Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListTypeHR
    Private Sub ListTypeHR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from hr_type"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Title"
            DataGridView1.Columns(1).HeaderText = "Group"
            DataGridView1.Columns(2).HeaderText = "Status"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class