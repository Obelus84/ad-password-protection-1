Imports Microsoft.Win32

Public Class RegistryClass

    Public REG_BASE_GLOBAL_SETTINGS_KEY As String = "SOFTWARE\Policies\Lithnet\PasswordFilter"
    Public REG_BASE_POLICY_KEY As String = "SOFTWARE\Policies\Lithnet\PasswordFilter"
    Public REG_BASE_GROUPS = "SOFTWARE\Policies\Lithnet\Groups"
    Public REG_BASE_LISTS = "SOFTWARE\Policies\Lithnet\Lists"
    Public REG_BASE_LSA = "SYSTEM\CurrentControlSet\Control\Lsa"


    Public REG_VALUE_STOREPATH As String = "Store"
    Public REG_VALUE_ENABLED As String = "Enabled"
    Public REG_VALUE_SIMULATE As String = "Simulate"
    Public REG_VALUE_GROUPMATCH As String = "GroupMatching"
    Public REG_VALUE_GROUPMATCH_REQUIRED As String = "GroupMatchRequired"
    Public REG_VALUE_LSA_REGISTER As String = "Notification Packages"

    Public REG_VALUE_ALLOWPASSWORDSETONERROR As String = "AllowPasswordSetOnError"
    Public REG_VALUE_ALLOWPASSWORDCHANGEONERROR As String = "AllowPasswordChangeOnError"

    Public REG_VALUE_MINIMUMLENGTH As String = "MinimumLength"
    Public REG_VALUE_MAXIMUMLENGTH As String = "MaximumLength"

    Public REG_VALUE_CATPASSWORDCOMPLEXITY As String = "CatPasswordComplexity"
    Public REG_VALUE_CATREGEX As String = "CatRegex"
    Public REG_VALUE_CATLENGTHBASEDCOMPLEXITY As String = "CatLenghtBasedComplexity"

    Public REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE As String = "CheckNormalizedPasswordNotInBannedPasswordStoreOnChange"
    Public REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET As String = "CheckNormalizedPasswordNotInBannedPasswordStoreOnSet"
    Public REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE As String = "CheckNormalizedPasswordNotInBannedWordStoreOnChange"
    Public REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET As String = "CheckNormalizedPasswordNotInBannedWordStoreOnSet"
    Public REG_VALUE_CHECKBANNEDPASSWORDONCHANGE As String = "CheckPasswordNotInBannedPasswordStoreOnChange"
    Public REG_VALUE_CHECKBANNEDPASSWORDONSET As String = "CheckPasswordNotInBannedPasswordStoreOnSet"

    Public REG_VALUE_COMPLEXITYPOINTSPERCHAR As String = "ComplexityPointsPerCharacter"
    Public REG_VALUE_COMPLEXITYPOINTSPERLOWER As String = "ComplexityPointsPerLower"
    Public REG_VALUE_COMPLEXITYPOINTSPERNUMBER As String = "ComplexityPointsPerNumber"
    Public REG_VALUE_COMPLEXITYPOINTSPERSYMBOL As String = "ComplexityPointsPerSymbol"
    Public REG_VALUE_COMPLEXITYPOINTSPERUPPER As String = "ComplexityPointsPerUpper"
    Public REG_VALUE_COMPLEXITYPOINTSREQUIRED As String = "ComplexityPointsRequired"
    Public REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER As String = "ComplexityPointsUseOfLower"
    Public REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER As String = "ComplexityPointsUseOfNumber"
    Public REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL As String = "ComplexityPointsUseOfSymbol"
    Public REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER As String = "ComplexityPointsUseOfUpper"

    Public REG_VALUE_CTCHARSETSREQUIRED As String = "CharsetsRequired"
    Public REG_VALUE_CTREQUIRESLOWER As String = "RequiresLower"
    Public REG_VALUE_CTREQUIRESNUMBER As String = "RequiresNumber"
    Public REG_VALUE_CTREQUIRESSYMBOL As String = "RequiresSymbol"
    Public REG_VALUE_CTREQUIRESSYMBOLORNUMBER As String = "RequiresSymbolOrNumber"
    Public REG_VALUE_CTREQUIRESUPPER As String = "RequiresUpper"

    Public REG_VALUE_CT1 As String = "ComplexityThreshold1"
    Public REG_VALUE_CT1CHARSETSREQUIRED As String = "ComplexityThreshold1CharsetsRequired"
    Public REG_VALUE_CT1REQUIRESLOWER As String = "ComplexityThreshold1RequiresLower"
    Public REG_VALUE_CT1REQUIRESNUMBER As String = "ComplexityThreshold1RequiresNumber"
    Public REG_VALUE_CT1REQUIRESSYMBOL As String = "ComplexityThreshold1RequiresSymbol"
    Public REG_VALUE_CT1REQUIRESSYMBOLORNUMBER As String = "ComplexityThreshold1RequiresSymbolOrNumber"
    Public REG_VALUE_CT1REQUIRESUPPER As String = "ComplexityThreshold1RequiresUpper"

    Public REG_VALUE_CT2 As String = "ComplexityThreshold2"
    Public REG_VALUE_CT2CHARSETSREQUIRED As String = "ComplexityThreshold2CharsetsRequired"
    Public REG_VALUE_CT2REQUIRESLOWER As String = "ComplexityThreshold2RequiresLower"
    Public REG_VALUE_CT2REQUIRESNUMBER As String = "ComplexityThreshold2RequiresNumber"
    Public REG_VALUE_CT2REQUIRESSYMBOL As String = "ComplexityThreshold2RequiresSymbol"
    Public REG_VALUE_CT2REQUIRESSYMBOLORNUMBER As String = "ComplexityThreshold2RequiresSymbolOrNumber"
    Public REG_VALUE_CT2REQUIRESUPPER As String = "ComplexityThreshold2RequiresUpper"

    Public REG_VALUE_CT3 As String = "ComplexityThreshold3"
    Public REG_VALUE_CT3CHARSETSREQUIRED As String = "ComplexityThreshold3CharsetsRequired"
    Public REG_VALUE_CT3REQUIRESLOWER As String = "ComplexityThreshold3RequiresLower"
    Public REG_VALUE_CT3REQUIRESNUMBER As String = "ComplexityThreshold3RequiresNumber"
    Public REG_VALUE_CT3REQUIRESSYMBOL As String = "ComplexityThreshold3RequiresSymbol"
    Public REG_VALUE_CT3REQUIRESSYMBOLORNUMBER As String = "ComplexityThreshold3RequiresSymbolOrNumber"
    Public REG_VALUE_CT3REQUIRESUPPER As String = "ComplexityThreshold3RequiresUpper"

    Public REG_VALUE_REGEXAPPROVE As String = "RegexApprove"
    Public REG_VALUE_REGEXREJECT As String = "RegexReject"

    Public REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME As String = "ValidatePasswordDoesntContainAccountName"
    Public REG_VALUE_PASSWORDDOESNTCONTAINFULLNAME As String = "ValidatePasswordDoesntContainFullName"

    Private policyGroup As String
    Private globalSettingsKeyName As String
    Private policyKeyName As String
    Private policyGroups As String

    Public Sub New()
        policyGroup = "Default"
        globalSettingsKeyName = REG_BASE_GLOBAL_SETTINGS_KEY
        policyKeyName = REG_BASE_POLICY_KEY
        policyGroups = REG_BASE_GROUPS
    End Sub
    Public Sub New(ByVal pGroup As String)
        policyGroup = pGroup
        globalSettingsKeyName = GetKeyName(REG_BASE_GLOBAL_SETTINGS_KEY)
        policyKeyName = GetKeyName(REG_BASE_POLICY_KEY)
        policyGroups = REG_BASE_GROUPS
    End Sub
    Public Function getRegValue(ByVal valueName As String, ByVal defaultValue As Integer, Optional ByVal getGlobal As Boolean = False) As Integer
        Return GetPolicyOrSettingsValue(valueName, defaultValue, getGlobal)
    End Function
    Public Function getRegValue(ByVal valueName As String, ByVal defaultValue As Boolean, Optional ByVal getGlobal As Boolean = False) As Boolean
        Return GetPolicyOrSettingsValue(valueName, defaultValue, getGlobal)
    End Function
    Public Function getRegValue(ByVal valueName As String, ByVal defaultValue As String, Optional ByVal getGlobal As Boolean = False) As String
        Return GetPolicyOrSettingsValue(valueName, defaultValue, getGlobal)
    End Function
    Public Function getDefaultRegValue(ByVal valueName As String, ByVal defaultValue As String) As String
        Return GetDefaultPolicyOrSettingsValue(valueName, defaultValue)
    End Function
    Public Function setDefaultRegValue(ByVal valueName As String, ByVal Value As String) As Boolean
        Return SetDefaultPolicyOrSettingsValue(valueName, Value)
    End Function
    Public Function setRegValue(ByVal valueName As String, ByVal value As Integer, Optional ByVal setGlobal As Boolean = False) As Boolean
        If SetPolicyOrSettingsValue(valueName, value, setGlobal) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function setRegValue(ByVal valueName As String, ByVal value As Boolean, Optional ByVal setGlobal As Boolean = False) As Boolean
        If SetPolicyOrSettingsValue(valueName, value, setGlobal) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function setRegValue(ByVal valueName As String, ByVal value As String, Optional ByVal setGlobal As Boolean = False) As Boolean
        If SetPolicyOrSettingsValue(valueName, value, setGlobal) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub getPasswordLists(ByRef cmb As ComboBox, Optional ByVal extra As Boolean = True)
        Try
            Dim baseReg As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim baseKey As RegistryKey = baseReg.OpenSubKey(REG_BASE_LISTS)
            If (Not baseKey Is Nothing) Then
                Dim lists As String() = baseKey.GetValueNames()
                cmb.Items.Clear()
                For Each itm In lists
                    cmb.Items.Add(baseKey.GetValue(itm))
                Next
            End If
            If extra Then cmb.Items.Add("No list selected/found")
        Catch ex As Exception
            cmb.Items.Add("Error: " + ex.Message)
        End Try
    End Sub
    Public Function newPasswordList(ByVal newList As String) As Boolean
        Try
            Dim baseReg As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim baseKey As RegistryKey = baseReg.OpenSubKey(REG_BASE_LISTS, True)
            If (Not baseKey Is Nothing) Then
                Dim lists As String() = baseKey.GetValueNames()
                baseKey.SetValue(lists(lists.Length - 1) + 1, newList)
                If baseKey.GetValue(lists(lists.Length - 1) + 1, "") = newList Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function getGroupMapping() As Dictionary(Of String, String)
        Dim ret As New Dictionary(Of String, String)
        Try
            Dim baseReg As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim baseKey As RegistryKey = baseReg.OpenSubKey(REG_BASE_GROUPS)
            Dim groups As String() = baseKey.GetValueNames()
            For Each group As String In groups
                If group IsNot "" Then
                    ret.Add(group, Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + REG_BASE_GROUPS, group, ""))
                End If
            Next
            If ret.Count > 0 Then
                Return ret
            Else
                ret.Add("No group mappings found", "")
            End If
        Catch ex As Exception
            Dim er As String = ex.Message
            ret.Add("No group mappings found", er)
            Return ret
        End Try
        ret.Add("No group mappings found", "")
        Return ret
    End Function
    Public Function setGroupMapping(ByVal groupMapping As Dictionary(Of String, String)) As Boolean
        Dim ret As Boolean
        Try
            'Dim baseReg As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            'Dim baseKey As RegistryKey = baseReg.OpenSubKey(REG_BASE_GROUPS)
            'Dim groups As String() = baseKey.GetValueNames()
            For Each item As KeyValuePair(Of String, String) In groupMapping
                If item.Key IsNot "" Then
                    Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + REG_BASE_GROUPS, item.Key, item.Value, RegistryValueKind.String)
                    If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + REG_BASE_GROUPS, item.Key, ""), String) = item.Value Then
                        ret = True
                        Continue For
                    Else
                        ret = False
                        Exit For
                    End If
                End If
            Next
            Return ret
        Catch ex As Exception
            Dim er As String = ex.Message
            ret = False
            Return ret
        End Try
        ret = False
        Return ret
    End Function

    Public Function getPolicies() As String()
        Try
            Dim baseReg As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim baseKey As RegistryKey = baseReg.OpenSubKey(REG_BASE_POLICY_KEY)
            If (Not baseKey Is Nothing) Then
                Return baseKey.GetSubKeyNames()
            End If
        Catch ex As Exception
            Dim er As String = ex.Message
            Return {"No policies found", er}
        End Try
        Return {"No policies found", ""}
    End Function
    Public Function GetDefaultPolicyOrSettingsValue(ByVal valueName As String, ByVal defaultValue As String) As String
        Try
            Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + valueName, "", defaultValue)
        Catch ex As Exception
            Return defaultValue
        End Try

        Return defaultValue
    End Function
    Public Function SetDefaultPolicyOrSettingsValue(ByVal valueName As String, ByVal Value As String) As Boolean
        Try
            Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + valueName, "", Value, RegistryValueKind.String)
            If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + valueName, "", Value), String) = Value Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function GetNonPolicyOrSettingsValue(ByVal valueName As String, ByVal keyName As String, ByVal defaultValue As String()) As String()
        Try
            Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + valueName, keyName, defaultValue)
        Catch ex As Exception
            Return defaultValue
        End Try

        Return defaultValue
    End Function
    Public Function GetPolicyOrSettingsValue(ByVal valueName As String, ByVal defaultValue As Boolean, Optional ByVal getGlobal As Boolean = False) As Boolean
        If getGlobal Then
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        Else
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        End If
        Return defaultValue
    End Function
    Public Function GetPolicyOrSettingsValue(ByVal valueName As String, ByVal defaultValue As Integer, Optional ByVal getGlobal As Boolean = False) As Integer
        If getGlobal Then
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        Else
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        End If
        Return defaultValue
    End Function
    Public Function GetPolicyOrSettingsValue(ByVal valueName As String, ByVal defaultValue As String, Optional ByVal getGlobal As Boolean = False) As String
        If getGlobal Then
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        Else
            Try
                Return Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, defaultValue)
            Catch ex As Exception
                Return defaultValue
            End Try
        End If
        Return defaultValue
    End Function
    Public Function SetPolicyOrSettingsValue(ByVal valueName As String, ByVal value As Integer, Optional ByVal setGlobal As Boolean = False) As Boolean
        'Dim result As Integer = defaultValue
        If setGlobal Then
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, value, RegistryValueKind.DWord)
                If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, -1), Integer) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        Else
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, value, RegistryValueKind.DWord)
                If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, -1), Integer) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End If

        Return False
    End Function
    Public Function SetPolicyOrSettingsValue(ByVal valueName As String, ByVal value As Boolean, Optional ByVal setGlobal As Boolean = False) As Boolean
        'Dim result As Integer = defaultValue
        If setGlobal Then
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, value, RegistryValueKind.DWord)
                If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, 0), Boolean) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        Else
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, value, RegistryValueKind.DWord)
                If CType(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, 0), Boolean) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End If

        Return False
    End Function
    Public Function SetPolicyOrSettingsValue(ByVal valueName As String, ByVal value As String, Optional ByVal setGlobal As Boolean = False) As Boolean
        'Dim result As Integer = defaultValue
        If setGlobal Then
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, value, RegistryValueKind.String)
                If Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + globalSettingsKeyName, valueName, 0) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        Else
            Try
                Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, value, RegistryValueKind.String)
                If Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\" + policyKeyName, valueName, 0) = value Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End If

        Return False
    End Function
    Private Function GetKeyName(key) As String
        Dim name As String = key
        If (Not policyGroup Is Nothing) Then
            name += "\"
            name += policyGroup
        End If

        Return name
    End Function
End Class
