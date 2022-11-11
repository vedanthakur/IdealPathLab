Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Dim command As New MySqlCommand("SELECT `email`, `password` FROM `users` WHERE `email` = '" & UsernameTextBox.Text & "' AND `password` = '" & PasswordTextBox.Text & "'", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username Or Password")
        Else
            con.Close()
            MDIParent1.Show()
            MDIParent1.Timer1.Enabled = True
            MDIParent1.welcomeName.Text = UsernameTextBox.Text
            ClearTextBox(Me)
            Me.Hide()
        End If
    End Sub

    Public Sub ClearTextBox(parent As Control)
        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next
        If TryCast(parent, System.Windows.Forms.TextBox) IsNot Nothing Then
            TryCast(parent, System.Windows.Forms.TextBox).Text = [String].Empty
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If (Asc(e.KeyChar) = 10) Then
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
        End If
    End Sub

End Class
