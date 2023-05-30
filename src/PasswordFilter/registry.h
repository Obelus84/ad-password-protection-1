#pragma once
#include "stdafx.h"

static LPCWSTR REG_BASE_SETTINGS_KEY = L"SOFTWARE\\Lithnet\\PasswordFilter";
static LPCWSTR REG_BASE_POLICY_KEY = L"SOFTWARE\\Policies\\Lithnet\\PasswordFilter";
static LPCWSTR REG_BASE_GROUPS = L"SOFTWARE\\Policies\\Lithnet\\Groups";
static LPCWSTR REG_BASE_LISTS = L"SOFTWARE\\Policies\\Lithnet\\Lists";

static LPCWSTR REG_VALUE_STOREPATH = L"Store";
static LPCWSTR REG_VALUE_ENABLED = L"Enabled";
static LPCWSTR REG_VALUE_SIMULATE= L"Simulate";
static LPCWSTR REG_VALUE_GROUPMATCH = L"GroupMatching";
static LPCWSTR REG_VALUE_GROUPMATCH_REQUIRED = L"GroupMatchRequired";

static LPCWSTR REG_VALUE_CATPASSWORDCOMPLEXITY = L"CatPasswordComplexity";
static LPCWSTR REG_VALUE_CATREGEX = L"CatRegex";
static LPCWSTR REG_VALUE_CATLENGTHBASEDCOMPLEXITY = L"CatLenghtBasedComplexity";

static LPCWSTR REG_VALUE_MINIMUMLENGTH = L"MinimumLength";
static LPCWSTR REG_VALUE_MAXIMUMLENGTH = L"MaximumLength";

static LPCWSTR REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE = L"CheckNormalizedPasswordNotInBannedPasswordStoreOnChange";
static LPCWSTR REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET = L"CheckNormalizedPasswordNotInBannedPasswordStoreOnSet";
static LPCWSTR REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE = L"CheckNormalizedPasswordNotInBannedWordStoreOnChange";
static LPCWSTR REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET = L"CheckNormalizedPasswordNotInBannedWordStoreOnSet";
static LPCWSTR REG_VALUE_CHECKBANNEDPASSWORDONCHANGE = L"CheckPasswordNotInBannedPasswordStoreOnChange";
static LPCWSTR REG_VALUE_CHECKBANNEDPASSWORDONSET = L"CheckPasswordNotInBannedPasswordStoreOnSet";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSPERCHAR = L"ComplexityPointsPerCharacter";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSPERLOWER = L"ComplexityPointsPerLower";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSPERNUMBER = L"ComplexityPointsPerNumber";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSPERSYMBOL = L"ComplexityPointsPerSymbol";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSPERUPPER = L"ComplexityPointsPerUpper";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSREQUIRED = L"ComplexityPointsRequired";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER = L"ComplexityPointsUseOfLower";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER = L"ComplexityPointsUseOfNumber";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL = L"ComplexityPointsUseOfSymbol";
static LPCWSTR REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER = L"ComplexityPointsUseOfUpper";

static LPCWSTR REG_VALUE_CTCHARSETSREQUIRED = L"CharsetsRequired";
static LPCWSTR REG_VALUE_CTREQUIRESLOWER = L"RequiresLower";
static LPCWSTR REG_VALUE_CTREQUIRESNUMBER = L"RequiresNumber";
static LPCWSTR REG_VALUE_CTREQUIRESSYMBOL = L"RequiresSymbol";
static LPCWSTR REG_VALUE_CTREQUIRESSYMBOLORNUMBER = L"RequiresSymbolOrNumber";
static LPCWSTR REG_VALUE_CTREQUIRESUPPER = L"RequiresUpper";

static LPCWSTR REG_VALUE_CT1 = L"ComplexityThreshold1";
static LPCWSTR REG_VALUE_CT1CHARSETSREQUIRED = L"ComplexityThreshold1CharsetsRequired";
static LPCWSTR REG_VALUE_CT1REQUIRESLOWER = L"ComplexityThreshold1RequiresLower";
static LPCWSTR REG_VALUE_CT1REQUIRESNUMBER = L"ComplexityThreshold1RequiresNumber";
static LPCWSTR REG_VALUE_CT1REQUIRESSYMBOL = L"ComplexityThreshold1RequiresSymbol";
static LPCWSTR REG_VALUE_CT1REQUIRESSYMBOLORNUMBER = L"ComplexityThreshold1RequiresSymbolOrNumber";
static LPCWSTR REG_VALUE_CT1REQUIRESUPPER = L"ComplexityThreshold1RequiresUpper";

