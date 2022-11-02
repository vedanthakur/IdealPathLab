<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAppointment))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.Doctor = New System.Windows.Forms.ComboBox()
        Me.AppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.PreferredTime = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AppointmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.ToolStripSeparator1})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(83, 27)
        Me.ToolStrip.TabIndex = 7
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(726, 326)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DOB)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.Phone)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 235)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'DOB
        '
        Me.DOB.CustomFormat = "yyyy-MM-dd"
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOB.Location = New System.Drawing.Point(122, 195)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(151, 27)
        Me.DOB.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Date of Birth"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(122, 162)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(151, 28)
        Me.Gender.TabIndex = 9
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(122, 131)
        Me.Phone.Name = "Phone"
        Me.Phone.PlaceholderText = "Enter Phone"
        Me.Phone.Size = New System.Drawing.Size(151, 27)
        Me.Phone.TabIndex = 8
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(122, 97)
        Me.Email.Name = "Email"
        Me.Email.PlaceholderText = "Enter Email"
        Me.Email.Size = New System.Drawing.Size(151, 27)
        Me.Email.TabIndex = 7
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(122, 63)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Enter Patient Address"
        Me.Address.Size = New System.Drawing.Size(151, 27)
        Me.Address.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(122, 30)
        Me.Name.Name = "Name"
        Me.Name.PlaceholderText = "Enter Patient Name"
        Me.Name.Size = New System.Drawing.Size(151, 27)
        Me.Name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Note)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.AppointmentStatus)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.PreferredTime)
        Me.GroupBox2.Controls.Add(Me.AppointmentDate)
        Me.GroupBox2.Controls.Add(Me.Doctor)
        Me.GroupBox2.Controls.Add(Me.Department)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 308)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Doctor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Department"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(726, 326)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(726, 353)
        Me.ToolStripContainer1.TabIndex = 9
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Appointment Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Preferred Time"
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(188, 30)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(151, 28)
        Me.Department.TabIndex = 4
        '
        'Doctor
        '
        Me.Doctor.FormattingEnabled = True
        Me.Doctor.Location = New System.Drawing.Point(188, 63)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(151, 28)
        Me.Doctor.TabIndex = 5
        '
        'AppointmentDate
        '
        Me.AppointmentDate.CustomFormat = "yyyy-MM-dd"
        Me.AppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AppointmentDate.Location = New System.Drawing.Point(188, 95)
        Me.AppointmentDate.Name = "AppointmentDate"
        Me.AppointmentDate.Size = New System.Drawing.Size(151, 27)
        Me.AppointmentDate.TabIndex = 6
        '
        'PreferredTime
        '
        Me.PreferredTime.FormattingEnabled = True
        Me.PreferredTime.Location = New System.Drawing.Point(188, 131)
        Me.PreferredTime.Name = "PreferredTime"
        Me.PreferredTime.Size = New System.Drawing.Size(151, 28)
        Me.PreferredTime.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Appointment Status"
        '
        'AppointmentStatus
        '
        Me.AppointmentStatus.FormattingEnabled = True
        Me.AppointmentStatus.Location = New System.Drawing.Point(188, 162)
        Me.AppointmentStatus.Name = "AppointmentStatus"
        Me.AppointmentStatus.Size = New System.Drawing.Size(151, 28)
        Me.AppointmentStatus.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Note"
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(65, 195)
        Me.Note.Multiline = True
        Me.Note.Name = "Note"
        Me.Note.PlaceholderText = "Enter Notes"
        Me.Note.Size = New System.Drawing.Size(274, 90)
        Me.Note.TabIndex = 11
        '
        'AddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 353)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "AddAppointment"
        Me.Text = "Add Appointment"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Note As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AppointmentStatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PreferredTime As ComboBox
    Friend WithEvents AppointmentDate As DateTimePicker
    Friend WithEvents Doctor As ComboBox
    Friend WithEvents Department As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
