Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Security.Policy

Public Class AddHumanResource
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim imgpath2 As String
    Dim arrimage2() As Byte
    Dim useC As Byte
    Dim statusC As Byte
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer


            Dim memstr As New MemoryStream()
            Dim memstr2 As New MemoryStream()
            PictureBox2.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            PictureBox1.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            arrimage = memstr.GetBuffer()
            arrimage2 = memstr2.GetBuffer()
            Dim filesize As UInt32
            Dim filesize2 As UInt32
            filesize = memstr.Length
            filesize2 = memstr2.Length
            memstr.Close()
            memstr2.Close()
            con.Open()
            sql = "INSERT INTO hr values ('" & PName.Text & "', '" & Address.Text & "','" & Email.Text & "','" & Phone.Text & "', @img ,'" & HRType.Text & "','" & Position.Text & "','" & CuncilNo.Text & "', '" & Rank.Text & "', @img2 , '" & Facebook.Text & "', '" & Twitter.Text & "', '" & Instagram.Text & "', '" & YouTube.Text & "', '" & useC & "', '" & statusC & "', '" & Speciqlization.Text & "' );"
            Dim mysc As New MySqlCommand(sql, con)
            mysc.Parameters.AddWithValue("@img", arrimage)
            mysc.Parameters.AddWithValue("@img2", arrimage2)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub UseB_CheckedChanged(sender As Object, e As EventArgs) Handles useB.CheckedChanged
        If useB.Checked Then
            useC = 1
        Else
            useC = 0
        End If
    End Sub

    Private Sub statusB_CheckedChanged(sender As Object, e As EventArgs) Handles statusB.CheckedChanged
        If statusB.Checked Then
            statusC = 1
        Else
            statusC = 0
        End If
    End Sub
End Class