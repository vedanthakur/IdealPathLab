﻿Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub





    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeshboardMenu.Click
        Dashboard.MdiParent = Me
        Dashboard.Show()
        Dashboard.Top = 0
        Dashboard.Left = 0
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) 
        AddReferral.MdiParent = Me
        AddReferral.Show()
        AddReferral.Top = 0
        AddReferral.Left = 0
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles CreateLabResultMenu.Click
        AddLabReport.MdiParent = Me
        AddLabReport.Show()
        AddLabReport.Top = 0
        AddLabReport.Left = 0
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs)
        AddInvoice.MdiParent = Me
        AddInvoice.Show()
        AddInvoice.Left = 0
        AddInvoice.Top = 0
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles CreateBranchMenu.Click
        AddBranch.MdiParent = Me
        AddBranch.Show()
        AddBranch.Left = 0
        AddBranch.Top = 0
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CreateSampleCollectionMenu.Click
        AddSampleCollection.MdiParent = Me
        AddSampleCollection.Show()
        AddSampleCollection.Left = 0
        AddSampleCollection.Top = 0
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles CreateReferralMenu.Click
        AddReferral.MdiParent = Me
        AddReferral.Show()
        AddReferral.Left = 0
        AddReferral.Top = 0
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles CreateUserMenu.Click
        AddUser.MdiParent = Me
        AddUser.Show()
        AddUser.Left = 0
        AddUser.Top = 0
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles CreateHumanResourceMenu.Click
        AddHumanResource.MdiParent = Me
        AddHumanResource.Show()
        AddHumanResource.Left = 0
        AddHumanResource.Top = 0
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        Me.Hide()
        LoginForm1.Show()

    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles CreatePatientMenu.Click
        AddPatient.MdiParent = Me
        AddPatient.Show()
        AddPatient.Left = 0
        AddPatient.Top = 0
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateInvoiceMenu.Click
        AddInvoice.MdiParent = Me
        AddInvoice.Show()
        AddInvoice.Left = 0
        AddInvoice.Top = 0
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ListUserMenu.Click
        ListUser.MdiParent = Me
        ListUser.Show()
        ListUser.Left = 0
        ListUser.Top = 0
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ListBranchMenu.Click
        ListBranch.MdiParent = Me
        ListBranch.Show()
        ListBranch.Left = 0
        ListBranch.Top = 0
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ListHumanResourceMenu.Click
        ListHumanResource.MdiParent = Me
        ListHumanResource.Show()
        ListHumanResource.Left = 0
        ListHumanResource.Top = 0
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ListReferralMenu.Click
        ListReferral.MdiParent = Me
        ListReferral.Show()
        ListReferral.Left = 0
        ListReferral.Top = 0
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPatientMenu.Click
        ListPatient.MdiParent = Me
        ListPatient.Show()
        ListPatient.Left = 0
        ListPatient.Top = 0
    End Sub

    Private Sub ListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListInvoiceMenu.Click
        ListInvoice.MdiParent = Me
        ListInvoice.Show()
        ListInvoice.Left = 0
        ListInvoice.Top = 0
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListSampleCollectionMenu.Click
        ListSampleCollection.MdiParent = Me
        ListSampleCollection.Show()
        ListSampleCollection.Left = 0
        ListSampleCollection.Top = 0
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ListLabResultMenu.Click
        ListLabResult.MdiParent = Me
        ListLabResult.Show()
        ListLabResult.Left = 0
        ListLabResult.Top = 0
    End Sub

    Private Sub ConFigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyProfileMenu.Click
        CompanyProfile.MdiParent = Me
        CompanyProfile.Show()
        CompanyProfile.Left = 0
        CompanyProfile.Top = 0
    End Sub

    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateExaminationMenu.Click
        AddExamination.MdiParent = Me
        AddExamination.Show()
        AddExamination.Left = 0
        AddExamination.Top = 0
    End Sub

    Private Sub ListToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListExaminationMenu.Click
        ListExamination.MdiParent = Me
        ListExamination.Show()
        ListExamination.Left = 0
        ListExamination.Top = 0
    End Sub

    Private Sub CreateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateExaminationSubGroupMenu.Click
        AddExaminationSubGroup.MdiParent = Me
        AddExaminationSubGroup.Show()
        AddExaminationSubGroup.Left = 0
        AddExaminationSubGroup.Top = 0
    End Sub

    Private Sub CreateToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CreateExaminationGroupMenu.Click
        AddExaminationGroup.MdiParent = Me
        AddExaminationGroup.Show()
        AddExaminationGroup.Left = 0
        AddExaminationGroup.Top = 0
    End Sub

    Private Sub ListToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ListExaminationGroupMenu.Click
        ListExaminationGroup.MdiParent = Me
        ListExaminationGroup.Show()
        ListExaminationGroup.Left = 0
        ListExaminationGroup.Top = 0
    End Sub

    Private Sub ListToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ListExaminationSubGroupMenu.Click
        ListExaminationSubGroup.MdiParent = Me
        ListExaminationSubGroup.Show()
        ListExaminationSubGroup.Left = 0
        ListExaminationSubGroup.Top = 0
    End Sub

    Private Sub ToolStripMenuItem8_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        AddTypeHR.MdiParent = Me
        AddTypeHR.Show()
        AddTypeHR.Left = 0
        AddTypeHR.Top = 0
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        AddTypeReferral.MdiParent = Me
        AddTypeReferral.Show()
        AddTypeReferral.Left = 0
        AddTypeReferral.Top = 0
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        AddTypeSpecialization.MdiParent = Me
        AddTypeSpecialization.Show()
        AddTypeSpecialization.Left = 0
        AddTypeSpecialization.Top = 0
    End Sub

    Private Sub ToolStripMenuItem14_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        AddTypeDepartment.MdiParent = Me
        AddTypeDepartment.Show()
        AddTypeDepartment.Left = 0
        AddTypeDepartment.Top = 0
    End Sub

    Private Sub ToolStripMenuItem16_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        AddTypeEducation.MdiParent = Me
        AddTypeEducation.Show()
        AddTypeEducation.Left = 0
        AddTypeEducation.Top = 0
    End Sub

    Private Sub ToolStripMenuItem18_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        AddTypeDefaultValue.MdiParent = Me
        AddTypeDefaultValue.Show()
        AddTypeDefaultValue.Left = 0
        AddTypeDefaultValue.Top = 0
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        AddTypePaymentTerm.MdiParent = Me
        AddTypePaymentTerm.Show()
        AddTypePaymentTerm.Left = 0
        AddTypePaymentTerm.Top = 0
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        AddTypeSample.MdiParent = Me
        AddTypeSample.Show()
        AddTypeSample.Left = 0
        AddTypeSample.Top = 0
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        AddTypeUnit.MdiParent = Me
        AddTypeUnit.Show()
        AddTypeUnit.Left = 0
        AddTypeUnit.Top = 0
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        AddTypeBrand.MdiParent = Me
        AddTypeBrand.Show()
        AddTypeBrand.Left = 0
        AddTypeBrand.Top = 0
    End Sub
End Class
