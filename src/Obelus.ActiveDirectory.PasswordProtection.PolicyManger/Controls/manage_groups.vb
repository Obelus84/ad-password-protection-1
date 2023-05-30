Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class manage_groups
    Private reg As New RegistryClass
    Public myHandle As IntPtr
    Public needsave As Boolean = False


    Private Sub manage_groups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSave.Enabled = False
        LoadGroups()
    End Sub

    Private Sub LoadGroups()
        Dim groups As String() = reg.getDefaultRegValue(reg.REG_BASE_GROUPS, "").ToString.Split(",")
        Dim cmbItem = reg.getPolicies()
        Dim mapping As Dictionary(Of String, String) = reg.getGroupMapping
        If groups.Length > 0 Then
            For Each group As String In groups
                lvGroups.Items.Add(group)
                Dim c As New text_combo_control
                c.TextBox1.Text = group
                c.SetComboBox(cmbItem, mapping(group))
                'c.ComboBox1.Items.AddRange(cmbItem)
                'c.ComboBox1.SelectedIndex = c.ComboBox1.Items.IndexOf(mapping(group))
                c.parentwindow = Me.Handle
                If c.needSave Then
                    needsave = True
                    bSave.Enabled = True
                End If
                flpMapping.Controls.Add(c)
            Next
            lvGroups.Columns(ColumnHeader1.Index).Width = lvGroups.Width - 5
        Else
            MsgBox("No groups found", MsgBoxStyle.Critical, "Error")
        End If

        'For Each itm As KeyValuePair(Of String, String) In mapping

        'Next
    End Sub
    Private Sub setneedSave()
        needsave = True
        bSave.Enabled = True
    End Sub
    Private Sub bUp_Click(sender As Object, e As EventArgs) Handles bUp.Click
        If lvGroups.SelectedItems.Count = 1 Then
            setneedSave()
            Dim item As ListViewItem = lvGroups.SelectedItems(0)
            Dim index As Integer = item.Index
            If index > 0 Then
                lvGroups.Items.RemoveAt(index)
                lvGroups.Items.Insert(index - 1, item)
                lvGroups.Items(index - 1).Selected = True
                flpMapping.SuspendLayout()
                Dim ctrl As Control = GetControlIndex(flpMapping, item.Text)
                If ctrl IsNot Nothing Then
                    flpMapping.Controls.SetChildIndex(ctrl, flpMapping.Controls.IndexOf(ctrl) - 1)
                End If
                flpMapping.ResumeLayout()
            End If
        End If
    End Sub
    Private Sub bUp_Hover(sender As Object, e As EventArgs) Handles bUp.MouseEnter
        bUp.Image = My.Resources.arrow_up_over
    End Sub
    Private Sub bUp_nHover(sender As Object, e As EventArgs) Handles bUp.MouseLeave
        bUp.Image = My.Resources.arrow_up
    End Sub
    Private Sub bDown_Hover(sender As Object, e As EventArgs) Handles bDown.MouseEnter
        bDown.Image = My.Resources.arrow_down_over
    End Sub
    Private Sub bDown_nHover(sender As Object, e As EventArgs) Handles bDown.MouseEnter
        bDown.Image = My.Resources.arrow_down
    End Sub

    Private Function GetControlIndex(ByRef flowLayoutPanel As FlowLayoutPanel, ByVal searchValue As String) As Control
        For Each control As text_combo_control In flowLayoutPanel.Controls().Find("text_combo_control", False)
            If control.TextBox1.Text = searchValue Then
                Return control
            End If
        Next
        Return Nothing
    End Function

    Private Sub bDown_Click(sender As Object, e As EventArgs) Handles bDown.Click
        If lvGroups.SelectedItems.Count = 1 Then
            setneedSave()
            Dim item As ListViewItem = lvGroups.SelectedItems(0)
            Dim index As Integer = item.Index
            If index < lvGroups.Items.Count - 1 Then
                lvGroups.Items.RemoveAt(index)
                lvGroups.Items.Insert(index + 1, item)
                lvGroups.Items(index + 1).Selected = True
                flpMapping.SuspendLayout()
                Dim ctrl As Control = GetControlIndex(flpMapping, item.Text)
                If ctrl IsNot Nothing Then
                    flpMapping.Controls.SetChildIndex(ctrl, flpMapping.Controls.IndexOf(ctrl) + 1)
                End If
                flpMapping.ResumeLayout()
            End If
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim sb As New StringBuilder()
        Dim ret As Boolean
        For i = 0 To lvGroups.Items.Count - 1
            sb.Append(lvGroups.Items(i).Text)
            If i < lvGroups.Items.Count - 1 Then
                sb.Append(",")
            End If
        Next

        ret = reg.setDefaultRegValue(reg.REG_BASE_GROUPS, sb.ToString())
        If ret = True Then
            Dim gm As New Dictionary(Of String, String)
            For Each control As text_combo_control In flpMapping.Controls().Find("text_combo_control", False)
                gm.Add(control.TextBox1.Text, control.ComboBox1.SelectedItem)
            Next
            If gm.Count > 0 Then
                ret = reg.setGroupMapping(gm)
            End If
        End If
        If ret Then
            needsave = False
            bSave.Enabled = False
            MsgBox("Groups and group mapping settings saved successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
        Else
            MsgBox("There was an error trying to save the settings on this page, please try again", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub bCloseForm_Click(sender As Object, e As EventArgs) Handles bCloseForm.Click
        Dim ctrl2Remove As Control = Control.FromHandle(myHandle)
        If ctrl2Remove IsNot Nothing Then
            ctrl2Remove.Dispose()
        End If
    End Sub
    Private Sub Button1_EnabledChanged(sender As Object, e As EventArgs)
        If bSave.Enabled Then
            bSave.BackColor = ColorTranslator.FromHtml("#273c75")
        Else
            bSave.BackColor = ColorTranslator.FromHtml("#7f8fa6")
        End If
    End Sub
End Class
