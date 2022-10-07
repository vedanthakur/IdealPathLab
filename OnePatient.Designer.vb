<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnePatient
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
        Me.NoImage = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mobile = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CitizenshipNo = New System.Windows.Forms.Label()
        Me.PassportIssuedDistrict = New System.Windows.Forms.Label()
        Me.PassportExpired = New System.Windows.Forms.Label()
        Me.PassportIssuedDate = New System.Windows.Forms.Label()
        Me.PassportNo = New System.Windows.Forms.Label()
        Me.ACountry = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.Referral = New System.Windows.Forms.Label()
        Me.ReferralLab = New System.Windows.Forms.Label()
        Me.Nationality = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.Label()
        Me.MaritalStatus = New System.Windows.Forms.Label()
        Me.CPerson = New System.Windows.Forms.Label()
        Me.CPRelation = New System.Windows.Forms.Label()
        Me.CPPhone = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoImage
        '
        Me.NoImage.AutoSize = True
        Me.NoImage.Location = New System.Drawing.Point(37, 64)
        Me.NoImage.Name = "NoImage"
        Me.NoImage.Size = New System.Drawing.Size(75, 20)
        Me.NoImage.TabIndex = 52
        Me.NoImage.Text = "No image"
        Me.NoImage.Visible = False
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PName.Location = New System.Drawing.Point(148, 9)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(141, 46)
        Me.PName.TabIndex = 48
        Me.PName.Text = "yName: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(130, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(206, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Referral Hospital/Laboratory :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Referral :"
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Location = New System.Drawing.Point(155, 93)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(36, 20)
        Me.Age.TabIndex = 23
        Me.Age.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date of Birth :"
        '
        'Mobile
        '
        Me.Mobile.AutoSize = True
        Me.Mobile.Location = New System.Drawing.Point(155, 122)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(56, 20)
        Me.Mobile.TabIndex = 17
        Me.Mobile.Text = "Mobile"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Location = New System.Drawing.Point(155, 64)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(57, 20)
        Me.Gender.TabIndex = 1
        Me.Gender.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Marital Status :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 320)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nationality :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 359)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Email :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 398)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Phone :"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.CitizenshipNo)
        Me.GroupBox2.Controls.Add(Me.PassportIssuedDistrict)
        Me.GroupBox2.Controls.Add(Me.PassportExpired)
        Me.GroupBox2.Controls.Add(Me.PassportIssuedDate)
        Me.GroupBox2.Controls.Add(Me.PassportNo)
        Me.GroupBox2.Controls.Add(Me.ACountry)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(677, 242)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 338)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Roreign Employment"
        '
        'CitizenshipNo
        '
        Me.CitizenshipNo.AutoSize = True
        Me.CitizenshipNo.Location = New System.Drawing.Point(170, 291)
        Me.CitizenshipNo.Name = "CitizenshipNo"
        Me.CitizenshipNo.Size = New System.Drawing.Size(12, 20)
        Me.CitizenshipNo.TabIndex = 25
        Me.CitizenshipNo.Text = ":"
        '
        'PassportIssuedDistrict
        '
        Me.PassportIssuedDistrict.AutoSize = True
        Me.PassportIssuedDistrict.Location = New System.Drawing.Point(191, 241)
        Me.PassportIssuedDistrict.Name = "PassportIssuedDistrict"
        Me.PassportIssuedDistrict.Size = New System.Drawing.Size(12, 20)
        Me.PassportIssuedDistrict.TabIndex = 24
        Me.PassportIssuedDistrict.Text = ":"
        '
        'PassportExpired
        '
        Me.PassportExpired.AutoSize = True
        Me.PassportExpired.Location = New System.Drawing.Point(185, 191)
        Me.PassportExpired.Name = "PassportExpired"
        Me.PassportExpired.Size = New System.Drawing.Size(12, 20)
        Me.PassportExpired.TabIndex = 23
        Me.PassportExpired.Text = ":"
        '
        'PassportIssuedDate
        '
        Me.PassportIssuedDate.AutoSize = True
        Me.PassportIssuedDate.Location = New System.Drawing.Point(176, 141)
        Me.PassportIssuedDate.Name = "PassportIssuedDate"
        Me.PassportIssuedDate.Size = New System.Drawing.Size(12, 20)
        Me.PassportIssuedDate.TabIndex = 22
        Me.PassportIssuedDate.Text = ":"
        '
        'PassportNo
        '
        Me.PassportNo.AutoSize = True
        Me.PassportNo.Location = New System.Drawing.Point(153, 91)
        Me.PassportNo.Name = "PassportNo"
        Me.PassportNo.Size = New System.Drawing.Size(12, 20)
        Me.PassportNo.TabIndex = 21
        Me.PassportNo.Text = ":"
        '
        'ACountry
        '
        Me.ACountry.AutoSize = True
        Me.ACountry.Location = New System.Drawing.Point(148, 41)
        Me.ACountry.Name = "ACountry"
        Me.ACountry.Size = New System.Drawing.Size(12, 20)
        Me.ACountry.TabIndex = 20
        Me.ACountry.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Citizenship Number :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 20)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Passport Issued District :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Passport Expired Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Applied Country :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Passport Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Passport issued Date :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 476)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Contact Person :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 515)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(173, 20)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Contact Person Relation :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 554)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(186, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Contact Person Phone No. :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1025, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Edit Patient"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(87, 164)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(16, 20)
        Me.Address.TabIndex = 55
        Me.Address.Text = " :"
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Location = New System.Drawing.Point(119, 203)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(12, 20)
        Me.DOB.TabIndex = 56
        Me.DOB.Text = ":"
        '
        'Referral
        '
        Me.Referral.AutoSize = True
        Me.Referral.Location = New System.Drawing.Point(86, 242)
        Me.Referral.Name = "Referral"
        Me.Referral.Size = New System.Drawing.Size(12, 20)
        Me.Referral.TabIndex = 57
        Me.Referral.Text = ":"
        '
        'ReferralLab
        '
        Me.ReferralLab.AutoSize = True
        Me.ReferralLab.Location = New System.Drawing.Point(224, 283)
        Me.ReferralLab.Name = "ReferralLab"
        Me.ReferralLab.Size = New System.Drawing.Size(12, 20)
        Me.ReferralLab.TabIndex = 58
        Me.ReferralLab.Text = ":"
        '
        'Nationality
        '
        Me.Nationality.AutoSize = True
        Me.Nationality.Location = New System.Drawing.Point(107, 320)
        Me.Nationality.Name = "Nationality"
        Me.Nationality.Size = New System.Drawing.Size(12, 20)
        Me.Nationality.TabIndex = 59
        Me.Nationality.Text = ":"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(71, 359)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(12, 20)
        Me.Email.TabIndex = 60
        Me.Email.Text = ":"
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Location = New System.Drawing.Point(75, 398)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(12, 20)
        Me.Phone.TabIndex = 61
        Me.Phone.Text = ":"
        '
        'MaritalStatus
        '
        Me.MaritalStatus.AutoSize = True
        Me.MaritalStatus.Location = New System.Drawing.Point(125, 437)
        Me.MaritalStatus.Name = "MaritalStatus"
        Me.MaritalStatus.Size = New System.Drawing.Size(12, 20)
        Me.MaritalStatus.TabIndex = 62
        Me.MaritalStatus.Text = ":"
        '
        'CPerson
        '
        Me.CPerson.AutoSize = True
        Me.CPerson.Location = New System.Drawing.Point(132, 476)
        Me.CPerson.Name = "CPerson"
        Me.CPerson.Size = New System.Drawing.Size(12, 20)
        Me.CPerson.TabIndex = 63
        Me.CPerson.Text = ":"
        '
        'CPRelation
        '
        Me.CPRelation.AutoSize = True
        Me.CPRelation.Location = New System.Drawing.Point(191, 515)
        Me.CPRelation.Name = "CPRelation"
        Me.CPRelation.Size = New System.Drawing.Size(12, 20)
        Me.CPRelation.TabIndex = 64
        Me.CPRelation.Text = ":"
        '
        'CPPhone
        '
        Me.CPPhone.AutoSize = True
        Me.CPPhone.Location = New System.Drawing.Point(204, 554)
        Me.CPPhone.Name = "CPPhone"
        Me.CPPhone.Size = New System.Drawing.Size(12, 20)
        Me.CPPhone.TabIndex = 65
        Me.CPPhone.Text = ":"
        '
        'OnePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 606)
        Me.Controls.Add(Me.CPPhone)
        Me.Controls.Add(Me.CPRelation)
        Me.Controls.Add(Me.CPerson)
        Me.Controls.Add(Me.MaritalStatus)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Nationality)
        Me.Controls.Add(Me.ReferralLab)
        Me.Controls.Add(Me.Referral)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.NoImage)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Label11)
        Me.MinimumSize = New System.Drawing.Size(1149, 653)
        Me.Name = "OnePatient"
        Me.Text = "OnePatient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoImage As Label
    Friend WithEvents PName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Age As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mobile As Label
    Friend WithEvents Gender As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CitizenshipNo As Label
    Friend WithEvents PassportIssuedDistrict As Label
    Friend WithEvents PassportExpired As Label
    Friend WithEvents PassportIssuedDate As Label
    Friend WithEvents PassportNo As Label
    Friend WithEvents ACountry As Label
    Friend WithEvents Address As Label
    Friend WithEvents DOB As Label
    Friend WithEvents Referral As Label
    Friend WithEvents ReferralLab As Label
    Friend WithEvents Nationality As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phone As Label
    Friend WithEvents MaritalStatus As Label
    Friend WithEvents CPerson As Label
    Friend WithEvents CPRelation As Label
    Friend WithEvents CPPhone As Label
End Class
