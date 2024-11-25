Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBill
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

    Private Sub frmBill_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        StripPanel.Width = MDI.Width
        txtDate.Text = Date.Today
        GetInvoiceNo()
        txtFromDate.Text = DateAdd(DateInterval.Month, -1, Date.Today)
        txtToDate.Text = Date.Today
        '--------------------------- DESTINATION
        cmbDestination.DisplayMember = "fldName"
        cmbDestination.ValueMember = "ID"
        cmbDestination.DataSource = cnn.BindMaster(3)
        cmbDestination.SelectedIndex = -1
        ''--------------------------- CONSIGNEE
        cmbConsignee.DisplayMember = "AccountName"
        cmbConsignee.ValueMember = "AccountID"
        cmbConsignee.DataSource = cnn.BindMaster(1)
        cmbConsignee.SelectedIndex = -1
        BindAccount()
    End Sub
    Private Sub GetInvoiceNo()
        Dim strSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        strSQL = "SELECT MonthlyBillNo from LOG_tblPara Where CompanyID = " & Val(MDI.lblCompanyID.Text) & " AND SessionID = " & Val(MDI.lblSessionID.Text)
        Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        Dim dr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("MonthlyBillNo")) Then
                Dim iNo As Integer = dr.Item("MonthlyBillNo")
                txtInvoiceNo.Text = "INV/" & iNo.ToString("D3")
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
    Public Function BindAccount()
        If rbCNSE.Checked = True Then
            lblAccount.Text = "Consignee Name"
            ''--------------------------- CONSIGNEE
            cmbAccount.DisplayMember = "AccountName"
            cmbAccount.ValueMember = "AccountID"
            cmbAccount.DataSource = cnn.BindMaster(1)
            cmbAccount.SelectedIndex = -1
        Else
            lblAccount.Text = "Consignor Name"
            ''--------------------------- CONSIGNOR
            cmbAccount.DisplayMember = "AccountName"
            cmbAccount.ValueMember = "AccountID"
            cmbAccount.DataSource = cnn.BindMaster(0)
            cmbAccount.SelectedIndex = -1
        End If
    End Function

    Private Sub rbCNSR_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNSR.CheckedChanged
        BindAccount()
    End Sub

    Private Sub rbCNSE_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNSE.CheckedChanged
        BindAccount()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
    End Sub
    Private Sub SaveData()
        Try
            iSave = 0
            If cmbAccount.Text = "" Then
                cnn.ErrMsgBox("Please Select Consignor/Consignee Name  !")
                cmbAccount.Focus()
                Exit Sub
            End If
            If cmbAccount.SelectedValue = 0 Then
                cnn.ErrMsgBox("Please Select Consignor/Consignee Name from List  !")
                cmbAccount.Focus()
                Exit Sub
            End If
            '--------------------
            Dim cmd As Data.Odbc.OdbcCommand
            Dim dr As Data.Odbc.OdbcDataReader
            Dim partyType As String = ""
            Dim iPayType As String = ""
            If rbCNSE.Checked = True Then
                partyType = "CNSE"
            Else
                partyType = "CNSR"
            End If
            If rbToPay.Checked = True Then
                iPayType = "TOPAY"
            ElseIf rbPaid.Checked = True Then
                iPayType = "PAID"
            ElseIf rbTBB.Checked = True Then
                iPayType = "TBB"
            End If
            '-------------------------------------------------
            If lblID.Text <> "" Then
                strSQL = "UPDATE LOG_tblBillHeader SET BillDate='" & cnn.GetDate(txtDate.Text) & "', BookType='" & iPayType & "', PartyType='" & partyType & "', PartyID=" & Val(cmbAccount.SelectedValue) _
                & ", FromDate='" & cnn.GetDate(txtFromDate.Text) & "', ToDate='" & cnn.GetDate(txtToDate.Text) & "', EditedBy=" & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "'" _
                & ", TotalPackage=" & Val(txtTotalPackage.Text) & ", BillAmount=" & Val(txtTotalAmount.Text) & ", GST=" & Val(txtGST.Text) & ", GBillAmount=" & Val(txtGAmount.Text) & ", TotPackage=" & Val(txtTotalPackage.Text) & ", TotChargeWeight=" & Val(txtTotalChargeWeight.Text) _
                & " WHERE ID=" & Val(lblID.Text)
                cnn.executeSQL(strSQL)
                lblHeaderID.Text = lblID.Text
            Else
                strSQL = "INSERT INTO LOG_tblBillHeader (BillNo, BillDate, BookType, PartyType, PartyID, FromDate, ToDate, CreatedBy, CreatedDate, CompanyID, SessionID, TotalPackage, BillAmount,GST,GBillAmount, TotPackage, TotChargeWeight) OutPut Inserted.ID as HeaderID VALUES (" _
                & cnn.SQLquote(txtInvoiceNo.Text) & ",'" & cnn.GetDate(txtDate.Text) & "','" & iPayType & "','" & partyType & "'," & Val(cmbAccount.SelectedValue) _
                & ",'" & cnn.GetDate(txtFromDate.Text) & "','" & cnn.GetDate(txtToDate.Text) & "'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "'" _
                & "," & Val(MDI.lblCompanyID.Text) & "," & Val(MDI.lblSessionID.Text) & "," & Val(txtTotalPackage.Text) & "," & Val(txtTotalAmount.Text) & "," & Val(txtGST.Text) & "," & Val(txtGAmount.Text) & "," & Val(txtTotalPackage.Text) & "," & Val(txtTotalChargeWeight.Text) & ")"

                cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
                If cmd.Connection.State = 1 Then cmd.Connection.Close()
                cmd.Connection.Open()
                dr = cmd.ExecuteReader
                If dr.Read Then
                    lblHeaderID.Text = dr.Item("HeaderID")
                End If
                dr.Close()
                cmd.Connection.Close()
            End If
            SaveDetails()
            '==================================
            If lblID.Text = "" Then
                strSQL = "UPDATE LOG_tblPara SET MonthlyBillNo = (MonthlyBillNo + 1) Where CompanyID = " & Val(MDI.lblCompanyID.Text) _
                & " AND SessionID = " & Val(MDI.lblSessionID.Text)
                cnn.executeSQL(strSQL)
                cnn.InfoMsgBox("Record has been Saved Successfully  !")
            Else
                cnn.InfoMsgBox("Record has been Updated Successfully  !")
            End If
            '==================================
            txtTotalPackage.Text = "" : txtTotalAmount.Text = "" : txtTotalChargeWeight.Text = ""
            iSave = 1 : ClearText() : GetInvoiceNo() : BindGridBilty() : txtDate.Focus()
        Catch ex As Exception
            iSave = 0
            cnn.ErrMsgBox("There is a Problem " & ex.Message)
        End Try
    End Sub
    Private Sub SaveDetails()
        Dim strSQL As String
        If lblID.Text <> "" Then
            cnn.executeSQL("DELETE From LOG_tblBillDetails Where HeaderID=" & lblID.Text)
        End If

        For i = 0 To Grid.Rows.Count - 1
            If Grid.Rows(i).Cells(0).Value = True Then
                strSQL = "INSERT INTO LOG_tblBillDetails (HeaderID, BiltyID) VALUES("
                strSQL = strSQL & Val(lblHeaderID.Text) & "," & Val(Grid.Rows(i).Cells(1).Value) & ")"
                cnn.executeSQL(strSQL)
            End If
        Next
    End Sub
    Private Sub ClearText()
        txtDate.Text = Date.Today() : rbCNSR.Checked = True : txtFromDate.Text = DateAdd(DateInterval.Month, -1, Date.Today) : txtToDate.Text = Date.Today
        cmbConsignee.SelectedIndex = -1 : cmbAccount.SelectedIndex = -1 : cmbDestination.SelectedIndex = -1 : lblID.Text = ""
        Grid.DataSource = Nothing
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        SaveData()
        DisplayInvoice()
    End Sub
    Private Sub DisplayInvoice()
        If iSave > 0 Then
            Dim objfrmRptViewer As New frmRptViewer
            Dim strSelection As String
            strSelection = "{rptInvoice.ID} = " & Val(lblHeaderID.Text)
            Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportName As String
            '===== Generate report preview =====================

            strReportName = Application.StartupPath & "\Reports\MonthlyInvoice.rpt"
            CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            Cursor.Current = Cursors.WaitCursor
            CrxReport.Refresh()
            objfrmRptViewer.CRViewer.ReportSource = CrxReport
            objfrmRptViewer.CRViewer.SelectionFormula = strSelection
            objfrmRptViewer.CRViewer.RefreshReport()
            objfrmRptViewer.CRViewer.ShowExportButton = True
            objfrmRptViewer.CRViewer.ShowPrintButton = True
            objfrmRptViewer.Text = "Bilty"
            objfrmRptViewer.Show()
            objfrmRptViewer.WindowState = FormWindowState.Maximized
            Cursor.Current = Cursors.Default
            '===================================================
            iSave = 0 : lblHeaderID.Text = ""
