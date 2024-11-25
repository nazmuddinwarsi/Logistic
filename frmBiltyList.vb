Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBiltyList
    Dim cnn As New DataConn.Conn
    Dim iChNo, iChDate, iTruckNo As String
    Dim iChWt, iBillAmt As Decimal

    Private Sub frmBiltyList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtFromDate.Text = DateAdd(DateInterval.Day, -10, Date.Today)
        txtToDate.Text = Date.Today
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT C.ChallanID, C.ChallanNo, C.ChallanDate, C.TruckNo, C.DriverName, C.OwnerName, C.ToAddress, C.eWayBillNo, C.TotalPackage, C.ActualWeight, C.ChargeWeight, C.TotalAmount, C.Printed, C.Online" _
        & " FROM dbo.LOG_tblChallanDetails AS CD INNER JOIN dbo.LOG_tblChallan AS C ON CD.HeaderID = C.ChallanID INNER JOIN dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN" _
        & " dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID ON CD.InvoiceID = I.InvoiceID" _
        & " WHERE (C.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (C.SessionID = " & Val(MDI.lblSessionID.Text) & ") AND (C.ChallanDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
        If txtInvNo.Text <> "" Then
            strSQL = strSQL & " AND C.ChallanNo = " & cnn.SQLquote(txtInvNo.Text)
        End If
        If txtTruckNo.Text <> "" Then
            strSQL = strSQL & " AND C.TruckNo LIKE " & cnn.SQLSearch(txtTruckNo.Text)
        End If
        If txtDriverName.Text <> "" Then
            strSQL = strSQL & " AND C.DriverName LIKE " & cnn.SQLSearch(txtDriverName.Text)
        End If
        strSQL = strSQL & " GROUP BY C.ChallanID, C.ChallanNo, C.ChallanDate, C.TruckNo, C.DriverName, C.OwnerName, C.ToAddress, C.eWayBillNo, C.TotalPackage, C.ActualWeight, C.ChargeWeight, C.TotalAmount, C.Printed, C.Online"
        strSQL = strSQL & " ORDER BY C.ChallanDate DESC, C.ChallanID DESC"
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
        Grid.Columns(1).HeaderText = "Challan No"
        Grid.Columns(2).HeaderText = "Challan Date"
        Grid.Columns(3).HeaderText = "Truck No"
        Grid.Columns(4).HeaderText = "Driver Name"
        Grid.Columns(5).HeaderText = "Owner Name"
        Grid.Columns(6).HeaderText = "Destination"
        Grid.Columns(7).HeaderText = "eWay BillNo"
        Grid.Columns(8).HeaderText = "Package"
        Grid.Columns(9).HeaderText = "Actual Weight"
        Grid.Columns(10).HeaderText = "Charge Weight"
        Grid.Columns(11).HeaderText = "Bill Amount"
        Grid.Columns(12).HeaderText = "Printed"
        Grid.Columns(13).HeaderText = "Online"
        Grid.Columns(12).Visible = False : Grid.Columns(13).Visible = False
        '=========================
        Grid2.DataSource = Nothing
        For i = 0 To Grid.Rows.Count - 1
            If Grid.Rows(i).Cells(12).Value = "Y" Then
                For j = 0 To Grid.Columns.Count - 1
                    Grid.Rows(i).Cells(j).Style.BackColor = Color.LightGray
                Next
            End If
            If Grid.Rows(i).Cells(13).Value = "Y" Then
                For j = 0 To Grid.Columns.Count - 1
                    Grid.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                Next
            End If
        Next
    End Sub

    Private Sub frmBiltyList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBiltyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub frmBiltyList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
            strSQL = "SELECT C.ChallanID, C.ChallanNo, C.ChallanDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName AS CNSRName, CE.AccountName AS CNSEName, D.fldName AS DestinationName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount" _
            & " FROM dbo.LOG_tblChallanDetails AS CD INNER JOIN dbo.LOG_tblChallan AS C ON CD.HeaderID = C.ChallanID INNER JOIN dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN " _
            & " dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID ON CD.InvoiceID = I.InvoiceID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID " _
            & " WHERE (C.ChallanID = " & Val(lblID.Text) & ")"
            strSQL = strSQL & " GROUP BY C.ChallanID, C.ChallanNo, C.ChallanDate, I.InvoiceNo, I.InvoiceDate, CR.AccountName, CE.AccountName, D.fldName, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.BillAmount"

            da = New OdbcDataAdapter(strSQL, cnn.cnn)
            ds = New DataSet()
            da.Fill(ds)
            Grid2.DataSource = ds.Tables(0)
            Grid2.Columns(0).HeaderText = "ID"
            Grid2.Columns(0).Visible = False
            Grid2.Columns(1).HeaderText = "Challan No"
            Grid2.Columns(2).HeaderText = "Challan Date"
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

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString : lblID2.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                iChNo = Grid.Rows(crRowIndex).Cells(1).Value.ToString : iChDate = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                iTruckNo = Grid.Rows(crRowIndex).Cells(3).Value.ToString : iChWt = Grid.Rows(crRowIndex).Cells(10).Value.ToString
                iBillAmt = Grid.Rows(crRowIndex).Cells(11).Value.ToString
                frameEdit.Visible = True ' EditRecord()
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
        Dim strSQL As String
        strSQL = "Select * from LOG_tblChallan Where ChallanID=" & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then

            frmBilty.lblID.Text = lblID.Text
            cnn.ShowForm(frmBilty)
            If Not IsDBNull(dr.Item("ChallanNo")) Then
                frmBilty.txtInvoiceNo.Text = dr.Item("ChallanNo")
            End If
            If Not IsDBNull(dr.Item("ChallanDate")) Then
                frmBilty.txtDate.Text = dr.Item("ChallanDate")
            End If
            If Not IsDBNull(dr.Item("TruckNo")) Then
                frmBilty.cmbTruckNo.Text = dr.Item("TruckNo")
            End If
            If Not IsDBNull(dr.Item("DriverName")) Then
                frmBilty.cmbDriverName.Text = dr.Item("DriverName")
            End If
            If Not IsDBNull(dr.Item("DriverAddress")) Then
                frmBilty.cmbDriverAddress.Text = dr.Item("DriverAddress")
            End If
            If Not IsDBNull(dr.Item("OwnerName")) Then
                frmBilty.cmbOwnerName.Text = dr.Item("OwnerName")
            End If
            If Not IsDBNull(dr.Item("OwnerAddress")) Then
                frmBilty.cmbOwnerAddress.Text = dr.Item("OwnerAddress")
            End If
            If Not IsDBNull(dr.Item("eWayBillNo")) Then
                frmBilty.txteWayBillNo.Text = dr.Item("eWayBillNo")
            End If
            If Not IsDBNull(dr.Item("ToName")) Then
                frmBilty.cmbTo.Text = dr.Item("ToName")
            End If
            If Not IsDBNull(dr.Item("ToAddress")) Then
                frmBilty.cmbToAddress.Text = dr.Item("ToAddress")
            End If
            If Not IsDBNull(dr.Item("TotalPackage")) Then
                frmBilty.txtTotalPackage.Text = dr.Item("TotalPackage")
            End If
            If Not IsDBNull(dr.Item("ActualWeight")) Then
                frmBilty.txtTotalActualWeight.Text = dr.Item("ActualWeight")
            End If
            If Not IsDBNull(dr.Item("ChargeWeight")) Then
                frmBilty.txtTotalChargeWeight.Text = dr.Item("ChargeWeight")
            End If
            If Not IsDBNull(dr.Item("TotalAmount")) Then
                frmBilty.txtTotalAmount.Text = dr.Item("TotalAmount")
            End If
            dr.Close()
            cmd.Connection.Close()
        End If
        frmBilty.BindGrid()
        '---------------------------------------
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBilty)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldDelete") = False Then
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
        strSQL = "Select ChallanDetailID from LOG_tblChallanDetails Where InvoiceID =" & Val(lblID.Text)
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("This Record is in Use, You can't delete this srecord  !")
            Exit Sub
        End If

        strSQL = "UPDATE LOG_tblInvoice SET Bilty = 'N' WHere InvoiceID IN (SELECT InvoiceID From LOG_tblChallanDetails WHERE HeaderID =" & Val(lblID.Text) & ")"
        cnn.executeSQL(strSQL)
        strSQL = "DELETE From LOG_tblChallanDetails WHere HeaderID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        strSQL = "DELETE From LOG_tblChallan WHere ChallanID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Deleted  !")
        BindGrid()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BindGrid() : frameSearch.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frameSearch.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
      
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bilty"
        strReportName = Application.StartupPath & "\Reports\Challan.rpt"


        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayInvoice(CrxReport, reportDesc)
    End Sub
    Private Sub DisplayInvoice(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptChallan.ChallanID} = " & Val(lblID.Text)

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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Bilty List"
        strReportName = Application.StartupPath & "\Reports\ChallanList.rpt"


        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayReport(CrxReport, reportDesc)
    End Sub

    Private Sub DisplayReport(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptInvoice.ChallanDate} >= #" & cnn.GetDate(txtFromDate.Text) & "#" _
        & " AND {rptInvoice.ChallanDate} <= #" & cnn.GetDate(txtToDate.Text) & "#" _
        & " AND {rptInvoice.CompanyID} = " & Val(MDI.lblCompanyID.Text) & " AND {rptInvoice.SessionID} = " & Val(MDI.lblSessionID.Text)
        If txtInvNo.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.ChallanNo} = " & Val(txtInvNo.Text)
        End If
        If txtInvNo.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.ChallanNo} LIKE " & cnn.CrystalSearch(txtInvNo.Text)
        End If
        If txtTruckNo.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.TruckNo} LIKE " & cnn.CrystalSearch(txtTruckNo.Text)
        End If
        If txtDriverName.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.DriverName} LIKE " & cnn.CrystalSearch(txtDriverName.Text)
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEditFrame_Click(sender As Object, e As EventArgs) Handles btnEditFrame.Click
        EditRecord()
    End Sub

    Private Sub btnOnlineFrame_Click(sender As Object, e As EventArgs) Handles btnOnlineFrame.Click
        PostOnline()
    End Sub
    Private Sub PostOnline()
        Dim strSQL As String = "" : Dim InvID As Integer
        strSQL = "Select InvoiceID from LOG_tblChallanDetails Where HeaderID=" & Val(lblID2.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            InvID = dr.Item("InvoiceID")
            Dim ival = cnn.GetInvDetails(Val(InvID), iChNo, iChDate, iTruckNo, iChWt, iBillAmt, Val(lblID2.Text))
            If ival = 0 Then

            ElseIf ival = -2 Then
                cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            ElseIf ival = -5 Then
                cnn.ErrMsgBox("Something went Wrong  !")
            End If
        Loop
        dr.Close() : cmd.Connection.Close()
        '------------- ID > ChallanID 19052021
        strSQL = "UPDATE LOG_tblChallan SET Online= 'Y' WHERE ChallanID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Posted Online !")
        frameEdit.Visible = False : BindGrid()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        frameEdit.Visible = False
    End Sub
End Class