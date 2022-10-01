Imports Org.BouncyCastle.Crypto
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Numerics
Imports System.Reflection.Emit

Public Class AddPatient
    Dim imgpath As String
    Dim arrimage() As Byte
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
            sql = "INSERT INTO patient values ('" & PName.Text & "', '" & Gender.Text & "','" & Address.Text & "','" & Mobile.Text & "','" & DOB.ToString & "','" & Age.Text & "','" & Referral.Text & "','" & RLab.Text & "','" & Nationality.Text & "','" & Email.Text & "','" & Phone.Text & "','" & MaritalStatus.Text & "', @img ,'" & Country.Text & "','" & PassportNo.Text & "','" & PassportIssuedDate.CustomFormat & "','" & PassportExpiredDate.ToString & "','" & PIssuedDistrict.Text & "','" & CitizenshipNo.Text & "','" & CPerson.Text & "','" & CPRelation.Text & "','" & CPPhone.Text & "' );"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub

End Class