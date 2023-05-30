#include "stdafx.h"
#include "registry.h"
#include <memory>
#include "eventlog.h"

registry::registry()
{
	this->settingsKeyName = REG_BASE_SETTINGS_KEY;
	this->policyKeyName = REG_BASE_POLICY_KEY;
	this->policyGroups = REG_BASE_GROUPS;
	this->policyLists = REG_BASE_LISTS;
	this->debug = GetRegValue(L"Debug", 0);
}

registry::registry(std::wstring policyGroup)
{
	this->policyGroup = policyGroup;
	this->settingsKeyName = GetKeyName(REG_BASE_SETTINGS_KEY);
	this->policyKeyName = GetKeyName(REG_BASE_POLICY_KEY);
	this->policyGroups = REG_BASE_GROUPS;
	this->policyLists = REG_BASE_LISTS;
	this->debug = GetRegValue(L"Debug", 0);
}

registry::~registry()
= default;


std::wstring registry::GetRegValue(const std::wstring & valueName, const std::wstring & defaultValue) const
{
	return GetPolicyOrSettingsValue(valueName, defaultValue);
}
std::wstring registry::GetPolicyName()
{
	return policyGroup;
}
bool registry::GetDebug() {
	return debug;
}
const std::wstring registry::GetRegGroups(const std::wstring defaultValue) const
{
	DWORD dwBufferSize = 0;

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->policyGroups.c_str(),
		NULL,
		RRF_RT_REG_SZ,
		NULL,
		NULL,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return GetDefaultValueString(dwBufferSize, this->policyGroups, defaultValue);
	}
	return defaultValue;
}

const std::wstring registry::GetStoreValue(const std::wstring valueName, const std::wstring defaultValue) const
{
	DWORD dwBufferSize = 0;

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->policyLists.c_str(),
		valueName.c_str(),
		RRF_RT_REG_SZ,
		NULL,
		NULL,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return GetValueString(dwBufferSize, this->policyLists, valueName, defaultValue);
	}
	return defaultValue;
}

const std::wstring registry::GetRegGroupsPolicy(const std::wstring & valueName, const std::wstring defaultValue) const
{

	DWORD dwBufferSize = 0;
	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->policyGroups.c_str(),
		valueName.c_str(),
		RRF_RT_REG_SZ,
		NULL,
		NULL,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return GetValueString(dwBufferSize, this->policyGroups, valueName, defaultValue);
	}
	return defaultValue;
}
DWORD registry::GetRegValue(const std::wstring & valueName, DWORD defaultValue) const
{
	return GetPolicyOrSettingsValue(valueName, defaultValue);
}

registry registry::GetRegistryForUser(const std::wstring & user)
{
	return registry(user);
}

DWORD registry::GetPolicyOrSettingsValue(const std::wstring & valueName, DWORD defaultValue) const
{
	DWORD dwBufferSize(sizeof(DWORD));
	DWORD value(0);

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->policyKeyName.c_str(),
		valueName.c_str(),
		RRF_RT_DWORD,
		NULL,
		&value,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return value;
	}

	result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->settingsKeyName.c_str(),
		valueName.c_str(),
		RRF_RT_DWORD,
		NULL,
		&value,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return value;
	}

	return defaultValue;
}

const std::wstring registry::GetKeyName(LPCWSTR & key) const
{
	std::wstring name(key);
	if (!this->policyGroup.empty())
	{
		name += L"\\";
		name += this->policyGroup;
	}

	return name;
}

const std::wstring registry::GetPolicyOrSettingsValue(const std::wstring & valueName, const std::wstring & defaultValue) const
{
	DWORD dwBufferSize = 0;

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->policyKeyName.c_str(),
		valueName.c_str(),
		RRF_RT_REG_SZ,
		NULL,
		NULL,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return GetValueString(dwBufferSize, this->policyKeyName, valueName, defaultValue);
	}

	result = RegGetValue(HKEY_LOCAL_MACHINE,
		this->settingsKeyName.c_str(),
		valueName.c_str(),
		RRF_RT_REG_SZ,
		NULL,
		NULL,
		&dwBufferSize);

	if (result == ERROR_SUCCESS)
	{
		return GetValueString(dwBufferSize, this->settingsKeyName, valueName, defaultValue);
	}

	return defaultValue;
}

const std::wstring registry::GetValueString(DWORD & dwBufferSize, const std::wstring & keyName, const std::wstring & valueName, const std::wstring & defaultValue) const
{
	std::unique_ptr<WCHAR[]> szBuffer = std::make_unique<WCHAR[]>(dwBufferSize / sizeof(WCHAR));

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		keyName.c_str(),
		valueName.c_str(),
		RRF_RT_REG_SZ,
		NULL,
		&szBuffer[0],
		&dwBufferSize);

	if (result != ERROR_SUCCESS)
	{
		return defaultValue;
	}
	
	return std::wstring(szBuffer.get());
}
const std::wstring registry::GetDefaultValueString(DWORD & dwBufferSize, const std::wstring & keyName, const std::wstring & defaultValue) const
{
	std::unique_ptr<WCHAR[]> szBuffer = std::make_unique<WCHAR[]>(dwBufferSize / sizeof(WCHAR));

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		keyName.c_str(),
		NULL,
		RRF_RT_REG_SZ,
		NULL,
		&szBuffer[0],
		&dwBufferSize);

	if (result != ERROR_SUCCESS)
	{
		return defaultValue;
	}

	return std::wstring(szBuffer.get());
}
wchar_t* registry::GetDefaultValueString(DWORD & dwBufferSize, const std::wstring & keyName, wchar_t* defaultValue) const
{
	std::unique_ptr<WCHAR[]> szBuffer = std::make_unique<WCHAR[]>(dwBufferSize / sizeof(WCHAR));

	long result = RegGetValue(HKEY_LOCAL_MACHINE,
		keyName.c_str(),
		NULL,
		RRF_RT_REG_SZ,
		NULL,
		&szBuffer[0],
		&dwBufferSize);

	if (result != ERROR_SUCCESS)
	{
		return defaultValue;
	}

	return szBuffer.get();
}
