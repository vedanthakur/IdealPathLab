Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddTypeHR
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO `hr_type` values ('" & TitleName.Text & "','" & GroupName.Text & "','" & CheckBox1.Checked.ToString & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add HR Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TitleName.Text = ""
                GroupName.Text = ""
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add HR Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class