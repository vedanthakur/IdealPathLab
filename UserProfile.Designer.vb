<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserProfile
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UName = New System.Windows.Forms.Label()
        Me.RollnBranch = New System.Windows.Forms.Label()
        Me.HR = New System.Windows.Forms.Label()
        Me.ContactDetails = New System.Windows.Forms.Label()
        Me.userWD = New System.Windows.Forms.CheckBox()
        Me.publishS = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NoImage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'UName
        '
        Me.UName.AutoSize = True
        Me.UName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UName.Location = New System.Drawing.Point(144, -4)
        Me.UName.Name = "UName"
        Me.UName.Size = New System.Drawing.Size(141, 46)
        Me.UName.TabIndex = 28
        Me.UName.Text = "yName: "
        '
        'RollnBranch
        '
        Me.RollnBranch.AutoSize = True
        Me.RollnBranch.Location = New System.Drawing.Point(149, 46)
        Me.RollnBranch.Name = "RollnBranch"
        Me.RollnBranch.Size = New System.Drawing.Size(113, 20)
        Me.RollnBranch.TabIndex = 29
        Me.RollnBranch.Text = "Roll and Branch"
        '
        'HR
        '
        Me.HR.AutoSize = True
        Me.HR.Location = New System.Drawing.Point(149, 94)
        Me.HR.Name = "HR"
        Me.HR.Size = New System.Drawing.Size(29, 20)
        Me.HR.TabIndex = 30
        Me.HR.Text = "HR"
        '
        'ContactDetails
        '
        Me.ContactDetails.AutoSize = True
        Me.ContactDetails.Location = New System.Drawing.Point(149, 70)
        Me.ContactDetails.Name = "ContactDetails"
        Me.ContactDetails.Size = New System.Drawing.Size(110, 20)
        Me.ContactDetails.TabIndex = 32
        Me.ContactDetails.Text = "Contact Details"
        '
        'userWD
        '
        Me.userWD.AutoSize = True
        Me.userWD.Location = New System.Drawing.Point(154, 117)
        Me.userWD.Name = "userWD"
        Me.userWD.Size = New System.Drawing.Size(178, 24)
        Me.userWD.TabIndex = 33
        Me.userWD.Text = "Show User Wise Data*"
        Me.userWD.UseVisualStyleBackColor = True
        '
        'publishS
        '
        Me.publishS.AutoSize = True
        Me.publishS.Location = New System.Drawing.Point(339, 117)
        Me.publishS.Name = "publishS"
        Me.publishS.Size = New System.Drawing.Size(78, 24)
        Me.publishS.TabIndex = 34
        Me.publishS.Text = "Publish"
        Me.publishS.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(449, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Edit User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NoImage
        '
        Me.NoImage.AutoSize = True
        Me.NoImage.Location = New System.Drawing.Point(33, 60)
        Me.NoImage.Name = "NoImage"
        Me.NoImage.Size = New System.Drawing.Size(75, 20)
        Me.NoImage.TabIndex = 36
        Me.NoImage.Text = "No image"
        Me.NoImage.Visible = False
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 153)
        Me.Controls.Add(Me.NoImage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.publishS)
        Me.Controls.Add(Me.userWD)
        Me.Controls.Add(Me.ContactDetails)
        Me.Controls.Add(Me.HR)
        Me.Controls.Add(Me.RollnBranch)
        Me.Controls.Add(Me.UName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UserProfile"
        Me.Text = "User Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UName As Label
    Friend WithEvents RollnBranch As Label
    Friend WithEvents HR As Label
    Friend WithEvents ContactDetails As Label
    Friend WithEvents userWD As CheckBox
    Friend WithEvents publishS As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NoImage As Label
End Class
