Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Public Class AddReferral
    Private Sub AddReferral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            'sql = "INSERT INTO referral values ('" & ReferralTypeCBox.Text & "', '" & ReferralNameTBox.Text & "','" & RContactPersonTBox.Text & "','" & AddressTBox.Text & "','" & PhoneTBox.Text & "','" & EmailTBox.Text & "','" & SharingPersantageTBox.Text & "');"
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

    Private Sub SharingPersantageTBox_TextChanged(sender As Object, e As EventArgs) Handles SharingPersantageTBox.TextChanged

    End Sub

    Private Sub AddressTBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTBox.TextChanged

    End Sub

    Private Sub PhoneTBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTBox.TextChanged

    End Sub
End Class