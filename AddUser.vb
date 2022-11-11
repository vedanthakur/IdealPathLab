Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.Drawing.Image
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Google.Protobuf.WellKnownTypes
Imports System.Numerics

Public Class AddUser
    Dim imgpath As String
    Dim arrimage() As Byte
    Public emailID As String

    Private Sub ImgUpload_Click(sender As Object, e As EventArgs) Handles imgUpload.Click
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
            If SaveToolStripButton.Text = "Save" Then
                sql = "INSERT INTO users values ('" & nameL.Text & "', '" & role.Text & "','" & email.Text & "','" & address.Text & "','" & mobile.Text & "','" & password.Text & "','" & branch.Text & "','" & humanResource.Text & "', '" & userB.Enabled.ToString & "', @img , '" & status.Enabled.ToString & "');"
            Else
                sql = "UPDATE `users` SET `name`='" & nameL.Text & "',`role`='" & role.Text & "',`email`='" & email.Text & "',`address`='" & address.Text & "',`mobile`=" & mobile.Text & ",`password`='" & password.Text & "',`branch`='" & branch.Text & "',`humanResource`='" & humanResource.Text & "',`showUserWiseData`='" & userB.Checked.ToString & "',`image`= @img,`status`='" & status.Checked.ToString & "' WHERE email = '" & email.Text & "';"
            End If
            Dim mysc As New MySqlCommand(sql, con)
            If SaveToolStripButton.Text = "Update" Then
                ImageFunction()
            End If
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                    ClearPictureBox(PictureBox1)
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

    Public Sub ClearTextBox(parent As Control)
        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next
        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If
    End Sub

    Private Sub ClearPictureBox(pb As PictureBox)
        pb.Image = Nothing
        pb.BackColor = Color.Empty
        pb.Invalidate()
        pb.BackColor = Color.Transparent
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadElements("hr_type", "title")
        LoadElements("branch", "branch_name")
        If SaveToolStripButton.Text = "Save" Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Sub LoadElements(TableName As String, Cname As String)
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `" & Cname & "` from `" & TableName & "`"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim elements = rd.GetString("" & Cname & "")
                If TableName = "branch" Then
                    branch.Items.Add(elements)
                Else
                    humanResource.Items.Add(elements)
                End If
            End While
            con.Close()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select * from `users` where `email` = '" & emailID & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                nameL.Text = rd.GetString("name")
                role.Text = rd.GetString("role")
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
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Timer1.Stop()
    End Sub

    Private Sub NameL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nameL.KeyPress
        ' String and space
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles address.KeyPress
        ' String + Number + # + space + backspace
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) And (Asc(e.KeyChar) <> 44) And (Asc(e.KeyChar) <> 35) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobile.KeyPress
        ' Number
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub
End Class