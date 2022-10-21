Imports System.Windows.Forms

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

    Private Sub ToolStripMenuItem8_Click_1(sender As Object, e As EventArgs) Handles HRTypeCreate.Click
        AddTypeHR.MdiParent = Me
        AddTypeHR.Show()
        AddTypeHR.Left = 0
        AddTypeHR.Top = 0
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ReferralTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Referral Type"
        AddType.GroupBox1.Text = "Add Referral Type"
        AddType.TableName = "referral_type"
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles SpecializationTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Specialization Type"
        AddType.GroupBox1.Text = "Add Specialization Type"
        AddType.TableName = "specialization_type"
    End Sub

    Private Sub ToolStripMenuItem14_Click_1(sender As Object, e As EventArgs) Handles DepartmentTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Department Type"
        AddType.GroupBox1.Text = "Add Department Type"
        AddType.TableName = "department_type"
    End Sub

    Private Sub ToolStripMenuItem16_Click_1(sender As Object, e As EventArgs) Handles EducationTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Education"
        AddType.GroupBox1.Text = "Add Education"
        AddType.TableName = "education_type"
    End Sub

    Private Sub ToolStripMenuItem18_Click_1(sender As Object, e As EventArgs) Handles DefaultValueTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Default Value"
        AddType.GroupBox1.Text = "Add Default Value"
        AddType.TableName = "default_value"
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles PaymentTermTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Payment Term"
        AddType.GroupBox1.Text = "Add Payment Term"
        AddType.TableName = "payment_term"
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles SampleTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Sample Type"
        AddType.GroupBox1.Text = "Add Sample Type"
        AddType.TableName = "sample_type"
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles UnitTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Unit"
        AddType.GroupBox1.Text = "Add Unit"
        AddType.TableName = "unit_type"
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles BrandTypeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Brand"
        AddType.GroupBox1.Text = "Add Brand"
        AddType.TableName = "brand_type"
    End Sub

    Private Sub ToolStripMenuItem8_Click_2(sender As Object, e As EventArgs) Handles AppointmentStatusCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Appointment Status"
        AddType.GroupBox1.Text = "Add Appointment Status"
        AddType.TableName = "appointment_status"
    End Sub

    Private Sub PreferTimeCreate_Click(sender As Object, e As EventArgs) Handles PreferTimeCreate.Click
        AddType.MdiParent = Me
        AddType.Show()
        AddType.Left = 0
        AddType.Top = 0
        AddType.Text = "Add Prefer Time"
        AddType.GroupBox1.Text = "Add Prefer Time"
        AddType.TableName = "prefer_time"
    End Sub

    Private Sub HRTypeList_Click(sender As Object, e As EventArgs) Handles HRTypeList.Click
        ListTypeHR.MdiParent = Me
        ListTypeHR.Show()
        ListTypeHR.Left = 0
        ListTypeHR.Top = 0
    End Sub

    Private Sub ReferralTypeList_Click(sender As Object, e As EventArgs) Handles ReferralTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Referral Type"
        ListType.TableName = "referral_type"
    End Sub

    Private Sub SpecializationTypeList_Click(sender As Object, e As EventArgs) Handles SpecializationTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Specialization"
        ListType.TableName = "specialization_type"
    End Sub

    Private Sub DepartmentTypeList_Click(sender As Object, e As EventArgs) Handles DepartmentTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Department"
        ListType.TableName = "department_type"
    End Sub

    Private Sub EducationTypeList_Click(sender As Object, e As EventArgs) Handles EducationTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Education"
        ListType.TableName = "education_type"
    End Sub

    Private Sub DefaultValueTypeList_Click(sender As Object, e As EventArgs) Handles DefaultValueTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Default Value"
        ListType.TableName = "default_value"
    End Sub

    Private Sub PaymentTermList_Click(sender As Object, e As EventArgs) Handles PaymentTermList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Payment Term"
        ListType.TableName = "payment_term"
    End Sub

    Private Sub SampleTypeList_Click(sender As Object, e As EventArgs) Handles SampleTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Sample Type"
        ListType.TableName = "sample_type"
    End Sub

    Private Sub UnitTypeList_Click(sender As Object, e As EventArgs) Handles UnitTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Unit"
        ListType.TableName = "unit_type"
    End Sub

    Private Sub BrandTypeList_Click(sender As Object, e As EventArgs) Handles BrandTypeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Brand"
        ListType.TableName = "brand_type"
    End Sub

    Private Sub AppointmentStatusList_Click(sender As Object, e As EventArgs) Handles AppointmentStatusList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Appointment Status"
        ListType.TableName = "appointment_status"
    End Sub

    Private Sub PreferTimeList_Click(sender As Object, e As EventArgs) Handles PreferTimeList.Click
        ListType.MdiParent = Me
        ListType.Show()
        ListType.Left = 0
        ListType.Top = 0
        ListType.Text = "Prefer Time"
        ListType.TableName = "prefer_time"
    End Sub
End Class
