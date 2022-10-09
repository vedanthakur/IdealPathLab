<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.welcomeName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DeshboardMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppoinmentMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAppoinmentMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentDataAppoinmentMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferralMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListReferralMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateReferralMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListInvoiceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateInvoiceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleCollectionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListSampleCollectionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateSampleCollectionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabResultMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListLabResultMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateLabResultMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HumanResourceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListHumanResourceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateHumanResourceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListExaminationGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateExaminationGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationSubGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListExaminationSubGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateExaminationSubGroupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListExaminationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateExaminationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBranchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBranchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListUserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentDataMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HumanResTYpeLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferralTYpeLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecializationLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentLabSideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyProfileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.welcomeName})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1355, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripStatusLabel.Text = "Welcome "
        '
        'welcomeName
        '
        Me.welcomeName.Name = "welcomeName"
        Me.welcomeName.Size = New System.Drawing.Size(73, 20)
        Me.welcomeName.Text = "username"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshboardMenu, Me.AppoinmentMenu, Me.ReferralMenu, Me.PatientMenu, Me.InvoiceMenu, Me.SampleCollectionMenu, Me.LabResultMenu, Me.HumanResourceMenu, Me.ServicesMenu, Me.BranchMenu, Me.UserMenu, Me.ParentDataMenu, Me.CompanyProfileMenu, Me.LogoutMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1355, 30)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DeshboardMenu
        '
        Me.DeshboardMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.DeshboardMenu.Name = "DeshboardMenu"
        Me.DeshboardMenu.Size = New System.Drawing.Size(96, 24)
        Me.DeshboardMenu.Text = "&Dashboard"
        '
        'AppoinmentMenu
        '
        Me.AppoinmentMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListAppoinmentMenu, Me.ParentDataAppoinmentMenu})
        Me.AppoinmentMenu.Name = "AppoinmentMenu"
        Me.AppoinmentMenu.Size = New System.Drawing.Size(106, 24)
        Me.AppoinmentMenu.Text = "&Appoinment"
        '
        'ListAppoinmentMenu
        '
        Me.ListAppoinmentMenu.Name = "ListAppoinmentMenu"
        Me.ListAppoinmentMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListAppoinmentMenu.Text = "&List"
        '
        'ParentDataAppoinmentMenu
        '
        Me.ParentDataAppoinmentMenu.Name = "ParentDataAppoinmentMenu"
        Me.ParentDataAppoinmentMenu.Size = New System.Drawing.Size(224, 26)
        Me.ParentDataAppoinmentMenu.Text = "&Parent Data"
        '
        'ReferralMenu
        '
        Me.ReferralMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListReferralMenu, Me.CreateReferralMenu})
        Me.ReferralMenu.Name = "ReferralMenu"
        Me.ReferralMenu.Size = New System.Drawing.Size(75, 24)
        Me.ReferralMenu.Text = "&Referral"
        '
        'ListReferralMenu
        '
        Me.ListReferralMenu.Name = "ListReferralMenu"
        Me.ListReferralMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListReferralMenu.Text = "&List"
        '
        'CreateReferralMenu
        '
        Me.CreateReferralMenu.Name = "CreateReferralMenu"
        Me.CreateReferralMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateReferralMenu.Text = "&Create"
        '
        'PatientMenu
        '
        Me.PatientMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListPatientMenu, Me.CreatePatientMenu})
        Me.PatientMenu.Name = "PatientMenu"
        Me.PatientMenu.Size = New System.Drawing.Size(68, 24)
        Me.PatientMenu.Text = "&Patient"
        '
        'ListPatientMenu
        '
        Me.ListPatientMenu.Name = "ListPatientMenu"
        Me.ListPatientMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListPatientMenu.Text = "&List"
        '
        'CreatePatientMenu
        '
        Me.CreatePatientMenu.Name = "CreatePatientMenu"
        Me.CreatePatientMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreatePatientMenu.Text = "&Create"
        '
        'InvoiceMenu
        '
        Me.InvoiceMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListInvoiceMenu, Me.CreateInvoiceMenu})
        Me.InvoiceMenu.Name = "InvoiceMenu"
        Me.InvoiceMenu.Size = New System.Drawing.Size(70, 24)
        Me.InvoiceMenu.Text = "&Invoice"
        '
        'ListInvoiceMenu
        '
        Me.ListInvoiceMenu.Name = "ListInvoiceMenu"
        Me.ListInvoiceMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListInvoiceMenu.Text = "&List"
        '
        'CreateInvoiceMenu
        '
        Me.CreateInvoiceMenu.Name = "CreateInvoiceMenu"
        Me.CreateInvoiceMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateInvoiceMenu.Text = "&Create"
        '
        'SampleCollectionMenu
        '
        Me.SampleCollectionMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListSampleCollectionMenu, Me.CreateSampleCollectionMenu})
        Me.SampleCollectionMenu.Name = "SampleCollectionMenu"
        Me.SampleCollectionMenu.Size = New System.Drawing.Size(144, 24)
        Me.SampleCollectionMenu.Text = "&Sample Collection"
        '
        'ListSampleCollectionMenu
        '
        Me.ListSampleCollectionMenu.Name = "ListSampleCollectionMenu"
        Me.ListSampleCollectionMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListSampleCollectionMenu.Text = "&List"
        '
        'CreateSampleCollectionMenu
        '
        Me.CreateSampleCollectionMenu.Name = "CreateSampleCollectionMenu"
        Me.CreateSampleCollectionMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateSampleCollectionMenu.Text = "&Create"
        '
        'LabResultMenu
        '
        Me.LabResultMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListLabResultMenu, Me.CreateLabResultMenu})
        Me.LabResultMenu.Name = "LabResultMenu"
        Me.LabResultMenu.Size = New System.Drawing.Size(91, 24)
        Me.LabResultMenu.Text = "&Lab Result"
        '
        'ListLabResultMenu
        '
        Me.ListLabResultMenu.Name = "ListLabResultMenu"
        Me.ListLabResultMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListLabResultMenu.Text = "&List"
        '
        'CreateLabResultMenu
        '
        Me.CreateLabResultMenu.Name = "CreateLabResultMenu"
        Me.CreateLabResultMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateLabResultMenu.Text = "&Create"
        '
        'HumanResourceMenu
        '
        Me.HumanResourceMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListHumanResourceMenu, Me.CreateHumanResourceMenu})
        Me.HumanResourceMenu.Name = "HumanResourceMenu"
        Me.HumanResourceMenu.Size = New System.Drawing.Size(135, 24)
        Me.HumanResourceMenu.Text = "&Human Resource"
        '
        'ListHumanResourceMenu
        '
        Me.ListHumanResourceMenu.Name = "ListHumanResourceMenu"
        Me.ListHumanResourceMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListHumanResourceMenu.Text = "&List"
        '
        'CreateHumanResourceMenu
        '
        Me.CreateHumanResourceMenu.Name = "CreateHumanResourceMenu"
        Me.CreateHumanResourceMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateHumanResourceMenu.Text = "&Create"
        '
        'ServicesMenu
        '
        Me.ServicesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExaminationGroupMenu, Me.ExaminationSubGroupMenu, Me.ExaminationMenu})
        Me.ServicesMenu.Name = "ServicesMenu"
        Me.ServicesMenu.Size = New System.Drawing.Size(76, 24)
        Me.ServicesMenu.Text = "&Services"
        '
        'ExaminationGroupMenu
        '
        Me.ExaminationGroupMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListExaminationGroupMenu, Me.CreateExaminationGroupMenu})
        Me.ExaminationGroupMenu.Name = "ExaminationGroupMenu"
        Me.ExaminationGroupMenu.Size = New System.Drawing.Size(248, 26)
        Me.ExaminationGroupMenu.Text = "Examination &Group"
        '
        'ListExaminationGroupMenu
        '
        Me.ListExaminationGroupMenu.Name = "ListExaminationGroupMenu"
        Me.ListExaminationGroupMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListExaminationGroupMenu.Text = "&List"
        '
        'CreateExaminationGroupMenu
        '
        Me.CreateExaminationGroupMenu.Name = "CreateExaminationGroupMenu"
        Me.CreateExaminationGroupMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateExaminationGroupMenu.Text = "&Create"
        '
        'ExaminationSubGroupMenu
        '
        Me.ExaminationSubGroupMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListExaminationSubGroupMenu, Me.CreateExaminationSubGroupMenu})
        Me.ExaminationSubGroupMenu.Name = "ExaminationSubGroupMenu"
        Me.ExaminationSubGroupMenu.Size = New System.Drawing.Size(248, 26)
        Me.ExaminationSubGroupMenu.Text = "Examination &Sub Group"
        '
        'ListExaminationSubGroupMenu
        '
        Me.ListExaminationSubGroupMenu.Name = "ListExaminationSubGroupMenu"
        Me.ListExaminationSubGroupMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListExaminationSubGroupMenu.Text = "&List"
        '
        'CreateExaminationSubGroupMenu
        '
        Me.CreateExaminationSubGroupMenu.Name = "CreateExaminationSubGroupMenu"
        Me.CreateExaminationSubGroupMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateExaminationSubGroupMenu.Text = "&Create"
        '
        'ExaminationMenu
        '
        Me.ExaminationMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListExaminationMenu, Me.CreateExaminationMenu})
        Me.ExaminationMenu.Name = "ExaminationMenu"
        Me.ExaminationMenu.Size = New System.Drawing.Size(248, 26)
        Me.ExaminationMenu.Text = "&Examination"
        '
        'ListExaminationMenu
        '
        Me.ListExaminationMenu.Name = "ListExaminationMenu"
        Me.ListExaminationMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListExaminationMenu.Text = "&List"
        '
        'CreateExaminationMenu
        '
        Me.CreateExaminationMenu.Name = "CreateExaminationMenu"
        Me.CreateExaminationMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateExaminationMenu.Text = "&Create"
        '
        'BranchMenu
        '
        Me.BranchMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBranchMenu, Me.CreateBranchMenu})
        Me.BranchMenu.Name = "BranchMenu"
        Me.BranchMenu.Size = New System.Drawing.Size(68, 24)
        Me.BranchMenu.Text = "&Branch"
        '
        'ListBranchMenu
        '
        Me.ListBranchMenu.Name = "ListBranchMenu"
        Me.ListBranchMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListBranchMenu.Text = "&List"
        '
        'CreateBranchMenu
        '
        Me.CreateBranchMenu.Name = "CreateBranchMenu"
        Me.CreateBranchMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateBranchMenu.Text = "&Create"
        '
        'UserMenu
        '
        Me.UserMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListUserMenu, Me.CreateUserMenu})
        Me.UserMenu.Name = "UserMenu"
        Me.UserMenu.Size = New System.Drawing.Size(52, 24)
        Me.UserMenu.Text = "&User"
        '
        'ListUserMenu
        '
        Me.ListUserMenu.Name = "ListUserMenu"
        Me.ListUserMenu.Size = New System.Drawing.Size(224, 26)
        Me.ListUserMenu.Text = "&List"
        '
        'CreateUserMenu
        '
        Me.CreateUserMenu.Name = "CreateUserMenu"
        Me.CreateUserMenu.Size = New System.Drawing.Size(224, 26)
        Me.CreateUserMenu.Text = "&Create"
        '
        'ParentDataMenu
        '
        Me.ParentDataMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabSideMenu})
        Me.ParentDataMenu.Name = "ParentDataMenu"
        Me.ParentDataMenu.Size = New System.Drawing.Size(100, 24)
        Me.ParentDataMenu.Text = "&Parent Data"
        '
        'LabSideMenu
        '
        Me.LabSideMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HumanResTYpeLabSideMenu, Me.ReferralTYpeLabSideMenu, Me.SpecializationLabSideMenu, Me.SampleLabSideMenu, Me.UnitLabSideMenu, Me.DepartmentLabSideMenu})
        Me.LabSideMenu.Name = "LabSideMenu"
        Me.LabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.LabSideMenu.Text = "Lab Side"
        '
        'HumanResTYpeLabSideMenu
        '
        Me.HumanResTYpeLabSideMenu.Name = "HumanResTYpeLabSideMenu"
        Me.HumanResTYpeLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.HumanResTYpeLabSideMenu.Text = "&Human Res. Type"
        '
        'ReferralTYpeLabSideMenu
        '
        Me.ReferralTYpeLabSideMenu.Name = "ReferralTYpeLabSideMenu"
        Me.ReferralTYpeLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.ReferralTYpeLabSideMenu.Text = "&Referral Type"
        '
        'SpecializationLabSideMenu
        '
        Me.SpecializationLabSideMenu.Name = "SpecializationLabSideMenu"
        Me.SpecializationLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.SpecializationLabSideMenu.Text = "&Specialization"
        '
        'SampleLabSideMenu
        '
        Me.SampleLabSideMenu.Name = "SampleLabSideMenu"
        Me.SampleLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.SampleLabSideMenu.Text = "&Sample Type"
        '
        'UnitLabSideMenu
        '
        Me.UnitLabSideMenu.Name = "UnitLabSideMenu"
        Me.UnitLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.UnitLabSideMenu.Text = "&Unit"
        '
        'DepartmentLabSideMenu
        '
        Me.DepartmentLabSideMenu.Name = "DepartmentLabSideMenu"
        Me.DepartmentLabSideMenu.Size = New System.Drawing.Size(224, 26)
        Me.DepartmentLabSideMenu.Text = "&Department"
        '
        'CompanyProfileMenu
        '
        Me.CompanyProfileMenu.Name = "CompanyProfileMenu"
        Me.CompanyProfileMenu.Size = New System.Drawing.Size(133, 24)
        Me.CompanyProfileMenu.Text = "&Company Profile"
        '
        'LogoutMenu
        '
        Me.LogoutMenu.Name = "LogoutMenu"
        Me.LogoutMenu.Size = New System.Drawing.Size(74, 24)
        Me.LogoutMenu.Text = "Log &out"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1355, 697)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1302, 744)
        Me.Name = "MDIParent1"
        Me.Text = "Ideal Path Lab"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DeshboardMenu As ToolStripMenuItem
    Friend WithEvents AppoinmentMenu As ToolStripMenuItem
    Friend WithEvents ReferralMenu As ToolStripMenuItem
    Friend WithEvents PatientMenu As ToolStripMenuItem
    Friend WithEvents CreatePatientMenu As ToolStripMenuItem
    Friend WithEvents ListPatientMenu As ToolStripMenuItem
    Friend WithEvents SampleCollectionMenu As ToolStripMenuItem
    Friend WithEvents ListSampleCollectionMenu As ToolStripMenuItem
    Friend WithEvents CreateSampleCollectionMenu As ToolStripMenuItem
    Friend WithEvents LabResultMenu As ToolStripMenuItem
    Friend WithEvents ListLabResultMenu As ToolStripMenuItem
    Friend WithEvents CreateLabResultMenu As ToolStripMenuItem
    Friend WithEvents HumanResourceMenu As ToolStripMenuItem
    Friend WithEvents ListHumanResourceMenu As ToolStripMenuItem
    Friend WithEvents CreateHumanResourceMenu As ToolStripMenuItem
    Friend WithEvents ServicesMenu As ToolStripMenuItem
    Friend WithEvents ExaminationGroupMenu As ToolStripMenuItem
    Friend WithEvents ExaminationSubGroupMenu As ToolStripMenuItem
    Friend WithEvents ExaminationMenu As ToolStripMenuItem
    Friend WithEvents BranchMenu As ToolStripMenuItem
    Friend WithEvents ListBranchMenu As ToolStripMenuItem
    Friend WithEvents CreateBranchMenu As ToolStripMenuItem
    Friend WithEvents UserMenu As ToolStripMenuItem
    Friend WithEvents ListUserMenu As ToolStripMenuItem
    Friend WithEvents CreateUserMenu As ToolStripMenuItem
    Friend WithEvents ParentDataMenu As ToolStripMenuItem
    Friend WithEvents LabSideMenu As ToolStripMenuItem
    Friend WithEvents HumanResTYpeLabSideMenu As ToolStripMenuItem
    Friend WithEvents ReferralTYpeLabSideMenu As ToolStripMenuItem
    Friend WithEvents SpecializationLabSideMenu As ToolStripMenuItem
    Friend WithEvents SampleLabSideMenu As ToolStripMenuItem
    Friend WithEvents UnitLabSideMenu As ToolStripMenuItem
    Friend WithEvents DepartmentLabSideMenu As ToolStripMenuItem
    Friend WithEvents CompanyProfileMenu As ToolStripMenuItem
    Friend WithEvents LogoutMenu As ToolStripMenuItem
    Friend WithEvents ListAppoinmentMenu As ToolStripMenuItem
    Friend WithEvents ParentDataAppoinmentMenu As ToolStripMenuItem
    Friend WithEvents ListReferralMenu As ToolStripMenuItem
    Friend WithEvents CreateReferralMenu As ToolStripMenuItem
    Friend WithEvents welcomeName As ToolStripStatusLabel
    Friend WithEvents InvoiceMenu As ToolStripMenuItem
    Friend WithEvents ListInvoiceMenu As ToolStripMenuItem
    Friend WithEvents CreateInvoiceMenu As ToolStripMenuItem
    Friend WithEvents ListExaminationMenu As ToolStripMenuItem
    Friend WithEvents CreateExaminationMenu As ToolStripMenuItem
    Friend WithEvents ListExaminationGroupMenu As ToolStripMenuItem
    Friend WithEvents CreateExaminationGroupMenu As ToolStripMenuItem
    Friend WithEvents ListExaminationSubGroupMenu As ToolStripMenuItem
    Friend WithEvents CreateExaminationSubGroupMenu As ToolStripMenuItem
End Class
