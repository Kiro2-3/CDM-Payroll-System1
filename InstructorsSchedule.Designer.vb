<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorsSchedule
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
        Dim Button5 As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorsSchedule))
        Button3 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button6 = New Button()
        Panel17 = New Panel()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        ExitButton = New Button()
        NamePanel = New Panel()
        Label2 = New Label()
        ProfName = New Label()
        Button2 = New Button()
        Panel1 = New Panel()
        Button4 = New Button()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Button5 = New Button()
        Panel17.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        NamePanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Yellow
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(273, 611)
        Button5.Name = "Button5"
        Button5.Size = New Size(956, 48)
        Button5.TabIndex = 52
        Button5.Text = "Edit"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Verdana", 11.25F)
        Button3.Location = New Point(12, 466)
        Button3.Name = "Button3"
        Button3.Size = New Size(222, 65)
        Button3.TabIndex = 7
        Button3.Text = "Attendance Report"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = SystemColors.ActiveBorder
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Verdana", 11.25F)
        Button10.Location = New Point(12, 182)
        Button10.Name = "Button10"
        Button10.Size = New Size(222, 65)
        Button10.TabIndex = 6
        Button10.Text = "Register Instructor"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = SystemColors.ActiveBorder
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Verdana", 11.25F)
        Button9.Location = New Point(12, 395)
        Button9.Name = "Button9"
        Button9.Size = New Size(222, 65)
        Button9.TabIndex = 5
        Button9.Text = "Employment History"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.ActiveBorder
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Verdana", 11.25F)
        Button8.Location = New Point(12, 321)
        Button8.Name = "Button8"
        Button8.Size = New Size(222, 68)
        Button8.TabIndex = 4
        Button8.Text = "Summary Report"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ActiveBorder
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Verdana", 11.25F)
        Button6.Location = New Point(12, 253)
        Button6.Name = "Button6"
        Button6.Size = New Size(222, 62)
        Button6.TabIndex = 2
        Button6.Text = "Instructor Schedules"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel17.Controls.Add(Label1)
        Panel17.Controls.Add(PictureBox2)
        Panel17.Controls.Add(PictureBox1)
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(20, 10)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(214, 60)
        Panel17.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(56, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 3
        Label1.Text = "CDMIPS"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(161, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(904, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 40)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(ExitButton)
        Panel2.Controls.Add(NamePanel)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(254, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(30, 20, 0, 10)
        Panel2.Size = New Size(1014, 87)
        Panel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label4.Location = New Point(19, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkGreen
        Label3.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(19, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(429, 46)
        Label3.TabIndex = 51
        Label3.Text = "INSTRUCTORS SCHEDULE"
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.White
        ExitButton.FlatStyle = FlatStyle.Flat
        ExitButton.ForeColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        ExitButton.Location = New Point(982, 0)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(25, 23)
        ExitButton.TabIndex = 7
        ExitButton.Text = "X"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' NamePanel
        ' 
        NamePanel.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        NamePanel.Controls.Add(Label2)
        NamePanel.Controls.Add(ProfName)
        NamePanel.Location = New Point(466, 23)
        NamePanel.Name = "NamePanel"
        NamePanel.Size = New Size(352, 40)
        NamePanel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(65, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 23)
        Label2.TabIndex = 3
        Label2.Text = "Hello Administrator"
        ' 
        ' ProfName
        ' 
        ProfName.AutoSize = True
        ProfName.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        ProfName.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfName.ForeColor = Color.White
        ProfName.Location = New Point(63, 7)
        ProfName.Name = "ProfName"
        ProfName.Size = New Size(222, 23)
        ProfName.TabIndex = 2
        ProfName.Text = "Hello Administrator"
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.DarkGoldenrod
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(824, 24)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 40)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button10)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Panel17)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 10, 20, 0)
        Panel1.Size = New Size(254, 704)
        Panel1.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveBorder
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Verdana", 11.25F)
        Button4.Location = New Point(12, 111)
        Button4.Name = "Button4"
        Button4.Size = New Size(222, 65)
        Button4.TabIndex = 9
        Button4.Text = "Main Dashboard"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Department"
        Column3.MinimumWidth = 50
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Instructor Id"
        Column2.MinimumWidth = 50
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Surname"
        Column6.MinimumWidth = 50
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Middle Name"
        Column5.MinimumWidth = 50
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 200F
        Column1.HeaderText = "First Name"
        Column1.MinimumWidth = 50
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column5, Column6, Column2, Column3})
        DataGridView1.GridColor = SystemColors.InfoText
        DataGridView1.Location = New Point(273, 111)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 199
        DataGridView1.ScrollBars = ScrollBars.Horizontal
        DataGridView1.Size = New Size(956, 494)
        DataGridView1.TabIndex = 50
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(264, 99)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(977, 572)
        Panel3.TabIndex = 53
        ' 
        ' InstructorsSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1268, 704)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "InstructorsSchedule"
        Text = "InstructorsSchedule"
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        NamePanel.ResumeLayout(False)
        NamePanel.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents NamePanel As Panel
    Friend WithEvents ProfName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
End Class
