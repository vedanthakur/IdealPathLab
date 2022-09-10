Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddBranch
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO branch values ('" & BranchNameTBox.Text & "', '" & AddressTBox.Text & "','" & PhoneNoTBox.Text & "','" & EmailTBox.Text & "','" & ImageL.Text & "','" & ContactPersonTBox.Text & "','" & StatusCkBox.Text & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class