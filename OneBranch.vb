Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig

Public Class OneBranch
    Public branchName As String
    Private Sub OneBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `image`, `status`  from branch where branch_name = '" & branchName & "';"
            con.Open()
            Dim cmd = New MySqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim img() As Byte
            If rd.HasRows() Then
                publishS.Checked = rd("status")
                img = rd("image")
                Dim ms As New MemoryStream(img)
                PictureBox1.Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If

        Catch ex As Exception
            NoImage.Visible = True
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBranch.Show()
        AddBranch.Text = "Edit User"
        AddBranch.SaveToolStripButton.Text = "Update"
        AddBranch.branchName = branchName
        AddBranch.BName.Text = branchName
        AddBranch.BName.Enabled = False
        AddBranch.Timer1.Enabled = True
    End Sub

    Private Sub publishS_CheckedChanged(sender As Object, e As EventArgs) Handles publishS.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "UPDATE `branch` SET `status`='" & publishS.Checked.ToString & "'  WHERE branch_name = '" & branchName & "';"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("'" & UName.Text & "' updated successfully! to '" & publishS.Checked.ToString & "'", "Alert for Publishing  '" & UName.Text & "'", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

End Class