Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math
Imports System.Data.Entity.Core.Metadata.Edm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class AddAppointment
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO `appointment` values ('" & Name.Text & "','" & Address.Text & "','" & Email.Text & "','" & Phone.Text & "','" & Gender.Text & "','" & DOB.Text & "','" & Department.Text & "','" & Doctor.Text & "','" & AppointmentDate.Text & "','" & PreferredTime.Text & "','" & AppointmentStatus.Text & "','" & Note.Text & "');"
            Else
                sqlcmd = "UPDATE `appointment` SET `name` ='" & Name.Text & "',`address`='" & Address.Text & "',`email`='" & Email.Text & "',`phone`='" & Phone.Text & "',`gender`='" & Gender.Text & "',`dob`='" & DOB.Text & "',`department`='" & Department.Text & "',`doctor`='" & Doctor.Text & "',`appointment_date` ='" & AppointmentDate.Text & "',`preferred_time` ='" & PreferredTime.Text & "',`appointment_status` ='" & AppointmentStatus.Text & "',`note` ='" & Note.Text & "' WHERE `email` = '" & Email.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class