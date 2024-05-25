<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payroll))
        Panel7 = New Panel()
        PictureBox13 = New PictureBox()
        Panel3 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        PictureBox14 = New PictureBox()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(126, 101)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(667, 590)
        Panel7.TabIndex = 0
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Gold
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(918, 132)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(432, 384)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 22
        PictureBox13.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gold
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(PictureBox14)
        Panel3.Controls.Add(PictureBox13)
        Panel3.Location = New Point(-79, -11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1387, 815)
        Panel3.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(994, 702)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 27
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(876, 715)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 26
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(103, 370)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(731, 384)
        DataGridView1.TabIndex = 25
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(103, 232)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(731, 123)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 23
        PictureBox14.TabStop = False
        ' 
        ' payroll
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1229, 793)
        Controls.Add(Panel3)
        Controls.Add(Panel7)
        FormBorderStyle = FormBorderStyle.None
        Name = "payroll"
        Text = "payroll"
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
