MessageIdTypedef=DWORD

SeverityNames=(Success=0x0:STATUS_SEVERITY_SUCCESS
Informational=0x1:STATUS_SEVERITY_INFORMATIONAL
Warning=0x2:STATUS_SEVERITY_WARNING
Error=0x3:STATUS_SEVERITY_ERROR
)

FacilityNames=(System=0x0:FACILITY_SYSTEM
Runtime=0x2:FACILITY_RUNTIME
Stubs=0x3:FACILITY_STUBS
Io=0x4:FACILITY_IO_ERROR_CODE
)

LanguageNames=(English=0x409:MSG00409)

; // The following are message definitions.

MessageId=0x1
Severity=Error
Facility=Runtime
SymbolicName=MSG_UNEXPECTEDERROR
Language=English
An unexpected error occurred.
%1
.

MessageId=0x2
Severity=Warning
Facility=Io
SymbolicName=MSG_AGENT_DISABLED
Language=English
The password filter is currently disabled and has not evaluated the password change request.%n
Disabled at: %1
.

MessageId=0x20
Severity=Warning
Facility=Io
SymbolicName=MSG_GROUP_MATCHING_REQUIRED
Language=English
Password reset for %1 was skipped because group matching is required and user is not a member of any potential enabled groups.%n
Groups Checked: %2
.

MessageId=0x21
Severity=Warning
Facility=Io
SymbolicName=MSG_GROUP_DISABLED
Language=English
The password filter %1 disabled, password filters for %2 will not be evaluated.%n
.

MessageId=0x3
Severity=Success
Facility=Io
SymbolicName=MSG_AGENT_INITIALIZED
Language=English
The password filter has been successfully loaded.
.

MessageId=0x4
Severity=Success
Facility=System
SymbolicName=MSG_PROCESSING_REQUEST
Language=English
Processing password request%n
Action: %1%n
UserName: %2%n
Full Name: %3%n
Poilcy: %4%n
List: %5%n
Status Processing
.

MessageId=0x5
Severity=Success
Facility=System
SymbolicName=MSG_PASSWORD_APPROVED
Language=English
Completed password request%n
Action: %1%n
UserName: %2%n
Full Name: %3%n
Policy: %4%n
List: %5%n
Status Completed
.

MessageId=0x8
Severity=Error
Facility=Runtime
SymbolicName=MSG_WIN32ERROR
Language=English
An unexpected error occurred.
Error code: %1%n
Message: %2
.

MessageId=0x9
Severity=Error
Facility=Runtime
SymbolicName=MSG_STOREERROR
Language=English
There was a problem opening the store file. Check that the store folder exists and is accessible%n%n
Error code: %1
.

MessageId=0x2001
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_ON_ERROR
Language=English
The password %1 request was rejected. The module is configured to deny password requests when an error occurs.
.

MessageId=0x2002
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_MINLENGTH
Language=English
The password %1 request for %2 (%3) was rejected because its length (%4) did not meet the minimum configured length (%5).
.

MessageId=0x2012
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_MAXLENGTH
Language=English
The password %1 request for %2 (%3) was rejected because its length (%4) greather than the maximum configured length (%5).
.

MessageId=0x2003
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_BANNED
Language=English
The password %1 request for %2 (%3) was rejected because it matched a password in the compromised password store%n
%4.
.

MessageId=0x2004
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_PASSWORD
Language=English
The password %1 request for %2 (%3) was rejected after being normalized because it matched a password in the compromised password store%n
%4.
.

MessageId=0x2005
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_APPROVAL_REGEX
Language=English
The password %1 request for %2 (%3) was rejected because it did not match the approval regular expression%n
%4.
.

MessageId=0x2006
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_REJECTION_REGEX
Language=English
The password %1 request for %2 (%3) was rejected because it matched the rejection regular expression%n
%4.
.

MessageId=0x2007
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_NOT_ENOUGH_POINTS
Language=English
The password %1 request for %2 (%3) was rejected because it achieved only %4 of the required %5 complexity points.
.

MessageId=0x2008
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_BELOW_THRESHOLD
Language=English
The password %1 request for %2 (%3) was rejected because it did not meet the complexity requirements of a password below the specified threshold.
.

MessageId=0x2009
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_ABOVE_THRESHOLD
Language=English
The password %1 request for %2 (%3) was rejected because it did not meet the complexity requirements of a password above the specified threshold.
.

MessageId=0x200A
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_CONTAINS_ACCOUNTNAME
Language=English
The password %1 request for %2 (%3) was rejected because it contained the account name
.

MessageId=0x200B
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_CONTAINS_DISPLAYNAME
Language=English
The password %1 request for %2 (%3) was rejected because it contained at least part of the display name
.

MessageId=0x200C
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_THRESHOLD_COMPLEXITY
Language=English
The password %1 request for %2 (%3) was rejected because it did not meet the complexity requirements of a password of %4 characters.
.

MessageId=0x200D
Severity=Warning
Facility=System
SymbolicName=MSG_PASSWORD_REJECTED_BANNED_NORMALIZED_WORD
Language=English
The password %1 request for %2 (%3) was rejected after being normalized because it matched a password in the banned word store%N
%4.
.
