Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListReferral
    Private Sub ListReferral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `referral`;"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Address", "Phone", "Email", "Benifit", "Discount", "Status", "Name", "Contact Person"}
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        AddReferral.MdiParent = MDIParent1
        AddReferral.Left = 0
        AddReferral.Top = 0
        AddReferral.Text = "Update Referral"
        AddReferral.SaveToolStripButton.Text = "Update"
        AddReferral.ReferralName.Enabled = False
        AddReferral.Address.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddReferral.Phone.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddReferral.Email.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddReferral.SharingPersantage.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddReferral.DiscountKey.Checked = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddReferral.Status.Checked = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddReferral.ReferralType.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddReferral.ReferralName.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddReferral.RContactPerson.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddReferral.Show()
    End Sub
End Class