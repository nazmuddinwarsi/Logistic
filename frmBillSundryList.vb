Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBillSundryList
    Dim cnn As New DataConn.Conn

    Private Sub frmBillSundryList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT SundryID, SundryName, DefaultValue, CASE WHEN SundryType = 'ADD' THEN 'ADDITIVE' ELSE 'SUBSTRACTIVE' END AS SundryType, RoundOff, RoundOffType, AmountAs," _
        & " PercentOf, Active FROM LOG_BillSundry ORDER BY SundryName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Sundry Name"
        Grid.Columns(2).HeaderText = "Default Value"
        Grid.Columns(3).HeaderText = "Sundry Type"
        Grid.Columns(4).HeaderText = "Round Off"
        Grid.Columns(5).HeaderText = "Round Off Type"
        Grid.Columns(6).HeaderText = "Amount As"
        Grid.Columns(7).HeaderText = "Percent Of"
        Grid.Columns(8).HeaderText = "Active"
    End Sub

    Private Sub frmBillSundryList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBillSundryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        '===========================================
    End Sub

    Private Sub frmBillSundryList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = Me.Width
        Grid.Height = Me.Height - 157
        StripPanel.Width = Me.Width
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If MDI.lblAccessType.Text <> "A" Then
        '    cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
        '    Exit Sub
        'End If
        cnn.ShowForm(frmBillSundry)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditRecord()
    End Sub
    Private Sub EditRecord()
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        If MDI.lblAccessType.Text <> "A" Then
            cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
            Exit Sub
        End If
        ''--------------------
        Dim strSQL As String
        strSQL = "Select SundryID, SundryName, DefaultValue, SundryType, RoundOff, RoundOffType, AmountAs, PercentOf, Active from LOG_BillSundry Where SundryID=" & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            cnn.ShowForm(frmBillSundry)
            frmBillSundry.lblID.Text = lblID.Text
            If Not IsDBNull(dr.Item("SundryName")) Then
                frmBillSundry.txtName.Text = dr.Item("SundryName")
            End If
            If Not IsDBNull(dr.Item("DefaultValue")) Then
                frmBillSundry.txtValue.Text = dr.Item("DefaultValue")
            End If
            If Not IsDBNull(dr.Item("SundryType")) Then
                If dr.Item("SundryType") = "ADD" Then
                    frmBillSundry.optAdd.Checked = True
                Else
                    frmBillSundry.optSub.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("RoundOff")) Then
                If dr.Item("RoundOff") = "Y" Then
                    frmBillSundry.chkRoundOff.Checked = True
                Else
                    frmBillSundry.chkRoundOff.Checked = False
                End If
            End If
            If Not IsDBNull(dr.Item("RoundOffType")) Then
                If dr.Item("RoundOffType") <> "" Then
                    If dr.Item("RoundOffType") = "AUTO" Then
                        frmBillSundry.optAuto.Checked = True
                    ElseIf dr.Item("RoundOffType") = "UP" Then
                        frmBillSundry.optUp.Checked = True
                    ElseIf dr.Item("RoundOffType") = "LOW" Then
                        frmBillSundry.optLow.Checked = True
                    End If
                End If
            End If
            If Not IsDBNull(dr.Item("AmountAs")) Then
                If dr.Item("AmountAs") = "AMT" Then
                    frmBillSundry.optAmt.Checked = True
                Else
                    frmBillSundry.optPer.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("PercentOf")) Then
                If dr.Item("PercentOf") <> "" Then
                    If dr.Item("PercentOf") = "BASIC" Then
                        frmBillSundry.optBasic.Checked = True
                    ElseIf dr.Item("PercentOf") = "TAX" Then
                        frmBillSundry.optTaxable.Checked = True
                    ElseIf dr.Item("PercentOf") = "BILL" Then
                        frmBillSundry.optBill.Checked = True
                    ElseIf dr.Item("PercentOf") = "PREV" Then
                        frmBillSundry.optPrevious.Checked = True
                    End If
                End If
            End If
            If Not IsDBNull(dr.Item("Active")) Then
                If dr.Item("Active") = "True" Then
                    frmBillSundry.chkActive.Checked = True
                Else
                    frmBillSundry.chkActive.Checked = False
                End If
            End If
            dr.Close()
            cmd.Connection.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()

    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Rows.Count > 0 Then
            If Grid.CurrentCell.RowIndex > -1 Then
                Dim crRowIndex As Integer = Grid.CurrentCell.RowIndex
                lblID.Text = Grid.Rows(crRowIndex).Cells(0).Value.ToString
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
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
                lblName.Text = Grid.Rows(crRowIndex).Cells(2).Value.ToString
                EditRecord()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class