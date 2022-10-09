<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneBranch
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.publishS = New System.Windows.Forms.CheckBox()
        Me.ContactDetails = New System.Windows.Forms.Label()
        Me.UName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContactPerson = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.NoImage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Edit User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'publishS
        '
        Me.publishS.AutoSize = True
        Me.publishS.Location = New System.Drawing.Point(153, 121)
        Me.publishS.Name = "publishS"
        Me.publishS.Size = New System.Drawing.Size(78, 24)
        Me.publishS.TabIndex = 42
        Me.publishS.Text = "Publish"
        Me.publishS.UseVisualStyleBackColor = True
        '
        'ContactDetails
        '
        Me.ContactDetails.AutoSize = True
        Me.ContactDetails.Location = New System.Drawing.Point(153, 74)
        Me.ContactDetails.Name = "ContactDetails"
        Me.ContactDetails.Size = New System.Drawing.Size(110, 20)
        Me.ContactDetails.TabIndex = 40
        Me.ContactDetails.Text = "Contact Details"
        '
        'UName
        '
        Me.UName.AutoSize = True
        Me.UName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UName.Location = New System.Drawing.Point(148, 0)
        Me.UName.Name = "UName"
        Me.UName.Size = New System.Drawing.Size(141, 46)
        Me.UName.TabIndex = 37
        Me.UName.Text = "yName: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'ContactPerson
        '
        Me.ContactPerson.AutoSize = True
        Me.ContactPerson.Location = New System.Drawing.Point(153, 98)
        Me.ContactPerson.Name = "ContactPerson"
        Me.ContactPerson.Size = New System.Drawing.Size(107, 20)
        Me.ContactPerson.TabIndex = 49
        Me.ContactPerson.Text = "Contact Person"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(153, 50)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(62, 20)
        Me.Address.TabIndex = 44
        Me.Address.Text = "Address"
        '
        'NoImage
        '
        Me.NoImage.AutoSize = True
        Me.NoImage.Location = New System.Drawing.Point(39, 65)
        Me.NoImage.Name = "NoImage"
        Me.NoImage.Size = New System.Drawing.Size(75, 20)
        Me.NoImage.TabIndex = 50
        Me.NoImage.Text = "No image"
        Me.NoImage.Visible = False
        '
        'OneBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 156)
        Me.Controls.Add(Me.NoImage)
        Me.Controls.Add(Me.ContactPerson)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.publishS)
        Me.Controls.Add(Me.ContactDetails)
        Me.Controls.Add(Me.UName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OneBranch"
        Me.Text = "One Branch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents publishS As CheckBox
    Friend WithEvents ContactDetails As Label
    Friend WithEvents UName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContactPerson As Label
    Friend WithEvents Address As Label
    Friend WithEvents NoImage As Label
End Class
