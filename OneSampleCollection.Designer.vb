<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneSampleCollection
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CollectedBy = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.Label()
        Me.InvoiceNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Notes = New System.Windows.Forms.Label()
        Me.CTime = New System.Windows.Forms.Label()
        Me.CollectionDate = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(465, 584)
        Me.FlowLayoutPanel2.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CollectedBy)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.PName)
        Me.GroupBox1.Controls.Add(Me.InvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 240)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sample"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Edit Sample"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CollectedBy
        '
        Me.CollectedBy.AutoSize = True
        Me.CollectedBy.Location = New System.Drawing.Point(181, 197)
        Me.CollectedBy.Name = "CollectedBy"
        Me.CollectedBy.Size = New System.Drawing.Size(13, 20)
        Me.CollectedBy.TabIndex = 21
        Me.CollectedBy.Text = " "
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(181, 153)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(13, 20)
        Me.Address.TabIndex = 20
        Me.Address.Text = " "
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.Location = New System.Drawing.Point(181, 109)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(13, 20)
        Me.PName.TabIndex = 19
        Me.PName.Text = " "
        '
        'InvoiceNo
        '
        Me.InvoiceNo.AutoSize = True
        Me.InvoiceNo.Location = New System.Drawing.Point(181, 65)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.Size = New System.Drawing.Size(13, 20)
        Me.InvoiceNo.TabIndex = 18
        Me.InvoiceNo.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sample Collected By"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select invoice no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Billing Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.Notes)
        Me.GroupBox2.Controls.Add(Me.CTime)
        Me.GroupBox2.Controls.Add(Me.CollectionDate)
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.Description)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 249)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 302)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'Notes
        '
        Me.Notes.AutoSize = True
        Me.Notes.Location = New System.Drawing.Point(22, 259)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(13, 20)
        Me.Notes.TabIndex = 33
        Me.Notes.Text = " "
        '
        'CTime
        '
        Me.CTime.AutoSize = True
        Me.CTime.Location = New System.Drawing.Point(181, 182)
        Me.CTime.Name = "CTime"
        Me.CTime.Size = New System.Drawing.Size(13, 20)
        Me.CTime.TabIndex = 32
        Me.CTime.Text = " "
        '
        'CollectionDate
        '
        Me.CollectionDate.AutoSize = True
        Me.CollectionDate.Location = New System.Drawing.Point(181, 135)
        Me.CollectionDate.Name = "CollectionDate"
        Me.CollectionDate.Size = New System.Drawing.Size(13, 20)
        Me.CollectionDate.TabIndex = 31
        Me.CollectionDate.Text = " "
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(181, 88)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(13, 20)
        Me.Status.TabIndex = 30
        Me.Status.Text = " "
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(181, 41)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(13, 20)
        Me.Description.TabIndex = 29
        Me.Description.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Collection Date"
        '
        'OneSampleCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 584)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "OneSampleCollection"
        Me.Text = "One Sample Collection"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CollectedBy As Label
    Friend WithEvents Address As Label
    Friend WithEvents PName As Label
    Friend WithEvents InvoiceNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Notes As Label
    Friend WithEvents CTime As Label
    Friend WithEvents CollectionDate As Label
    Friend WithEvents Status As Label
    Friend WithEvents Description As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
