<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payrollsum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payrollsum))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        searchButton = New Button()
        searchTextBox = New TextBox()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        PictureBox13 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gold
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(RichTextBox1)
        Panel3.Controls.Add(searchButton)
        Panel3.Controls.Add(searchTextBox)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(PictureBox13)
        Panel3.Location = New Point(-149, -59)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1763, 891)
        Panel3.TabIndex = 4
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.Gold
        searchButton.FlatAppearance.BorderSize = 0
        searchButton.FlatStyle = FlatStyle.Flat
        searchButton.ForeColor = SystemColors.Window
        searchButton.Image = CType(resources.GetObject("searchButton.Image"), Image)
        searchButton.Location = New Point(373, 153)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(54, 47)
        searchButton.TabIndex = 32
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Font = New Font("Segoe UI", 22F)
        searchTextBox.Location = New Point(170, 153)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(197, 47)
        searchTextBox.TabIndex = 31
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(467, 57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(435, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
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
        DataGridView1.BackgroundColor = Color.Gold
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
        DataGridView1.Location = New Point(170, 206)
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
        DataGridView1.Size = New Size(946, 582)
        DataGridView1.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(454, 700)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 27
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Gold
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(1122, 206)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(432, 318)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 22
        PictureBox13.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(1122, 530)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(432, 258)
        RichTextBox1.TabIndex = 33
        RichTextBox1.Text = ""
        ' 
        ' payrollsum
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1438, 832)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "payrollsum"
        Text = "Maindashboard2"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
