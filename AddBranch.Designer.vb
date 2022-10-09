<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBranch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBranch))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.status = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContactPerson = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(116, 27)
        Me.ToolStrip.TabIndex = 31
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.MinimumSize = New System.Drawing.Size(450, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(450, 381)
        Me.FlowLayoutPanel2.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ContactPerson)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ImageButton)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Phone)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 374)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Branch"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(321, 195)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 0)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(0, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Checked = True
        Me.status.CheckState = System.Windows.Forms.CheckState.Checked
        Me.status.Location = New System.Drawing.Point(140, 322)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(78, 24)
        Me.status.TabIndex = 32
        Me.status.Text = "Publish"
        Me.status.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Status"
        '
        'ContactPerson
        '
        Me.ContactPerson.Location = New System.Drawing.Point(140, 275)
        Me.ContactPerson.Name = "ContactPerson"
        Me.ContactPerson.PlaceholderText = "Enter Contact name"
        Me.ContactPerson.Size = New System.Drawing.Size(151, 27)
        Me.ContactPerson.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Contact Person"
        '
        'ImageButton
        '
        Me.ImageButton.Location = New System.Drawing.Point(140, 226)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(94, 29)
        Me.ImageButton.TabIndex = 27
        Me.ImageButton.Text = "Upload"
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(140, 179)
        Me.Email.Name = "Email"
        Me.Email.PlaceholderText = "Enter Email"
        Me.Email.Size = New System.Drawing.Size(151, 27)
        Me.Email.TabIndex = 26
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(140, 132)
        Me.Phone.Name = "Phone"
        Me.Phone.PlaceholderText = "Enter Phone No."
        Me.Phone.Size = New System.Drawing.Size(151, 27)
        Me.Phone.TabIndex = 25
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(140, 85)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Enter Address"
        Me.Address.Size = New System.Drawing.Size(151, 27)
        Me.Address.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email"
        '
        'BName
        '
        Me.BName.Location = New System.Drawing.Point(140, 38)
        Me.BName.Name = "BName"
        Me.BName.PlaceholderText = "Enter Branch Name"
        Me.BName.Size = New System.Drawing.Size(151, 27)
        Me.BName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Branch Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(448, 381)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(448, 408)
        Me.ToolStripContainer1.TabIndex = 33
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'Timer1
        '
        '
        'AddBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 408)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(466, 455)
        Me.Name = "AddBranch"
        Me.Text = "Add Branch"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents status As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactPerson As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ImageL As Label
    Friend WithEvents ImageButton As Button
    Friend WithEvents Email As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Timer1 As Timer
End Class
