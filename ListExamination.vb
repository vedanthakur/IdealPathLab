Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListExamination
    Private Sub ListExamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from examination"
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
        AddExamination.MdiParent = MDIParent1
        AddExamination.Left = 0
        AddExamination.Top = 0
        AddExamination.Text = "Update Referral"
        AddExamination.SaveToolStripButton.Text = "Update"
        AddExamination.TitleB.Enabled = False
        AddExamination.ExaminationGroup.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddExamination.ExaminationSubGroup.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddExamination.Unit.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddExamination.TitleB.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddExamination.KeyB.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddExamination.Rank.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddExamination.CodeB.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddExamination.ReportB.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddExamination.DefaultValue.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddExamination.SampleType.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        AddExamination.Price.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        AddExamination.Comment.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        AddExamination.ValidationonType.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        AddExamination.StatusP.Checked = DataGridView1.CurrentRow.Cells(13).Value.ToString
        AddExamination.Show()
    End Sub
End Class