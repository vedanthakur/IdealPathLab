<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatient))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RLab = New System.Windows.Forms.ComboBox()
        Me.Referral = New System.Windows.Forms.ComboBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.PName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.UploadBtn = New System.Windows.Forms.Button()
        Me.MaritalStatus = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Nationality = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CitizenshipNo = New System.Windows.Forms.TextBox()
        Me.PIssuedDistrict = New System.Windows.Forms.ComboBox()
        Me.PassportExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.PassportIssuedDate = New System.Windows.Forms.DateTimePicker()
        Me.PassportNo = New System.Windows.Forms.TextBox()
        Me.Country = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CPPhone = New System.Windows.Forms.TextBox()
        Me.CPRelation = New System.Windows.Forms.TextBox()
        Me.CPerson = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(921, 767)
        Me.FlowLayoutPanel2.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.RLab)
        Me.GroupBox1.Controls.Add(Me.Referral)
        Me.GroupBox1.Controls.Add(Me.Age)
        Me.GroupBox1.Controls.Add(Me.DOB)
        Me.GroupBox1.Controls.Add(Me.Mobile)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.PName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NameL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(442, 395)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(442, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 395)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Patient"
        '
        'RLab
        '
        Me.RLab.FormattingEnabled = True
        Me.RLab.Location = New System.Drawing.Point(278, 341)
        Me.RLab.Name = "RLab"
        Me.RLab.Size = New System.Drawing.Size(151, 28)
        Me.RLab.TabIndex = 35
        Me.RLab.Text = "Select"
        '
        'Referral
        '
        Me.Referral.FormattingEnabled = True
        Me.Referral.Location = New System.Drawing.Point(278, 297)
        Me.Referral.Name = "Referral"
        Me.Referral.Size = New System.Drawing.Size(151, 28)
        Me.Referral.TabIndex = 34
        Me.Referral.Text = "Select"
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(278, 254)
        Me.Age.Name = "Age"
        Me.Age.PlaceholderText = "Enter Age"
        Me.Age.Size = New System.Drawing.Size(151, 27)
        Me.Age.TabIndex = 33
        '
        'DOB
        '
        Me.DOB.CustomFormat = "yyyy-MM-dd"
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOB.Location = New System.Drawing.Point(278, 211)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(151, 27)
        Me.DOB.TabIndex = 32
        '
        'Mobile
        '
        Me.Mobile.Location = New System.Drawing.Point(278, 168)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.PlaceholderText = "Enter Mobile No."
        Me.Mobile.Size = New System.Drawing.Size(151, 27)
        Me.Mobile.TabIndex = 31
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(278, 125)
        Me.Address.Name = "Address"
        Me.Address.PlaceholderText = "Enter Address"
        Me.Address.Size = New System.Drawing.Size(151, 27)
        Me.Address.TabIndex = 30
        '
        'Gender
        '
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.Gender.Location = New System.Drawing.Point(278, 81)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(151, 28)
        Me.Gender.TabIndex = 29
        '
        'PName
        '
        Me.PName.Location = New System.Drawing.Point(278, 38)
        Me.PName.Name = "PName"
        Me.PName.PlaceholderText = "Enter Name"
        Me.PName.Size = New System.Drawing.Size(151, 27)
        Me.PName.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Referral Hospital/Laboratory"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Referral"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Mobile"
        '
        'NameL
        '
        Me.NameL.AutoSize = True
        Me.NameL.Location = New System.Drawing.Point(18, 41)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(49, 20)
        Me.NameL.TabIndex = 0
        Me.NameL.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.UploadBtn)
        Me.GroupBox3.Controls.Add(Me.MaritalStatus)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Phone)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Email)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Nationality)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(451, 3)
        Me.GroupBox3.MaximumSize = New System.Drawing.Size(442, 395)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(442, 395)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 395)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Detail Information"
        '
        'UploadBtn
        '
        Me.UploadBtn.Location = New System.Drawing.Point(274, 208)
        Me.UploadBtn.Name = "UploadBtn"
        Me.UploadBtn.Size = New System.Drawing.Size(151, 29)
        Me.UploadBtn.TabIndex = 31
        Me.UploadBtn.Text = "Upload"
        Me.UploadBtn.UseVisualStyleBackColor = True
        '
        'MaritalStatus
        '
        Me.MaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaritalStatus.FormattingEnabled = True
        Me.MaritalStatus.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        Me.MaritalStatus.Location = New System.Drawing.Point(274, 165)
        Me.MaritalStatus.Name = "MaritalStatus"
        Me.MaritalStatus.Size = New System.Drawing.Size(151, 28)
        Me.MaritalStatus.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(286, 253)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(130, 0)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(0, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 213)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 20)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Image"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Marital Status"
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(274, 123)
        Me.Phone.Name = "Phone"
        Me.Phone.PlaceholderText = "Enter Phone no."
        Me.Phone.Size = New System.Drawing.Size(151, 27)
        Me.Phone.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nationality"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(274, 81)
        Me.Email.Name = "Email"
        Me.Email.PlaceholderText = "Enter Email"
        Me.Email.Size = New System.Drawing.Size(151, 27)
        Me.Email.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Email"
        '
        'Nationality
        '
        Me.Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nationality.FormattingEnabled = True
        Me.Nationality.Items.AddRange(New Object() {"Nepal", "India", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.Nationality.Location = New System.Drawing.Point(274, 38)
        Me.Nationality.Name = "Nationality"
        Me.Nationality.Size = New System.Drawing.Size(151, 28)
        Me.Nationality.TabIndex = 20
        Me.Nationality.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Phone"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.CitizenshipNo)
        Me.GroupBox2.Controls.Add(Me.PIssuedDistrict)
        Me.GroupBox2.Controls.Add(Me.PassportExpiredDate)
        Me.GroupBox2.Controls.Add(Me.PassportIssuedDate)
        Me.GroupBox2.Controls.Add(Me.PassportNo)
        Me.GroupBox2.Controls.Add(Me.Country)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 404)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 338)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Roreign Employment"
        '
        'CitizenshipNo
        '
        Me.CitizenshipNo.Location = New System.Drawing.Point(278, 285)
        Me.CitizenshipNo.Name = "CitizenshipNo"
        Me.CitizenshipNo.PlaceholderText = "Enter Citizenship No."
        Me.CitizenshipNo.Size = New System.Drawing.Size(151, 27)
        Me.CitizenshipNo.TabIndex = 25
        '
        'PIssuedDistrict
        '
        Me.PIssuedDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PIssuedDistrict.FormattingEnabled = True
        Me.PIssuedDistrict.Items.AddRange(New Object() {"Bhojpur", "Dhankuta", "Ilam", "Jhapa", "Khotang", "Morang", "Okhaldhunga", "Panchthar", "Sankhuwasabha", "Solukhumbu", "Sunsari", "Taplejung", "Terhathum", "Udayapur", "Bara", "Dhanusa", "Mahottari", "Parsa", "Rautahat", "Saptari", "Sarlahi", "Siraha", "Bhaktapur District", "Chitwan", "Dhading", "Dolakha", "Kathmandu", "Kavrepalanchok", "Lalitpur", "Makawanpur", "Nuwakot District", "Ramechhap", "Rasuwa", "Sindhuli", "Sindhupalchok", "Baglung", "Gorkha", "Kaski", "Lamjung", "Manang", "Mustang", "Myagdi", "Nawalparasi (Bardaghat Susta Purva)", "Parbat", "Syangja", "Tanahu District", "Arghakhanchi", "Banke", "Bardiya", "Dang", "Gulmi", "Kapilvastu", "Nawalparasi (Bardaghat Susta Paschim)", "Palpa", "Pyuthan", "Rolpa", "Purbi Rukum", "Rupandehi", "Dailekh", "Dolpa", "Humla", "Jajarkot", "Jumla", "Kalikot", "Mugu", "Rukum Paschim", "Salyan", "Surkhet", "Achham", "Baitadi", "Bajhang", "Bajura", "Dadeldhura", "Darchula", "Doti", "Kailali", "Kanchanpur"})
        Me.PIssuedDistrict.Location = New System.Drawing.Point(278, 235)
        Me.PIssuedDistrict.Name = "PIssuedDistrict"
        Me.PIssuedDistrict.Size = New System.Drawing.Size(151, 28)
        Me.PIssuedDistrict.TabIndex = 24
        '
        'PassportExpiredDate
        '
        Me.PassportExpiredDate.CustomFormat = "yyyy-MM-dd"
        Me.PassportExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PassportExpiredDate.Location = New System.Drawing.Point(278, 186)
        Me.PassportExpiredDate.Name = "PassportExpiredDate"
        Me.PassportExpiredDate.Size = New System.Drawing.Size(151, 27)
        Me.PassportExpiredDate.TabIndex = 23
        '
        'PassportIssuedDate
        '
        Me.PassportIssuedDate.CustomFormat = "yyyy-MM-dd"
        Me.PassportIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PassportIssuedDate.Location = New System.Drawing.Point(278, 138)
        Me.PassportIssuedDate.Name = "PassportIssuedDate"
        Me.PassportIssuedDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PassportIssuedDate.Size = New System.Drawing.Size(151, 27)
        Me.PassportIssuedDate.TabIndex = 22
        '
        'PassportNo
        '
        Me.PassportNo.Location = New System.Drawing.Point(278, 88)
        Me.PassportNo.Name = "PassportNo"
        Me.PassportNo.PlaceholderText = "Enter Passport No."
        Me.PassportNo.Size = New System.Drawing.Size(151, 27)
        Me.PassportNo.TabIndex = 21
        '
        'Country
        '
        Me.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Country.FormattingEnabled = True
        Me.Country.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.Country.Location = New System.Drawing.Point(278, 38)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(151, 28)
        Me.Country.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Citizenship Number"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 20)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Passport Issued District"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Passport Expired Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Applied Country"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Passport Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Passport issued Date"
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Controls.Add(Me.CPPhone)
        Me.GroupBox4.Controls.Add(Me.CPRelation)
        Me.GroupBox4.Controls.Add(Me.CPerson)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(451, 404)
        Me.GroupBox4.MinimumSize = New System.Drawing.Size(442, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 189)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Emergency Contact Information"
        '
        'CPPhone
        '
        Me.CPPhone.Location = New System.Drawing.Point(274, 136)
        Me.CPPhone.Name = "CPPhone"
        Me.CPPhone.PlaceholderText = "Enter Phone No."
        Me.CPPhone.Size = New System.Drawing.Size(151, 27)
        Me.CPPhone.TabIndex = 5
        '
        'CPRelation
        '
        Me.CPRelation.Location = New System.Drawing.Point(274, 87)
        Me.CPRelation.Name = "CPRelation"
        Me.CPRelation.PlaceholderText = "Enter Relation"
        Me.CPRelation.Size = New System.Drawing.Size(151, 27)
        Me.CPRelation.TabIndex = 4
        '
        'CPerson
        '
        Me.CPerson.Location = New System.Drawing.Point(274, 38)
        Me.CPerson.Name = "CPerson"
        Me.CPerson.PlaceholderText = "Enter Contact Name"
        Me.CPerson.Size = New System.Drawing.Size(151, 27)
        Me.CPerson.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 41)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Contact Person"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 20)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Contact Person Relation"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 141)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(179, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Contact Person Phone No."
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(921, 767)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(921, 794)
        Me.ToolStripContainer1.TabIndex = 32
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 794)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MinimumSize = New System.Drawing.Size(497, 637)
        Me.Name = "AddPatient"
        Me.Text = "Add Patient"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents NameL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RLab As ComboBox
    Friend WithEvents Referral As ComboBox
    Friend WithEvents Age As TextBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Mobile As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents Gender As ComboBox
    Friend WithEvents PName As TextBox
    Friend WithEvents UploadBtn As Button
    Friend WithEvents MaritalStatus As ComboBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Nationality As ComboBox
    Friend WithEvents CitizenshipNo As TextBox
    Friend WithEvents PIssuedDistrict As ComboBox
    Friend WithEvents PassportExpiredDate As DateTimePicker
    Friend WithEvents PassportIssuedDate As DateTimePicker
    Friend WithEvents PassportNo As TextBox
    Friend WithEvents Country As ComboBox
    Friend WithEvents CPPhone As TextBox
    Friend WithEvents CPRelation As TextBox
    Friend WithEvents CPerson As TextBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
End Class
