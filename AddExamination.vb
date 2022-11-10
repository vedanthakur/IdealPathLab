Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient


Public Class AddExamination

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO `examination` values ('" & ExaminationGroup.Text & "','" & ExaminationSubGroup.Text & "','" & Unit.Text & "','" & TitleB.Text & "','" & KeyB.Text & "','" & Rank.Text & "','" & CodeB.Text & "','" & ReportB.Text & "','" & DefaultValue.Text & "','" & SampleType.Text & "','" & Price.Text & "','" & Comment.Text & "','" & ValidationOnType.Text & "','" & StatusP.Checked.ToString & "');"
            Else
                sqlcmd = "UPDATE `examination` SET `examination_group` ='" & ExaminationGroup.Text & "',`examination_sub_group`='" & ExaminationSubGroup.Text & "',`unit`='" & Unit.Text & "',`title`='" & TitleB.Text & "',`key_`='" & KeyB.Text & "',`rank`='" & Rank.Text & "',`code`='" & CodeB.Text & "',`report`='" & ReportB.Text & "',`default_value` ='" & DefaultValue.Text & "',`sample_type` ='" & SampleType.Text & "',`price` ='" & Price.Text & "',`comment` ='" & Comment.Text & "',`validation_on_type` ='" & ValidationOnType.Text & "',`status` ='" & StatusP.Checked.ToString & "' WHERE `title` = '" & TitleB.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Examination", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(Me)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Examination", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Examination", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Examination", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TitleB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TitleB.KeyPress
        If (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddExamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadElements("examinationgroup")
        LoadElements("examinationsubgroup")
        LoadElements("unit_type")
        LoadElements("sample_type")
    End Sub

    Sub LoadElements(TableName As String)
        Try
            Dim sql As String
            Dim rd As MySqlDataReader
            sql = "Select `title` from `" & TableName & "`"
            con.Open()
            Dim com = New MySqlCommand(sql, con)
            rd = com.ExecuteReader
            While rd.Read
                Dim Elements = rd.GetString("title")
                If TableName = "examinationgroup" Then
                    ExaminationGroup.Items.Add(Elements)
                ElseIf TableName = "examinationsubgroup" Then
                    ExaminationSubGroup.Items.Add(Elements)
                ElseIf TableName = "unit_type" Then
                    Unit.Items.Add(Elements)
                ElseIf TableName = "sample_type" Then
                    SampleType.Items.Add(Elements)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class

