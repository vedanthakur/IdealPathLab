Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient

Public Class ListUser
    Private Sub ListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select `name`, `role`, `email`, `address`, `mobile`, `branch`, `humanResource`, `showUserWiseData`, `image`, `status` from `users`;"
            con.Open()
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Name", "Role", "Email", "Address", "Mobile", "Branch", "Human Resource", "Show User Wise Data", "Image", "Status"}
            For Each CName In Names
                DataGridView1.Columns(CIndex).HeaderText = CName
                CIndex += 1
            Next
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        UserProfile.MdiParent = MDIParent1

        UserProfile.Left = 0
        UserProfile.Top = 0
        UserProfile.UName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        UserProfile.RollnBranch.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString & " • " & DataGridView1.CurrentRow.Cells(5).Value.ToString & " Branch"
        UserProfile.ContactDetails.Text = "From " & DataGridView1.CurrentRow.Cells(3).Value.ToString & " • " & DataGridView1.CurrentRow.Cells(2).Value.ToString & " • " & DataGridView1.CurrentRow.Cells(4).Value.ToString
        UserProfile.HR.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        UserProfile.emailID = DataGridView1.CurrentRow.Cells(2).Value.ToString
        UserProfile.Show()

    End Sub
End Class