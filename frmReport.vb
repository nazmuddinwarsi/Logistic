Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office.Interop
Public Class frmReport
    Dim cnn As New DataConn.Conn
    Private Sub BindGrid()
        Dim strSQL, sSQL, iCancel As String
        If rbCancelAll.Checked = True Then
            iCancel = "A"
        ElseIf rbCancelNO.Checked = True Then
            iCancel = "N"
        Else
            iCancel = "Y"
        End If


        Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand
        cmd.Connection = cnn.cnn
        cmd.CommandText = "{call LOG_Sp_GET_Report(?,?,?)}"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@FromDate", OdbcType.VarChar, 10) : cmd.Parameters("@FromDate").Value = cnn.GetDate(txtFromDate.Text)
        cmd.Parameters.Add("@ToDate", OdbcType.VarChar, 10) : cmd.Parameters("@ToDate").Value = cnn.GetDate(txtToDate.Text)
        cmd.Parameters.Add("@Cancelled", OdbcType.VarChar, 1) : cmd.Parameters("@Cancelled").Value = iCancel
        Dim da As New OdbcDataAdapter(cmd)
        Dim dt As New System.Data.DataTable()
        da.Fill(dt)
        Grid.DataSource = dt
        Grid.Columns(0).HeaderText = "CN No"
        Grid.Columns(1).HeaderText = "Date"
        Grid.Columns(2).HeaderText = "Destination"
        Grid.Columns(3).HeaderText = "Packages"
        Grid.Columns(4).HeaderText = "Product Name"
        Grid.Columns(5).HeaderText = "Actual Wt."
        Grid.Columns(6).HeaderText = "Charge Wt."
        Grid.Columns(7).HeaderText = "Consignor Name"
        Grid.Columns(8).HeaderText = "Consignor GST"
        Grid.Columns(9).HeaderText = "Consignee Name"
        Grid.Columns(10).HeaderText = "Consignee GST"
        Grid.Columns(11).HeaderText = "Freight"
        'Grid.Columns(10).HeaderText = "IGST"
        'Grid.Columns(11).HeaderText = "To Pay Amt"
        'Grid.Columns(12).HeaderText = "Paid Amt"
        'Grid.Columns(12).HeaderText = "RCM"
        '=========================

    End Sub
    Private Sub frmReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        '==============================
        txtFromDate.Text = DateAdd(DateInterval.Month, -1, Date.Today)
        txtToDate.Text = Date.Today
    End Sub
    Private Sub frmReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = Me.Width
        Grid.Height = Me.Height - 157
        StripPanel.Width = Me.Width
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BindGrid()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try


            ' creating Excel Application
            Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application
            ' creating new WorkBook within Excel application
            Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
            ' creating new Excelsheet in workbook
            Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
            ' see the excel sheet behind the program
            app.Visible = True
            ' get the reference of first sheet. By default its name is Sheet1.
            ' store its reference to worksheet
            worksheet = workbook.Sheets("Sheet1")
            worksheet = workbook.ActiveSheet
            ' changing the name of active sheet
            worksheet.Name = "Exported from Grid"
            ' storing header part in Excel
            worksheet.Range("B:B").Cells.NumberFormat = "dd/mm/yyyy"
            Dim i As Integer = 1
            Do While (i _
                        < (Grid.Columns.Count + 1))
                worksheet.Cells(1, i) = Grid.Columns((i - 1)).HeaderText
                i = (i + 1)
            Loop

            ' storing Each row and column value to excel sheet
            i = 0
            Do While (i < (Grid.Rows.Count))
                Dim j As Integer = 0
                Do While (j < Grid.Columns.Count)
                    worksheet.Cells((i + 2), (j + 1)) = Grid.Rows(i).Cells(j).Value.ToString
                    j = (j + 1)
                Loop
                i = (i + 1)
            Loop

            ' save the application
            Dim fileName As String = "Report_" + DateTime.Now.ToString("ddMMyyyhhmmss") & ".xls"
            workbook.SaveAs("E:\" & fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            ' Exit from the application
            app.Quit()
        Catch ex As Exception
            cnn.ErrMsgBox("Please Check File Location or File is in Use")
        End Try
    End Sub

    Private Sub Grid_DataSourceChanged(sender As Object, e As EventArgs) Handles Grid.DataSourceChanged
        'Dim sum As Integer = 0
        'Dim i As Integer = 0
        'Do While (i < (Grid.Rows.Count - 1))
        '    'If (Grid(7, i).Value <> DBNull.Value) Then
        '    sum = (sum + CType(Grid(7, i).Value, Integer))
        '    'End If

        '    i = (i + 1)
        'Loop

        'Grid(7, (Grid.Rows.Count - 1)).Value = sum
    End Sub
End Class