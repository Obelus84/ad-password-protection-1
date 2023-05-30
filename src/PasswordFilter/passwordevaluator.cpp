#include "stdafx.h"
#include "registry.h"
#include "messages.h"
#include "eventlog.h"
#include "stringnormalization.h"
#include "passwordevaluator.h"
#include <regex>
#include <Shlwapi.h>
#include "utils.h"
#include "complexityevaluator.h"
#include "v3store.h"
#include "groups.h"

int ProcessPassword(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation)
{	
	
	std::wstring policy = L"Default";
	std::wstring mGroup = L"";
	registry reg;
	registry groupReg;
	bool debug = reg.GetDebug();
	groups gp(accountName,debug);

	if (debug) { eventlog::getInstance().writeToFileLog(accountName, L"Started processing password " + std::wstring(setOperation ? L"Set" : L"Change") + L" (" + fullName + L")\n"); }

	
	bool groupMatching = (reg.GetRegValue(REG_VALUE_GROUPMATCH, 0) != 0);
	bool groupMatchingRequired = (reg.GetRegValue(REG_VALUE_GROUPMATCH_REQUIRED, 0) != 0);
	if (debug) {eventlog::getInstance().writeToFileLog(accountName,"value of group matching: " + std::string(groupMatching ? "True\n" : "False\n"));}
	if (debug) {eventlog::getInstance().writeToFileLog(accountName,"value of group match required: " + std::string(groupMatchingRequired ? "True\n" : "False\n"));}

	if (groupMatching) {
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Group matching is on, groups will be processed\n");}

		if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"+++Getting Registry Groups\n");}
		std::wstring regGroups = reg.GetRegGroups(L"");

		if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"++++Registry Groups: " + regGroups + L"\n");}

		if (regGroups != L"") {
			if (debug) { eventlog::getInstance().writeToFileLog(accountName, L"+++Getting ADGroups\n"); }
			const std::vector<std::wstring> adGroups = gp.GetADGroups();
			if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"++++Comparing groups\n");}
			mGroup = gp.CompareGroups(regGroups, adGroups);
			if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Matching groups: " + mGroup + L"\n");}

			if (mGroup == L"" && groupMatchingRequired) {
				if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"There were no matching groups and Group Matching is required filter will not be evaluated\n");}
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_GROUP_MATCHING_REQUIRED, 1, accountName.c_str());
				return PASSWORD_APPROVED;
			}
			else if (mGroup != L"") {
				if (mGroup.find(L",") != std::wstring::npos) {
					if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Found multiple matches: " + mGroup + L"\n");}
					for each (std::wstring gr in SplitString(mGroup, L',')) {
						if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Checking if policy for group |" + gr + L"| is enabled" + L"\n");}
						policy = reg.GetRegGroupsPolicy(gr, L"Default");
						groupReg = registry(policy);
						bool polEnabled = groupReg.GetRegValue(REG_VALUE_ENABLED, 0);
						if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Checking if policy " + groupReg.GetPolicyName() + L" is enabled:" + std::wstring(polEnabled ? L"True\n" : L"False\n")); }
						if (groupReg.GetRegValue(REG_VALUE_ENABLED, 0) == 1) {
							if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Matched enabled policy found Group: " + gr + L"  Policy: " + groupReg.GetPolicyName() + L"\n"); }
							break;
						}
					}
					if ((groupReg.GetRegValue(REG_VALUE_ENABLED, 0) == 0) && groupMatchingRequired) {
						if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"There were no matched enabled groups and Group Matching is required\n");}
						eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_GROUP_MATCHING_REQUIRED, 2, accountName.c_str(),mGroup.c_str());
						return PASSWORD_APPROVED;
					}
					else if((groupReg.GetRegValue(REG_VALUE_ENABLED, 0) == 0)){
						groupReg = registry(L"Default");
					}

				}
				else {
					if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Only found one group match: |" + mGroup + L"|\n");}
					policy = reg.GetRegGroupsPolicy(mGroup, L"Default");
					if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"after finding group got policy " + policy + L"\n");}
					groupReg = registry(policy);

					if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"trying to attach to :: " + policy + L" got " + groupReg.GetPolicyName() + L"\n");}
					bool testen = groupReg.GetRegValue(REG_VALUE_ENABLED, 0);
					if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"TEST STRING: " + std::to_wstring(testen) + L"\n");
					}
					if (groupMatching && groupMatchingRequired) {
						if (groupReg.GetRegValue(REG_VALUE_ENABLED, 0) != 1)
						{
							if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Group " + mGroup + L" policy disabled: " + std::to_wstring(testen) + L"\n");}
							eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_GROUP_MATCHING_REQUIRED, 2,  accountName.c_str(), mGroup.c_str());
							return PASSWORD_APPROVED;
						}
					}
					else if((groupReg.GetRegValue(REG_VALUE_ENABLED, 0) == 0)) {
						groupReg = registry(L"Default");
					}
				}
			}
			else {
				if (debug) { eventlog::getInstance().writeToFileLog(accountName, "No matching groups were found, group matching is not required. fillter will continue with default policy\n"); }
			}
		}
		else if (groupMatchingRequired) {
			if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Group matching is required but no valid group options were found in the settings (This should be considered an error have you setup up policies yet?). Password for (" + accountName + L") will not be evaluated\n");}
			eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_GROUP_MATCHING_REQUIRED, 1, accountName.c_str());
			return PASSWORD_APPROVED;
		}
	} 
	else
	{
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Group matching is off running default policy\n");}
		groupReg = registry(L"Default");
	}

	if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Ulitimate policy decision: " + groupReg.GetPolicyName() + L"\n");}
	if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Policy Group: " + groupReg.GetPolicyName() + L"\n");	}
	if (debug) {eventlog::getInstance().writeToFileLog(accountName,L"Policy Group for processing: " + groupReg.GetPolicyName() + L"\n");}
	v3store store(groupReg.GetStoreValue(std::to_wstring(groupReg.GetRegValue(L"Store", 0)), L"no list"));

	bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;

	if (store.storeBasePath == L"no list") {
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,"error getting store");}
		eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_ON_ERROR, 1, setOperation ? L"set" : L"change");
		return FILTER_ERROR;
	}
	if (simulate) {
		eventlog::getInstance().logw(EVENTLOG_INFORMATION_TYPE, MSG_PROCESSING_REQUEST, 5, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), policy.c_str(), store.storeBasePath.c_str());
	}
	else {
		eventlog::getInstance().logw(EVENTLOG_INFORMATION_TYPE, MSG_PROCESSING_REQUEST, 5, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), policy.c_str(), store.storeBasePath.c_str());
	}
	if (!ProcessPasswordLength(password, accountName, fullName, setOperation, groupReg))
	{
		return PASSWORD_REJECTED_LENGTH;
	}
	if (groupReg.GetRegValue(REG_VALUE_CATLENGTHBASEDCOMPLEXITY, 0) == 1) {
		if (!ProcessPasswordComplexityThreshold(password, accountName, fullName, setOperation, groupReg))
		{
			return PASSWORD_REJECTED_COMPLEXITY_THRESHOLD;
		}
	}
	else{
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,"Skipping ProcessPasswordComplexityThreshold because it's disabled\n");}
	}
	if (groupReg.GetRegValue(REG_VALUE_CATPASSWORDCOMPLEXITY, 0) == 1) {
		if (!ProcessPasswordComplexityPoints(password, accountName, fullName, setOperation, groupReg))
		{
			return PASSWORD_REJECTED_COMPLEXITY_POINTS;
		}
	} else {
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,"Skipping ProcessPasswordComplexityPoints because it's disabled\n");}
	}
	if (groupReg.GetRegValue(REG_VALUE_CATREGEX, 0) == 1) {
		if (!ProcessPasswordRegexApprove(password, accountName, fullName, setOperation, groupReg))
		{
			return PASSWORD_REJECTED_REGEX_APPROVE;
		}

		if (!ProcessPasswordRegexReject(password, accountName, fullName, setOperation, groupReg))
		{
			return PASSWORD_REJECTED_REGEX_REJECT;
		}
	}
	else {
		if (debug) {eventlog::getInstance().writeToFileLog(accountName,"Skipping ProcessPasswordRegex because it's disabled\n");}
	}

	if (!ProcessPasswordDoesntContainAccountName(password, accountName, fullName, setOperation, groupReg))
	{
		return PASSWORD_REJECTED_CONTAINS_ACCOUNT_NAME;
	}

	if (!ProcessPasswordDoesntContainFullName(password, accountName, fullName, setOperation, groupReg))
	{
		return PASSWORD_REJECTED_CONTAINS_FULL_NAME;
	}

	if (!ProcessPasswordRaw(password, accountName, fullName, setOperation, groupReg, store))
	{
		return PASSWORD_REJECTED_BANNED;
	}

	if (!ProcessPasswordNormalizedWordStore(password, accountName, fullName, setOperation, groupReg, store))
	{
		return PASSWORD_REJECTED_BANNED_NORMALIZED_WORD;
	}

	if (!ProcessPasswordNormalizedPasswordStore(password, accountName, fullName, setOperation, groupReg, store))
	{
		return PASSWORD_REJECTED_BANNED_NORMALIZED_PASSWORD;
	}


	OutputDebugString(L"Password was approved by all modules");

	if (simulate) {
		eventlog::getInstance().logw(EVENTLOG_SUCCESS, MSG_PASSWORD_APPROVED, 5, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), policy.c_str(), store.storeBasePath.c_str());
	}
	else {
		eventlog::getInstance().logw(EVENTLOG_SUCCESS, MSG_PASSWORD_APPROVED, 5, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), policy.c_str(), store.storeBasePath.c_str());
	}
	

	return PASSWORD_APPROVED;
}

