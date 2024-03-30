Imports MySql.Data.MySqlClient

Public Class DatabaseFunctions
    Inherits DatabaseConnection

    Public Overrides Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
        Dim count As Integer = 0

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' If count is greater than 0, username and password match
        Return count > 0
    End Function

    Public Function GetDepartmentNames() As List(Of String)
        Dim departmentNames As New List(Of String)()

        Dim query As String = "SELECT depName FROM Department"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                departmentNames.Add(reader("depName").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return departmentNames
    End Function

    Public Function RegisterUser(firstName As String, middleName As String, lastName As String, birthday As Date, username As String, password As String, email As String, contact As String, address As String, department As String, governmentID As String, bankDetails As String, tinID As String, gender As String) As Boolean
        Dim query As String = "INSERT INTO users (first_name, middle_name, last_name, birthday, username, password, email, contact_number, address, department, government_id, bank_details, tin_id, gender) VALUES (@firstName, @middleName, @lastName, @birthday, @username, @password, @email, @contact, @address, @department, @governmentID, @bankDetails, @tinID, @gender)"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@firstName", firstName)
            cmd.Parameters.AddWithValue("@middleName", middleName)
            cmd.Parameters.AddWithValue("@lastName", lastName)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@contact", contact)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.Parameters.AddWithValue("@governmentID", governmentID)
            cmd.Parameters.AddWithValue("@bankDetails", bankDetails)
            cmd.Parameters.AddWithValue("@tinID", tinID)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registration successful!")
                RegistrationPage.Close()
                LoginPage.Show()
            Else
                MessageBox.Show("Registration failed!")
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function GetUserIDByUsername(username As String) As Integer
        Dim userID As Integer = 0
        Dim query As String = "SELECT id FROM users WHERE username = @username"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                userID = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return userID
    End Function
    Public Function AuthenticateAndGetUserID(username As String, password As String) As Integer
        Dim userID As Integer = 0
        Dim query As String = "SELECT id FROM users WHERE username = @username AND password = @password"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                userID = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return userID
    End Function

End Class
