<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lblSessionID = New System.Windows.Forms.Label()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUserLoginID = New System.Windows.Forms.Label()
        Me.lblCompanyID = New System.Windows.Forms.Label()
        Me.lblAccessType = New System.Windows.Forms.Label()
        Me.btnUserRight = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConsigners = New System.Windows.Forms.Button()
        Me.btnConsignee = New System.Windows.Forms.Button()
        Me.btnCity = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnBilty = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuProductList = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuConsignerList = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuConsigneeList = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuCityList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransporter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.smnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuBilty = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuUnUpdaedBilty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuBillSundry = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuUserList = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuUserRights = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCNSRAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCNSEAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuCNSERate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSession = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuSalaryPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuSalaryReciept = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuMarksEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuGradeEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuRankAttendance = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuPrintReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuFeeReciept = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuFeeRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuDayBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuDueRecovery = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuAllDue = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuFeeDisc = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuVehicleFee = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 711)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1059, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.LightBlue
        Me.Panel.Controls.Add(Me.lblSessionID)
        Me.Panel.Controls.Add(Me.btnBill)
        Me.Panel.Controls.Add(Me.PictureBox3)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Controls.Add(Me.lblUserLoginID)
        Me.Panel.Controls.Add(Me.lblCompanyID)
        Me.Panel.Controls.Add(Me.lblAccessType)
        Me.Panel.Controls.Add(Me.btnUserRight)
        Me.Panel.Controls.Add(Me.btnUsers)
        Me.Panel.Controls.Add(Me.btnReport)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.btnConsigners)
        Me.Panel.Controls.Add(Me.btnConsignee)
        Me.Panel.Controls.Add(Me.btnCity)
        Me.Panel.Controls.Add(Me.btnInvoice)
        Me.Panel.Controls.Add(Me.btnBilty)
        Me.Panel.Controls.Add(Me.btnProducts)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel.Location = New System.Drawing.Point(884, 0)
        Me.Panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(175, 711)
        Me.Panel.TabIndex = 17
        '
        'lblSessionID
        '
        Me.lblSessionID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSessionID.Location = New System.Drawing.Point(3, 708)
        Me.lblSessionID.Name = "lblSessionID"
        Me.lblSessionID.Size = New System.Drawing.Size(29, 19)
        Me.lblSessionID.TabIndex = 52
        Me.lblSessionID.Visible = False
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBill.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBill.ForeColor = System.Drawing.Color.White
        Me.btnBill.Location = New System.Drawing.Point(0, 327)
        Me.btnBill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(175, 35)
        Me.btnBill.TabIndex = 51
        Me.btnBill.Text = "Bill / Invoice"
        Me.btnBill.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.eLozics.My.Resources.Resources.mws_logo
        Me.PictureBox3.Location = New System.Drawing.Point(17, 575)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(149, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(25, 550)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 22)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "For Any Support"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(13, 628)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 47)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "9026419991"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eLozics.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 405)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'lblUserLoginID
        '
        Me.lblUserLoginID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUserLoginID.Location = New System.Drawing.Point(79, 440)
        Me.lblUserLoginID.Name = "lblUserLoginID"
        Me.lblUserLoginID.Size = New System.Drawing.Size(29, 19)
        Me.lblUserLoginID.TabIndex = 46
        Me.lblUserLoginID.Visible = False
        '
        'lblCompanyID
        '
        Me.lblCompanyID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCompanyID.Location = New System.Drawing.Point(44, 440)
        Me.lblCompanyID.Name = "lblCompanyID"
        Me.lblCompanyID.Size = New System.Drawing.Size(29, 19)
        Me.lblCompanyID.TabIndex = 45
        Me.lblCompanyID.Visible = False
        '
        'lblAccessType
        '
        Me.lblAccessType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccessType.Location = New System.Drawing.Point(9, 440)
        Me.lblAccessType.Name = "lblAccessType"
        Me.lblAccessType.Size = New System.Drawing.Size(29, 19)
        Me.lblAccessType.TabIndex = 44
        Me.lblAccessType.Visible = False
        '
        'btnUserRight
        '
        Me.btnUserRight.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserRight.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUserRight.ForeColor = System.Drawing.Color.White
        Me.btnUserRight.Location = New System.Drawing.Point(0, 401)
        Me.btnUserRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUserRight.Name = "btnUserRight"
        Me.btnUserRight.Size = New System.Drawing.Size(175, 35)
        Me.btnUserRight.TabIndex = 42
        Me.btnUserRight.Text = "Users Rights"
        Me.btnUserRight.UseVisualStyleBackColor = False
        Me.btnUserRight.Visible = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(0, 185)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(175, 35)
        Me.btnUsers.TabIndex = 41
        Me.btnUsers.Text = "Transporter"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(0, 364)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(175, 35)
        Me.btnReport.TabIndex = 35
        Me.btnReport.Text = "Reports"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(20, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "TRANSACTION"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.Location = New System.Drawing.Point(0, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 23)
        Me.Label4.TabIndex = 32
        '
        'btnConsigners
        '
        Me.btnConsigners.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConsigners.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsigners.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsigners.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsigners.ForeColor = System.Drawing.Color.White
        Me.btnConsigners.Location = New System.Drawing.Point(0, 74)
        Me.btnConsigners.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsigners.Name = "btnConsigners"
        Me.btnConsigners.Size = New System.Drawing.Size(175, 35)
        Me.btnConsigners.TabIndex = 30
        Me.btnConsigners.Text = "Consigners"
        Me.btnConsigners.UseVisualStyleBackColor = False
        '
        'btnConsignee
        '
        Me.btnConsignee.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConsignee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsignee.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsignee.ForeColor = System.Drawing.Color.White
        Me.btnConsignee.Location = New System.Drawing.Point(0, 111)
        Me.btnConsignee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsignee.Name = "btnConsignee"
        Me.btnConsignee.Size = New System.Drawing.Size(175, 35)
        Me.btnConsignee.TabIndex = 29
        Me.btnConsignee.Text = "Consignees"
        Me.btnConsignee.UseVisualStyleBackColor = False
        '
        'btnCity
        '
        Me.btnCity.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCity.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCity.ForeColor = System.Drawing.Color.White
        Me.btnCity.Location = New System.Drawing.Point(0, 148)
        Me.btnCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCity.Name = "btnCity"
        Me.btnCity.Size = New System.Drawing.Size(175, 35)
        Me.btnCity.TabIndex = 28
        Me.btnCity.Text = "Destination"
        Me.btnCity.UseVisualStyleBackColor = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvoice.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInvoice.ForeColor = System.Drawing.Color.White
        Me.btnInvoice.Location = New System.Drawing.Point(0, 253)
        Me.btnInvoice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(175, 35)
        Me.btnInvoice.TabIndex = 27
        Me.btnInvoice.Text = "Bilty"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnBilty
        '
        Me.btnBilty.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBilty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBilty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilty.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBilty.ForeColor = System.Drawing.Color.White
        Me.btnBilty.Location = New System.Drawing.Point(0, 290)
        Me.btnBilty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBilty.Name = "btnBilty"
        Me.btnBilty.Size = New System.Drawing.Size(175, 35)
        Me.btnBilty.TabIndex = 26
        Me.btnBilty.Text = "Challan"
        Me.btnBilty.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.Color.SteelBlue
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Location = New System.Drawing.Point(0, 37)
        Me.btnProducts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(175, 35)
        Me.btnProducts.TabIndex = 25
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(43, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "MASTER"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 37)
        Me.Label1.TabIndex = 23
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add.png")
        Me.ImageList1.Images.SetKeyName(1, "edit.png")
        Me.ImageList1.Images.SetKeyName(2, "delete.png")
        Me.ImageList1.Images.SetKeyName(3, "search.png")
        Me.ImageList1.Images.SetKeyName(4, "print.png")
        Me.ImageList1.Images.SetKeyName(5, "Logout.png")
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMaster, Me.mnuTransaction, Me.mnuAdmin, Me.mnuLogOff})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip.TabIndex = 22
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuMaster
        '
        Me.mnuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smnuProductList, Me.smnuConsignerList, Me.smnuConsigneeList, Me.smnuCityList, Me.mnuTransporter, Me.ToolStripSeparator4, Me.smnuExit})
        Me.mnuMaster.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuMaster.Name = "mnuMaster"
        Me.mnuMaster.Size = New System.Drawing.Size(55, 20)
        Me.mnuMaster.Text = "&Master"
        '
        'smnuProductList
        '
        Me.smnuProductList.Name = "smnuProductList"
        Me.smnuProductList.Size = New System.Drawing.Size(134, 22)
        Me.smnuProductList.Text = "Products"
        '
        'smnuConsignerList
        '
        Me.smnuConsignerList.Name = "smnuConsignerList"
        Me.smnuConsignerList.Size = New System.Drawing.Size(134, 22)
        Me.smnuConsignerList.Text = "Consignors"
        '
        'smnuConsigneeList
        '
        Me.smnuConsigneeList.Name = "smnuConsigneeList"
        Me.smnuConsigneeList.Size = New System.Drawing.Size(134, 22)
        Me.smnuConsigneeList.Text = "Consignee"
        '
        'smnuCityList
        '
        Me.smnuCityList.Name = "smnuCityList"
        Me.smnuCityList.Size = New System.Drawing.Size(134, 22)
        Me.smnuCityList.Text = "Destination"
        '
        'mnuTransporter
        '
        Me.mnuTransporter.Name = "mnuTransporter"
        Me.mnuTransporter.Size = New System.Drawing.Size(134, 22)
        Me.mnuTransporter.Text = "Transporter"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(131, 6)
        '
        'smnuExit
        '
        Me.smnuExit.Name = "smnuExit"
        Me.smnuExit.Size = New System.Drawing.Size(134, 22)
        Me.smnuExit.Text = "E&xit"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smnuInvoice, Me.smnuBilty, Me.smnuBill, Me.smnuUnUpdaedBilty})
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(79, 20)
        Me.mnuTransaction.Text = "Transaction"
        '
        'smnuInvoice
        '
        Me.smnuInvoice.Name = "smnuInvoice"
        Me.smnuInvoice.Size = New System.Drawing.Size(160, 22)
        Me.smnuInvoice.Text = "Bilty"
        '
        'smnuBilty
        '
        Me.smnuBilty.Name = "smnuBilty"
        Me.smnuBilty.Size = New System.Drawing.Size(160, 22)
        Me.smnuBilty.Text = "Challan"
        '
        'smnuBill
        '
        Me.smnuBill.Name = "smnuBill"
        Me.smnuBill.Size = New System.Drawing.Size(160, 22)
        Me.smnuBill.Text = "Bill / Invoice"
        '
        'smnuUnUpdaedBilty
        '
        Me.smnuUnUpdaedBilty.Name = "smnuUnUpdaedBilty"
        Me.smnuUnUpdaedBilty.Size = New System.Drawing.Size(160, 22)
        Me.smnuUnUpdaedBilty.Text = "UnUpdated Bilty"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smnuBillSundry, Me.smnuUserList, Me.smnuUserRights, Me.ToolStripSeparator1, Me.mnuCNSRAdmin, Me.mnuCNSEAdmin, Me.mnuTransAdmin, Me.smnuCNSERate, Me.ToolStripSeparator3, Me.mnuSession, Me.mnuBackup, Me.mnuRestore, Me.ToolStripSeparator2, Me.mnuCompany})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(98, 20)
        Me.mnuAdmin.Text = "Administration"
        '
        'smnuBillSundry
        '
        Me.smnuBillSundry.Name = "smnuBillSundry"
        Me.smnuBillSundry.Size = New System.Drawing.Size(156, 22)
        Me.smnuBillSundry.Text = "Bill Sundry"
        '
        'smnuUserList
        '
        Me.smnuUserList.Name = "smnuUserList"
        Me.smnuUserList.Size = New System.Drawing.Size(156, 22)
        Me.smnuUserList.Text = "Users"
        '
        'smnuUserRights
        '
        Me.smnuUserRights.Name = "smnuUserRights"
        Me.smnuUserRights.Size = New System.Drawing.Size(156, 22)
        Me.smnuUserRights.Text = "User Rights"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'mnuCNSRAdmin
        '
        Me.mnuCNSRAdmin.Name = "mnuCNSRAdmin"
        Me.mnuCNSRAdmin.Size = New System.Drawing.Size(156, 22)
        Me.mnuCNSRAdmin.Text = "Consignor"
        '
        'mnuCNSEAdmin
        '
        Me.mnuCNSEAdmin.Name = "mnuCNSEAdmin"
        Me.mnuCNSEAdmin.Size = New System.Drawing.Size(156, 22)
        Me.mnuCNSEAdmin.Text = "Consignee"
        '
        'mnuTransAdmin
        '
        Me.mnuTransAdmin.Name = "mnuTransAdmin"
        Me.mnuTransAdmin.Size = New System.Drawing.Size(156, 22)
        Me.mnuTransAdmin.Text = "Transporter"
        '
        'smnuCNSERate
        '
        Me.smnuCNSERate.Name = "smnuCNSERate"
        Me.smnuCNSERate.Size = New System.Drawing.Size(156, 22)
        Me.smnuCNSERate.Text = "Consignee Rate"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(153, 6)
        '
        'mnuSession
        '
        Me.mnuSession.Name = "mnuSession"
        Me.mnuSession.Size = New System.Drawing.Size(156, 22)
        Me.mnuSession.Text = "Session"
        '
        'mnuBackup
        '
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(156, 22)
        Me.mnuBackup.Text = "Backup"
        '
        'mnuRestore
        '
        Me.mnuRestore.Name = "mnuRestore"
        Me.mnuRestore.Size = New System.Drawing.Size(156, 22)
        Me.mnuRestore.Text = "Restore"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'mnuCompany
        '
        Me.mnuCompany.Name = "mnuCompany"
        Me.mnuCompany.Size = New System.Drawing.Size(156, 22)
        Me.mnuCompany.Text = "Company"
        '
        'mnuLogOff
        '
        Me.mnuLogOff.Name = "mnuLogOff"
        Me.mnuLogOff.Size = New System.Drawing.Size(38, 20)
        Me.mnuLogOff.Text = "Exit"
        '
        'smnuSalaryPayment
        '
        Me.smnuSalaryPayment.Name = "smnuSalaryPayment"
        Me.smnuSalaryPayment.Size = New System.Drawing.Size(155, 22)
        Me.smnuSalaryPayment.Text = "Salary Payment"
        '
        'smnuSalaryReciept
        '
        Me.smnuSalaryReciept.Name = "smnuSalaryReciept"
        Me.smnuSalaryReciept.Size = New System.Drawing.Size(155, 22)
        Me.smnuSalaryReciept.Text = "Salary List"
        '
        'smnuMarksEntry
        '
        Me.smnuMarksEntry.Name = "smnuMarksEntry"
        Me.smnuMarksEntry.Size = New System.Drawing.Size(172, 22)
        Me.smnuMarksEntry.Text = "Marks Entry"
        '
        'smnuGradeEntry
        '
        Me.smnuGradeEntry.Name = "smnuGradeEntry"
        Me.smnuGradeEntry.Size = New System.Drawing.Size(172, 22)
        Me.smnuGradeEntry.Text = "Grade Entry"
        '
        'smnuRankAttendance
        '
        Me.smnuRankAttendance.Name = "smnuRankAttendance"
        Me.smnuRankAttendance.Size = New System.Drawing.Size(172, 22)
        Me.smnuRankAttendance.Text = "Rank / Attendance"
        Me.smnuRankAttendance.Visible = False
        '
        'smnuPrintReport
        '
        Me.smnuPrintReport.Name = "smnuPrintReport"
        Me.smnuPrintReport.Size = New System.Drawing.Size(172, 22)
        Me.smnuPrintReport.Text = "Print Report Card"
        '
        'smnuFeeReciept
        '
        Me.smnuFeeReciept.Name = "smnuFeeReciept"
        Me.smnuFeeReciept.Size = New System.Drawing.Size(180, 22)
        Me.smnuFeeReciept.Text = "Fee Reciept"
        '
        'smnuFeeRegister
        '
        Me.smnuFeeRegister.Name = "smnuFeeRegister"
        Me.smnuFeeRegister.Size = New System.Drawing.Size(180, 22)
        Me.smnuFeeRegister.Text = "Fee Register"
        '
        'smnuDayBook
        '
        Me.smnuDayBook.Name = "smnuDayBook"
        Me.smnuDayBook.Size = New System.Drawing.Size(180, 22)
        Me.smnuDayBook.Text = "Day Book"
        '
        'smnuDueRecovery
        '
        Me.smnuDueRecovery.Enabled = False
        Me.smnuDueRecovery.Name = "smnuDueRecovery"
        Me.smnuDueRecovery.Size = New System.Drawing.Size(180, 22)
        Me.smnuDueRecovery.Text = "Due Recovery"
        Me.smnuDueRecovery.Visible = False
        '
        'smnuAllDue
        '
        Me.smnuAllDue.Enabled = False
        Me.smnuAllDue.Name = "smnuAllDue"
        Me.smnuAllDue.Size = New System.Drawing.Size(180, 22)
        Me.smnuAllDue.Text = "All Due Fee"
        Me.smnuAllDue.Visible = False
        '
        'smnuFeeDisc
        '
        Me.smnuFeeDisc.Enabled = False
        Me.smnuFeeDisc.Name = "smnuFeeDisc"
        Me.smnuFeeDisc.Size = New System.Drawing.Size(180, 22)
        Me.smnuFeeDisc.Text = "Fee Discount Report"
        Me.smnuFeeDisc.Visible = False
        '
        'smnuVehicleFee
        '
        Me.smnuVehicleFee.Enabled = False
        Me.smnuVehicleFee.Name = "smnuVehicleFee"
        Me.smnuVehicleFee.Size = New System.Drawing.Size(180, 22)
        Me.smnuVehicleFee.Text = "Vehicle Fee Report"
        Me.smnuVehicleFee.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.eLozics.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(343, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(277, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 176
        Me.PictureBox2.TabStop = False
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eLozics.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(1059, 733)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConsigners As System.Windows.Forms.Button
    Friend WithEvents btnConsignee As System.Windows.Forms.Button
    Friend WithEvents btnCity As System.Windows.Forms.Button
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents btnBilty As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnUserRight As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuProductList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuConsignerList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuConsigneeList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuCityList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents smnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuBillSundry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuUserList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuUserRights As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogOff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuSalaryPayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuSalaryReciept As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuMarksEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuGradeEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuRankAttendance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuPrintReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuFeeReciept As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuFeeRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuDayBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuDueRecovery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuAllDue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuFeeDisc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuVehicleFee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuBilty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserLoginID As System.Windows.Forms.Label
    Friend WithEvents lblCompanyID As System.Windows.Forms.Label
    Friend WithEvents lblAccessType As System.Windows.Forms.Label
    Friend WithEvents mnuTransporter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents smnuBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents mnuSession As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSessionID As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuUnUpdaedBilty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCNSRAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCNSEAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTransAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuCNSERate As System.Windows.Forms.ToolStripMenuItem

End Class
