Imports Org.BouncyCastle.Crypto
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Numerics
Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports System.Data.Entity.Core.Metadata.Edm

Public Class AddPatient
    Dim imgpath As String
    Dim arrimage() As Byte
    Public emailID As String
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            If SaveToolStripButton.Text = "Save" Then
                sql = "INSERT INTO patient values ('" & PName.Text & "', '" & Gender.Text & "','" & Address.Text & "','" & Mobile.Text & "','" & DOB.Text & "','" & Age.Text & "','" & Referral.Text & "','" & RLab.Text & "','" & Nationality.Text & "','" & Email.Text & "','" & Phone.Text & "','" & MaritalStatus.Text & "', @img ,'" & Country.Text & "','" & PassportNo.Text & "','" & PassportIssuedDate.Text & "','" & PassportExpiredDate.Text & "','" & PIssuedDistrict.Text & "','" & CitizenshipNo.Text & "','" & CPerson.Text & "','" & CPRelation.Text & "','" & CPPhone.Text & "' );"
            Else
                sql = "UPDATE `patient` SET `name`='" & PName.Text & "',`gender`='" & Gender.Text & "',`address`='" & Address.Text & "',`mobile`='" & Mobile.Text & "',`dob`='" & DOB.Text & "',`age`='" & Age.Text & "',`referral`='" & Referral.Text & "',`referral_lab`='" & RLab.Text & "',`nationality`='" & Nationality.Text & "',`email`='" & Email.Text & "',`phone`='" & Phone.Text & "',`marital_status`='" & MaritalStatus.Text & "',`image`= @img,`country`='" & Country.Text & "',`passportno`='" & PassportNo.Text & "',`passportissue`='" & PassportIssuedDate.Text & "',`passportexpired`='" & PassportExpiredDate.Text & "',`pidistrict`='" & PIssuedDistrict.Text & "',`citizenshipno`='" & CitizenshipNo.Text & "',`cperson`='" & CPerson.Text & "',`cprelation`='" & CPRelation.Text & "',`cpphone`='" & CPPhone.Text & "' WHERE email = '" & Email.Text & "';"
            End If
            Dim mysc As New MySqlCommand(sql, con)
            ImageFunction()
            mysc.Parameters.AddWithValue("@img", arrimage)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "Image file|*.jpg;*.png;*.gif;*.bmp"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgpath = openfiledialog1.FileName
            PictureBox1.ImageLocation = imgpath
        End If
    End Sub

    Private Sub DOB_ValueChanged(sender As Object, e As EventArgs) Handles DOB.ValueChanged
        Age.Text = 2022 - DOB.Value.Year
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
            sql = "Select * from patient where email = '" & emailID & "';"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                PName.Text = rd.GetString("name")
                Gender.Text = rd.GetString("gender")
                Address.Text = rd.GetString("address")
                Mobile.Text = rd.GetString("mobile")
                DOB.Value = rd.GetString("dob")
                Age.Text = rd.GetString("age")
                Referral.Text = rd.GetString("referral")
                RLab.Text = rd.GetString("referral_lab")
                Nationality.Text = rd.GetString("nationality")
                Email.Text = rd.GetString("email")
                Phone.Text = rd.GetString("phone")
                MaritalStatus.Text = rd.GetString("marital_status")
                Country.Text = rd.GetString("country")
                PassportNo.Text = rd.GetString("passportno")
                PassportIssuedDate.Value = rd.GetString("passportissue")
                PassportExpiredDate.Value = rd.GetString("passportexpired")
                PIssuedDistrict.Text = rd.GetString("pidistrict")
                CitizenshipNo.Text = rd.GetString("citizenshipno")
                CPerson.Text = rd.GetString("cperson")
                CPRelation.Text = rd.GetString("cprelation")
                CPPhone.Text = rd.GetString("cpphone")
                If OnePatient.NoImage.Visible = False Then
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

    Private Sub Mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Mobile.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PassportNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PassportNo.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CPPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CPPhone.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Age.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CitizenshipNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CitizenshipNo.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
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

    Private Sub CPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CPerson.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CPRelation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CPRelation.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadElements("referral")
    End Sub

    Sub LoadElements(TableName As String)
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `contactperson`, `name` from `" & TableName & "`"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim Elements = rd.GetString("contactperson")
                Referral.Items.Add(Elements)
                Dim Elements2 = rd.GetString("name")
                RLab.Items.Add(Elements2)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class