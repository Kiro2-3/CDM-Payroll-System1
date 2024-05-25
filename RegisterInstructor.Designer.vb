<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterInstructor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterInstructor))
        LastNameTextbox = New TextBox()
        MiddleNameTextbox = New TextBox()
        FirstNameTextbox = New TextBox()
        TabPage2 = New TabPage()
        DepartmentDropdown = New ComboBox()
        AddressTextbox = New TextBox()
        ContactTextbox = New TextBox()
        EmailTextbox = New TextBox()
        FemaleRadioButton = New RadioButton()
        TabPage3 = New TabPage()
        CompleteRegistration = New Button()
        TinTextbox = New TextBox()
        BankDetailsTextbox = New TextBox()
        GovermentTextbox = New TextBox()
        MaleRadioButton = New RadioButton()
        RegistrationTab = New TabControl()
        TabPage1 = New TabPage()
        Label1 = New Label()
        PasswordTextbox = New TextBox()
        UsernameTextbox = New TextBox()
        Panel3 = New Panel()
        BirthdayPicker = New DateTimePicker()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        RegistrationTab.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LastNameTextbox
        ' 
        LastNameTextbox.BackColor = Color.Gold
        LastNameTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        LastNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        LastNameTextbox.Location = New Point(22, 146)
        LastNameTextbox.Name = "LastNameTextbox"
        LastNameTextbox.PlaceholderText = "LAST NAME"
        LastNameTextbox.Size = New Size(388, 40)
        LastNameTextbox.TabIndex = 2
        ' 
        ' MiddleNameTextbox
        ' 
        MiddleNameTextbox.BackColor = Color.Gold
        MiddleNameTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        MiddleNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        MiddleNameTextbox.Location = New Point(22, 91)
        MiddleNameTextbox.Name = "MiddleNameTextbox"
        MiddleNameTextbox.PlaceholderText = "MIDDLE NAME"
        MiddleNameTextbox.Size = New Size(388, 40)
        MiddleNameTextbox.TabIndex = 1
        ' 
        ' FirstNameTextbox
        ' 
        FirstNameTextbox.BackColor = Color.Gold
        FirstNameTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        FirstNameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        FirstNameTextbox.Location = New Point(23, 24)
        FirstNameTextbox.Name = "FirstNameTextbox"
        FirstNameTextbox.PlaceholderText = "FIRST NAME"
        FirstNameTextbox.Size = New Size(387, 40)
        FirstNameTextbox.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Gold
        TabPage2.Controls.Add(DepartmentDropdown)
        TabPage2.Controls.Add(AddressTextbox)
        TabPage2.Controls.Add(ContactTextbox)
        TabPage2.Controls.Add(EmailTextbox)
        TabPage2.ForeColor = SystemColors.ControlText
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(519, 710)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Institution"
        ' 
        ' DepartmentDropdown
        ' 
        DepartmentDropdown.BackColor = Color.Gold
        DepartmentDropdown.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        DepartmentDropdown.ForeColor = SystemColors.WindowFrame
        DepartmentDropdown.FormattingEnabled = True
        DepartmentDropdown.Location = New Point(24, 192)
        DepartmentDropdown.Name = "DepartmentDropdown"
        DepartmentDropdown.Size = New Size(364, 40)
        DepartmentDropdown.TabIndex = 27
        DepartmentDropdown.Text = "DEPARTMENT"
        ' 
        ' AddressTextbox
        ' 
        AddressTextbox.BackColor = Color.Gold
        AddressTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        AddressTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        AddressTextbox.Location = New Point(24, 133)
        AddressTextbox.Name = "AddressTextbox"
        AddressTextbox.PlaceholderText = "ADDRESS"
        AddressTextbox.Size = New Size(375, 40)
        AddressTextbox.TabIndex = 17
        ' 
        ' ContactTextbox
        ' 
        ContactTextbox.BackColor = Color.Gold
        ContactTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        ContactTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        ContactTextbox.Location = New Point(24, 78)
        ContactTextbox.Name = "ContactTextbox"
        ContactTextbox.PlaceholderText = "CONTACT NUMBER"
        ContactTextbox.Size = New Size(375, 40)
        ContactTextbox.TabIndex = 16
        ' 
        ' EmailTextbox
        ' 
        EmailTextbox.BackColor = Color.Gold
        EmailTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        EmailTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        EmailTextbox.Location = New Point(24, 27)
        EmailTextbox.Name = "EmailTextbox"
        EmailTextbox.PlaceholderText = "EMAIL"
        EmailTextbox.Size = New Size(375, 40)
        EmailTextbox.TabIndex = 15
        ' 
        ' FemaleRadioButton
        ' 
        FemaleRadioButton.AutoSize = True
        FemaleRadioButton.Location = New Point(175, 4)
        FemaleRadioButton.Name = "FemaleRadioButton"
        FemaleRadioButton.Size = New Size(142, 36)
        FemaleRadioButton.TabIndex = 1
        FemaleRadioButton.TabStop = True
        FemaleRadioButton.Text = "Female"
        FemaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Gold
        TabPage3.Controls.Add(CompleteRegistration)
        TabPage3.Controls.Add(TinTextbox)
        TabPage3.Controls.Add(BankDetailsTextbox)
        TabPage3.Controls.Add(GovermentTextbox)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(519, 710)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Identification"
        ' 
        ' CompleteRegistration
        ' 
        CompleteRegistration.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        CompleteRegistration.FlatStyle = FlatStyle.Flat
        CompleteRegistration.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CompleteRegistration.ForeColor = Color.White
        CompleteRegistration.Location = New Point(411, 650)
        CompleteRegistration.Name = "CompleteRegistration"
        CompleteRegistration.Size = New Size(76, 43)
        CompleteRegistration.TabIndex = 6
        CompleteRegistration.Text = "Register"
        CompleteRegistration.UseVisualStyleBackColor = False
        ' 
        ' TinTextbox
        ' 
        TinTextbox.BackColor = Color.Gold
        TinTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        TinTextbox.ForeColor = SystemColors.ControlDarkDark
        TinTextbox.Location = New Point(31, 141)
        TinTextbox.Name = "TinTextbox"
        TinTextbox.PlaceholderText = "TIN"
        TinTextbox.Size = New Size(281, 40)
        TinTextbox.TabIndex = 30
        ' 
        ' BankDetailsTextbox
        ' 
        BankDetailsTextbox.BackColor = Color.Gold
        BankDetailsTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        BankDetailsTextbox.ForeColor = SystemColors.ControlDarkDark
        BankDetailsTextbox.Location = New Point(31, 86)
        BankDetailsTextbox.Name = "BankDetailsTextbox"
        BankDetailsTextbox.PlaceholderText = "BANK ACC NO."
        BankDetailsTextbox.Size = New Size(281, 40)
        BankDetailsTextbox.TabIndex = 29
        ' 
        ' GovermentTextbox
        ' 
        GovermentTextbox.BackColor = Color.Gold
        GovermentTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        GovermentTextbox.ForeColor = SystemColors.ControlDarkDark
        GovermentTextbox.Location = New Point(31, 35)
        GovermentTextbox.Name = "GovermentTextbox"
        GovermentTextbox.PlaceholderText = "SSS"
        GovermentTextbox.Size = New Size(281, 40)
        GovermentTextbox.TabIndex = 28
        ' 
        ' MaleRadioButton
        ' 
        MaleRadioButton.AutoSize = True
        MaleRadioButton.Location = New Point(14, 3)
        MaleRadioButton.Name = "MaleRadioButton"
        MaleRadioButton.Size = New Size(103, 36)
        MaleRadioButton.TabIndex = 0
        MaleRadioButton.TabStop = True
        MaleRadioButton.Text = "Male"
        MaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RegistrationTab
        ' 
        RegistrationTab.Controls.Add(TabPage2)
        RegistrationTab.Controls.Add(TabPage1)
        RegistrationTab.Controls.Add(TabPage3)
        RegistrationTab.Location = New Point(12, 13)
        RegistrationTab.Name = "RegistrationTab"
        RegistrationTab.SelectedIndex = 0
        RegistrationTab.Size = New Size(527, 738)
        RegistrationTab.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gold
        TabPage1.Controls.Add(FirstNameTextbox)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(PasswordTextbox)
        TabPage1.Controls.Add(UsernameTextbox)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(BirthdayPicker)
        TabPage1.Controls.Add(LastNameTextbox)
        TabPage1.Controls.Add(MiddleNameTextbox)
        TabPage1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(519, 710)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Basic information"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label1.Image = My.Resources.Resources.Vanilla_1x_3_7s_104px_35px
        Label1.Location = New Point(197, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 8
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.BackColor = Color.Gold
        PasswordTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        PasswordTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        PasswordTextbox.Location = New Point(22, 373)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PlaceholderText = "PASSWORD"
        PasswordTextbox.Size = New Size(388, 40)
        PasswordTextbox.TabIndex = 7
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.BackColor = Color.Gold
        UsernameTextbox.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        UsernameTextbox.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        UsernameTextbox.Location = New Point(23, 317)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.PlaceholderText = "USERNAME"
        UsernameTextbox.Size = New Size(388, 40)
        UsernameTextbox.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(FemaleRadioButton)
        Panel3.Controls.Add(MaleRadioButton)
        Panel3.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Panel3.Location = New Point(22, 259)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 43)
        Panel3.TabIndex = 5
        ' 
        ' BirthdayPicker
        ' 
        BirthdayPicker.CalendarForeColor = Color.Gold
        BirthdayPicker.CalendarMonthBackground = Color.Gold
        BirthdayPicker.CalendarTitleBackColor = Color.Gold
        BirthdayPicker.CalendarTitleForeColor = Color.Gold
        BirthdayPicker.CalendarTrailingForeColor = Color.Gold
        BirthdayPicker.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        BirthdayPicker.Location = New Point(23, 207)
        BirthdayPicker.Name = "BirthdayPicker"
        BirthdayPicker.Size = New Size(388, 40)
        BirthdayPicker.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gold
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(RegistrationTab)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1340, 809)
        Panel1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Sitka Text", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(558, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(770, 142)
        Label2.TabIndex = 8
        Label2.Text = "Take note : " & vbCrLf & "Always double check the informations                                              " & vbCrLf & "inserted to avoid any discepancies regards" & vbCrLf & "with the account."
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(558, 173)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(641, 629)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' RegisterInstructor
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1296, 820)
        ControlBox = False
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterInstructor"
        Text = "RegisterInstructor"
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        RegistrationTab.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents MiddleNameTextbox As TextBox
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DepartmentDropdown As ComboBox
    Friend WithEvents AddressTextbox As TextBox
    Friend WithEvents ContactTextbox As TextBox
    Friend WithEvents EmailTextbox As TextBox
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CompleteRegistration As Button
    Friend WithEvents TinTextbox As TextBox
    Friend WithEvents BankDetailsTextbox As TextBox
    Friend WithEvents GovermentTextbox As TextBox
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents RegistrationTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BirthdayPicker As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
