Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmTrans
    Dim cnn As New DataConn.Conn
    Dim strSQL As String
    Dim da As New OdbcDataAdapter
    Dim ds As New DataSet

    Private Sub frmTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        strSQL = "SELECT TOP (100) PERCENT T.ID, T.fldName, T.MobileNo, C.fldName AS CityName FROM dbo.LOG_tblMaster AS T LEFT OUTER JOIN dbo.LOG_tblMaster AS C ON T.CityID = C.ID" _
        & " WHERE (T.tType = 'TRANS')"
        If txtCity.Text <> "" Then
            strSQL = strSQL & " AND C.fldName LIKE " & cnn.SQLSearch(txtCity.Text)
        End If
        strSQL = strSQL & " ORDER BY T.fldName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Transporter Name"
        Grid.Columns(2).HeaderText = "Mobile No"
        Grid.Columns(3).HeaderText = "City Name"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BindGrid()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i = 0 To Grid.Rows.Count - 1
                strSQL = "UPDATE LOG_tblMaster SET fldName=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(1).Value.ToString)) & ", MobileNo=" & cnn.SQLquote(UCase(Grid.Rows(i).Cells(2).Value.ToString)) _
                & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "' WHERE ID=" & Val(Grid.Rows(i).Cells(0).Value.ToString)
                cnn.executeSQL(strSQL)
            Next
            cnn.InfoMsgBox("All Record Updated")
            BindGrid()
        Catch ex As Exception
            cnn.ErrMsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        
    End Sub
End Class