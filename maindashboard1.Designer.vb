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
        PictureBox1 = New PictureBox()
        PictureBox13 = New PictureBox()
        Panel3.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gold
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(PictureBox14)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(-131, -30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1387, 815)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(471, 343)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(737, 161)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 23
        PictureBox14.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(125, 428)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(432, 384)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Gold
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(1022, -8)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(372, 330)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 22
        PictureBox13.TabStop = False
        ' 
        ' maindashboard1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1386, 781)
        Controls.Add(PictureBox13)
        Controls.Add(Panel3)
        ForeColor = Color.Gold
        FormBorderStyle = FormBorderStyle.None
        Name = "maindashboard1"
        Text = "maindashboard1"
        Panel3.ResumeLayout(False)
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
