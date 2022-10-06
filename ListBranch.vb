Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListBranch
    Private Sub ListBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        OneBranch.MdiParent = MDIParent1
        OneBranch.Left = 0
        OneBranch.Top = 0

        OneBranch.UName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        OneBranch.ContactPerson.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        OneBranch.Address.Text = "Address: " & DataGridView1.CurrentRow.Cells(1).Value.ToString
        OneBranch.ContactDetails.Text = "Email: " & DataGridView1.CurrentRow.Cells(3).Value.ToString & " • Phone " & DataGridView1.CurrentRow.Cells(2).Value.ToString
        OneBranch.ContactPerson.Text = "Contact Person: " & DataGridView1.CurrentRow.Cells(5).Value.ToString
        OneBranch.branchName = DataGridView1.CurrentRow.Cells(0).Value.ToString
        OneBranch.Show()
    End Sub


End Class