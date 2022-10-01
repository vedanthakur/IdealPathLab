Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddSampleCollection
    Private Sub AddSampleCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            Button1.Text = "Current Time"
        Else
            Timer1.Enabled = True
            Button1.Text = "Custom Time"
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO sample values ('" & InvoiceNo.Text & "','" & PName.Text & "','" & Address.Text & "','" & SCollectedBy.Text & "','" & Description.Text & "','" & Status.Text & "','" & DateTimePicker1.Text & "','" & Time.Text & "','" & Notes.Text & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class