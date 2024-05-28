Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class LandingPage
    Private totalDailyHours As Double = 0
    Private totalMonthlyHours As Double = 0
    Private shiftStartTime As DateTime
    Private shiftStarted As Boolean = False
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private originalBackColor As Color
    Private originalForeColor As Color
    Private originalFont As Font
    Private originalText As String
    Private userID As Integer

    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakeRoundedControl(Me, 25)


    End Sub


    Private Sub MakeRoundedControl(control As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, control.Width, control.Height)
        Dim radius As Integer = cornerRadius

        path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90)
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        control.Region = New Region(path)
    End Sub




    Private Function GetTotalMonthlyHours(userID As Integer, year As Integer, month As Integer) As Double
        Dim totalHours As Double = 0

        Dim query As String = "SELECT SUM(DailyHours) FROM userTime WHERE ID = @userID AND YEAR(ShiftDate) = @year AND MONTH(ShiftDate) = @month"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", userID)
                    cmd.Parameters.AddWithValue("@year", year)
                    cmd.Parameters.AddWithValue("@month", month)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        totalHours = Convert.ToDouble(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return totalHours
    End Function





    Public Sub InsertTotalDailyHours(id As Integer, shiftDate As Date, totalDailyHours As Double)
        Dim query As String = "INSERT INTO userTime (ID, ShiftDate, DailyHours) VALUES (@id, @shiftDate, @totalDailyHours)"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@shiftDate", shiftDate)
                    cmd.Parameters.AddWithValue("@totalDailyHours", totalDailyHours)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Total daily hours inserted into database successfully!")
                    Else
                        MessageBox.Show("Failed to insert total daily hours into database.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub







    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub









    Private Sub MakeButtonRound(button As Button)
        Dim diameter As Integer = Math.Min(button.Width, button.Height)
        Dim path As New GraphicsPath()
        path.AddEllipse(New Rectangle(0, 0, diameter, diameter))
        button.Region = New Region(path)
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Application.Exit()
    End Sub
    Private Sub ShowFormInPanel(formToShow As Form)
        ' Clear previous controls
        Panel3.Controls.Clear()
        ' Set the form's TopLevel property to false
        formToShow.TopLevel = False
        ' Add the form to the panel
        Panel3.Controls.Add(formToShow)
        ' Set the form's Dock property to Fill to fill the panel
        formToShow.Dock = DockStyle.Fill
        ' Show the form
        formToShow.Show()
    End Sub
    Private Sub ShowFormInPanel1(formToShow As Form)
        ' Clear previous controls
        Panel3.Controls.Clear()
        ' Set the form's TopLevel property to false
        formToShow.TopLevel = False
        ' Add the form to the panel
        Panel4.Controls.Add(formToShow)
        ' Set the form's Dock property to Fill to fill the panel
        formToShow.Dock = DockStyle.Fill
        ' Show the form
        formToShow.Show()
    End Sub

    Private Sub ShowFormInPanel2(formToShow As Form)
        ' Clear previous controls
        Panel3.Controls.Clear()
        ' Set the form's TopLevel property to false
        formToShow.TopLevel = False
        ' Add the form to the panel
        Panel3.Controls.Add(formToShow)
        ' Set the form's Dock property to Fill to fill the panel
        formToShow.Dock = DockStyle.Fill
        ' Show the form
        formToShow.Show()
    End Sub
    Private Sub ShowFormInPanel4(formToShow As Form)
        ' Clear previous controls
        Panel3.Controls.Clear()
        ' Set the form's TopLevel property to false
        formToShow.TopLevel = False
        ' Add the form to the panel
        Panel4.Controls.Add(formToShow)
        ' Set the form's Dock property to Fill to fill the panel
        formToShow.Dock = DockStyle.Fill
        ' Show the form
        formToShow.Show()
    End Sub
    Private Sub ShowFormInPanel8(formToShow As Form)
        ' Clear previous controls
        Panel3.Controls.Clear()
        ' Set the form's TopLevel property to false
        formToShow.TopLevel = False
        ' Add the form to the panel
        Panel3.Controls.Add(formToShow)
        ' Set the form's Dock property to Fill to fill the panel
        formToShow.Dock = DockStyle.Fill
        ' Show the form
        formToShow.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowFormInPanel(newschedtab)
    End Sub
    Private Sub ClearPanel(panel As Panel)
        ' Clear all controls from the panel
        panel.Controls.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowFormInPanel(RegisterInstructor)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowFormInPanel2(maindashboard1)
        Dim Button1 As Button = CType(sender, Button)

        ' Change the properties of the button to alter its design
        Button1.BackColor = Color.Gold
        Button1.ForeColor = Color.Gold
        Button1.Font = New Font("Arial", 14, FontStyle.Bold)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ShowFormInPanel8(payrollsum)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub RevertButton_Click(sender As Object, e As EventArgs)
        ' Find the main button by its name
        Dim myButton As Button = CType(Me.Controls("MyButton"), Button)

        ' Revert the properties of the main button to the original design
        myButton.BackColor = originalBackColor
        myButton.ForeColor = originalForeColor
        myButton.Font = originalFont
        myButton.Text = originalText
    End Sub
End Class
