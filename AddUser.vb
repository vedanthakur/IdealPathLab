Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.Drawing.Image
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddUser
    Dim imgpath As String
    Dim arrimage() As Byte
    Public emailID As String

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
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO users values ('" & nameL.Text & "', '" & roll.Text & "','" & email.Text & "','" & address.Text & "','" & mobile.Text & "','" & password.Text & "','" & branch.Text & "','" & humanResource.Text & "', '" & userB.Enabled.ToString & "', @img , '" & status.Enabled.ToString & "');"
            Else
                sqlcmd = "UPDATE `users` SET `username`='" & nameL.Text & "',`roll`='" & roll.Text & "',`email`='" & email.Text & "',`address`='" & address.Text & "',`mobile`=" & mobile.Text & ",`password`='" & password.Text & "',`branch`='" & branch.Text & "',`humanResource`='" & humanResource.Text & "',`showUserWiseData`='" & userB.Checked.ToString & "',`image`= @img,`status`='" & status.Checked.ToString & "' WHERE email = '" & email.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            If SaveToolStripButton.Text = "Update" Then
                ImageFunction()
            End If
            mysc.Parameters.AddWithValue("@img", arrimage)

            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `branch_name` from branch"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim sBranch = rd.GetString("branch_name")
                branch.Items.Add(sBranch)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        ImageFunction()
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

    Private Sub mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobile.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select * from users where email = '" & emailID & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                nameL.Text = rd.GetString("username")
                roll.Text = rd.GetString("roll")
                address.Text = rd.GetString("address")
                mobile.Text = rd.GetString("mobile")
                password.Text = rd.GetString("password")
                branch.Text = rd.GetString("branch")
                humanResource.Text = rd.GetString("humanResource")
                userB.Checked = rd.GetString("showUserWiseData")
                status.Checked = rd.GetString("status")
                If UserProfile.NoImage.Visible = False Then
                    Dim img() As Byte
                    img = rd("image")
                    Dim ms As New MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Timer1.Stop()
    End Sub
End Class