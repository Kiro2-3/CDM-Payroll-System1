Imports MySql.Data.MySqlClient

Public Class message
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Private DataTable1 As New DataTable()
    Private BindingSource1 As New BindingSource()

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT id, name, email, number, message FROM exception"

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
                        DataGridView1.Columns.Add("IdColumn", "ID")
                        DataGridView1.Columns("IdColumn").DataPropertyName = "id"
                        DataGridView1.Columns("IdColumn").Visible = False ' Hide the ID column

                        DataGridView1.Columns.Add("NameColumn", "Name")
                        DataGridView1.Columns("NameColumn").DataPropertyName = "name"

                        DataGridView1.Columns.Add("EmailColumn", "Email")
                        DataGridView1.Columns("EmailColumn").DataPropertyName = "email"

                        DataGridView1.Columns.Add("NumberColumn", "Number")
                        DataGridView1.Columns("NumberColumn").DataPropertyName = "number"

                        DataGridView1.Columns.Add("MessageColumn", "Message")
                        DataGridView1.Columns("MessageColumn").DataPropertyName = "message"

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' edit
        If DataGridView1.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
                                Dim query As String = "UPDATE exception SET name = @name, email = @email, number = @number, message = @message WHERE id = @id"
                                Using cmd As New MySqlCommand(query, conn)
                                    cmd.Parameters.AddWithValue("@name", row.Cells("NameColumn").Value)
                                    cmd.Parameters.AddWithValue("@id", row.Cells("IdColumn").Value)
                                    cmd.Parameters.AddWithValue("@email", row.Cells("EmailColumn").Value)
                                    cmd.Parameters.AddWithValue("@number", row.Cells("NumberColumn").Value)
                                    cmd.Parameters.AddWithValue("@message", row.Cells("MessageColumn").Value)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' delete
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("No row selected.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IdColumn").Value)

        If MessageBox.Show("Are you sure you want to delete this message?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    ' Delete the message
                    Using deleteCmd As New MySqlCommand("DELETE FROM exception WHERE id = @Id", conn)
                        deleteCmd.Parameters.AddWithValue("@Id", id)
                        deleteCmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView
                LoadDataIntoDataGridView()
                MessageBox.Show("Message deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error deleting message: " & ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim searchTerm As String = searchTextBox.Text.Trim()

        If searchTerm.Length > 0 Then
            ' Build a filter expression for all searchable columns
            Dim filterExpression As String = String.Format("name LIKE '%{0}%' OR email LIKE '%{0}%' OR CONVERT(number, 'System.String') LIKE '%{0}%' OR message LIKE '%{0}%'", searchTerm)

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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
