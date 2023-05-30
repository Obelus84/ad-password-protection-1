#pragma once
#include "stdafx.h"
#include <vector>

class groups
{
public:
	groups(std::wstring accountName,bool debug);
	//~groups();*/
	const std::wstring CompareGroups(const std::wstring regGroups, const std::vector<std::wstring> adGroups) const;
	//const std::wstring GetADGroupst() const;
	const std::vector<std::wstring> GetADGroups() const;
private:
	 std::wstring accountName;
	 bool debug;
};
