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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBranch))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusCkBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContactPersonTBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ImageL = New System.Windows.Forms.Label()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.EmailTBox = New System.Windows.Forms.TextBox()
        Me.AddressTBox = New System.Windows.Forms.TextBox()
        Me.BranchNameTBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PhoneNoTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(464, 27)
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
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 27)
        Me.FlowLayoutPanel2.MinimumSize = New System.Drawing.Size(450, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(464, 538)
        Me.FlowLayoutPanel2.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.StatusCkBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ContactPersonTBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ImageL)
        Me.GroupBox1.Controls.Add(Me.ImageButton)
        Me.GroupBox1.Controls.Add(Me.EmailTBox)
        Me.GroupBox1.Controls.Add(Me.AddressTBox)
        Me.GroupBox1.Controls.Add(Me.BranchNameTBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PhoneNoTBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 454)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Branch"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusCkBox
        '
        Me.StatusCkBox.AutoSize = True
        Me.StatusCkBox.Location = New System.Drawing.Point(140, 327)
        Me.StatusCkBox.Name = "StatusCkBox"
        Me.StatusCkBox.Size = New System.Drawing.Size(78, 24)
        Me.StatusCkBox.TabIndex = 32
        Me.StatusCkBox.Text = "Publish"
        Me.StatusCkBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Status"
        '
        'ContactPersonTBox
        '
        Me.ContactPersonTBox.Location = New System.Drawing.Point(140, 279)
        Me.ContactPersonTBox.Name = "ContactPersonTBox"
        Me.ContactPersonTBox.Size = New System.Drawing.Size(125, 27)
        Me.ContactPersonTBox.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Contact Person"
        '
        'ImageL
        '
        Me.ImageL.AutoSize = True
        Me.ImageL.Location = New System.Drawing.Point(238, 236)
        Me.ImageL.Name = "ImageL"
        Me.ImageL.Size = New System.Drawing.Size(104, 20)
        Me.ImageL.TabIndex = 28
        Me.ImageL.Text = "No file chosen"
        '
        'ImageButton
        '
        Me.ImageButton.Location = New System.Drawing.Point(140, 230)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(94, 29)
        Me.ImageButton.TabIndex = 27
        Me.ImageButton.Text = "Upload"
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'EmailTBox
        '
        Me.EmailTBox.Location = New System.Drawing.Point(140, 177)
        Me.EmailTBox.Name = "EmailTBox"
        Me.EmailTBox.Size = New System.Drawing.Size(125, 27)
        Me.EmailTBox.TabIndex = 26
        '
        'AddressTBox
        '
        Me.AddressTBox.Location = New System.Drawing.Point(140, 86)
        Me.AddressTBox.Name = "AddressTBox"
        Me.AddressTBox.Size = New System.Drawing.Size(125, 27)
        Me.AddressTBox.TabIndex = 25
        '
        'BranchNameTBox
        '
        Me.BranchNameTBox.Location = New System.Drawing.Point(140, 34)
        Me.BranchNameTBox.Name = "BranchNameTBox"
        Me.BranchNameTBox.Size = New System.Drawing.Size(125, 27)
        Me.BranchNameTBox.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email"
        '
        'PhoneNoTBox
        '
        Me.PhoneNoTBox.Location = New System.Drawing.Point(140, 130)
        Me.PhoneNoTBox.Name = "PhoneNoTBox"
        Me.PhoneNoTBox.Size = New System.Drawing.Size(125, 27)
        Me.PhoneNoTBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 133)
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
        Me.Label3.Location = New System.Drawing.Point(18, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'AddBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 565)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddBranch"
        Me.Text = "AddBranch"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusCkBox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactPersonTBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ImageL As Label
    Friend WithEvents ImageButton As Button
    Friend WithEvents EmailTBox As TextBox
    Friend WithEvents AddressTBox As TextBox
    Friend WithEvents BranchNameTBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneNoTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
