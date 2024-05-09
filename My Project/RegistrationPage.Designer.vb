<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationPage))
        Panel1 = New Panel()
        Panel2 = New Panel()
        HeaderTitle = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        RegistrationTab = New TabControl()
        TabPage1 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PasswordTextbox = New TextBox()
        UsernameTextbox = New TextBox()
        Panel3 = New Panel()
        NotToRadioButton = New RadioButton()
        FemaleRadioButton = New RadioButton()
        MaleRadioButton = New RadioButton()
        BirthdayPicker = New DateTimePicker()
        LastNameTextbox = New TextBox()
        MiddleNameTextbox = New TextBox()
        FirstNameTextbox = New TextBox()
        TabPage2 = New TabPage()
        DepartmentDropdown = New ComboBox()
        Label9 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        AddressTextbox = New TextBox()
        ContactTextbox = New TextBox()
        EmailTextbox = New TextBox()
        TabPage3 = New TabPage()
        CompleteRegistration = New Button()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TinTextbox = New TextBox()
        BankDetailsTextbox = New TextBox()
        GovermentTextbox = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RegistrationTab.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(300, 5, 300, 5)
        Panel1.Size = New Size(1264, 96)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(HeaderTitle)
        Panel2.Location = New Point(503, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 79)
        Panel2.TabIndex = 2
        ' 
        ' HeaderTitle
        ' 
        HeaderTitle.AutoSize = True
        HeaderTitle.Dock = DockStyle.Fill
        HeaderTitle.Font = New Font("Verdana", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderTitle.ForeColor = Color.Transparent
        HeaderTitle.Location = New Point(0, 0)
        HeaderTitle.Margin = New Padding(3, 10, 3, 0)
        HeaderTitle.Name = "HeaderTitle"
        HeaderTitle.Size = New Size(281, 67)
        HeaderTitle.TabIndex = 0
        HeaderTitle.Text = "CDMIPS"
        HeaderTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(783, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Padding = New Padding(0, 10, 0, 10)
        PictureBox2.Size = New Size(181, 86)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(300, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(147, 111)
        Label2.Margin = New Padding(10, 0, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(356, 59)
        Label2.TabIndex = 3
        Label2.Text = "Registration"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RegistrationTab
        ' 
        RegistrationTab.Controls.Add(TabPage1)
        RegistrationTab.Controls.Add(TabPage2)
        RegistrationTab.Controls.Add(TabPage3)
        RegistrationTab.Location = New Point(300, 173)
        RegistrationTab.Name = "RegistrationTab"
        RegistrationTab.SelectedIndex = 0
        RegistrationTab.Size = New Size(664, 454)
        RegistrationTab.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(PasswordTextbox)
        TabPage1.Controls.Add(UsernameTextbox)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(BirthdayPicker)
        TabPage1.Controls.Add(LastNameTextbox)
        TabPage1.Controls.Add(MiddleNameTextbox)
        TabPage1.Controls.Add(FirstNameTextbox)
        TabPage1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(656, 426)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Basic information"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(145, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 14
        Label8.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(141, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 23)
        Label7.TabIndex = 13
        Label7.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(166, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 23)
        Label6.TabIndex = 12
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(155, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 23)
        Label5.TabIndex = 11
        Label5.Text = "Birthday"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(137, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 23)
        Label4.TabIndex = 10
        Label4.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(113, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 23)
        Label3.TabIndex = 9
        Label3.Text = "Middle name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 8
        Label1.Text = "First name"
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.BackColor = SystemColors.ControlLight
        PasswordTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        PasswordTextbox.Location = New Point(251, 359)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PasswordChar = "*"c
        PasswordTextbox.Size = New Size(281, 31)
        PasswordTextbox.TabIndex = 7
        PasswordTextbox.Text = "********"
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.BackColor = SystemColors.ControlLight
        UsernameTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        UsernameTextbox.Location = New Point(252, 298)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.Size = New Size(281, 31)
        UsernameTextbox.TabIndex = 6
        UsernameTextbox.Text = ""
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(NotToRadioButton)
        Panel3.Controls.Add(FemaleRadioButton)
        Panel3.Controls.Add(MaleRadioButton)
        Panel3.Location = New Point(251, 249)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(281, 27)
        Panel3.TabIndex = 5
        ' 
        ' NotToRadioButton
        ' 
        NotToRadioButton.AutoSize = True
        NotToRadioButton.Dock = DockStyle.Right
        NotToRadioButton.Location = New Point(160, 0)
        NotToRadioButton.Name = "NotToRadioButton"
        NotToRadioButton.Size = New Size(121, 27)
        NotToRadioButton.TabIndex = 2
        NotToRadioButton.TabStop = True
        NotToRadioButton.Text = "Prefer not to"
        NotToRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FemaleRadioButton
        ' 
        FemaleRadioButton.AutoSize = True
        FemaleRadioButton.Dock = DockStyle.Fill
        FemaleRadioButton.Location = New Point(60, 0)
        FemaleRadioButton.Name = "FemaleRadioButton"
        FemaleRadioButton.Size = New Size(221, 27)
        FemaleRadioButton.TabIndex = 1
        FemaleRadioButton.TabStop = True
        FemaleRadioButton.Text = "Female"
        FemaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MaleRadioButton
        ' 
        MaleRadioButton.AutoSize = True
        MaleRadioButton.Dock = DockStyle.Left
        MaleRadioButton.Location = New Point(0, 0)
        MaleRadioButton.Name = "MaleRadioButton"
        MaleRadioButton.Size = New Size(60, 27)
        MaleRadioButton.TabIndex = 0
        MaleRadioButton.TabStop = True
        MaleRadioButton.Text = "Male"
        MaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BirthdayPicker
        ' 
        BirthdayPicker.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BirthdayPicker.Location = New Point(252, 197)
        BirthdayPicker.Name = "BirthdayPicker"
        BirthdayPicker.Size = New Size(281, 27)
        BirthdayPicker.TabIndex = 4
        ' 
        ' LastNameTextbox
        ' 
        LastNameTextbox.BackColor = SystemColors.ControlLight
        LastNameTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LastNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        LastNameTextbox.Location = New Point(251, 136)
        LastNameTextbox.Name = "LastNameTextbox"
        LastNameTextbox.Size = New Size(281, 31)
        LastNameTextbox.TabIndex = 2
        LastNameTextbox.Text = ""
        ' 
        ' MiddleNameTextbox
        ' 
        MiddleNameTextbox.BackColor = SystemColors.ControlLight
        MiddleNameTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MiddleNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        MiddleNameTextbox.Location = New Point(251, 81)
        MiddleNameTextbox.Name = "MiddleNameTextbox"
        MiddleNameTextbox.Size = New Size(281, 31)
        MiddleNameTextbox.TabIndex = 1
        MiddleNameTextbox.Text = ""
        ' 
        ' FirstNameTextbox
        ' 
        FirstNameTextbox.BackColor = SystemColors.ControlLight
        FirstNameTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        FirstNameTextbox.Location = New Point(251, 30)
        FirstNameTextbox.Name = "FirstNameTextbox"
        FirstNameTextbox.Size = New Size(281, 31)
        FirstNameTextbox.TabIndex = 0
        FirstNameTextbox.Text = ""
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(DepartmentDropdown)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(AddressTextbox)
        TabPage2.Controls.Add(ContactTextbox)
        TabPage2.Controls.Add(EmailTextbox)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(656, 426)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Institution"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' DepartmentDropdown
        ' 
        DepartmentDropdown.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DepartmentDropdown.FormattingEnabled = True
        DepartmentDropdown.Location = New Point(251, 195)
        DepartmentDropdown.Name = "DepartmentDropdown"
        DepartmentDropdown.Size = New Size(270, 31)
        DepartmentDropdown.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(128, 198)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 23)
        Label9.TabIndex = 26
        Label9.Text = "Department"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(164, 139)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 23)
        Label13.TabIndex = 24
        Label13.Text = "Address"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(88, 84)
        Label14.Name = "Label14"
        Label14.Size = New Size(162, 23)
        Label14.TabIndex = 23
        Label14.Text = "Contact number"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(182, 33)
        Label15.Name = "Label15"
        Label15.Size = New Size(63, 23)
        Label15.TabIndex = 22
        Label15.Text = "Email"
        ' 
        ' AddressTextbox
        ' 
        AddressTextbox.BackColor = SystemColors.ControlLight
        AddressTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddressTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        AddressTextbox.Location = New Point(251, 136)
        AddressTextbox.Name = "AddressTextbox"
        AddressTextbox.Size = New Size(281, 31)
        AddressTextbox.TabIndex = 17
        AddressTextbox.Text = "Montalban, Rizal"
        ' 
        ' ContactTextbox
        ' 
        ContactTextbox.BackColor = SystemColors.ControlLight
        ContactTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ContactTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        ContactTextbox.Location = New Point(251, 81)
        ContactTextbox.Name = "ContactTextbox"
        ContactTextbox.Size = New Size(281, 31)
        ContactTextbox.TabIndex = 16
        ContactTextbox.Text = "09774669886"
        ' 
        ' EmailTextbox
        ' 
        EmailTextbox.BackColor = SystemColors.ControlLight
        EmailTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        EmailTextbox.Location = New Point(251, 30)
        EmailTextbox.Name = "EmailTextbox"
        EmailTextbox.Size = New Size(281, 31)
        EmailTextbox.TabIndex = 15
        EmailTextbox.Text = ""
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(CompleteRegistration)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(TinTextbox)
        TabPage3.Controls.Add(BankDetailsTextbox)
        TabPage3.Controls.Add(GovermentTextbox)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(656, 426)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Identification"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' CompleteRegistration
        ' 
        CompleteRegistration.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        CompleteRegistration.FlatStyle = FlatStyle.Flat
        CompleteRegistration.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CompleteRegistration.ForeColor = Color.White
        CompleteRegistration.Location = New Point(456, 351)
        CompleteRegistration.Name = "CompleteRegistration"
        CompleteRegistration.Size = New Size(76, 43)
        CompleteRegistration.TabIndex = 6
        CompleteRegistration.Text = "Register"
        CompleteRegistration.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(120, 139)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 23)
        Label10.TabIndex = 33
        Label10.Text = "Tax | Tin ID"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(115, 89)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 23)
        Label11.TabIndex = 32
        Label11.Text = "Bank Details"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(88, 33)
        Label12.Name = "Label12"
        Label12.Size = New Size(157, 23)
        Label12.TabIndex = 31
        Label12.Text = "Government ID"
        ' 
        ' TinTextbox
        ' 
        TinTextbox.BackColor = SystemColors.ControlLight
        TinTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TinTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TinTextbox.Location = New Point(251, 136)
        TinTextbox.Name = "TinTextbox"
        TinTextbox.Size = New Size(281, 31)
        TinTextbox.TabIndex = 30
        TinTextbox.Text = "123-456-789-000"
        ' 
        ' BankDetailsTextbox
        ' 
        BankDetailsTextbox.BackColor = SystemColors.ControlLight
        BankDetailsTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BankDetailsTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        BankDetailsTextbox.Location = New Point(251, 81)
        BankDetailsTextbox.Name = "BankDetailsTextbox"
        BankDetailsTextbox.Size = New Size(281, 31)
        BankDetailsTextbox.TabIndex = 29
        BankDetailsTextbox.Text = "33-7913734-2"
        ' 
        ' GovermentTextbox
        ' 
        GovermentTextbox.BackColor = SystemColors.ControlLight
        GovermentTextbox.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GovermentTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        GovermentTextbox.Location = New Point(251, 30)
        GovermentTextbox.Name = "GovermentTextbox"
        GovermentTextbox.Size = New Size(281, 31)
        GovermentTextbox.TabIndex = 28
        GovermentTextbox.Text = "Social Security"
        ' 
        ' RegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(RegistrationTab)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationPage"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RegistrationTab.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HeaderTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegistrationTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents BirthdayPicker As DateTimePicker
    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents MiddleNameTextbox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents NotToRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents AddressTextbox As TextBox
    Friend WithEvents ContactTextbox As TextBox
    Friend WithEvents EmailTextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DepartmentDropdown As ComboBox
    Friend WithEvents CompleteRegistration As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TinTextbox As TextBox
    Friend WithEvents BankDetailsTextbox As TextBox
    Friend WithEvents GovermentTextbox As TextBox
End Class
