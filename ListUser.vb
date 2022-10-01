Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListUser
    Private Sub ListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from users"
            con.Open()
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
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(e.RowIndex)
        Dim id As Integer = selectedRow.Index
        MsgBox(id)
    End Sub
End Class