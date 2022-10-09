<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExaminationSubGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExaminationSubGroup))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.KeyB = New System.Windows.Forms.TextBox()
        Me.StatusP = New System.Windows.Forms.CheckBox()
        Me.TitleB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SampleTitle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QRCode = New System.Windows.Forms.TextBox()
        Me.RankB = New System.Windows.Forms.TextBox()
        Me.ExaminationGroup = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.ToolStripSeparator1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(407, 27)
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
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(407, 408)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Price)
        Me.GroupBox1.Controls.Add(Me.KeyB)
        Me.GroupBox1.Controls.Add(Me.StatusP)
        Me.GroupBox1.Controls.Add(Me.TitleB)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.SampleTitle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.QRCode)
        Me.GroupBox1.Controls.Add(Me.RankB)
        Me.GroupBox1.Controls.Add(Me.ExaminationGroup)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 397)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Examination Sub Group"
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(216, 303)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(151, 27)
        Me.Price.TabIndex = 54
        '
        'KeyB
        '
        Me.KeyB.Location = New System.Drawing.Point(216, 124)
        Me.KeyB.Name = "KeyB"
        Me.KeyB.Size = New System.Drawing.Size(151, 27)
        Me.KeyB.TabIndex = 53
        '
        'StatusP
        '
        Me.StatusP.AutoSize = True
        Me.StatusP.Location = New System.Drawing.Point(216, 350)
        Me.StatusP.Name = "StatusP"
        Me.StatusP.Size = New System.Drawing.Size(78, 24)
        Me.StatusP.TabIndex = 53
        Me.StatusP.Text = "Publish"
        Me.StatusP.UseVisualStyleBackColor = True
        '
        'TitleB
        '
        Me.TitleB.Location = New System.Drawing.Point(216, 79)
        Me.TitleB.Name = "TitleB"
        Me.TitleB.Size = New System.Drawing.Size(151, 27)
        Me.TitleB.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Status"
        '
        'SampleTitle
        '
        Me.SampleTitle.FormattingEnabled = True
        Me.SampleTitle.Location = New System.Drawing.Point(216, 214)
        Me.SampleTitle.Name = "SampleTitle"
        Me.SampleTitle.Size = New System.Drawing.Size(151, 28)
        Me.SampleTitle.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Price*"
        '
        'QRCode
        '
        Me.QRCode.Location = New System.Drawing.Point(216, 259)
        Me.QRCode.Name = "QRCode"
        Me.QRCode.Size = New System.Drawing.Size(151, 27)
        Me.QRCode.TabIndex = 50
        '
        'RankB
        '
        Me.RankB.Location = New System.Drawing.Point(216, 169)
        Me.RankB.Name = "RankB"
        Me.RankB.Size = New System.Drawing.Size(151, 27)
        Me.RankB.TabIndex = 39
        '
        'ExaminationGroup
        '
        Me.ExaminationGroup.FormattingEnabled = True
        Me.ExaminationGroup.Location = New System.Drawing.Point(216, 34)
        Me.ExaminationGroup.Name = "ExaminationGroup"
        Me.ExaminationGroup.Size = New System.Drawing.Size(151, 28)
        Me.ExaminationGroup.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "QR Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Sample Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Rank*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Title*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Examination Group*"
        '
        'AddExaminationSubGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 435)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "AddExaminationSubGroup"
        Me.Text = "Add Examination Sub Group"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Price As TextBox
    Friend WithEvents KeyB As TextBox
    Friend WithEvents StatusP As CheckBox
    Friend WithEvents TitleB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SampleTitle As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents QRCode As TextBox
    Friend WithEvents RankB As TextBox
    Friend WithEvents ExaminationGroup As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
