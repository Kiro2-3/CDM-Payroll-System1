<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maindashboard1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maindashboard1))
        Panel3 = New Panel()
        PictureBox14 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel3.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(PictureBox14)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(-131, -30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1570, 920)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.Gold
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(491, 24)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(616, 131)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 23
        PictureBox14.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Gold
        PictureBox3.Location = New Point(-133, 24)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1683, 131)
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Gold
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(123, 135)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(1614, 913)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 27
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 104)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Screenshot_2024_05_28_104806
        PictureBox2.Location = New Point(137, 161)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(627, 398)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' maindashboard1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1411, 880)
        Controls.Add(Panel3)
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Name = "maindashboard1"
        Text = "maindashboard1"
        Panel3.ResumeLayout(False)
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
