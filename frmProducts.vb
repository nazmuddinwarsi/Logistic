Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmProducts
    Dim cnn As New DataConn.Conn

    Private Sub frmProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        strSQL = "SELECT ID, fldName FROM LOG_tblMaster WHERE tType='PROD' ORDER BY fldName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Product Name"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Product Name  !")
            txtName.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        '--------------------- CHECK DUPLICATE
        If lblID.Text = "" Then
            strSQL = "Select ID from LOG_tblMaster Where fldName=" & cnn.SQLquote(UCase(txtName.Text)) & " AND tType='PROD'"
        Else
            strSQL = "Select ID from LOG_tblMaster Where fldName=" & cnn.SQLquote(UCase(txtName.Text)) & " AND tType='PROD' AND ID <>" & Val(lblID.Text)
        End If
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("Duplicate Entry, Please check  !")
            txtName.Focus()
            Exit Sub
        End If
        '--------------------- CHECK DUPLICATE
        If lblID.Text <> "" Then
            strSQL = "UPDATE LOG_tblMaster SET fldName=" & cnn.SQLquote(UCase(txtName.Text)) & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "' WHERE ID=" & Val(lblID.Text)
        Else
            strSQL = "INSERT INTO LOG_tblMaster (fldName, tType, CreatedBy, CreatedDate) VALUES (" & cnn.SQLquote(UCase(txtName.Text)) & ",'PROD'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        End If
        cnn.executeSQL(strSQL)
        If lblID.Text <> "" Then
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
            frameSearch.Visible = False
        Else
            cnn.InfoMsgBox("Record has been Added Successfully  !")
        End If
        txtName.Text = "" : lblID.Text = "" : BindGrid() : txtName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MDI.lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        frameSearch.Visible = True : txtName.Focus()
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
        strSQL = "SELECT ID, fldName FROM LOG_tblMaster Where ID = " & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("fldName")) Then
                txtName.Text = dr.Item("fldName")
            End If
            dr.Close()
            cmd.Connection.Close()
            frameSearch.Visible = True : txtName.Focus()

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
        strSQL = "Select InvDetailID from LOG_tblInvoiceDetails Where ProductID =" & Val(lblID.Text)
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("This Record is in Use, You can't delete this srecord  !")
            Exit Sub
        End If

        strSQL = "DELETE From LOG_tblMaster WHere ID=" & Val(lblID.Text)
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

    Private Sub frmProducts_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = MDI.ClientSize.Width - (MDI.Panel.Width)
        Grid.Height = Me.Height - 37
        StripPanel.Width = Me.Width
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim reportDesc As String = "Product List"
        strReportName = Application.StartupPath & "\Reports\MasterList.rpt"


        CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Call DisplayReport(CrxReport, reportDesc)
    End Sub
    Private Sub DisplayReport(ByVal CrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportDesc As String)
        Dim objfrmRptViewer As New frmRptViewer
        Dim strSelection As String
        strSelection = "{LOG_tblMaster.tType} = 'PROD'"
        
        '===== Generate report preview =====================
        Cursor.Current = Cursors.WaitCursor
        CrxReport.Refresh()
        CrxReport.DataDefinition.FormulaFields("lblCaption").Text = "'Products List'"
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