Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmLeftInvoiceList
    Dim cnn As New DataConn.Conn
    Dim iNet As Boolean = True
    Private Sub frmLeftInvoiceList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtFromDate.Text = DateAdd(DateInterval.Day, -10, Date.Today)
        txtToDate.Text = Date.Today
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        'GetOnlineData()
        If iNet = True Then


            strSQL = "SELECT TOP (100) PERCENT I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName AS Destination, CR.AccountName AS CRName, CE.AccountName AS CEName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, I.Online" _
            & " FROM dbo.LOG_tblInvoice AS I INNER JOIN dbo.LOG_tblAccount AS CE ON I.ConsigneeID = CE.AccountID INNER JOIN dbo.LOG_tblAccount AS CR ON I.ConsignerID = CR.AccountID INNER JOIN dbo.LOG_tblInvoiceDetails AS ID ON I.InvoiceID = ID.HeaderID INNER JOIN dbo.LOG_tblMaster AS M ON ID.ProductID = M.ID INNER JOIN dbo.LOG_tblMaster AS D ON I.DestinationID = D.ID" _
            & " WHERE (I.CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (I.SessionID = " & Val(MDI.lblSessionID.Text) & ")" _
            & " AND (I.Online = 'True') AND (I.InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')" _
            & " AND (I.InvoiceID NOT IN (Select InvoiceID From LOG_tblOnlineInvoiceID))"
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
            strSQL = strSQL & " GROUP BY I.InvoiceID, I.InvoiceNo, I.InvoiceDate, D.fldName, CR.AccountName, CE.AccountName, I.BookingType, I.TotalPackage, I.TotalActualWeight, I.TotalChargeWeight, I.TotalAmount, I.TaxableAmount, I.BillAmount, I.Bilty, I.Printed, I.Online"
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
            'Grid.Columns(15).HeaderText = "Challan No"
            Grid.Columns(15).HeaderText = "Online"
            Grid.Columns(15).Visible = False

            '=========================
            Grid2.DataSource = Nothing

            For i = 0 To Grid.Rows.Count - 1
                If Grid.Rows(i).Cells(14).Value = "Y" Then
                    For j = 0 To Grid.Columns.Count - 1
                        Grid.Rows(i).Cells(j).Style.BackColor = Color.Silver
                    Next
                End If
                If Grid.Rows(i).Cells(15).Value = "True" Then
                    For j = 0 To Grid.Columns.Count - 1
                        Grid.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub GetOnlineData()
        Try


            Dim str As String = "DELETE From LOG_tblOnlineInvoiceID"
            cnn.executeSQL(str) 'COMPID = 1 FOR SRTC, 2 FOR SHREE ROADWAYS
            Dim query As String = "Select InvoiceID from SRTC_tblInvoice WHERE (CompID = 1) AND (CompanyID = " & Val(MDI.lblCompanyID.Text) & ") AND (SessionID = " & Val(MDI.lblSessionID.Text) & ")" _
        & " AND (InvoiceDate BETWEEN '" & cnn.GetDate(txtFromDate.Text) & "' AND '" & cnn.GetDate(txtToDate.Text) & "')"
            Dim cmdOn As Data.Odbc.OdbcCommand
            Dim drOn As Data.Odbc.OdbcDataReader
            cmdOn = New Data.Odbc.OdbcCommand(query, cnn.ocnn)
            If cmdOn.Connection.State = 1 Then cmdOn.Connection.Close()
            cmdOn.Connection.Open()
            drOn = cmdOn.ExecuteReader()
            Do While drOn.Read()
                str = "INSERT INTO LOG_tblOnlineInvoiceID (InvoiceID) VALUES (" & drOn.Item(0).ToString() & ")"
                cnn.executeSQL(str)
            Loop
            drOn.Close() : cmdOn.Connection.Close()
        Catch ex As Exception
            iNet = False
            'cnn.ErrMsgBox(ex.Message.ToString())
            cnn.ErrMsgBox("Please check your internet connection")
        End Try
    End Sub
    Private Sub frmLeftInvoiceList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmLeftInvoiceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub frmLeftInvoiceList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
                'GetDetails()
            End If
        End If
    End Sub



    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        frameEdit.Visible = True
    End Sub
    'Private Sub PostOnline()
    '    '-------- 20012022 DISABLE ALL COMMENT DUE TO ADD ChNo, ChDate, ChTruckNo, ChWt, ChBillAmt FIELDS IN ONLINE TABLE
    '    'If lblID.Text = "" Then
    '    '    cnn.ErrMsgBox("Please Select Record to Modify  !")
    '    '    Exit Sub
    '    'End If

    '    'Dim ival = cnn.GetInvDetails(Val(lblID.Text))
    '    'If ival = 0 Then

    '    'ElseIf ival = -2 Then
    '    '    cnn.ErrMsgBox("Duplicate Entry, Please check  !")
    '    'ElseIf ival = -5 Then
    '    '    cnn.ErrMsgBox("Something went Wrong  !")
    '    'End If
    '    'cnn.InfoMsgBox("Record has been Posted Online !")
    '    'frameEdit.Visible = False : BindGrid()
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frameSearch.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BindGrid()
        frameSearch.Visible = False
    End Sub

    Private Sub btnOnlineFrame_Click(sender As Object, e As EventArgs) Handles btnOnlineFrame.Click
        pnlProgress.Visible = True
        ProgressBar1.Visible = True

        'ProgressBar1.Minimum = 0
        'ProgressBar1.Maximum = Grid2.Rows.Count()
        PostOnline()
    End Sub
    Private Sub PostOnline()
        ''  -------- 20012022 DISABLE ALL COMMENT DUE TO ADD ChNo, ChDate, ChTruckNo, ChWt, ChBillAmt FIELDS IN ONLINE TABLE
        'If lblID.Text = "" Then
        '    cnn.ErrMsgBox("Please Select Record to Modify  !")
        '    Exit Sub
        'End If

        'Dim ival = cnn.GetSingleInvDetails(Val(lblID.Text))

        'If ival = 0 Then

        'ElseIf ival = -2 Then
        '    cnn.ErrMsgBox("Duplicate Entry, Please check  !")
        'ElseIf ival = -5 Then
        '    cnn.ErrMsgBox("Something went Wrong  !")
        'End If
        'cnn.InfoMsgBox("Record has been Posted Online !")
        'frameEdit.Visible = False : BindGrid()
        ProgressBar1.Maximum = Grid.Rows.Count()
        ProgressBar1.Step = 1

        Dim strSQL As String = "" : Dim InvID As Integer

        InvID = 0
        ' Timer1.Start()
        Do While (InvID < Grid.Rows.Count())

            Dim ival = cnn.GetSingleInvDetails(Val(Grid.Rows(InvID).Cells(0).Value))
            'If ival = 0 Then
            '    strSQL = "INSERT INTO LOG_tblOnlineInvoiceID (InvoiceID) VALUES (" & Val(Grid.Rows(InvID).Cells(0).Value) & ")"
            '    cnn.executeSQL(strSQL)
            'ElseIf ival = -2 Then
            '    cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            'ElseIf ival = -5 Then
            '    cnn.ErrMsgBox("Something went Wrong  !")
            'End If
            If ival = -5 Then
                cnn.ErrMsgBox("Something went Wrong  !")
            Else
                strSQL = "INSERT INTO LOG_tblOnlineInvoiceID (InvoiceID) VALUES (" & Val(Grid.Rows(InvID).Cells(0).Value) & ")"
                cnn.executeSQL(strSQL)
            End If


            'ProgressBar1.Value = ProgressBar1.Value + 1
            'lblPostedBilty.Text = ProgressBar1.Step & "/" & Grid2.Rows.Count() & " completed"
            ProgressBar1.PerformStep()

            ' strSQL = "UPDATE LOG_tblChallan SET Online= 'Y' WHERE ChallanID=" & Val(lblID.Text)
            InvID = InvID + 1
        Loop

        '  dr.Close() : cmd.Connection.Close()
        ' Timer1.Stop()
        '-------------  17092021

        'cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        'If cmd.Connection.State = 1 Then cmd.Connection.Close()
        'cmd.Connection.Open()
        'cmd.ExecuteNonQuery()
        'cmd.Connection.Close()
        cnn.InfoMsgBox("Record has been Posted Online  !")
        frameEdit.Visible = False : BindGrid() : pnlProgress.Visible = False : ProgressBar1.Visible = False : ProgressBar1.Value = 0
    End Sub

End Class