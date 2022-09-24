<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReferral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddReferral))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountKeyCkBox = New System.Windows.Forms.CheckBox()
        Me.StatusCkBox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AddressTBox = New System.Windows.Forms.TextBox()
        Me.PhoneTBox = New System.Windows.Forms.TextBox()
        Me.SharingPersantageTBox = New System.Windows.Forms.TextBox()
        Me.EmailTBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReferralNameTBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RContactPersonTBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountKeyCkBox)
        Me.GroupBox2.Controls.Add(Me.StatusCkBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.AddressTBox)
        Me.GroupBox2.Controls.Add(Me.PhoneTBox)
        Me.GroupBox2.Controls.Add(Me.SharingPersantageTBox)
        Me.GroupBox2.Controls.Add(Me.EmailTBox)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 311)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'DiscountKeyCkBox
        '
        Me.DiscountKeyCkBox.AutoSize = True
        Me.DiscountKeyCkBox.Location = New System.Drawing.Point(220, 229)
        Me.DiscountKeyCkBox.Name = "DiscountKeyCkBox"
        Me.DiscountKeyCkBox.Size = New System.Drawing.Size(52, 24)
        Me.DiscountKeyCkBox.TabIndex = 8
        Me.DiscountKeyCkBox.Text = "Yes"
        Me.DiscountKeyCkBox.UseVisualStyleBackColor = True
        '
        'StatusCkBox
        '
        Me.StatusCkBox.AutoSize = True
        Me.StatusCkBox.Location = New System.Drawing.Point(220, 273)
        Me.StatusCkBox.Name = "StatusCkBox"
        Me.StatusCkBox.Size = New System.Drawing.Size(78, 24)
        Me.StatusCkBox.TabIndex = 9
        Me.StatusCkBox.Text = "Publish"
        Me.StatusCkBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Benifit sharing percentage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Discount Apply Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Status"
        '
        'AddressTBox
        '
        Me.AddressTBox.Location = New System.Drawing.Point(220, 41)
        Me.AddressTBox.Name = "AddressTBox"
        Me.AddressTBox.PlaceholderText = "Enter Address"
        Me.AddressTBox.Size = New System.Drawing.Size(151, 27)
        Me.AddressTBox.TabIndex = 3
        '
        'PhoneTBox
        '
        Me.PhoneTBox.Location = New System.Drawing.Point(220, 88)
        Me.PhoneTBox.Name = "PhoneTBox"
        Me.PhoneTBox.PlaceholderText = "Enter Phone no."
        Me.PhoneTBox.Size = New System.Drawing.Size(151, 27)
        Me.PhoneTBox.TabIndex = 4
        '
        'SharingPersantageTBox
        '
        Me.SharingPersantageTBox.Location = New System.Drawing.Point(220, 182)
        Me.SharingPersantageTBox.Name = "SharingPersantageTBox"
        Me.SharingPersantageTBox.PlaceholderText = "Enter Benifit sharing"
        Me.SharingPersantageTBox.Size = New System.Drawing.Size(151, 27)
        Me.SharingPersantageTBox.TabIndex = 6
        '
        'EmailTBox
        '
        Me.EmailTBox.Location = New System.Drawing.Point(220, 135)
        Me.EmailTBox.Name = "EmailTBox"
        Me.EmailTBox.PlaceholderText = "Enter email address"
        Me.EmailTBox.Size = New System.Drawing.Size(151, 27)
        Me.EmailTBox.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ReferralNameTBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RContactPersonTBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 179)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referral Basic Information"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(220, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.Text = "Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label1.Size = New System.Drawing.Size(102, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referral Type*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label2.Size = New System.Drawing.Size(111, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Referral Name*"
        '
        'ReferralNameTBox
        '
        Me.ReferralNameTBox.Location = New System.Drawing.Point(220, 83)
        Me.ReferralNameTBox.Name = "ReferralNameTBox"
        Me.ReferralNameTBox.PlaceholderText = "Enter Ref. Name"
        Me.ReferralNameTBox.Size = New System.Drawing.Size(151, 27)
        Me.ReferralNameTBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label3.Size = New System.Drawing.Size(163, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Referral Contact Person"
        '
        'RContactPersonTBox
        '
        Me.RContactPersonTBox.Location = New System.Drawing.Point(220, 128)
        Me.RContactPersonTBox.Name = "RContactPersonTBox"
        Me.RContactPersonTBox.PlaceholderText = "Enter Ref. Person"
        Me.RContactPersonTBox.Size = New System.Drawing.Size(151, 27)
        Me.RContactPersonTBox.TabIndex = 12
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(410, 27)
        Me.ToolStrip.TabIndex = 34
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(410, 500)
        Me.FlowLayoutPanel1.TabIndex = 35
        '
        'AddReferral
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(410, 527)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(428, 574)
        Me.Name = "AddReferral"
        Me.Text = "Add Referral"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AddressTBox As TextBox
    Friend WithEvents PhoneTBox As TextBox
    Friend WithEvents SharingPersantageTBox As TextBox
    Friend WithEvents EmailTBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReferralNameTBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RContactPersonTBox As TextBox
    Friend WithEvents DiscountKeyCkBox As CheckBox
    Friend WithEvents StatusCkBox As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
