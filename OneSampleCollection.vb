Public Class OneSampleCollection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddSampleCollection.MdiParent = MDIParent1
        AddSampleCollection.Show()
        AddSampleCollection.Left = 0
        AddSampleCollection.Top = 0
        AddSampleCollection.Text = "Edit Sample Collection"
        AddSampleCollection.SaveToolStripButton.Text = "Update"
        AddSampleCollection.Button1.Text = "Set Current Time"
        AddSampleCollection.InvoiceNo.Enabled = False
        AddSampleCollection.InvoiceNo.Text = InvoiceNo.Text
        AddSampleCollection.PName.Text = PName.Text
        AddSampleCollection.Address.Text = Address.Text
        AddSampleCollection.CollectedBy.Text = CollectedBy.Text
        AddSampleCollection.Description.Text = Description.Text
        AddSampleCollection.Status.Text = Status.Text
        AddSampleCollection.CollectionDate.Text = CollectionDate.Text
        AddSampleCollection.CTime.Text = CTime.Text
        AddSampleCollection.Notes.Text = Notes.Text
    End Sub
End Class