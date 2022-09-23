Public Class AddSampleCollection
    Private Sub AddSampleCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            Button1.Text = "Current Time"
        Else
            Timer1.Enabled = True
            Button1.Text = "Custom Time"
        End If
    End Sub


End Class