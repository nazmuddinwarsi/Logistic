<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceList
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
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.StripPanel = New System.Windows.Forms.Panel()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Grid2 = New System.Windows.Forms.DataGridView()
        Me.framePrint = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDriver = New System.Windows.Forms.CheckBox()
        Me.chkConsignee = New System.Windows.Forms.CheckBox()
        Me.chkConsigner = New System.Windows.Forms.CheckBox()
        Me.btnPrintPrint = New System.Windows.Forms.Button()
        Me.btnPrintCancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.frameSearch = New System.Windows.Forms.Panel()
        Me.chkAllDate = New System.Windows.Forms.CheckBox()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTAll = New System.Windows.Forms.RadioButton()
        Me.rbTOthers = New System.Windows.Forms.RadioButton()
        Me.rbTKanpur = New System.Windows.Forms.RadioButton()
        Me.cmbDestination = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCancelNO = New System.Windows.Forms.RadioButton()
        Me.rbCancelYES = New System.Windows.Forms.RadioButton()
        Me.frameOf = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbTBB = New System.Windows.Forms.RadioButton()
        Me.rbPaid = New System.Windows.Forms.RadioButton()
        Me.rbToPay = New System.Windows.Forms.RadioButton()
        Me.cmbConsignee = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFromDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbConsigner = New System.Windows.Forms.ComboBox()
        Me.txtInvNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.frameEdit = New System.Windows.Forms.Panel()
        Me.btnEditFrame = New System.Windows.Forms.Button()
        Me.btnOnlineFrame = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StripPanel.SuspendLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.framePrint.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.frameSearch.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.frameOf.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.frameEdit.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.Location = New System.Drawing.Point(0, 86)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(780, 263)
        Me.Grid.TabIndex = 38
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(497, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(48, 21)
        Me.lblID.TabIndex = 40
        Me.lblID.Visible = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(551, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 21)
        Me.lblName.TabIndex = 41
        Me.lblName.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator3, Me.btnSearch, Me.ToolStripSeparator4, Me.btnPrint, Me.ToolStripSeparator5, Me.btnInvoice, Me.ToolStripSeparator6, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(209, 25)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnAdd.Text = "Add New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(23, 22)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnInvoice
        '
        Me.btnInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(23, 22)
        Me.btnInvoice.Text = "Invoice"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'StripPanel
        '
        Me.StripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StripPanel.Controls.Add(Me.lblCaption)
        Me.StripPanel.Location = New System.Drawing.Point(0, 0)
        Me.StripPanel.Name = "StripPanel"
        Me.StripPanel.Size = New System.Drawing.Size(473, 43)
        Me.StripPanel.TabIndex = 37
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(12, 12)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(90, 22)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Bilty List"
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
        Me.Grid2.Location = New System.Drawing.Point(0, 362)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.ReadOnly = True
        Me.Grid2.RowHeadersVisible = False
        Me.Grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid2.Size = New System.Drawing.Size(845, 165)
        Me.Grid2.TabIndex = 43
        '
        'framePrint
        '
        Me.framePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.framePrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.framePrint.Controls.Add(Me.GroupBox1)
        Me.framePrint.Controls.Add(Me.btnPrintPrint)
        Me.framePrint.Controls.Add(Me.btnPrintCancel)
        Me.framePrint.Controls.Add(Me.Panel3)
        Me.framePrint.Location = New System.Drawing.Point(109, 199)
        Me.framePrint.Name = "framePrint"
        Me.framePrint.Size = New System.Drawing.Size(385, 131)
        Me.framePrint.TabIndex = 44
        Me.framePrint.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDriver)
        Me.GroupBox1.Controls.Add(Me.chkConsignee)
        Me.GroupBox1.Controls.Add(Me.chkConsigner)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 54)
        Me.GroupBox1.TabIndex = 296
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print"
        '
        'chkDriver
        '
        Me.chkDriver.AutoSize = True
        Me.chkDriver.Checked = True
        Me.chkDriver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDriver.Location = New System.Drawing.Point(261, 22)
        Me.chkDriver.Name = "chkDriver"
        Me.chkDriver.Size = New System.Drawing.Size(99, 22)
        Me.chkDriver.TabIndex = 58
        Me.chkDriver.Text = "Driver Copy"
        Me.chkDriver.UseVisualStyleBackColor = True
        '
        'chkConsignee
        '
        Me.chkConsignee.AutoSize = True
        Me.chkConsignee.Checked = True
        Me.chkConsignee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConsignee.Location = New System.Drawing.Point(133, 22)
        Me.chkConsignee.Name = "chkConsignee"
        Me.chkConsignee.Size = New System.Drawing.Size(123, 22)
        Me.chkConsignee.TabIndex = 57
        Me.chkConsignee.Text = "Consignee Copy"
        Me.chkConsignee.UseVisualStyleBackColor = True
        '
        'chkConsigner
        '
        Me.chkConsigner.AutoSize = True
        Me.chkConsigner.Location = New System.Drawing.Point(6, 22)
        Me.chkConsigner.Name = "chkConsigner"
        Me.chkConsigner.Size = New System.Drawing.Size(122, 22)
        Me.chkConsigner.TabIndex = 56
        Me.chkConsigner.Text = "Consignor Copy"
        Me.chkConsigner.UseVisualStyleBackColor = True
        '
        'btnPrintPrint
        '
        Me.btnPrintPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPrintPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrintPrint.Location = New System.Drawing.Point(206, 94)
        Me.btnPrintPrint.Name = "btnPrintPrint"
        Me.btnPrintPrint.Size = New System.Drawing.Size(81, 26)
        Me.btnPrintPrint.TabIndex = 33
        Me.btnPrintPrint.Text = "&Print"
        Me.btnPrintPrint.UseVisualStyleBackColor = False
        '
        'btnPrintCancel
        '
        Me.btnPrintCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPrintCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCancel.ForeColor = System.Drawing.Color.White
        Me.btnPrintCancel.Location = New System.Drawing.Point(293, 94)
        Me.btnPrintCancel.Name = "btnPrintCancel"
        Me.btnPrintCancel.Size = New System.Drawing.Size(81, 26)
        Me.btnPrintCancel.TabIndex = 34
        Me.btnPrintCancel.Text = "&Cancel"
        Me.btnPrintCancel.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(-1, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 28)
        Me.Panel3.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Print"
        '
        'frameSearch
        '
        Me.frameSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.frameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameSearch.Controls.Add(Me.chkAllDate)
        Me.frameSearch.Controls.Add(Me.txtBillNo)
        Me.frameSearch.Controls.Add(Me.Label9)
        Me.frameSearch.Controls.Add(Me.GroupBox3)
        Me.frameSearch.Controls.Add(Me.cmbDestination)
        Me.frameSearch.Controls.Add(Me.Label7)
        Me.frameSearch.Controls.Add(Me.GroupBox2)
        Me.frameSearch.Controls.Add(Me.frameOf)
        Me.frameSearch.Controls.Add(Me.cmbConsignee)
        Me.frameSearch.Controls.Add(Me.txtName)
        Me.frameSearch.Controls.Add(Me.Label5)
        Me.frameSearch.Controls.Add(Me.Label6)
        Me.frameSearch.Controls.Add(Me.Label4)
        Me.frameSearch.Controls.Add(Me.txtToDate)
        Me.frameSearch.Controls.Add(Me.Label3)
        Me.frameSearch.Controls.Add(Me.txtFromDate)
        Me.frameSearch.Controls.Add(Me.btnSave)
        Me.frameSearch.Controls.Add(Me.btnCancel)
        Me.frameSearch.Controls.Add(Me.cmbConsigner)
        Me.frameSearch.Controls.Add(Me.txtInvNo)
        Me.frameSearch.Controls.Add(Me.Label8)
        Me.frameSearch.Controls.Add(Me.Label2)
        Me.frameSearch.Controls.Add(Me.Panel2)
        Me.frameSearch.Location = New System.Drawing.Point(147, 97)
        Me.frameSearch.Name = "frameSearch"
        Me.frameSearch.Size = New System.Drawing.Size(469, 333)
        Me.frameSearch.TabIndex = 45
        '
        'chkAllDate
        '
        Me.chkAllDate.AutoSize = True
        Me.chkAllDate.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.chkAllDate.ForeColor = System.Drawing.Color.White
        Me.chkAllDate.Location = New System.Drawing.Point(326, 48)
        Me.chkAllDate.Name = "chkAllDate"
        Me.chkAllDate.Size = New System.Drawing.Size(73, 20)
        Me.chkAllDate.TabIndex = 303
        Me.chkAllDate.Text = "All Date"
        Me.chkAllDate.UseVisualStyleBackColor = True
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(112, 93)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(88, 22)
        Me.txtBillNo.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(109, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 302
        Me.Label9.Text = "Party Inv No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTAll)
        Me.GroupBox3.Controls.Add(Me.rbTOthers)
        Me.GroupBox3.Controls.Add(Me.rbTKanpur)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(5, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 48)
        Me.GroupBox3.TabIndex = 300
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transit"
        '
        'rbTAll
        '
        Me.rbTAll.AutoSize = True
        Me.rbTAll.Checked = True
        Me.rbTAll.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTAll.ForeColor = System.Drawing.Color.White
        Me.rbTAll.Location = New System.Drawing.Point(6, 22)
        Me.rbTAll.Name = "rbTAll"
        Me.rbTAll.Size = New System.Drawing.Size(49, 22)
        Me.rbTAll.TabIndex = 56
        Me.rbTAll.TabStop = True
        Me.rbTAll.Text = "ALL "
        Me.rbTAll.UseVisualStyleBackColor = True
        '
        'rbTOthers
        '
        Me.rbTOthers.AutoSize = True
        Me.rbTOthers.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbTOthers.ForeColor = System.Drawing.Color.White
        Me.rbTOthers.Location = New System.Drawing.Point(127, 22)
        Me.rbTOthers.Name = "rbTOthers"
        Me.rbTOthers.Size = New System.Drawing.Size(64, 22)
        Me.rbTOthers.TabIndex = 54
        Me.rbTOthers.Text = "Others"
        Me.rbTOthers.UseVisualStyleBackColor = True
        '
        'rbTKanpur
        '
        Me.rbTKanpur.AutoSize = True
        Me.rbTKanpur.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTKanpur.ForeColor = System.Drawing.Color.White
        Me.rbTKanpur.Location = New System.Drawing.Point(62, 22)
        Me.rbTKanpur.Name = "rbTKanpur"
        Me.rbTKanpur.Size = New System.Drawing.Size(65, 22)
        Me.rbTKanpur.TabIndex = 53
        Me.rbTKanpur.Text = "Kanpur"
        Me.rbTKanpur.UseVisualStyleBackColor = True
        '
        'cmbDestination
        '
        Me.cmbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDestination.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDestination.FormattingEnabled = True
        Me.cmbDestination.Location = New System.Drawing.Point(205, 184)
        Me.cmbDestination.Name = "cmbDestination"
        Me.cmbDestination.Size = New System.Drawing.Size(252, 24)
        Me.cmbDestination.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(202, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 299
        Me.Label7.Text = "Destination"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCancelNO)
        Me.GroupBox2.Controls.Add(Me.rbCancelYES)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(320, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 49)
        Me.GroupBox2.TabIndex = 297
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cancelled"
        '
        'rbCancelNO
        '
        Me.rbCancelNO.AutoSize = True
        Me.rbCancelNO.Checked = True
        Me.rbCancelNO.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCancelNO.ForeColor = System.Drawing.Color.White
        Me.rbCancelNO.Location = New System.Drawing.Point(6, 22)
        Me.rbCancelNO.Name = "rbCancelNO"
        Me.rbCancelNO.Size = New System.Drawing.Size(43, 22)
        Me.rbCancelNO.TabIndex = 56
        Me.rbCancelNO.TabStop = True
        Me.rbCancelNO.Text = "NO"
        Me.rbCancelNO.UseVisualStyleBackColor = True
        '
        'rbCancelYES
        '
        Me.rbCancelYES.AutoSize = True
        Me.rbCancelYES.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCancelYES.ForeColor = System.Drawing.Color.White
        Me.rbCancelYES.Location = New System.Drawing.Point(69, 22)
        Me.rbCancelYES.Name = "rbCancelYES"
        Me.rbCancelYES.Size = New System.Drawing.Size(45, 22)
        Me.rbCancelYES.TabIndex = 53
        Me.rbCancelYES.Text = "YES"
        Me.rbCancelYES.UseVisualStyleBackColor = True
        '
        'frameOf
        '
        Me.frameOf.Controls.Add(Me.rbAll)
        Me.frameOf.Controls.Add(Me.rbTBB)
        Me.frameOf.Controls.Add(Me.rbPaid)
        Me.frameOf.Controls.Add(Me.rbToPay)
        Me.frameOf.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.frameOf.ForeColor = System.Drawing.Color.White
        Me.frameOf.Location = New System.Drawing.Point(6, 216)
        Me.frameOf.Name = "frameOf"
        Me.frameOf.Size = New System.Drawing.Size(280, 49)
        Me.frameOf.TabIndex = 296
        Me.frameOf.TabStop = False
        Me.frameOf.Text = "Booking Type"
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAll.ForeColor = System.Drawing.Color.White
        Me.rbAll.Location = New System.Drawing.Point(6, 22)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(49, 22)
        Me.rbAll.TabIndex = 56
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "ALL "
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbTBB
        '
        Me.rbTBB.AutoSize = True
        Me.rbTBB.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbTBB.ForeColor = System.Drawing.Color.White
        Me.rbTBB.Location = New System.Drawing.Point(209, 22)
        Me.rbTBB.Name = "rbTBB"
        Me.rbTBB.Size = New System.Drawing.Size(62, 22)
        Me.rbTBB.TabIndex = 55
        Me.rbTBB.Text = "TBB At"
        Me.rbTBB.UseVisualStyleBackColor = True
        '
        'rbPaid
        '
        Me.rbPaid.AutoSize = True
        Me.rbPaid.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.rbPaid.ForeColor = System.Drawing.Color.White
        Me.rbPaid.Location = New System.Drawing.Point(146, 22)
        Me.rbPaid.Name = "rbPaid"
        Me.rbPaid.Size = New System.Drawing.Size(48, 22)
        Me.rbPaid.TabIndex = 54
        Me.rbPaid.Text = "Paid"
        Me.rbPaid.UseVisualStyleBackColor = True
        '
        'rbToPay
        '
        Me.rbToPay.AutoSize = True
        Me.rbToPay.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbToPay.ForeColor = System.Drawing.Color.White
        Me.rbToPay.Location = New System.Drawing.Point(69, 22)
        Me.rbToPay.Name = "rbToPay"
        Me.rbToPay.Size = New System.Drawing.Size(61, 22)
        Me.rbToPay.TabIndex = 53
        Me.rbToPay.Text = "To Pay"
        Me.rbToPay.UseVisualStyleBackColor = True
        '
        'cmbConsignee
        '
        Me.cmbConsignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbConsignee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConsignee.FormattingEnabled = True
        Me.cmbConsignee.Location = New System.Drawing.Point(206, 137)
        Me.cmbConsignee.Name = "cmbConsignee"
        Me.cmbConsignee.Size = New System.Drawing.Size(252, 24)
        Me.cmbConsignee.TabIndex = 33
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(6, 139)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 22)
        Me.txtName.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(203, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Consignee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(203, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "To Date"
        '
        'txtToDate
        '
        Me.txtToDate.CustomFormat = "dd/MM/yyyy"
        Me.txtToDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtToDate.Location = New System.Drawing.Point(206, 48)
        Me.txtToDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(107, 22)
        Me.txtToDate.TabIndex = 28
        Me.txtToDate.Value = New Date(2014, 4, 26, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "From Date"
        '
        'txtFromDate
        '
        Me.txtFromDate.CustomFormat = "dd/MM/yyyy"
        Me.txtFromDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFromDate.Location = New System.Drawing.Point(6, 48)
        Me.txtFromDate.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(107, 22)
        Me.txtFromDate.TabIndex = 27
        Me.txtFromDate.Value = New Date(2014, 4, 26, 0, 0, 0, 0)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(289, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 47)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "&Search"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(376, 277)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 47)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cmbConsigner
        '
        Me.cmbConsigner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsigner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbConsigner.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConsigner.FormattingEnabled = True
        Me.cmbConsigner.Location = New System.Drawing.Point(206, 93)
        Me.cmbConsigner.Name = "cmbConsigner"
        Me.cmbConsigner.Size = New System.Drawing.Size(252, 24)
        Me.cmbConsigner.TabIndex = 31
        '
        'txtInvNo
        '
        Me.txtInvNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvNo.Location = New System.Drawing.Point(6, 93)
        Me.txtInvNo.Name = "txtInvNo"
        Me.txtInvNo.Size = New System.Drawing.Size(88, 22)
        Me.txtInvNo.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(203, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Consigner Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Invoice No"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 28)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'frameEdit
        '
        Me.frameEdit.BackColor = System.Drawing.Color.Chocolate
        Me.frameEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameEdit.Controls.Add(Me.btnEditFrame)
        Me.frameEdit.Controls.Add(Me.btnOnlineFrame)
        Me.frameEdit.Controls.Add(Me.Panel5)
        Me.frameEdit.Location = New System.Drawing.Point(119, 160)
        Me.frameEdit.Name = "frameEdit"
        Me.frameEdit.Size = New System.Drawing.Size(231, 97)
        Me.frameEdit.TabIndex = 52
        Me.frameEdit.Visible = False
        '
        'btnEditFrame
        '
        Me.btnEditFrame.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEditFrame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditFrame.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditFrame.ForeColor = System.Drawing.Color.White
        Me.btnEditFrame.Location = New System.Drawing.Point(16, 44)
        Me.btnEditFrame.Name = "btnEditFrame"
        Me.btnEditFrame.Size = New System.Drawing.Size(94, 41)
        Me.btnEditFrame.TabIndex = 33
        Me.btnEditFrame.Text = "E&dit"
        Me.btnEditFrame.UseVisualStyleBackColor = False
        '
        'btnOnlineFrame
        '
        Me.btnOnlineFrame.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnOnlineFrame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnlineFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOnlineFrame.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnlineFrame.ForeColor = System.Drawing.Color.White
        Me.btnOnlineFrame.Location = New System.Drawing.Point(116, 44)
        Me.btnOnlineFrame.Name = "btnOnlineFrame"
        Me.btnOnlineFrame.Size = New System.Drawing.Size(94, 41)
        Me.btnOnlineFrame.TabIndex = 34
        Me.btnOnlineFrame.Text = "Post Online"
        Me.btnOnlineFrame.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.Controls.Add(Me.lblClose)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(-1, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 28)
        Me.Panel5.TabIndex = 6
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(207, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(24, 24)
        Me.lblClose.TabIndex = 35
        Me.lblClose.Text = "X"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "eLozics"
        '
        'frmInvoiceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(979, 524)
        Me.Controls.Add(Me.frameEdit)
        Me.Controls.Add(Me.framePrint)
        Me.Controls.Add(Me.frameSearch)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StripPanel)
        Me.Controls.Add(Me.Grid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmInvoiceList"
        Me.Text = "frmInvoiceList"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StripPanel.ResumeLayout(False)
        Me.StripPanel.PerformLayout()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.framePrint.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.frameSearch.ResumeLayout(False)
        Me.frameSearch.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frameOf.ResumeLayout(False)
        Me.frameOf.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.frameEdit.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents StripPanel As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents Grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents framePrint As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDriver As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsignee As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsigner As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrintPrint As System.Windows.Forms.Button
    Friend WithEvents btnPrintCancel As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents frameSearch As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbTOthers As System.Windows.Forms.RadioButton
    Friend WithEvents rbTKanpur As System.Windows.Forms.RadioButton
    Friend WithEvents cmbDestination As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCancelNO As System.Windows.Forms.RadioButton
    Friend WithEvents rbCancelYES As System.Windows.Forms.RadioButton
    Friend WithEvents frameOf As System.Windows.Forms.GroupBox
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbTBB As System.Windows.Forms.RadioButton
    Friend WithEvents rbPaid As System.Windows.Forms.RadioButton
    Friend WithEvents rbToPay As System.Windows.Forms.RadioButton
    Friend WithEvents cmbConsignee As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbConsigner As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents frameEdit As System.Windows.Forms.Panel
    Friend WithEvents btnEditFrame As System.Windows.Forms.Button
    Friend WithEvents btnOnlineFrame As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkAllDate As System.Windows.Forms.CheckBox
End Class
