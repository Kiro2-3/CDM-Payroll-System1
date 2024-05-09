<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        CloseButton = New Button()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        RememberCredentials = New CheckBox()
        PasswordField = New TextBox()
        UsernameField = New TextBox()
        Panel6 = New Panel()
        RegistrationButton = New Button()
        LoginButton = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(CloseButton)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 15, 0, 0)
        Panel1.Size = New Size(384, 124)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(100, 15)
        Panel4.Margin = New Padding(3, 40, 3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(184, 109)
        Panel4.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 31)
        Label1.Margin = New Padding(3, 10, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 45)
        Label1.TabIndex = 0
        Label1.Text = "CDMIPS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Transparent
        CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), Image)
        CloseButton.BackgroundImageLayout = ImageLayout.Zoom
        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.ForeColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        CloseButton.Location = New Point(355, 2)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(22, 19)
        CloseButton.TabIndex = 2
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(284, 15)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(2, 10, 0, 10)
        Panel3.Size = New Size(100, 109)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 10)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(98, 89)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 15)
        Panel2.Margin = New Padding(4, 3, 0, 3)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 8, 4, 8)
        Panel2.Size = New Size(100, 109)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 8)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(LinkLabel1)
        Panel5.Controls.Add(RememberCredentials)
        Panel5.Controls.Add(PasswordField)
        Panel5.Controls.Add(UsernameField)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 124)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(384, 202)
        Panel5.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(7, 76)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(84, 54)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(7, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(84, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Verdana", 9.0F)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(255), CByte(199), CByte(0))
        LinkLabel1.Location = New Point(224, 159)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(121, 14)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot password?"
        ' 
        ' RememberCredentials
        ' 
        RememberCredentials.AutoSize = True
        RememberCredentials.Font = New Font("Verdana", 9.0F)
        RememberCredentials.ForeColor = Color.FromArgb(CByte(255), CByte(199), CByte(0))
        RememberCredentials.Location = New Point(108, 158)
        RememberCredentials.Name = "RememberCredentials"
        RememberCredentials.Size = New Size(116, 18)
        RememberCredentials.TabIndex = 2
        RememberCredentials.Text = "Remember me"
        RememberCredentials.UseVisualStyleBackColor = True
        ' 
        ' PasswordField
        ' 
        PasswordField.BackColor = SystemColors.ControlLight
        PasswordField.Font = New Font("Verdana", 15.75F)
        PasswordField.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        PasswordField.Location = New Point(108, 85)
        PasswordField.Name = "PasswordField"
        PasswordField.PasswordChar = "*"c
        PasswordField.Size = New Size(237, 33)
        PasswordField.TabIndex = 1
        PasswordField.Text = "Password"
        ' 
        ' UsernameField
        ' 
        UsernameField.BackColor = SystemColors.ControlLight
        UsernameField.Font = New Font("Verdana", 15.75F)
        UsernameField.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        UsernameField.Location = New Point(108, 24)
        UsernameField.Name = "UsernameField"
        UsernameField.Size = New Size(237, 33)
        UsernameField.TabIndex = 0
        UsernameField.Text = "Username"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(RegistrationButton)
        Panel6.Controls.Add(LoginButton)
        Panel6.Location = New Point(7, 320)
        Panel6.Margin = New Padding(8, 3, 8, 3)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20, 0, 20, 0)
        Panel6.Size = New Size(360, 46)
        Panel6.TabIndex = 6
        ' 
        ' RegistrationButton
        ' 
        RegistrationButton.Dock = DockStyle.Right
        RegistrationButton.FlatStyle = FlatStyle.Flat
        RegistrationButton.Font = New Font("Verdana", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RegistrationButton.ForeColor = Color.FromArgb(CByte(255), CByte(199), CByte(0))
        RegistrationButton.Location = New Point(238, 0)
        RegistrationButton.Name = "RegistrationButton"
        RegistrationButton.Size = New Size(102, 46)
        RegistrationButton.TabIndex = 3
        RegistrationButton.Text = "Register"
        RegistrationButton.UseVisualStyleBackColor = True
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        LoginButton.Dock = DockStyle.Left
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Verdana", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = Color.White
        LoginButton.Location = New Point(20, 0)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(127, 46)
        LoginButton.TabIndex = 1
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(253), CByte(246))
        ClientSize = New Size(384, 378)
        ControlBox = False
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginPage"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LoginButton As Button
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents UsernameField As TextBox
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents RememberCredentials As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label

End Class
