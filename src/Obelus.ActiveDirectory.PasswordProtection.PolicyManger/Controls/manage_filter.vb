Imports System.Runtime.CompilerServices
Imports Microsoft.Win32

Public Class manage_filter
    Public myHandle As IntPtr
    Public needSave As Boolean = False
    Private reg As New RegistryClass
    Private loading As Boolean = False

    Private Function GetFilterStatus() As Boolean
        Dim status As Boolean = False
        Dim ret As String() = reg.GetNonPolicyOrSettingsValue(reg.REG_BASE_LSA, reg.REG_VALUE_LSA_REGISTER, {""})
        If ret.Contains("lithnetpwdf") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub manage_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading = True
        Dim filterStatus As Boolean = GetFilterStatus()
        If filterStatus Then
            btnToggleFilter.Text = "Disable Filter"
        Else
            btnToggleFilter.Text = "Enable Filter"
        End If
        chkGlobalEnable.Checked = reg.getRegValue(reg.REG_VALUE_ENABLED, False, True)
        chkSimulate.Checked = reg.getRegValue(reg.REG_VALUE_SIMULATE, False, True)
        chkRequireGroupMatch.Checked = reg.getRegValue(reg.REG_VALUE_GROUPMATCH_REQUIRED, False, True)
        chkGroupMatchEnabled.Checked = reg.getRegValue(reg.REG_VALUE_GROUPMATCH, False, True)
        chkAllowSetonError.Checked = reg.getRegValue(reg.REG_VALUE_ALLOWPASSWORDSETONERROR, True, True)
        chkAllowChangeonError.Checked = reg.getRegValue(reg.REG_VALUE_ALLOWPASSWORDCHANGEONERROR, True, True)
        parseControls(Me)
        loading = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub

    Private Sub parseControls(ByVal container As Control)
        For Each c As Control In container.Controls
            If TypeOf c Is CheckBox Then
                AddHandler DirectCast(c, CheckBox).CheckedChanged, AddressOf handleModified
            ElseIf TypeOf c Is NumericUpDown Then
                AddHandler DirectCast(c, NumericUpDown).ValueChanged, AddressOf handleModified
            ElseIf TypeOf c Is TextBox Then
                AddHandler DirectCast(c, TextBox).TextChanged, AddressOf handleModified
            End If
            If c.Controls.Count > 0 Then
                parseControls(c)
            End If
        Next
    End Sub
    Private Sub handleModified(sender As Object, e As EventArgs)
        If Not loading Then
            needSave = True
            bSave.Enabled = True
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim ret As Boolean = False
        If (chkRequireGroupMatch.Checked And Not chkGroupMatchEnabled.Checked) Then
            MsgBox("Error: If you require GroupMatching you must also enable Group Matching", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Settings Error")
        Else
            ret = reg.setRegValue(reg.REG_VALUE_ENABLED, chkGlobalEnable.Checked, True)
            If ret Then ret = reg.setRegValue(reg.REG_VALUE_SIMULATE, chkSimulate.Checked, True)
            If ret Then ret = reg.setRegValue(reg.REG_VALUE_GROUPMATCH_REQUIRED, chkRequireGroupMatch.Checked, True)
            If ret Then ret = reg.setRegValue(reg.REG_VALUE_GROUPMATCH, chkGroupMatchEnabled.Checked, True)
            If ret Then ret = reg.setRegValue(reg.REG_VALUE_ALLOWPASSWORDSETONERROR, chkAllowSetonError.Checked, True)
            If ret Then ret = reg.setRegValue(reg.REG_VALUE_ALLOWPASSWORDCHANGEONERROR, chkAllowChangeonError.Checked, True)
            If ret Then
                MsgBox("Global filter settings saved successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
                bSave.Enabled = False
                needSave = False
            Else
                MsgBox("One or more settings failed to save, please try again", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub Button1_EnabledChanged(sender As Object, e As EventArgs) Handles bSave.EnabledChanged
        If bSave.Enabled Then
            bSave.BackColor = ColorTranslator.FromHtml("#273c75")
        Else
            bSave.BackColor = ColorTranslator.FromHtml("#7f8fa6")
        End If
    End Sub

    Private Sub AddRegistryValue(keyValue As String, valueName As String, valueData As String)
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey(keyValue, True)
        Dim existingValueData As String() = CType(key.GetValue(valueName), String())
        If existingValueData Is Nothing Then
            existingValueData = New String() {}
        End If
        Array.Resize(existingValueData, existingValueData.Length + 1)
        existingValueData(existingValueData.Length - 1) = valueData
        key.SetValue(valueName, existingValueData, RegistryValueKind.MultiString)
        key.Close()
    End Sub

    Private Sub RemoveRegistryValue(keyValue As String, valueName As String, valueData As String)
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey(keyValue, True)
        Dim existingValueData As String() = CType(key.GetValue(valueName), String())
        If existingValueData Is Nothing Then
            existingValueData = New String() {}
        End If
        If existingValueData.Contains(valueData) Then
            existingValueData = existingValueData.Where(Function(x) x <> valueData).ToArray()
            key.SetValue(valueName, existingValueData, RegistryValueKind.MultiString)
        End If
        key.Close()
    End Sub

    Private Sub btnToggleFilter_Click(sender As Object, e As EventArgs) Handles btnToggleFilter.Click
        Dim ret As Boolean = GetFilterStatus()
        Dim valueData As String = "lithnetpwdf"

        If ret Then
            RemoveRegistryValue(reg.REG_BASE_LSA, reg.REG_VALUE_LSA_REGISTER, valueData)
        Else
            AddRegistryValue(reg.REG_BASE_LSA, reg.REG_VALUE_LSA_REGISTER, valueData)
        End If

        ret = GetFilterStatus()
        If ret Then
            btnToggleFilter.Text = "Disable Filter"
        Else
            btnToggleFilter.Text = "Enable Filter"
        End If

        Dim msg As MsgBoxResult = MsgBox("You must restart the server in order to apply changes to the filter." & vbCrLf & vbCrLf & "Would you like to restart now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Restart Required")
        If msg = MsgBoxResult.Yes Then
            Process.Start("shutdown", "-r -t 0")
        End If
    End Sub
End Class
