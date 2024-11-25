<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilty
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
        Me.lblSGST = New System.Windows.Forms.Label()
        Me.txtTotalActualWeight = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StripPanel = New System.Windows.Forms.Panel()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblIGST = New System.Windows.Forms.Label()
        Me.lblCGST = New System.Windows.Forms.Label()
        Me.lblHeaderID = New System.Windows.Forms.Label()
        Me.txtTotalPackage = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.cmbInvoice = New System.Windows.Forms.ComboBox()
        Me.lblHR2 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfPkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weights = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeWt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consignee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txteWayBillNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalChargeWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.lblOldDate = New System.Windows.Forms.Label()
        Me.lblOldNo = New System.Windows.Forms.Label()
        Me.frameGrid = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grdList = New System.Windows.Forms.DataGridView()
        Me.cmbTruckNo = New System.Windows.Forms.ComboBox()
        Me.cmbOwnerName = New System.Windows.Forms.ComboBox()
        Me.cmbOwnerAddress = New System.Windows.Forms.ComboBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.cmbToAddress = New System.Windows.Forms.ComboBox()
        Me.cmbDriverName = New System.Windows.Forms.ComboBox()
        Me.cmbDriverAddress = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chkALL = New System.Windows.Forms.CheckBox()
        Me.StripPanel.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameGrid.SuspendLayout()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSGST
        '
        Me.lblSGST.BackColor = System.Drawing.Color.White
        Me.lblSGST.Location = New System.Drawing.Point(911, 25)
        Me.lblSGST.Name = "lblSGST"
        Me.lblSGST.Size = New System.Drawing.Size(16, 18)
        Me.lblSGST.TabIndex = 361
        Me.lblSGST.Visible = False
        '
        'txtTotalActualWeight
        '
        Me.txtTotalActualWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalActualWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalActualWeight.Location = New System.Drawing.Point(551, 462)
        Me.txtTotalActualWeight.Name = "txtTotalActualWeight"
        Me.txtTotalActualWeight.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalActualWeight.TabIndex = 348
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = "dd/MM/yyyy"
        Me.txtDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(98, 82)
        Me.txtDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(91, 22)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Value = New Date(2014, 4, 26, 0, 0, 0, 0)
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(98, 54)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(91, 22)
        Me.txtInvoiceNo.TabIndex = 322
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(981, 22)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 18)
        Me.lblID.TabIndex = 333
        Me.lblID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(895, 494)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 38)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(808, 494)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 38)
        Me.btnSave.TabIndex = 12
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
        Me.StripPanel.TabIndex = 331
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(12, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(80, 22)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Challan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 332
        Me.Label2.Text = "Challan No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(32, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 18)
        Me.Label11.TabIndex = 335
        Me.Label11.Text = "Date"
        '
        'lblIGST
        '
        Me.lblIGST.BackColor = System.Drawing.Color.White
        Me.lblIGST.Location = New System.Drawing.Point(933, 25)
        Me.lblIGST.Name = "lblIGST"
        Me.lblIGST.Size = New System.Drawing.Size(16, 18)
        Me.lblIGST.TabIndex = 362
        Me.lblIGST.Visible = False
        '
        'lblCGST
        '
        Me.lblCGST.BackColor = System.Drawing.Color.White
        Me.lblCGST.Location = New System.Drawing.Point(892, 25)
        Me.lblCGST.Name = "lblCGST"
        Me.lblCGST.Size = New System.Drawing.Size(16, 18)
        Me.lblCGST.TabIndex = 360
        Me.lblCGST.Visible = False
        '
        'lblHeaderID
        '
        Me.lblHeaderID.BackColor = System.Drawing.Color.White
        Me.lblHeaderID.Location = New System.Drawing.Point(955, 24)
        Me.lblHeaderID.Name = "lblHeaderID"
        Me.lblHeaderID.Size = New System.Drawing.Size(20, 19)
        Me.lblHeaderID.TabIndex = 345
        Me.lblHeaderID.Visible = False
        '
        'txtTotalPackage
        '
        Me.txtTotalPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalPackage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPackage.Location = New System.Drawing.Point(481, 462)
        Me.txtTotalPackage.Name = "txtTotalPackage"
        Me.txtTotalPackage.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalPackage.TabIndex = 341
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(818, 462)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(104, 22)
        Me.txtTotalAmount.TabIndex = 340
        '
        'cmbInvoice
        '
        Me.cmbInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbInvoice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInvoice.FormattingEnabled = True
        Me.cmbInvoice.Location = New System.Drawing.Point(556, 499)
        Me.cmbInvoice.Name = "cmbInvoice"
        Me.cmbInvoice.Size = New System.Drawing.Size(44, 24)
        Me.cmbInvoice.TabIndex = 9
        Me.cmbInvoice.Visible = False
        '
        'lblHR2
        '
        Me.lblHR2.BackColor = System.Drawing.Color.DimGray
        Me.lblHR2.Location = New System.Drawing.Point(33, 486)
        Me.lblHR2.Name = "lblHR2"
        Me.lblHR2.Size = New System.Drawing.Size(900, 1)
        Me.lblHR2.TabIndex = 342
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(1006, 111)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(10, 14)
        Me.btnDel.TabIndex = 11
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
        Me.btnAdd.Location = New System.Drawing.Point(990, 111)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(10, 15)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(453, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 368
        Me.Label6.Text = "Owner's Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(194, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 367
        Me.Label7.Text = "Driver Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(193, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "Truck No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(453, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 18)
        Me.Label12.TabIndex = 370
        Me.Label12.Text = "Owner's Address"
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
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.CNNo, Me.Dated, Me.Product, Me.NoOfPkg, Me.Weights, Me.ChargeWt, Me.Destination, Me.Consignee, Me.Amounts})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.Location = New System.Drawing.Point(30, 195)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(946, 261)
        Me.Grid.TabIndex = 371
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'CNNo
        '
        Me.CNNo.HeaderText = "C.N. No"
        Me.CNNo.Name = "CNNo"
        '
        'Dated
        '
        Me.Dated.HeaderText = "Dated"
        Me.Dated.Name = "Dated"
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        '
        'NoOfPkg
        '
        Me.NoOfPkg.HeaderText = "No Of Pkg"
        Me.NoOfPkg.Name = "NoOfPkg"
        '
        'Weights
        '
        Me.Weights.HeaderText = "Actual Wt."
        Me.Weights.Name = "Weights"
        '
        'ChargeWt
        '
        Me.ChargeWt.HeaderText = "Charge Wt."
        Me.ChargeWt.Name = "ChargeWt"
        '
        'Destination
        '
        Me.Destination.HeaderText = "Destination"
        Me.Destination.Name = "Destination"
        '
        'Consignee
        '
        Me.Consignee.HeaderText = "Consignee"
        Me.Consignee.Name = "Consignee"
        '
        'Amounts
        '
        Me.Amounts.HeaderText = "Amount"
        Me.Amounts.Name = "Amounts"
        '
        'txteWayBillNo
        '
        Me.txteWayBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteWayBillNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txteWayBillNo.Location = New System.Drawing.Point(556, 111)
        Me.txteWayBillNo.Name = "txteWayBillNo"
        Me.txteWayBillNo.Size = New System.Drawing.Size(302, 23)
        Me.txteWayBillNo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(453, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "CEWB No"
        '
        'txtTotalChargeWeight
        '
        Me.txtTotalChargeWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalChargeWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalChargeWeight.Location = New System.Drawing.Point(621, 462)
        Me.txtTotalChargeWeight.Name = "txtTotalChargeWeight"
        Me.txtTotalChargeWeight.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalChargeWeight.TabIndex = 374
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(389, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 18)
        Me.Label4.TabIndex = 376
        Me.Label4.Text = "To "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 380
        Me.Label5.Text = "Driver Address"
        '
        'btnSavePrint
        '
        Me.btnSavePrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSavePrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.ForeColor = System.Drawing.Color.White
        Me.btnSavePrint.Location = New System.Drawing.Point(689, 494)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(113, 38)
        Me.btnSavePrint.TabIndex = 381
        Me.btnSavePrint.Text = "Save && &Print"
        Me.btnSavePrint.UseVisualStyleBackColor = False
        '
        'lblOldDate
        '
        Me.lblOldDate.BackColor = System.Drawing.Color.White
        Me.lblOldDate.Location = New System.Drawing.Point(938, 86)
        Me.lblOldDate.Name = "lblOldDate"
        Me.lblOldDate.Size = New System.Drawing.Size(16, 18)
        Me.lblOldDate.TabIndex = 383
        Me.lblOldDate.Visible = False
        '
        'lblOldNo
        '
        Me.lblOldNo.BackColor = System.Drawing.Color.White
        Me.lblOldNo.Location = New System.Drawing.Point(917, 86)
        Me.lblOldNo.Name = "lblOldNo"
        Me.lblOldNo.Size = New System.Drawing.Size(18, 18)
        Me.lblOldNo.TabIndex = 382
        Me.lblOldNo.Visible = False
        '
        'frameGrid
        '
        Me.frameGrid.Controls.Add(Me.btnClose)
        Me.frameGrid.Controls.Add(Me.grdList)
        Me.frameGrid.Location = New System.Drawing.Point(984, 137)
        Me.frameGrid.Name = "frameGrid"
        Me.frameGrid.Size = New System.Drawing.Size(974, 293)
        Me.frameGrid.TabIndex = 385
        Me.frameGrid.TabStop = False
        Me.frameGrid.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(8, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(960, 26)
        Me.btnClose.TabIndex = 386
        Me.btnClose.Text = "C  L  O  S  E"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'grdList
        '
        Me.grdList.AllowUserToAddRows = False
        Me.grdList.AllowUserToDeleteRows = False
        Me.grdList.AllowUserToResizeRows = False
        Me.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.grdList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdList.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdList.Location = New System.Drawing.Point(8, 12)
        Me.grdList.Name = "grdList"
        Me.grdList.ReadOnly = True
        Me.grdList.RowHeadersVisible = False
        Me.grdList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdList.Size = New System.Drawing.Size(960, 243)
        Me.grdList.TabIndex = 385
        '
        'cmbTruckNo
        '
        Me.cmbTruckNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTruckNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTruckNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTruckNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbTruckNo.FormattingEnabled = True
        Me.cmbTruckNo.Location = New System.Drawing.Point(281, 54)
        Me.cmbTruckNo.Name = "cmbTruckNo"
        Me.cmbTruckNo.Size = New System.Drawing.Size(162, 24)
        Me.cmbTruckNo.TabIndex = 1
        '
        'cmbOwnerName
        '
        Me.cmbOwnerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOwnerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOwnerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOwnerName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbOwnerName.FormattingEnabled = True
        Me.cmbOwnerName.Location = New System.Drawing.Point(556, 52)
        Me.cmbOwnerName.Name = "cmbOwnerName"
        Me.cmbOwnerName.Size = New System.Drawing.Size(302, 24)
        Me.cmbOwnerName.TabIndex = 4
        '
        'cmbOwnerAddress
        '
        Me.cmbOwnerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOwnerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOwnerAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOwnerAddress.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbOwnerAddress.FormattingEnabled = True
        Me.cmbOwnerAddress.Location = New System.Drawing.Point(556, 81)
        Me.cmbOwnerAddress.Name = "cmbOwnerAddress"
        Me.cmbOwnerAddress.Size = New System.Drawing.Size(302, 24)
        Me.cmbOwnerAddress.TabIndex = 5
        '
        'cmbTo
        '
        Me.cmbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(55, 139)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(331, 24)
        Me.cmbTo.TabIndex = 7
        '
        'cmbToAddress
        '
        Me.cmbToAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbToAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbToAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbToAddress.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbToAddress.FormattingEnabled = True
        Me.cmbToAddress.Location = New System.Drawing.Point(449, 139)
        Me.cmbToAddress.Name = "cmbToAddress"
        Me.cmbToAddress.Size = New System.Drawing.Size(409, 24)
        Me.cmbToAddress.TabIndex = 8
        '
        'cmbDriverName
        '
        Me.cmbDriverName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDriverName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDriverName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDriverName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbDriverName.FormattingEnabled = True
        Me.cmbDriverName.Location = New System.Drawing.Point(281, 82)
        Me.cmbDriverName.Name = "cmbDriverName"
        Me.cmbDriverName.Size = New System.Drawing.Size(162, 24)
        Me.cmbDriverName.TabIndex = 2
        '
        'cmbDriverAddress
        '
        Me.cmbDriverAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDriverAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDriverAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDriverAddress.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbDriverAddress.FormattingEnabled = True
        Me.cmbDriverAddress.Location = New System.Drawing.Point(125, 111)
        Me.cmbDriverAddress.Name = "cmbDriverAddress"
        Me.cmbDriverAddress.Size = New System.Drawing.Size(318, 24)
        Me.cmbDriverAddress.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(375, 490)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(32, 19)
        Me.btnCalc.TabIndex = 386
        Me.btnCalc.Text = "&Save"
        Me.btnCalc.UseVisualStyleBackColor = False
        Me.btnCalc.Visible = False
        '
        'chkALL
        '
        Me.chkALL.AutoSize = True
        Me.chkALL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkALL.Location = New System.Drawing.Point(35, 174)
        Me.chkALL.Name = "chkALL"
        Me.chkALL.Size = New System.Drawing.Size(87, 17)
        Me.chkALL.TabIndex = 387
        Me.chkALL.Text = "Select All"
        Me.chkALL.UseVisualStyleBackColor = True
        '
        'frmBilty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1129, 555)
        Me.Controls.Add(Me.chkALL)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cmbDriverAddress)
        Me.Controls.Add(Me.cmbDriverName)
        Me.Controls.Add(Me.cmbToAddress)
        Me.Controls.Add(Me.cmbTo)
        Me.Controls.Add(Me.cmbOwnerAddress)
        Me.Controls.Add(Me.cmbOwnerName)
        Me.Controls.Add(Me.cmbTruckNo)
        Me.Controls.Add(Me.frameGrid)
        Me.Controls.Add(Me.lblOldDate)
        Me.Controls.Add(Me.lblOldNo)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalChargeWeight)
        Me.Controls.Add(Me.txteWayBillNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSGST)
        Me.Controls.Add(Me.txtTotalActualWeight)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.StripPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblIGST)
        Me.Controls.Add(Me.lblCGST)
        Me.Controls.Add(Me.lblHeaderID)
        Me.Controls.Add(Me.txtTotalPackage)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.cmbInvoice)
        Me.Controls.Add(Me.lblHR2)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBilty"
        Me.Text = "frmBilty"
        Me.StripPanel.ResumeLayout(False)
        Me.StripPanel.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameGrid.ResumeLayout(False)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSGST As System.Windows.Forms.Label
    Friend WithEvents txtTotalActualWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents StripPanel As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblIGST As System.Windows.Forms.Label
    Friend WithEvents lblCGST As System.Windows.Forms.Label
    Friend WithEvents lblHeaderID As System.Windows.Forms.Label
    Friend WithEvents txtTotalPackage As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbInvoice As System.Windows.Forms.ComboBox
    Friend WithEvents lblHR2 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents txteWayBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfPkg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weights As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consignee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amounts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalChargeWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSavePrint As System.Windows.Forms.Button
    Friend WithEvents lblOldDate As System.Windows.Forms.Label
    Friend WithEvents lblOldNo As System.Windows.Forms.Label
    Friend WithEvents frameGrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grdList As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTruckNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOwnerName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOwnerAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbToAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDriverName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDriverAddress As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents chkALL As System.Windows.Forms.CheckBox
End Class
