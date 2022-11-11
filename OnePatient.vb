Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Security.Policy
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient

Public Class OnePatient
    Public emailID As String

    Private Sub OnePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `image` from patient where email = '" & emailID & "';"
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
            con.Close()
        Catch ex As Exception
            NoImage.Visible = True
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddPatient.MdiParent = MDIParent1
        AddPatient.Left = 0
        AddPatient.Top = 0
        AddPatient.Show()
        AddPatient.Text = "Edit Patient"
        AddPatient.SaveToolStripButton.Text = "Update"
        AddPatient.emailID = emailID
        AddPatient.Email.Text = emailID
        AddPatient.Email.Enabled = False
        AddPatient.Timer1.Enabled = True
    End Sub
End Class