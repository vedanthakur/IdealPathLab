Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListPatient
    Private Sub ListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub

    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from patient"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        OnePatient.MdiParent = MDIParent1
        OnePatient.Left = 0
        OnePatient.Top = 0
        OnePatient.emailID = DataGridView1.CurrentRow.Cells(9).Value.ToString
        OnePatient.PName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        OnePatient.Gender.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        OnePatient.Age.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        OnePatient.Mobile.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        OnePatient.Address.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        OnePatient.DOB.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        OnePatient.Referral.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        OnePatient.ReferralLab.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        OnePatient.Nationality.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        OnePatient.Email.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        OnePatient.Phone.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        OnePatient.MaritalStatus.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        OnePatient.CPerson.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString
        OnePatient.CPRelation.Text = DataGridView1.CurrentRow.Cells(20).Value.ToString
        OnePatient.CPPhone.Text = DataGridView1.CurrentRow.Cells(21).Value.ToString
        OnePatient.ACountry.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        OnePatient.PassportNo.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        OnePatient.PassportIssuedDate.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        OnePatient.PassportExpired.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
        OnePatient.PassportIssuedDistrict.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
        OnePatient.CitizenshipNo.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString
        OnePatient.Show()
    End Sub
End Class