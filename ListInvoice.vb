﻿Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient
Public Class ListInvoice
    Private Sub ListInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grid()
    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from `invoice`;"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '
            Dim CIndex As Integer = 0
            Dim Names() As String = {"Name", "Status", "Speciqlization"} 'yet to complete
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
End Class