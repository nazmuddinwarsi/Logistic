﻿Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmConsigner
    Dim cnn As New DataConn.Conn
    Private Sub frmConsigner_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmConsigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        '==============================
        Grid.Width = MDI.ClientSize.Width
        Grid.Height = Me.Height - 157
        StripPanel.Width = MDI.Width
        ToolStrip1.Cursor = Cursors.Hand
        btnAdd.Image = MDI.ImageList1.Images(0)
        btnEdit.Image = MDI.ImageList1.Images(1)
        btnDelete.Image = MDI.ImageList1.Images(2)
        btnSearch.Image = MDI.ImageList1.Images(3)
        btnPrint.Image = MDI.ImageList1.Images(4)
        btnExit.Image = MDI.ImageList1.Images(5)
        '============================================
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT AccountID, AccountName, CPerson, Address, City, Mobile, GSTinNo, AadharNo FROM LOG_tblAccount WHERE tType='CNSR'"
        If txtSName.Text <> "" Then
            strSQL = strSQL & " AND AccountName LIKE " & cnn.SQLSearch(txtSName.Text)
        End If
        If txtSMobile.Text <> "" Then
            strSQL = strSQL & " AND Mobile LIKE " & cnn.SQLSearch(txtSMobile.Text)
        End If
        If txtSGST.Text <> "" Then
            strSQL = strSQL & " AND GSTinNo LIKE " & cnn.SQLSearch(txtSGST.Text)
        End If

        strSQL = strSQL & " ORDER BY AccountName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Consignor Name"
        Grid.Columns(2).HeaderText = "Contact Person"
        Grid.Columns(3).HeaderText = "Address"
        Grid.Columns(4).HeaderText = "City"
        Grid.Columns(5).HeaderText = "Mobile No"
        Grid.Columns(6).HeaderText = "GST No"
        Grid.Columns(7).HeaderText = "Aadhar No"
        Grid.Columns(2).Visible = False : Grid.Columns(3).Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCompany.Text = "" Then
            cnn.ErrMsgBox("Please Enter Consignor Name  !")
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
        If txtAadharNo.Text <> "" Then
            If Len(txtAadharNo.Text) <> 12 Then
                cnn.ErrMsgBox("Please Enter Valid Aadhar No  !")
                txtAadharNo.Focus()
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
        If lblID.Text <> "" Then
            strSQL = "UPDATE LOG_tblAccount SET AccountName=" & cnn.SQLquote(UCase(txtCompany.Text)) & ", CPerson=" & cnn.SQLquote(UCase(txtName.Text)) & ", Address=" & cnn.SQLquote(UCase(txtAddress.Text)) _
            & ", City=" & cnn.SQLquote(UCase(txtCity.Text)) & ", State=" & cnn.SQLquote(UCase(txtState.Text)) & ", Mobile=" & cnn.SQLquote(UCase(txtMobileNo.Text)) & ", GSTinNo=" & cnn.SQLquote(UCase(txtGST.Text)) _
            & ", AadharNo=" & cnn.SQLquote(UCase(txtAadharNo.Text)) & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "' WHERE AccountID=" & Val(lblID.Text)
        Else
            strSQL = "INSERT INTO LOG_tblAccount (tType, AccountName, CPerson, Address, City, State, Mobile, GSTinNo, AadharNo, CreatedBy, CreatedDate) VALUES ('CNSR'," & cnn.SQLquote(UCase(txtCompany.Text)) _
            & "," & cnn.SQLquote(UCase(txtName.Text)) & "," & cnn.SQLquote(UCase(txtAddress.Text)) & "," & cnn.SQLquote(UCase(txtCity.Text)) & "," & cnn.SQLquote(UCase(txtState.Text)) _
            & "," & cnn.SQLquote(UCase(txtMobileNo.Text)) & "," & cnn.SQLquote(UCase(txtGST.Text)) & "," & cnn.SQLquote(UCase(txtAadharNo.Text)) & "," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        End If
        cnn.executeSQL(strSQL)
        If lblID.Text <> "" Then
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
            frameSearch.Visible = False
        Else
            cnn.InfoMsgBox("Record has been Added Successfully  !")
        End If
        ClearText() : BindGrid()
    End Sub
    Private Sub ClearText()
        txtCompany.Text = "" : txtName.Text = "" : txtAddress.Text = "" : txtCity.Text = "" : txtState.Text = "" : txtMobileNo.Text = "" : txtGST.Text = ""
        lblID.Text = "" : txtCompany.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        frameSearch.Visible = True : lblID.Text = "" : txtCompany.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditRecord()
    End Sub
    Private Sub EditRecord()
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldEdit") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        '--------------------
        Dim strSQL As String
        strSQL = "SELECT * FROM LOG_tblAccount Where AccountID = " & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("AccountName")) Then
                txtCompany.Text = dr.Item("AccountName")
            End If
            If Not IsDBNull(dr.Item("CPerson")) Then
                txtName.Text = dr.Item("CPerson")
            End If
            If Not IsDBNull(dr.Item("Address")) Then
                txtAddress.Text = dr.Item("Address")
            End If
            If Not IsDBNull(dr.Item("City")) Then
                txtCity.Text = dr.Item("City")
            End If
            If Not IsDBNull(dr.Item("State")) Then
                txtState.Text = dr.Item("State")
            End If
            If Not IsDBNull(dr.Item("Mobile")) Then
                txtMobileNo.Text = dr.Item("Mobile")
            End If
            If Not IsDBNull(dr.Item("GSTinNo")) Then
                txtGST.Text = dr.Item("GSTinNo")
            End If
            If Not IsDBNull(dr.Item("AadharNo")) Then
                txtAadharNo.Text = dr.Item("AadharNo")
            End If

            dr.Close()
            cmd.Connection.Close()
            frameSearch.Visible = True : txtCompany.Focus()

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldDelete") = False Then
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
        strSQL = "Select InvoiceID from LOG_tblInvoice Where ConsignerID =" & Val(lblID.Text)
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("This Record is in Use, You can't delete this srecord  !")
            Exit Sub
        End If

        strSQL = "DELETE From LOG_tblAccount WHere AccountID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Deleted  !")
        BindGrid()
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(1).Value.ToString
            End If
        End If
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(1).Value.ToString
                EditRecord()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmConsigner_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = MDI.ClientSize.Width - (MDI.Panel.Width)
        Grid.Height = Me.Height - 37
        StripPanel.Width = Me.Width
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        BindGrid() : frameSearch2.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frameSearch2.Visible = True : txtSName.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Consignor List"
        strReportName = Application.StartupPath & "\Reports\AccountList.rpt"
        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayReport(CrxReport, reportDesc)
    End Sub

    Private Sub DisplayReport(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{rptInvoice.tType} = 'CNSR'"
         If txtSName.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.AccountName} LIKE " & cnn.CrystalSearch(txtSName.Text)
        End If
        If txtSMobile.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.Mobile} LIKE " & cnn.CrystalSearch(txtSMobile.Text)
        End If
        If txtSGST.Text <> "" Then
            strSelection = strSelection & " AND {rptInvoice.GSTinNo} LIKE " & cnn.CrystalSearch(txtSGST.Text)
        End If

        '===== Generate report preview =====================
        Cursor.Current = Cursors.WaitCursor
        CrxReport.Refresh()
        CrxReport.DataDefinition.FormulaFields("lblCaption").Text = "'Consignor List'"
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

    Private Sub btnSearchCancel_Click(sender As Object, e As EventArgs) Handles btnSearchCancel.Click
        frameSearch2.Visible = False
    End Sub
End Class