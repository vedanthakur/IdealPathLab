Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class AddReferral
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO referral values ('" & Address.Text & "','" & Phone.Text & "','" & Email.Text & "','" & SharingPersantage.Text & "'," & DiscountKey.Checked.ToString & "," & Status.Checked.ToString & ",'" & Type.Text & "','" & ReferralName.Text & "','" & RContactPerson.Text & "');"
            Else
                sqlcmd = "UPDATE `referral` SET `address` ='" & Address.Text & "',`phone`='" & Phone.Text & "',`email`='" & Email.Text & "',`benifit`='" & SharingPersantage.Text & "',`discount`='" & DiscountKey.Checked.ToString & "',`status`='" & Status.Checked.ToString & "',`type`='" & Type.Text & "',`contactperson` ='" & RContactPerson.Text & "' WHERE `name` = '" & ReferralName.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Referral", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Referral", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Referral", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Referral", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
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

    Private Sub ReferralName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReferralName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RContactPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RContactPerson.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class