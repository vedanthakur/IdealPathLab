Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Google.Protobuf.Reflection.FieldDescriptorProto.Types

Public Class AddBranch

    Dim imgpath As String
    Dim arrimage() As Byte
    Public branchName As String
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
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO branch values ('" & BName.Text & "', '" & Address.Text & "'," & Phone.Text & ",'" & Email.Text & "', @img ,'" & ContactPerson.Text & "'," & status.Enabled.ToString & ");"
            Else
                sqlcmd = "UPDATE `branch` SET branch_name ='" & BName.Text & "',`address`='" & Address.Text & "',`phone`='" & Phone.Text & "',`email`='" & Email.Text & "',`image`= @img,`contact`=" & ContactPerson.Text & ",`status`='" & status.Checked.ToString & "' WHERE branch_name = '" & BName.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Branch", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Branch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Branch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select * from branch where branch_name = '" & branchName & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                BName.Text = rd.GetString("branch_name")
                Address.Text = rd.GetString("address")
                Phone.Text = rd.GetString("phone")
                Email.Text = rd.GetString("email")
                ContactPerson.Text = rd.GetString("contact")
                status.Checked = rd.GetString("status")
                If OneBranch.NoImage.Visible = False Then
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