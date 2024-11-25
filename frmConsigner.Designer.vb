<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsigner
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.frameSearch = New System.Windows.Forms.Panel()
        Me.txtAadharNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StripPanel = New System.Windows.Forms.Panel()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.frameSearch2 = New System.Windows.Forms.Panel()
        Me.txtSMobile = New System.Windows.Forms.TextBox()
        Me.txtSGST = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch2 = New System.Windows.Forms.Button()
        Me.btnSearchCancel = New System.Windows.Forms.Button()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameSearch.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StripPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.frameSearch2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(661, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 21)
        Me.lblName.TabIndex = 75
        Me.lblName.Visible = False
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(698, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(48, 21)
        Me.lblID.TabIndex = 74
        Me.lblID.Visible = False
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
        Me.Grid.Location = New System.Drawing.Point(0, 85)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(780, 352)
        Me.Grid.TabIndex = 72
        '
        'frameSearch
        '
        Me.frameSearch.BackColor = System.Drawing.Color.LightBlue
        Me.frameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameSearch.Controls.Add(Me.txtAadharNo)
        Me.frameSearch.Controls.Add(Me.Label4)
        Me.frameSearch.Controls.Add(Me.txtGST)
        Me.frameSearch.Controls.Add(Me.Label3)
        Me.frameSearch.Controls.Add(Me.txtState)
        Me.frameSearch.Controls.Add(Me.Label10)
        Me.frameSearch.Controls.Add(Me.txtCompany)
        Me.frameSearch.Controls.Add(Me.Label6)
        Me.frameSearch.Controls.Add(Me.txtMobileNo)
        Me.frameSearch.Controls.Add(Me.Label7)
        Me.frameSearch.Controls.Add(Me.txtCity)
        Me.frameSearch.Controls.Add(Me.Label8)
        Me.frameSearch.Controls.Add(Me.txtAddress)
        Me.frameSearch.Controls.Add(Me.txtName)
        Me.frameSearch.Controls.Add(Me.btnSave)
        Me.frameSearch.Controls.Add(Me.btnCancel)
        Me.frameSearch.Controls.Add(Me.Panel2)
        Me.frameSearch.Location = New System.Drawing.Point(198, 131)
        Me.frameSearch.Name = "frameSearch"
        Me.frameSearch.Size = New System.Drawing.Size(409, 218)
        Me.frameSearch.TabIndex = 77
        Me.frameSearch.Visible = False
        '
        'txtAadharNo
        '
        Me.txtAadharNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAadharNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAadharNo.Location = New System.Drawing.Point(114, 148)
        Me.txtAadharNo.Name = "txtAadharNo"
        Me.txtAadharNo.Size = New System.Drawing.Size(284, 23)
        Me.txtAadharNo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "Aadhar No"
        '
        'txtGST
        '
        Me.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGST.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtGST.Location = New System.Drawing.Point(114, 121)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(284, 23)
        Me.txtGST.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "GSTin No"
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtState.Location = New System.Drawing.Point(291, 65)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(105, 23)
        Me.txtState.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(252, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 18)
        Me.Label10.TabIndex = 209
        Me.Label10.Text = "State"
        '
        'txtCompany
        '
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCompany.Location = New System.Drawing.Point(114, 38)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(282, 23)
        Me.txtCompany.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Company Name"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtMobileNo.Location = New System.Drawing.Point(114, 93)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(284, 23)
        Me.txtMobileNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Mobile No"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtCity.Location = New System.Drawing.Point(114, 65)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 23)
        Me.txtCity.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAddress.Location = New System.Drawing.Point(136, 182)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(16, 23)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Visible = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtName.Location = New System.Drawing.Point(114, 182)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(16, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(228, 177)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 32)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(315, 177)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 32)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 28)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add / Edit Consignor"
        '
        'StripPanel
        '
        Me.StripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StripPanel.Controls.Add(Me.lblCaption)
        Me.StripPanel.Location = New System.Drawing.Point(0, 0)
        Me.StripPanel.Name = "StripPanel"
        Me.StripPanel.Size = New System.Drawing.Size(473, 43)
        Me.StripPanel.TabIndex = 71
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(7, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(137, 24)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Consignor List"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(23, 22)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator3, Me.btnSearch, Me.ToolStripSeparator4, Me.btnPrint, Me.ToolStripSeparator5, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 45)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStrip1.TabIndex = 73
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
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(620, 34)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(35, 21)
        Me.lblType.TabIndex = 76
        Me.lblType.Visible = False
        '
        'frameSearch2
        '
        Me.frameSearch2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.frameSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frameSearch2.Controls.Add(Me.txtSMobile)
        Me.frameSearch2.Controls.Add(Me.txtSGST)
        Me.frameSearch2.Controls.Add(Me.Label2)
        Me.frameSearch2.Controls.Add(Me.btnSearch2)
        Me.frameSearch2.Controls.Add(Me.btnSearchCancel)
        Me.frameSearch2.Controls.Add(Me.txtSName)
        Me.frameSearch2.Controls.Add(Me.Label12)
        Me.frameSearch2.Controls.Add(Me.Label13)
        Me.frameSearch2.Controls.Add(Me.Panel3)
        Me.frameSearch2.Location = New System.Drawing.Point(178, 185)
        Me.frameSearch2.Name = "frameSearch2"
        Me.frameSearch2.Size = New System.Drawing.Size(429, 152)
        Me.frameSearch2.TabIndex = 86
        Me.frameSearch2.Visible = False
        '
        'txtSMobile
        '
        Me.txtSMobile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtSMobile.Location = New System.Drawing.Point(214, 59)
        Me.txtSMobile.Name = "txtSMobile"
        Me.txtSMobile.Size = New System.Drawing.Size(194, 23)
        Me.txtSMobile.TabIndex = 30
        '
        'txtSGST
        '
        Me.txtSGST.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtSGST.Location = New System.Drawing.Point(12, 105)
        Me.txtSGST.Name = "txtSGST"
        Me.txtSGST.Size = New System.Drawing.Size(194, 23)
        Me.txtSGST.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "GSTN"
        '
        'btnSearch2
        '
        Me.btnSearch2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearch2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch2.ForeColor = System.Drawing.Color.White
        Me.btnSearch2.Location = New System.Drawing.Point(240, 105)
        Me.btnSearch2.Name = "btnSearch2"
        Me.btnSearch2.Size = New System.Drawing.Size(81, 26)
        Me.btnSearch2.TabIndex = 32
        Me.btnSearch2.Text = "&Search"
        Me.btnSearch2.UseVisualStyleBackColor = False
        '
        'btnSearchCancel
        '
        Me.btnSearchCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCancel.ForeColor = System.Drawing.Color.White
        Me.btnSearchCancel.Location = New System.Drawing.Point(327, 105)
        Me.btnSearchCancel.Name = "btnSearchCancel"
        Me.btnSearchCancel.Size = New System.Drawing.Size(81, 26)
        Me.btnSearchCancel.TabIndex = 33
        Me.btnSearchCancel.Text = "&Cancel"
        Me.btnSearchCancel.UseVisualStyleBackColor = False
        '
        'txtSName
        '
        Me.txtSName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtSName.Location = New System.Drawing.Point(12, 59)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(194, 23)
        Me.txtSName.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(209, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Mobile No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(9, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Consignor Name"
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
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Search"
        '
        'frmConsigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(940, 529)
        Me.ControlBox = False
        Me.Controls.Add(Me.frameSearch2)
        Me.Controls.Add(Me.frameSearch)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.StripPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmConsigner"
        Me.Text = "frmConsigner"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameSearch.ResumeLayout(False)
        Me.frameSearch.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StripPanel.ResumeLayout(False)
        Me.StripPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.frameSearch2.ResumeLayout(False)
        Me.frameSearch2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents frameSearch As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StripPanel As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAadharNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents frameSearch2 As System.Windows.Forms.Panel
    Friend WithEvents txtSMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtSGST As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch2 As System.Windows.Forms.Button
    Friend WithEvents btnSearchCancel As System.Windows.Forms.Button
    Friend WithEvents txtSName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
