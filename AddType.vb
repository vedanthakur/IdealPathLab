Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddType
    Public TableName As String
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO `" & TableName & "` values ('" & TitleName.Text & "','" & CheckBox1.Checked.ToString & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add " & Me.Text & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TitleName.Text = ""
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Referral " & Me.Text & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class