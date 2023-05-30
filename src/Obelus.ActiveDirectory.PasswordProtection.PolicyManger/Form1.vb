Public Class Form1
    Public reg As New RegistryClass
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if remote
        lblGroup.Visible = False
        lblPassList.Visible = False
        txtGroup.Visible = False
        cmbLists.Visible = False
        chkDisable.Visible = False
        chkRegExpSettings.Visible = False
        chkComplexityPoints.Visible = False
        chkLengthBasedComplexityRules.Visible = False
        FlowLayoutPanel1.Visible = False
        bSetList.Visible = False
        bAddList.Visible = False

        'cmbLists.Items.AddRange(reg.getPasswordLists())
        reg.getPasswordLists(cmbLists)
        cmbPolicy.Items.AddRange(reg.getPolicies())
    End Sub
    Private Sub chkComplexityPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkComplexityPoints.CheckedChanged
        If chkComplexityPoints.Checked Then
            gbComplexityPoints.Visible = True
            gbComplexityPoints.Enabled = True
        Else
            gbComplexityPoints.Visible = False
            gbComplexityPoints.Enabled = False
        End If
    End Sub

    Private Sub chkLengthBasedComplexityRules_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkLengthBasedComplexityRules.CheckedChanged
        If chkLengthBasedComplexityRules.Checked Then
            gbLengthBasedComplexity.Visible = True
            gbLengthBasedComplexity.Enabled = True
        Else
            gbLengthBasedComplexity.Visible = False
            gbLengthBasedComplexity.Enabled = False
        End If
    End Sub

    Private Sub chkRegExpSettings_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegExpSettings.CheckedChanged
        If chkRegExpSettings.Checked Then
            gbRegExpress.Visible = True
            gbRegExpress.Enabled = True
        Else
            gbRegExpress.Visible = False
            gbRegExpress.Enabled = False
        End If
    End Sub

    Private Sub loadPolicy()
        Dim Policy As String = cmbPolicy.SelectedItem()
        Dim reg As New RegistryClass(Policy)

        cmbLists.SelectedIndex = reg.getRegValue(reg.REG_VALUE_STOREPATH, cmbLists.Items.Count - 1)

        'chkDisable.Checked = reg.getRegValue(reg.REG_VALUE_DISABLED, False)

        polMinPasswordLength.Value = reg.getRegValue(reg.REG_VALUE_MINIMUMLENGTH, 0)
        polMaxPasswordLength.Value = reg.getRegValue(reg.REG_VALUE_MAXIMUMLENGTH, 0)

        polRejectContainAccountNameChange.Checked = reg.getRegValue(reg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, False)
        polRejectNormalizedPasswordsinPasswordStoreChange.Checked = reg.getRegValue(reg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONCHANGE, False)
        polRejectNormalizedPasswordsinWordListChange.Checked = reg.getRegValue(reg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONCHANGE, False)
        polRejectPasswordStoreChange.Checked = reg.getRegValue(reg.REG_VALUE_CHECKBANNEDPASSWORDONCHANGE, False)

        polRejectContainAccountNameSet.Checked = reg.getRegValue(reg.REG_VALUE_PASSWORDDOESNTCONTAINACCOUNTNAME, False)
        polRejectNormalizedPasswordsinPasswordStoreSet.Checked = reg.getRegValue(reg.REG_VALUE_CHECKNORMALIZEDBANNEDPASSWORDONSET, False)
        polRejectNormalizedPasswordsinWordListSet.Checked = reg.getRegValue(reg.REG_VALUE_CHECKNORMALIZEDBANNEDWORDONSET, False)
        polRejectPasswordStoreSet.Checked = reg.getRegValue(reg.REG_VALUE_CHECKBANNEDPASSWORDONSET, False)


        chkComplexityPoints.Checked = reg.getRegValue(reg.REG_VALUE_CATPASSWORDCOMPLEXITY, False)

        polComplexityPointsRequired.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSREQUIRED, 0)
        polComplexityPointsEachChar.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSPERCHAR, 0)
        polComplexityPointsEachNumber.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSPERNUMBER, 0)
        polComplexityPointsEachLower.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSPERLOWER, 0)
        polComplexityPointsEachUpper.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSPERUPPER, 0)
        polComplexityPointsEachSymbol.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSPERSYMBOL, 0)
        polComplexityPointsUseOfNumber.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSUSEOFNUMBER, 0)
        polComplexityPointsUseOfSymbol.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSUSEOFSYMBOL, 0)
        polComplexityPointsUseOfUpper.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSUSEOFUPPER, 0)
        polComplexityPointsUseOfLower.Value = reg.getRegValue(reg.REG_VALUE_COMPLEXITYPOINTSUSEOFLOWER, 0)

    End Sub

    Private Sub cmbPolicy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPolicy.SelectedIndexChanged
        If (cmbPolicy.SelectedItem <> "") Then
            loadPolicy()
            lblGroup.Visible = True
            lblPassList.Visible = True
            txtGroup.Visible = True
            cmbLists.Visible = True
            chkDisable.Visible = True
            chkRegExpSettings.Visible = True
            chkComplexityPoints.Visible = True
            chkLengthBasedComplexityRules.Visible = True
            FlowLayoutPanel1.Visible = True
            bSetList.Visible = True
            bAddList.Visible = True
            FlowLayoutPanel1.VerticalScroll.Enabled = True
            FlowLayoutPanel1.VerticalScroll.Visible = True
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


End Class
