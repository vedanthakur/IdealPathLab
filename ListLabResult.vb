Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListLabResult
    Private Sub ListLabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `labreport`"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class