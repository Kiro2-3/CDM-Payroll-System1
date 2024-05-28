Imports MySql.Data.MySqlClient

Public Class maindashboard1


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private totalDailyHours As Double = 0
    Private totalMonthlyHours As Double = 0
    Private shiftStartTime As DateTime
    Private shiftStarted As Boolean = False
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private userID As Integer




    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class