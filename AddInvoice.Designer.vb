<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddInvoice))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Test = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PaidAmount = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.RichTextBox()
        Me.Paid = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.P_mode = New System.Windows.Forms.ComboBox()
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
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(258, 27)
        Me.ToolStrip.TabIndex = 30
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
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(63, 24)
        Me.PrintToolStripButton.Text = "Print"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(118, 24)
        Me.PrintPreviewToolStripButton.Text = "Print Preview"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(926, 426)
        Me.FlowLayoutPanel2.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackgroundImage = Global.IdealPathLab.My.Resources.Resources.bg_blur
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Test)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.InvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 280)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Invoice"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(140, 85)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Ente Address"
        Me.Address.Size = New System.Drawing.Size(151, 27)
        Me.Address.TabIndex = 1
        '
        'Test
        '
        Me.Test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Test.FormattingEnabled = True
        Me.Test.Items.AddRange(New Object() {"serum tests", "Imaging scans", "Biopsy samples"})
        Me.Test.Location = New System.Drawing.Point(140, 226)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(151, 28)
        Me.Test.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(18, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Choose Test"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 177)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 27)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Invoice Date*"
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Enabled = False
        Me.InvoiceNo.Location = New System.Drawing.Point(140, 131)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.PlaceholderText = "Enter Invoice No."
        Me.InvoiceNo.Size = New System.Drawing.Size(151, 27)
        Me.InvoiceNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Invoice Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Patient Name*"
        '
        'PName
        '
        Me.PName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PName.FormattingEnabled = True
        Me.PName.Location = New System.Drawing.Point(140, 38)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(151, 28)
        Me.PName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 88)
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
        Me.GroupBox2.Controls.Add(Me.P_mode)
        Me.GroupBox2.Controls.Add(Me.PaidAmount)
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Notes)
        Me.GroupBox2.Controls.Add(Me.Paid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(454, 6)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 387)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'PaidAmount
        '
        Me.PaidAmount.Location = New System.Drawing.Point(255, 334)
        Me.PaidAmount.Name = "PaidAmount"
        Me.PaidAmount.PlaceholderText = "Enter Amount Paid"
        Me.PaidAmount.Size = New System.Drawing.Size(151, 27)
        Me.PaidAmount.TabIndex = 12
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(255, 292)
        Me.Total.Name = "Total"
        Me.Total.PlaceholderText = "Enter Total"
        Me.Total.Size = New System.Drawing.Size(151, 27)
        Me.Total.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(18, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Paid Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(18, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(18, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Notes:"
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(18, 163)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(394, 110)
        Me.Notes.TabIndex = 9
        Me.Notes.Text = ""
        '
        'Paid
        '
        Me.Paid.AutoSize = True
        Me.Paid.BackColor = System.Drawing.Color.Transparent
        Me.Paid.Location = New System.Drawing.Point(139, 88)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(59, 24)
        Me.Paid.TabIndex = 8
        Me.Paid.Text = "Paid"
        Me.Paid.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(17, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Payment mode*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(18, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Payment Status*"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(926, 426)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(926, 453)
        Me.ToolStripContainer1.TabIndex = 32
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'P_mode
        '
        Me.P_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_mode.FormattingEnabled = True
        Me.P_mode.Items.AddRange(New Object() {"Online", "Cash", "Check"})
        Me.P_mode.Location = New System.Drawing.Point(139, 38)
        Me.P_mode.Name = "P_mode"
        Me.P_mode.Size = New System.Drawing.Size(151, 28)
        Me.P_mode.TabIndex = 32
        '
        'AddInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(926, 453)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MinimumSize = New System.Drawing.Size(496, 500)
        Me.Name = "AddInvoice"
        Me.Text = "Add Invoice"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
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
    Friend WithEvents InvoiceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Test As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Notes As RichTextBox
    Friend WithEvents Paid As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ReturnedCash As TextBox
    Friend WithEvents Amount3 As TextBox
    Friend WithEvents Amount2 As TextBox
    Friend WithEvents Percentage As TextBox
    Friend WithEvents PaidAmount As TextBox
    Friend WithEvents Total As TextBox
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents PrintPreviewToolStripButton As ToolStripButton
    Friend WithEvents Address As TextBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents P_mode As ComboBox
End Class