static LPCWSTR REG_VALUE_CT2 = L"ComplexityThreshold2";
static LPCWSTR REG_VALUE_CT2CHARSETSREQUIRED = L"ComplexityThreshold2CharsetsRequired";
static LPCWSTR REG_VALUE_CT2REQUIRESLOWER = L"ComplexityThreshold2RequiresLower";
static LPCWSTR REG_VALUE_CT2REQUIRESNUMBER = L"ComplexityThreshold2RequiresNumber";
static LPCWSTR REG_VALUE_CT2REQUIRESSYMBOL = L"ComplexityThreshold2RequiresSymbol";
static LPCWSTR REG_VALUE_CT2REQUIRESSYMBOLORNUMBER = L"ComplexityThreshold2RequiresSymbolOrNumber";
static LPCWSTR REG_VALUE_CT2REQUIRESUPPER = L"ComplexityThreshold2RequiresUpper";

static LPCWSTR REG_VALUE_CT3 = L"ComplexityThreshold3";
static LPCWSTR REG_VALUE_CT3CHARSETSREQUIRED = L"ComplexityThreshold3CharsetsRequired";
static LPCWSTR REG_VALUE_CT3REQUIRESLOWER = L"ComplexityThreshold3RequiresLower";
static LPCWSTR REG_VALUE_CT3REQUIRESNUMBER = L"ComplexityThreshold3RequiresNumber";
static LPCWSTR REG_VALUE_CT3REQUIRESSYMBOL = L"ComplexityThreshold3RequiresSymbol";
static LPCWSTR REG_VALUE_CT3REQUIRESSYMBOLORNUMBER = L"ComplexityThreshold3RequiresSymbolOrNumber";
static LPCWSTR REG_VALUE_CT3REQUIRESUPPER = L"ComplexityThreshold3RequiresUpper";

static LPCWSTR REG_VALUE_REGEXAPPROVE = L"RegexApprove";
static LPCWSTR REG_VALUE_REGEXREJECT = L"RegexReject";

static LPCWSTR REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME = L"ValidatePasswordDoesntContainAccountName";
static LPCWSTR REG_VALUE_PASSWORDDOESNTCONTAINFULLNAME = L"ValidatePasswordDoesntContainFullName";


class registry
{
private:
	std::wstring policyGroup;
	std::wstring settingsKeyName;
	std::wstring policyKeyName;
	std::wstring policyGroups;
	std::wstring policyLists;
	bool debug;

public:
	registry();
	registry(std::wstring policyGroup);
	~registry();
	std::wstring GetRegValue(const std::wstring & valueName, const std::wstring & defaultValue) const;
	DWORD GetRegValue(const std::wstring & valueName, DWORD defaultValue) const;
	static registry GetRegistryForUser(const std::wstring & user);
	const std::wstring GetRegGroups(const std::wstring defaultValue) const;
	const std::wstring GetRegGroupsPolicy(const std::wstring& valueName, const std::wstring defaultValue) const;
	const std::wstring GetStoreValue(const std::wstring valueName, const std::wstring defaultValue) const;
	std::wstring GetPolicyName();
	bool registry::GetDebug();
private:
	DWORD GetPolicyOrSettingsValue(const std::wstring & valueName, DWORD defaultValue) const;
	const std::wstring GetKeyName(LPCWSTR& key) const;
	const std::wstring GetPolicyOrSettingsValue(const std::wstring & valueName, const std::wstring & defaultValue) const;
	const std::wstring GetValueString(DWORD & dwBufferSize, const std::wstring & keyName, const std::wstring & valueName, const std::wstring & defaultValue) const;
	const std::wstring GetDefaultValueString(DWORD& dwBufferSize, const std::wstring& keyName, const std::wstring& defaultValue) const;
	wchar_t* GetDefaultValueString(DWORD& dwBufferSize, const std::wstring& keyName,  wchar_t* defaultValue) const;
};


