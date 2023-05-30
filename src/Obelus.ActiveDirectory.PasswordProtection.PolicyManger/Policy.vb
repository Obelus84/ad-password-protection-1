
Public Class Policy
    Inherits RegistryClass
    Structure complexity_threshold
        Public ComplexityThreshold As Integer
        Public ComplexityThresholdCharsetsRequired As Integer
        Public ComplexityThresholdRequiresLower As Boolean
        Public ComplexityThresholdRequiresNumber As Boolean
        Public ComplexityThresholdRequiresSymbol As Boolean
        Public ComplexityThresholdRequiresSymbolOrNumber As Boolean
        Public ComplexityThresholdRequiresUpper As Boolean
    End Structure

    Structure complexity_points
        Public PerCharacter As Integer
        Public PerLower As Integer
        Public PerNumber As Integer
        Public PerSymbol As Integer
        Public PerUpper As Integer
        Public Required As Integer
        Public UseOfLower As Integer
        Public UseOfNumber As Integer
        Public UseOfSymbol As Integer
        Public UseOfUpper As Integer
    End Structure

    Structure store_policy
        Public CheckNormalizedPasswordNotInBannedPasswordStoreOnChange As Boolean
        Public CheckNormalizedPasswordNotInBannedPasswordStoreOnSet As Boolean
        Public CheckNormalizedPasswordNotInBannedWordStoreOnChange As Boolean
        Public CheckNormalizedPasswordNotInBannedWordStoreOnSet As Boolean
        Public CheckPasswordNotInBannedPasswordStoreOnChange As Boolean
        Public CheckPasswordNotInBannedPasswordStoreOnSet As Boolean
    End Structure

    Structure general_policy
        Public MinimumLength As Integer

        Public RegexApprove As String
        Public RegexReject As String

        Public ValidatePasswordDoesntContainAccountName As Boolean
        Public ValidatePasswordDoesntContainFullName As Boolean
    End Structure

    Structure user_policy
        Public GeneralPolicy As general_policy
        Public StorePolicy As store_policy
        Public ComplexityPoints As complexity_points
        Public ComplexityThreshold1 As complexity_threshold
        Public ComplexityThreshold2 As complexity_threshold
        Public ComplexityThreshold3 As complexity_threshold
    End Structure
    Public Function getPolicy(ByVal account As String) As user_policy
        Dim Policy As New user_policy
        Dim reg As New RegistryClass
        Policy.ComplexityPoints.PerCharacter = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSPERCHAR, 0)
        Policy.ComplexityPoints.PerLower = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSPERLOWER, 0)
        Policy.ComplexityPoints.PerNumber = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSPERNUMBER, 0)
        Policy.ComplexityPoints.PerSymbol = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSPERSYMBOL, 0)
        Policy.ComplexityPoints.PerUpper = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSPERUPPER, 0)
        Policy.ComplexityPoints.Required = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSREQUIRED, 0)
        Policy.ComplexityPoints.UseOfLower = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER, 0)
        Policy.ComplexityPoints.UseOfNumber = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER, 0)
        Policy.ComplexityPoints.UseOfSymbol = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL, 0)
        Policy.ComplexityPoints.UseOfUpper = reg.getRegValue(REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER, 0)

        Policy.ComplexityThreshold1.ComplexityThreshold = reg.getRegValue(REG_VALUE_CT1, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdCharsetsRequired = reg.getRegValue(REG_VALUE_CT1CHARSETSREQUIRED, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdRequiresLower = reg.getRegValue(REG_VALUE_CT1REQUIRESLOWER, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdRequiresNumber = reg.getRegValue(REG_VALUE_CT1REQUIRESNUMBER, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdRequiresSymbol = reg.getRegValue(REG_VALUE_CT1REQUIRESSYMBOL, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdRequiresSymbolOrNumber = reg.getRegValue(REG_VALUE_CT1REQUIRESSYMBOLORNUMBER, 0)
        Policy.ComplexityThreshold1.ComplexityThresholdRequiresUpper = reg.getRegValue(REG_VALUE_CT1REQUIRESUPPER, 0)

        Policy.ComplexityThreshold2.ComplexityThreshold = reg.getRegValue(REG_VALUE_CT2, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdCharsetsRequired = reg.getRegValue(REG_VALUE_CT2CHARSETSREQUIRED, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdRequiresLower = reg.getRegValue(REG_VALUE_CT2REQUIRESLOWER, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdRequiresNumber = reg.getRegValue(REG_VALUE_CT2REQUIRESNUMBER, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdRequiresSymbol = reg.getRegValue(REG_VALUE_CT2REQUIRESSYMBOL, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdRequiresSymbolOrNumber = reg.getRegValue(REG_VALUE_CT2REQUIRESSYMBOLORNUMBER, 0)
        Policy.ComplexityThreshold2.ComplexityThresholdRequiresUpper = reg.getRegValue(REG_VALUE_CT2REQUIRESUPPER, 0)

        Policy.ComplexityThreshold3.ComplexityThreshold = reg.getRegValue(REG_VALUE_CT3, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdCharsetsRequired = reg.getRegValue(REG_VALUE_CT3CHARSETSREQUIRED, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdRequiresLower = reg.getRegValue(REG_VALUE_CT3REQUIRESLOWER, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdRequiresNumber = reg.getRegValue(REG_VALUE_CT3REQUIRESNUMBER, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdRequiresSymbol = reg.getRegValue(REG_VALUE_CT3REQUIRESSYMBOL, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdRequiresSymbolOrNumber = reg.getRegValue(REG_VALUE_CT3REQUIRESSYMBOLORNUMBER, 0)
        Policy.ComplexityThreshold3.ComplexityThresholdRequiresUpper = reg.getRegValue(REG_VALUE_CT3REQUIRESUPPER, 0)

        Policy.GeneralPolicy.MinimumLength = reg.getRegValue(REG_VALUE_MINIMUMLENGTH, 0)
        Policy.GeneralPolicy.ValidatePasswordDoesntContainAccountName = reg.getRegValue(REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, 0)
        Policy.GeneralPolicy.ValidatePasswordDoesntContainFullName = reg.getRegValue(REG_VALUE_PASSWORDDOESNTCONTAINFULLNAME, 0)

        'Policy.GeneralPolicy.RegexApprove = GetInteropString(reg.getRegValue(REG_VALUE_REGEXAPPROVE, L"").c_str())
        'Policy.GeneralPolicy.RegexReject = GetInteropString(reg.getRegValue(REG_VALUE_REGEXREJECT, L"").c_str())


        Return Policy
    End Function

End Class