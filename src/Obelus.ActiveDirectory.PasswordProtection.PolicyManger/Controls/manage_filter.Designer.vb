<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manage_filter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If needSave Then
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bCloseForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAllowChangeonError = New System.Windows.Forms.CheckBox()
        Me.chkAllowSetonError = New System.Windows.Forms.CheckBox()
        Me.chkGroupMatchEnabled = New System.Windows.Forms.CheckBox()
        Me.bSave = New System.Windows.Forms.Button()
        Me.chkSimulate = New System.Windows.Forms.CheckBox()
        Me.chkRequireGroupMatch = New System.Windows.Forms.CheckBox()
        Me.chkGlobalEnable = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnToggleFilter = New System.Windows.Forms.Button()
        Me.lFilterStatus = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.bCloseForm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkAllowChangeonError)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkAllowSetonError)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkGroupMatchEnabled)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkSimulate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkRequireGroupMatch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkGlobalEnable)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnToggleFilter)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lFilterStatus)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Lable1)
        Me.SplitContainer1.Size = New System.Drawing.Size(831, 519)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.TabIndex = 3
        '
        'bCloseForm
        '
        Me.bCloseForm.FlatAppearance.BorderSize = 0
        Me.bCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCloseForm.Location = New System.Drawing.Point(3, 3)
        Me.bCloseForm.Name = "bCloseForm"
        Me.bCloseForm.Size = New System.Drawing.Size(33, 27)
        Me.bCloseForm.TabIndex = 45
        Me.bCloseForm.Text = "X"
        Me.bCloseForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(198, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Below are global settings relating to basic passoword filter functionality."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 73
        '
        'chkAllowChangeonError
        '
        Me.chkAllowChangeonError.AutoSize = True
        Me.chkAllowChangeonError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkAllowChangeonError.Location = New System.Drawing.Point(41, 288)
        Me.chkAllowChangeonError.Name = "chkAllowChangeonError"
        Me.chkAllowChangeonError.Size = New System.Drawing.Size(229, 20)
        Me.chkAllowChangeonError.TabIndex = 72
        Me.chkAllowChangeonError.Text = "Allow password CHANGE on error"
        Me.chkAllowChangeonError.UseVisualStyleBackColor = True
        '
        'chkAllowSetonError
        '
        Me.chkAllowSetonError.AutoSize = True
        Me.chkAllowSetonError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkAllowSetonError.Location = New System.Drawing.Point(41, 262)
        Me.chkAllowSetonError.Name = "chkAllowSetonError"
        Me.chkAllowSetonError.Size = New System.Drawing.Size(199, 20)
        Me.chkAllowSetonError.TabIndex = 71
        Me.chkAllowSetonError.Text = "Allow password SET on error"
        Me.chkAllowSetonError.UseVisualStyleBackColor = True
        '
        'chkGroupMatchEnabled
        '
        Me.chkGroupMatchEnabled.AutoSize = True
        Me.chkGroupMatchEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkGroupMatchEnabled.Location = New System.Drawing.Point(41, 199)
        Me.chkGroupMatchEnabled.Name = "chkGroupMatchEnabled"
        Me.chkGroupMatchEnabled.Size = New System.Drawing.Size(569, 20)
        Me.chkGroupMatchEnabled.TabIndex = 70
        Me.chkGroupMatchEnabled.Text = "Enable group matching (Check this box to enable group matching, no match = Defaul" &
    "t policy)"
        Me.chkGroupMatchEnabled.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bSave.Enabled = False
        Me.bSave.FlatAppearance.BorderSize = 0
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.bSave.Location = New System.Drawing.Point(324, 350)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(132, 34)
        Me.bSave.TabIndex = 69
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'chkSimulate
        '
        Me.chkSimulate.AutoSize = True
        Me.chkSimulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkSimulate.Location = New System.Drawing.Point(41, 157)
        Me.chkSimulate.Name = "chkSimulate"
        Me.chkSimulate.Size = New System.Drawing.Size(599, 36)
        Me.chkSimulate.TabIndex = 68
        Me.chkSimulate.Text = "Simlation (Enables/Disables global simulation. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    If enabled p" &
    "asswords will still be processed by the filter but polcies will not be enforced)" &
    ""
        Me.chkSimulate.UseVisualStyleBackColor = True
        '
        'chkRequireGroupMatch
        '
        Me.chkRequireGroupMatch.AutoSize = True
        Me.chkRequireGroupMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkRequireGroupMatch.Location = New System.Drawing.Point(41, 225)
        Me.chkRequireGroupMatch.Name = "chkRequireGroupMatch"
        Me.chkRequireGroupMatch.Size = New System.Drawing.Size(608, 20)
        Me.chkRequireGroupMatch.TabIndex = 67
        Me.chkRequireGroupMatch.Text = "Require group match (Unchecking will apply the default policy to all users who do" &
    "n't match a group)"
        Me.chkRequireGroupMatch.UseVisualStyleBackColor = True
        '
        'chkGlobalEnable
        '
        Me.chkGlobalEnable.AutoSize = True
        Me.chkGlobalEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkGlobalEnable.Location = New System.Drawing.Point(41, 131)
        Me.chkGlobalEnable.Name = "chkGlobalEnable"
        Me.chkGlobalEnable.Size = New System.Drawing.Size(638, 20)
        Me.chkGlobalEnable.TabIndex = 66
        Me.chkGlobalEnable.Text = "Enforce Filter (Enables/Disables the password filter globally. If unchecked the f" &
    "ilter will still produce logs)"
        Me.chkGlobalEnable.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(19, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Filtering Functions:"
        '
        'btnToggleFilter
        '
        Me.btnToggleFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnToggleFilter.FlatAppearance.BorderSize = 0
        Me.btnToggleFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnToggleFilter.Location = New System.Drawing.Point(22, 48)
        Me.btnToggleFilter.Name = "btnToggleFilter"
        Me.btnToggleFilter.Size = New System.Drawing.Size(132, 34)
        Me.btnToggleFilter.TabIndex = 4
        Me.btnToggleFilter.Text = "Button1"
        Me.btnToggleFilter.UseVisualStyleBackColor = False
        '
        'lFilterStatus
        '
        Me.lFilterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lFilterStatus.Location = New System.Drawing.Point(448, 19)
        Me.lFilterStatus.Name = "lFilterStatus"
        Me.lFilterStatus.Size = New System.Drawing.Size(355, 16)
        Me.lFilterStatus.TabIndex = 3
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Lable1.Location = New System.Drawing.Point(19, 19)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(423, 16)
        Me.Lable1.TabIndex = 2
        Me.Lable1.Text = "Current filtering status (click button below to change. Requires Restart): "
        '
        'manage_filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "manage_filter"
        Me.Size = New System.Drawing.Size(831, 519)
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
    Friend WithEvents chkRequireGroupMatch As CheckBox
    Friend WithEvents chkGlobalEnable As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnToggleFilter As Button
    Friend WithEvents lFilterStatus As Label
    Friend WithEvents Lable1 As Label
    Friend WithEvents chkSimulate As CheckBox
    Friend WithEvents bSave As Button
    Friend WithEvents chkGroupMatchEnabled As CheckBox
    Friend WithEvents chkAllowChangeonError As CheckBox
    Friend WithEvents chkAllowSetonError As CheckBox
    Friend WithEvents Label3 As Label
End Class
