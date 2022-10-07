Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListHumanResource
    Private Sub ListHumanResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from hr"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        OneHumanResource.MdiParent = MDIParent1
        OneHumanResource.Left = 0
        OneHumanResource.Top = 0
        OneHumanResource.emailID = DataGridView1.CurrentRow.Cells(2).Value.ToString
        'OneHumanResource.UName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'OneHumanResource.ContactDetails.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString & " | " & DataGridView1.CurrentRow.Cells(2).Value.ToString & " | " & DataGridView1.CurrentRow.Cells(3).Value.ToString
        'OneHumanResource.Type.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString & " | " & DataGridView1.CurrentRow.Cells(5).Value.ToString & " | " &
        'OneHumanResource.Speciqlization.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString & " | " & DataGridView1.CurrentRow.Cells(16).Value.ToString & " | " & DataGridView1.CurrentRow.Cells(8).Value.ToString
        'OneHumanResource.Facebook.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        'OneHumanResource.Twitter.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        'OneHumanResource.Instagram.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        'OneHumanResource.YouTube.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        'OneHumanResource.userWD.Checked = DataGridView1.CurrentRow.Cells(14).Value.ToString
        'OneHumanResource.publishS.Checked = DataGridView1.CurrentRow.Cells(15).Value.ToString

        OneHumanResource.Show()
    End Sub
End Class