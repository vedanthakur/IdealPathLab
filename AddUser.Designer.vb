<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImageSizeLabel = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.userB = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.humanResource = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.branch = New System.Windows.Forms.ComboBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.role = New System.Windows.Forms.ComboBox()
        Me.imgUpload = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.nameL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.MinimumSize = New System.Drawing.Size(450, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(450, 582)
        Me.FlowLayoutPanel2.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.ImageSizeLabel)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.userB)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.humanResource)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.branch)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.role)
        Me.GroupBox1.Controls.Add(Me.imgUpload)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.mobile)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.nameL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 574)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create User"
        '
        'ImageSizeLabel
        '
        Me.ImageSizeLabel.AutoSize = True
        Me.ImageSizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ImageSizeLabel.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ImageSizeLabel.Location = New System.Drawing.Point(18, 502)
        Me.ImageSizeLabel.Name = "ImageSizeLabel"
        Me.ImageSizeLabel.Size = New System.Drawing.Size(204, 15)
        Me.ImageSizeLabel.TabIndex = 43
        Me.ImageSizeLabel.Text = "Image size should be less than 500 KB"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.BackColor = System.Drawing.Color.Transparent
        Me.status.Checked = True
        Me.status.CheckState = System.Windows.Forms.CheckState.Checked
        Me.status.Location = New System.Drawing.Point(176, 529)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(78, 24)
        Me.status.TabIndex = 10
        Me.status.Text = "Publish"
        Me.status.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(16, 531)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Status"
        '
        'userB
        '
        Me.userB.AutoSize = True
        Me.userB.BackColor = System.Drawing.Color.Transparent
        Me.userB.Checked = True
        Me.userB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.userB.Location = New System.Drawing.Point(192, 427)
        Me.userB.Name = "userB"
        Me.userB.Size = New System.Drawing.Size(52, 24)
        Me.userB.TabIndex = 8
        Me.userB.Text = "Yes"
        Me.userB.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(16, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Show User Wise Data*"
        '
        'humanResource
        '
        Me.humanResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.humanResource.FormattingEnabled = True
        Me.humanResource.Location = New System.Drawing.Point(144, 377)
        Me.humanResource.Name = "humanResource"
        Me.humanResource.Size = New System.Drawing.Size(152, 28)
        Me.humanResource.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(16, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Human Resource"
        '
        'branch
        '
        Me.branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branch.FormattingEnabled = True
        Me.branch.Location = New System.Drawing.Point(144, 327)
        Me.branch.Name = "branch"
        Me.branch.Size = New System.Drawing.Size(152, 28)
        Me.branch.TabIndex = 6
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(144, 278)
        Me.password.Name = "password"
        Me.password.PlaceholderText = "Enter Password"
        Me.password.Size = New System.Drawing.Size(152, 27)
        Me.password.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(16, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Password*"
        '
        'role
        '
        Me.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.role.Items.AddRange(New Object() {"Doctor", "Lab Technician", "Human Resource", "Director", "Account"})
        Me.role.Location = New System.Drawing.Point(144, 81)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(152, 28)
        Me.role.TabIndex = 1
        '
        'imgUpload
        '
        Me.imgUpload.Location = New System.Drawing.Point(168, 469)
        Me.imgUpload.Name = "imgUpload"
        Me.imgUpload.Size = New System.Drawing.Size(96, 31)
        Me.imgUpload.TabIndex = 9
        Me.imgUpload.Text = "Upload"
        Me.imgUpload.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 480)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Image*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(16, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Branch"
        '
        'mobile
        '
        Me.mobile.Location = New System.Drawing.Point(144, 229)
        Me.mobile.Name = "mobile"
        Me.mobile.PlaceholderText = "Enter Mobile"
        Me.mobile.Size = New System.Drawing.Size(152, 27)
        Me.mobile.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(16, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Mobile*"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(144, 180)
        Me.address.Name = "address"
        Me.address.PlaceholderText = "Enter Address"
        Me.address.Size = New System.Drawing.Size(152, 27)
        Me.address.TabIndex = 3
        '
        'nameL
        '
        Me.nameL.Location = New System.Drawing.Point(144, 32)
        Me.nameL.Name = "nameL"
        Me.nameL.PlaceholderText = "Enter Name"
        Me.nameL.Size = New System.Drawing.Size(152, 27)
        Me.nameL.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Address"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(144, 131)
        Me.email.Name = "email"
        Me.email.PlaceholderText = "Enter Email"
        Me.email.Size = New System.Drawing.Size(152, 27)
        Me.email.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Role*"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(286, 433)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 0)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(0, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(77, 27)
        Me.ToolStrip.TabIndex = 33
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
        'Timer1
        '
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(448, 582)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(448, 609)
        Me.ToolStripContainer1.TabIndex = 35
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 609)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MaximumSize = New System.Drawing.Size(466, 656)
        Me.MinimumSize = New System.Drawing.Size(466, 656)
        Me.Name = "AddUser"
        Me.Text = "Add User"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents roll As ComboBox
    Friend WithEvents imgUpload As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mobile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents nameL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents status As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents userB As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents humanResource As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents branch As ComboBox
    Friend WithEvents password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageSizeLabel As Label
    Public WithEvents Timer1 As Timer
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents role As ComboBox
End Class