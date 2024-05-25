Imports MySql.Data.MySqlClient

Public Class payroll

    Private totalDailyHours As Double = 0
    Private totalMonthlyHours As Double = 0
    Private shiftStartTime As DateTime
    Private shiftStarted As Boolean = False
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private userID As Integer


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

                        DataGridView1.Columns.Add("ScheduleColumn", "Schedule")
                        DataGridView1.Columns("ScheduleColumn").DataPropertyName = "Schedule"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            Dim query As String = "UPDATE users SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name, department = @department, Schedule = @Schedule WHERE id = @id"
                            Using cmd As New MySqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@first_name", row.Cells("FirstNameColumn").Value)
                                cmd.Parameters.AddWithValue("@middle_name", row.Cells("MiddleNameColumn").Value)
                                cmd.Parameters.AddWithValue("@last_name", row.Cells("LastNameColumn").Value)
                                cmd.Parameters.AddWithValue("@department", row.Cells("DepartmentColumn").Value)
                                cmd.Parameters.AddWithValue("@Schedule", row.Cells("ScheduleColumn").Value)
                                cmd.Parameters.AddWithValue("@id", row.Cells("IDColumn").Value)
                                cmd.ExecuteNonQuery()
                            End Using
                        Next
                    End Using
                    MessageBox.Show("Changes saved successfully.")
                Catch ex As MySqlException
                    MessageBox.Show("MySQL Error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error saving changes: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("No data to save.")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("No row selected.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userID As Integer = DataGridView1.SelectedRows(0).Cells("IDColumn").Value

        If MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Using cmd As New MySqlCommand("DELETE FROM users WHERE id = @id", conn)
                        cmd.Parameters.AddWithValue("@id", userID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                LoadDataIntoDataGridView()
                MessageBox.Show("User deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub
End Class