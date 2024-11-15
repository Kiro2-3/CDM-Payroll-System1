﻿Imports MySql.Data.MySqlClient

Public Class payrollsum
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private DataTable1 As New DataTable()
    Private BindingSource1 As New BindingSource()

    Private Sub payrollsum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT u.first_name, u.middle_name, u.last_name, u.id, s.salary_id, s.daily_salary, s.monthly_salary, s.salary_date " &
                              "FROM users u " &
                              "INNER JOIN salary_info s ON u.id = s.id"

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

                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "First Name", .DataPropertyName = "first_name"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Middle Name", .DataPropertyName = "middle_name"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Instructor ID", .DataPropertyName = "id"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Last Name", .DataPropertyName = "last_name"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Salary ID", .DataPropertyName = "salary_id"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Daily Salary", .DataPropertyName = "daily_salary"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Monthly Salary", .DataPropertyName = "monthly_salary"})
                        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Salary Date", .DataPropertyName = "salary_date"})

                        ' Bind the BindingSource to the DataGridView
                        DataGridView1.DataSource = BindingSource1

                        ' Auto-size columns
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        ' Update Label1 with the count of payroll records
                        Label1.Text = "There are currently " & DataTable1.Rows.Count.ToString() & " payroll records!"
                        Label2.Text = " Today is " & DateTime.Now.ToString("dddd, MMMM dd, yyyy")
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
                                                           "CONVERT(salary_id, 'System.String') LIKE '%{0}%' OR CONVERT(daily_salary, 'System.String') LIKE '%{0}%' OR " &
                                                           "CONVERT(monthly_salary, 'System.String') LIKE '%{0}%' OR CONVERT(salary_date, 'System.String') LIKE '%{0}%'", searchTerm)

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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' edit 
        If DataGridView1.SelectedRows.Count > 0 Then
            If RichTextBox1.Text.Trim() <> "" Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim selectedColumnIndex As Integer = DataGridView1.CurrentCell.ColumnIndex
                selectedRow.Cells(selectedColumnIndex).Value = RichTextBox1.Text.Trim()
                MessageBox.Show("Value updated successfully.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please enter a value in the RichTextBox.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No row selected.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' delete 
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            DataGridView1.Rows.Remove(selectedRow)
            MessageBox.Show("Row deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No row selected.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
