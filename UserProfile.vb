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
    Public publishStatus As String
    Public userWiseData As String
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        userWD.Checked = userWiseData
        publishS.Checked = publishStatus

        Try
            Dim sql As String
            Dim dt As New DataTable
            Dim rd As MySqlDataReader
            sql = "Select `image` from users where email = '" & emailID & "';"
            con.Open()
            Dim cmd = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim img() As Byte
            If rd.HasRows() Then
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
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "UPDATE `users` SET `showUserWiseData`='" & userWD.Checked.ToString & "',`status`='" & publishS.Checked.ToString & "'  WHERE email = '" & emailID & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("User record has been updated successfully!", "Alert for Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been updated!", "Alert for Update User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class