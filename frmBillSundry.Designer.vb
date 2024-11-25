<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillSundry
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
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSub = New System.Windows.Forms.RadioButton()
        Me.optAdd = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRoundOff = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StripPanel = New System.Windows.Forms.Panel()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.optUp = New System.Windows.Forms.RadioButton()
        Me.optAuto = New System.Windows.Forms.RadioButton()
        Me.frameRoundOff = New System.Windows.Forms.GroupBox()
        Me.optLow = New System.Windows.Forms.RadioButton()
        Me.optAmt = New System.Windows.Forms.RadioButton()
        Me.optPer = New System.Windows.Forms.RadioButton()
        Me.optBasic = New System.Windows.Forms.RadioButton()
        Me.frameOf = New System.Windows.Forms.GroupBox()
        Me.optPrevious = New System.Windows.Forms.RadioButton()
        Me.optBill = New System.Windows.Forms.RadioButton()
        Me.optTaxable = New System.Windows.Forms.RadioButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.chkFix = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.StripPanel.SuspendLayout()
        Me.frameRoundOff.SuspendLayout()
        Me.frameOf.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtValue.Location = New System.Drawing.Point(106, 85)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(78, 23)
        Me.txtValue.TabIndex = 87
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSub)
        Me.GroupBox1.Controls.Add(Me.optAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 56)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'optSub
        '
        Me.optSub.AutoSize = True
        Me.optSub.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optSub.Location = New System.Drawing.Point(96, 19)
        Me.optSub.Name = "optSub"
        Me.optSub.Size = New System.Drawing.Size(99, 22)
        Me.optSub.TabIndex = 54
        Me.optSub.Text = "Substractive"
        Me.optSub.UseVisualStyleBackColor = True
        '
        'optAdd
        '
        Me.optAdd.AutoSize = True
        Me.optAdd.Checked = True
        Me.optAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optAdd.Location = New System.Drawing.Point(6, 19)
        Me.optAdd.Name = "optAdd"
        Me.optAdd.Size = New System.Drawing.Size(75, 22)
        Me.optAdd.TabIndex = 53
        Me.optAdd.TabStop = True
        Me.optAdd.Text = "Additive"
        Me.optAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(584, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Round Off"
        Me.Label1.Visible = False
        '
        'chkRoundOff
        '
        Me.chkRoundOff.AutoSize = True
        Me.chkRoundOff.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.chkRoundOff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkRoundOff.Location = New System.Drawing.Point(675, 112)
        Me.chkRoundOff.Name = "chkRoundOff"
        Me.chkRoundOff.Size = New System.Drawing.Size(197, 22)
        Me.chkRoundOff.TabIndex = 82
        Me.chkRoundOff.Text = "Round Off Bill Sundry Amount"
        Me.chkRoundOff.UseVisualStyleBackColor = True
        Me.chkRoundOff.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(313, 127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 38)
        Me.btnExit.TabIndex = 80
        Me.btnExit.Text = "&Cancel"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(226, 127)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(81, 38)
        Me.btnLogin.TabIndex = 78
        Me.btnLogin.Text = "&Save"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtName.Location = New System.Drawing.Point(106, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(252, 23)
        Me.txtName.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Default Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Name"
        '
        'StripPanel
        '
        Me.StripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StripPanel.Controls.Add(Me.lblCaption)
        Me.StripPanel.Location = New System.Drawing.Point(0, 0)
        Me.StripPanel.Name = "StripPanel"
        Me.StripPanel.Size = New System.Drawing.Size(473, 43)
        Me.StripPanel.TabIndex = 73
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Trebuchet MS", 14.75!, System.Drawing.FontStyle.Bold)
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(12, 8)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(184, 26)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Bill Sundry Master"
        '
        'optUp
        '
        Me.optUp.AutoSize = True
        Me.optUp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optUp.Location = New System.Drawing.Point(6, 45)
        Me.optUp.Name = "optUp"
        Me.optUp.Size = New System.Drawing.Size(103, 22)
        Me.optUp.TabIndex = 54
        Me.optUp.TabStop = True
        Me.optUp.Text = "Always Upper"
        Me.optUp.UseVisualStyleBackColor = True
        '
        'optAuto
        '
        Me.optAuto.AutoSize = True
        Me.optAuto.Checked = True
        Me.optAuto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optAuto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optAuto.Location = New System.Drawing.Point(6, 19)
        Me.optAuto.Name = "optAuto"
        Me.optAuto.Size = New System.Drawing.Size(86, 22)
        Me.optAuto.TabIndex = 53
        Me.optAuto.TabStop = True
        Me.optAuto.Text = "Automatic"
        Me.optAuto.UseVisualStyleBackColor = True
        '
        'frameRoundOff
        '
        Me.frameRoundOff.Controls.Add(Me.optLow)
        Me.frameRoundOff.Controls.Add(Me.optUp)
        Me.frameRoundOff.Controls.Add(Me.optAuto)
        Me.frameRoundOff.Enabled = False
        Me.frameRoundOff.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.frameRoundOff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.frameRoundOff.Location = New System.Drawing.Point(439, 228)
        Me.frameRoundOff.Name = "frameRoundOff"
        Me.frameRoundOff.Size = New System.Drawing.Size(199, 97)
        Me.frameRoundOff.TabIndex = 86
        Me.frameRoundOff.TabStop = False
        Me.frameRoundOff.Text = "Type"
        Me.frameRoundOff.Visible = False
        '
        'optLow
        '
        Me.optLow.AutoSize = True
        Me.optLow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optLow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optLow.Location = New System.Drawing.Point(6, 71)
        Me.optLow.Name = "optLow"
        Me.optLow.Size = New System.Drawing.Size(104, 22)
        Me.optLow.TabIndex = 55
        Me.optLow.TabStop = True
        Me.optLow.Text = "Always Lower"
        Me.optLow.UseVisualStyleBackColor = True
        '
        'optAmt
        '
        Me.optAmt.AutoSize = True
        Me.optAmt.Checked = True
        Me.optAmt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optAmt.Location = New System.Drawing.Point(6, 20)
        Me.optAmt.Name = "optAmt"
        Me.optAmt.Size = New System.Drawing.Size(124, 22)
        Me.optAmt.TabIndex = 53
        Me.optAmt.TabStop = True
        Me.optAmt.Text = "Absolute Amount"
        Me.optAmt.UseVisualStyleBackColor = True
        '
        'optPer
        '
        Me.optPer.AutoSize = True
        Me.optPer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optPer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optPer.Location = New System.Drawing.Point(6, 46)
        Me.optPer.Name = "optPer"
        Me.optPer.Size = New System.Drawing.Size(90, 22)
        Me.optPer.TabIndex = 54
        Me.optPer.Text = "Percentage"
        Me.optPer.UseVisualStyleBackColor = True
        '
        'optBasic
        '
        Me.optBasic.AutoSize = True
        Me.optBasic.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optBasic.Location = New System.Drawing.Point(6, 19)
        Me.optBasic.Name = "optBasic"
        Me.optBasic.Size = New System.Drawing.Size(104, 22)
        Me.optBasic.TabIndex = 53
        Me.optBasic.TabStop = True
        Me.optBasic.Text = "Basic Amount"
        Me.optBasic.UseVisualStyleBackColor = True
        '
        'frameOf
        '
        Me.frameOf.Controls.Add(Me.optPrevious)
        Me.frameOf.Controls.Add(Me.optBill)
        Me.frameOf.Controls.Add(Me.optTaxable)
        Me.frameOf.Controls.Add(Me.optBasic)
        Me.frameOf.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.frameOf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.frameOf.Location = New System.Drawing.Point(644, 209)
        Me.frameOf.Name = "frameOf"
        Me.frameOf.Size = New System.Drawing.Size(199, 133)
        Me.frameOf.TabIndex = 55
        Me.frameOf.TabStop = False
        Me.frameOf.Text = "of"
        Me.frameOf.Visible = False
        '
        'optPrevious
        '
        Me.optPrevious.AutoSize = True
        Me.optPrevious.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optPrevious.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optPrevious.Location = New System.Drawing.Point(6, 97)
        Me.optPrevious.Name = "optPrevious"
        Me.optPrevious.Size = New System.Drawing.Size(183, 22)
        Me.optPrevious.TabIndex = 56
        Me.optPrevious.TabStop = True
        Me.optPrevious.Text = "Previous BillSundry Amount"
        Me.optPrevious.UseVisualStyleBackColor = True
        '
        'optBill
        '
        Me.optBill.AutoSize = True
        Me.optBill.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optBill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optBill.Location = New System.Drawing.Point(6, 71)
        Me.optBill.Name = "optBill"
        Me.optBill.Size = New System.Drawing.Size(115, 22)
        Me.optBill.TabIndex = 55
        Me.optBill.TabStop = True
        Me.optBill.Text = "Net Bill Amount"
        Me.optBill.UseVisualStyleBackColor = True
        '
        'optTaxable
        '
        Me.optTaxable.AutoSize = True
        Me.optTaxable.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.optTaxable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.optTaxable.Location = New System.Drawing.Point(6, 45)
        Me.optTaxable.Name = "optTaxable"
        Me.optTaxable.Size = New System.Drawing.Size(118, 22)
        Me.optTaxable.TabIndex = 54
        Me.optTaxable.TabStop = True
        Me.optTaxable.Text = "Taxable Amount"
        Me.optTaxable.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(179, 318)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(38, 25)
        Me.lblID.TabIndex = 81
        Me.lblID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optPer)
        Me.GroupBox2.Controls.Add(Me.optAmt)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(644, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 195)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        Me.GroupBox2.Visible = False
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.chkActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkActive.Location = New System.Drawing.Point(190, 88)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(64, 22)
        Me.chkActive.TabIndex = 88
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'chkFix
        '
        Me.chkFix.AutoSize = True
        Me.chkFix.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.chkFix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.chkFix.Location = New System.Drawing.Point(294, 86)
        Me.chkFix.Name = "chkFix"
        Me.chkFix.Size = New System.Drawing.Size(45, 22)
        Me.chkFix.TabIndex = 89
        Me.chkFix.Text = "Fix"
        Me.chkFix.UseVisualStyleBackColor = True
        '
        'frmBillSundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(960, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkFix)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.frameOf)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRoundOff)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StripPanel)
        Me.Controls.Add(Me.frameRoundOff)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBillSundry"
        Me.Text = "frmBillSundry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StripPanel.ResumeLayout(False)
        Me.StripPanel.PerformLayout()
        Me.frameRoundOff.ResumeLayout(False)
        Me.frameRoundOff.PerformLayout()
        Me.frameOf.ResumeLayout(False)
        Me.frameOf.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSub As System.Windows.Forms.RadioButton
    Friend WithEvents optAdd As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkRoundOff As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StripPanel As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents optUp As System.Windows.Forms.RadioButton
    Friend WithEvents optAuto As System.Windows.Forms.RadioButton
    Friend WithEvents frameRoundOff As System.Windows.Forms.GroupBox
    Friend WithEvents optLow As System.Windows.Forms.RadioButton
    Friend WithEvents optAmt As System.Windows.Forms.RadioButton
    Friend WithEvents optPer As System.Windows.Forms.RadioButton
    Friend WithEvents optBasic As System.Windows.Forms.RadioButton
    Friend WithEvents frameOf As System.Windows.Forms.GroupBox
    Friend WithEvents optPrevious As System.Windows.Forms.RadioButton
    Friend WithEvents optBill As System.Windows.Forms.RadioButton
    Friend WithEvents optTaxable As System.Windows.Forms.RadioButton
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents chkFix As System.Windows.Forms.CheckBox
End Class
