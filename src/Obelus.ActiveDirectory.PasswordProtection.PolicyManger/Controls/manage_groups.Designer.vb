<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manage_groups
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If needsave Then
            Dim answ As MsgBoxResult = MsgBox("You may have settings that need to be changed, are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
            If answ = MsgBoxResult.Yes Then

            ElseIf answ = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_groups))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bCloseForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.flpMapping = New System.Windows.Forms.FlowLayoutPanel()
        Me.bDown = New System.Windows.Forms.Button()
        Me.bUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvGroups = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.bSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bCloseForm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.flpMapping)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bDown)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bUp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvGroups)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 422)
        Me.SplitContainer1.SplitterDistance = 98
        Me.SplitContainer1.TabIndex = 2
        '
        'bCloseForm
        '
        Me.bCloseForm.FlatAppearance.BorderSize = 0
        Me.bCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCloseForm.Location = New System.Drawing.Point(3, 3)
        Me.bCloseForm.Name = "bCloseForm"
        Me.bCloseForm.Size = New System.Drawing.Size(33, 27)
        Me.bCloseForm.TabIndex = 46
        Me.bCloseForm.Text = "X"
        Me.bCloseForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(110, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Below are the settings for managing group matching and priorities"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 603)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 71
        '
        'flpMapping
        '
        Me.flpMapping.AutoSize = True
        Me.flpMapping.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMapping.Location = New System.Drawing.Point(15, 310)
        Me.flpMapping.Name = "flpMapping"
        Me.flpMapping.Size = New System.Drawing.Size(749, 138)
        Me.flpMapping.TabIndex = 9
        '
        'bDown
        '
        Me.bDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDown.FlatAppearance.BorderSize = 0
        Me.bDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDown.Image = Global.Obelus.ActiveDirectory.PasswordProtection.PolicyManger.My.Resources.Resources.arrow_down
        Me.bDown.Location = New System.Drawing.Point(266, 206)
        Me.bDown.Name = "bDown"
        Me.bDown.Size = New System.Drawing.Size(31, 47)
        Me.bDown.TabIndex = 6
        Me.bDown.UseVisualStyleBackColor = True
        '
        'bUp
        '
        Me.bUp.BackColor = System.Drawing.Color.Transparent
        Me.bUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bUp.FlatAppearance.BorderSize = 0
        Me.bUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUp.Image = Global.Obelus.ActiveDirectory.PasswordProtection.PolicyManger.My.Resources.Resources.arrow_up
        Me.bUp.Location = New System.Drawing.Point(266, 105)
        Me.bUp.Name = "bUp"
        Me.bUp.Size = New System.Drawing.Size(31, 47)
        Me.bUp.TabIndex = 5
        Me.bUp.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(766, 44)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Group to policy mapping. This is where the policies can be matched to particular " &
    "goups. "
        '
        'lvGroups
        '
        Me.lvGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvGroups.FullRowSelect = True
        Me.lvGroups.GridLines = True
        Me.lvGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvGroups.HideSelection = False
        Me.lvGroups.Location = New System.Drawing.Point(15, 105)
        Me.lvGroups.MultiSelect = False
        Me.lvGroups.Name = "lvGroups"
        Me.lvGroups.Size = New System.Drawing.Size(245, 148)
        Me.lvGroups.TabIndex = 3
        Me.lvGroups.UseCompatibleStateImageBehavior = False
        Me.lvGroups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Groups"
        Me.ColumnHeader1.Width = 250
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(766, 92)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bSave.FlatAppearance.BorderSize = 0
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.bSave.Location = New System.Drawing.Point(632, 45)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(132, 34)
        Me.bSave.TabIndex = 71
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'manage_groups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "manage_groups"
        Me.Size = New System.Drawing.Size(800, 422)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents bCloseForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bDown As Button
    Friend WithEvents bUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lvGroups As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents flpMapping As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents bSave As Button
End Class
