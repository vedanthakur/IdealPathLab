Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig

Public Class OneHumanResource
    Public emailID As String
    Private Sub OneHumanResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select * from hr where email = '" & emailID & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                UName.Text = rd.GetString("name")
                ContactDetails.Text = rd.GetString("address") & " | " & rd.GetString("email") & " | " & rd.GetString("phone")
                Type.Text = rd.GetString("crn") & " | " & rd.GetString("rank")
                Speciqlization.Text = rd.GetString("type") & " | " & rd.GetString("position") & " | " & rd.GetString("speciqlization")
                Facebook.Links.Add(6, 4, rd.GetString("facebook"))
                Twitter.Text = rd.GetString("twitter")
                Instagram.Text = rd.GetString("instagram")
                YouTube.Text = rd.GetString("youtube")
                userWD.Checked = rd.GetString("su")
                publishS.Checked = rd.GetString("status")
                Try
                    Dim img() As Byte
                    img = rd("image")
                    Dim ms As New MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    NoImage.Visible = True
                End Try
                Try
                    Dim img2() As Byte
                    img2 = rd("signature")
                    Dim ms2 As New MemoryStream(img2)
                    PictureBox2.Image = Image.FromStream(ms2)
                    PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    NoImage2.Visible = True
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddHumanResource.Show()
        AddHumanResource.Text = "Edit Human Resource"
        AddHumanResource.SaveToolStripButton.Text = "Update"
        AddHumanResource.emailID = emailID
        AddHumanResource.Email.Text = emailID
        AddHumanResource.Email.Enabled = False
        AddHumanResource.Timer1.Enabled = True
    End Sub

    Private Sub userWD_CheckedChanged(sender As Object, e As EventArgs) Handles userWD.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "UPDATE `hr` SET `su`='" & userWD.Checked.ToString & "'  WHERE email = '" & emailID & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("'" & UName.Text & "' updated successfully! to '" & userWD.Checked.ToString & "'", "Alert for User Wise Data " & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been updated!", "Alert for User Wise Data'" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
            sql = "UPDATE `hr` SET `status`='" & publishS.Checked.ToString & "'  WHERE email = '" & emailID & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("'" & UName.Text & "' updated successfully! to '" & publishS.Checked.ToString & "'", "Alert for Publishing  '" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been updated!", "Alert for Publish'" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class