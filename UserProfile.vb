Imports System.IO
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class UserProfile
    Public emailID As String
    Public publishStatus As String
    Public userWiseData As String
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        userWD.AutoCheck = True
        publishS.Enabled = publishStatus

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


End Class