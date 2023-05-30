<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class policy_control
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bSave = New System.Windows.Forms.Button()
        Me.chkSimulate = New System.Windows.Forms.CheckBox()
        Me.lGroupPolicyAssignment = New System.Windows.Forms.Label()
        Me.bCloseForm = New System.Windows.Forms.Button()
        Me.chkEnable = New System.Windows.Forms.CheckBox()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.chkRegExpSettings = New System.Windows.Forms.CheckBox()
        Me.chkLengthBasedComplexityRules = New System.Windows.Forms.CheckBox()
        Me.chkComplexityPoints = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPolicy = New System.Windows.Forms.ComboBox()
        Me.pRegExp = New System.Windows.Forms.Panel()
        Me.txtRegexReject = New System.Windows.Forms.TextBox()
        Me.chkEnableRegexApprove = New System.Windows.Forms.CheckBox()
        Me.chkEnableRegexReject = New System.Windows.Forms.CheckBox()
        Me.txtRegexApprove = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegExp = New System.Windows.Forms.Button()
        Me.pLengthBased = New System.Windows.Forms.Panel()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTLevel = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtThresholdPassword = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.polCT3CharacterSetsRequired = New System.Windows.Forms.NumericUpDown()
        Me.polCT3SymbolOrNumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT3NumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT3SymbolRequired = New System.Windows.Forms.CheckBox()
        Me.polCT3UpperRequired = New System.Windows.Forms.CheckBox()
        Me.polCT3LowerRequired = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.polCT2SymbolOrNumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT2NumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT2SymbolRequired = New System.Windows.Forms.CheckBox()
        Me.polCT2UpperRequired = New System.Windows.Forms.CheckBox()
        Me.polCT2LowerRequired = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.polCT2CharacterSetsRequired = New System.Windows.Forms.NumericUpDown()
        Me.polCT2 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.polCT1SymbolOrNumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT1NumberRequired = New System.Windows.Forms.CheckBox()
        Me.polCT1SymbolRequired = New System.Windows.Forms.CheckBox()
        Me.polCT1UpperRequired = New System.Windows.Forms.CheckBox()
        Me.polCT1LowerRequired = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.polCT1CharacterSetsRequired = New System.Windows.Forms.NumericUpDown()
        Me.polCT1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLengthBased = New System.Windows.Forms.Button()
        Me.pComplexityPoints = New System.Windows.Forms.Panel()
        Me.lPoints = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.prgPWTest = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPWTest = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.polComplexityPointsUseOfLower = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.polComplexityPointsRequired = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsEachChar = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsEachNumber = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsEachLower = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsEachUpper = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsEachSymbol = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsUseOfNumber = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsUseOfSymbol = New System.Windows.Forms.NumericUpDown()
        Me.polComplexityPointsUseOfUpper = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnPasswordPts = New System.Windows.Forms.Button()
        Me.pBasic = New System.Windows.Forms.Panel()
        Me.cmbLists = New System.Windows.Forms.ComboBox()
        Me.bSetList = New System.Windows.Forms.Button()
        Me.lblPassList = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.polMinPasswordLength = New System.Windows.Forms.NumericUpDown()
        Me.polMaxPasswordLength = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.polRejectNormalizedPasswordsinPasswordStoreSet = New System.Windows.Forms.CheckBox()
        Me.polRejectPasswordStoreSet = New System.Windows.Forms.CheckBox()
        Me.polRejectContainAccountNameSet = New System.Windows.Forms.CheckBox()
        Me.polRejectNormalizedPasswordsinWordListSet = New System.Windows.Forms.CheckBox()
        Me.polRejectNormalizedPasswordsinWordListChange = New System.Windows.Forms.CheckBox()
        Me.polRejectNormalizedPasswordsinPasswordStoreChange = New System.Windows.Forms.CheckBox()
        Me.polRejectPasswordStoreChange = New System.Windows.Forms.CheckBox()
        Me.polRejectContainAccountNameChange = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnBasicSettings = New System.Windows.Forms.Button()
        Me.bAddPolicy = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pRegExp.SuspendLayout()
        Me.pLengthBased.SuspendLayout()
        CType(Me.polCT3CharacterSetsRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polCT2CharacterSetsRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polCT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polCT1CharacterSetsRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polCT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pComplexityPoints.SuspendLayout()
        CType(Me.polComplexityPointsUseOfLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsRequired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsEachChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsEachNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsEachLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsEachUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsEachSymbol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsUseOfNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsUseOfSymbol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polComplexityPointsUseOfUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBasic.SuspendLayout()
        CType(Me.polMinPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.polMaxPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.bAddPolicy)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkSimulate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lGroupPolicyAssignment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bCloseForm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkEnable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblGroup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkRegExpSettings)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkLengthBasedComplexityRules)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkComplexityPoints)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbPolicy)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.pRegExp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRegExp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pLengthBased)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLengthBased)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pComplexityPoints)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPasswordPts)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pBasic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBasicSettings)
        Me.SplitContainer1.Size = New System.Drawing.Size(794, 444)
        Me.SplitContainer1.SplitterDistance = 149
        Me.SplitContainer1.TabIndex = 0
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bSave.FlatAppearance.BorderSize = 0
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.bSave.Location = New System.Drawing.Point(635, 93)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(132, 34)
        Me.bSave.TabIndex = 71
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'chkSimulate
        '
        Me.chkSimulate.AutoSize = True
        Me.chkSimulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkSimulate.Location = New System.Drawing.Point(180, 93)
        Me.chkSimulate.Name = "chkSimulate"
        Me.chkSimulate.Size = New System.Drawing.Size(88, 20)
        Me.chkSimulate.TabIndex = 46
        Me.chkSimulate.Text = "Simulation"
        Me.chkSimulate.UseVisualStyleBackColor = True
        '
        'lGroupPolicyAssignment
        '
        Me.lGroupPolicyAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lGroupPolicyAssignment.Location = New System.Drawing.Point(482, 35)
        Me.lGroupPolicyAssignment.Name = "lGroupPolicyAssignment"
        Me.lGroupPolicyAssignment.Size = New System.Drawing.Size(295, 44)
        Me.lGroupPolicyAssignment.TabIndex = 45
        '
        'bCloseForm
        '
        Me.bCloseForm.FlatAppearance.BorderSize = 0
        Me.bCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCloseForm.Location = New System.Drawing.Point(3, 3)
        Me.bCloseForm.Name = "bCloseForm"
        Me.bCloseForm.Size = New System.Drawing.Size(33, 27)
        Me.bCloseForm.TabIndex = 44
        Me.bCloseForm.Text = "X"
        Me.bCloseForm.UseVisualStyleBackColor = True
        '
        'chkEnable
        '
        Me.chkEnable.AutoSize = True
        Me.chkEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkEnable.Location = New System.Drawing.Point(43, 93)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(131, 20)
        Me.chkEnable.TabIndex = 43
        Me.chkEnable.Text = "Enable this policy"
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGroup.Location = New System.Drawing.Point(482, 14)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(151, 16)
        Me.lblGroup.TabIndex = 42
        Me.lblGroup.Text = "Groups using this policy:"
        '
        'chkRegExpSettings
        '
        Me.chkRegExpSettings.AutoSize = True
        Me.chkRegExpSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkRegExpSettings.Location = New System.Drawing.Point(327, 93)
        Me.chkRegExpSettings.Name = "chkRegExpSettings"
        Me.chkRegExpSettings.Size = New System.Drawing.Size(232, 20)
        Me.chkRegExpSettings.TabIndex = 39
        Me.chkRegExpSettings.Text = "Enable regular expression settings"
        Me.chkRegExpSettings.UseVisualStyleBackColor = True
        '
        'chkLengthBasedComplexityRules
        '
        Me.chkLengthBasedComplexityRules.AutoSize = True
        Me.chkLengthBasedComplexityRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkLengthBasedComplexityRules.Location = New System.Drawing.Point(327, 116)
        Me.chkLengthBasedComplexityRules.Name = "chkLengthBasedComplexityRules"
        Me.chkLengthBasedComplexityRules.Size = New System.Drawing.Size(250, 20)
        Me.chkLengthBasedComplexityRules.TabIndex = 38
        Me.chkLengthBasedComplexityRules.Text = "Enable length-based complexity rules"
        Me.chkLengthBasedComplexityRules.UseVisualStyleBackColor = True
        '
        'chkComplexityPoints
        '
        Me.chkComplexityPoints.AutoSize = True
        Me.chkComplexityPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkComplexityPoints.Location = New System.Drawing.Point(43, 116)
        Me.chkComplexityPoints.Name = "chkComplexityPoints"
        Me.chkComplexityPoints.Size = New System.Drawing.Size(276, 20)
        Me.chkComplexityPoints.TabIndex = 37
        Me.chkComplexityPoints.Text = "Enable password complexity point system"
        Me.chkComplexityPoints.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(42, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Policy:"
        '
        'cmbPolicy
        '
        Me.cmbPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPolicy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbPolicy.FormattingEnabled = True
        Me.cmbPolicy.Location = New System.Drawing.Point(95, 19)
        Me.cmbPolicy.Name = "cmbPolicy"
        Me.cmbPolicy.Size = New System.Drawing.Size(176, 24)
        Me.cmbPolicy.TabIndex = 33
        '
        'pRegExp
        '
        Me.pRegExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pRegExp.Controls.Add(Me.txtRegexReject)
        Me.pRegExp.Controls.Add(Me.chkEnableRegexApprove)
        Me.pRegExp.Controls.Add(Me.chkEnableRegexReject)
        Me.pRegExp.Controls.Add(Me.txtRegexApprove)
        Me.pRegExp.Controls.Add(Me.Label7)
        Me.pRegExp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pRegExp.Location = New System.Drawing.Point(0, 1586)
        Me.pRegExp.Name = "pRegExp"
        Me.pRegExp.Size = New System.Drawing.Size(777, 133)
        Me.pRegExp.TabIndex = 10
        Me.pRegExp.Visible = False
        '
        'txtRegexReject
        '
        Me.txtRegexReject.Enabled = False
        Me.txtRegexReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtRegexReject.Location = New System.Drawing.Point(240, 95)
        Me.txtRegexReject.Name = "txtRegexReject"
        Me.txtRegexReject.Size = New System.Drawing.Size(350, 22)
        Me.txtRegexReject.TabIndex = 91
        '
        'chkEnableRegexApprove
        '
        Me.chkEnableRegexApprove.AutoSize = True
        Me.chkEnableRegexApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkEnableRegexApprove.Location = New System.Drawing.Point(29, 57)
        Me.chkEnableRegexApprove.Name = "chkEnableRegexApprove"
        Me.chkEnableRegexApprove.Size = New System.Drawing.Size(199, 20)
        Me.chkEnableRegexApprove.TabIndex = 90
        Me.chkEnableRegexApprove.Text = "Enable regex approve match"
        Me.chkEnableRegexApprove.UseVisualStyleBackColor = True
        '
        'chkEnableRegexReject
        '
        Me.chkEnableRegexReject.AutoSize = True
        Me.chkEnableRegexReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkEnableRegexReject.Location = New System.Drawing.Point(29, 97)
        Me.chkEnableRegexReject.Name = "chkEnableRegexReject"
        Me.chkEnableRegexReject.Size = New System.Drawing.Size(181, 20)
        Me.chkEnableRegexReject.TabIndex = 89
        Me.chkEnableRegexReject.Text = "Enable regex reject match"
        Me.chkEnableRegexReject.UseVisualStyleBackColor = True
        '
        'txtRegexApprove
        '
        Me.txtRegexApprove.Enabled = False
        Me.txtRegexApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtRegexApprove.Location = New System.Drawing.Point(240, 57)
        Me.txtRegexApprove.Name = "txtRegexApprove"
        Me.txtRegexApprove.Size = New System.Drawing.Size(350, 22)
        Me.txtRegexApprove.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(20, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Regular expression"
        '
        'btnRegExp
        '
        Me.btnRegExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnRegExp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnRegExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnRegExp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRegExp.Location = New System.Drawing.Point(0, 1551)
        Me.btnRegExp.Name = "btnRegExp"
        Me.btnRegExp.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnRegExp.Size = New System.Drawing.Size(777, 35)
        Me.btnRegExp.TabIndex = 9
        Me.btnRegExp.Text = "Regular Expression Settings"
        Me.btnRegExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegExp.UseVisualStyleBackColor = False
        '
        'pLengthBased
        '
        Me.pLengthBased.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pLengthBased.Controls.Add(Me.lblResult)
        Me.pLengthBased.Controls.Add(Me.lblTLevel)
        Me.pLengthBased.Controls.Add(Me.Label37)
        Me.pLengthBased.Controls.Add(Me.Label24)
        Me.pLengthBased.Controls.Add(Me.Label38)
        Me.pLengthBased.Controls.Add(Me.txtThresholdPassword)
        Me.pLengthBased.Controls.Add(Me.Label39)
        Me.pLengthBased.Controls.Add(Me.polCT3CharacterSetsRequired)
        Me.pLengthBased.Controls.Add(Me.polCT3SymbolOrNumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT3NumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT3SymbolRequired)
        Me.pLengthBased.Controls.Add(Me.polCT3UpperRequired)
        Me.pLengthBased.Controls.Add(Me.polCT3LowerRequired)
        Me.pLengthBased.Controls.Add(Me.Label15)
        Me.pLengthBased.Controls.Add(Me.Label16)
        Me.pLengthBased.Controls.Add(Me.Label17)
        Me.pLengthBased.Controls.Add(Me.Label18)
        Me.pLengthBased.Controls.Add(Me.polCT2SymbolOrNumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT2NumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT2SymbolRequired)
        Me.pLengthBased.Controls.Add(Me.polCT2UpperRequired)
        Me.pLengthBased.Controls.Add(Me.polCT2LowerRequired)
        Me.pLengthBased.Controls.Add(Me.Label11)
        Me.pLengthBased.Controls.Add(Me.polCT2CharacterSetsRequired)
        Me.pLengthBased.Controls.Add(Me.polCT2)
        Me.pLengthBased.Controls.Add(Me.Label12)
        Me.pLengthBased.Controls.Add(Me.Label13)
        Me.pLengthBased.Controls.Add(Me.Label14)
        Me.pLengthBased.Controls.Add(Me.polCT1SymbolOrNumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT1NumberRequired)
        Me.pLengthBased.Controls.Add(Me.polCT1SymbolRequired)
        Me.pLengthBased.Controls.Add(Me.polCT1UpperRequired)
        Me.pLengthBased.Controls.Add(Me.polCT1LowerRequired)
        Me.pLengthBased.Controls.Add(Me.Label10)
        Me.pLengthBased.Controls.Add(Me.polCT1CharacterSetsRequired)
        Me.pLengthBased.Controls.Add(Me.polCT1)
        Me.pLengthBased.Controls.Add(Me.Label6)
        Me.pLengthBased.Controls.Add(Me.Label5)
        Me.pLengthBased.Controls.Add(Me.Label2)
        Me.pLengthBased.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLengthBased.Location = New System.Drawing.Point(0, 672)
        Me.pLengthBased.Name = "pLengthBased"
        Me.pLengthBased.Size = New System.Drawing.Size(777, 879)
        Me.pLengthBased.TabIndex = 12
        Me.pLengthBased.Visible = False
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblResult.Location = New System.Drawing.Point(436, 48)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 16)
        Me.lblResult.TabIndex = 98
        '
        'lblTLevel
        '
        Me.lblTLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTLevel.Location = New System.Drawing.Point(436, 21)
        Me.lblTLevel.Name = "lblTLevel"
        Me.lblTLevel.Size = New System.Drawing.Size(89, 16)
        Me.lblTLevel.TabIndex = 97
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label37.Location = New System.Drawing.Point(320, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 16)
        Me.Label37.TabIndex = 96
        Me.Label37.Text = "Result:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(320, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 16)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Threshold Level: "
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label38.Location = New System.Drawing.Point(27, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(149, 16)
        Me.Label38.TabIndex = 94
        Me.Label38.Text = "Enter a password to test"
        '
        'txtThresholdPassword
        '
        Me.txtThresholdPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtThresholdPassword.Location = New System.Drawing.Point(27, 72)
        Me.txtThresholdPassword.Name = "txtThresholdPassword"
        Me.txtThresholdPassword.Size = New System.Drawing.Size(267, 22)
        Me.txtThresholdPassword.TabIndex = 93
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label39.Location = New System.Drawing.Point(27, 21)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(103, 16)
        Me.Label39.TabIndex = 92
        Me.Label39.Text = "Real Time Test:"
        '
        'polCT3CharacterSetsRequired
        '
        Me.polCT3CharacterSetsRequired.Location = New System.Drawing.Point(572, 696)
        Me.polCT3CharacterSetsRequired.Name = "polCT3CharacterSetsRequired"
        Me.polCT3CharacterSetsRequired.Size = New System.Drawing.Size(49, 20)
        Me.polCT3CharacterSetsRequired.TabIndex = 91
        '
        'polCT3SymbolOrNumberRequired
        '
        Me.polCT3SymbolOrNumberRequired.AutoSize = True
        Me.polCT3SymbolOrNumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT3SymbolOrNumberRequired.Location = New System.Drawing.Point(16, 847)
        Me.polCT3SymbolOrNumberRequired.Name = "polCT3SymbolOrNumberRequired"
        Me.polCT3SymbolOrNumberRequired.Size = New System.Drawing.Size(136, 20)
        Me.polCT3SymbolOrNumberRequired.TabIndex = 89
        Me.polCT3SymbolOrNumberRequired.Text = "Number or symbol"
        Me.polCT3SymbolOrNumberRequired.UseVisualStyleBackColor = True
        '
        'polCT3NumberRequired
        '
        Me.polCT3NumberRequired.AutoSize = True
        Me.polCT3NumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT3NumberRequired.Location = New System.Drawing.Point(16, 824)
        Me.polCT3NumberRequired.Name = "polCT3NumberRequired"
        Me.polCT3NumberRequired.Size = New System.Drawing.Size(74, 20)
        Me.polCT3NumberRequired.TabIndex = 88
        Me.polCT3NumberRequired.Text = "Number"
        Me.polCT3NumberRequired.UseVisualStyleBackColor = True
        '
        'polCT3SymbolRequired
        '
        Me.polCT3SymbolRequired.AutoSize = True
        Me.polCT3SymbolRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT3SymbolRequired.Location = New System.Drawing.Point(16, 801)
        Me.polCT3SymbolRequired.Name = "polCT3SymbolRequired"
        Me.polCT3SymbolRequired.Size = New System.Drawing.Size(72, 20)
        Me.polCT3SymbolRequired.TabIndex = 87
        Me.polCT3SymbolRequired.Text = "Symbol"
        Me.polCT3SymbolRequired.UseVisualStyleBackColor = True
        '
        'polCT3UpperRequired
        '
        Me.polCT3UpperRequired.AutoSize = True
        Me.polCT3UpperRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT3UpperRequired.Location = New System.Drawing.Point(16, 778)
        Me.polCT3UpperRequired.Name = "polCT3UpperRequired"
        Me.polCT3UpperRequired.Size = New System.Drawing.Size(129, 20)
        Me.polCT3UpperRequired.TabIndex = 86
        Me.polCT3UpperRequired.Text = "Upper case letter"
        Me.polCT3UpperRequired.UseVisualStyleBackColor = True
        '
        'polCT3LowerRequired
        '
        Me.polCT3LowerRequired.AutoSize = True
        Me.polCT3LowerRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT3LowerRequired.Location = New System.Drawing.Point(16, 755)
        Me.polCT3LowerRequired.Name = "polCT3LowerRequired"
        Me.polCT3LowerRequired.Size = New System.Drawing.Size(127, 20)
        Me.polCT3LowerRequired.TabIndex = 85
        Me.polCT3LowerRequired.Text = "Lower case letter"
        Me.polCT3LowerRequired.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(10, 726)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(325, 16)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Alternatively, specify the exact character sets required"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(10, 696)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(549, 16)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Total number of character sets required (number, symbol, uppercase letter, lowerc" &
    "ase letter)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(10, 669)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(494, 16)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "For passwords longer than the second threshold apploy the following requirements"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(13, 631)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Threshold level 3"
        '
        'polCT2SymbolOrNumberRequired
        '
        Me.polCT2SymbolOrNumberRequired.AutoSize = True
        Me.polCT2SymbolOrNumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT2SymbolOrNumberRequired.Location = New System.Drawing.Point(20, 595)
        Me.polCT2SymbolOrNumberRequired.Name = "polCT2SymbolOrNumberRequired"
        Me.polCT2SymbolOrNumberRequired.Size = New System.Drawing.Size(136, 20)
        Me.polCT2SymbolOrNumberRequired.TabIndex = 80
        Me.polCT2SymbolOrNumberRequired.Text = "Number or symbol"
        Me.polCT2SymbolOrNumberRequired.UseVisualStyleBackColor = True
        '
        'polCT2NumberRequired
        '
        Me.polCT2NumberRequired.AutoSize = True
        Me.polCT2NumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT2NumberRequired.Location = New System.Drawing.Point(20, 572)
        Me.polCT2NumberRequired.Name = "polCT2NumberRequired"
        Me.polCT2NumberRequired.Size = New System.Drawing.Size(74, 20)
        Me.polCT2NumberRequired.TabIndex = 79
        Me.polCT2NumberRequired.Text = "Number"
        Me.polCT2NumberRequired.UseVisualStyleBackColor = True
        '
        'polCT2SymbolRequired
        '
        Me.polCT2SymbolRequired.AutoSize = True
        Me.polCT2SymbolRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT2SymbolRequired.Location = New System.Drawing.Point(20, 549)
        Me.polCT2SymbolRequired.Name = "polCT2SymbolRequired"
        Me.polCT2SymbolRequired.Size = New System.Drawing.Size(72, 20)
        Me.polCT2SymbolRequired.TabIndex = 78
        Me.polCT2SymbolRequired.Text = "Symbol"
        Me.polCT2SymbolRequired.UseVisualStyleBackColor = True
        '
        'polCT2UpperRequired
        '
        Me.polCT2UpperRequired.AutoSize = True
        Me.polCT2UpperRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT2UpperRequired.Location = New System.Drawing.Point(20, 526)
        Me.polCT2UpperRequired.Name = "polCT2UpperRequired"
        Me.polCT2UpperRequired.Size = New System.Drawing.Size(129, 20)
        Me.polCT2UpperRequired.TabIndex = 77
        Me.polCT2UpperRequired.Text = "Upper case letter"
        Me.polCT2UpperRequired.UseVisualStyleBackColor = True
        '
        'polCT2LowerRequired
        '
        Me.polCT2LowerRequired.AutoSize = True
        Me.polCT2LowerRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT2LowerRequired.Location = New System.Drawing.Point(20, 503)
        Me.polCT2LowerRequired.Name = "polCT2LowerRequired"
        Me.polCT2LowerRequired.Size = New System.Drawing.Size(127, 20)
        Me.polCT2LowerRequired.TabIndex = 76
        Me.polCT2LowerRequired.Text = "Lower case letter"
        Me.polCT2LowerRequired.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(14, 474)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(325, 16)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Alternatively, specify the exact character sets required"
        '
        'polCT2CharacterSetsRequired
        '
        Me.polCT2CharacterSetsRequired.Location = New System.Drawing.Point(572, 442)
        Me.polCT2CharacterSetsRequired.Name = "polCT2CharacterSetsRequired"
        Me.polCT2CharacterSetsRequired.Size = New System.Drawing.Size(49, 20)
        Me.polCT2CharacterSetsRequired.TabIndex = 74
        '
        'polCT2
        '
        Me.polCT2.Location = New System.Drawing.Point(572, 415)
        Me.polCT2.Name = "polCT2"
        Me.polCT2.Size = New System.Drawing.Size(49, 20)
        Me.polCT2.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(14, 444)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(549, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Total number of character sets required (number, symbol, uppercase letter, lowerc" &
    "ase letter)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(14, 417)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(553, 16)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Apply the following requirements for passwords longer than the first threshold, b" &
    "ut shorter than"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(17, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 16)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Threshold level 2"
        '
        'polCT1SymbolOrNumberRequired
        '
        Me.polCT1SymbolOrNumberRequired.AutoSize = True
        Me.polCT1SymbolOrNumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT1SymbolOrNumberRequired.Location = New System.Drawing.Point(23, 342)
        Me.polCT1SymbolOrNumberRequired.Name = "polCT1SymbolOrNumberRequired"
        Me.polCT1SymbolOrNumberRequired.Size = New System.Drawing.Size(136, 20)
        Me.polCT1SymbolOrNumberRequired.TabIndex = 69
        Me.polCT1SymbolOrNumberRequired.Text = "Number or symbol"
        Me.polCT1SymbolOrNumberRequired.UseVisualStyleBackColor = True
        '
        'polCT1NumberRequired
        '
        Me.polCT1NumberRequired.AutoSize = True
        Me.polCT1NumberRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT1NumberRequired.Location = New System.Drawing.Point(23, 319)
        Me.polCT1NumberRequired.Name = "polCT1NumberRequired"
        Me.polCT1NumberRequired.Size = New System.Drawing.Size(74, 20)
        Me.polCT1NumberRequired.TabIndex = 68
        Me.polCT1NumberRequired.Text = "Number"
        Me.polCT1NumberRequired.UseVisualStyleBackColor = True
        '
        'polCT1SymbolRequired
        '
        Me.polCT1SymbolRequired.AutoSize = True
        Me.polCT1SymbolRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT1SymbolRequired.Location = New System.Drawing.Point(23, 296)
        Me.polCT1SymbolRequired.Name = "polCT1SymbolRequired"
        Me.polCT1SymbolRequired.Size = New System.Drawing.Size(72, 20)
        Me.polCT1SymbolRequired.TabIndex = 67
        Me.polCT1SymbolRequired.Text = "Symbol"
        Me.polCT1SymbolRequired.UseVisualStyleBackColor = True
        '
        'polCT1UpperRequired
        '
        Me.polCT1UpperRequired.AutoSize = True
        Me.polCT1UpperRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT1UpperRequired.Location = New System.Drawing.Point(23, 273)
        Me.polCT1UpperRequired.Name = "polCT1UpperRequired"
        Me.polCT1UpperRequired.Size = New System.Drawing.Size(129, 20)
        Me.polCT1UpperRequired.TabIndex = 66
        Me.polCT1UpperRequired.Text = "Upper case letter"
        Me.polCT1UpperRequired.UseVisualStyleBackColor = True
        '
        'polCT1LowerRequired
        '
        Me.polCT1LowerRequired.AutoSize = True
        Me.polCT1LowerRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polCT1LowerRequired.Location = New System.Drawing.Point(23, 250)
        Me.polCT1LowerRequired.Name = "polCT1LowerRequired"
        Me.polCT1LowerRequired.Size = New System.Drawing.Size(127, 20)
        Me.polCT1LowerRequired.TabIndex = 65
        Me.polCT1LowerRequired.Text = "Lower case letter"
        Me.polCT1LowerRequired.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(17, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Alternatively, specify the exact character sets required"
        '
        'polCT1CharacterSetsRequired
        '
        Me.polCT1CharacterSetsRequired.Location = New System.Drawing.Point(575, 189)
        Me.polCT1CharacterSetsRequired.Name = "polCT1CharacterSetsRequired"
        Me.polCT1CharacterSetsRequired.Size = New System.Drawing.Size(49, 20)
        Me.polCT1CharacterSetsRequired.TabIndex = 63
        '
        'polCT1
        '
        Me.polCT1.Location = New System.Drawing.Point(575, 162)
        Me.polCT1.Name = "polCT1"
        Me.polCT1.Size = New System.Drawing.Size(49, 20)
        Me.polCT1.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(17, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(549, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total number of character sets required (number, symbol, uppercase letter, lowerc" &
    "ase letter)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(17, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Apply the following requirements for passwords with a length less than"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(20, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Threshold level 1"
        '
        'btnLengthBased
        '
        Me.btnLengthBased.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnLengthBased.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLengthBased.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLengthBased.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLengthBased.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnLengthBased.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnLengthBased.Location = New System.Drawing.Point(0, 637)
        Me.btnLengthBased.Name = "btnLengthBased"
        Me.btnLengthBased.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnLengthBased.Size = New System.Drawing.Size(777, 35)
        Me.btnLengthBased.TabIndex = 11
        Me.btnLengthBased.Text = "Length Based Complexity"
        Me.btnLengthBased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLengthBased.UseVisualStyleBackColor = False
        '
        'pComplexityPoints
        '
        Me.pComplexityPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pComplexityPoints.Controls.Add(Me.lPoints)
        Me.pComplexityPoints.Controls.Add(Me.Label19)
        Me.pComplexityPoints.Controls.Add(Me.prgPWTest)
        Me.pComplexityPoints.Controls.Add(Me.Label9)
        Me.pComplexityPoints.Controls.Add(Me.txtPWTest)
        Me.pComplexityPoints.Controls.Add(Me.Label8)
        Me.pComplexityPoints.Controls.Add(Me.Label20)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsUseOfLower)
        Me.pComplexityPoints.Controls.Add(Me.Label36)
        Me.pComplexityPoints.Controls.Add(Me.Label35)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsRequired)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsEachChar)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsEachNumber)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsEachLower)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsEachUpper)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsEachSymbol)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsUseOfNumber)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsUseOfSymbol)
        Me.pComplexityPoints.Controls.Add(Me.polComplexityPointsUseOfUpper)
        Me.pComplexityPoints.Controls.Add(Me.Label3)
        Me.pComplexityPoints.Controls.Add(Me.Label1)
        Me.pComplexityPoints.Controls.Add(Me.Label27)
        Me.pComplexityPoints.Controls.Add(Me.Label31)
        Me.pComplexityPoints.Controls.Add(Me.Label32)
        Me.pComplexityPoints.Controls.Add(Me.Label33)
        Me.pComplexityPoints.Controls.Add(Me.Label34)
        Me.pComplexityPoints.Dock = System.Windows.Forms.DockStyle.Top
        Me.pComplexityPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.pComplexityPoints.Location = New System.Drawing.Point(0, 323)
        Me.pComplexityPoints.Name = "pComplexityPoints"
        Me.pComplexityPoints.Size = New System.Drawing.Size(777, 314)
        Me.pComplexityPoints.TabIndex = 6
        Me.pComplexityPoints.Visible = False
        '
        'lPoints
        '
        Me.lPoints.Location = New System.Drawing.Point(540, 121)
        Me.lPoints.Name = "lPoints"
        Me.lPoints.Size = New System.Drawing.Size(47, 16)
        Me.lPoints.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(493, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 16)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Points:"
        '
        'prgPWTest
        '
        Me.prgPWTest.Location = New System.Drawing.Point(489, 95)
        Me.prgPWTest.Name = "prgPWTest"
        Me.prgPWTest.Size = New System.Drawing.Size(270, 23)
        Me.prgPWTest.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(489, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 16)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Enter a password to test"
        '
        'txtPWTest
        '
        Me.txtPWTest.Location = New System.Drawing.Point(489, 66)
        Me.txtPWTest.Name = "txtPWTest"
        Me.txtPWTest.Size = New System.Drawing.Size(267, 22)
        Me.txtPWTest.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Real Time Test:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 271)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(294, 16)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Points for the use of at least one lower case letter"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'polComplexityPointsUseOfLower
        '
        Me.polComplexityPointsUseOfLower.Location = New System.Drawing.Point(418, 268)
        Me.polComplexityPointsUseOfLower.Name = "polComplexityPointsUseOfLower"
        Me.polComplexityPointsUseOfLower.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsUseOfLower.TabIndex = 61
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(23, 244)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(294, 16)
        Me.Label36.TabIndex = 60
        Me.Label36.Text = "Points for the use of at least one uppercase letter"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(23, 215)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(241, 16)
        Me.Label35.TabIndex = 59
        Me.Label35.Text = "Points for the use of at least one symbol"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'polComplexityPointsRequired
        '
        Me.polComplexityPointsRequired.Location = New System.Drawing.Point(418, 13)
        Me.polComplexityPointsRequired.Name = "polComplexityPointsRequired"
        Me.polComplexityPointsRequired.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsRequired.TabIndex = 58
        '
        'polComplexityPointsEachChar
        '
        Me.polComplexityPointsEachChar.Location = New System.Drawing.Point(418, 42)
        Me.polComplexityPointsEachChar.Name = "polComplexityPointsEachChar"
        Me.polComplexityPointsEachChar.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsEachChar.TabIndex = 45
        '
        'polComplexityPointsEachNumber
        '
        Me.polComplexityPointsEachNumber.Location = New System.Drawing.Point(418, 69)
        Me.polComplexityPointsEachNumber.Name = "polComplexityPointsEachNumber"
        Me.polComplexityPointsEachNumber.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsEachNumber.TabIndex = 51
        '
        'polComplexityPointsEachLower
        '
        Me.polComplexityPointsEachLower.Location = New System.Drawing.Point(418, 97)
        Me.polComplexityPointsEachLower.Name = "polComplexityPointsEachLower"
        Me.polComplexityPointsEachLower.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsEachLower.TabIndex = 57
        '
        'polComplexityPointsEachUpper
        '
        Me.polComplexityPointsEachUpper.Location = New System.Drawing.Point(418, 125)
        Me.polComplexityPointsEachUpper.Name = "polComplexityPointsEachUpper"
        Me.polComplexityPointsEachUpper.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsEachUpper.TabIndex = 53
        '
        'polComplexityPointsEachSymbol
        '
        Me.polComplexityPointsEachSymbol.Location = New System.Drawing.Point(418, 153)
        Me.polComplexityPointsEachSymbol.Name = "polComplexityPointsEachSymbol"
        Me.polComplexityPointsEachSymbol.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsEachSymbol.TabIndex = 54
        '
        'polComplexityPointsUseOfNumber
        '
        Me.polComplexityPointsUseOfNumber.Location = New System.Drawing.Point(418, 181)
        Me.polComplexityPointsUseOfNumber.Name = "polComplexityPointsUseOfNumber"
        Me.polComplexityPointsUseOfNumber.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsUseOfNumber.TabIndex = 56
        '
        'polComplexityPointsUseOfSymbol
        '
        Me.polComplexityPointsUseOfSymbol.Location = New System.Drawing.Point(418, 212)
        Me.polComplexityPointsUseOfSymbol.Name = "polComplexityPointsUseOfSymbol"
        Me.polComplexityPointsUseOfSymbol.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsUseOfSymbol.TabIndex = 52
        '
        'polComplexityPointsUseOfUpper
        '
        Me.polComplexityPointsUseOfUpper.Location = New System.Drawing.Point(418, 241)
        Me.polComplexityPointsUseOfUpper.Name = "polComplexityPointsUseOfUpper"
        Me.polComplexityPointsUseOfUpper.Size = New System.Drawing.Size(49, 22)
        Me.polComplexityPointsUseOfUpper.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Minimum number of points required for password to be approved"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Points for each character used"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(23, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(176, 16)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "Points for each number used"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(23, 100)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(228, 16)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Points for each lower case letter used"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(23, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(231, 16)
        Me.Label32.TabIndex = 48
        Me.Label32.Text = "Points for each upper case letter used"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(23, 156)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(175, 16)
        Me.Label33.TabIndex = 50
        Me.Label33.Text = "Points for each symbol used"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(23, 184)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(242, 16)
        Me.Label34.TabIndex = 49
        Me.Label34.Text = "Points for the use of at least one number"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPasswordPts
        '
        Me.btnPasswordPts.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnPasswordPts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPasswordPts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnPasswordPts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswordPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnPasswordPts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnPasswordPts.Location = New System.Drawing.Point(0, 288)
        Me.btnPasswordPts.Name = "btnPasswordPts"
        Me.btnPasswordPts.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnPasswordPts.Size = New System.Drawing.Size(777, 35)
        Me.btnPasswordPts.TabIndex = 5
        Me.btnPasswordPts.Text = "Password Complexity Points"
        Me.btnPasswordPts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasswordPts.UseVisualStyleBackColor = False
        '
        'pBasic
        '
        Me.pBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pBasic.Controls.Add(Me.cmbLists)
        Me.pBasic.Controls.Add(Me.bSetList)
        Me.pBasic.Controls.Add(Me.lblPassList)
        Me.pBasic.Controls.Add(Me.Label21)
        Me.pBasic.Controls.Add(Me.polMinPasswordLength)
        Me.pBasic.Controls.Add(Me.polMaxPasswordLength)
        Me.pBasic.Controls.Add(Me.Label30)
        Me.pBasic.Controls.Add(Me.Label28)
        Me.pBasic.Controls.Add(Me.Label26)
        Me.pBasic.Controls.Add(Me.Label25)
        Me.pBasic.Controls.Add(Me.Label23)
        Me.pBasic.Controls.Add(Me.polRejectNormalizedPasswordsinPasswordStoreSet)
        Me.pBasic.Controls.Add(Me.polRejectPasswordStoreSet)
        Me.pBasic.Controls.Add(Me.polRejectContainAccountNameSet)
        Me.pBasic.Controls.Add(Me.polRejectNormalizedPasswordsinWordListSet)
        Me.pBasic.Controls.Add(Me.polRejectNormalizedPasswordsinWordListChange)
        Me.pBasic.Controls.Add(Me.polRejectNormalizedPasswordsinPasswordStoreChange)
        Me.pBasic.Controls.Add(Me.polRejectPasswordStoreChange)
        Me.pBasic.Controls.Add(Me.polRejectContainAccountNameChange)
        Me.pBasic.Controls.Add(Me.Label29)
        Me.pBasic.Controls.Add(Me.Label22)
        Me.pBasic.Dock = System.Windows.Forms.DockStyle.Top
        Me.pBasic.Location = New System.Drawing.Point(0, 35)
        Me.pBasic.Name = "pBasic"
        Me.pBasic.Size = New System.Drawing.Size(777, 253)
        Me.pBasic.TabIndex = 8
        Me.pBasic.Visible = False
        '
        'cmbLists
        '
        Me.cmbLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbLists.FormattingEnabled = True
        Me.cmbLists.Location = New System.Drawing.Point(190, 213)
        Me.cmbLists.Name = "cmbLists"
        Me.cmbLists.Size = New System.Drawing.Size(462, 24)
        Me.cmbLists.TabIndex = 62
        '
        'bSetList
        '
        Me.bSetList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.bSetList.Location = New System.Drawing.Point(658, 214)
        Me.bSetList.Name = "bSetList"
        Me.bSetList.Size = New System.Drawing.Size(75, 23)
        Me.bSetList.TabIndex = 61
        Me.bSetList.Text = "Set List"
        Me.bSetList.UseVisualStyleBackColor = True
        '
        'lblPassList
        '
        Me.lblPassList.AutoSize = True
        Me.lblPassList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblPassList.Location = New System.Drawing.Point(37, 217)
        Me.lblPassList.Name = "lblPassList"
        Me.lblPassList.Size = New System.Drawing.Size(147, 16)
        Me.lblPassList.TabIndex = 60
        Me.lblPassList.Text = "Password List Location:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(40, 166)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(368, 16)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Reject normalized passwords found in the banned word store"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'polMinPasswordLength
        '
        Me.polMinPasswordLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polMinPasswordLength.Location = New System.Drawing.Point(352, 13)
        Me.polMinPasswordLength.Name = "polMinPasswordLength"
        Me.polMinPasswordLength.Size = New System.Drawing.Size(49, 22)
        Me.polMinPasswordLength.TabIndex = 54
        '
        'polMaxPasswordLength
        '
        Me.polMaxPasswordLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polMaxPasswordLength.Location = New System.Drawing.Point(352, 39)
        Me.polMaxPasswordLength.Name = "polMaxPasswordLength"
        Me.polMaxPasswordLength.Size = New System.Drawing.Size(49, 22)
        Me.polMaxPasswordLength.TabIndex = 45
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.Location = New System.Drawing.Point(40, 15)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(281, 16)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Minimum Password Length (set to 0 to disable)"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.Location = New System.Drawing.Point(40, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(285, 16)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Maximum Password Length (set to 0 to disable)"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(40, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(333, 16)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Reject Passwords that contain the user's account name"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(40, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(361, 16)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Reject passwords found in the comprimised password store"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(40, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(435, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Reject normalized passwords found in the compromised password store"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'polRejectNormalizedPasswordsinPasswordStoreSet
        '
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.Location = New System.Drawing.Point(538, 139)
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.Name = "polRejectNormalizedPasswordsinPasswordStoreSet"
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.Size = New System.Drawing.Size(52, 19)
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.TabIndex = 56
        Me.polRejectNormalizedPasswordsinPasswordStoreSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectPasswordStoreSet
        '
        Me.polRejectPasswordStoreSet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectPasswordStoreSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectPasswordStoreSet.Location = New System.Drawing.Point(538, 113)
        Me.polRejectPasswordStoreSet.Name = "polRejectPasswordStoreSet"
        Me.polRejectPasswordStoreSet.Size = New System.Drawing.Size(52, 19)
        Me.polRejectPasswordStoreSet.TabIndex = 58
        Me.polRejectPasswordStoreSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectContainAccountNameSet
        '
        Me.polRejectContainAccountNameSet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectContainAccountNameSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectContainAccountNameSet.Location = New System.Drawing.Point(538, 87)
        Me.polRejectContainAccountNameSet.Name = "polRejectContainAccountNameSet"
        Me.polRejectContainAccountNameSet.Size = New System.Drawing.Size(52, 19)
        Me.polRejectContainAccountNameSet.TabIndex = 59
        Me.polRejectContainAccountNameSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectNormalizedPasswordsinWordListSet
        '
        Me.polRejectNormalizedPasswordsinWordListSet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectNormalizedPasswordsinWordListSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectNormalizedPasswordsinWordListSet.Location = New System.Drawing.Point(538, 167)
        Me.polRejectNormalizedPasswordsinWordListSet.Name = "polRejectNormalizedPasswordsinWordListSet"
        Me.polRejectNormalizedPasswordsinWordListSet.Size = New System.Drawing.Size(52, 20)
        Me.polRejectNormalizedPasswordsinWordListSet.TabIndex = 55
        Me.polRejectNormalizedPasswordsinWordListSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectNormalizedPasswordsinWordListChange
        '
        Me.polRejectNormalizedPasswordsinWordListChange.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectNormalizedPasswordsinWordListChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectNormalizedPasswordsinWordListChange.Location = New System.Drawing.Point(483, 167)
        Me.polRejectNormalizedPasswordsinWordListChange.Name = "polRejectNormalizedPasswordsinWordListChange"
        Me.polRejectNormalizedPasswordsinWordListChange.Size = New System.Drawing.Size(49, 20)
        Me.polRejectNormalizedPasswordsinWordListChange.TabIndex = 52
        Me.polRejectNormalizedPasswordsinWordListChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectNormalizedPasswordsinPasswordStoreChange
        '
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.Location = New System.Drawing.Point(483, 139)
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.Name = "polRejectNormalizedPasswordsinPasswordStoreChange"
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.Size = New System.Drawing.Size(49, 19)
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.TabIndex = 51
        Me.polRejectNormalizedPasswordsinPasswordStoreChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectPasswordStoreChange
        '
        Me.polRejectPasswordStoreChange.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectPasswordStoreChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectPasswordStoreChange.Location = New System.Drawing.Point(483, 113)
        Me.polRejectPasswordStoreChange.Name = "polRejectPasswordStoreChange"
        Me.polRejectPasswordStoreChange.Size = New System.Drawing.Size(49, 19)
        Me.polRejectPasswordStoreChange.TabIndex = 53
        Me.polRejectPasswordStoreChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'polRejectContainAccountNameChange
        '
        Me.polRejectContainAccountNameChange.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.polRejectContainAccountNameChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.polRejectContainAccountNameChange.Location = New System.Drawing.Point(483, 87)
        Me.polRejectContainAccountNameChange.Name = "polRejectContainAccountNameChange"
        Me.polRejectContainAccountNameChange.Size = New System.Drawing.Size(49, 19)
        Me.polRejectContainAccountNameChange.TabIndex = 50
        Me.polRejectContainAccountNameChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label29.Location = New System.Drawing.Point(486, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(54, 16)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Change"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(551, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Set"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBasicSettings
        '
        Me.btnBasicSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnBasicSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBasicSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnBasicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBasicSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBasicSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnBasicSettings.Location = New System.Drawing.Point(0, 0)
        Me.btnBasicSettings.Name = "btnBasicSettings"
        Me.btnBasicSettings.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnBasicSettings.Size = New System.Drawing.Size(777, 35)
        Me.btnBasicSettings.TabIndex = 7
        Me.btnBasicSettings.Text = "Basic Password Settings"
        Me.btnBasicSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBasicSettings.UseVisualStyleBackColor = False
        '
        'bAddPolicy
        '
        Me.bAddPolicy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAddPolicy.FlatAppearance.BorderSize = 0
        Me.bAddPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddPolicy.Image = Global.Obelus.ActiveDirectory.PasswordProtection.PolicyManger.My.Resources.Resources.add
        Me.bAddPolicy.Location = New System.Drawing.Point(278, 19)
        Me.bAddPolicy.Name = "bAddPolicy"
        Me.bAddPolicy.Size = New System.Drawing.Size(24, 24)
        Me.bAddPolicy.TabIndex = 72
        Me.bAddPolicy.UseVisualStyleBackColor = True
        '
        'policy_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "policy_control"
        Me.Size = New System.Drawing.Size(794, 444)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pRegExp.ResumeLayout(False)
        Me.pRegExp.PerformLayout()
        Me.pLengthBased.ResumeLayout(False)
        Me.pLengthBased.PerformLayout()
        CType(Me.polCT3CharacterSetsRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polCT2CharacterSetsRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polCT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polCT1CharacterSetsRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polCT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pComplexityPoints.ResumeLayout(False)
        Me.pComplexityPoints.PerformLayout()
        CType(Me.polComplexityPointsUseOfLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsRequired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsEachChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsEachNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsEachLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsEachUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsEachSymbol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsUseOfNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsUseOfSymbol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polComplexityPointsUseOfUpper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBasic.ResumeLayout(False)
        Me.pBasic.PerformLayout()
        CType(Me.polMinPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.polMaxPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pRegExp As Panel
    Friend WithEvents btnRegExp As Button
    Friend WithEvents pLengthBased As Panel
    Friend WithEvents btnLengthBased As Button
    Friend WithEvents pComplexityPoints As Panel
    Friend WithEvents btnPasswordPts As Button
    Friend WithEvents pBasic As Panel
    Friend WithEvents btnBasicSettings As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents polMinPasswordLength As NumericUpDown
    Friend WithEvents polMaxPasswordLength As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents polRejectNormalizedPasswordsinPasswordStoreSet As CheckBox
    Friend WithEvents polRejectPasswordStoreSet As CheckBox
    Friend WithEvents polRejectContainAccountNameSet As CheckBox
    Friend WithEvents polRejectNormalizedPasswordsinWordListSet As CheckBox
    Friend WithEvents polRejectNormalizedPasswordsinWordListChange As CheckBox
    Friend WithEvents polRejectNormalizedPasswordsinPasswordStoreChange As CheckBox
    Friend WithEvents polRejectPasswordStoreChange As CheckBox
    Friend WithEvents polRejectContainAccountNameChange As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents chkEnable As CheckBox
    Friend WithEvents lblGroup As Label
    Friend WithEvents chkRegExpSettings As CheckBox
    Friend WithEvents chkLengthBasedComplexityRules As CheckBox
    Friend WithEvents chkComplexityPoints As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPolicy As ComboBox
    Friend WithEvents cmbLists As ComboBox
    Friend WithEvents bSetList As Button
    Friend WithEvents lblPassList As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents polComplexityPointsUseOfLower As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents polComplexityPointsRequired As NumericUpDown
    Friend WithEvents polComplexityPointsEachChar As NumericUpDown
    Friend WithEvents polComplexityPointsEachNumber As NumericUpDown
    Friend WithEvents polComplexityPointsEachLower As NumericUpDown
    Friend WithEvents polComplexityPointsEachUpper As NumericUpDown
    Friend WithEvents polComplexityPointsEachSymbol As NumericUpDown
    Friend WithEvents polComplexityPointsUseOfNumber As NumericUpDown
    Friend WithEvents polComplexityPointsUseOfSymbol As NumericUpDown
    Friend WithEvents polComplexityPointsUseOfUpper As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents polCT3CharacterSetsRequired As NumericUpDown
    Friend WithEvents polCT3SymbolOrNumberRequired As CheckBox
    Friend WithEvents polCT3NumberRequired As CheckBox
    Friend WithEvents polCT3SymbolRequired As CheckBox
    Friend WithEvents polCT3UpperRequired As CheckBox
    Friend WithEvents polCT3LowerRequired As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents polCT2SymbolOrNumberRequired As CheckBox
    Friend WithEvents polCT2NumberRequired As CheckBox
    Friend WithEvents polCT2SymbolRequired As CheckBox
    Friend WithEvents polCT2UpperRequired As CheckBox
    Friend WithEvents polCT2LowerRequired As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents polCT2CharacterSetsRequired As NumericUpDown
    Friend WithEvents polCT2 As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents polCT1SymbolOrNumberRequired As CheckBox
    Friend WithEvents polCT1NumberRequired As CheckBox
    Friend WithEvents polCT1SymbolRequired As CheckBox
    Friend WithEvents polCT1UpperRequired As CheckBox
    Friend WithEvents polCT1LowerRequired As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents polCT1CharacterSetsRequired As NumericUpDown
    Friend WithEvents polCT1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegexApprove As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bCloseForm As Button
    Friend WithEvents lGroupPolicyAssignment As Label
    Friend WithEvents txtRegexReject As TextBox
    Friend WithEvents chkEnableRegexApprove As CheckBox
    Friend WithEvents chkEnableRegexReject As CheckBox
    Friend WithEvents chkSimulate As CheckBox
    Friend WithEvents bSave As Button
    Friend WithEvents lPoints As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents prgPWTest As ProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPWTest As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblTLevel As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtThresholdPassword As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents bAddPolicy As Button
End Class
