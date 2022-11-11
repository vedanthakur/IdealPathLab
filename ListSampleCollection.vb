Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListSampleCollection
    Private Sub ListSampleCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `sample`;"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Invoice No.", "Patient Name", "Address", "Sample Collected", "Description", "Status", "Collection Date", "Time", "Notes"}
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
        OneSampleCollection.MdiParent = MDIParent1
        OneSampleCollection.Show()
        OneSampleCollection.Left = 0
        OneSampleCollection.Top = 0
        OneSampleCollection.InvoiceNo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        OneSampleCollection.PName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        OneSampleCollection.Address.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        OneSampleCollection.CollectedBy.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        OneSampleCollection.Description.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        OneSampleCollection.Status.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        OneSampleCollection.CollectionDate.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        OneSampleCollection.CTime.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        OneSampleCollection.Notes.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
    End Sub
End Class