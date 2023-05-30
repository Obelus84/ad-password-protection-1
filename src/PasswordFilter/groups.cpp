

#include "stdafx.h"
#include "eventlog.h"
#include "groups.h"
#include "utils.h"
#include<algorithm>
#include <lm.h>

groups::groups(std::wstring accountName,bool debug) {
    this->accountName = accountName;
    this->debug = debug;
}

const std::wstring groups::CompareGroups(const std::wstring regGroups, const std::vector<std::wstring> adGroups) const {
    std::wstring ret = L"";
    bool b;
    try
    {
        for each (std::wstring rG in SplitString(regGroups, L','))
        {
            if (debug) {eventlog::getInstance().writeToFileLog(accountName, L"Reg group:::" + rG + L"\n"); }
            std::transform(rG.begin(), rG.end(), rG.begin(), ::tolower);
            b = std::find(adGroups.begin(), adGroups.end(), rG) != adGroups.end();
            if (b)
            {
                ret += rG + L",";
                if (debug) { eventlog::getInstance().writeToFileLog(accountName, L"++++Found Match: " + rG + L"\n"); }
            }
        }
        if (ret != L"") {
            ret = ret.erase(ret.length() - 1);
            return ret;
        }
        else {
            return L"";
        }
    }    
    catch (const std::exception& e)
    {        
        std::string message = "Error occureed in group matching\r\n";
        message += e.what();
        message += "\r\n";
        OutputDebugStringA(message.c_str());
        if (debug) { eventlog::getInstance().writeToFileLog(accountName, message.c_str());}
    }
    return L"noMatch";
}



const std::vector<std::wstring> groups::GetADGroups() const
{
    DWORD bufferSize = 0;
    LPBYTE buffer = NULL;
    DWORD entries_read = 0;
    DWORD total_entries = 0;

    NET_API_STATUS result = NetUserGetGroups(NULL, accountName.c_str(), 0, (LPBYTE*)&buffer, MAX_PREFERRED_LENGTH, &entries_read, &total_entries);

    std::vector<std::wstring> groupNames;
    if (result == NERR_Success || result == ERROR_MORE_DATA)
    {
        GROUP_USERS_INFO_0* groupInfo = (GROUP_USERS_INFO_0*)buffer;
        for (DWORD i = 0; i < entries_read; i++)
        {
            std::wstring wGroupName = groupInfo[i].grui0_name;
            std::transform(wGroupName.begin(), wGroupName.end(), wGroupName.begin(), ::tolower);
            if (debug) { eventlog::getInstance().writeToFileLog(L"",L"AD Group: " + wGroupName + L"\n"); }
            groupNames.push_back(wGroupName);
        }
    }
    NetApiBufferFree(buffer);
    return groupNames;
}


