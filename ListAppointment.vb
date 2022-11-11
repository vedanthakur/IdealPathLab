Imports MySql.Data.MySqlClient

Public Class ListAppointment
    Private Sub ListAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_grid()
    End Sub

    Sub Load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `appointment`;"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Name", "Address", "Email", "Phone", "Gender", "Date of Birth", "Department", "Doctor", "Appointment Date", "Preferred time", "Appointment status", "Note"}
            For Each CName In Names
                DataGridView1.Columns(CIndex).HeaderText = CName
                CIndex += 1
            Next
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        AddAppointment.MdiParent = MDIParent1
        AddAppointment.Left = 0
        AddAppointment.Top = 0
        AddAppointment.Show()
        AddAppointment.SaveToolStripButton.Text = "Update"
        AddAppointment.Text = "Update Appointment"
        AddAppointment.Email.Enabled = False
        AddAppointment.PName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddAppointment.Address.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AddAppointment.Email.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AddAppointment.Phone.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AddAppointment.Gender.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AddAppointment.DOB.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        AddAppointment.Department.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        AddAppointment.Doctor.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        AddAppointment.AppointmentDate.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        AddAppointment.PreferredTime.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        AddAppointment.AppointmentStatus.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        AddAppointment.Note.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
    End Sub
End Class