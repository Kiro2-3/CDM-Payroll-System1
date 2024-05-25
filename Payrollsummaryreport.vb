Imports MySql.Data.MySqlClient
' netstat -ano | findstr :<port_number>
'taskkill / F / PID < PID >
'netstat - ano | findstr :3306
'taskkill / F / PID 5608 <- the port you want to kill
Public Class Payrollsummaryreport
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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()

    End Sub


    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT u.first_name, u.middle_name, u.last_name, u.id, ut.Salary " &
                              "FROM users u " &
                              "INNER JOIN usertime ut ON u.id = ut.user_id"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Clear any existing columns in the DataGridView
                    DataGridView1.Columns.Clear()

                    If dataTable.Rows.Count > 0 Then
                        ' Set column headers and data properties
                        DataGridView1.Columns.Add("FirstNameColumn", "First Name")
                        DataGridView1.Columns("FirstNameColumn").DataPropertyName = "first_name"

                        DataGridView1.Columns.Add("MiddleNameColumn", "Middle Name")
                        DataGridView1.Columns("MiddleNameColumn").DataPropertyName = "middle_name"

                        DataGridView1.Columns.Add("LastNameColumn", "Last Name")
                        DataGridView1.Columns("LastNameColumn").DataPropertyName = "last_name"

                        DataGridView1.Columns.Add("IDColumn", "Instructors Id")
                        DataGridView1.Columns("IDColumn").DataPropertyName = "id"

                        DataGridView1.Columns.Add("SalaryColumn", "Salary")
                        DataGridView1.Columns("SalaryColumn").DataPropertyName = "Salary"

                        ' Auto-size columns
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        ' Bind the DataTable to the DataGridView
                        DataGridView1.DataSource = dataTable
                    Else
                        MessageBox.Show("No data found.")
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Event handler for CellContentClick event of DataGridView
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Add your code here to handle cell click events if needed
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim LandingPage As New LandingPage(userID)
        LandingPage.ShowDialog()
        Me.Close()
    End Sub
    Public Function CalculateSalaryWithDeductions(ByVal totalHours As Decimal) As Decimal
        Const regularHourlyRate As Decimal = 108.33
        Const overtimeHourlyRate As Decimal = regularHourlyRate * 1.5
        Const regularHoursPerWeek As Decimal = 40

        Dim regularPay As Decimal = 0
        Dim overtimePay As Decimal = 0
        Dim grossPay As Decimal = 0
        Dim socialSecurityDeduction As Decimal = 0
        Dim philHealthDeduction As Decimal = 0
        Dim pagIbigDeduction As Decimal = 0
        Dim netPay As Decimal = 0

        Try
            regularPay = totalHours * regularHourlyRate

            If totalHours > regularHoursPerWeek Then
                Dim overtimeHours As Decimal = totalHours - regularHoursPerWeek

                overtimePay = overtimeHours * overtimeHourlyRate

                grossPay = regularPay + overtimePay
            Else
                grossPay = regularPay
            End If

            socialSecurityDeduction = grossPay * 0.0572
            philHealthDeduction = grossPay * 0.082
            pagIbigDeduction = grossPay * 0.055

            netPay = grossPay - (socialSecurityDeduction + philHealthDeduction + pagIbigDeduction)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return netPay
    End Function

End Class
