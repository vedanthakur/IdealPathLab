Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=ipl")
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @username AND `password` = @password", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else
            MDIParent1.Show()
            MDIParent1.welcomeName.Text = UsernameTextBox.Text
            Me.Hide()
        End If


    End Sub
End Class
