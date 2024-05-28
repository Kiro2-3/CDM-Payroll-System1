<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newschedtab
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newschedtab))
        Panel4 = New Panel()
        RichTextBox1 = New RichTextBox()
        searchButton = New Button()
        searchTextBox = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column4 = New DataGridViewTextBoxColumn()
        PictureBox13 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Gold
        Panel4.BackgroundImageLayout = ImageLayout.Stretch
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(RichTextBox1)
        Panel4.Controls.Add(searchButton)
        Panel4.Controls.Add(searchTextBox)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Controls.Add(PictureBox13)
        Panel4.Controls.Add(PictureBox15)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1452, 893)
        Panel4.TabIndex = 4
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 15.0F)
        RichTextBox1.Location = New Point(1069, 444)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(278, 254)
        RichTextBox1.TabIndex = 34
        RichTextBox1.Text = ""
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.Gold
        searchButton.FlatAppearance.BorderSize = 0
        searchButton.FlatStyle = FlatStyle.Flat
        searchButton.ForeColor = SystemColors.Window
        searchButton.Image = CType(resources.GetObject("searchButton.Image"), Image)
        searchButton.Location = New Point(215, 391)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(50, 48)
        searchButton.TabIndex = 33
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Font = New Font("Segoe UI", 22.0F)
        searchTextBox.Location = New Point(12, 391)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(197, 47)
        searchTextBox.TabIndex = 32
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(356, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(374, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.BackgroundImage = My.Resources.Resources.Vanilla_1x_3_7s_108px_35px
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1069, 808)
        Button2.Name = "Button2"
        Button2.Size = New Size(278, 50)
        Button2.TabIndex = 25
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(38))
        Button1.BackgroundImage = My.Resources.Resources.Vanilla_1x_3_7s_108px_35px
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1069, 742)
        Button1.Name = "Button1"
        Button1.Size = New Size(278, 50)
        Button1.TabIndex = 24
        Button1.UseVisualStyleBackColor = False
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column4})
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
        DataGridView1.Location = New Point(12, 444)
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
        DataGridView1.Size = New Size(1031, 414)
        DataGridView1.TabIndex = 23
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Column1"
        Column4.Name = "Column4"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Gold
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(1089, 123)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(258, 236)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 22
        PictureBox13.TabStop = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = Color.Gold
        PictureBox15.Location = New Point(0, 0)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(1445, 893)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 0
        PictureBox15.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Gold
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(271, 391)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(12, 123)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1031, 262)
        PictureBox3.TabIndex = 36
        PictureBox3.TabStop = False
        ' 
        ' newschedtab
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1363, 893)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.None
        Name = "newschedtab"
        Text = "newsched"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