m_quit:
            objfrmRptViewer = Nothing
            Exit Sub
m_err:
            MsgBox("Flow error!", vbCritical)
            GoTo m_quit
m_err2:
            MsgBox(Err.Description, vbCritical)
            GoTo m_quit
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BindGridBilty()
    End Sub
    Public Function BindGridBilty()
        Dim strSQL, sSQL, iPayType As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = "" : iPayType = ""
        If rbToPay.Checked = True Then
            iPayType = "TOPAY"
        ElseIf rbPaid.Checked = True Then
            iPayType = "PAID"
        ElseIf rbTBB.Checked = True Then
            iPayType = "TBB"
        End If
        If lblID.Text = "" Then
            strSQL = "SELECT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, 0 as Edited" _
           & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID INNER JOIN" _
           & " dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
           & " WHERE (I.InvoiceID NOT IN (SELECT BiltyID From LOG_tblBillDetails)) AND (I.Cancelled = 'N') AND (I.BookingType = '" & iPayType & "')" _
           & " AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
            If rbCNSE.Checked = True Then
                strSQL = strSQL & " AND (I.ConsigneeID = " & Val(cmbAccount.SelectedValue) & ")"
            Else
                strSQL = strSQL & " AND (I.ConsignerID = " & Val(cmbAccount.SelectedValue) & ")"
            End If
            If cmbConsignee.Text <> "" Then
                strSQL = strSQL & " AND I.ConsigneeID = " & Val(cmbConsignee.SelectedValue)
            End If
            If cmbDestination.Text <> "" Then
                strSQL = strSQL & " AND I.DestinationID = " & Val(cmbDestination.SelectedValue)
            End If
            strSQL = strSQL & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, D.fldName"
            strSQL = strSQL & " ORDER BY I.InvoiceDate DESC, I.InvoiceID DESC"
        Else
            strSQL = "SELECT TOP (100) PERCENT InvoiceID, InvoiceNo, InvoiceDate, Destination, CRName, CEName, BookingType, TotalPackage, TotalActualWeight, TotalChargeWeight, TotalAmount, TaxableAmount, BillAmount, Bilty, Edited FROM (" _
            & " SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, 0 as Edited" _
            & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.InvoiceID NOT IN (SELECT BiltyID FROM dbo.LOG_tblBillDetails)) AND (I.Cancelled = 'N') AND (I.BookingType = '" & iPayType & "')" _
            & " AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ")" _
            & " AND (I.InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
            If rbCNSE.Checked = True Then
                strSQL = strSQL & " AND (I.ConsigneeID = " & Val(cmbAccount.SelectedValue) & ")"
            Else
                strSQL = strSQL & " AND (I.ConsignerID = " & Val(cmbAccount.SelectedValue) & ")"
            End If
            If cmbConsignee.Text <> "" Then
                strSQL = strSQL & " AND I.ConsigneeID = " & Val(cmbConsignee.SelectedValue)
            End If
            If cmbDestination.Text <> "" Then
                strSQL = strSQL & " AND I.DestinationID = " & Val(cmbDestination.SelectedValue)
            End If
            strSQL = strSQL & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, D.fldName" _
            & " UNION ALL" _
            & " SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage,  I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, 1 as Edited FROM dbo.LOG_tblInvoice AS I INNER JOIN" _
            & " dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.InvoiceID IN (SELECT BiltyID FROM dbo.LOG_tblBillDetails AS LOG_tblBillDetails_1 WHERE (HeaderID = " & Val(lblID.Text) & "))) AND (I.Cancelled = 'N') AND (I.BookingType = '" & iPayType & "')" _
            & " AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ")" _
            & " AND (I.InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
            If rbCNSE.Checked = True Then
                strSQL = strSQL & " AND (I.ConsigneeID = " & Val(cmbAccount.SelectedValue) & ")"
            Else
                strSQL = strSQL & " AND (I.ConsignerID = " & Val(cmbAccount.SelectedValue) & ")"
            End If
            If cmbConsignee.Text <> "" Then
                strSQL = strSQL & " AND I.ConsigneeID = " & Val(cmbConsignee.SelectedValue)
            End If
            If cmbDestination.Text <> "" Then
                strSQL = strSQL & " AND I.DestinationID = " & Val(cmbDestination.SelectedValue)
            End If
            strSQL = strSQL & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, D.fldName) AS t" _
            & " ORDER BY InvoiceDate DESC, InvoiceID DESC"
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
        Grid.Columns(15).HeaderText = "printed"
        Grid.Columns(15).Visible = False
        If lblID.Text <> "" Then
            For i = 0 To Grid.RowCount - 1
                If Grid.Rows(i).Cells(15).Value = 1 Then
                    Grid.Rows(i).Cells(0).Value = True
                End If
            Next
        End If
    End Function

    Private Sub frmBill_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = Me.Width - 50
        StripPanel.Width = Me.Width
    End Sub

    Private Sub Grid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles Grid.CurrentCellDirtyStateChanged
        CalcTotal()
    End Sub
    Public Sub CalcTotal()
        Dim tPackage, tChWt, tAmount As Integer
        tPackage = 0 : tChWt = 0 : tAmount = 0
        For i = 0 To Grid.RowCount - 1
            If Grid.Rows(i).Cells(0).Value = True Then
                tPackage = Val(tPackage) + Val(Grid.Rows(i).Cells(8).Value)
                tChWt = Val(tChWt) + Val(Grid.Rows(i).Cells(10).Value)
                tAmount = Val(tAmount) + Val(Grid.Rows(i).Cells(13).Value)
            End If
        Next
        txtTotalPackage.Text = tPackage : txtTotalChargeWeight.Text = tChWt : txtTotalAmount.Text = tAmount
        txtGAmount.Text = (Convert.ToDouble(txtTotalAmount.Text) + (Convert.ToDouble(txtTotalAmount.Text) * Convert.ToDouble(txtGST.Text) / 100)).ToString()
    End Sub

    Private Sub chkALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkALL.CheckedChanged
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

    Private Sub txtGST_TextChanged(sender As Object, e As EventArgs) Handles txtGST.TextChanged


    End Sub

    Private Sub txtGST_Leave(sender As Object, e As EventArgs) Handles txtGST.Leave
        txtGAmount.Text = (Convert.ToDouble(txtTotalAmount.Text) + (Convert.ToDouble(txtTotalAmount.Text) * Convert.ToDouble(txtGST.Text) / 100)).ToString()
    End Sub
End Class