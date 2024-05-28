Imports MySql.Data.MySqlClient

Public Class newschedtab
    Private totalDailyHours As Double = 0
    Private totalMonthlyHours As Double = 0
    Private shiftStartTime As DateTime
    Private shiftStarted As Boolean = False
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private userID As Integer
    Private DataTable1 As New DataTable()
    Private BindingSource1 As New BindingSource()

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
                    DataTable1.Clear()
                    adapter.Fill(DataTable1)

                    ' Clear any existing columns in the DataGridView
                    DataGridView1.Columns.Clear()

                    If DataTable1.Rows.Count > 0 Then
                        ' Set column headers and data properties
                        DataGridView1.Columns.Add("FirstNameColumn", "First Name")
                        DataGridView1.Columns("FirstNameColumn").DataPropertyName = "first_name"

                        DataGridView1.Columns.Add("MiddleNameColumn", "Middle Name")
                        DataGridView1.Columns("MiddleNameColumn").DataPropertyName = "middle_name"

                        DataGridView1.Columns.Add("LastNameColumn", "Last Name")
                        DataGridView1.Columns("LastNameColumn").DataPropertyName = "last_name"

                        DataGridView1.Columns.Add("IDColumn", "Instructor ID")
                        DataGridView1.Columns("IDColumn").DataPropertyName = "id"

                        DataGridView1.Columns.Add("DepartmentColumn", "Department")
                        DataGridView1.Columns("DepartmentColumn").DataPropertyName = "department"

                        DataGridView1.Columns.Add("ScheduleColumn", "Schedule")
                        DataGridView1.Columns("ScheduleColumn").DataPropertyName = "Schedule"



                        ' Auto-size columns
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        ' Bind the DataTable to the DataGridView
                        BindingSource1.DataSource = DataTable1
                        DataGridView1.DataSource = BindingSource1
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
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            RichTextBox1.Text = clickedCellValue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' edit 
        If DataGridView1.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
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
                            End If
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

                    ' Delete related rows from the salary_info table
                    Using deleteCmd As New MySqlCommand("DELETE FROM salary_info WHERE id = @id", conn)
                        deleteCmd.Parameters.AddWithValue("@id", userID)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    ' Delete the user
                    Using deleteCmd As New MySqlCommand("DELETE FROM users WHERE id = @id", conn)
                        deleteCmd.Parameters.AddWithValue("@id", userID)
                        deleteCmd.ExecuteNonQuery()
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


    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim searchTerm As String = searchTextBox.Text.Trim()

        If searchTerm.Length > 0 Then
            ' Build a filter expression for all searchable columns
            Dim filterExpression As String = String.Format("first_name LIKE '%{0}%' OR middle_name LIKE '%{0}%' OR last_name LIKE '%{0}%' OR " &
                                                           "CONVERT(id, 'System.String') LIKE '%{0}%' OR  CONVERT(Department, 'System.String') LIKE '%{0}%' OR  CONVERT(Schedule, 'System.String') LIKE '%{0}%'", searchTerm)

            ' Apply the filter to the BindingSource
            BindingSource1.Filter = filterExpression

            ' Check if any rows match the filter
            If BindingSource1.Count = 0 Then
                MessageBox.Show("No matching data found.")
            End If
        Else
            ' Clear the filter to show all data
            BindingSource1.RemoveFilter()
        End If
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        searchButton_Click(sender, e)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
