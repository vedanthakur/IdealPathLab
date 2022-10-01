Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.Drawing.Image
Imports System.IO
Public Class AddUser
    Dim statusC As Byte = 1
    Dim userC As Byte = 1

    Dim imgpath As String
    Dim arrimage() As Byte

    Private Sub status_CheckedChanged(sender As Object, e As EventArgs) Handles status.CheckedChanged
        If status.Checked Then
            statusC = 1
        Else
            statusC = 0
        End If
    End Sub



    Private Sub imgUpload_Click(sender As Object, e As EventArgs) Handles imgUpload.Click
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
            sql = "INSERT INTO users values ('" & nameL.Text & "', '" & roll.Text & "','" & email.Text & "','" & address.Text & "','" & mobile.Text & "','" & password.Text & "','" & branch.Text & "','" & humanResource.Text & "', '" & userB.Enabled.ToString & "', @img , '" & status.Enabled.ToString & "');"
            Dim mysc As New MySqlCommand(sql, con)

            mysc.Parameters.AddWithValue("@img", arrimage)

            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub userB_CheckedChanged(sender As Object, e As EventArgs) Handles userB.CheckedChanged
        If userB.Checked Then
            statusC = 1
        Else
            statusC = 0
        End If
    End Sub
End Class