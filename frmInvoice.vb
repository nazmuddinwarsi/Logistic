Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmInvoice
    Dim cnn As New DataConn.Conn
    Dim iEvent As Integer = 0
    Dim iGrid As Integer = 0
    Dim iSave As Integer = 0
    Private focusedForeColor As Color = Color.White
    Private focusedBackColor As Color = Color.Black
    Dim strSQL, sSQL As String
    Dim da As New OdbcDataAdapter
    Dim ds As New DataSet
    Private Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function
    Public Sub New()
        InitializeComponent()
        Me.GetAllControls(Me).OfType(Of TextBox)().ToList() _
          .ForEach(Sub(b)
                       b.Tag = Tuple.Create(b.ForeColor, b.BackColor)
                       AddHandler b.GotFocus, AddressOf b_GotFocus : AddHandler b.LostFocus, AddressOf b_LostFocus
                   End Sub)
        Me.GetAllControls(Me).OfType(Of ComboBox)().ToList() _
          .ForEach(Sub(c)
                       c.Tag = Tuple.Create(c.ForeColor, c.BackColor)
                       AddHandler c.GotFocus, AddressOf c_GotFocus : AddHandler c.LostFocus, AddressOf c_LostFocus
                   End Sub)
    End Sub
    Private Sub b_LostFocus(sender As Object, e As EventArgs)
        Dim b = DirectCast(sender, TextBox) : Dim colors = DirectCast(b.Tag, Tuple(Of Color, Color)) : b.ForeColor = colors.Item1 : b.BackColor = colors.Item2
    End Sub
    Private Sub b_GotFocus(sender As Object, e As EventArgs)
        Dim b = DirectCast(sender, TextBox) : b.ForeColor = focusedForeColor : b.BackColor = focusedBackColor
    End Sub
    Private Sub c_LostFocus(sender As Object, e As EventArgs)
        Dim c = DirectCast(sender, ComboBox) : Dim colors = DirectCast(c.Tag, Tuple(Of Color, Color)) : c.ForeColor = colors.Item1 : c.BackColor = colors.Item2
    End Sub
    Private Sub c_GotFocus(sender As Object, e As EventArgs)
        Dim c = DirectCast(sender, ComboBox) : c.ForeColor = focusedForeColor : c.BackColor = focusedBackColor
    End Sub
    Private Sub frmInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        StripPanel.Width = MDI.Width : lblHR2.Width = MDI.Width
        If Date.Now.Hour > 4 Then
            txtDate.Text = Date.Today
        Else
            txtDate.Text = DateAdd(DateInterval.Day, -1, Date.Today)
        End If
        GetInvoiceNo()
        ''--------------------------- CONSIGNER
        cmbConsigner.DisplayMember = "AccountName"
        cmbConsigner.ValueMember = "AccountID"
        cmbConsigner.DataSource = cnn.BindMaster(0)
        cmbConsigner.SelectedIndex = -1
        '--------------------------- CONSIGNEE
        cmbConsignee.DisplayMember = "AccountName"
        cmbConsignee.ValueMember = "AccountID"
        cmbConsignee.DataSource = cnn.BindMaster(1)
        cmbConsignee.SelectedIndex = -1
        '--------------------------- PRODUCTS
        cmbProduct.DisplayMember = "fldName"
        cmbProduct.ValueMember = "ID"
        cmbProduct.DataSource = cnn.BindMaster(2)
        cmbProduct.SelectedIndex = -1
        '--------------------------- DESTINATION
        cmbDestination.DisplayMember = "fldName"
        cmbDestination.ValueMember = "ID"
        cmbDestination.DataSource = cnn.BindMaster(3)
        cmbDestination.SelectedIndex = -1
        ''--------------------------- TRANSPORTER
        'cmbTransporter.DisplayMember = "fldName"
        'cmbTransporter.ValueMember = "ID"
        'cmbTransporter.DataSource = cnn.BindMaster(5)
        'cmbTransporter.SelectedIndex = -1
        '--------------------------- REMAKRS
        cmbRemarks.DisplayMember = "Remarks"
        cmbRemarks.ValueMember = "Remarks"
        cmbRemarks.DataSource = cnn.BindRemarks()
        cmbRemarks.SelectedIndex = -1
        '----------------

        BindTax()
        iEvent = 1

    End Sub

    Private Sub BindTax()
        '--------------------------- TAX

        Grid2.DataSource = cnn.BindMaster(4)
        Grid2.Columns(0).HeaderText = "ID"
        Grid2.Columns(0).Visible = False
        Grid2.Columns(1).HeaderText = "Name"
        Grid2.Columns(2).HeaderText = "Amt" '"(%)"
        Grid2.Columns(3).HeaderText = "Enable"
        Grid2.Columns(3).Visible = False

    End Sub
    Private Sub GetInvoiceNo()
        strSQL = "SELECT BillNo, GST from LOG_tblPara Where CompanyID = " & Val(MDI.lblCompanyID.Text) & " AND SessionID = " & Val(MDI.lblSessionID.Text)
        Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("BillNo")) Then
                txtInvoiceNo.Text = dr.Item("BillNo")
            Else
                cnn.ErrMsgBox("There is a Problem in Entry, Please Contact Software Administrator  !")
                Exit Sub
            End If
            If Not IsDBNull(dr.Item("GST")) Then
                lblGST.Text = dr.Item("GST")
            End If
        Else
            cnn.ErrMsgBox("There is a Problem in Entry, Please Contact Software Administrator  !")
            Exit Sub
        End If
        dr.Close()
        cmd.Connection.Close()
        '---------------------------
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtInvoiceNo.Text = "" Then
            cnn.ErrMsgBox("Please Enter Invoice No  !")
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        If txtDate.Text = "" Then
            cnn.ErrMsgBox("Please Enter Invoice Date  !")
            txtDate.Focus()
            Exit Sub
        End If
        If cmbProduct.Text = "" Then
            cnn.ErrMsgBox("Please Select Product Code  !")
            cmbProduct.Focus()
            Exit Sub
        End If
        If cmbProduct.SelectedValue = 0 Then
            cnn.ErrMsgBox("Please Select Product Name from List !")
            cmbProduct.Focus()
            Exit Sub
        End If
        If Val(txtActualWt.Text) = 0 Then
            cnn.ErrMsgBox("Please Enter Product Actual Weight  !")
            txtActualWt.Focus()
            Exit Sub
        End If
        If Val(txtAmount.Text) = 0 Then
            cnn.ErrMsgBox("Please Enter Product Amount  !")
            txtAmount.Focus()
            Exit Sub
        End If
        If Grid.RowCount = 1 Then
            cnn.ErrMsgBox("Only one Product can be add  !")
            cmbProduct.Focus()
            Exit Sub
        End If
        '---------
        For i = 0 To Grid.Rows.Count - 1
            If cmbProduct.SelectedValue = Grid.Rows(i).Cells(0).Value Then
                cnn.ErrMsgBox("Duplicate Entry, Please check  !")
                cmbProduct.Focus()
                Exit Sub
            End If
        Next
        '-----------------------------------------------
        Grid.Rows.Add(1)
        Grid.Rows(Grid.Rows.Count - 1).Cells(0).Value = cmbProduct.SelectedValue
        Grid.Rows(Grid.Rows.Count - 1).Cells(1).Value = cmbProduct.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(2).Value = txtDescr.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(3).Value = txtHSN.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(4).Value = txtPackage.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(5).Value = txtActualWt.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(6).Value = txtChargeWt.Text
        Grid.Rows(Grid.Rows.Count - 1).Cells(7).Value = txtAmount.Text
        GridTotal()
        CalculateSundryGrid()
        cmbProduct.Text = "" : txtActualWt.Text = "" : txtDescr.Text = "" : txtHSN.Text = "" : txtPackage.Text = "" : txtRate.Text = "" : txtChargeWt.Text = "" : txtAmount.Text = "" : Grid2.Focus()
        '===============
        For i = 0 To Grid2.Rows.Count - 1
            If Grid2.Rows(i).Cells(3).Value = "Y" Then
                For j = 0 To Grid2.Columns.Count - 1
                    Grid2.Rows(i).Cells(j).Style.Font = New Font("Arial", 10, FontStyle.Bold)
                Next
            End If
        Next
    End Sub
    Public Sub GridTotal()
        Dim iTotActualWt, iTotChargeWt, iTotPkg, iTotAmt
        iTotActualWt = 0 : iTotAmt = 0 : iTotPkg = 0 : iTotChargeWt = 0
        For i = 0 To Grid.Rows.Count - 1
            iTotPkg = Val(iTotPkg) + Val(Grid.Rows(i).Cells(4).Value)
            iTotActualWt = Val(iTotActualWt) + Val(Grid.Rows(i).Cells(5).Value)
            iTotChargeWt = Val(iTotChargeWt) + Val(Grid.Rows(i).Cells(6).Value)
            iTotAmt = Val(iTotAmt) + Val(Grid.Rows(i).Cells(7).Value)
        Next
        txtTotalPackage.Text = iTotPkg
        txtTotalActualWeight.Text = iTotActualWt
        txtTotalChargeWeight.Text = iTotChargeWt
        txtTotalAmount.Text = cnn.Num2(iTotAmt)
    End Sub
    Public Sub CalculateSundryGrid()
        Dim iTotalBasicAmt, iTaxableAmt, iBillAmt As Double
        iTotalBasicAmt = Val(txtTotalAmount.Text)
        iTaxableAmt = Val(txtTotalAmount.Text)
        iBillAmt = Val(txtTotalAmount.Text)
        For i = 0 To Grid2.Rows.Count - 1
            iTaxableAmt = Val(iTaxableAmt) + Val(Grid2.Rows(i).Cells(2).Value)
        Next

        txtTaxableAmount.Text = cnn.Num2(iTaxableAmt)
        If rbNo.Checked = True Then
            lblCGST.Text = 0 : lblSGST.Text = 0 : lblIGST.Text = 0
        Else
            If rbCGST.Checked = True Then
                lblCGST.Text = Val(lblGST.Text) / 2 : lblSGST.Text = Val(lblGST.Text) / 2 : lblIGST.Text = 0
            Else
                lblCGST.Text = 0 : lblSGST.Text = 0 : lblIGST.Text = lblGST.Text
            End If
        End If
        txtCGST.Text = cnn.Num2(Val(iTaxableAmt) * Val(lblCGST.Text) / 100)
        txtSGST.Text = cnn.Num2(Val(iTaxableAmt) * Val(lblSGST.Text) / 100)
        txtIGST.Text = cnn.Num2(Val(iTaxableAmt) * Val(lblIGST.Text) / 100)

        txtBillAmount.Text = Val(iTaxableAmt) + Val(txtCGST.Text) + Val(txtSGST.Text) + Val(txtIGST.Text)
        txtBillAmount.Text = cnn.Num2(txtBillAmount.Text)
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Grid.Rows.Count > 0 Then
            Grid.Rows.RemoveAt(Grid.CurrentCell.RowIndex)
        End If
        GridTotal()
        CalculateSundryGrid()
    End Sub
    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChargeWt.KeyPress
        e.Handled = cnn.IsNumericTextbox(sender, e.KeyChar)
    End Sub
    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtChargeWt.TextChanged, txtRate.TextChanged
        GetAmount()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
    End Sub
    Private Sub SaveData()
        If cmbConsigner.Text = "" Then
            cnn.ErrMsgBox("Please Select Consigner Name  !")
            cmbConsigner.Focus()
            Exit Sub
        End If
        If cmbConsigner.SelectedValue = 0 Then
            cnn.ErrMsgBox("Please Select Consigner Name from List  !")
            cmbConsigner.Focus()
            Exit Sub
        End If
        If cmbConsignee.Text = "" Then
            cnn.ErrMsgBox("Please Select Consignee Name  !")
            cmbConsignee.Focus()
            Exit Sub
        End If
        If cmbConsignee.SelectedValue = 0 Then
            cnn.ErrMsgBox("Please Select Consignee Name from List  !")
            cmbConsignee.Focus()
            Exit Sub
        End If
        If cmbDestination.Text = "" Then
            cnn.ErrMsgBox("Please Select City Name  !")
            cmbDestination.Focus()
            Exit Sub
        End If
        If cmbDestination.SelectedValue = 0 Then
            cnn.ErrMsgBox("Please Select City Name from List  !")
            cmbDestination.Focus()
            Exit Sub
        End If
        If Val(cmbProduct.SelectedValue) <= 0 Then
            cnn.ErrMsgBox("Please Select Product Name from List  !")
            cmbProduct.Focus()
            Exit Sub
        End If
        'If cmbTransporter.Text = "" Then
        '    cnn.ErrMsgBox("Please Select Transport Name  !")
        '    cmbTransporter.Focus()
        '    Exit Sub
        'End If
        'If cmbTransporter.SelectedValue = 0 Then
        '    cnn.ErrMsgBox("Please Select Transport Name from List  !")
        '    cmbTransporter.Focus()
        '    Exit Sub
        'End If
        'If Grid.Rows.Count < 1 Then
        '    cnn.ErrMsgBox("Please Enter Product Details  !")
        '    cmbProduct.Focus()
        '    Exit Sub
        'End If
        Dim strSQL, iBookType, GSTat, iRCM As String
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        If rbToPay.Checked = True Then
            iBookType = "TOPAY"
        ElseIf rbPaid.Checked = True Then
            iBookType = "PAID"
        ElseIf rbTBB.Checked = True Then
            iBookType = "TBB"
        End If
        If rbCnsr.Checked = True Then
            GSTat = "CONSIGNOR"
        ElseIf rbCnse.Checked = True Then
            GSTat = "CONSIGNEE"
        ElseIf rbTrans.Checked = True Then
            GSTat = "TRANSPORTER"
        ElseIf rbExmptd.Checked = True Then
            GSTat = "EXEMPTED"
        End If
        If rbRCMNo.Checked = True Then
            iRCM = "NO"
        Else
            iRCM = "YES"
        End If


        If lblID.Text = "" Then
            GetInvoiceNo()
            '-------------------------------------------------
            strSQL = "INSERT INTO LOG_tblInvoice (InvoiceNo, InvoiceDate, ConsignerID, ConsigneeID, DestinationID, TransporterID, InvNo, Remarks, Value, PrivateMarks, TruckNo, GSTat, BookingType, TotalPackage, TotalActualWeight, TotalChargeWeight, TotalAmount, TaxableAmount," _
            & "CGST, CGSTAmount, SGST, SGSTAmount, IGST, IGSTAmount, BillAmount, RCM, CompanyID, CreatedBy, CreatedDate, SessionID) OutPut Inserted.InvoiceID as HeaderID VALUES (" _
            & Val(txtInvoiceNo.Text) & ",'" & cnn.GetDate(txtDate.Text) & "'," & Val(cmbConsigner.SelectedValue) & "," & Val(cmbConsignee.SelectedValue) & "," & Val(cmbDestination.SelectedValue) & "," & Val(cmbTransporter.SelectedValue) _
            & "," & cnn.SQLquote(UCase(txtInv.Text)) & "," & cnn.SQLquote(UCase(cmbRemarks.Text)) & "," & cnn.SQLquote(txtValue.Text) & "," & cnn.SQLquote(txtPrivateMarks.Text) & "," & cnn.SQLquote(txtTruckNo.Text) & ",'" & GSTat & "','" & iBookType & "'," & Val(txtTotalPackage.Text) _
            & "," & Val(txtTotalActualWeight.Text) & "," & Val(txtTotalChargeWeight.Text) & "," & Val(txtTotalAmount.Text) & "," & Val(txtTaxableAmount.Text) & "," & Val(lblCGST.Text) & "," & Val(txtCGST.Text) _
            & "," & Val(lblSGST.Text) & "," & Val(txtSGST.Text) & "," & Val(lblIGST.Text) & "," & Val(txtIGST.Text) & "," & Val(txtBillAmount.Text) & ",'" & iRCM & "'," & Val(MDI.lblCompanyID.Text) & "," & Val(MDI.lblUserLoginID.Text) & ",DATEADD(MINUTE, 330, GETUTCDATE())," & Val(MDI.lblSessionID.Text) & ")"

            cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
            If cmd.Connection.State = 1 Then cmd.Connection.Close()
            cmd.Connection.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                lblHeaderID.Text = dr.Item("HeaderID")
            End If
            dr.Close()
            cmd.Connection.Close()
            '==================================
            strSQL = "UPDATE LOG_tblPara SET BillNo = (BillNo + 1) Where CompanyID = " & Val(MDI.lblCompanyID.Text) & " AND SessionID = " & Val(MDI.lblSessionID.Text)
            cnn.executeSQL(strSQL)
            '==================================
            lblOldNo.Text = txtInvoiceNo.Text : lblOldDate.Text = txtDate.Text
            Call cnn.GenerateLog("Sale", "Add", 0, Val(txtInvoiceNo.Text) & ", Dt. " & txtDate.Text)
        Else
            strSQL = "UPDATE LOG_tblInvoice SET InvoiceNo=" & cnn.SQLquote(txtInvoiceNo.Text) & ", InvoiceDate='" & cnn.GetDate(txtDate.Text) & "'" _
            & ", ConsignerID=" & Val(cmbConsigner.SelectedValue) & ", ConsigneeID=" & Val(cmbConsignee.SelectedValue) & ", DestinationID=" & Val(cmbDestination.SelectedValue) _
            & ", TransporterID=" & Val(cmbTransporter.SelectedValue) & ", InvNo=" & cnn.SQLquote(UCase(txtInv.Text)) & ", Remarks=" & cnn.SQLquote(UCase(cmbRemarks.Text)) _
            & ", Value=" & cnn.SQLquote(txtValue.Text) & ", PrivateMarks=" & cnn.SQLquote(txtPrivateMarks.Text) & ", TruckNo=" & cnn.SQLquote(txtTruckNo.Text) _
            & ", GSTat='" & GSTat & "', BookingType='" & iBookType & "', TotalPackage=" & Val(txtTotalPackage.Text) & ", TotalActualWeight=" & Val(txtTotalActualWeight.Text) & ", TotalChargeWeight=" & Val(txtTotalChargeWeight.Text) & ", TotalAmount=" & Val(txtTotalAmount.Text) _
            & ", TaxableAmount=" & Val(txtTaxableAmount.Text) & ", CGST=" & Val(lblCGST.Text) & ", CGSTAmount=" & Val(txtCGST.Text) & ", SGST=" & Val(lblSGST.Text) _
            & ", IGST=" & Val(lblIGST.Text) & ", IGSTAmount=" & Val(txtIGST.Text) & ", BillAmount=" & Val(txtBillAmount.Text) & ", RCM='" & iRCM & "'" _
            & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "'" _
            & " Where InvoiceID=" & Val(lblID.Text)
            cnn.executeSQL(strSQL)
            lblHeaderID.Text = lblID.Text
            Call cnn.GenerateLog("Sale", "Edit", lblID.Text, Val(txtInvoiceNo.Text) & ", Dt. " & txtDate.Text)

        End If

        SaveDetails()
        lblOldNo.Text = txtInvoiceNo.Text : lblOldDate.Text = txtDate.Text
        cnn.CloseConn()
        If lblID.Text <> "" Then
            '===============================
            Dim iVal As Integer = cnn.UpdateChallan(Val(lblID.Text))
            '===============================
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
            'Me.Close()
        Else
            cnn.InfoMsgBox("Record has been Added Successfully  !")
        End If

        lblID.Text = "" : txtInvoiceNo.Text = "" : cmbConsignee.Text = "" : cmbConsigner.Text = ""
        txtConsignerCity.Text = "" : txtConsigneeCity.Text = "" : cmbProduct.Text = "" : txtPackage.Text = "" : txtActualWt.Text = ""
        txtChargeWt.Text = "" : txtAmount.Text = "" : Grid.Rows.Clear() : txtTotalPackage.Text = "" : txtTotalActualWeight.Text = "" : txtTotalAmount.Text = ""
        txtTaxableAmount.Text = "" : txtCGST.Text = "" : txtSGST.Text = "" : txtIGST.Text = "" : txtBillAmount.Text = ""
        txtInv.Text = "" : cmbRemarks.Text = "" : txtValue.Text = "" : txtPrivateMarks.Text = "" : txtTruckNo.Text = "" : rbRCMNo.Checked = True
        cmbTransporter.SelectedIndex = -1 : cmbDestination.SelectedIndex = -1 : rbToPay.Checked = True
        txtDescr.Text = "" : txtHSN.Text = "" : txtRate.Text = ""
        If Date.Now.Hour > 5 Then
            txtDate.Text = Date.Today
        Else
            txtDate.Text = DateAdd(DateInterval.Day, -1, Date.Today)
        End If
        iSave = 1
        '--------------------------- REMAKRS
        cmbRemarks.DisplayMember = "Remarks"
        cmbRemarks.ValueMember = "Remarks"
        cmbRemarks.DataSource = cnn.BindRemarks()
        cmbRemarks.SelectedIndex = -1
        BindTax() : GetInvoiceNo() : txtDate.Focus()
    End Sub
    Private Sub SaveDetails()
        Dim strSQL As String
        If lblID.Text <> "" Then
            cnn.executeSQL("DELETE From LOG_tblInvoiceDetails Where HeaderID=" & lblID.Text)
            cnn.executeSQL("DELETE From LOG_tblBillSundryDetails Where HeaderID=" & lblID.Text)
        End If
        strSQL = "INSERT INTO LOG_tblInvoiceDetails (HeaderID, ProductID, Description, HSNCode, Packages, ActualWeight, ChargeWeight, Amount) VALUES("
        strSQL = strSQL & Val(lblHeaderID.Text) & "," & Val(cmbProduct.SelectedValue) & "," & cnn.SQLquote(txtDescr.Text) & "," _
        & cnn.SQLquote(txtHSN.Text) & "," & Val(txtPackage.Text) & "," & Val(txtActualWt.Text) & "," _
        & Val(txtChargeWt.Text) & "," & Val(txtAmount.Text) & ")"
        cnn.executeSQL(strSQL)
        For i = 0 To Grid2.Rows.Count - 1
            strSQL = "INSERT INTO LOG_tblBillSundryDetails (HeaderID, vType, SundryID, Value, Amount) VALUES (" _
            & Val(lblHeaderID.Text) & ",'SALE'," & Val(Grid2.Rows(i).Cells(0).Value) & "," & Val(Grid2.Rows(i).Cells(2).Value) & "," & Val(Grid2.Rows(i).Cells(2).Value) & ")"
            cnn.executeSQL(strSQL)
        Next

    End Sub
    Private Sub txtPackage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPackage.KeyPress
        e.Handled = cnn.IsNumericTextbox(sender, e.KeyChar)
    End Sub
    Private Sub txtPackage_TextChanged(sender As Object, e As EventArgs) Handles txtPackage.TextChanged
        GetAmount()
    End Sub
    Private Sub cmbTransporter_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTransporter.KeyDown
        If e.KeyCode = Keys.F2 Then
            frameTrans.Visible = True : txtTransName.Focus()
        End If
    End Sub
    Private Sub cmbTransporter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTransporter.SelectedIndexChanged
        If iEvent = 1 Then
            If cmbTransporter.Text <> "" Then
                Dim strSQL As String
                strSQL = "Select MobileNo from LOG_tblMaster Where tType='TRANS' AND ID=" & Val(cmbTransporter.SelectedValue)
                Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
                If cmd.Connection.State = 1 Then cmd.Connection.Close()
                cmd.Connection.Open()
                Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
                If dr.Read Then
                    txtMobile.Text = dr.Item("MobileNo")
                End If
                dr.Close()
                cmd.Connection.Close()
            Else
                txtMobile.Text = ""
            End If
        End If
    End Sub
    Private Sub cmbConsignee_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbConsignee.KeyDown
        If e.KeyCode = Keys.F2 Then
            frameCNSE.Visible = True : txtCompany2.Focus()
        End If
    End Sub
    Private Sub cmbConsignee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsignee.SelectedIndexChanged
        If iEvent = 1 Then
            If cmbConsignee.Text <> "" Then
                Dim strSQL As String
                strSQL = "Select City, ProductRate, GSTinNo, AadharNo, RateBy from LOG_tblAccount Where tType='CNSE' AND AccountID=" & Val(cmbConsignee.SelectedValue)
                Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
                If cmd.Connection.State = 1 Then cmd.Connection.Close()
                cmd.Connection.Open()
                Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
                If dr.Read Then
                    If Not IsDBNull(dr.Item("GSTinNo")) And dr.Item("GSTinNo") <> "" Then
                        txtConsigneeCity.Text = dr.Item("GSTinNo") & " (" & dr.Item("City") & ")"
                    Else
                        If Not IsDBNull(dr.Item("AadharNo")) And dr.Item("AadharNo") <> "" Then
                            txtConsigneeCity.Text = dr.Item("AadharNo") & " (" & dr.Item("City") & ")"
                        Else
                            txtConsigneeCity.Text = dr.Item("City")
                        End If
                    End If
                    If Not IsDBNull(dr.Item("RateBy")) Then
                        lblRateBy.Text = dr.Item("RateBy")
                    End If
                    txtRate.Text = dr.Item("ProductRate")
                End If
                dr.Close()
                cmd.Connection.Close()
                '----------- 06042021
                GetPreviousBilty()
                '----------- 06042021
            Else
                txtConsigneeCity.Text = ""
            End If
        End If
    End Sub
    Private Sub GetPreviousBilty()
        strSQL = "SELECT TOP (5) I.InvoiceDate, I.TotalPackage, I.TotalChargeWeight, D.Amount, I.BillAmount FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS A ON I.ConsigneeID = A.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS D ON I.InvoiceID = D.HeaderID" _
        & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.ConsigneeID = " & Val(cmbConsignee.SelectedValue) & ") ORDER BY I.InvoiceID DESC"
        '--------------------
        If cnn.cnn.State = 1 Then
            cnn.cnn.Close()
        End If
        cnn.cnn.Open()
        '--------------------
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        grdPrev.DataSource = ds.Tables(0)
        grdPrev.Columns(0).HeaderText = "Date"
        grdPrev.Columns(1).HeaderText = "Pkg"
        grdPrev.Columns(2).HeaderText = "Weight"
        grdPrev.Columns(3).HeaderText = "Amount"
        grdPrev.Columns(4).HeaderText = "Bilty Amt"
    End Sub
    Private Sub cmbConsigner_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbConsigner.KeyDown
        If e.KeyCode = Keys.F2 Then
            frameCNSR.Visible = True : txtCompany.Focus()
        End If
    End Sub
    Private Sub cmbConsigner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsigner.SelectedIndexChanged
        If iEvent = 1 Then
            If cmbConsigner.Text <> "" Then
                Dim strSQL As String
                strSQL = "Select City, GSTinNo, AadharNo from LOG_tblAccount Where tType='CNSR' AND AccountID=" & Val(cmbConsigner.SelectedValue)
                Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
                If cmd.Connection.State = 1 Then cmd.Connection.Close()
                cmd.Connection.Open()
                Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
                If dr.Read Then
                    Dim ss As String = dr.Item("GSTinNo")
                    'txtConsignerCity.Text = dr.Item("GSTinNo") & " (" & dr.Item("City") & ")"
                    If Not IsDBNull(dr.Item("GSTinNo")) And dr.Item("GSTinNo") <> "" Then
                        txtConsignerCity.Text = dr.Item("GSTinNo") & " (" & dr.Item("City") & ")"
                    Else
                        If Not IsDBNull(dr.Item("AadharNo")) And dr.Item("AadharNo") <> "" Then
                            txtConsignerCity.Text = dr.Item("AadharNo") & " (" & dr.Item("City") & ")"
                        Else
                            txtConsignerCity.Text = dr.Item("City")
                        End If
                    End If
                End If
                dr.Close()
                cmd.Connection.Close()
            Else
                txtConsignerCity.Text = ""
            End If
        End If
    End Sub
    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        GetGST()
        CalculateSundryGrid()
    End Sub
    Private Sub GetGST()
        If rbNo.Checked = True Then
            frameGST.Enabled = False
        Else
            frameGST.Enabled = True
        End If

    End Sub
    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        GetGST() : CalculateSundryGrid()
    End Sub
    Private Sub rbCGST_CheckedChanged(sender As Object, e As EventArgs) Handles rbCGST.CheckedChanged
        CalculateSundryGrid()
    End Sub
    Private Sub rbIGST_CheckedChanged(sender As Object, e As EventArgs) Handles rbIGST.CheckedChanged
        CalculateSundryGrid()
    End Sub
    Private Sub btnCNSRCancel_Click(sender As Object, e As EventArgs) Handles btnCNSRCancel.Click
        frameCNSR.Visible = False : cmbConsigner.Focus()
    End Sub
    Private Sub btnCNSECancel_Click(sender As Object, e As EventArgs) Handles btnCNSECancel.Click
        frameCNSE.Visible = False : cmbConsignee.Focus()
    End Sub
    Private Sub btnCNSRSave_Click(sender As Object, e As EventArgs) Handles btnCNSRSave.Click
        If txtCompany.Text = "" Then
            cnn.ErrMsgBox("Please Enter Consigner Name  !")
            txtCompany.Focus()
            Exit Sub
        End If
        If txtGST.Text <> "" Then
            If Len(txtGST.Text) <> 15 Then
                cnn.ErrMsgBox("Please Enter Valid GST No  !")
                txtGST.Focus()
                Exit Sub
            End If
        End If
        If txtAadhar.Text <> "" Then
            If Len(txtAadhar.Text) <> 12 Then
                cnn.ErrMsgBox("Please Enter Valid Aadhar No  !")
                txtAadhar.Focus()
                Exit Sub
            End If
        End If
        Dim strSQL As String
        '--------------------- CHECK DUPLICATE
        If lblID.Text = "" Then
            strSQL = "Select AccountID from LOG_tblAccount Where AccountName=" & cnn.SQLquote(UCase(txtCompany.Text)) & " AND tType='CNSR'"
        Else
            strSQL = "Select AccountID from LOG_tblAccount Where AccountName=" & cnn.SQLquote(UCase(txtCompany.Text)) & " AND tType='CNSR' AND AccountID <>" & Val(lblID.Text)
        End If
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtName.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        strSQL = "INSERT INTO LOG_tblAccount (tType, AccountName, CPerson, Address, City, State, Mobile, GSTinNo, AadharNo, CreatedBy, CreatedDate) VALUES ('CNSR'," & cnn.SQLquote(UCase(txtCompany.Text)) _
        & "," & cnn.SQLquote(UCase(txtName.Text)) & "," & cnn.SQLquote(UCase(txtAddress.Text)) & "," & cnn.SQLquote(UCase(txtCity.Text)) & "," & cnn.SQLquote(UCase(txtState.Text)) _
        & "," & cnn.SQLquote(UCase(txtMobileNo.Text)) & "," & cnn.SQLquote(UCase(txtGST.Text)) & "," & cnn.SQLquote(UCase(txtAadhar.Text)) & "," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Added Successfully  !")
        '=============

        ''--------------------------- CONSIGNER
        cmbConsigner.DisplayMember = "AccountName"
        cmbConsigner.ValueMember = "AccountID"
        cmbConsigner.DataSource = cnn.BindMaster(0)
        cmbConsigner.SelectedIndex = -1
        '============
        cmbConsigner.Text = UCase(txtCompany.Text) : txtCompany.Text = "" : txtName.Text = "" : txtAddress.Text = "" : txtCity.Text = "" : txtState.Text = "" : txtMobileNo.Text = "" : txtGST.Text = "" : txtAadhar.Text = ""
        frameCNSR.Visible = False : cmbConsigner.Focus()

    End Sub
    Private Sub btnCNSESave_Click(sender As Object, e As EventArgs) Handles btnCNSESave.Click
        If txtCompany2.Text = "" Then
            cnn.ErrMsgBox("Please Enter Consignee Name  !")
            txtCompany2.Focus()
            Exit Sub
        End If
        If txtGST2.Text <> "" Then
            If Len(txtGST2.Text) <> 15 Then
                cnn.ErrMsgBox("Please Enter Valid GST No  !")
                txtGST2.Focus()
                Exit Sub
            End If
        End If
        If txtAadhar2.Text <> "" Then
            If Len(txtAadhar2.Text) <> 12 Then
                cnn.ErrMsgBox("Please Enter Valid Aadhar No  !")
                txtAadhar2.Focus()
                Exit Sub
            End If
        End If
        Dim strSQL, iRateBy As String
        If rbP.Checked = True Then
            iRateBy = "P"
        Else
            iRateBy = "W"
        End If
        '--------------------- CHECK DUPLICATE
        If lblID.Text = "" Then
            strSQL = "Select AccountID from LOG_tblAccount Where AccountName=" & cnn.SQLquote(UCase(txtCompany2.Text)) & " AND tType='CNSE'"
        Else
            strSQL = "Select AccountID from LOG_tblAccount Where AccountName=" & cnn.SQLquote(UCase(txtCompany2.Text)) & " AND tType='CNSE' AND AccountID <>" & Val(lblID.Text)
        End If
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtName.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        strSQL = "INSERT INTO LOG_tblAccount (tType, AccountName, CPerson, Address, City, State, Mobile, GSTinNo, AadharNo, CreatedBy, CreatedDate, ProductRate, Remarks, RateBy) VALUES ('CNSE'," & cnn.SQLquote(UCase(txtCompany2.Text)) _
        & "," & cnn.SQLquote(UCase(txtName2.Text)) & "," & cnn.SQLquote(UCase(txtAddress2.Text)) & "," & cnn.SQLquote(UCase(txtCity2.Text)) & "," & cnn.SQLquote(UCase(txtState2.Text)) _
        & "," & cnn.SQLquote(UCase(txtMobileNo2.Text)) & "," & cnn.SQLquote(UCase(txtGST2.Text)) & "," & cnn.SQLquote(UCase(txtAadhar2.Text)) & "," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "'" _
        & "," & Val(txtProdRate.Text) & "," & cnn.SQLquote(UCase(txtRemarks2.Text)) & ",'" & iRateBy & "')"
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Added Successfully  !")
        '=============

        ''--------------------------- CONSIGNER
        cmbConsignee.DisplayMember = "AccountName"
        cmbConsignee.ValueMember = "AccountID"
        cmbConsignee.DataSource = cnn.BindMaster(1)
        cmbConsignee.SelectedIndex = -1
        '============
        cmbConsignee.Text = UCase(txtCompany2.Text) : txtCompany2.Text = "" : txtName2.Text = "" : txtAddress2.Text = "" : txtCity2.Text = "" : txtState2.Text = "" : txtMobileNo2.Text = ""
        txtGST2.Text = "" : txtAadhar2.Text = "" : txtProdRate.Text = "" : txtRemarks2.Text = ""
        frameCNSE.Visible = False : cmbConsignee.Focus()
    End Sub
    Private Sub cmbProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProduct.KeyDown
        If e.KeyCode = Keys.F2 Then
            frameProd.Visible = True : txtProd.Focus()
        End If
    End Sub
    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged

    End Sub
    Private Sub btnProdCancel_Click(sender As Object, e As EventArgs) Handles btnProdCancel.Click
        frameProd.Visible = False : cmbProduct.Focus()
    End Sub
    Private Sub btnProdSave_Click(sender As Object, e As EventArgs) Handles btnProdSave.Click
        If txtProd.Text = "" Then
            cnn.ErrMsgBox("Please Enter Product Name  !")
            txtProd.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        '--------------------- CHECK DUPLICATE
        strSQL = "Select ID from LOG_tblMaster Where fldName=" & cnn.SQLquote(UCase(txtProd.Text)) & " AND tType='PROD'"
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtProd.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        strSQL = "INSERT INTO LOG_tblMaster (fldName, tType, CreatedBy, CreatedDate) VALUES (" & cnn.SQLquote(UCase(txtProd.Text)) & ",'PROD'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Added Successfully  !")

        '--------------------------- PRODUCTS
        cmbProduct.DisplayMember = "fldName"
        cmbProduct.ValueMember = "ID"
        cmbProduct.DataSource = cnn.BindMaster(2)
        cmbProduct.SelectedIndex = -1
        '--------------------
        cmbProduct.Text = UCase(txtProd.Text) : txtProd.Text = "" : frameProd.Visible = False : cmbProduct.Focus()
    End Sub
    Private Sub btnTransCancel_Click(sender As Object, e As EventArgs) Handles btnTransCancel.Click
        frameTrans.Visible = False : cmbTransporter.Focus()
    End Sub
    Private Sub btnTransSave_Click(sender As Object, e As EventArgs) Handles btnTransSave.Click
        If txtTransName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Tramsporter Name  !")
            txtTransName.Focus()
            Exit Sub
        End If
        'If txtTransMobile.Text = "" Then
        '    cnn.ErrMsgBox("Please Enter Tramsporter Mobile No  !")
        '    txtTransMobile.Focus()
        '    Exit Sub
        'End If
        Dim strSQL As String
        '--------------------- CHECK DUPLICATE
        strSQL = "Select ID from LOG_tblMaster Where fldName=" & cnn.SQLquote(UCase(txtTransName.Text)) & " AND tType='TRANS'"

        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtName.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        strSQL = "INSERT INTO LOG_tblMaster (fldName, MobileNo, tType, CreatedBy, CreatedDate) VALUES (" & cnn.SQLquote(UCase(txtTransName.Text)) & "," & cnn.SQLquote(txtTransMobile.Text) & ",'TRANS'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Added Successfully  !")

        '--------------------------- TRANSPORTER
        cmbTransporter.DisplayMember = "fldName"
        cmbTransporter.ValueMember = "ID"
        cmbTransporter.DataSource = cnn.BindMaster(5)
        cmbTransporter.SelectedIndex = -1
        '------------------
        cmbTransporter.Text = UCase(txtTransName.Text) : txtTransName.Text = "" : txtTransMobile.Text = "" : frameTrans.Visible = False : cmbTransporter.Focus()

    End Sub
    Private Sub cmbDestination_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDestination.KeyDown
        If e.KeyCode = Keys.F2 Then
            frameDestination.Visible = True : txtDestName.Focus()
        End If
    End Sub
    Private Sub cmbDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDestination.SelectedIndexChanged
        cmbTransporter.DataSource = Nothing
        If cmbDestination.Text <> "" Then
            cmbTransporter.DisplayMember = "fldName"
            cmbTransporter.ValueMember = "ID"
            cmbTransporter.DataSource = cnn.BindTransportCityWise(Val(cmbDestination.SelectedValue))

            If cmbTransporter.Items.Count > 0 Then
                cmbTransporter.SelectedIndex = 0
            End If
            'Dim strSQL As String
            'strSQL = "SELECT TOP 1 ID FROM dbo.LOG_tblMaster WHERE (CityID = " & Val(cmbDestination.SelectedValue) & ")"
            'Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
            'If cmd.Connection.State = 1 Then cmd.Connection.Close()
            'cmd.Connection.Open()
            'Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
            'If dr.Read Then
            '    cmbTransporter.SelectedValue = dr.Item("ID")
            'End If
            'dr.Close()
            'cmd.Connection.Close()
        Else
            cmbTransporter.SelectedIndex = -1
        End If

    End Sub
    Private Sub btnDestCancel_Click(sender As Object, e As EventArgs) Handles btnDestCancel.Click
        frameDestination.Visible = False : cmbDestination.Focus()
    End Sub
    Private Sub btnDestSave_Click(sender As Object, e As EventArgs) Handles btnDestSave.Click
        If txtDestName.Text = "" Then
            cnn.ErrMsgBox("Please Enter City Name  !")
            txtDestName.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        '--------------------- CHECK DUPLICATE
        strSQL = "Select ID from LOG_tblMaster Where fldName=" & cnn.SQLquote(UCase(txtDestName.Text)) & " AND tType='CITY'"

        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtDestName.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        strSQL = "INSERT INTO LOG_tblMaster (fldName, tType, CreatedBy, CreatedDate) VALUES (" & cnn.SQLquote(UCase(txtDestName.Text)) & ",'CITY'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        cnn.executeSQL(strSQL)

        cnn.InfoMsgBox("Record has been Added Successfully  !")
        '--------------------------- DESTINATION
        cmbDestination.DisplayMember = "fldName"
        cmbDestination.ValueMember = "ID"
        cmbDestination.DataSource = cnn.BindMaster(3)
        cmbDestination.SelectedIndex = -1
        '-----------
        cmbDestination.Text = UCase(txtDestName.Text) : txtDestName.Text = "" : frameDestination.Visible = False
    End Sub
    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        SaveData()
        PrintInvoice()
    End Sub
    Private Sub PrintInvoice()
        If iSave > 0 Then
            Call DisplayInvoice(1)
            'Call DisplayInvoice(2)
            'Call DisplayInvoice(3)
        End If
    End Sub
    Private Sub DisplayInvoice(iCopy As Integer)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        Dim iNum As Integer

        iNum = cnn.GetID(Val(lblOldNo.Text), cnn.GetDate(lblOldDate.Text), "BILTY")
        strSelection = "{rptInvoice.InvoiceID} = " & Val(iNum)
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        '===== Generate report preview =====================
        strSelection = strSelection & " AND {rptInvoice.CopyType} IN ['CONSIGNEE COPY','DRIVER COPY']"

        strReportName = Application.StartupPath & "\Reports\Bilty.rpt"
        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Cursor.Current = Cursors.WaitCursor
        CrxReport.Refresh()
        objfrmRptViewer.CRViewer.ReportSource = CrxReport
        objfrmRptViewer.CRViewer.SelectionFormula = strSelection
        'If iCopy = 1 Then
        '    CrxReport.DataDefinition.FormulaFields("CopyName").Text = "'Consignor Copy'"
        'ElseIf iCopy = 2 Then
        '    CrxReport.DataDefinition.FormulaFields("CopyName").Text = "'Consignee Copy'"
        'ElseIf iCopy = 3 Then
        '    CrxReport.DataDefinition.FormulaFields("CopyName").Text = "'Driver Copy'"
        'End If
        objfrmRptViewer.CRViewer.RefreshReport()
        objfrmRptViewer.CRViewer.ShowExportButton = True
        objfrmRptViewer.CRViewer.ShowPrintButton = True
        objfrmRptViewer.Text = "Bilty"
        objfrmRptViewer.Show()
        objfrmRptViewer.WindowState = FormWindowState.Maximized
        Cursor.Current = Cursors.Default
        '===================================================
        cnn.executeSQL("UPDATE LOG_tblInvoice SET Printed = 'Y' WHERE InvoiceID = " & Val(iNum))
        iSave = 0
