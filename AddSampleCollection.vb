Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddSampleCollection
    Private Sub AddSampleCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SaveToolStripButton.Text = "Save" Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            Button1.Text = "Set Current Time"
        Else
            Timer1.Enabled = True
            Button1.Text = "Set Custom Time"
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO sample values ('" & InvoiceNo.Text & "','" & PName.Text & "','" & Address.Text & "','" & CollectedBy.Text & "','" & Description.Text & "','" & Status.Text & "','" & CollectionDate.Text & "','" & CTime.Text & "','" & Notes.Text & "');"
            Else
                sqlcmd = "UPDATE `sample` SET `pname`='" & PName.Text & "',`address`='" & Address.Text & "',`samplecollected`='" & CollectedBy.Text & "',`description`='" & Description.Text & "',`status`='" & Status.Text & "',`collection_date`='" & CollectionDate.Text & "',`time` ='" & CTime.Text & "',`notes` ='" & Notes.Text & "' WHERE `invoice_no` = '" & InvoiceNo.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Sample Collection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class