BOOLEAN ProcessPasswordRaw(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg, v3store &store)
{
	if ((setOperation && reg.GetRegValue(REG_VALUE_CHECKBANNEDPASSWORDONSET, 0) != 0) || 
		(!setOperation && reg.GetRegValue(REG_VALUE_CHECKBANNEDPASSWORDONCHANGE, 0) != 0))
	{
		OutputDebugString(L"Checking raw password");

		if (store.IsPasswordInPasswordStore(password))
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Rejected password as it was found in the banned store");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED, 4, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED, 4, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
			return FALSE;
		}

		OutputDebugString(L"Raw password did not match any existing hashes");
	}

	return TRUE;
}

BOOLEAN ProcessPasswordNormalizedPasswordStore(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg, v3store &store)
{	
	if (setOperation && reg.GetRegValue(REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET, 0) != 0 ||
		!setOperation && reg.GetRegValue(REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE, 0) != 0 )
	{
		bool result = TRUE;

		const SecureArrayT<WCHAR> normalizedPassword = NormalizePassword(password);
		OutputDebugString(L"Checking normalized password");

		result = store.IsPasswordInPasswordStore(normalizedPassword);
		if (result)
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Rejected normalized password as it was found in the banned password store");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_PASSWORD, 4, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_PASSWORD, 4, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
		}
		else
		{
			OutputDebugString(L"Normalized password did not match any existing hashes in the password store");
		}

		return !result;
	}

	return TRUE;
}


