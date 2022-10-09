Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListLabResult
    Private Sub ListLabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `labreport`"
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
        AddLabReport.MdiParent = MDIParent1
        AddLabReport.Left = 0
        AddLabReport.Top = 0
        AddLabReport.Text = "Update Examination Group"
        AddLabReport.SaveToolStripButton.Text = "Update"
        AddLabReport.PName.Text = False
        AddLabReport.PName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddLabReport.Address.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddLabReport.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddLabReport.Doctor = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddLabReport.LabTechnician = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddLabReport.TestPerformed = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddLabReport.Verified = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddLabReport.Delivered.Checked = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddLabReport.Notes.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddLabReport.ReportedDate.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        AddLabReport.LabNo.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        AddLabReport.TSH.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        AddLabReport.Show()
    End Sub
End Class