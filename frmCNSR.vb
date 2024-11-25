Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmCNSR
    Dim cnn As New DataConn.Conn
    Dim strSQL As String

    Private Sub frmCNSR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmCNSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        '==============================
        Grid.Width = Me.Width
        Grid.Height = Me.Height - 157
        StripPanel.Width = MDI.Width
        '============================================
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT AccountID, AccountName, CPerson, Address, City, Mobile, GSTinNo, AadharNo, '' FROM LOG_tblAccount WHERE tType='CNSR'"
        If txtCity.Text <> "" Then
            strSQL = strSQL & " AND City LIKE " & cnn.SQLSearch(txtCity.Text)
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
        Grid.Columns(8).HeaderText = "#"
        Grid.Columns(8).Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i = 0 To Grid.Rows.Count - 1
                If Grid.Rows(i).Cells(8).Value <> "" Then
                    strSQL = "UPDATE LOG_tblAccount SET AccountName=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(1).Value.ToString)) & ", CPerson=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(2).Value.ToString)) & ", Address=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(3).Value.ToString)) _
                    & ", City=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(4).Value.ToString)) & ", Mobile=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(5).Value.ToString)) & ", GSTinNo=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(6).Value.ToString)) _
                    & ", AadharNo=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(7).Value.ToString)) & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "' WHERE AccountID=" & Val(Grid.Rows(i).Cells(0).Value.ToString)
                    cnn.executeSQL(strSQL)
                End If
            Next
            cnn.InfoMsgBox("All Record Updated")
            BindGrid()
        Catch ex As Exception
            cnn.ErrMsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BindGrid()
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        Dim iRow As Integer = Grid.CurrentCell.RowIndex
        Grid.Rows(iRow).Cells(8).Value = "A"
    End Sub
End Class