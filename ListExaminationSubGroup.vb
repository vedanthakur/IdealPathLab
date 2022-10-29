Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListExaminationSubGroup
    Private Sub ListExaminationSubGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from examinationsubgroup"
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
        AddExaminationSubGroup.MdiParent = MDIParent1
        AddExaminationSubGroup.Left = 0
        AddExaminationSubGroup.Top = 0
        AddExaminationSubGroup.Text = "Update Examination Sub Group"
        AddExaminationSubGroup.SaveToolStripButton.Text = "Update"
        AddExaminationSubGroup.TitleB.Enabled = False
        AddExaminationSubGroup.ExaminationGroup.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddExaminationSubGroup.TitleB.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddExaminationSubGroup.KeyB.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddExaminationSubGroup.RankB.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddExaminationSubGroup.SampleType.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddExaminationSubGroup.QRCode.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddExaminationSubGroup.Price.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddExaminationSubGroup.StatusP.Checked = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddExaminationSubGroup.Show()
    End Sub
End Class