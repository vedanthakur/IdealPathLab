Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports IdealPathLab.dbconfig
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class UserProfile
    Public emailID As String
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `image`, `showUserWiseData`, `status`  from users where email = '" & emailID & "';"
            con.Open()
            Dim cmd = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim img() As Byte
            If rd.HasRows() Then
                userWD.Checked = rd("showUserWiseData")
                publishS.Checked = rd("status")
                img = rd("image")
                Dim ms As New MemoryStream(img)
                PictureBox1.Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddUser.Show()
        AddUser.Mode = True
        AddUser.Text = "Edit User"
        AddUser.SaveToolStripButton.Text = "Update"
        AddUser.emailID = emailID
        AddUser.email.Text = emailID
        AddUser.email.Enabled = False
        AddUser.Timer1.Enabled = True
    End Sub

    Private Sub userWD_CheckedChanged(sender As Object, e As EventArgs) Handles userWD.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "UPDATE `users` SET `showUserWiseData`='" & userWD.Checked.ToString & "'  WHERE email = '" & emailID & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("'" & UName.Text & "' User Wise Data updated successfully! to '" & userWD.Checked.ToString & "'", "Alert for Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been updated!", "Alert for show User Wise Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub publishS_CheckedChanged(sender As Object, e As EventArgs) Handles publishS.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "UPDATE `users` SET `status`='" & publishS.Checked.ToString & "'  WHERE email = '" & emailID & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("'" & UName.Text & "' Published updated successfully! to '" & publishS.Checked.ToString & "'", "Alert for Publishing  '" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been updated!", "Alert for Publish'" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UserProfile_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ListUser.Close()
        ListUser.MdiParent = MDIParent1
        ListUser.Show()
        ListUser.Left = 0
        ListUser.Top = 0
    End Sub
End Class