m_quit:
        objfrmRptViewer = Nothing
        Exit Sub
m_err:
        MsgBox("Flow error!", vbCritical)
        GoTo m_quit
m_err2:
        MsgBox(Err.Description, vbCritical)
        GoTo m_quit
    End Sub
    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
    Private Sub Grid2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid2.CellBeginEdit
        If e.ColumnIndex = 2 Then
            Dim crRowIndex As Integer = Grid2.CurrentCell.RowIndex
            If Grid2.Rows(crRowIndex).Cells(3).Value.ToString = "Y" Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Grid2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid2.CellEndEdit
        Dim result As Double
        result = Grid2.CurrentCell.Value
        If Not IsNumeric(Grid2.CurrentCell.Value) Then
            cnn.ErrMsgBox("Invalid Amount, Please Check  !") '
            Grid2.CurrentCell.Value = 0
            Exit Sub
        End If
        CalculateSundryGrid()
    End Sub
    Private Sub Grid2_GotFocus(sender As Object, e As EventArgs) Handles Grid2.GotFocus
        If iGrid = 0 Then
            If Grid2.RowCount > 1 Then
                Grid2.CurrentCell = Grid2(2, 0)
            End If
            iGrid = 1
        End If
    End Sub
    Private Sub Grid2_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{right}")
            SendKeys.Send("{up}")
        End If
    End Sub

    Private Sub BookingType()
        If rbToPay.Checked = True Then
            rbCnse.Checked = True
        ElseIf rbPaid.Checked = True Then
            rbCnsr.Checked = True
        ElseIf rbTBB.Checked = True Then
            rbCnsr.Checked = True
        End If
    End Sub

    Private Sub GetAmount()
        If lblRateBy.Text = "P" Then
            txtAmount.Text = Val(txtPackage.Text) * Val(txtRate.Text)
        Else
            txtAmount.Text = Val(txtChargeWt.Text) * Val(txtRate.Text)
        End If
        txtAmount.Text = cnn.Num2(txtAmount.Text)
        'GridTotal()
        
    End Sub
    Private Sub GetTotal()
        txtTotalPackage.Text = txtPackage.Text
        txtTotalActualWeight.Text = txtActualWt.Text
        txtTotalChargeWeight.Text = txtChargeWt.Text
        txtTotalAmount.Text = cnn.Num2(txtAmount.Text)
        CalculateSundryGrid()
    End Sub
    Private Sub Grid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid2.CellContentClick

    End Sub

    Private Sub rbPaid_CheckedChanged(sender As Object, e As EventArgs) Handles rbPaid.CheckedChanged
        BookingType()
    End Sub

    Private Sub rbToPay_CheckedChanged(sender As Object, e As EventArgs) Handles rbToPay.CheckedChanged
        BookingType()
    End Sub

    Private Sub rbTBB_CheckedChanged(sender As Object, e As EventArgs) Handles rbTBB.CheckedChanged
        BookingType()
    End Sub

    Private Sub rbPaid_GotFocus(sender As Object, e As EventArgs) Handles rbPaid.GotFocus
        rbPaid.ForeColor = Color.Red
    End Sub

    Private Sub rbPaid_LostFocus(sender As Object, e As EventArgs) Handles rbPaid.LostFocus
        rbPaid.ForeColor = Color.Maroon
    End Sub

    Private Sub rbToPay_GotFocus(sender As Object, e As EventArgs) Handles rbToPay.GotFocus
        rbToPay.ForeColor = Color.Red
    End Sub

    Private Sub rbToPay_LostFocus(sender As Object, e As EventArgs) Handles rbToPay.LostFocus
        rbToPay.ForeColor = Color.Maroon
    End Sub

    Private Sub rbTBB_GotFocus(sender As Object, e As EventArgs) Handles rbTBB.GotFocus
        rbTBB.ForeColor = Color.Red
    End Sub

    Private Sub rbTBB_LostFocus(sender As Object, e As EventArgs) Handles rbTBB.LostFocus
        rbTBB.ForeColor = Color.Maroon
    End Sub

    Private Sub txtActualWt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtActualWt.KeyPress
        e.Handled = cnn.IsNumericTextbox(sender, e.KeyChar)
    End Sub

    Private Sub txtActualWt_TextChanged(sender As Object, e As EventArgs) Handles txtActualWt.TextChanged
        txtChargeWt.Text = txtActualWt.Text
        GetAmount()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        'GetAmount()
        GetTotal()
    End Sub
End Class