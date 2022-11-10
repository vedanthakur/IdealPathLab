<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSampleCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSampleCollection))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CollectedBy = New System.Windows.Forms.ComboBox()
        Me.PName = New System.Windows.Forms.ComboBox()
        Me.InvoiceNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Notes = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CTime = New System.Windows.Forms.TextBox()
        Me.CollectionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Description = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
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
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(77, 27)
        Me.ToolStrip.TabIndex = 29
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
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(452, 661)
        Me.FlowLayoutPanel2.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CollectedBy)
        Me.GroupBox1.Controls.Add(Me.PName)
        Me.GroupBox1.Controls.Add(Me.InvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 224)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Sample"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(187, 125)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Enter Billing Address"
        Me.Address.Size = New System.Drawing.Size(154, 27)
        Me.Address.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sample Collected By"
        '
        'CollectedBy
        '
        Me.CollectedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CollectedBy.FormattingEnabled = True
        Me.CollectedBy.Location = New System.Drawing.Point(187, 170)
        Me.CollectedBy.Name = "CollectedBy"
        Me.CollectedBy.Size = New System.Drawing.Size(151, 28)
        Me.CollectedBy.TabIndex = 3
        '
        'PName
        '
        Me.PName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PName.FormattingEnabled = True
        Me.PName.Location = New System.Drawing.Point(187, 79)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(151, 28)
        Me.PName.TabIndex = 1
        '
        'InvoiceNo
        '
        Me.InvoiceNo.FormattingEnabled = True
        Me.InvoiceNo.Location = New System.Drawing.Point(187, 33)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.Size = New System.Drawing.Size(151, 28)
        Me.InvoiceNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select invoice no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Billing Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Notes)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CTime)
        Me.GroupBox2.Controls.Add(Me.CollectionDate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.Description)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 233)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 417)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(18, 281)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(394, 110)
        Me.Notes.TabIndex = 9
        Me.Notes.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(18, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Notes:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Set Custom Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CTime
        '
        Me.CTime.Location = New System.Drawing.Point(187, 179)
        Me.CTime.Name = "CTime"
        Me.CTime.Size = New System.Drawing.Size(154, 27)
        Me.CTime.TabIndex = 7
        '
        'CollectionDate
        '
        Me.CollectionDate.CustomFormat = "yyyy-MM-dd"
        Me.CollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CollectionDate.Location = New System.Drawing.Point(187, 131)
        Me.CollectionDate.Name = "CollectionDate"
        Me.CollectionDate.Size = New System.Drawing.Size(154, 27)
        Me.CollectionDate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(18, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Time"
        '
        'Status
        '
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"Collected", "Not collected", "Transferred"})
        Me.Status.Location = New System.Drawing.Point(187, 82)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(151, 28)
        Me.Status.TabIndex = 5
        '
        'Description
        '
        Me.Description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Description.FormattingEnabled = True
        Me.Description.Location = New System.Drawing.Point(187, 33)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(151, 28)
        Me.Description.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(18, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(18, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(18, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Collection Date"
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(452, 661)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(452, 688)
        Me.ToolStripContainer1.TabIndex = 31
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'AddSampleCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 688)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(470, 735)
        Me.MinimumSize = New System.Drawing.Size(470, 735)
        Me.Name = "AddSampleCollection"
        Me.Text = "Add Sample Collection"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
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
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CollectedBy As ComboBox
    Friend WithEvents PName As ComboBox
    Friend WithEvents InvoiceNo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CollectionDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Status As ComboBox
    Friend WithEvents Description As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CTime As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Notes As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
End Class
