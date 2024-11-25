Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBillList
    Dim cnn As New DataConn.Conn

    Private Sub frmBillList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtFromDate.Text = DateAdd(DateInterval.Month, -1, Date.Today)
        txtToDate.Text = Date.Today
        BindGrid()
    End Sub

    Private Sub frmBillList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBillList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        '==============================
        ToolStrip1.Cursor = Cursors.Hand
        btnAdd.Image = MDI.ImageList1.Images(0)
        btnEdit.Image = MDI.ImageList1.Images(1)
        btnDelete.Image = MDI.ImageList1.Images(2)
        btnSearch.Image = MDI.ImageList1.Images(3)
        btnPrint.Image = MDI.ImageList1.Images(4)
        btnInvoice.Image = MDI.ImageList1.Images(4)
        btnExit.Image = MDI.ImageList1.Images(5)
        '===========================================
        frameSearch.Visible = False
        rbCNSR.Visible = True
        BindAccount()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        '---------- 05-10-2020
        strSQL = "SELECT BH.ID, BH.BillNo, BH.BillDate, CASE WHEN BH.PartyType = 'CNSR' THEN 'CONSIGNOR' ELSE 'CONSIGNEE' END AS PartyType, A.AccountName, A.City, BH.FromDate, BH.ToDate, BH.TotPackage, BH.TotChargeWeight, BH.BillAmount" _
        & " FROM dbo.LOG_tblAccount AS A INNER JOIN dbo.LOG_tblBillHeader AS BH ON A.AccountID = BH.PartyID" _
        & " WHERE (BH.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (BH.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (BH.BillDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
        If cmbAccount.Text <> "" Then
            strSQL = strSQL & " AND (BH.PartyID = " & Val(cmbAccount.SelectedValue) & ")"
        End If
        strSQL = strSQL & " ORDER BY BH.BillDate DESC, BH.ID DESC"
        '--------------------
        If cnn.cnn.State = 1 Then
            cnn.cnn.Close()
        End If
        cnn.cnn.Open()
        '--------------------
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Bill No"
        Grid.Columns(2).HeaderText = "Bill Date"
        Grid.Columns(3).HeaderText = "Party Type"
        Grid.Columns(4).HeaderText = "Party Name"
        Grid.Columns(5).HeaderText = "City"
        Grid.Columns(6).HeaderText = "From Date"
        Grid.Columns(7).HeaderText = "To Date"
        Grid.Columns(8).HeaderText = "Tot Pkg"
        Grid.Columns(9).HeaderText = "Tot Wt"
        Grid.Columns(10).HeaderText = "Bill Amt"
    End Sub

    Private Sub frmBillList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = Me.Width
        Grid.Height = (Me.Height / 2) - 37
        Grid2.Height = (Me.Height / 2) - 60
        Grid2.Top = Grid.Height + 105
        Grid2.Width = Me.Width
        StripPanel.Width = Me.Width
    End Sub
    Private Sub BindAccount()
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
    End Sub
    Private Sub rbCNSR_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNSR.CheckedChanged
        BindAccount()
    End Sub

    Private Sub rbCNSE_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNSE.CheckedChanged
        BindAccount()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BindGrid() : frameSearch.Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBill)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frameSearch.Visible = True : cmbAccount.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub DisplayInvoice(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String, iCopy As Integer)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptInvoice.ID} = " & Val(lblID.Text)
        objfrmRptViewer.CRViewer.ReportSource = CrxReport
        objfrmRptViewer.CRViewer.SelectionFormula = strSelection
        objfrmRptViewer.CRViewer.RefreshReport()
        objfrmRptViewer.CRViewer.ShowExportButton = True
        objfrmRptViewer.CRViewer.ShowPrintButton = True
        objfrmRptViewer.Text = reportDesc
        objfrmRptViewer.Show()
        objfrmRptViewer.WindowState = FormWindowState.Maximized
        Cursor.Current = Cursors.Default
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

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                GetDetails()
            End If
        End If
    End Sub
    Private Sub GetDetails()
        If lblID.Text <> "" Then
            Dim strSQL, sSQL As String
            Dim da As New OdbcDataAdapter
            Dim ds As New DataSet
            sSQL = ""
            'strSQL = "SELECT B.ID, C.BillNo, C.BillDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName AS CNSRName, CE.AccountName AS CNSEName, D.fldName AS DestinationName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount" _
            '& " FROM dbo.LOG_tblBillDetails AS BD INNER JOIN dbo.LOG_tblBillHeader AS BH ON BD.HeaderID = BH.ID INNER JOIN dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN " _
            '& " dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID ON CD.InvoiceID = I.InvoiceID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID " _
            '& " WHERE (C.ChallanID = " & Val(lblID.Text) & ")"
            'strSQL = strSQL & " GROUP BY B.ID, C.BillNo, C.BillDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName, CE.AccountName, D.fldName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount"
            strSQL = "SELECT BH.ID, BH.BillNo, BH.BillDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName AS CNSRName, CE.AccountName AS CNSEName, D.fldName AS DestinationName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount" _
            & " FROM dbo.LOG_tblMaster AS D INNER JOIN dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN" _
            & " dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID ON D.ID = I.DestinationID INNER JOIN dbo.LOG_tblBillDetails AS BD INNER JOIN dbo.LOG_tblBillHeader AS BH ON BD.HeaderID = BH.ID ON I.InvoiceID = BD.BiltyID" _
            & " WHERE (BH.ID = " & Val(lblID.Text) & ") GROUP BY BH.ID, BH.BillNo, BH.BillDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName, CE.AccountName, D.fldName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount"

            da = New OdbcDataAdapter(strSQL, cnn.cnn)
            ds = New DataSet()
            da.Fill(ds)
            Grid2.DataSource = ds.Tables(0)
            Grid2.Columns(0).HeaderText = "ID"
            Grid2.Columns(0).Visible = False
            Grid2.Columns(1).HeaderText = "Bill No"
            Grid2.Columns(2).HeaderText = "Bill Date"
            Grid2.Columns(3).HeaderText = "Invoice No"
            Grid2.Columns(4).HeaderText = "Invoice Date"
            Grid2.Columns(5).HeaderText = "Consigner Name"
            Grid2.Columns(6).HeaderText = "Consignee Name"
            Grid2.Columns(7).HeaderText = "Destination"
            Grid2.Columns(8).HeaderText = "Package"
            Grid2.Columns(9).HeaderText = "Actual Weight"
            Grid2.Columns(10).HeaderText = "Charge Weight"
            Grid2.Columns(11).HeaderText = "Total Amount"
            Grid2.Columns(12).HeaderText = "Bill Amount"
        End If
    End Sub
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        If Val(lblID.Text) = 0 Then
            cnn.ErrMsgBox("Please Select Invoice No  !")
            Exit Sub
        End If
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bill"
        strReportName = Application.StartupPath & "\Reports\MonthlyInvoice.rpt"
        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayInvoice(CrxReport, reportDesc, 1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                EditRecord()
            End If
        End If
    End Sub
    Private Sub EditRecord()
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        'If MDI.lblAccessType.Text <> "A" Then
        '    If cnn.GetUserAccess(7, "fldEdit") = False Then
        '        cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
        '        Exit Sub
        '    End If
        'End If
        'cnn.ShowForm(frmInvoice)
        ''--------------------
        Dim strSQL As String : Dim iPartyID As Integer
        strSQL = "Select * from LOG_tblBillHeader Where ID=" & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            frmBill.lblID.Text = lblID.Text
            cnn.ShowForm(frmBill)
            If Not IsDBNull(dr.Item("BillNo")) Then
                frmBill.txtInvoiceNo.Text = dr.Item("BillNo")
            End If
            If Not IsDBNull(dr.Item("BillDate")) Then
                frmBill.txtDate.Text = dr.Item("BillDate")
            End If
            If Not IsDBNull(dr.Item("BookType")) Then
                If dr.Item("BookType") = "TOPAY" Then
                    frmBill.rbToPay.Checked = True
                ElseIf dr.Item("BookType") = "PAID" Then
                    frmBill.rbPaid.Checked = True
                ElseIf dr.Item("BookType") = "TBB" Then
                    frmBill.rbTBB.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("PartyType")) Then
                If dr.Item("PartyType") = "CNSE" Then
                    frmBill.rbCNSE.Checked = True
                Else
                    frmBill.rbCNSR.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("PartyID")) Then
                iPartyID = dr.Item("PartyID")
            End If
            If Not IsDBNull(dr.Item("FromDate")) Then
                frmBill.txtFromDate.Text = dr.Item("FromDate")
            End If
            If Not IsDBNull(dr.Item("ToDate")) Then
                frmBill.txtToDate.Text = dr.Item("ToDate")
            End If
            frmBill.BindAccount()
            frmBill.cmbAccount.SelectedValue = iPartyID

            dr.Close()
            cmd.Connection.Close()
            frmBill.BindGridBilty()
            frmBill.CalcTotal()
        End If
        '---------------------------------------
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bill List"
        strReportName = Application.StartupPath & "\Reports\BillList.rpt"


        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayReport(CrxReport, reportDesc)
    End Sub

    Private Sub DisplayReport(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptBillList.BillDate} >= #" & cnn.GetDate(txtFromDate.Text) & "#" _
        & " AND {rptBillList.BillDate} <= #" & cnn.GetDate(txtToDate.Text) & "#" _
        & " AND {rptBillList.CompanyID} = " & Val(MDI.lblCompanyID.Text) & " AND {rptBillList.SessionID} = " & Val(MDI.lblSessionID.Text)
        If rbCNSE.Checked = True Then
            strSelection = strSelection & " AND {rptBillList.PartyType}='CONSIGNEE'"
        Else
            strSelection = strSelection & " AND {rptBillList.PartyType}='CONSIGNOR'"
        End If
        If cmbAccount.Text <> "" Then
            strSelection = strSelection & " AND {rptBillList.PartyID} =" & Val(cmbAccount.SelectedValue)
        End If


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

End Class