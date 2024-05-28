<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(attendance))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        searchTextBox = New TextBox()
        searchButton = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Button3 = New Button()
        Label2 = New Label()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        DataGridView1 = New DataGridView()
        PictureBox13 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(561, 700)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 27
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Font = New Font("Segoe UI", 22F)
        searchTextBox.Location = New Point(268, 477)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(197, 47)
        searchTextBox.TabIndex = 31
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.Gold
        searchButton.FlatAppearance.BorderSize = 0
        searchButton.FlatStyle = FlatStyle.Flat
        searchButton.ForeColor = Color.Transparent
        searchButton.Image = CType(resources.GetObject("searchButton.Image"), Image)
        searchButton.Location = New Point(471, 477)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(54, 47)
        searchButton.TabIndex = 32
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Gold
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(531, 477)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(282, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 45)
        Label1.TabIndex = 39
        Label1.Text = "Label1"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Yellow
        Button3.Location = New Point(1229, 773)
        Button3.Name = "Button3"
        Button3.Size = New Size(416, 100)
        Button3.TabIndex = 40
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(282, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 45)
        Label2.TabIndex = 41
        Label2.Text = "Label2"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gold
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(RichTextBox1)
        Panel3.Controls.Add(searchButton)
        Panel3.Controls.Add(searchTextBox)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(PictureBox13)
        Panel3.Location = New Point(-256, -72)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1763, 923)
        Panel3.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(913, 181)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(301, 290)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 38
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(268, 181)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(946, 290)
        PictureBox3.TabIndex = 35
        PictureBox3.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(1229, 530)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(416, 220)
        RichTextBox1.TabIndex = 33
        RichTextBox1.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = Color.PaleGoldenrod
        DataGridViewCellStyle1.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.SelectionBackColor = Color.SpringGreen
        DataGridViewCellStyle1.SelectionForeColor = Color.Red
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.SpringGreen
        DataGridViewCellStyle3.SelectionForeColor = Color.Red
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.GridColor = Color.Gold
        DataGridView1.Location = New Point(268, 530)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowHeadersWidth = 80
        DataGridView1.Size = New Size(946, 349)
        DataGridView1.TabIndex = 29
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Gold
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(1277, 171)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(299, 300)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 22
        PictureBox13.TabStop = False
        ' 
        ' attendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1251, 779)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "attendance"
        Text = "attendance"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox13 As PictureBox
End Class
