Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddInvoice
    Dim Pmode As String
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO referral values ('" & PName.Text & "','" & Address.Text & "','" & InvoiceNo.Text & "','" & DateTimePicker1.Text & "','" & Test.Text & "','" & Pmode & "','" & Paid.Enabled & "','" & Notes.Text & "','" & AllPaid.Enabled & "','" & Total.Text & "','" & Amount.Text & "','" & Percentage.Text & "','" & Amount2.Text & "','" & ReceivedCash.Text & "','" & ReturnedCash.Text & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Pmode = "Cash"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Pmode = "Online"
        End If
    End Sub

End Class