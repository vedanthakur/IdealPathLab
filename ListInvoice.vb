Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListInvoice
    Private Sub ListInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `invoice`;"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Patient Name", "Address", "Invoice No.", "Inoice Date", "Test", "Payment Mode", "Paid", "Note", "Total", "Paid Amount"}
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
        AddInvoice.MdiParent = MDIParent1
        AddInvoice.Show()
        AddInvoice.Left = 0
        AddInvoice.Top = 0
        AddInvoice.Text = "Update Invoice"
        AddInvoice.SaveToolStripButton.Text = "Update"
        AddInvoice.InvoiceNo.Enabled = False
        AddInvoice.PName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddInvoice.Address.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddInvoice.InvoiceNo.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddInvoice.DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddInvoice.Test.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddInvoice.P_mode.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddInvoice.Paid.Checked = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddInvoice.Notes.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddInvoice.Total.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddInvoice.PaidAmount.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
    End Sub
End Class