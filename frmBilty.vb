Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBilty
    Dim cnn As New DataConn.Conn
    Dim strSQL As String
    Dim iSave As Integer = 0
    Private focusedForeColor As Color = Color.White
    Private focusedBackColor As Color = Color.Black
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
    Private Sub frmBilty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBilty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        StripPanel.Width = MDI.Width : lblHR2.Width = MDI.Width
        If Date.Now.Hour > 4 Then
            txtDate.Text = Date.Today
        Else
            txtDate.Text = DateAdd(DateInterval.Day, -1, Date.Today)
        End If
        GetInvoiceNo()
        ''--------------------------- INVOICE
        cmbInvoice.DisplayMember = "InvName"
        cmbInvoice.ValueMember = "InvoiceID"
        cmbInvoice.DataSource = cnn.BindMaster(6)
        cmbInvoice.SelectedIndex = -1
        '--------------------------- TRUCK NO
        cmbTruckNo.DisplayMember = "TruckNo" : cmbTruckNo.ValueMember = "TruckNo" : cmbTruckNo.DataSource = cnn.BindTruckNo() : cmbTruckNo.SelectedIndex = -1
        '--------------------------- DRIVERNAME
        cmbDriverName.DisplayMember = "DriverName" : cmbDriverName.ValueMember = "DriverName" : cmbDriverName.DataSource = cnn.BindDriverName() : cmbDriverName.SelectedIndex = -1
        '--------------------------- DRIVER ADDRESS
        cmbDriverAddress.DisplayMember = "DriverAddress" : cmbDriverAddress.ValueMember = "DriverAddress" : cmbDriverAddress.DataSource = cnn.BindDriverAddress() : cmbDriverAddress.SelectedIndex = -1
        '--------------------------- TO NAME
        cmbTo.DisplayMember = "ToName" : cmbTo.ValueMember = "ToName" : cmbTo.DataSource = cnn.BindTo() : cmbTo.SelectedIndex = -1
        '--------------------------- OWNER NAME
        cmbOwnerName.DisplayMember = "OwnerName" : cmbOwnerName.ValueMember = "OwnerName" : cmbOwnerName.DataSource = cnn.BindOwnerName() : cmbOwnerName.SelectedIndex = -1
        '--------------------------- OWNER ADDRESS
        cmbOwnerAddress.DisplayMember = "OwnerAddress" : cmbOwnerAddress.ValueMember = "OwnerAddress" : cmbOwnerAddress.DataSource = cnn.BindOwnerAddress() : cmbOwnerAddress.SelectedIndex = -1
        '--------------------------- TO ADDRESS
        cmbToAddress.DisplayMember = "ToAddress" : cmbToAddress.ValueMember = "ToAddress" : cmbToAddress.DataSource = cnn.BindToAddress() : cmbToAddress.SelectedIndex = -1

        BindGrid()
    End Sub
    Public Function BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        If lblID.Text = "" Then
            strSQL = "SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, 0 as Edited" _
            & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.Bilty = 'N') AND (I.Cancelled = 'N') GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, D.fldName" _
            & " ORDER BY I.InvoiceDate, I.InvoiceID"
        Else
            strSQL = "SELECT TOP (100) PERCENT InvoiceID, InvoiceNo, InvoiceDate, Destination, CRName, CEName, BookingType, TotalPackage, TotalActualWeight, TotalChargeWeight, TotalAmount, TaxableAmount, BillAmount, Bilty, 1 as Edited FROM (" _
            & " SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty FROM dbo.LOG_tblInvoice AS I INNER JOIN" _
            & " dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.Bilty = 'Y') AND (I.Cancelled = 'N') AND (I.InvoiceID IN (SELECT InvoiceID FROM dbo.LOG_tblChallanDetails WHERE (HeaderID = " & Val(lblID.Text) & ")))" _
            & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, D.fldName" _
            & " UNION ALL" _
            & " SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty FROM dbo.LOG_tblInvoice AS I INNER JOIN" _
            & " dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.Bilty = 'N') AND (I.Cancelled = 'N') GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, D.fldName" _
            & " ) AS t ORDER BY InvoiceDate, InvoiceID"
        End If
        '--------------------
        If cnn.cnn.State = 1 Then
            cnn.cnn.Close()
        End If
        cnn.cnn.Open()
        '--------------------
        Grid.Columns.Clear()
        Dim chkboxcol As New DataGridViewCheckBoxColumn
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns.Insert(0, chkboxcol)
        With chkboxcol
            .HeaderText = "Select"
            .Name = "RecSel"
            .DisplayIndex = 0
        End With
        Grid.Columns(1).HeaderText = "ID"
        Grid.Columns(1).Visible = False
        Grid.Columns(2).HeaderText = "Invoice No"
        Grid.Columns(3).HeaderText = "Invoice Date"
        Grid.Columns(4).HeaderText = "Destination"
        Grid.Columns(5).HeaderText = "Consigner Name"
        Grid.Columns(6).HeaderText = "Consignee Name"
        Grid.Columns(7).HeaderText = "Booking Type"
        Grid.Columns(8).HeaderText = "Total Package"
        Grid.Columns(9).HeaderText = "Actual Weight"
        Grid.Columns(10).HeaderText = "Charge Weight"
        Grid.Columns(11).HeaderText = "Freight Amt"
        Grid.Columns(12).HeaderText = "Taxable Amt"
        Grid.Columns(13).HeaderText = "Bill Amount"
        Grid.Columns(14).HeaderText = "Challan"
        Grid.Columns(15).HeaderText = "Edited"
        Grid.Columns(15).Visible = False
        If lblID.Text <> "" Then
            For i = 0 To Grid.RowCount - 1
                If Grid.Rows(i).Cells(14).Value = "Y" Then
                    Grid.Rows(i).Cells(0).Value = True
                End If
            Next
        End If
    End Function
    Private Sub CalcTotal()
        Dim tPackage, tActWt, tChWt, tAmount As Integer
        tPackage = 0 : tActWt = 0 : tChWt = 0 : tAmount = 0
        For i = 0 To Grid.RowCount - 1
            If Grid.Rows(i).Cells(0).Value = True Then
                tPackage = Val(tPackage) + Val(Grid.Rows(i).Cells(8).Value)
                tActWt = Val(tActWt) + Val(Grid.Rows(i).Cells(9).Value)
                tChWt = Val(tChWt) + Val(Grid.Rows(i).Cells(10).Value)
                tAmount = Val(tAmount) + Val(Grid.Rows(i).Cells(13).Value)
            End If
        Next
        txtTotalPackage.Text = tPackage : txtTotalActualWeight.Text = tActWt : txtTotalChargeWeight.Text = tChWt : txtTotalAmount.Text = tAmount
    End Sub
    Private Sub GetInvoiceNo()
        Dim strSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        strSQL = "SELECT BiltyNo from LOG_tblPara Where CompanyID = " & Val(MDI.lblCompanyID.Text) & " AND SessionID = " & Val(MDI.lblSessionID.Text)
        Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("BiltyNo")) Then
                txtInvoiceNo.Text = dr.Item("BiltyNo")
            Else
                cnn.ErrMsgBox("There is a Problem in Entry, Please Contact Software Administrator  !")
                Exit Sub
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
        frameGrid.Visible = True
        'Exit Sub
        'If txtInvoiceNo.Text = "" Then
        '    cnn.ErrMsgBox("Please Enter Invoice No  !")
        '    txtInvoiceNo.Focus()
        '    Exit Sub
        'End If
        'If txtDate.Text = "" Then
        '    cnn.ErrMsgBox("Please Enter Invoice Date  !")
        '    txtDate.Focus()
        '    Exit Sub
        'End If
        'If cmbInvoice.Text = "" Then
        '    cnn.ErrMsgBox("Please Select Invoice Details  !")
        '    cmbInvoice.Focus()
        '    Exit Sub
        'End If
        'If cmbInvoice.SelectedValue = 0 Then
        '    cnn.ErrMsgBox("Please Select Invoice Details from List !")
        '    cmbInvoice.Focus()
        '    Exit Sub
        'End If

    End Sub
    Public Sub GridTotal()
        Dim iTotActualWt, iTotChargeWt, iTotPkg, iTotAmt
        iTotActualWt = 0 : iTotAmt = 0 : iTotPkg = 0 : iTotChargeWt = 0
        For i = 0 To Grid.Rows.Count - 1
            iTotPkg = Val(iTotPkg) + Val(Grid.Rows(i).Cells(4).Value)
            iTotActualWt = Val(iTotActualWt) + Val(Grid.Rows(i).Cells(5).Value)
            iTotChargeWt = Val(iTotChargeWt) + Val(Grid.Rows(i).Cells(6).Value)
            iTotAmt = Val(iTotAmt) + Val(Grid.Rows(i).Cells(9).Value)
        Next
        txtTotalPackage.Text = iTotPkg
        txtTotalActualWeight.Text = iTotActualWt
        txtTotalChargeWeight.Text = iTotChargeWt
        txtTotalAmount.Text = cnn.Num2(iTotAmt)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
    End Sub
    Private Sub SaveData()
        If cmbTruckNo.Text = "" Then
            cnn.ErrMsgBox("Please Enter Truck No.  !")
            cmbTruckNo.Focus()
            Exit Sub
        End If
        If cmbDriverName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Driver Name  !")
            cmbDriverName.Focus()
            Exit Sub
        End If
        If cmbOwnerName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Owner Name !")
            cmbOwnerName.Focus()
            Exit Sub
        End If
        If cmbOwnerAddress.Text = "" Then
            cnn.ErrMsgBox("Please Enter Owner Address  !")
            cmbOwnerAddress.Focus()
            Exit Sub
        End If
        If cmbDriverAddress.Text = "" Then
            cnn.ErrMsgBox("Please Enter Driver Address  !")
            cmbDriverAddress.Focus()
            Exit Sub
        End If
        If cmbTo.Text = "" Then
            cnn.ErrMsgBox("Please Enter Company Name  !")
            cmbTo.Focus()
            Exit Sub
        End If
        If cmbToAddress.Text = "" Then
            cnn.ErrMsgBox("Please Enter Address  !")
            cmbToAddress.Focus()
            Exit Sub
        End If
        If Grid.Rows.Count < 1 Then
            cnn.ErrMsgBox("Please Enter Product Details  !")
            cmbInvoice.Focus()
            Exit Sub
        End If
        Dim bBool As Boolean
        bBool = False
        For i = 0 To Grid.Rows.Count - 1
            If Grid(0, i).Value = True Then
                bBool = True
            End If
        Next
        If bBool = False Then
            cnn.ErrMsgBox("Please Select Bilty !")
            Exit Sub
        End If
        CalcTotal()

        '=================================
        If lblID.Text = "" Then
            GetInvoiceNo()
            '-------------------------------------------------
            strSQL = "INSERT INTO LOG_tblChallan (ChallanNo, ChallanDate, TruckNo, DriverName, DriverAddress, OwnerName, OwnerAddress, eWayBillNo, ToName, ToAddress, TotalPackage, ActualWeight, ChargeWeight, TotalAmount, CompanyID, CreatedBy, CreatedDate, SessionID) OutPut Inserted.ChallanID as HeaderID VALUES (" _
            & Val(txtInvoiceNo.Text) & ",'" & cnn.GetDate(txtDate.Text) & "'," & cnn.SQLquote(UCase(cmbTruckNo.Text)) & "," & cnn.SQLquote(UCase(cmbDriverName.Text)) & "," & cnn.SQLquote(UCase(cmbDriverAddress.Text)) & "," & cnn.SQLquote(UCase(cmbOwnerName.Text)) & "," & cnn.SQLquote(UCase(cmbOwnerAddress.Text)) _
            & "," & cnn.SQLquote(UCase(txteWayBillNo.Text)) & "," & cnn.SQLquote(UCase(cmbTo.Text)) & "," & cnn.SQLquote(UCase(cmbToAddress.Text)) & "," & Val(txtTotalPackage.Text) & "," & Val(txtTotalActualWeight.Text) & "," & Val(txtTotalChargeWeight.Text) & "," & Val(txtTotalAmount.Text) & "," & Val(MDI.lblCompanyID.Text) _
            & "," & Val(MDI.lblUserLoginID.Text) & ",DATEADD(MINUTE, 330, GETUTCDATE())," & Val(MDI.lblSessionID.Text) & ")"
            Dim cmd As Data.Odbc.OdbcCommand
            Dim dr As Data.Odbc.OdbcDataReader
            cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
            If cmd.Connection.State = 1 Then cmd.Connection.Close()
            cmd.Connection.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                lblHeaderID.Text = dr.Item("HeaderID")
            End If
            dr.Close()
            cmd.Connection.Close()
        Else
            strSQL = "UPDATE LOG_tblChallan SET ChallanDate='" & cnn.GetDate(txtDate.Text) & "', TruckNo=" & cnn.SQLquote(UCase(cmbTruckNo.Text)) & ", DriverName=" & cnn.SQLquote(UCase(cmbDriverName.Text)) & ", DriverAddress=" & cnn.SQLquote(UCase(cmbDriverAddress.Text)) _
            & ", OwnerName=" & cnn.SQLquote(UCase(cmbOwnerName.Text)) & ", OwnerAddress=" & cnn.SQLquote(UCase(cmbOwnerAddress.Text)) & ", eWayBillNo=" & cnn.SQLquote(UCase(txteWayBillNo.Text)) & ", ToName=" & cnn.SQLquote(UCase(cmbTo.Text)) & ", ToAddress=" & cnn.SQLquote(UCase(cmbToAddress.Text)) _
            & ", TotalPackage=" & Val(txtTotalPackage.Text) & ", ActualWeight=" & Val(txtTotalActualWeight.Text) & ", ChargeWeight=" & Val(txtTotalChargeWeight.Text) & ", TotalAmount=" & Val(txtTotalAmount.Text) & ", EditedBy=" & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "'" _
            & " WHERE ChallanID=" & Val(lblID.Text)
            cnn.executeSQL(strSQL) : lblHeaderID.Text = lblID.Text
        End If
        SaveDetails()
        lblOldNo.Text = txtInvoiceNo.Text : lblOldDate.Text = txtDate.Text
        '==================================
        If lblID.Text = "" Then
            strSQL = "UPDATE LOG_tblPara SET BiltyNo = (BiltyNo + 1) Where CompanyID = " & Val(MDI.lblCompanyID.Text) & " AND SessionID = " & Val(MDI.lblSessionID.Text)
            cnn.executeSQL(strSQL)
            cnn.InfoMsgBox("Record has been Saved Successfully  !")
        Else
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
        End If
        iSave = 1
        lblID.Text = "" : txtInvoiceNo.Text = "" : cmbTruckNo.Text = "" : cmbDriverName.Text = "" : cmbDriverAddress.Text = "" : cmbOwnerName.Text = "" : cmbOwnerAddress.Text = ""
        txtTotalPackage.Text = "" : cmbTo.Text = "" : cmbToAddress.Text = "" : txtTotalActualWeight.Text = "" : txtTotalChargeWeight.Text = "" : txtTotalAmount.Text = "" : txteWayBillNo.Text = "" : cmbInvoice.SelectedIndex = -1
        If Date.Now.Hour > 4 Then
            txtDate.Text = Date.Today
        Else
            txtDate.Text = DateAdd(DateInterval.Day, -1, Date.Today)
        End If
        GetInvoiceNo()

        ' ''--------------------------- INVOICE
        'cmbInvoice.DisplayMember = "InvName"
        'cmbInvoice.ValueMember = "InvoiceID"
        'cmbInvoice.DataSource = cnn.BindMaster(6)
        'cmbInvoice.SelectedIndex = -1
        ''------------------------
        'txtInvoiceNo.Focus()
        BindGrid() : txtDate.Focus()
    End Sub
    Private Sub SaveDetails()
        Dim strSQL As String
        If lblID.Text <> "" Then
            strSQL = "UPDATE LOG_tblInvoice SET Bilty = 'N' WHERE InvoiceID IN (SELECT InvoiceID From LOG_tblChallanDetails WHERE HeaderID=" & Val(lblID.Text) & ")"
            cnn.executeSQL(strSQL)
            cnn.executeSQL("DELETE From LOG_tblChallanDetails Where HeaderID=" & lblID.Text)
        End If

        For i = 0 To Grid.Rows.Count - 1
            If Grid.Rows(i).Cells(0).Value = True Then
                strSQL = "INSERT INTO LOG_tblChallanDetails (HeaderID, InvoiceID) VALUES("
                strSQL = strSQL & Val(lblHeaderID.Text) & "," & Val(Grid.Rows(i).Cells(1).Value) & ")"
                cnn.executeSQL(strSQL)
                strSQL = "UPDATE LOG_tblInvoice SET Bilty = 'Y', ChNo=" & Val(txtInvoiceNo.Text) & ", ChDate=DATEADD(MINUTE, 330, GETUTCDATE()) WHERE InvoiceID = " & Val(Grid.Rows(i).Cells(1).Value)
                cnn.executeSQL(strSQL)
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        SaveData()
        PrintInvoice()
        If lblID.Text <> "" Then
            Me.Close()
        End If
    End Sub
    Private Sub PrintInvoice()
        If iSave > 0 Then
            Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportName As String
            Dim reportDesc As String = "Challan"
            strReportName = Application.StartupPath & "\Reports\Challan.rpt"
            CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            Call DisplayInvoice(CrxReport, reportDesc)
        End If
    End Sub
    Private Sub DisplayInvoice(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        Dim iNum As Integer
        iNum = cnn.GetID(Val(lblOldNo.Text), cnn.GetDate(lblOldDate.Text), "CHALLAN")
        strSelection = "{rptChallan.ChallanID} = " & Val(iNum)

        '===== Generate report preview =====================
        Cursor.Current = Cursors.WaitCursor
        CrxReport.Refresh()

        objfrmRptViewer.CRViewer.ReportSource = CrxReport
        objfrmRptViewer.CRViewer.SelectionFormula = strSelection
        objfrmRptViewer.CRViewer.RefreshReport()
        objfrmRptViewer.CRViewer.ShowExportButton = True
        objfrmRptViewer.CRViewer.ShowPrintButton = True
        objfrmRptViewer.Text = reportDesc
        objfrmRptViewer.Show()
        objfrmRptViewer.WindowState = FormWindowState.Maximized
        Cursor.Current = Cursors.Default
        '===================================================
        cnn.executeSQL("UPDATE LOG_tblChallan SET Printed = 'Y' WHERE ChallanID = " & Val(lblID.Text))
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

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Grid.Rows.Count > 0 Then
            Grid.Rows.RemoveAt(Grid.CurrentCell.RowIndex)
        End If
        GridTotal() : ChangeColor()
    End Sub
    Private Sub GetDetails(iID As Integer)
        '---------
        For i = 0 To Grid.Rows.Count - 1
            If Val(iID) = Grid.Rows(i).Cells(0).Value Then
                cnn.ErrMsgBox("Duplicate Entry, Please check  !")
                Exit Sub
            End If
        Next
        '----------------------------
        strSQL = "SELECT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, P.fldName AS ProductName, ID.Packages, ID.ActualWeight, ID.ChargeWeight, D.fldName AS DestinationName, A.AccountName, I.BillAmount" _
        & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblAccount AS A ON I.ConsigneeID = A.AccountID INNER JOIN dbo.LOG_tblMaster AS P ON ID.ProductID = P.ID INNER JOIN" _
        & " dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID WHERE(I.InvoiceID = " & Val(iID) & ")"
        Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
        If dr.Read Then
            Grid.Rows.Add(1)
            Grid.Rows(Grid.Rows.Count - 1).Cells(0).Value = dr.Item("InvoiceID")
            Grid.Rows(Grid.Rows.Count - 1).Cells(1).Value = dr.Item("InvoiceNo")
            Grid.Rows(Grid.Rows.Count - 1).Cells(2).Value = dr.Item("InvoiceDate")
            Grid.Rows(Grid.Rows.Count - 1).Cells(3).Value = dr.Item("ProductName")
            Grid.Rows(Grid.Rows.Count - 1).Cells(4).Value = dr.Item("Packages")
            Grid.Rows(Grid.Rows.Count - 1).Cells(5).Value = dr.Item("ActualWeight")
            Grid.Rows(Grid.Rows.Count - 1).Cells(6).Value = dr.Item("ChargeWeight")
            Grid.Rows(Grid.Rows.Count - 1).Cells(7).Value = dr.Item("DestinationName")
            Grid.Rows(Grid.Rows.Count - 1).Cells(8).Value = dr.Item("AccountName")
            Grid.Rows(Grid.Rows.Count - 1).Cells(9).Value = dr.Item("BillAmount")
        End If
        dr.Close()
        cmd.Connection.Close()
        GridTotal()
    End Sub

    Private Sub grdList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdList.CellContentClick

    End Sub

    Private Sub grdList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdList.CellDoubleClick
        If grdList.Rows.Count > 0 Then
            If grdList.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = grdList.CurrentCell.RowIndex
                Dim Iid As Integer = grdList.Rows(crRowIndex).Cells(0).Value.ToString
                GetDetails(Iid)
                ChangeColor()
            End If
        End If
    End Sub
    Public Function ChangeColor()
        For x = 0 To grdList.Rows.Count - 1
            For y = 0 To grdList.Columns.Count - 1
                grdList.Rows(x).Cells(y).Style.BackColor = Color.White
            Next
        Next
        Dim Iid As Integer
        For i = 0 To Grid.Rows.Count - 1
            Iid = Grid.Rows(i).Cells(0).Value.ToString
            For k = 0 To grdList.Rows.Count - 1
                If Iid = grdList.Rows(k).Cells(0).Value.ToString Then
                    For j = 0 To grdList.Columns.Count - 1
                        grdList.Rows(k).Cells(j).Style.BackColor = Color.Silver
                    Next
                End If
            Next
        Next

    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frameGrid.Visible = False
    End Sub

    Private Sub Grid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick

    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit

    End Sub

    Private Sub Grid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellValueChanged

    End Sub

    Private Sub Grid_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles Grid.CurrentCellDirtyStateChanged
        CalcTotal()
    End Sub

    Private Sub Grid_MouseClick(sender As Object, e As MouseEventArgs) Handles Grid.MouseClick

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        CalcTotal()
    End Sub

    Private Sub chkALL_CheckdChanged(sender As Object, e As EventArgs) Handles chkALL.CheckedChanged
        If chkALL.Checked = True Then
            For i = 0 To Grid.Rows.Count - 1
                Grid.Rows(i).Cells(0).Value = True
            Next
        Else
            For i = 0 To Grid.Rows.Count - 1
                Grid.Rows(i).Cells(0).Value = False
            Next
        End If
        CalcTotal()
    End Sub
End Class