Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports Org.BouncyCastle.Crypto

Public Class AddLabReport
    Public Doctor, LabTechnician, TestPerformed, Verified As String
    Dim imgpath As String
    Private Sub CheckBoxSelectedItems()
        Doctor = ""
        For j = 0 To DoctorB.Items.Count - 1
            If DoctorB.GetItemChecked(j) Then
                Doctor = Doctor & "," & DoctorB.Items.Item(j)
            End If
        Next
        LabTechnician = ""
        For k = 0 To LabTechnicianB.Items.Count - 1
            If LabTechnicianB.GetItemChecked(k) Then
                LabTechnician = LabTechnician & "," & LabTechnicianB.Items.Item(k)
            End If
        Next
        TestPerformed = ""
        For k = 0 To TestPerformedBy.Items.Count - 1
            If TestPerformedBy.GetItemChecked(k) Then
                TestPerformed = TestPerformed & "," & TestPerformedBy.Items.Item(k)
            End If
        Next
        Verified = ""
        For k = 0 To VerifiedBy.Items.Count - 1
            If VerifiedBy.GetItemChecked(k) Then
                Verified = Verified & "," & VerifiedBy.Items.Item(k)
            End If
        Next
    End Sub

    Private Sub PName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Address.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                e.Handled = True
            End If
        End If
    End Sub

    Dim arrimage() As Byte

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

            Dim memstr As New MemoryStream()
            PictureBox1.Image.Save(memstr, Imaging.ImageFormat.Jpeg)
            arrimage = memstr.GetBuffer()
            Dim filesize As UInt32
            filesize = memstr.Length
            memstr.Close()
            con.Open()
            CheckBoxSelectedItems()
            sql = "INSERT INTO `labreport` values ('" & PName.Text & "', '" & Address.Text & "','" & DateTimePicker1.Text & "','" & Doctor & "','" & LabTechnician & "','" & TestPerformed & "','" & Verified & "','" & Delivered.Checked.ToString & "','" & Notes.Text & "','" & ReportedDate.Text & "','" & LabNo.Text & "','" & TSH.Text & "', @img );"
            Dim mysc As New MySqlCommand(sql, con)
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class