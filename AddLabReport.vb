﻿Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports Org.BouncyCastle.Crypto
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Org.BouncyCastle.Math.EC.Custom
Imports System.Diagnostics.Metrics
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddLabReport
    Public Doctor, LabTechnician, TestPerformed, Verified As String
    Dim imgpath As String
    Dim arrimage() As Byte
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
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Address.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) And (Asc(e.KeyChar) <> 44) And (Asc(e.KeyChar) <> 35) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub



    Private Sub AddLabReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadElements("Doctor")
        LoadElements("Lab Technician")
        LoadAllElements()
    End Sub

    Sub LoadElements(Cname As String)
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `name` from `users` where `role` = '" & Cname & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim elements = rd.GetString("name")
                If Cname = "Doctor" Then
                    DoctorB.Items.Add(elements)
                Else
                    LabTechnicianB.Items.Add(elements)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub LoadAllElements()
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `name` from `users`"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim elements = rd.GetString("name")
                TestPerformedBy.Items.Add(elements)
                VerifiedBy.Items.Add(elements)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

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
            con.Open()
            CheckBoxSelectedItems()
            If SaveToolStripButton.Text = "Save" Then
                sql = "INSERT INTO `labreport` values ('" & PName.Text & "', '" & Address.Text & "','" & DateTimePicker1.Text & "','" & Doctor & "','" & LabTechnician & "','" & TestPerformed & "','" & Verified & "','" & Delivered.Checked.ToString & "','" & Notes.Text & "','" & ReportedDate.Text & "','" & LabNo.Text & "','" & TSH.Text & "', @img );"
            Else
                sql = "UPDATE `labreport` SET `name`='" & PName.Text & "',`address`='" & Address.Text & "',`doctor`='" & Doctor & "',`lab_technician`='" & LabTechnician & "',`test_preformed_by`='" & TestPerformed & "',`verified_by`='" & Verified & "',`delivery_status`='" & Delivered.Checked.ToString & "',`notes`='" & Notes.Text & "',`reported_date`='" & ReportedDate.Text & "',`lab_no`='" & LabNo.Text & "',`tsh`='" & TSH.Text & "', @img  WHERE `invoice_no` = '" & DateTimePicker1.Text & "';"
            End If
            Dim mysc As New MySqlCommand(sql, con)
            ImageFunction()
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Record has not updated!", "Alert for Update Lab Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
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
        If TryCast(parent, System.Windows.Forms.TextBox) IsNot Nothing Then
            TryCast(parent, System.Windows.Forms.TextBox).Text = [String].Empty
        End If
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
End Class