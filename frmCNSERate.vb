Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmCNSERate
    Dim cnn As New DataConn.Conn
    Dim strSQL As String
    Dim da As New OdbcDataAdapter
    Dim ds As New DataSet

    Private Sub frmCNSERate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmCNSERate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        '==============================
        Grid.Width = Me.Width
        Grid.Height = Me.Height - 157
        StripPanel.Width = MDI.Width
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT AccountID, AccountName, Mobile, GSTinNo, AadharNo, CASE WHEN RateBy='P' THEN 'PACKAGE' ELSE 'WEIGHT' END AS RateBy, ProductRate FROM LOG_tblAccount WHERE tType='CNSE'"
        If txtCity.Text <> "" Then
            strSQL = strSQL & " AND City LIKE " & cnn.SQLSearch(txtCity.Text)
        End If
        If rbP.Checked = True Then
            strSQL = strSQL & " AND RateBy = 'P'"
        Else
            strSQL = strSQL & " AND RateBy = 'W'"
        End If

        strSQL = strSQL & " ORDER BY AccountName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Consignee Name"
        Grid.Columns(2).HeaderText = "Mobile No"
        Grid.Columns(3).HeaderText = "GST No"
        Grid.Columns(4).HeaderText = "Aadhar No"
        Grid.Columns(5).HeaderText = "Rate By"
        Grid.Columns(6).HeaderText = "Rate"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BindGrid()
    End Sub

    Private Sub Grid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid.CellBeginEdit
        If e.ColumnIndex = 6 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        Try
            'Dim result As Double
            'result = Grid.CurrentCell.Value
            If Not IsNumeric(Grid.CurrentCell.Value) Then
                cnn.ErrMsgBox("Invalid Marks, Please Check  !") '
                Grid.CurrentCell.Value = 0
                Exit Sub
            End If

        Catch ex As Exception
            cnn.ErrMsgBox("Invalid value")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i = 0 To Grid.Rows.Count - 1
                strSQL = "UPDATE LOG_tblAccount SET ProductRate=" & Val(Grid.Rows(i).Cells(6).Value.ToString) _
                & " WHERE AccountID=" & Val(Grid.Rows(i).Cells(0).Value.ToString)
                cnn.executeSQL(strSQL)
            Next
            cnn.InfoMsgBox("All Record Updated")
            BindGrid()
        Catch ex As Exception
            cnn.ErrMsgBox(ex.Message.ToString())

        End Try
    End Sub
End Class