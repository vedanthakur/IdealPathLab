Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports IdealPathLab.dbconfig
Imports Org.BouncyCastle.Math.EC.Custom
Imports System.Numerics
Imports System.Reflection

Public Class AddInvoice
    Dim Pmode As String
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            If SaveToolStripButton.Text = "Save" Then
                sql = "INSERT INTO `invoice` values ('" & PName.Text & "','" & Address.Text & "','" & InvoiceNo.Text & "','" & DateTimePicker1.Text & "','" & Test.Text & "','" & P_mode.Text & "','" & Paid.Checked.ToString & "','" & Notes.Text & "','" & Total.Text & "','" & PaidAmount.Text & "');"
            Else
                sql = "UPDATE `invoice` SET `name` ='" & PName.Text & "',`address`='" & Address.Text & "',`invoice_no`='" & InvoiceNo.Text & "',`inoice_date`='" & DateTimePicker1.Text & "',`test`='" & Test.Text & "',`pmode`='" & P_mode.Text & "',`paid`='" & Paid.Checked.ToString & "',`notes`='" & Notes.Text & "',`total` ='" & Total.Text & "',`paid_amount` ='" & PaidAmount.Text & "';"
            End If
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub AddInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadElements("patient")
        If SaveToolStripButton.Text = "Save" Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Sub LoadElements(TableName As String)
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `name` from `" & TableName & "`;"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim Elements = rd.GetString("name")
                PName.Items.Add(Elements)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        InvoiceNo.Text = DateTimePicker1.Text + " " + Date.Now.ToString("hh:mm:ss tt")
    End Sub
End Class