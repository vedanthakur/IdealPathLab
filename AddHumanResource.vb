Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView

Public Class AddHumanResource
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim imgpath2 As String
    Dim arrimage2() As Byte
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer


            Dim memstr As New MemoryStream()
            Dim memstr2 As New MemoryStream()
            PictureBox1.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            PictureBox2.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            arrimage = memstr.GetBuffer()
            arrimage2 = memstr2.GetBuffer()
            Dim filesize As UInt32
            Dim filesize2 As UInt32
            filesize = memstr.Length
            filesize2 = memstr2.Length
            memstr.Close()
            memstr2.Close()
            con.Open()
            sql = "INSERT INTO users values ('" & PName.Text & "', '" & Address.Text & "','" & Email.Text & "','" & Phone.Text & "', @img ,'" & HRType.Text & "','" & Position.Text & "','" & CuncilNo.Text & "', '" & Rank.Text & "', @img2 , '" & Use.Text & "', '" & Publish.Text & "', '" & Speciqlization.Text & "', '" & Facebook.Text & "', '" & Twitter.Text & "', '" & Instagram.Text & "', '" & YouTube.Text & "' );"
            Dim mysc As New MySqlCommand(sql, con)
            mysc.Parameters.AddWithValue("@img", arrimage)
            mysc.Parameters.AddWithValue("@img2", arrimage2)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim openfiledialog2 As New OpenFileDialog()
        openfiledialog2.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath2 = openfiledialog2.FileName
            PictureBox2.ImageLocation = imgpath2
        End If
    End Sub
End Class