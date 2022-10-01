Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class AddReferral
    Dim DiscountKeyC As Byte = 0
    Dim StatusC As Byte = 0


    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO referral values ('" & Address.Text & "','" & Phone.Text & "','" & Email.Text & "','" & SharingPersantage.Text & "'," & DiscountKeyC & "," & StatusC & ",'" & Type.Text & "','" & ReferralName.Text & "','" & RContactPerson.Text & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add Referral", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add Referral", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DiscountKey_CheckedChanged(sender As Object, e As EventArgs) Handles DiscountKey.CheckedChanged
        If DiscountKey.Checked Then
            DiscountKeyC = 1
        Else
            DiscountKeyC = 0
        End If
    End Sub

    Private Sub Status_CheckedChanged(sender As Object, e As EventArgs) Handles Status.CheckedChanged
        If Status.Checked Then
            StatusC = 1
        Else
            StatusC = 0
        End If
    End Sub
End Class