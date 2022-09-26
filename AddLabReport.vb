Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports Org.BouncyCastle.Crypto

Public Class AddLabReport
    Dim Doctor, LabTechnician, TestPerformed, Verified As String
    Dim imgpath As String
    Dim arrimage() As Byte

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer


            Dim memstr As New MemoryStream()
            PictureBox1.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            arrimage = memstr.GetBuffer()
            Dim filesize As UInt32
            filesize = memstr.Length
            memstr.Close()
            con.Open()
            sql = "INSERT INTO branch values ('" & PName.Text & "', '" & Address.Text & "','" & DateTimePicker1.Text & "','" & Doctor & "','" & LabTechnician & "','" & TestPerformed & "','" & Verified & "','" & DateTimePicker2.ToString & "','" & LabNo.Text & "','" & TSH.Text & "', @img ,'" & Delivered.Enabled & "','" & Notes.Text & "' );"
            Dim mysc As New MySqlCommand(sql, con)
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class