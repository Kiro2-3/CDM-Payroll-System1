Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class LoginPage
    Dim dbFunctions As New DatabaseFunctions()

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        PasswordField.UseSystemPasswordChar = False
        UsernameField.Font = New Font("Verdana", 16.0F, FontStyle.Regular)
        PasswordField.Font = New Font("Verdana", 16.0F, FontStyle.Regular)
    End Sub

    Private Sub LoginPage_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 25
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        Me.Region = New Region(gp)
    End Sub

    Private Sub UsernameField_Enter(sender As Object, e As EventArgs) Handles UsernameField.Enter
        If UsernameField.Text = "Username" Then
            UsernameField.Text = ""
            UsernameField.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UsernameField_Leave(sender As Object, e As EventArgs) Handles UsernameField.Leave
        If UsernameField.Text = "" Then
            UsernameField.Text = "Username"
            UsernameField.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub PasswordField_Enter(sender As Object, e As EventArgs) Handles PasswordField.Enter
        If PasswordField.Text = "Password" Then
            PasswordField.Text = "" ' showpassword
            PasswordField.UseSystemPasswordChar = True ' Hide characters with asterisks
            PasswordField.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PasswordField_Leave(sender As Object, e As EventArgs) Handles PasswordField.Leave
        If PasswordField.Text = "" Then
            PasswordField.Text = "Password"
            PasswordField.UseSystemPasswordChar = False ' Show placeholder text
            PasswordField.ForeColor = Color.Silver
        End If
    End Sub



    Private Sub ExitLogin(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameField.Text
        Dim password As String = PasswordField.Text

        ' Authenticate user and get user ID
        Dim userID As Integer = dbFunctions.AuthenticateAndGetUserID(username, password)

        If userID <> 0 Then
            ' Hide the login form
            Me.Hide()

            ' Retrieve the position of the logged-in user
            Dim userPosition As String = dbFunctions.GetUserPosition(userID)

            ' Display the position in a message box
            MessageBox.Show("Logged in as: " & userPosition)

            ' Check if the user is an admin
            If userPosition.ToLower() = "admin" Then
                ' Proceed with further actions (e.g., showing a landing page)
                Dim landingPage As New LandingPage(userID)
                landingPage.Show()
            ElseIf userPosition.ToLower() = "user" Then
                ' Open the desired executable file for users
                Process.Start("C:\Users\rocky\Documents\GitHub\UserSideWithCalculation\UserSideWithCalculation\bin\Debug\net8.0-windows\UserSideWithCalculation")
            Else
                MessageBox.Show("Invalid position!")
            End If
        Else
            MessageBox.Show("Invalid username or password!")
        End If
    End Sub



    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
