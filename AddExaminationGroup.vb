Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports IdealPathLab.dbconfig
Imports MySql.Data.MySqlClient

Public Class AddExaminationGroup
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Dim sql As String
            Dim i As Integer
            con.Open()
            Dim sqlcmd As String
            If SaveToolStripButton.Text = "Save" Then
                sqlcmd = "INSERT INTO `examinationgroup` values ('" & Department.Text & "','" & TitleB.Text & "','" & KeyB.Text & "','" & RankB.Text & "','" & Interpretation.Text & "','" & Specification.Text & "','" & SampleType.Text & "','" & Price.Text & "','" & StatusP.Checked.ToString & "');"
            Else
                sqlcmd = "UPDATE `examinationgroup` SET `examination_group` ='" & Department.Text & "',`examination_sub_group`='" & TitleB.Text & "',`unit`='" & KeyB.Text & "',`title`='" & RankB.Text & "',`its_key`='" & Interpretation.Text & "',`rank`='" & Specification.Text & "',`code`='" & SampleType.Text & "',`report`='" & Price.Text & "',`default_value` ='" & StatusP.Checked.ToString & "' WHERE `title` = '" & TitleB.Text & "';"
            End If
            sql = sqlcmd
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("New record has been inserted successfully!", "Alert for Add Examination Group", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been updated successfully!", "Alert for Update Examination Group", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If SaveToolStripButton.Text = "Save" Then
                    MessageBox.Show("No record has been inserted!", "Alert for Add Examination Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No record has been updated!", "Alert for Update Examination Group", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class