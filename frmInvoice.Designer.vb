<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblHeaderID = New System.Windows.Forms.Label()
        Me.txtTotalPackage = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtChargeWt = New System.Windows.Forms.TextBox()
        Me.lblHR2 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSNCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Packages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualWt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeWt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPackage = New System.Windows.Forms.TextBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StripPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtActualWt = New System.Windows.Forms.TextBox()
        Me.txtTotalActualWeight = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTaxableAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCGST = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSGST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIGST = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.lblSGST = New System.Windows.Forms.Label()
        Me.lblCGST = New System.Windows.Forms.Label()
        Me.lblIGST = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbExmptd = New System.Windows.Forms.RadioButton()
        Me.rbTrans = New System.Windows.Forms.RadioButton()
        Me.rbCnse = New System.Windows.Forms.RadioButton()
        Me.rbCnsr = New System.Windows.Forms.RadioButton()
        Me.cmbDestination = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalChargeWeight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrivateMarks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTruckNo = New System.Windows.Forms.TextBox()
        Me.cmbConsigner = New System.Windows.Forms.ComboBox()
        Me.txtConsignerCity = New System.Windows.Forms.TextBox()
        Me.cmbConsignee = New System.Windows.Forms.ComboBox()
        Me.txtConsigneeCity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.cmbTransporter = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.frameGST = New System.Windows.Forms.GroupBox()
        Me.rbIGST = New System.Windows.Forms.RadioButton()
        Me.rbCGST = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.frameCNSR = New System.Windows.Forms.Panel()
        Me.txtAadhar = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCNSRSave = New System.Windows.Forms.Button()
        Me.btnCNSRCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.frameCNSE = New System.Windows.Forms.Panel()
        Me.rbW = New System.Windows.Forms.RadioButton()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtRemarks2 = New System.Windows.Forms.TextBox()
        Me.txtProdRate = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtAadhar2 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtGST2 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtState2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCompany2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMobileNo2 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCity2 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.btnCNSESave = New System.Windows.Forms.Button()
        Me.btnCNSECancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.frameTrans = New System.Windows.Forms.Panel()
        Me.txtTransMobile = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtTransName = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnTransSave = New System.Windows.Forms.Button()
        Me.btnTransCancel = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnProdCancel = New System.Windows.Forms.Button()
        Me.btnProdSave = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.frameProd = New System.Windows.Forms.Panel()
        Me.frameDestination = New System.Windows.Forms.Panel()
        Me.txtDestName = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btnDestSave = New System.Windows.Forms.Button()
        Me.btnDestCancel = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblOldDate = New System.Windows.Forms.Label()
        Me.lblOldNo = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtHSN = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbRCMYes = New System.Windows.Forms.RadioButton()
        Me.rbRCMNo = New System.Windows.Forms.RadioButton()
        Me.Grid2 = New System.Windows.Forms.DataGridView()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.rbTBB = New System.Windows.Forms.RadioButton()
        Me.rbPaid = New System.Windows.Forms.RadioButton()
        Me.rbToPay = New System.Windows.Forms.RadioButton()
        Me.cmbRemarks = New System.Windows.Forms.ComboBox()
        Me.grdPrev = New System.Windows.Forms.DataGridView()
        Me.lblRateBy = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StripPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.frameGST.SuspendLayout()
        Me.frameCNSR.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.frameCNSE.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.frameTrans.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.frameProd.SuspendLayout()
        Me.frameDestination.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(12, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(51, 22)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Bilty"
        '
        'lblHeaderID
        '
        Me.lblHeaderID.BackColor = System.Drawing.Color.White
        Me.lblHeaderID.Location = New System.Drawing.Point(1272, 281)
        Me.lblHeaderID.Name = "lblHeaderID"
        Me.lblHeaderID.Size = New System.Drawing.Size(17, 19)
        Me.lblHeaderID.TabIndex = 287
        Me.lblHeaderID.Visible = False
        '
        'txtTotalPackage
        '
        Me.txtTotalPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalPackage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPackage.Location = New System.Drawing.Point(1221, 253)
        Me.txtTotalPackage.Name = "txtTotalPackage"
        Me.txtTotalPackage.Size = New System.Drawing.Size(10, 22)
        Me.txtTotalPackage.TabIndex = 280
        Me.txtTotalPackage.Visible = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(1237, 253)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(10, 22)
        Me.txtTotalAmount.TabIndex = 278
        Me.txtTotalAmount.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(226, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 18)
        Me.Label16.TabIndex = 283
        Me.Label16.Text = "Charge Wt."
        '
        'txtChargeWt
        '
        Me.txtChargeWt.BackColor = System.Drawing.Color.White
        Me.txtChargeWt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeWt.Location = New System.Drawing.Point(229, 233)
        Me.txtChargeWt.Name = "txtChargeWt"
        Me.txtChargeWt.Size = New System.Drawing.Size(98, 22)
        Me.txtChargeWt.TabIndex = 10
        '
        'lblHR2
        '
        Me.lblHR2.BackColor = System.Drawing.Color.DimGray
        Me.lblHR2.Location = New System.Drawing.Point(0, 268)
        Me.lblHR2.Name = "lblHR2"
        Me.lblHR2.Size = New System.Drawing.Size(1067, 1)
        Me.lblHR2.TabIndex = 282
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ProductName, Me.Description, Me.HSNCode, Me.Packages, Me.ActualWt, Me.ChargeWt, Me.Amount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.Location = New System.Drawing.Point(1204, 325)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(251, 71)
        Me.Grid.TabIndex = 276
        Me.Grid.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'ProductName
        '
        Me.ProductName.FillWeight = 38.7665!
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Description
        '
        Me.Description.FillWeight = 60.0!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'HSNCode
        '
        Me.HSNCode.FillWeight = 40.0!
        Me.HSNCode.HeaderText = "HSN Code"
        Me.HSNCode.Name = "HSNCode"
        Me.HSNCode.ReadOnly = True
        '
        'Packages
        '
        Me.Packages.FillWeight = 25.0!
        Me.Packages.HeaderText = "Packages"
        Me.Packages.Name = "Packages"
        Me.Packages.ReadOnly = True
        '
        'ActualWt
        '
        Me.ActualWt.FillWeight = 14.76649!
        Me.ActualWt.HeaderText = "Actual Wt."
        Me.ActualWt.Name = "ActualWt"
        Me.ActualWt.ReadOnly = True
        '
        'ChargeWt
        '
        Me.ChargeWt.FillWeight = 17.76649!
        Me.ChargeWt.HeaderText = "Charge Wt."
        Me.ChargeWt.Name = "ChargeWt"
        Me.ChargeWt.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.FillWeight = 17.76649!
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(1250, 402)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(40, 30)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "-"
        Me.btnDel.UseVisualStyleBackColor = False
        Me.btnDel.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1204, 402)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 30)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(411, 213)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 275
        Me.Label17.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(414, 233)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(83, 22)
        Me.txtAmount.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(27, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 18)
        Me.Label15.TabIndex = 273
        Me.Label15.Text = "Packages"
        '
        'txtPackage
        '
        Me.txtPackage.BackColor = System.Drawing.Color.White
        Me.txtPackage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackage.Location = New System.Drawing.Point(30, 233)
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.Size = New System.Drawing.Size(83, 22)
        Me.txtPackage.TabIndex = 8
        '
        'cmbProduct
        '
        Me.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbProduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(28, 186)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(236, 24)
        Me.cmbProduct.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(33, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 18)
        Me.Label11.TabIndex = 270
        Me.Label11.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "dd/MM/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(74, 95)
        Me.txtDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(107, 22)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Value = New Date(2014, 4, 26, 0, 0, 0, 0)
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(74, 67)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(103, 22)
        Me.txtInvoiceNo.TabIndex = 247
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(1209, 305)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 18)
        Me.lblID.TabIndex = 266
        Me.lblID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(660, 474)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 38)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(25, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 268
        Me.Label8.Text = "Product Name"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(573, 474)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 38)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'StripPanel
        '
        Me.StripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StripPanel.Controls.Add(Me.lblCaption)
        Me.StripPanel.Location = New System.Drawing.Point(0, 0)
        Me.StripPanel.Name = "StripPanel"
        Me.StripPanel.Size = New System.Drawing.Size(858, 43)
        Me.StripPanel.TabIndex = 263
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "C. N. No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(124, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 291
        Me.Label9.Text = "Actual Wt."
        '
        'txtActualWt
        '
        Me.txtActualWt.BackColor = System.Drawing.Color.White
        Me.txtActualWt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActualWt.Location = New System.Drawing.Point(127, 233)
        Me.txtActualWt.Name = "txtActualWt"
        Me.txtActualWt.Size = New System.Drawing.Size(96, 22)
        Me.txtActualWt.TabIndex = 9
        '
        'txtTotalActualWeight
        '
        Me.txtTotalActualWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalActualWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalActualWeight.Location = New System.Drawing.Point(1208, 253)
        Me.txtTotalActualWeight.Name = "txtTotalActualWeight"
        Me.txtTotalActualWeight.Size = New System.Drawing.Size(10, 22)
        Me.txtTotalActualWeight.TabIndex = 292
        Me.txtTotalActualWeight.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(401, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 22)
        Me.Label18.TabIndex = 246
        Me.Label18.Text = "Total Amount"
        '
        'txtTaxableAmount
        '
        Me.txtTaxableAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTaxableAmount.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxableAmount.Location = New System.Drawing.Point(401, 294)
        Me.txtTaxableAmount.Name = "txtTaxableAmount"
        Me.txtTaxableAmount.ReadOnly = True
        Me.txtTaxableAmount.Size = New System.Drawing.Size(103, 26)
        Me.txtTaxableAmount.TabIndex = 245
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(401, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "CGST"
        '
        'txtCGST
        '
        Me.txtCGST.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCGST.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCGST.Location = New System.Drawing.Point(401, 345)
        Me.txtCGST.Name = "txtCGST"
        Me.txtCGST.ReadOnly = True
        Me.txtCGST.Size = New System.Drawing.Size(103, 26)
        Me.txtCGST.TabIndex = 296
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(401, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 299
        Me.Label3.Text = "SGST"
        '
        'txtSGST
        '
        Me.txtSGST.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSGST.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSGST.Location = New System.Drawing.Point(401, 396)
        Me.txtSGST.Name = "txtSGST"
        Me.txtSGST.ReadOnly = True
        Me.txtSGST.Size = New System.Drawing.Size(103, 26)
        Me.txtSGST.TabIndex = 298
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(401, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 22)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "IGST"
        '
        'txtIGST
        '
        Me.txtIGST.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtIGST.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIGST.Location = New System.Drawing.Point(401, 447)
        Me.txtIGST.Name = "txtIGST"
        Me.txtIGST.ReadOnly = True
        Me.txtIGST.Size = New System.Drawing.Size(103, 26)
        Me.txtIGST.TabIndex = 300
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(510, 446)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 27)
        Me.Label5.TabIndex = 303
        Me.Label5.Text = "Bill Amount"
        '
        'txtBillAmount
        '
        Me.txtBillAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBillAmount.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBillAmount.ForeColor = System.Drawing.Color.Red
        Me.txtBillAmount.Location = New System.Drawing.Point(638, 446)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.ReadOnly = True
        Me.txtBillAmount.Size = New System.Drawing.Size(103, 26)
        Me.txtBillAmount.TabIndex = 302
        '
        'lblSGST
        '
        Me.lblSGST.BackColor = System.Drawing.Color.White
        Me.lblSGST.Location = New System.Drawing.Point(1228, 282)
        Me.lblSGST.Name = "lblSGST"
        Me.lblSGST.Size = New System.Drawing.Size(16, 18)
        Me.lblSGST.TabIndex = 318
        Me.lblSGST.Visible = False
        '
        'lblCGST
        '
        Me.lblCGST.BackColor = System.Drawing.Color.White
        Me.lblCGST.Location = New System.Drawing.Point(1209, 282)
        Me.lblCGST.Name = "lblCGST"
        Me.lblCGST.Size = New System.Drawing.Size(16, 18)
        Me.lblCGST.TabIndex = 317
        Me.lblCGST.Visible = False
        '
        'lblIGST
        '
        Me.lblIGST.BackColor = System.Drawing.Color.White
        Me.lblIGST.Location = New System.Drawing.Point(1250, 282)
        Me.lblIGST.Name = "lblIGST"
        Me.lblIGST.Size = New System.Drawing.Size(16, 18)
        Me.lblIGST.TabIndex = 319
        Me.lblIGST.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbExmptd)
        Me.GroupBox3.Controls.Add(Me.rbTrans)
        Me.GroupBox3.Controls.Add(Me.rbCnse)
        Me.GroupBox3.Controls.Add(Me.rbCnsr)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 48)
        Me.GroupBox3.TabIndex = 320
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GST Liable at"
        '
        'rbExmptd
        '
        Me.rbExmptd.AutoSize = True
        Me.rbExmptd.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbExmptd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbExmptd.Location = New System.Drawing.Point(269, 16)
        Me.rbExmptd.Name = "rbExmptd"
        Me.rbExmptd.Size = New System.Drawing.Size(80, 22)
        Me.rbExmptd.TabIndex = 28
        Me.rbExmptd.Text = "Exempted"
        Me.rbExmptd.UseVisualStyleBackColor = True
        '
        'rbTrans
        '
        Me.rbTrans.AutoSize = True
        Me.rbTrans.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbTrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbTrans.Location = New System.Drawing.Point(175, 16)
        Me.rbTrans.Name = "rbTrans"
        Me.rbTrans.Size = New System.Drawing.Size(92, 22)
        Me.rbTrans.TabIndex = 27
        Me.rbTrans.Text = "Transporter"
        Me.rbTrans.UseVisualStyleBackColor = True
        '
        'rbCnse
        '
        Me.rbCnse.AutoSize = True
        Me.rbCnse.Checked = True
        Me.rbCnse.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbCnse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbCnse.Location = New System.Drawing.Point(87, 19)
        Me.rbCnse.Name = "rbCnse"
        Me.rbCnse.Size = New System.Drawing.Size(82, 22)
        Me.rbCnse.TabIndex = 26
        Me.rbCnse.TabStop = True
        Me.rbCnse.Text = "Consignee"
        Me.rbCnse.UseVisualStyleBackColor = True
        '
        'rbCnsr
        '
        Me.rbCnsr.AutoSize = True
        Me.rbCnsr.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbCnsr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbCnsr.Location = New System.Drawing.Point(6, 19)
        Me.rbCnsr.Name = "rbCnsr"
        Me.rbCnsr.Size = New System.Drawing.Size(80, 22)
        Me.rbCnsr.TabIndex = 25
        Me.rbCnsr.Text = "Consignor"
        Me.rbCnsr.UseVisualStyleBackColor = True
        '
        'cmbDestination
        '
        Me.cmbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDestination.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbDestination.FormattingEnabled = True
        Me.cmbDestination.Location = New System.Drawing.Point(41, 140)
        Me.cmbDestination.Name = "cmbDestination"
        Me.cmbDestination.Size = New System.Drawing.Size(301, 24)
        Me.cmbDestination.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(38, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "Destination"
        '
        'txtTotalChargeWeight
        '
        Me.txtTotalChargeWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalChargeWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalChargeWeight.Location = New System.Drawing.Point(1253, 253)
        Me.txtTotalChargeWeight.Name = "txtTotalChargeWeight"
        Me.txtTotalChargeWeight.Size = New System.Drawing.Size(10, 22)
        Me.txtTotalChargeWeight.TabIndex = 323
        Me.txtTotalChargeWeight.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 325
        Me.Label7.Text = "Invoice No"
        '
        'txtInv
        '
        Me.txtInv.BackColor = System.Drawing.Color.White
        Me.txtInv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInv.Location = New System.Drawing.Point(28, 297)
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(177, 22)
        Me.txtInv.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(217, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 18)
        Me.Label10.TabIndex = 327
        Me.Label10.Text = "Remarks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(218, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 18)
        Me.Label12.TabIndex = 331
        Me.Label12.Text = "Private Marks"
        '
        'txtPrivateMarks
        '
        Me.txtPrivateMarks.BackColor = System.Drawing.Color.White
        Me.txtPrivateMarks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrivateMarks.Location = New System.Drawing.Point(218, 346)
        Me.txtPrivateMarks.Name = "txtPrivateMarks"
        Me.txtPrivateMarks.Size = New System.Drawing.Size(177, 22)
        Me.txtPrivateMarks.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(28, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 18)
        Me.Label13.TabIndex = 329
        Me.Label13.Text = "Value"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.White
        Me.txtValue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(28, 345)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(177, 22)
        Me.txtValue.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(27, 369)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 18)
        Me.Label19.TabIndex = 333
        Me.Label19.Text = "eWay Bill No"
        '
        'txtTruckNo
        '
        Me.txtTruckNo.BackColor = System.Drawing.Color.White
        Me.txtTruckNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTruckNo.Location = New System.Drawing.Point(27, 390)
        Me.txtTruckNo.Name = "txtTruckNo"
        Me.txtTruckNo.Size = New System.Drawing.Size(177, 22)
        Me.txtTruckNo.TabIndex = 26
        '
        'cmbConsigner
        '
        Me.cmbConsigner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsigner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsigner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbConsigner.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbConsigner.FormattingEnabled = True
        Me.cmbConsigner.Location = New System.Drawing.Point(198, 69)
        Me.cmbConsigner.Name = "cmbConsigner"
        Me.cmbConsigner.Size = New System.Drawing.Size(252, 24)
        Me.cmbConsigner.TabIndex = 1
        '
        'txtConsignerCity
        '
        Me.txtConsignerCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConsignerCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsignerCity.Location = New System.Drawing.Point(198, 95)
        Me.txtConsignerCity.Name = "txtConsignerCity"
        Me.txtConsignerCity.ReadOnly = True
        Me.txtConsignerCity.Size = New System.Drawing.Size(252, 22)
        Me.txtConsignerCity.TabIndex = 335
        '
        'cmbConsignee
        '
        Me.cmbConsignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsignee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbConsignee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConsignee.FormattingEnabled = True
        Me.cmbConsignee.Location = New System.Drawing.Point(476, 67)
        Me.cmbConsignee.Name = "cmbConsignee"
        Me.cmbConsignee.Size = New System.Drawing.Size(252, 24)
        Me.cmbConsignee.TabIndex = 2
        '
        'txtConsigneeCity
        '
        Me.txtConsigneeCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConsigneeCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsigneeCity.Location = New System.Drawing.Point(476, 95)
        Me.txtConsigneeCity.Name = "txtConsigneeCity"
        Me.txtConsigneeCity.ReadOnly = True
        Me.txtConsigneeCity.Size = New System.Drawing.Size(252, 22)
        Me.txtConsigneeCity.TabIndex = 337
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(195, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 18)
        Me.Label14.TabIndex = 338
        Me.Label14.Text = "Consignor Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(473, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 339
        Me.Label20.Text = "Consignee Name"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(601, 141)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.ReadOnly = True
        Me.txtMobile.Size = New System.Drawing.Size(127, 22)
        Me.txtMobile.TabIndex = 341
        '
        'cmbTransporter
        '
        Me.cmbTransporter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTransporter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTransporter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTransporter.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(346, 140)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(252, 24)
        Me.cmbTransporter.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(346, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(149, 18)
        Me.Label21.TabIndex = 342
        Me.Label21.Text = "Transporter Name / No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.frameGST)
        Me.GroupBox1.Controls.Add(Me.rbNo)
        Me.GroupBox1.Controls.Add(Me.rbYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(752, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 158)
        Me.GroupBox1.TabIndex = 343
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GST Applicable"
        '
        'frameGST
        '
        Me.frameGST.Controls.Add(Me.rbIGST)
        Me.frameGST.Controls.Add(Me.rbCGST)
        Me.frameGST.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.frameGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.frameGST.Location = New System.Drawing.Point(9, 73)
        Me.frameGST.Name = "frameGST"
        Me.frameGST.Size = New System.Drawing.Size(115, 77)
        Me.frameGST.TabIndex = 296
        Me.frameGST.TabStop = False
        Me.frameGST.Text = "GST Type"
        '
        'rbIGST
        '
        Me.rbIGST.AutoSize = True
        Me.rbIGST.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbIGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbIGST.Location = New System.Drawing.Point(6, 45)
        Me.rbIGST.Name = "rbIGST"
        Me.rbIGST.Size = New System.Drawing.Size(50, 22)
        Me.rbIGST.TabIndex = 13
        Me.rbIGST.Text = "IGST"
        Me.rbIGST.UseVisualStyleBackColor = True
        '
        'rbCGST
        '
        Me.rbCGST.AutoSize = True
        Me.rbCGST.Checked = True
        Me.rbCGST.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbCGST.Location = New System.Drawing.Point(6, 19)
        Me.rbCGST.Name = "rbCGST"
        Me.rbCGST.Size = New System.Drawing.Size(97, 22)
        Me.rbCGST.TabIndex = 12
        Me.rbCGST.TabStop = True
        Me.rbCGST.Text = "CGST && SGST"
        Me.rbCGST.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Checked = True
        Me.rbNo.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbNo.Location = New System.Drawing.Point(7, 20)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(41, 22)
        Me.rbNo.TabIndex = 13
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbYes.Location = New System.Drawing.Point(7, 43)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(45, 22)
        Me.rbYes.TabIndex = 12
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'lblGST
        '
        Me.lblGST.BackColor = System.Drawing.Color.White
        Me.lblGST.Location = New System.Drawing.Point(1230, 305)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(16, 18)
        Me.lblGST.TabIndex = 344
        Me.lblGST.Visible = False
        '
        'frameCNSR
        '
        Me.frameCNSR.BackColor = System.Drawing.Color.LightBlue
        Me.frameCNSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameCNSR.Controls.Add(Me.txtAadhar)
        Me.frameCNSR.Controls.Add(Me.Label22)
        Me.frameCNSR.Controls.Add(Me.txtGST)
        Me.frameCNSR.Controls.Add(Me.Label23)
        Me.frameCNSR.Controls.Add(Me.txtState)
        Me.frameCNSR.Controls.Add(Me.Label24)
        Me.frameCNSR.Controls.Add(Me.txtCompany)
        Me.frameCNSR.Controls.Add(Me.Label25)
        Me.frameCNSR.Controls.Add(Me.txtMobileNo)
        Me.frameCNSR.Controls.Add(Me.Label26)
        Me.frameCNSR.Controls.Add(Me.txtCity)
        Me.frameCNSR.Controls.Add(Me.Label27)
        Me.frameCNSR.Controls.Add(Me.txtAddress)
        Me.frameCNSR.Controls.Add(Me.txtName)
        Me.frameCNSR.Controls.Add(Me.btnCNSRSave)
        Me.frameCNSR.Controls.Add(Me.btnCNSRCancel)
        Me.frameCNSR.Controls.Add(Me.Panel2)
        Me.frameCNSR.Location = New System.Drawing.Point(187, 47)
        Me.frameCNSR.Name = "frameCNSR"
        Me.frameCNSR.Size = New System.Drawing.Size(398, 208)
        Me.frameCNSR.TabIndex = 345
        Me.frameCNSR.Visible = False
        '
        'txtAadhar
        '
        Me.txtAadhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAadhar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAadhar.Location = New System.Drawing.Point(108, 140)
        Me.txtAadhar.Name = "txtAadhar"
        Me.txtAadhar.Size = New System.Drawing.Size(284, 23)
        Me.txtAadhar.TabIndex = 117
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(4, 143)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 18)
        Me.Label22.TabIndex = 213
        Me.Label22.Text = "Aadhar No"
        '
        'txtGST
        '
        Me.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGST.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtGST.Location = New System.Drawing.Point(108, 113)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(284, 23)
        Me.txtGST.TabIndex = 116
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(4, 118)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 18)
        Me.Label23.TabIndex = 211
        Me.Label23.Text = "GSTin No"
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtState.Location = New System.Drawing.Point(285, 60)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(105, 23)
        Me.txtState.TabIndex = 114
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(246, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 18)
        Me.Label24.TabIndex = 209
        Me.Label24.Text = "State"
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCompany.Location = New System.Drawing.Point(108, 32)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(282, 23)
        Me.txtCompany.TabIndex = 111
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(4, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 18)
        Me.Label25.TabIndex = 206
        Me.Label25.Text = "Company Name"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtMobileNo.Location = New System.Drawing.Point(108, 86)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(284, 23)
        Me.txtMobileNo.TabIndex = 115
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(4, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 18)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Mobile No"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCity.Location = New System.Drawing.Point(108, 60)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 23)
        Me.txtCity.TabIndex = 113
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(4, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 18)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAddress.Location = New System.Drawing.Point(173, 169)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(23, 20)
        Me.txtAddress.TabIndex = 112
        Me.txtAddress.Visible = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtName.Location = New System.Drawing.Point(202, 169)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(15, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.Visible = False
        '
        'btnCNSRSave
        '
        Me.btnCNSRSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCNSRSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCNSRSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCNSRSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCNSRSave.ForeColor = System.Drawing.Color.White
        Me.btnCNSRSave.Location = New System.Drawing.Point(224, 169)
        Me.btnCNSRSave.Name = "btnCNSRSave"
        Me.btnCNSRSave.Size = New System.Drawing.Size(81, 32)
        Me.btnCNSRSave.TabIndex = 118
        Me.btnCNSRSave.Text = "&Save"
        Me.btnCNSRSave.UseVisualStyleBackColor = False
        '
        'btnCNSRCancel
        '
        Me.btnCNSRCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCNSRCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCNSRCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCNSRCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCNSRCancel.ForeColor = System.Drawing.Color.White
        Me.btnCNSRCancel.Location = New System.Drawing.Point(311, 169)
        Me.btnCNSRCancel.Name = "btnCNSRCancel"
        Me.btnCNSRCancel.Size = New System.Drawing.Size(81, 32)
        Me.btnCNSRCancel.TabIndex = 119
        Me.btnCNSRCancel.Text = "&Cancel"
        Me.btnCNSRCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 28)
        Me.Panel2.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(8, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(127, 18)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Add New Consignor"
        '
        'frameCNSE
        '
        Me.frameCNSE.BackColor = System.Drawing.Color.LightBlue
        Me.frameCNSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameCNSE.Controls.Add(Me.rbW)
        Me.frameCNSE.Controls.Add(Me.Label48)
        Me.frameCNSE.Controls.Add(Me.rbP)
        Me.frameCNSE.Controls.Add(Me.Label47)
        Me.frameCNSE.Controls.Add(Me.txtRemarks2)
        Me.frameCNSE.Controls.Add(Me.txtProdRate)
        Me.frameCNSE.Controls.Add(Me.Label45)
        Me.frameCNSE.Controls.Add(Me.txtAadhar2)
        Me.frameCNSE.Controls.Add(Me.Label29)
        Me.frameCNSE.Controls.Add(Me.txtGST2)
        Me.frameCNSE.Controls.Add(Me.Label31)
        Me.frameCNSE.Controls.Add(Me.txtState2)
        Me.frameCNSE.Controls.Add(Me.Label32)
        Me.frameCNSE.Controls.Add(Me.txtCompany2)
        Me.frameCNSE.Controls.Add(Me.Label33)
        Me.frameCNSE.Controls.Add(Me.txtMobileNo2)
        Me.frameCNSE.Controls.Add(Me.Label34)
        Me.frameCNSE.Controls.Add(Me.txtCity2)
        Me.frameCNSE.Controls.Add(Me.Label35)
        Me.frameCNSE.Controls.Add(Me.txtAddress2)
        Me.frameCNSE.Controls.Add(Me.txtName2)
        Me.frameCNSE.Controls.Add(Me.btnCNSESave)
        Me.frameCNSE.Controls.Add(Me.btnCNSECancel)
        Me.frameCNSE.Controls.Add(Me.Panel3)
        Me.frameCNSE.Location = New System.Drawing.Point(470, 48)
        Me.frameCNSE.Name = "frameCNSE"
        Me.frameCNSE.Size = New System.Drawing.Size(398, 303)
        Me.frameCNSE.TabIndex = 346
        Me.frameCNSE.Visible = False
        '
        'rbW
        '
        Me.rbW.AutoSize = True
        Me.rbW.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.rbW.Location = New System.Drawing.Point(319, 163)
        Me.rbW.Name = "rbW"
        Me.rbW.Size = New System.Drawing.Size(68, 22)
        Me.rbW.TabIndex = 233
        Me.rbW.Text = "Weight"
        Me.rbW.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(185, 165)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(52, 18)
        Me.Label48.TabIndex = 232
        Me.Label48.Text = "Rate By"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Checked = True
        Me.rbP.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.rbP.Location = New System.Drawing.Point(238, 163)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(74, 22)
        Me.rbP.TabIndex = 231
        Me.rbP.TabStop = True
        Me.rbP.Text = "Package"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(4, 192)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(59, 18)
        Me.Label47.TabIndex = 225
        Me.Label47.Text = "Remarks"
        '
        'txtRemarks2
        '
        Me.txtRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtRemarks2.Location = New System.Drawing.Point(108, 190)
        Me.txtRemarks2.Multiline = True
        Me.txtRemarks2.Name = "txtRemarks2"
        Me.txtRemarks2.Size = New System.Drawing.Size(284, 60)
        Me.txtRemarks2.TabIndex = 219
        '
        'txtProdRate
        '
        Me.txtProdRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtProdRate.Location = New System.Drawing.Point(108, 163)
        Me.txtProdRate.Name = "txtProdRate"
        Me.txtProdRate.Size = New System.Drawing.Size(64, 23)
        Me.txtProdRate.TabIndex = 218
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(4, 165)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 18)
        Me.Label45.TabIndex = 223
        Me.Label45.Text = "Product Rate"
        '
        'txtAadhar2
        '
        Me.txtAadhar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAadhar2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAadhar2.Location = New System.Drawing.Point(108, 136)
        Me.txtAadhar2.Name = "txtAadhar2"
        Me.txtAadhar2.Size = New System.Drawing.Size(284, 23)
        Me.txtAadhar2.TabIndex = 217
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(4, 141)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 18)
        Me.Label29.TabIndex = 213
        Me.Label29.Text = "Aadhar No"
        '
        'txtGST2
        '
        Me.txtGST2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGST2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtGST2.Location = New System.Drawing.Point(108, 110)
        Me.txtGST2.Name = "txtGST2"
        Me.txtGST2.Size = New System.Drawing.Size(284, 23)
        Me.txtGST2.TabIndex = 216
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(4, 116)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 18)
        Me.Label31.TabIndex = 211
        Me.Label31.Text = "GSTin No"
        '
        'txtState2
        '
        Me.txtState2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtState2.Location = New System.Drawing.Point(285, 58)
        Me.txtState2.Name = "txtState2"
        Me.txtState2.Size = New System.Drawing.Size(105, 23)
        Me.txtState2.TabIndex = 214
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(246, 60)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 18)
        Me.Label32.TabIndex = 209
        Me.Label32.Text = "State"
        '
        'txtCompany2
        '
        Me.txtCompany2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCompany2.Location = New System.Drawing.Point(108, 32)
        Me.txtCompany2.Name = "txtCompany2"
        Me.txtCompany2.Size = New System.Drawing.Size(282, 23)
        Me.txtCompany2.TabIndex = 211
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(4, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(98, 18)
        Me.Label33.TabIndex = 206
        Me.Label33.Text = "Company Name"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtMobileNo2.Location = New System.Drawing.Point(108, 84)
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(284, 23)
        Me.txtMobileNo2.TabIndex = 215
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(4, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(65, 18)
        Me.Label34.TabIndex = 48
        Me.Label34.Text = "Mobile No"
        '
        'txtCity2
        '
        Me.txtCity2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCity2.Location = New System.Drawing.Point(108, 58)
        Me.txtCity2.Name = "txtCity2"
        Me.txtCity2.Size = New System.Drawing.Size(132, 23)
        Me.txtCity2.TabIndex = 213
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(4, 60)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(31, 18)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "City"
        '
        'txtAddress2
        '
        Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAddress2.Location = New System.Drawing.Point(162, 277)
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(28, 11)
        Me.txtAddress2.TabIndex = 212
        Me.txtAddress2.Visible = False
        '
        'txtName2
        '
        Me.txtName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtName2.Location = New System.Drawing.Point(196, 269)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(15, 23)
        Me.txtName2.TabIndex = 1
        Me.txtName2.Visible = False
        '
        'btnCNSESave
        '
        Me.btnCNSESave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCNSESave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCNSESave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCNSESave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCNSESave.ForeColor = System.Drawing.Color.White
        Me.btnCNSESave.Location = New System.Drawing.Point(222, 260)
        Me.btnCNSESave.Name = "btnCNSESave"
        Me.btnCNSESave.Size = New System.Drawing.Size(81, 32)
        Me.btnCNSESave.TabIndex = 220
        Me.btnCNSESave.Text = "&Save"
        Me.btnCNSESave.UseVisualStyleBackColor = False
        '
        'btnCNSECancel
        '
        Me.btnCNSECancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCNSECancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCNSECancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCNSECancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCNSECancel.ForeColor = System.Drawing.Color.White
        Me.btnCNSECancel.Location = New System.Drawing.Point(309, 260)
        Me.btnCNSECancel.Name = "btnCNSECancel"
        Me.btnCNSECancel.Size = New System.Drawing.Size(81, 32)
        Me.btnCNSECancel.TabIndex = 221
        Me.btnCNSECancel.Text = "&Cancel"
        Me.btnCNSECancel.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(547, 28)
        Me.Panel3.TabIndex = 6
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(8, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 18)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Add New Consignee"
        '
        'frameTrans
        '
        Me.frameTrans.BackColor = System.Drawing.Color.LightBlue
        Me.frameTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameTrans.Controls.Add(Me.txtTransMobile)
        Me.frameTrans.Controls.Add(Me.Label42)
        Me.frameTrans.Controls.Add(Me.txtTransName)
        Me.frameTrans.Controls.Add(Me.Label40)
        Me.frameTrans.Controls.Add(Me.btnTransSave)
        Me.frameTrans.Controls.Add(Me.btnTransCancel)
        Me.frameTrans.Controls.Add(Me.Panel5)
        Me.frameTrans.Location = New System.Drawing.Point(346, 123)
        Me.frameTrans.Name = "frameTrans"
        Me.frameTrans.Size = New System.Drawing.Size(303, 122)
        Me.frameTrans.TabIndex = 348
        Me.frameTrans.Visible = False
        '
        'txtTransMobile
        '
        Me.txtTransMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransMobile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtTransMobile.Location = New System.Drawing.Point(120, 58)
        Me.txtTransMobile.Name = "txtTransMobile"
        Me.txtTransMobile.Size = New System.Drawing.Size(174, 23)
        Me.txtTransMobile.TabIndex = 213
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(9, 56)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(65, 18)
        Me.Label42.TabIndex = 38
        Me.Label42.Text = "Mobile No"
        '
        'txtTransName
        '
        Me.txtTransName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtTransName.Location = New System.Drawing.Point(120, 33)
        Me.txtTransName.Name = "txtTransName"
        Me.txtTransName.Size = New System.Drawing.Size(174, 23)
        Me.txtTransName.TabIndex = 212
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(9, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(114, 18)
        Me.Label40.TabIndex = 36
        Me.Label40.Text = "Transporter Name"
        '
        'btnTransSave
        '
        Me.btnTransSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTransSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnTransSave.ForeColor = System.Drawing.Color.White
        Me.btnTransSave.Location = New System.Drawing.Point(126, 84)
        Me.btnTransSave.Name = "btnTransSave"
        Me.btnTransSave.Size = New System.Drawing.Size(81, 32)
        Me.btnTransSave.TabIndex = 214
        Me.btnTransSave.Text = "&Save"
        Me.btnTransSave.UseVisualStyleBackColor = False
        '
        'btnTransCancel
        '
        Me.btnTransCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTransCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnTransCancel.ForeColor = System.Drawing.Color.White
        Me.btnTransCancel.Location = New System.Drawing.Point(213, 84)
        Me.btnTransCancel.Name = "btnTransCancel"
        Me.btnTransCancel.Size = New System.Drawing.Size(81, 32)
        Me.btnTransCancel.TabIndex = 215
        Me.btnTransCancel.Text = "&Cancel"
        Me.btnTransCancel.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label41)
        Me.Panel5.Location = New System.Drawing.Point(-2, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(329, 28)
        Me.Panel5.TabIndex = 6
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(4, 5)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(140, 18)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Add New Transporter"
        '
        'btnSavePrint
        '
        Me.btnSavePrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSavePrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.ForeColor = System.Drawing.Color.White
        Me.btnSavePrint.Location = New System.Drawing.Point(450, 474)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(117, 38)
        Me.btnSavePrint.TabIndex = 34
        Me.btnSavePrint.Text = "Save && &Print"
        Me.btnSavePrint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 28)
        Me.Panel1.TabIndex = 6
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(4, 5)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(121, 18)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Add New Products"
        '
        'btnProdCancel
        '
        Me.btnProdCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnProdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnProdCancel.ForeColor = System.Drawing.Color.White
        Me.btnProdCancel.Location = New System.Drawing.Point(212, 77)
        Me.btnProdCancel.Name = "btnProdCancel"
        Me.btnProdCancel.Size = New System.Drawing.Size(81, 32)
        Me.btnProdCancel.TabIndex = 2
        Me.btnProdCancel.Text = "&Cancel"
        Me.btnProdCancel.UseVisualStyleBackColor = False
        '
        'btnProdSave
        '
        Me.btnProdSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnProdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnProdSave.ForeColor = System.Drawing.Color.White
        Me.btnProdSave.Location = New System.Drawing.Point(125, 77)
        Me.btnProdSave.Name = "btnProdSave"
        Me.btnProdSave.Size = New System.Drawing.Size(81, 32)
        Me.btnProdSave.TabIndex = 1
        Me.btnProdSave.Text = "&Save"
        Me.btnProdSave.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(9, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 18)
        Me.Label38.TabIndex = 36
        Me.Label38.Text = "Product Name"
        '
        'txtProd
        '
        Me.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtProd.Location = New System.Drawing.Point(9, 50)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(284, 23)
        Me.txtProd.TabIndex = 0
        '
        'frameProd
        '
        Me.frameProd.BackColor = System.Drawing.Color.LightBlue
        Me.frameProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameProd.Controls.Add(Me.txtProd)
        Me.frameProd.Controls.Add(Me.Label38)
        Me.frameProd.Controls.Add(Me.btnProdSave)
        Me.frameProd.Controls.Add(Me.btnProdCancel)
        Me.frameProd.Controls.Add(Me.Panel1)
        Me.frameProd.Location = New System.Drawing.Point(21, 170)
        Me.frameProd.Name = "frameProd"
        Me.frameProd.Size = New System.Drawing.Size(303, 119)
        Me.frameProd.TabIndex = 347
        Me.frameProd.Visible = False
        '
        'frameDestination
        '
        Me.frameDestination.BackColor = System.Drawing.Color.LightBlue
        Me.frameDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameDestination.Controls.Add(Me.txtDestName)
        Me.frameDestination.Controls.Add(Me.Label43)
        Me.frameDestination.Controls.Add(Me.btnDestSave)
        Me.frameDestination.Controls.Add(Me.btnDestCancel)
        Me.frameDestination.Controls.Add(Me.Panel6)
        Me.frameDestination.Location = New System.Drawing.Point(20, 123)
        Me.frameDestination.Name = "frameDestination"
        Me.frameDestination.Size = New System.Drawing.Size(315, 121)
        Me.frameDestination.TabIndex = 350
        Me.frameDestination.Visible = False
        '
        'txtDestName
        '
        Me.txtDestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtDestName.Location = New System.Drawing.Point(9, 50)
        Me.txtDestName.Name = "txtDestName"
        Me.txtDestName.Size = New System.Drawing.Size(301, 23)
        Me.txtDestName.TabIndex = 228
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(9, 31)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 18)
        Me.Label43.TabIndex = 36
        Me.Label43.Text = "Destination"
        '
        'btnDestSave
        '
        Me.btnDestSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDestSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDestSave.ForeColor = System.Drawing.Color.White
        Me.btnDestSave.Location = New System.Drawing.Point(142, 83)
        Me.btnDestSave.Name = "btnDestSave"
        Me.btnDestSave.Size = New System.Drawing.Size(81, 32)
        Me.btnDestSave.TabIndex = 229
        Me.btnDestSave.Text = "&Save"
        Me.btnDestSave.UseVisualStyleBackColor = False
        '
        'btnDestCancel
        '
        Me.btnDestCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDestCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDestCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDestCancel.ForeColor = System.Drawing.Color.White
        Me.btnDestCancel.Location = New System.Drawing.Point(229, 83)
        Me.btnDestCancel.Name = "btnDestCancel"
        Me.btnDestCancel.Size = New System.Drawing.Size(81, 32)
        Me.btnDestCancel.TabIndex = 230
        Me.btnDestCancel.Text = "&Cancel"
        Me.btnDestCancel.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label44)
        Me.Panel6.Location = New System.Drawing.Point(-2, -1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(329, 28)
        Me.Panel6.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(4, 5)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(135, 18)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Add New Destination"
        '
        'lblOldDate
        '
        Me.lblOldDate.BackColor = System.Drawing.Color.White
        Me.lblOldDate.Location = New System.Drawing.Point(1273, 305)
        Me.lblOldDate.Name = "lblOldDate"
        Me.lblOldDate.Size = New System.Drawing.Size(16, 18)
        Me.lblOldDate.TabIndex = 352
        Me.lblOldDate.Visible = False
        '
        'lblOldNo
        '
        Me.lblOldNo.BackColor = System.Drawing.Color.White
        Me.lblOldNo.Location = New System.Drawing.Point(1252, 305)
        Me.lblOldNo.Name = "lblOldNo"
        Me.lblOldNo.Size = New System.Drawing.Size(18, 18)
        Me.lblOldNo.TabIndex = 351
        Me.lblOldNo.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(448, 166)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 356
        Me.Label28.Text = "HSN Code"
        '
        'txtHSN
        '
        Me.txtHSN.BackColor = System.Drawing.Color.White
        Me.txtHSN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSN.Location = New System.Drawing.Point(448, 186)
        Me.txtHSN.Name = "txtHSN"
        Me.txtHSN.Size = New System.Drawing.Size(97, 22)
        Me.txtHSN.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(268, 166)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(74, 18)
        Me.Label36.TabIndex = 355
        Me.Label36.Text = "Description"
        '
        'txtDescr
        '
        Me.txtDescr.BackColor = System.Drawing.Color.White
        Me.txtDescr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescr.Location = New System.Drawing.Point(268, 186)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(177, 22)
        Me.txtDescr.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbRCMYes)
        Me.GroupBox2.Controls.Add(Me.rbRCMNo)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(891, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(60, 77)
        Me.GroupBox2.TabIndex = 357
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RCM"
        '
        'rbRCMYes
        '
        Me.rbRCMYes.AutoSize = True
        Me.rbRCMYes.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbRCMYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbRCMYes.Location = New System.Drawing.Point(6, 45)
        Me.rbRCMYes.Name = "rbRCMYes"
        Me.rbRCMYes.Size = New System.Drawing.Size(45, 22)
        Me.rbRCMYes.TabIndex = 13
        Me.rbRCMYes.Text = "Yes"
        Me.rbRCMYes.UseVisualStyleBackColor = True
        '
        'rbRCMNo
        '
        Me.rbRCMNo.AutoSize = True
        Me.rbRCMNo.Checked = True
        Me.rbRCMNo.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRCMNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.rbRCMNo.Location = New System.Drawing.Point(6, 19)
        Me.rbRCMNo.Name = "rbRCMNo"
        Me.rbRCMNo.Size = New System.Drawing.Size(41, 22)
        Me.rbRCMNo.TabIndex = 12
        Me.rbRCMNo.TabStop = True
        Me.rbRCMNo.Text = "No"
        Me.rbRCMNo.UseVisualStyleBackColor = True
        '
        'Grid2
        '
        Me.Grid2.AllowUserToAddRows = False
        Me.Grid2.AllowUserToDeleteRows = False
        Me.Grid2.AllowUserToResizeRows = False
        Me.Grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Grid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Grid2.Location = New System.Drawing.Point(510, 277)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RowHeadersVisible = False
        Me.Grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Grid2.Size = New System.Drawing.Size(231, 166)
        Me.Grid2.TabIndex = 21
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(330, 213)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(35, 18)
        Me.Label46.TabIndex = 361
        Me.Label46.Text = "Rate"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.White
        Me.txtRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(333, 233)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(72, 22)
        Me.txtRate.TabIndex = 11
        '
        'rbTBB
        '
        Me.rbTBB.AutoSize = True
        Me.rbTBB.BackColor = System.Drawing.Color.LightBlue
        Me.rbTBB.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTBB.ForeColor = System.Drawing.Color.Maroon
        Me.rbTBB.Location = New System.Drawing.Point(217, 423)
        Me.rbTBB.Name = "rbTBB"
        Me.rbTBB.Size = New System.Drawing.Size(70, 24)
        Me.rbTBB.TabIndex = 29
        Me.rbTBB.Text = "TBB At"
        Me.rbTBB.UseVisualStyleBackColor = False
        '
        'rbPaid
        '
        Me.rbPaid.AutoSize = True
        Me.rbPaid.BackColor = System.Drawing.Color.LightBlue
        Me.rbPaid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaid.ForeColor = System.Drawing.Color.Maroon
        Me.rbPaid.Location = New System.Drawing.Point(296, 390)
        Me.rbPaid.Name = "rbPaid"
        Me.rbPaid.Size = New System.Drawing.Size(55, 24)
        Me.rbPaid.TabIndex = 28
        Me.rbPaid.Text = "Paid"
        Me.rbPaid.UseVisualStyleBackColor = False
        '
        'rbToPay
        '
        Me.rbToPay.AutoSize = True
        Me.rbToPay.BackColor = System.Drawing.Color.LightBlue
        Me.rbToPay.Checked = True
        Me.rbToPay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbToPay.ForeColor = System.Drawing.Color.Maroon
        Me.rbToPay.Location = New System.Drawing.Point(218, 391)
        Me.rbToPay.Name = "rbToPay"
        Me.rbToPay.Size = New System.Drawing.Size(70, 24)
        Me.rbToPay.TabIndex = 27
        Me.rbToPay.TabStop = True
        Me.rbToPay.Text = "To Pay"
        Me.rbToPay.UseVisualStyleBackColor = False
        '
        'cmbRemarks
        '
        Me.cmbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbRemarks.FormattingEnabled = True
        Me.cmbRemarks.Location = New System.Drawing.Point(221, 295)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(174, 24)
        Me.cmbRemarks.TabIndex = 23
        '
        'grdPrev
        '
        Me.grdPrev.AllowUserToAddRows = False
        Me.grdPrev.AllowUserToDeleteRows = False
        Me.grdPrev.AllowUserToResizeRows = False
        Me.grdPrev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdPrev.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdPrev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPrev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdPrev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdPrev.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdPrev.Location = New System.Drawing.Point(734, 66)
        Me.grdPrev.Name = "grdPrev"
        Me.grdPrev.RowHeadersVisible = False
        Me.grdPrev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdPrev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdPrev.Size = New System.Drawing.Size(430, 166)
        Me.grdPrev.TabIndex = 362
        '
        'lblRateBy
        '
        Me.lblRateBy.BackColor = System.Drawing.Color.White
        Me.lblRateBy.Location = New System.Drawing.Point(1186, 282)
        Me.lblRateBy.Name = "lblRateBy"
        Me.lblRateBy.Size = New System.Drawing.Size(17, 19)
        Me.lblRateBy.TabIndex = 363
        Me.lblRateBy.Visible = False
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1309, 646)
        Me.Controls.Add(Me.frameCNSE)
        Me.Controls.Add(Me.lblRateBy)
        Me.Controls.Add(Me.grdPrev)
        Me.Controls.Add(Me.frameCNSR)
        Me.Controls.Add(Me.cmbRemarks)
        Me.Controls.Add(Me.rbTBB)
        Me.Controls.Add(Me.rbPaid)
        Me.Controls.Add(Me.rbToPay)
        Me.Controls.Add(Me.frameDestination)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.frameTrans)
        Me.Controls.Add(Me.frameProd)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtHSN)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.lblOldDate)
        Me.Controls.Add(Me.lblOldNo)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.cmbTransporter)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbConsignee)
        Me.Controls.Add(Me.txtConsigneeCity)
        Me.Controls.Add(Me.cmbConsigner)
        Me.Controls.Add(Me.txtConsignerCity)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtTruckNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrivateMarks)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInv)
        Me.Controls.Add(Me.txtTotalChargeWeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbDestination)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblIGST)
        Me.Controls.Add(Me.lblSGST)
        Me.Controls.Add(Me.lblCGST)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIGST)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSGST)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCGST)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtTaxableAmount)
        Me.Controls.Add(Me.txtTotalActualWeight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtActualWt)
        Me.Controls.Add(Me.lblHeaderID)
        Me.Controls.Add(Me.txtTotalPackage)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtChargeWt)
        Me.Controls.Add(Me.lblHR2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPackage)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.StripPanel)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmInvoice"
        Me.Text = "frmInvoice"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StripPanel.ResumeLayout(False)
        Me.StripPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.frameGST.ResumeLayout(False)
        Me.frameGST.PerformLayout()
        Me.frameCNSR.ResumeLayout(False)
        Me.frameCNSR.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.frameCNSE.ResumeLayout(False)
        Me.frameCNSE.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.frameTrans.ResumeLayout(False)
        Me.frameTrans.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.frameProd.ResumeLayout(False)
        Me.frameProd.PerformLayout()
        Me.frameDestination.ResumeLayout(False)
        Me.frameDestination.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents lblHeaderID As System.Windows.Forms.Label
    Friend WithEvents txtTotalPackage As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtChargeWt As System.Windows.Forms.TextBox
    Friend WithEvents lblHR2 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPackage As System.Windows.Forms.TextBox
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents StripPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtActualWt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalActualWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTaxableAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCGST As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSGST As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIGST As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblSGST As System.Windows.Forms.Label
    Friend WithEvents lblCGST As System.Windows.Forms.Label
    Friend WithEvents lblIGST As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbExmptd As System.Windows.Forms.RadioButton
    Friend WithEvents rbTrans As System.Windows.Forms.RadioButton
    Friend WithEvents rbCnse As System.Windows.Forms.RadioButton
    Friend WithEvents rbCnsr As System.Windows.Forms.RadioButton
    Friend WithEvents cmbDestination As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalChargeWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPrivateMarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTruckNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbConsigner As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsignerCity As System.Windows.Forms.TextBox
    Friend WithEvents cmbConsignee As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsigneeCity As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents frameGST As System.Windows.Forms.GroupBox
    Friend WithEvents rbIGST As System.Windows.Forms.RadioButton
    Friend WithEvents rbCGST As System.Windows.Forms.RadioButton
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents frameCNSR As System.Windows.Forms.Panel
    Friend WithEvents txtAadhar As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCNSRSave As System.Windows.Forms.Button
    Friend WithEvents btnCNSRCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents frameCNSE As System.Windows.Forms.Panel
    Friend WithEvents txtAadhar2 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtGST2 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtState2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCompany2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtCity2 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCNSESave As System.Windows.Forms.Button
    Friend WithEvents btnCNSECancel As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents frameTrans As System.Windows.Forms.Panel
    Friend WithEvents txtTransMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtTransName As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents btnTransSave As System.Windows.Forms.Button
    Friend WithEvents btnTransCancel As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnSavePrint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnProdCancel As System.Windows.Forms.Button
    Friend WithEvents btnProdSave As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtProd As System.Windows.Forms.TextBox
    Friend WithEvents frameProd As System.Windows.Forms.Panel
    Friend WithEvents frameDestination As System.Windows.Forms.Panel
    Friend WithEvents txtDestName As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btnDestSave As System.Windows.Forms.Button
    Friend WithEvents btnDestCancel As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lblOldDate As System.Windows.Forms.Label
    Friend WithEvents lblOldNo As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HSNCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Packages As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActualWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtHSN As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRCMYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbRCMNo As System.Windows.Forms.RadioButton
    Friend WithEvents Grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtProdRate As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents rbTBB As System.Windows.Forms.RadioButton
    Friend WithEvents rbPaid As System.Windows.Forms.RadioButton
    Friend WithEvents rbToPay As System.Windows.Forms.RadioButton
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents grdPrev As System.Windows.Forms.DataGridView
    Friend WithEvents lblRateBy As System.Windows.Forms.Label
    Friend WithEvents rbW As System.Windows.Forms.RadioButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
End Class
