﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddLabReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLabReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TSH = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReportedDate = New System.Windows.Forms.DateTimePicker()
        Me.LabNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabTechnicianB = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DoctorB = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TestPerformedBy = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.VerifiedBy = New System.Windows.Forms.CheckedListBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.RichTextBox()
        Me.Delivered = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ImageSizeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(182, 27)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Label1.Size = New System.Drawing.Size(126, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Number*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Label2.Size = New System.Drawing.Size(110, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient Name*"
        '
        'PName
        '
        Me.PName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PName.Location = New System.Drawing.Point(153, 29)
        Me.PName.Name = "PName"
        Me.PName.PlaceholderText = "Enter Name"
        Me.PName.Size = New System.Drawing.Size(182, 27)
        Me.PName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Label3.Size = New System.Drawing.Size(114, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Billing Address"
        '
        'Address
        '
        Me.Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address.Location = New System.Drawing.Point(153, 81)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Enter Address"
        Me.Address.Size = New System.Drawing.Size(182, 27)
        Me.Address.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.TSH)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Location = New System.Drawing.Point(454, 411)
        Me.GroupBox8.MaximumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox8.MinimumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(442, 130)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TSH*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Thyroid Stimulating Hormone (TSH)"
        '
        'TSH
        '
        Me.TSH.Location = New System.Drawing.Point(262, 33)
        Me.TSH.Name = "TSH"
        Me.TSH.PlaceholderText = "Enter TSH"
        Me.TSH.Size = New System.Drawing.Size(151, 27)
        Me.TSH.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.ReportedDate)
        Me.GroupBox7.Controls.Add(Me.LabNo)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 411)
        Me.GroupBox7.MaximumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox7.MinimumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(442, 130)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Reported Date*"
        '
        'ReportedDate
        '
        Me.ReportedDate.CustomFormat = "yyyy-MM-dd"
        Me.ReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReportedDate.Location = New System.Drawing.Point(131, 23)
        Me.ReportedDate.Name = "ReportedDate"
        Me.ReportedDate.Size = New System.Drawing.Size(151, 27)
        Me.ReportedDate.TabIndex = 11
        Me.ReportedDate.Value = New Date(2022, 10, 8, 0, 0, 0, 0)
        '
        'LabNo
        '
        Me.LabNo.Location = New System.Drawing.Point(131, 76)
        Me.LabNo.Name = "LabNo"
        Me.LabNo.PlaceholderText = "Enter Lab no."
        Me.LabNo.Size = New System.Drawing.Size(151, 27)
        Me.LabNo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lab Number"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.LabTechnicianB)
        Me.GroupBox3.Location = New System.Drawing.Point(902, 6)
        Me.GroupBox3.MaximumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lab Technician*"
        '
        'LabTechnicianB
        '
        Me.LabTechnicianB.CheckOnClick = True
        Me.LabTechnicianB.FormattingEnabled = True
        Me.LabTechnicianB.Location = New System.Drawing.Point(6, 26)
        Me.LabTechnicianB.MaximumSize = New System.Drawing.Size(341, 136)
        Me.LabTechnicianB.Name = "LabTechnicianB"
        Me.LabTechnicianB.Size = New System.Drawing.Size(341, 136)
        Me.LabTechnicianB.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.DoctorB)
        Me.GroupBox4.Location = New System.Drawing.Point(454, 6)
        Me.GroupBox4.MaximumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox4.MinimumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Doctor*"
        '
        'DoctorB
        '
        Me.DoctorB.CheckOnClick = True
        Me.DoctorB.FormattingEnabled = True
        Me.DoctorB.Location = New System.Drawing.Point(6, 26)
        Me.DoctorB.MaximumSize = New System.Drawing.Size(341, 136)
        Me.DoctorB.Name = "DoctorB"
        Me.DoctorB.Size = New System.Drawing.Size(341, 136)
        Me.DoctorB.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.TestPerformedBy)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 199)
        Me.GroupBox5.MaximumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox5.MinimumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Test Performed By"
        '
        'TestPerformedBy
        '
        Me.TestPerformedBy.CheckOnClick = True
        Me.TestPerformedBy.FormattingEnabled = True
        Me.TestPerformedBy.Location = New System.Drawing.Point(6, 26)
        Me.TestPerformedBy.MaximumSize = New System.Drawing.Size(341, 136)
        Me.TestPerformedBy.Name = "TestPerformedBy"
        Me.TestPerformedBy.Size = New System.Drawing.Size(341, 136)
        Me.TestPerformedBy.TabIndex = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.VerifiedBy)
        Me.GroupBox6.Location = New System.Drawing.Point(454, 199)
        Me.GroupBox6.MaximumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox6.MinimumSize = New System.Drawing.Size(442, 187)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Verified By"
        '
        'VerifiedBy
        '
        Me.VerifiedBy.CheckOnClick = True
        Me.VerifiedBy.FormattingEnabled = True
        Me.VerifiedBy.Location = New System.Drawing.Point(6, 26)
        Me.VerifiedBy.MaximumSize = New System.Drawing.Size(341, 136)
        Me.VerifiedBy.Name = "VerifiedBy"
        Me.VerifiedBy.Size = New System.Drawing.Size(341, 136)
        Me.VerifiedBy.TabIndex = 4
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox5)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox6)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox9)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox7)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox8)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1377, 561)
        Me.FlowLayoutPanel2.TabIndex = 27
        '
        'GroupBox9
        '
        Me.GroupBox9.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Notes)
        Me.GroupBox9.Controls.Add(Me.Delivered)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Location = New System.Drawing.Point(902, 199)
        Me.GroupBox9.MaximumSize = New System.Drawing.Size(442, 206)
        Me.GroupBox9.MinimumSize = New System.Drawing.Size(442, 206)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(442, 206)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Report Related Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(13, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Notes:"
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(13, 102)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(406, 84)
        Me.Notes.TabIndex = 8
        Me.Notes.Text = ""
        '
        'Delivered
        '
        Me.Delivered.AutoSize = True
        Me.Delivered.BackColor = System.Drawing.Color.Transparent
        Me.Delivered.Location = New System.Drawing.Point(119, 36)
        Me.Delivered.Name = "Delivered"
        Me.Delivered.Size = New System.Drawing.Size(95, 24)
        Me.Delivered.TabIndex = 7
        Me.Delivered.Text = "Delivered"
        Me.Delivered.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Delivery Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.ImageSizeLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(902, 411)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 130)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report file"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Upload Report"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 29)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(310, 21)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 0)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(0, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.SaveAllToolStripMenuItem.Text = "Save all"
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(77, 27)
        Me.ToolStrip.TabIndex = 28
        Me.ToolStrip.Text = "ToolStrip"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(64, 24)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1377, 561)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1377, 588)
        Me.ToolStripContainer1.TabIndex = 29
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'ImageSizeLabel
        '
        Me.ImageSizeLabel.AutoSize = True
        Me.ImageSizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ImageSizeLabel.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ImageSizeLabel.Location = New System.Drawing.Point(100, 94)
        Me.ImageSizeLabel.Name = "ImageSizeLabel"
        Me.ImageSizeLabel.Size = New System.Drawing.Size(204, 15)
        Me.ImageSizeLabel.TabIndex = 43
        Me.ImageSizeLabel.Text = "Image size should be less than 500 KB"
        '
        'AddLabReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1377, 588)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(496, 635)
        Me.Name = "AddLabReport"
        Me.Text = "Add Lab Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabTechnicianB As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabNo As TextBox
    Friend WithEvents TSH As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DoctorB As CheckedListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ReportedDate As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TestPerformedBy As CheckedListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents VerifiedBy As CheckedListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Notes As RichTextBox
    Friend WithEvents Delivered As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ImageSizeLabel As Label
End Class
