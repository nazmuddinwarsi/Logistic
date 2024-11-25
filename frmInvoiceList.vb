Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmInvoiceList
    Dim cnn As New DataConn.Conn

    Private Sub frmInvoiceList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtFromDate.Text = DateAdd(DateInterval.Day, -10, Date.Today)
        txtToDate.Text = Date.Today
        BindGrid()
    End Sub
    Private Sub BindGrid()
        'If chkAllDate.Checked = False And txtInvNo.Text = "" Then
        '    cnn.ErrMsgBox("Please enter Bilty No.")
        '    txtInvNo.Focus()
        '    Exit Sub
        'End If

        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, I.ChNo, I.ChDate, I.Online, I.CreatedDate" _
        & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID " _
        & " INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
        & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ")"
        '------------------ 05-10-2020
        If chkAllDate.Checked = False Then
            strSQL = strSQL & " AND (I.InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
        End If
        If rbCancelNO.Checked = True Then
            strSQL = strSQL & " AND I.Cancelled = 'N'"
        Else
            strSQL = strSQL & " AND I.Cancelled = 'Y'"
        End If
        If rbAll.Checked = True Then
        ElseIf rbToPay.Checked = True Then
            strSQL = strSQL & " AND I.BookingType = 'TOPAY'"
        ElseIf rbPaid.Checked = True Then
            strSQL = strSQL & " AND I.BookingType = 'PAID'"
        ElseIf rbTBB.Checked = True Then
            strSQL = strSQL & " AND I.BookingType = 'TBB'"
        End If
        If txtInvNo.Text <> "" Then
            strSQL = strSQL & " AND I.InvoiceNo LIKE " & cnn.SQLSearch(txtInvNo.Text)
        End If
        If cmbConsigner.Text <> "" Then
            strSQL = strSQL & " AND I.ConsignerID = " & Val(cmbConsigner.SelectedValue)
        End If
        If cmbConsignee.Text <> "" Then
            strSQL = strSQL & " AND I.ConsigneeID = " & Val(cmbConsignee.SelectedValue)
        End If
        If txtName.Text <> "" Then
            strSQL = strSQL & " AND M.fldName LIKE " & cnn.SQLSearch(txtName.Text)
        End If
        If txtBillNo.Text <> "" Then
            strSQL = strSQL & " AND I.InvNo LIKE " & cnn.SQLSearch(txtBillNo.Text)
        End If
        If cmbDestination.Text <> "" Then
            strSQL = strSQL & " AND I.DestinationID = " & Val(cmbDestination.SelectedValue)
        End If
        '------------- TRANSIT
        If rbTAll.Checked = True Then
        ElseIf rbTKanpur.Checked = True Then
            strSQL = strSQL & " AND D.fldName = 'KANPUR'"
        ElseIf rbTOthers.Checked = True Then
            strSQL = strSQL & " AND D.fldName <> 'KANPUR'"
        End If
        'strSQL = strSQL & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, D.fldName, C.ChallanNo, C.CreatedDate, I.Online, I.CreatedDate"
        'strSQL = strSQL & " ORDER BY I.InvoiceDate DESC, I.InvoiceID DESC"
        strSQL = strSQL & " GROUP BY I.InvoiceDate, I.InvoiceID, I.InvoiceNo, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, D.fldName, I.ChNo, I.ChDate, I.Online, I.CreatedDate"
        strSQL = strSQL & " ORDER BY I.InvoiceDate DESC, I.InvoiceID DESC"

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
        Grid.Columns(1).HeaderText = "Invoice No"
        Grid.Columns(2).HeaderText = "Invoice Date"
        Grid.Columns(3).HeaderText = "Destination"
        Grid.Columns(4).HeaderText = "Consigner Name"
        Grid.Columns(5).HeaderText = "Consignee Name"
        Grid.Columns(6).HeaderText = "Booking Type"
        Grid.Columns(7).HeaderText = "Total Package"
        Grid.Columns(8).HeaderText = "Actual Weight"
        Grid.Columns(9).HeaderText = "Charge Weight"
        Grid.Columns(10).HeaderText = "Freight Amt"
        Grid.Columns(11).HeaderText = "Taxable Amt"
        Grid.Columns(12).HeaderText = "Bill Amount"
        Grid.Columns(13).Visible = False
        Grid.Columns(13).HeaderText = "Challan"
        Grid.Columns(14).HeaderText = "printed"
        Grid.Columns(14).Visible = False
        Grid.Columns(15).HeaderText = "Challan No"
        Grid.Columns(16).HeaderText = "Created Date"
        Grid.Columns(17).HeaderText = "Online"
        Grid.Columns(17).Visible = False
        Grid.Columns(18).HeaderText = "Bilty Time"
        '=========================
        Grid2.DataSource = Nothing

        For i = 0 To Grid.Rows.Count - 1
            If Grid.Rows(i).Cells(14).Value = "Y" Then
                For j = 0 To Grid.Columns.Count - 1
                    Grid.Rows(i).Cells(j).Style.BackColor = Color.Silver
                Next
            End If
            If Grid.Rows(i).Cells(17).Value = "True" Then
                For j = 0 To Grid.Columns.Count - 1
                    Grid.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                Next
            End If
        Next

    End Sub
    Private Sub frmInvoiceList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmInvoiceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        '--------------------------- DESTINATION
        cmbDestination.DisplayMember = "fldName"
        cmbDestination.ValueMember = "ID"
        cmbDestination.DataSource = cnn.BindMaster(3)
        cmbDestination.SelectedIndex = -1
    End Sub

    Private Sub frmInvoiceList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = Me.Width
        Grid2.Height = 50
        Grid.Height = (Me.Height - 155)
        Grid2.Top = Grid.Height + 105
        Grid2.Width = Me.Width
        StripPanel.Width = Me.Width
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
            strSQL = "SELECT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, M.fldName, ID.Description, ID.HSNCode, ID.Packages, ID.ActualWeight, ID.ChargeWeight, ID.Amount" _
            & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID" _
            & " WHERE (I.InvoiceID = " & Val(lblID.Text) & ")"

            da = New OdbcDataAdapter(strSQL, cnn.cnn)
            ds = New DataSet()
            da.Fill(ds)
            Grid2.DataSource = ds.Tables(0)
            Grid2.Columns(0).HeaderText = "ID"
            Grid2.Columns(0).Visible = False
            Grid2.Columns(1).HeaderText = "Invoice No"
            Grid2.Columns(2).HeaderText = "Invoice Date"
            Grid2.Columns(3).HeaderText = "Product Name"
            Grid2.Columns(4).HeaderText = "Description"
            Grid2.Columns(5).HeaderText = "HSN Code"
            Grid2.Columns(6).HeaderText = "Package"
            Grid2.Columns(7).HeaderText = "Actual Weight"
            Grid2.Columns(8).HeaderText = "Charge Weight"
            Grid2.Columns(9).HeaderText = "Amount"
        End If
    End Sub
    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                frameEdit.Visible = True 'EditRecord()
            End If
        End If
    End Sub
    Private Sub EditRecord()
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(2, "fldEdit") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        ''--------------------
        Dim strSQL As String

        '-----------------------
        If MDI.lblAccessType.Text <> "A" Then
            strSQL = "Select ChallanDetailID from LOG_tblChallanDetails Where InvoiceID =" & Val(lblID.Text)
            If cnn.CheckDuplicate(strSQL) = True Then
                cnn.ErrMsgBox("This Record is in Use, You can't Edit this srecord  !")
                Exit Sub
            End If
        End If

        '-----------------------
        strSQL = "Select * from LOG_tblInvoice Where InvoiceID=" & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("Cancelled")) Then
                If dr.Item("Cancelled") = "Y" Then
                    cnn.ErrMsgBox("This Bilty is Cancelled, You can't Edit this srecord  !")
                    dr.Close() : cmd.Connection.Close()
                    Exit Sub
                End If
            End If
            cnn.ShowForm(frmInvoice)
            frmInvoice.lblID.Text = lblID.Text
            If Not IsDBNull(dr.Item("InvoiceNo")) Then
                frmInvoice.txtInvoiceNo.Text = dr.Item("InvoiceNo")
            End If
            If Not IsDBNull(dr.Item("InvoiceDate")) Then
                frmInvoice.txtDate.Text = dr.Item("InvoiceDate")
            End If
            If Not IsDBNull(dr.Item("ConsignerID")) Then
                frmInvoice.cmbConsigner.SelectedValue = dr.Item("ConsignerID")
            End If
            If Not IsDBNull(dr.Item("ConsigneeID")) Then
                frmInvoice.cmbConsignee.SelectedValue = dr.Item("ConsigneeID")
            End If
            If Not IsDBNull(dr.Item("DestinationID")) Then
                frmInvoice.cmbDestination.SelectedValue = dr.Item("DestinationID")
            End If
            If Not IsDBNull(dr.Item("TransporterID")) Then
                frmInvoice.cmbTransporter.SelectedValue = dr.Item("TransporterID")
            End If
            If Not IsDBNull(dr.Item("InvNo")) Then
                frmInvoice.txtInv.Text = dr.Item("InvNo")
            End If
            If Not IsDBNull(dr.Item("Remarks")) Then
                frmInvoice.cmbRemarks.Text = dr.Item("Remarks")
            End If
            If Not IsDBNull(dr.Item("Value")) Then
                frmInvoice.txtValue.Text = dr.Item("Value")
            End If
            If Not IsDBNull(dr.Item("PrivateMarks")) Then
                frmInvoice.txtPrivateMarks.Text = dr.Item("PrivateMarks")
            End If
            If Not IsDBNull(dr.Item("TruckNo")) Then
                frmInvoice.txtTruckNo.Text = dr.Item("TruckNo")
            End If

            ' strSQL = "INSERT INTO LOG_tblInvoice ( , , , GSTat, BookingType, TotalPackage, TotalActualWeight, TotalChargeWeight, TotalAmount, TaxableAmount," _
            '& "CGST, CGSTAmount, SGST, SGSTAmount, IGST, IGSTAmount, BillAmount, CompanyID) OutPut Inserted.InvoiceID as HeaderID VALUES (" _
            '& Val(txtInvoiceNo.Text) & ",'" & cnn.GetDate(txtDate.Text) & "'," & Val(cmbConsigner.SelectedValue) & "," & Val(cmbConsignee.SelectedValue) & "," & Val(cmbDestination.SelectedValue) & "," & Val(cmbTransporter.SelectedValue) _
            '& nn.SQLquote(.Text) & ",'" & GSTat & "','" & iBookType & "'," & Val(txtTotalPackage.Text) _
            '& "," & Val(txtTotalActualWeight.Text) & "," & Val(txtTotalChargeWeight.Text) & "," & Val(txtTotalAmount.Text) & "," & Val(txtTaxableAmount.Text) & "," & Val(lblCGST.Text) & "," & Val(txtCGST.Text) _
            '& "," & Val(lblSGST.Text) & "," & Val(txtSGST.Text) & "," & Val(lblIGST.Text) & "," & Val(txtIGST.Text) & "," & Val(txtBillAmount.Text) & "," & Val(MDI.lblCompanyID.Text) & ")"
            If Not IsDBNull(dr.Item("GSTat")) Then
                If dr.Item("GSTat") = "CONSIGNER" Then
                    frmInvoice.rbCnsr.Checked = True
                ElseIf dr.Item("GSTat") = "CONSIGNEE" Then
                    frmInvoice.rbCnse.Checked = True
                ElseIf dr.Item("GSTat") = "TRANSPORTER" Then
                    frmInvoice.rbTrans.Checked = True
                ElseIf dr.Item("GSTat") = "EXEMPTED" Then
                    frmInvoice.rbExmptd.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("BookingType")) Then
                If dr.Item("BookingType") = "TOPAY" Then
                    frmInvoice.rbToPay.Checked = True
                ElseIf dr.Item("BookingType") = "PAID" Then
                    frmInvoice.rbPaid.Checked = True
                ElseIf dr.Item("BookingType") = "TBB" Then
                    frmInvoice.rbTBB.Checked = True
                End If
            End If

            'If Not IsDBNull(dr.Item("TotalAmount")) Then
            '    frmInvoice.txtTotalAmount.Text = dr.Item("TotalAmount")
            'End If
            'If Not IsDBNull(dr.Item("BillAmount")) Then
            '    frmInvoice.txtBillAmount.Text = dr.Item("BillAmount")
            'End If
            'If Not IsDBNull(dr.Item("Remarks")) Then
            '    frmInvoice.txtRemarks.Text = dr.Item("Remarks")
            'End If
            dr.Close()
            cmd.Connection.Close()
        End If
        '---------------------------------------
        strSQL = "SELECT ID.ProductID, M.fldName, ID.Description, ID.HSNCode, ID.Packages, ID.ActualWeight, ID.ChargeWeight, ID.Amount FROM dbo.LOG_tblInvoiceDetails AS ID INNER JOIN" _
        & " dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID WHERE (ID.HeaderID = " & Val(lblID.Text) & ")"
        frmInvoice.Grid.Rows.Clear()
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            frmInvoice.cmbProduct.SelectedValue = dr.Item("ProductID")
            'frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(1).Value = dr.Item("fldName")
            frmInvoice.txtDescr.Text = dr.Item("Description")
            frmInvoice.txtHSN.Text = dr.Item("HSNCode")
            frmInvoice.txtPackage.Text = dr.Item("Packages")
            frmInvoice.txtActualWt.Text = dr.Item("ActualWeight")
            frmInvoice.txtChargeWt.Text = dr.Item("ChargeWeight")
            frmInvoice.txtAmount.Text = dr.Item("Amount")
        End If
        frmInvoice.txtTotalAmount.Text = frmInvoice.txtAmount.Text
        'Do While dr.Read
        '    frmInvoice.Grid.Rows.Add(1)
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(0).Value = dr.Item("ProductID")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(1).Value = dr.Item("fldName")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(2).Value = dr.Item("Description")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(3).Value = dr.Item("HSNCode")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(4).Value = dr.Item("Packages")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(5).Value = dr.Item("ActualWeight")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(6).Value = dr.Item("ChargeWeight")
        '    frmInvoice.Grid.Rows(frmInvoice.Grid.Rows.Count - 1).Cells(7).Value = dr.Item("Amount")
        'Loop

        '---------------------------------------
        For i = 0 To frmInvoice.Grid2.Rows.Count - 1
            strSQL = "SELECT BSD.Amount FROM dbo.LOG_BillSundry AS BS INNER JOIN dbo.LOG_tblBillSundryDetails AS BSD ON BS.SundryID = BSD.SundryID" _
        & " WHERE (BSD.HeaderID = " & Val(lblID.Text) & ") AND (BSD.SundryID = " & Val(frmInvoice.Grid2.Rows(i).Cells(0).Value) & ")"
            cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
            If cmd.Connection.State = 1 Then cmd.Connection.Close()
            cmd.Connection.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim iVal = dr.Item("Amount")
                frmInvoice.Grid2.Rows(i).Cells(2).Value = dr.Item("Amount")
            End If
            dr.Close() : cmd.Connection.Close()
        Next
        'frmInvoice.GridTotal()
        frmInvoice.CalculateSundryGrid()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bilty List"
        strReportName = Application.StartupPath & "\Reports\BiltyList.rpt"


        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayReport(CrxReport, reportDesc)
    End Sub

    Private Sub DisplayReport(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptInvoice.InvoiceDate} >= #" & cnn.GetDate(txtFromDate.Text) & "#" _
        & " AND {rptInvoice.InvoiceDate} <= #" & cnn.GetDate(txtToDate.Text) & "#" _
        & " AND {rptInvoice.CompanyID} = " & Val(MDI.lblCompanyID.Text) & " AND {rptInvoice.SessionID} = " & Val(MDI.lblSessionID.Text)
        If rbAll.Checked = True Then
        ElseIf rbToPay.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.BookingType} = 'TOPAY'"
        ElseIf rbPaid.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.BookingType} = 'PAID'"
        ElseIf rbTBB.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.BookingType} = 'TBB'"
        End If
        If txtInvNo.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.InvoiceNo} LIKE " & cnn.CrystalSearch(txtInvNo.Text)
        End If
        If cmbConsigner.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.ConsignerID} = " & Val(cmbConsigner.SelectedValue)
        End If
        If cmbConsignee.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.ConsigneeID} = " & Val(cmbConsignee.SelectedValue)
        End If
        If txtName.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.fldName} LIKE " & cnn.CrystalSearch(txtName.Text)
        End If
        If cmbDestination.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.DestinationID} = " & Val(cmbDestination.SelectedValue)
        End If
        If rbCancelNO.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.Cancelled} = 'N'"
        Else
            strSelection = strSelection & " AND {rptInvoice.Cancelled} = 'Y'"
        End If
        If rbTAll.Checked = True Then
        ElseIf rbTKanpur.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.Destination} = 'KANPUR'"
        ElseIf rbTOthers.Checked = True Then
            strSelection = strSelection & " AND {rptInvoice.Destination} <> 'KANPUR'"
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

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        framePrint.Visible = True

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(2, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmInvoice)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(2, "fldDelete") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        '------------------
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Delete  !")
            Exit Sub
        End If
        '------------------
        If MessageBox.Show("Do you want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim strSQL As String
        '--------------------------------------------------------------
        If MDI.lblAccessType.Text <> "A" Then
            strSQL = "Select ChallanDetailID from LOG_tblChallanDetails Where InvoiceID =" & Val(lblID.Text)
            If cnn.CheckDuplicate(strSQL) = True Then
                cnn.ErrMsgBox("This Record is in Use, You can't delete this srecord  !")
                Exit Sub
            End If
        End If


        'strSQL = "DELETE From LOG_tblInvoiceDetails WHere HeaderID=" & Val(lblID.Text)
        'cnn.executeSQL(strSQL)
        strSQL = "UPDATE LOG_tblInvoice SET Cancelled = 'Y' WHere InvoiceID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        strSQL = "DELETE From LOG_tblChallanDetails WHERE InvoiceID = " & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        Dim iVal As Integer = cnn.UpdateChallan(Val(lblID.Text))
        cnn.InfoMsgBox("Record has been Deleted  !")
        BindGrid()
    End Sub

    Private Sub btnPrintPrint_Click(sender As Object, e As EventArgs) Handles btnPrintPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bilty"
        strReportName = Application.StartupPath & "\Reports\Bilty.rpt"
        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayInvoice(CrxReport, reportDesc, 1)
        'If chkConsigner.Checked = True Then
        '    Call DisplayInvoice(CrxReport, reportDesc, 1)
        'End If
        'If chkConsignee.Checked = True Then
        '    Call DisplayInvoice(CrxReport, reportDesc, 2)
        'End If
        'If chkDriver.Checked = True Then
        '    Call DisplayInvoice(CrxReport, reportDesc, 3)
        'End If



    End Sub
    Private Sub DisplayInvoice(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String, iCopy As Integer)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection, strCopy As String
        strSelection = "{rptInvoice.InvoiceID} = " & Val(lblID.Text)
        strCopy = ""
        If chkConsignee.Checked = True Then
            strCopy = "'CONSIGNEE COPY'"
        End If
        If chkConsigner.Checked = True Then
            If strCopy = "" Then
                strCopy = "'CONSIGNOR COPY'"
            Else
                strCopy = strCopy & ",'CONSIGNOR COPY'"
            End If
        End If
        If chkDriver.Checked = True Then
            If strCopy = "" Then
                strCopy = "'DRIVER COPY'"
            Else
                strCopy = strCopy & ",'DRIVER COPY'"
            End If
        End If
        strSelection = strSelection & " AND {rptInvoice.CopyType} IN [" & strCopy & "]"

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
        cnn.executeSQL("UPDATE LOG_tblInvoice SET Printed = 'Y' WHERE InvoiceID = " & Val(lblID.Text))
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
    Private Sub btnPrintCancel_Click(sender As Object, e As EventArgs) Handles btnPrintCancel.Click
        framePrint.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frameEdit.Visible = True 'EditRecord()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BindGrid() : frameSearch.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frameSearch.Visible = True : txtFromDate.Focus()
    End Sub

    Private Sub btnEditFrame_Click(sender As Object, e As EventArgs) Handles btnEditFrame.Click
        EditRecord()
    End Sub

    Private Sub btnOnlineFrame_Click(sender As Object, e As EventArgs) Handles btnOnlineFrame.Click
        PostOnline()
    End Sub
    Private Sub PostOnline()
        ''  -------- 20012022 DISABLE ALL COMMENT DUE TO ADD ChNo, ChDate, ChTruckNo, ChWt, ChBillAmt FIELDS IN ONLINE TABLE
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If

        Dim ival = cnn.GetSingleInvDetails(Val(lblID.Text))

        If ival = 0 Then

        ElseIf ival = -2 Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
        ElseIf ival = -5 Then
            cnn.ErrMsgBox("Something went Wrong  !")
        End If
        cnn.InfoMsgBox("Record has been Posted Online !")
        frameEdit.Visible = False : BindGrid()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        frameEdit.Visible = False
    End Sub
End Class