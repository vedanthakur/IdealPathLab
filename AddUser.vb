Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddUser
    Dim statusC As Boolean
    Dim showUserWiseDataC As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO users values ('" & nameL.Text & "', '" & roll.Text & "','" & email.Text & "','" & address.Text & "','" & mobile.Text & "','" & password.Text & "','" & branch.Text & "','" & humanResource.Text & "','" & showUserWiseDataC & "','" & imgUpload.Text & "','" & statusC & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub status_CheckedChanged(sender As Object, e As EventArgs) Handles status.CheckedChanged
        statusC = status.Checked
    End Sub

    Private Sub showUserWiseData_CheckedChanged(sender As Object, e As EventArgs) Handles showUserWiseData.CheckedChanged
        showUserWiseDataC = showUserWiseData.Checked
    End Sub
End Class