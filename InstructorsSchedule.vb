Imports MySql.Data.MySqlClient

Public Class InstructorsSchedule
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
        Dim query As String = "SELECT first_name, middle_name, last_name, id, department, Schedule FROM users"

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

                        DataGridView1.Columns.Add("DepartmentColumn", "Department")
                        DataGridView1.Columns("DepartmentColumn").DataPropertyName = "department"

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
End Class
