Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListType
    Public TableName As String

    Private Sub ListType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from branch"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Timer1.Stop()
    End Sub
End Class