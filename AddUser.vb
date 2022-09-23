Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.Drawing.Image
Imports System.IO

Public Class AddUser
    Dim statusC As Boolean
    Dim showUserWiseDataC As Boolean

    Dim imgpath As String
    Dim arrimage() As Byte
    Private Sub Button2_Click(sender As Object, e As EventArgs)
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
            sql = "INSERT INTO users values ('" & nameL.Text & "', '" & roll.Text & "','" & email.Text & "','" & address.Text & "','" & mobile.Text & "','" & password.Text & "','" & branch.Text & "','" & humanResource.Text & "', '" & showUserWiseData.ToString & "', @img , '" & status.ToString & "');"
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

    Private Sub status_CheckedChanged(sender As Object, e As EventArgs) Handles status.CheckedChanged
        statusC = status.Checked
    End Sub

    Private Sub showUserWiseData_CheckedChanged(sender As Object, e As EventArgs) Handles showUserWiseData.CheckedChanged
        showUserWiseDataC = showUserWiseData.Checked
    End Sub

    Private Sub imgUpload_Click(sender As Object, e As EventArgs) Handles imgUpload.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub

End Class