BOOLEAN ProcessPasswordNormalizedWordStore(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg, v3store &store)
{
	if (setOperation && reg.GetRegValue(REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET, 0) != 0 ||
		!setOperation && reg.GetRegValue(REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE, 0) != 0)
	{
		bool result = TRUE;

		const SecureArrayT<WCHAR> normalizedPassword = NormalizePassword(password);
		OutputDebugString(L"Checking normalized password");

		result = store.IsPasswordInWordStore(normalizedPassword);
		if (result)
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Rejected normalized password as it was found in the banned word store");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_WORD, 4, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_WORD, 4, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), store.storeBasePath.c_str());
			}
		}
		else
		{
			OutputDebugString(L"Normalized password did not match any existing hashes in the word store");
		}

		return !result;
	}

	return TRUE;
}


BOOLEAN ProcessPasswordLength(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg)
{
	const int minLength = reg.GetRegValue(REG_VALUE_MINIMUMLENGTH, 0);
	const int maxLength = reg.GetRegValue(REG_VALUE_MAXIMUMLENGTH, 0);

	if (minLength > 0)
	{
		OutputDebugString(L"Checking minimum length");

		if (wcslen(password) < minLength)
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Rejected password as it did not meet the minimum length requirements");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_MINLENGTH, 5, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), std::to_wstring(wcslen(password)).c_str(), std::to_wstring(minLength).c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_MINLENGTH, 5, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), std::to_wstring(wcslen(password)).c_str(), std::to_wstring(minLength).c_str());
			}
			return FALSE;
		}

		OutputDebugString(L"Password met the minimum length requirements");

	}
	if (maxLength > 0 && maxLength < 256 && maxLength > minLength)
	{
		OutputDebugString(L"Checking maximum length");

		if (wcslen(password) > maxLength)
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Rejected password as it was greater than the maximum length requirements");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_MAXLENGTH, 5, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str(), std::to_wstring(wcslen(password)).c_str(), std::to_wstring(maxLength).c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_MAXLENGTH, 5, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str(), std::to_wstring(wcslen(password)).c_str(), std::to_wstring(maxLength).c_str());
			}
			return FALSE;
		}

		OutputDebugString(L"Password was less than the maximum length requirements");

	}
	return TRUE;
}

