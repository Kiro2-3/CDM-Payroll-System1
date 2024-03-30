Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class LandingPage
    Private totalDailyHours As Double = 0
    Private totalMonthlyHours As Double = 0
    Private shiftStartTime As DateTime
    Private shiftStarted As Boolean = False
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private userID As Integer

    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeRoundedControl(CDMPic, 25)
        MakeRoundedControl(TopPanel, 25)
        MakeRoundedControl(PanelA, 25)
        MakeRoundedControl(PanelB, 25)
        MakeRoundedControl(PanelC, 25)
        MakeRoundedControl(NamePanel, 10)
        MakeRoundedControl(StartPanel, 10)
        MakeRoundedControl(EndPanel, 10)
        MakeRoundedControl(Me, 25)

        InitializeComboBoxes()

        UpdateDateLabel()

        StartShiftButton.Enabled = False

        EndShiftButton.Enabled = False
    End Sub

    Private Sub InitializeComboBoxes()
        For i As Integer = 0 To 23
            OpeningHourTime.Items.Add(i.ToString("00"))
            EndingHourtime.Items.Add(i.ToString("00"))
        Next

        For i As Integer = 0 To 59
            OpeningMinutesTime.Items.Add(i.ToString("00"))
            EndingMinutesTime.Items.Add(i.ToString("00"))
        Next

        AddHandler OpeningHourTime.SelectedIndexChanged, AddressOf OpeningTimeComboBox_SelectedIndexChanged
        AddHandler OpeningMinutesTime.SelectedIndexChanged, AddressOf OpeningTimeComboBox_SelectedIndexChanged
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

    Private Sub UpdateDateLabel()
        Dim todayDate As String = Date.Today.ToString("dddd, MMMM dd, yyyy")
        DateLabel.Text = "Today is " & todayDate

        If Date.Today.Day = Date.DaysInMonth(Date.Today.Year, Date.Today.Month) Then
            ' Last day of the month
            UpdateTotalMonthlyHours()
        Else
            Label11.Text = "Still far from the end of the month."
        End If
    End Sub

    Private Sub UpdateTotalMonthlyHours()
        ' Calculate total monthly hours from the database
        totalMonthlyHours = GetTotalMonthlyHours(userID, Date.Today.Year, Date.Today.Month)

        ' Update UI label
        Label11.Text = "Total Monthly Hours: " & totalMonthlyHours.ToString("0.00")
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

    Private Sub OpeningTimeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        If OpeningHourTime.SelectedIndex <> -1 AndAlso OpeningMinutesTime.SelectedIndex <> -1 AndAlso
       EndingHourtime.SelectedIndex <> -1 AndAlso EndingMinutesTime.SelectedIndex <> -1 Then
            StartShiftButton.Enabled = True
        Else
            StartShiftButton.Enabled = False
        End If

        EndingHourtime.Enabled = OpeningHourTime.SelectedIndex <> -1 AndAlso OpeningMinutesTime.SelectedIndex <> -1
        EndingMinutesTime.Enabled = OpeningHourTime.SelectedIndex <> -1 AndAlso OpeningMinutesTime.SelectedIndex <> -1

        If Not shiftStarted Then
            StartShiftButton.Enabled = True
        End If
    End Sub

    Private Sub StartShiftButton_Click(sender As Object, e As EventArgs) Handles StartShiftButton.Click
        ' Event handler for starting a shift
        shiftStarted = True
        shiftStartTime = DateTime.Now
        StartShiftButton.Enabled = False
        EndShiftButton.Enabled = True
    End Sub

    Private Sub EndShiftButton_Click(sender As Object, e As EventArgs) Handles EndShiftButton.Click
        ' Event handler for ending a shift
        If shiftStarted Then
            Dim shiftDuration As TimeSpan = DateTime.Now - shiftStartTime
            Dim hoursWorked As Double = shiftDuration.TotalHours

            totalDailyHours += hoursWorked

            ' Update total daily hours in the database
            If userID <> 0 Then
                Dim currentDate As Date = Date.Today
                InsertTotalDailyHours(userID, currentDate, totalDailyHours)
            Else
                MessageBox.Show("Failed to retrieve user ID.")
            End If

            ' Update UI labels
            UpdateDailyHoursLabel()

            ' Reset shift status and enable Start Shift button
            shiftStarted = False
            StartShiftButton.Enabled = True
            EndShiftButton.Enabled = False
        End If
    End Sub

    Private Sub UpdateDailyHoursLabel()
        DailyHours.Text = "Daily Hours: " & totalDailyHours.ToString("0.00")
    End Sub

    Private Sub InsertTotalDailyHours(id As Integer, shiftDate As Date, totalDailyHours As Double)
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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
