Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class RegistrationPage
    Private dbFunctions As New DatabaseFunctions()

    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

        ' Populate the department dropdown
        PopulateDepartmentDropdown()

        ' Add event handlers for controls
        AddHandlers()
        CheckRegistrationCompletion()
    End Sub

    Private Sub AddHandlers()
        ' Add event handlers for textboxes
        AddHandler FirstNameTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler MiddleNameTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler LastNameTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler UsernameTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler PasswordTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler EmailTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler ContactTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler AddressTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler GovermentTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler BankDetailsTextbox.TextChanged, AddressOf CheckRegistrationCompletion
        AddHandler TinTextbox.TextChanged, AddressOf CheckRegistrationCompletion

        ' Add event handlers for radio buttons
        AddHandler MaleRadioButton.CheckedChanged, AddressOf CheckRegistrationCompletion
        AddHandler FemaleRadioButton.CheckedChanged, AddressOf CheckRegistrationCompletion
        AddHandler NotToRadioButton.CheckedChanged, AddressOf CheckRegistrationCompletion

        ' Add event handler for dropdown
        AddHandler DepartmentDropdown.SelectedIndexChanged, AddressOf CheckRegistrationCompletion
    End Sub

    Private Sub CheckRegistrationCompletion()
        Dim isRadioButtonSelected As Boolean = MaleRadioButton.Checked OrElse FemaleRadioButton.Checked OrElse NotToRadioButton.Checked
        Dim isDepartmentSelected As Boolean = DepartmentDropdown.SelectedItem IsNot Nothing AndAlso DepartmentDropdown.SelectedItem.ToString() <> ""

        If Not String.IsNullOrWhiteSpace(FirstNameTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(MiddleNameTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(LastNameTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(UsernameTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(PasswordTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(EmailTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(ContactTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(AddressTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(GovermentTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(BankDetailsTextbox.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TinTextbox.Text) AndAlso
           isRadioButtonSelected AndAlso
           isDepartmentSelected Then
            CompleteRegistration.Enabled = True
            CompleteRegistration.BackColor = Color.FromArgb(0, 82, 8)
        Else
            CompleteRegistration.Enabled = False
            CompleteRegistration.BackColor = Color.Gray
        End If
    End Sub
    Private Sub FirstNameTextbox_Enter(sender As Object, e As EventArgs) Handles FirstNameTextbox.Enter
        If FirstNameTextbox.Text = "" Then
            FirstNameTextbox.Text = ""
            FirstNameTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub FirstNameTextbox_Leave(sender As Object, e As EventArgs) Handles FirstNameTextbox.Leave
        If FirstNameTextbox.Text = "" Then
            FirstNameTextbox.Text = "Firstname"
            FirstNameTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub MiddleNameTextbox_Enter(sender As Object, e As EventArgs) Handles MiddleNameTextbox.Enter
        If MiddleNameTextbox.Text = "Middle Name" Then
            MiddleNameTextbox.Text = ""
            MiddleNameTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MiddleNameTextbox_Leave(sender As Object, e As EventArgs) Handles MiddleNameTextbox.Leave
        If MiddleNameTextbox.Text = "" Then
            MiddleNameTextbox.Text = "Middle Name"
            MiddleNameTextbox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub LastNameTextbox_Enter(sender As Object, e As EventArgs) Handles LastNameTextbox.Enter
        If LastNameTextbox.Text = "Surname" Then
            LastNameTextbox.Text = ""
            LastNameTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LastNameTextbox_Leave(sender As Object, e As EventArgs) Handles LastNameTextbox.Leave
        If LastNameTextbox.Text = "" Then
            LastNameTextbox.Text = "Surname"
            LastNameTextbox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub UsernameTextbox_Enter(sender As Object, e As EventArgs) Handles UsernameTextbox.Enter
        If UsernameTextbox.Text = "Username" Then
            UsernameTextbox.Text = ""
            UsernameTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UsernameTextbox_Leave(sender As Object, e As EventArgs) Handles UsernameTextbox.Leave
        If UsernameTextbox.Text = "" Then
            UsernameTextbox.Text = "Username"
            UsernameTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub PasswordTextbox_Enter(sender As Object, e As EventArgs) Handles PasswordTextbox.Enter
        If PasswordTextbox.Text = "********" Then
            PasswordTextbox.Text = ""
            PasswordTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PasswordTextbox_Leave(sender As Object, e As EventArgs) Handles PasswordTextbox.Leave
        If PasswordTextbox.Text = "" Then
            PasswordTextbox.Text = "********"
            PasswordTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub EmailTextbox_Enter(sender As Object, e As EventArgs) Handles EmailTextbox.Enter, Label12.Enter
        If EmailTextbox.Text = "Email" Then
            EmailTextbox.Text = ""
            EmailTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub EmailTextbox_Leave(sender As Object, e As EventArgs) Handles EmailTextbox.Leave, Label12.Leave
        If EmailTextbox.Text = "" Then
            EmailTextbox.Text = "Email"
            EmailTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub ContactTextbox_Enter(sender As Object, e As EventArgs) Handles ContactTextbox.Enter
        If ContactTextbox.Text = "Contact No#" Then
            ContactTextbox.Text = ""
            ContactTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ContactTextbox_Leave(sender As Object, e As EventArgs) Handles ContactTextbox.Leave
        If ContactTextbox.Text = "" Then
            ContactTextbox.Text = "Contact No#"
            ContactTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub AddressTextbox_Enter(sender As Object, e As EventArgs) Handles AddressTextbox.Enter
        If AddressTextbox.Text = "Address" Then
            AddressTextbox.Text = ""
            AddressTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub AddressTextbox_Leave(sender As Object, e As EventArgs) Handles AddressTextbox.Leave
        If AddressTextbox.Text = "" Then
            AddressTextbox.Text = "Address"
            AddressTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub GovermentTextbox_Enter(sender As Object, e As EventArgs) Handles GovermentTextbox.Enter
        If GovermentTextbox.Text = "Social Security" Then
            GovermentTextbox.Text = ""
            GovermentTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub GovermentTextbox_Leave(sender As Object, e As EventArgs) Handles GovermentTextbox.Leave
        If GovermentTextbox.Text = "" Then
            GovermentTextbox.Text = "Social Security"
            GovermentTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub BankDetailsTextbox_Enter(sender As Object, e As EventArgs) Handles BankDetailsTextbox.Enter
        If BankDetailsTextbox.Text = "33-7913734-2" Then
            BankDetailsTextbox.Text = ""
            BankDetailsTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BankDetailsTextbox_Leave(sender As Object, e As EventArgs) Handles BankDetailsTextbox.Leave
        If BankDetailsTextbox.Text = "" Then
            BankDetailsTextbox.Text = "12-3913734-2"
            BankDetailsTextbox.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub TinTextbox_Enter(sender As Object, e As EventArgs) Handles TinTextbox.Enter
        If TinTextbox.Text = "123-456-789-000" Then
            TinTextbox.Text = ""
            TinTextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TinTextbox_Leave(sender As Object, e As EventArgs) Handles TinTextbox.Leave
        If TinTextbox.Text = "" Then
            TinTextbox.Text = "123-456-789-000"
            TinTextbox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub RegistrationPage_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 25S
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        Me.Region = New Region(gp)
    End Sub

    Private Sub PopulateDepartmentDropdown()
        ' Clear existing items
        DepartmentDropdown.Items.Clear()

        ' Get department names from the database
        Dim departmentNames As List(Of String) = dbFunctions.GetDepartmentNames()

        ' Add department names to the dropdown
        For Each departmentName As String In departmentNames
            DepartmentDropdown.Items.Add(departmentName)
        Next
    End Sub

    Private Sub CompleteRegistration_Click(sender As Object, e As EventArgs) Handles CompleteRegistration.Click
        Dim firstName As String = FirstNameTextbox.Text
        Dim middleName As String = MiddleNameTextbox.Text
        Dim lastName As String = LastNameTextbox.Text
        Dim username As String = UsernameTextbox.Text
        Dim birthday As String = BirthdayPicker.Value.ToString("yyyy-MM-dd")
        Dim password As String = PasswordTextbox.Text
        Dim email As String = EmailTextbox.Text
        Dim contact As String = ContactTextbox.Text
        Dim address As String = AddressTextbox.Text
        Dim department As String = DepartmentDropdown.SelectedItem.ToString()
        Dim governmentID As String = GovermentTextbox.Text
        Dim bankDetails As String = BankDetailsTextbox.Text
        Dim tinID As String = TinTextbox.Text
        Dim gender As String = If(MaleRadioButton.Checked, "Male", If(FemaleRadioButton.Checked, "Female", "Not Specified"))
        Dim registrationSuccess As Boolean = dbFunctions.RegisterUser(firstName, middleName, lastName, birthday, username, password, email, contact, address, department, governmentID, bankDetails, tinID, gender)
        Me.Close()
        LoginPage.Show()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class