BOOLEAN ProcessPasswordDoesntContainAccountName(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg)
{
	int flag = reg.GetRegValue(REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, 0);

	if (flag != 0 && accountName.length() > 3)
	{
		OutputDebugString(L"Checking to see if password contains account name");

		for each (std::wstring substring in SplitString(accountName, L' '))
		{
			if (substring.length() > 3)
			{
				if (StrStrI(password, substring.c_str()) != NULL)
				{
					bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
					OutputDebugString(L"Rejected password as it contained part of the account name");
					if (simulate) {
						eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_CONTAINS_ACCOUNTNAME, 3, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str());
					}
					else {
						eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_CONTAINS_ACCOUNTNAME, 3, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str());
					}
					return FALSE;
				}
			}
		}

		OutputDebugString(L"Password did not contain part of the account name");
	}

	return TRUE;
}

BOOLEAN ProcessPasswordDoesntContainFullName(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg)
{
	int flag = reg.GetRegValue(REG_VALUE_PASSWORDDOESNTCONTAINFULLNAME, 0);

	if (flag != 0 && fullName.length() > 3)
	{
		OutputDebugString(L"Checking to see if password contains full name");

		for each (std::wstring substring in SplitString(fullName, L' '))
		{
			if (substring.length() > 3)
			{
				if (StrStrI(password, substring.c_str()) != NULL)
				{
					bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
					OutputDebugString(L"Rejected password as it contained part of the full name");
					if (simulate) {
						eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_CONTAINS_DISPLAYNAME, 3, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str());
					}
					else {
						eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_CONTAINS_DISPLAYNAME, 3, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str());
					}
					return FALSE;
				}
			}
		}

		OutputDebugString(L"Password did not contain any part of the full name");
	}

	return TRUE;
}

BOOLEAN ProcessPasswordRegexApprove(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg)
{
	std::wstring regex = reg.GetRegValue(REG_VALUE_REGEXAPPROVE, L"");

	if (regex.length() > 0)
	{
		OutputDebugString(L"Checking for regular expression approval match");

		std::wregex e(regex, std::regex_constants::icase);

		if (!std::regex_search(password.get(), e))
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Password did not match the approval regular expression");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_APPROVAL_REGEX, 3, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str());
			}
			else {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_APPROVAL_REGEX, 3, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str());
			}
			return FALSE;
		}

		OutputDebugString(L"Password met the approval regular expression");
	}

	return TRUE;
}

BOOLEAN ProcessPasswordRegexReject(const SecureArrayT<WCHAR> &password, const std::wstring &accountName, const std::wstring &fullName, const BOOLEAN &setOperation, const registry &reg)
{
	std::wstring regex = reg.GetRegValue(REG_VALUE_REGEXREJECT, L"");

	if (regex.length() > 0)
	{
		OutputDebugString(L"Checking for regular expression rejection match");

		std::wregex e(regex, std::regex_constants::icase);

		if (std::regex_search(password.get(), e))
		{
			bool simulate = reg.GetRegValue(REG_VALUE_SIMULATE, 0) != 0;
			OutputDebugString(L"Password matched the rejection regular expression");
			if (simulate) {
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_REJECTION_REGEX, 3, setOperation ? L"SIMULATE(set)" : L"SIMULATE(change)", accountName.c_str(), fullName.c_str());
			} else { 
				eventlog::getInstance().logw(EVENTLOG_WARNING_TYPE, MSG_PASSWORD_REJECTED_REJECTION_REGEX, 3, setOperation ? L"set" : L"change", accountName.c_str(), fullName.c_str()); 
			}
			return FALSE;
		}

		OutputDebugString(L"Password not did match the rejection regular expression");
	}

	return TRUE;
}
