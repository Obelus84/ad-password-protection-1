Imports System.Security.Cryptography
Imports System.Text

Public Class policy_control
    Private reg As New RegistryClass
    Public needSave As Boolean = False
    Private loading As Boolean = False
    Public myHandle As IntPtr
    Private Sub policy_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGroup.Visible = False
        chkEnable.Visible = False
        chkRegExpSettings.Visible = False
        chkComplexityPoints.Visible = False
        chkLengthBasedComplexityRules.Visible = False
        btnBasicSettings.Visible = False
        btnLengthBased.Visible = False
        btnPasswordPts.Visible = False
        btnRegExp.Visible = False
        chkSimulate.Visible = False
        bSave.Visible = False
        bSave.Enabled = False

        'cmbLists.Items.AddRange(reg.getPasswordLists())
        reg.getPasswordLists(cmbLists)
        cmbPolicy.Items.AddRange(reg.getPolicies())
        parseControls(Me)

    End Sub
    Private Sub parseControls(ByVal container As Control)
        For Each c As Control In container.Controls
            If TypeOf c Is CheckBox Then
                AddHandler DirectCast(c, CheckBox).CheckedChanged, AddressOf handleModified
                If container.Name = "pLengthBased" Then
                    AddHandler DirectCast(c, CheckBox).CheckedChanged, AddressOf proc_PasswordThresholdTest
                End If
            ElseIf TypeOf c Is NumericUpDown Then
                AddHandler DirectCast(c, NumericUpDown).ValueChanged, AddressOf handleModified
                AddHandler DirectCast(c, NumericUpDown).MouseWheel, AddressOf DisiableScrollNumericUpDown
                If container.Name = "pComplexityPoints" Then
                    AddHandler DirectCast(c, NumericUpDown).ValueChanged, AddressOf proc_passwordComplexityTest
                ElseIf container.Name = "pLengthBased" Then
                    AddHandler DirectCast(c, NumericUpDown).ValueChanged, AddressOf proc_PasswordThresholdTest
                End If
            ElseIf TypeOf c Is TextBox Then
                AddHandler DirectCast(c, TextBox).TextChanged, AddressOf handleModified
                If container.Name = "pComplexityPoints" Then
                    AddHandler DirectCast(c, TextBox).TextChanged, AddressOf proc_passwordComplexityTest
                ElseIf container.Name = "pLengthBased" Then
                    AddHandler DirectCast(c, TextBox).TextChanged, AddressOf proc_PasswordThresholdTest
                End If
            ElseIf TypeOf c Is ComboBox Then
                If c.Name = "cmbLists" Then
                    AddHandler DirectCast(c, ComboBox).SelectedIndexChanged, AddressOf handleModified
                End If
            End If
            If c.Controls.Count > 0 Then
                parseControls(c)
            End If
        Next
    End Sub
    Private Sub DisiableScrollNumericUpDown(sender As Object, e As HandledMouseEventArgs)
        ' Set the Handled property of the event arguments to True
        e.Handled = True
    End Sub
    Private Sub proc_passwordComplexityTest(sender As Object, e As EventArgs)
        If Not loading Then testComplexityPolicy()
    End Sub
    Private Sub proc_PasswordThresholdTest(sender As Object, e As EventArgs)
        If Not loading Then testThreasholdPolicy()
    End Sub
    Private Sub sanityCheckThreasholds(sender As Object, e As EventArgs) Handles polCT1.ValueChanged, polCT2.ValueChanged
        If loading Then Exit Sub
        If polCT2.Value = 0 Then
            polCT1.Maximum = 1
        Else
            polCT1.Maximum = polCT2.Value - 1
        End If
        polCT2.Minimum = polCT1.Maximum + 1
    End Sub
    Private Sub handleModified(sender As Object, e As EventArgs)
        If Not loading Then
            needSave = True
            bSave.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBasicSettings.Click
        If pBasic.Visible Then
            pBasic.Visible = False
        Else
            pBasic.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPasswordPts.Click
        If pComplexityPoints.Visible Then
            pComplexityPoints.Visible = False
        Else
            pComplexityPoints.Visible = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLengthBased.Click
        If pLengthBased.Visible Then
            pLengthBased.Visible = False
        Else
            pLengthBased.Visible = True
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRegExp.Click
        If pRegExp.Visible Then
            pRegExp.Visible = False
        Else
            pRegExp.Visible = True
        End If
    End Sub

    Private Sub chkBasicSettings_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnable.CheckedChanged
        If chkEnable.Checked Then
            btnBasicSettings.Visible = True
        Else
            btnBasicSettings.Visible = False
            pBasic.Visible = False
        End If
    End Sub
    Private Sub chkComplexityPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkComplexityPoints.CheckedChanged
        If chkComplexityPoints.Checked Then
            btnPasswordPts.Visible = True
            testComplexityPolicy()
        Else
            btnPasswordPts.Visible = False
            pComplexityPoints.Visible = False
        End If
    End Sub

    Private Sub chkLengthBasedComplexityRules_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkLengthBasedComplexityRules.CheckedChanged
        If chkLengthBasedComplexityRules.Checked Then
            btnLengthBased.Visible = True
            testThreasholdPolicy()
        Else
            btnLengthBased.Visible = False
            pLengthBased.Visible = False
        End If
    End Sub

    Private Sub chkRegExpSettings_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegExpSettings.CheckedChanged
        If chkRegExpSettings.Checked Then
            btnRegExp.Visible = True
        Else
            btnRegExp.Visible = False
            pRegExp.Visible = False
        End If
    End Sub
    Private Sub chkEnableRegexApprove_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableRegexApprove.CheckedChanged
        If chkEnableRegexApprove.Checked Then
            txtRegexApprove.Enabled = True
        Else
            txtRegexApprove.Enabled = False
        End If
    End Sub

    Private Sub chkEnableRegexReject_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableRegexReject.CheckedChanged
        If chkEnableRegexReject.Checked Then
            txtRegexReject.Enabled = True
        Else
            txtRegexReject.Enabled = False
        End If
    End Sub
    Private Sub loadPolicy()
        Dim Policy As String = cmbPolicy.SelectedItem()
        Dim polReg As New RegistryClass(Policy)
        resetPolicy(Me)
        lGroupPolicyAssignment.Text = getGroups(Policy)


        cmbLists.SelectedIndex = polReg.getRegValue(polReg.REG_VALUE_STOREPATH, cmbLists.Items.Count - 1)

        chkEnable.Checked = polReg.getRegValue(polReg.REG_VALUE_ENABLED, False)
        chkSimulate.Checked = polReg.getRegValue(polReg.REG_VALUE_SIMULATE, True)

        polMinPasswordLength.Value = polReg.getRegValue(polReg.REG_VALUE_MINIMUMLENGTH, 0)
        polMaxPasswordLength.Value = polReg.getRegValue(polReg.REG_VALUE_MAXIMUMLENGTH, 0)

        polRejectContainAccountNameChange.Checked = polReg.getRegValue(polReg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, False)
        polRejectNormalizedPasswordsinPasswordStoreChange.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE, False)
        polRejectNormalizedPasswordsinWordListChange.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE, False)
        polRejectPasswordStoreChange.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKBANNEDPASSWORDONCHANGE, False)

        polRejectContainAccountNameSet.Checked = polReg.getRegValue(polReg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, False)
        polRejectNormalizedPasswordsinPasswordStoreSet.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET, False)
        polRejectNormalizedPasswordsinWordListSet.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET, False)
        polRejectPasswordStoreSet.Checked = polReg.getRegValue(polReg.REG_VALUE_CHECKBANNEDPASSWORDONSET, False)


        chkComplexityPoints.Checked = polReg.getRegValue(polReg.REG_VALUE_CATPASSWORDCOMPLEXITY, False)

        polComplexityPointsRequired.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSREQUIRED, 0)
        polComplexityPointsEachChar.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERCHAR, 0)
        polComplexityPointsEachNumber.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERNUMBER, 0)
        polComplexityPointsEachLower.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERLOWER, 0)
        polComplexityPointsEachUpper.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERUPPER, 0)
        polComplexityPointsEachSymbol.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERSYMBOL, 0)
        polComplexityPointsUseOfNumber.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER, 0)
        polComplexityPointsUseOfSymbol.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL, 0)
        polComplexityPointsUseOfUpper.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER, 0)
        polComplexityPointsUseOfLower.Value = polReg.getRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER, 0)

        chkLengthBasedComplexityRules.Checked = polReg.getRegValue(polReg.REG_VALUE_CATLENGTHBASEDCOMPLEXITY, False)

        polCT1.Value = polReg.getRegValue(polReg.REG_VALUE_CT1, 0)
        If polReg.getRegValue(polReg.REG_VALUE_CT1CHARSETSREQUIRED, 0) > 4 Then
            polCT1CharacterSetsRequired.Value = 4
            needSave = True
            bSave.Enabled = True
            MsgBox("Error found with Threshold 1 Character Sets Requires setting, " & vbCrLf & polReg.getRegValue(polReg.REG_VALUE_CT1CHARSETSREQUIRED, 0) & " is higher than the max value of 4." & vbCrLf & vbCrLf & "The setting has been adjusted automatically. Please save to prevent this error in the future", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Settings Error")
        Else
            polCT1CharacterSetsRequired.Value = Math.Min(polReg.getRegValue(polReg.REG_VALUE_CT1CHARSETSREQUIRED, 0), 4)
        End If
        polCT1LowerRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT1REQUIRESLOWER, False)
        polCT1UpperRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT1REQUIRESUPPER, False)
        polCT1NumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT1REQUIRESNUMBER, False)
        polCT1SymbolRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT1REQUIRESSYMBOL, False)
        polCT1SymbolOrNumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT1REQUIRESSYMBOLORNUMBER, False)

        polCT2.Value = polReg.getRegValue(polReg.REG_VALUE_CT2, 0)
        If polReg.getRegValue(polReg.REG_VALUE_CT1CHARSETSREQUIRED, 0) > 4 Then
            polCT2CharacterSetsRequired.Value = 4
            needSave = True
            bSave.Enabled = True
            MsgBox("Error found with Threshold 2 Character Sets Requires setting, " & vbCrLf & polReg.getRegValue(polReg.REG_VALUE_CT2CHARSETSREQUIRED, 0) & " is higher than the max value of 4." & vbCrLf & vbCrLf & "The setting has been adjusted automatically. Please save to prevent this error in the future", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Settings Error")
        Else
            polCT2CharacterSetsRequired.Value = Math.Min(polReg.getRegValue(polReg.REG_VALUE_CT2CHARSETSREQUIRED, 0), 4)
        End If
        polCT2LowerRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT2REQUIRESLOWER, False)
        polCT2UpperRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT2REQUIRESUPPER, False)
        polCT2NumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT2REQUIRESNUMBER, False)
        polCT2SymbolRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT2REQUIRESSYMBOL, False)
        polCT2SymbolOrNumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT2REQUIRESSYMBOLORNUMBER, False)

        If polReg.getRegValue(polReg.REG_VALUE_CT3CHARSETSREQUIRED, 0) > 4 Then
            polCT3CharacterSetsRequired.Value = 4
            needSave = True
            bSave.Enabled = True
            MsgBox("Error found with Threshold 3 Character Sets Requires setting, " & vbCrLf & polReg.getRegValue(polReg.REG_VALUE_CT3CHARSETSREQUIRED, 0) & " is higher than the max value of 4." & vbCrLf & vbCrLf & "The setting has been adjusted automatically. Please save to prevent this error in the future", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Settings Error")
        Else
            polCT3CharacterSetsRequired.Value = Math.Min(polReg.getRegValue(polReg.REG_VALUE_CT3CHARSETSREQUIRED, 0), 4)
        End If
        polCT3CharacterSetsRequired.Value = Math.Min(polReg.getRegValue(polReg.REG_VALUE_CT3CHARSETSREQUIRED, 0), 4)
        polCT3LowerRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT3REQUIRESLOWER, False)
        polCT3UpperRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT3REQUIRESUPPER, False)
        polCT3NumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT3REQUIRESNUMBER, False)
        polCT3SymbolRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT3REQUIRESSYMBOL, False)
        polCT3SymbolOrNumberRequired.Checked = polReg.getRegValue(polReg.REG_VALUE_CT3REQUIRESSYMBOLORNUMBER, False)

        If (polCT1.Value >= polCT2.Value) AndAlso (polCT1.Value > 0 And polCT2.Value > 0) Then
            polCT1.Value = polCT2.Value - 1
            MsgBox("Lenght based complexity Threashold 1 was higher than Threashold 2. Threshold 1 has been automatically adjusted to Threshold 2 - 1 to prevent errors", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
        If polCT2.Value = 0 Then
            polCT1.Maximum = 1
        Else
            polct1.Maximum = polCT2.Value - 1
        End If
        polCT2.Minimum = polCT1.Maximum + 1


        chkRegExpSettings.Checked = polReg.getRegValue(polReg.REG_VALUE_CATREGEX, False)
        txtRegexApprove.Text = polReg.getRegValue(polReg.REG_VALUE_REGEXAPPROVE, "")
        If txtRegexApprove.Text IsNot "" Then
            chkEnableRegexApprove.Checked = True
            txtRegexApprove.Enabled = True
        End If
        txtRegexReject.Text = polReg.getRegValue(polReg.REG_VALUE_REGEXREJECT, "")
        If txtRegexReject.Text IsNot "" Then
            chkEnableRegexReject.Checked = True
            txtRegexReject.Enabled = True
        End If

    End Sub
    Private Sub bAddPolicy_Hover(sender As Object, e As EventArgs) Handles bAddPolicy.MouseEnter
        bAddPolicy.Image = My.Resources.add_over
    End Sub
    Private Sub bAddPolicy_nHover(sender As Object, e As EventArgs) Handles bAddPolicy.MouseLeave
        bAddPolicy.Image = My.Resources.add
    End Sub
    Private Function getGroups(ByVal searchPolicy As String) As String
        Dim out As String = ""
        Dim mapping As Dictionary(Of String, String) = reg.getGroupMapping

        For Each itm As KeyValuePair(Of String, String) In mapping
            If itm.Value = searchPolicy Then
                out = out & " " & itm.Key & ","
            End If
        Next
        Return out.TrimEnd(",")
    End Function
    Public Sub resetPolicy(control As Control)
        For Each c As Control In control.Controls
            If c.Controls.Count > 0 Then resetPolicy(c)
            Select Case c.GetType
                Case GetType(CheckBox)
                    DirectCast(c, CheckBox).Checked = False
                Case GetType(NumericUpDown)
                    If c.Name = "polCT1CharacterSetsRequired" Or c.Name = "polCT2CharacterSetsRequired" Or c.Name = "polCT3CharacterSetsRequired" Then
                        DirectCast(c, NumericUpDown).Minimum = 0
                        DirectCast(c, NumericUpDown).Maximum = 4
                    ElseIf c.Name = "polMaxPasswordLength" Or c.Name = "polMinPasswordLength" Or c.Name = "polCT1" Or c.Name = "polCT2" Then
                        DirectCast(c, NumericUpDown).Minimum = 0
                        DirectCast(c, NumericUpDown).Maximum = 256
                    Else
                        DirectCast(c, NumericUpDown).Minimum = 0
                        DirectCast(c, NumericUpDown).Maximum = 100
                    End If
                    DirectCast(c, NumericUpDown).Value = 0
                Case GetType(TextBox)
                    DirectCast(c, TextBox).Text = ""
                    DirectCast(c, TextBox).Enabled = False
                Case GetType(Label)
                    If c.Name = "lGroupPolicyAssignment" Or c.Name = "lPoints" Or c.Name = "lblTLevel" Or c.Name = "lblResult" Then
                        DirectCast(c, Label).Text = ""
                    End If
                Case GetType(ProgressBar)
                    DirectCast(c, ProgressBar).Minimum = 0
                    DirectCast(c, ProgressBar).Maximum = 100
                    DirectCast(c, ProgressBar).Value = 0
            End Select
        Next
    End Sub
    Private Sub testComplexityPolicy()
        If loading Then Exit Sub
        loading = True
        Dim test As String = ""
        If txtPWTest.Text = "" Then txtPWTest.Text = "Th1$ is A T3st P@sswrd"
        txtPWTest.Enabled = True
        test = txtPWTest.Text
        Dim total As Integer = polComplexityPointsRequired.Value
        prgPWTest.Maximum = total

        Dim perChar As Integer = polComplexityPointsEachChar.Value

        Dim perNumber As Integer = polComplexityPointsEachNumber.Value
        Dim perLower As Integer = polComplexityPointsEachLower.Value
        Dim perUpper As Integer = polComplexityPointsEachUpper.Value
        Dim perSymbol As Integer = polComplexityPointsEachSymbol.Value

        Dim useNumber As Integer = polComplexityPointsUseOfNumber.Value
        Dim useSymbol As Integer = polComplexityPointsUseOfSymbol.Value
        Dim useUpper As Integer = polComplexityPointsUseOfUpper.Value
        Dim useLower As Integer = polComplexityPointsUseOfLower.Value

        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasSymbol As Boolean = False
        Dim hasNumber As Boolean = False

        Dim pointCount As Integer = 0
        loading = False
        For Each c As Char In test

            pointCount += perChar

            If IsNumeric(c) Then

                hasNumber = True
                pointCount += perNumber
                Continue For
            End If

            If Char.IsUpper(c) Then

                pointCount += perUpper
                hasUpper = True
                Continue For
            End If

            If Char.IsLower(c) Then

                pointCount += perLower
                hasLower = True
                Continue For
            End If

            pointCount += perSymbol
            hasSymbol = True
        Next

        If hasLower Then
            pointCount += useLower
        End If

        If hasUpper Then
            pointCount += useUpper
        End If

        If hasSymbol Then
            pointCount += useSymbol
        End If

        If hasNumber Then
            pointCount += useNumber
        End If

        'MsgBox(pointCount)

        If pointCount > total Then
            prgPWTest.Value = total
        Else
            prgPWTest.Value = pointCount
        End If

        lPoints.Text = pointCount & "/" & total
    End Sub
    Public Sub testThreasholdPolicy()
        If loading Then Exit Sub
        loading = True
        If txtThresholdPassword.Text = "" Then txtThresholdPassword.Text = "Th1$ is A T3st P@sswrd"
        txtThresholdPassword.Enabled = True
        loading = False

        Dim threshold1 As Integer = polCT1.Value
        Dim threshold2 As Integer = polCT2.Value

        If threshold1 <= 0 Then
            'Return True
        End If

        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasSymbol As Boolean = False
        Dim hasNumber As Boolean = False
        Dim pwdlength As Integer = txtThresholdPassword.Text.Length


        For Each c As Char In txtThresholdPassword.Text
            If IsNumeric(c) Then

                hasNumber = True
                Continue For
            End If

            If Char.IsUpper(c) Then

                hasUpper = True
                Continue For
            End If

            If Char.IsLower(c) Then
                hasLower = True
                Continue For
            End If

            hasSymbol = True
        Next

        Dim thresholdID As String
        Dim requiresLower As Boolean
        Dim requiresUpper As Boolean
        Dim requiresNumber As Boolean
        Dim requiresSymbol As Boolean
        Dim requiresSymbolOrNumber As Boolean
        Dim charSetsRequired As Integer

        If pwdlength < threshold1 Or threshold2 <= 0 Then
            thresholdID = "CT1"
            lblTLevel.Text = "Threshold 1"
            requiresLower = polCT1LowerRequired.Checked
            requiresUpper = polCT1UpperRequired.Checked
            requiresNumber = polCT1NumberRequired.Checked
            requiresSymbol = polCT1SymbolRequired.Checked
            requiresSymbolOrNumber = polCT1SymbolOrNumberRequired.Checked
            charSetsRequired = Math.Min(polCT1CharacterSetsRequired.Value, 4)
        ElseIf (pwdlength < threshold2) Then
            thresholdID = "CT2"
            lblTLevel.Text = "Threshold 2"
            requiresLower = polCT2LowerRequired.Checked
            requiresUpper = polCT2UpperRequired.Checked
            requiresNumber = polCT2NumberRequired.Checked
            requiresSymbol = polCT2SymbolRequired.Checked
            requiresSymbolOrNumber = polCT2SymbolOrNumberRequired.Checked
            charSetsRequired = Math.Min(polCT2CharacterSetsRequired.Value, 4)
        Else
            thresholdID = "CT3"
            lblTLevel.Text = "Threshold 3"
            requiresLower = polCT3LowerRequired.Checked
            requiresUpper = polCT3UpperRequired.Checked
            requiresNumber = polCT3NumberRequired.Checked
            requiresSymbol = polCT3SymbolRequired.Checked
            requiresSymbolOrNumber = polCT3SymbolOrNumberRequired.Checked
            charSetsRequired = Math.Min(polCT3CharacterSetsRequired.Value, 4)
        End If



        Dim charSetsPresent As Integer = If(hasLower, 1, 0) + If(hasUpper, 1, 0) + If(hasSymbol, 1, 0) + If(hasNumber, 1, 0)

        If (charSetsPresent < charSetsRequired) OrElse (requiresLower AndAlso Not hasLower) OrElse (requiresUpper AndAlso Not hasUpper) OrElse (requiresNumber AndAlso Not hasNumber) OrElse (requiresSymbol AndAlso Not hasSymbol) OrElse (requiresSymbolOrNumber AndAlso Not (hasSymbol Or hasNumber)) Then
            lblResult.Text = "Fail"
        Else
            lblResult.Text = "Pass"
        End If
    End Sub
    Public Function savePolicy()
        Dim Policy As String = cmbPolicy.SelectedItem()
        Dim polReg As New RegistryClass(Policy)
        Dim ret As Boolean = False

        ret = polReg.setRegValue(polReg.REG_VALUE_ENABLED, chkEnable.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_SIMULATE, chkSimulate.Checked)

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_STOREPATH, cmbLists.SelectedIndex)

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_MINIMUMLENGTH, CType(polMinPasswordLength.Value, Integer))
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_MAXIMUMLENGTH, CType(polMaxPasswordLength.Value, Integer))

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, polRejectContainAccountNameChange.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE, polRejectNormalizedPasswordsinPasswordStoreChange.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE, polRejectNormalizedPasswordsinWordListChange.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKBANNEDPASSWORDONCHANGE, polRejectPasswordStoreChange.Checked)

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, polRejectContainAccountNameSet.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET, polRejectNormalizedPasswordsinPasswordStoreSet.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET, polRejectNormalizedPasswordsinWordListSet.Checked)
        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CHECKBANNEDPASSWORDONSET, polRejectPasswordStoreSet.Checked)


        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CATPASSWORDCOMPLEXITY, chkComplexityPoints.Checked)

        If chkComplexityPoints.Checked Then
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSREQUIRED, CType(polComplexityPointsRequired.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERCHAR, CType(polComplexityPointsEachChar.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERNUMBER, CType(polComplexityPointsEachNumber.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERLOWER, CType(polComplexityPointsEachLower.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERUPPER, CType(polComplexityPointsEachUpper.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSPERSYMBOL, CType(polComplexityPointsEachSymbol.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER, CType(polComplexityPointsUseOfNumber.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL, CType(polComplexityPointsUseOfSymbol.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER, CType(polComplexityPointsUseOfUpper.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER, CType(polComplexityPointsUseOfLower.Value, Integer))
        End If

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CATLENGTHBASEDCOMPLEXITY, chkLengthBasedComplexityRules.Checked)

        If chkLengthBasedComplexityRules.Checked Then
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1, CType(polCT1.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1CHARSETSREQUIRED, CType(polCT1CharacterSetsRequired.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1REQUIRESLOWER, polCT1LowerRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1REQUIRESUPPER, polCT1UpperRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1REQUIRESNUMBER, polCT1NumberRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1REQUIRESSYMBOL, polCT1SymbolRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT1REQUIRESSYMBOLORNUMBER, polCT1SymbolOrNumberRequired.Checked)

            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2, CType(polCT2.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2CHARSETSREQUIRED, CType(polCT2CharacterSetsRequired.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2REQUIRESLOWER, polCT2LowerRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2REQUIRESUPPER, polCT2UpperRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2REQUIRESNUMBER, polCT2NumberRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2REQUIRESSYMBOL, polCT2SymbolRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT2REQUIRESSYMBOLORNUMBER, polCT2SymbolOrNumberRequired.Checked)

            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3CHARSETSREQUIRED, CType(polCT3CharacterSetsRequired.Value, Integer))
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3REQUIRESLOWER, polCT3LowerRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3REQUIRESUPPER, polCT3UpperRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3REQUIRESNUMBER, polCT3NumberRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3REQUIRESSYMBOL, polCT3SymbolRequired.Checked)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CT3REQUIRESSYMBOLORNUMBER, polCT3SymbolOrNumberRequired.Checked)
        End If

        If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_CATREGEX, chkRegExpSettings.Checked)

        If chkRegExpSettings.Checked Then
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_REGEXAPPROVE, txtRegexApprove.Text)
            If ret Then ret = polReg.setRegValue(polReg.REG_VALUE_REGEXREJECT, txtRegexReject.Text)
        End If

        Return ret
    End Function
    Private Sub cmbPolicy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPolicy.SelectedIndexChanged
        If needSave Then
            Dim answ As MsgBoxResult = MsgBox("You may have settings that need to be changed, are you sure you want to change this selection?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
            If answ = MsgBoxResult.Yes Then
                needSave = False
                bSave.Enabled = False
            ElseIf answ = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If (cmbPolicy.SelectedItem <> "") Then
            loading = True
            loadPolicy()
            lblGroup.Visible = True
            chkEnable.Visible = True
            chkRegExpSettings.Visible = True
            chkComplexityPoints.Visible = True
            chkLengthBasedComplexityRules.Visible = True
            chkSimulate.Visible = True
            bSave.Visible = True
            loading = False
            If chkComplexityPoints.Checked Then testComplexityPolicy()
            If chkLengthBasedComplexityRules.Checked Then testThreasholdPolicy()
        End If
    End Sub

    Private Sub bSetList_Click(sender As Object, e As EventArgs) Handles bSetList.Click
        Dim Policy As String = cmbPolicy.SelectedItem()
        Dim reg As New RegistryClass(Policy)
        Dim test As Boolean = reg.setRegValue(reg.REG_VALUE_STOREPATH, cmbLists.SelectedIndex)
        If test Then
            MsgBox("Successfully set the password list", MsgBoxStyle.Information, "Success")
        Else
            MsgBox("There was an error setting the policy list for " + Policy, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim ret As Boolean = savePolicy()
        If ret Then
            bSave.Enabled = False
            needSave = False
            MsgBox("Policy for " & cmbPolicy.SelectedItem & " has been saved successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
        Else
            MsgBox("An error occured saving one or more policies, please try again", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub Button1_EnabledChanged(sender As Object, e As EventArgs) Handles bSave.EnabledChanged
        If bSave.Enabled Then
            bSave.BackColor = ColorTranslator.FromHtml("#273c75")
        Else
            bSave.BackColor = ColorTranslator.FromHtml("#7f8fa6")
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        testComplexityPolicy()
    End Sub

    Private Sub bAddPolicy_Click(sender As Object, e As EventArgs) Handles bAddPolicy.Click
        Dim inpt As New custom_input_box("Enter the name of the policy you would like to create. Name should be alphanumeric only and not contain Spaces or special characters other than - (dash) or _ (underscore)", "New Policy")
        Dim resp As DialogResult = inpt.ShowDialog()
        If resp = DialogResult.OK Then
            Dim newPol As String = inpt.GetInput()
            cmbPolicy.Items.Add(newPol)
            MsgBox("New policy " + newPol + " has been added, you can now configure the settings. Don't forget to save")
            cmbPolicy.SelectedIndex = cmbPolicy.Items.IndexOf(newPol)
        Else
            'MsgBox("input box was cancled")
        End If
    End Sub
End Class
