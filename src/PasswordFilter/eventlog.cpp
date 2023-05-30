#include "stdafx.h"
#include "eventlog.h"
#include <vector>
#include <fstream>
#include <Shlwapi.h>
#include "messages.h"
#include <mutex>
#include <ctime>
#include <iomanip>


HANDLE eventlog::hlog;
std::mutex eventlog::lock;

eventlog::eventlog()
= default;

eventlog::~eventlog()
{
	if (hlog)
	{
		DeregisterEventSource(hlog);
	}
}

void eventlog::init()
{
	try {
		int count = 0;

		while (getHandle() == NULL)
		{
			if (count > 30)
			{
				std::string message = "Event log initialization error\r\n";
				message += "Could not obtain a handle to the event log service";
				OutputDebugStringA(message.c_str());
				break;
			}

			Sleep(1000);
			count++;
		}

		if (hlog != NULL)
		{
			ReportEvent(hlog, EVENTLOG_INFORMATION_TYPE, 0, MSG_AGENT_INITIALIZED, NULL, 0, 0, NULL, NULL);
		}
	}
	catch (std::exception const& e)
	{
		std::string message = "Event log initialization error\r\n";
		message += e.what();
		OutputDebugStringA(message.c_str());
	}
	catch (...)
	{
		std::string message = "Event log initialization error\r\n";
		message += "No exception information was available";
		OutputDebugStringA(message.c_str());
	}
}

void eventlog::writeToFileLog(const std::wstring accountName, const std::string& message)
{
	std::ofstream outfile;
	const LPCWSTR sourcepath = L"%windir%\\logs\\lpp.log";

	const int bufSize = ExpandEnvironmentStrings(sourcepath, NULL, 0);

	if (bufSize == 0)
	{
		// error
		return;
	}

	std::vector<wchar_t> buf(bufSize);
	const int result = ExpandEnvironmentStrings(sourcepath, &buf[0], bufSize);

	if (bufSize == 0 || result != bufSize)
	{
		// error
		return;
	}
	std::time_t t = std::time(nullptr);
	std::tm tm;
	localtime_s(&tm, &t);

	std::wstring format = L"%Y-%m-%d %H:%M:%S";
	wchar_t buffer[100];
	std::wcsftime(buffer, 100, format.c_str(), &tm);

	std::wstring datetime(buffer);

	outfile.open(buf.data(), std::ios_base::app);
	outfile << std::string(datetime.begin(),datetime.end()) << "     " << std::string(accountName.begin(),accountName.end()) << "     " << message;
	outfile.close();
}

void eventlog::writeToFileLog(const std::wstring accountName, const std::wstring& message)
{
	std::wofstream outfile;
	const LPCWSTR sourcepath = L"%windir%\\logs\\lpp.log";

	const int bufSize = ExpandEnvironmentStrings(sourcepath, NULL, 0);

	if (bufSize == 0)
	{
		// error
		return;
	}

	std::vector<wchar_t> buf(bufSize);
	const int result = ExpandEnvironmentStrings(sourcepath, &buf[0], bufSize);

	if (bufSize == 0 || result != bufSize)
	{
		// error
		return;
	}

	std::time_t t = std::time(nullptr);
	std::tm tm;
	localtime_s(&tm,&t);

	std::wstring format = L"%Y-%m-%d %H:%M:%S";

	wchar_t buffer[100];
	std::wcsftime(buffer, 100, format.c_str(), &tm);

	std::wstring datetime(buffer);

	outfile.open(buf.data(), std::ios_base::app);
	outfile << datetime << L"     " << accountName << L"     " << message;
	outfile.close();
}

HANDLE eventlog::getHandle()
{
	if (eventlog::hlog == NULL)
	{
		try
		{
			lock.lock();

			if (eventlog::hlog == NULL)
			{
				eventlog::hlog = RegisterEventSource(NULL, L"LithnetPasswordProtection");

				if (eventlog::hlog == NULL)
				{
					const std::wstring message = L"Could not register event source LithnetPasswordProtection: " + std::to_wstring(GetLastError()) + L"\r\n";
					writeToFileLog(L"",message);
				}
			}
		}
		catch (...)
		{
			lock.unlock();
			throw;
		}

		lock.unlock();
	}

	return eventlog::hlog;
}

void eventlog::logw(const WORD &severity, const DWORD &eventID, const int argCount, ...)
{
	auto* pInsertStrings = new LPCWSTR[argCount];

	va_list(arglist);
	va_start(arglist, argCount);

	for (int i = 0; i < argCount; i++)
	{
		pInsertStrings[i] = va_arg(arglist, LPCWSTR);
	}

	va_end(arglist);

	const HANDLE hevent = getHandle();

	if (hevent)
	{
		ReportEvent(hevent, severity, 0, eventID, NULL, argCount, 0, pInsertStrings, NULL);
	}

	delete[] pInsertStrings;
}

void eventlog::log(const WORD &severity, const DWORD &eventID, const int argCount, ...)
{
	auto* pInsertStrings = new LPCSTR[argCount];

	va_list(arglist);
	va_start(arglist, argCount);

	for (int i = 0; i < argCount; i++)
	{
		pInsertStrings[i] = va_arg(arglist, LPCSTR);
	}

	va_end(arglist);

	const HANDLE hevent = getHandle();

	if (hevent)
	{
		ReportEventA(hevent, severity, 0, eventID, NULL, argCount, 0, pInsertStrings, NULL);
	}

	delete[] pInsertStrings;
}
