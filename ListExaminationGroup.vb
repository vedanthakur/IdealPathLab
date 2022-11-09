Imports System.Data.Entity.Core.Metadata.Edm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math

Public Class ListExaminationGroup
    Private Sub ListExaminationGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from examinationgroup"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Department", "Title", "Key", "Rank", "Interpretation", "Specification", "Sample Type", "Price", "Status"}
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
        AddExaminationGroup.MdiParent = MDIParent1
        AddExaminationGroup.Left = 0
        AddExaminationGroup.Top = 0
        AddExaminationGroup.Text = "Update Examination Group"
        AddExaminationGroup.SaveToolStripButton.Text = "Update"
        AddExaminationGroup.TitleB.Enabled = False
        AddExaminationGroup.Department.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddExaminationGroup.TitleB.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddExaminationGroup.KeyB.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddExaminationGroup.RankB.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddExaminationGroup.Interpretation.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddExaminationGroup.Specification.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddExaminationGroup.Price.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddExaminationGroup.SampleType.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddExaminationGroup.StatusP.Checked = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddExaminationGroup.Show()
    End Sub
End Class