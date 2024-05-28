﻿Imports MySql.Data.MySqlClient

Public Class attendance

    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private DataTable1 As New DataTable()
    Private BindingSource1 As New BindingSource()

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT DISTINCT u.first_name, u.middle_name, u.last_name, u.id, s.salary_date " &
                              "FROM users u " &
                              "INNER JOIN salary_info s ON u.id = s.id " &
                              "ORDER BY u.id, s.salary_date"

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
                        ' Bind the DataTable to the BindingSource
                        BindingSource1.DataSource = DataTable1

                        ' Set column headers and data properties
                        DataGridView1.AutoGenerateColumns = False

                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "First Name", .DataPropertyName = "first_name", .Name = "FirstNameColumn"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Middle Name", .DataPropertyName = "middle_name", .Name = "MiddleNameColumn"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Last Name", .DataPropertyName = "last_name", .Name = "LastNameColumn"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Instructor ID", .DataPropertyName = "id", .Name = "IDColumn"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Attendance", .DataPropertyName = "salary_date", .Name = "SalaryDateColumn"})

                        ' Bind the BindingSource to the DataGridView
                        DataGridView1.DataSource = BindingSource1

                        ' Auto-size columns
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        ' Update Label1 with the count of payroll records
                        Label1.Text = "There are currently " & DataTable1.Rows.Count.ToString() & " Attendance records!"
                        Label2.Text = "Today is " & DateTime.Now.ToString("dddd, MMMM dd, yyyy")
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

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim searchTerm As String = searchTextBox.Text.Trim()

        If searchTerm.Length > 0 Then
            ' Build a filter expression for all searchable columns
            Dim filterExpression As String = String.Format("first_name LIKE '%{0}%' OR middle_name LIKE '%{0}%' OR last_name LIKE '%{0}%' OR " &
                                                           "CONVERT(id, 'System.String') LIKE '%{0}%' OR " &
                                                           "CONVERT(salary_date, 'System.String') LIKE '%{0}%'", searchTerm)

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' No action needed here
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        ' No action needed here
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Refresh the data and update the labels
        LoadDataIntoDataGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        For Each row As DataGridViewRow In DataGridView1.SelectedRows
                            If Not row.IsNewRow Then
                                Dim query As String = "UPDATE users SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name WHERE id = @id"
                                Using cmd As New MySqlCommand(query, conn)
                                    cmd.Parameters.AddWithValue("@first_name", row.Cells("FirstNameColumn").Value)
                                    cmd.Parameters.AddWithValue("@middle_name", row.Cells("MiddleNameColumn").Value)
                                    cmd.Parameters.AddWithValue("@last_name", row.Cells("LastNameColumn").Value)
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
            MessageBox.Show("No row selected to save.")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("No row selected.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRows As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
        Dim rowsAffected As Integer = 0

        If MessageBox.Show("Are you sure you want to delete the selected attendance records?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    For Each row As DataGridViewRow In selectedRows
                        Dim userID As Integer = row.Cells("IDColumn").Value
                        Dim salaryDate As String = row.Cells("SalaryDateColumn").Value.ToString()

                        Dim query As String = "DELETE FROM salary_info WHERE id = @id AND salary_date = @salary_date"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@id", userID)
                            cmd.Parameters.AddWithValue("@salary_date", salaryDate)
                            rowsAffected += cmd.ExecuteNonQuery()
                        End Using
                    Next

                    If rowsAffected > 0 Then
                        MessageBox.Show("Attendance records deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No matching records found to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
                LoadDataIntoDataGridView() ' Make sure this method is correctly refreshing the DataGridView
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error deleting attendance records: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
