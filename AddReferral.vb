Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddReferral
    Private Sub AddReferral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO referral values ('" & ReferralTypeCBox.Text & "', '" & ReferralNameTBox.Text & "','" & RContactPersonTBox.Text & "','" & AddressTBox.Text & "','" & PhoneTBox.Text & "','" & EmailTBox.Text & "','" & SharingPersantageTBox.Text & "');"
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New record has been inserted successfully!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record has been inserted!", "Alert for Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class