Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Security.Policy
Imports Google.Protobuf.Reflection.FieldDescriptorProto.Types

Public Class AddHumanResource
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim imgpath2 As String
    Dim arrimage2() As Byte
    Public emailID As String
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO hr values ('" & PName.Text & "', '" & Address.Text & "','" & Email.Text & "','" & Phone.Text & "', @img ,'" & HRType.Text & "','" & Position.Text & "','" & CuncilNo.Text & "', '" & Rank.Text & "', @img2 , '" & Facebook.Text & "', '" & Twitter.Text & "', '" & Instagram.Text & "', '" & YouTube.Text & "', '" & useB.Enabled.ToString & "', '" & statusB.Enabled.ToString & "', '" & Speciqlization.Text & "' );"
            Else
                sqlcmd = "UPDATE `hr` SET `name`='" & PName.Text & "',`address`='" & Address.Text & "',`email`='" & Email.Text & "',`phone`='" & Phone.Text & "',`image`= @img,`type`='" & HRType.Text & "',`position`='" & Position.Text & "',`crn`='" & CuncilNo.Text & "',`rank`='" & Rank.Text & "',`signature`= @img2,`facebook`='" & Facebook.Text & "',`twitter`='" & Twitter.Text & "',`instagram`='" & Instagram.Text & "',`youtube`='" & YouTube.Text & "',`su`='" & useB.Checked.ToString & "',`status`='" & statusB.Checked.ToString & "',`speciqlization`='" & Speciqlization.Text & "' WHERE email = '" & Email.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            ImageFunction()
            ImageFunction2()
            mysc.Parameters.AddWithValue("@img", arrimage)
            mysc.Parameters.AddWithValue("@img2", arrimage2)

            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
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

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        ImageFunction()
    End Sub

    Private Sub PictureBox2_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox2.LoadCompleted
        ImageFunction2()
    End Sub

    Private Sub ImageFunction()
        Dim memstr As New MemoryStream()
        PictureBox1.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
        arrimage = memstr.GetBuffer()
        Dim filesize As UInt32
        filesize = memstr.Length
        If filesize > 500000 Then
            ImageSizeLabel.ForeColor = Color.DarkRed
            ImageSizeLabel.Text = "Image size should be less than 500 KB"
        Else
            ImageSizeLabel.Text = " "
        End If
        memstr.Close()
    End Sub



    Private Sub ImageFunction2()
        Dim memstr2 As New MemoryStream()
        PictureBox2.Image.Save(memstr2, Imaging.ImageFormat.Jpeg)
        arrimage2 = memstr2.GetBuffer()
        Dim filesize2 As UInt32
        filesize2 = memstr2.Length
        If filesize2 > 500000 Then
            ImageSizeLabel2.ForeColor = Color.DarkRed
            ImageSizeLabel2.Text = "Image size should be less than 500 KB"
        Else
            ImageSizeLabel2.Text = " "
        End If
        memstr2.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select * from hr where email = '" & emailID & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                PName.Text = rd.GetString("name")
                Address.Text = rd.GetString("address")
                Email.Text = rd.GetString("email")
                Phone.Text = rd.GetString("phone")
                HRType.Text = rd.GetString("type")
                Position.Text = rd.GetString("position")
                CuncilNo.Text = rd.GetString("crn")
                Rank.Text = rd.GetString("rank")
                Facebook.Text = rd.GetString("facebook")
                Twitter.Text = rd.GetString("twitter")
                Instagram.Text = rd.GetString("instagram")
                YouTube.Text = rd.GetString("youtube")
                useB.Checked = rd.GetString("su")
                statusB.Checked = rd.GetString("status")
                Speciqlization.Text = rd.GetString("speciqlization")
                If OneHumanResource.NoImage.Visible = False Then
                    Dim img() As Byte
                    img = rd("image")
                    Dim ms As New MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End If
                If OneHumanResource.NoImage2.Visible = False Then
                    Dim img2() As Byte
                    img2 = rd("signature")
                    Dim ms2 As New MemoryStream(img2)
                    PictureBox2.Image = Image.FromStream(ms2)
                    PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Timer1.Stop()
    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CuncilNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CuncilNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class