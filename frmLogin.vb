Imports System
Imports System.Data
Imports System.Drawing
Imports System.Data.Odbc
Public Class frmLogin
    Dim cnn As New DataConn.Conn
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbSession.Text = "" Then
            MessageBox.Show("Please Select Session Name  !", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbSession.Focus()
            Exit Sub
        End If
        If Val(cmbSession.SelectedValue) = 0 Then
            MessageBox.Show("Please Select Session Name from List  !", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbSession.Focus()
            Exit Sub
        End If
        If txtUserName.Text = "" Then
            MessageBox.Show("Enter User Name...!", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserName.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Enter Password...!", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        '------------------------------------------
        
        'Dim iCheckDate As Integer
        'iCheckDate = cnn.CheckExpDate(Date.Today())
        'If iCheckDate < 0 Then
        '    cnn.ErrMsgBox("Your Software has been expired." & vbCrLf & "Please contact your Software Provider  !")
        '    cnn.executeSQL("UPDATE LOG_tblPara SET dExp = 1")
        '    Exit Sub
        'ElseIf iCheckDate = 1 Then
        '    cnn.ErrMsgBox("There is Problem in Software configuration." & vbCrLf & " Please contact your Software Provider  !")
        '    Exit Sub
        'ElseIf iCheckDate = 2 Then
        '    cnn.InfoMsgBox("Software is going to be expire within 10 Days." & vbCrLf & " Please contact your Software Provider  !")
        '    'Exit Sub
        'End If
        '------------------------------------------
        strSQL = "select UserID, fldPassword, AccessType, Active from LOG_tblUsers where fldUserName=" & cnn.SQLquote(txtUserName.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cnn.cnn.State = ConnectionState.Open Then cnn.cnn.Close()
        cnn.cnn.Open()
        Dim rdr As Data.Odbc.OdbcDataReader = cmd.ExecuteReader
        If rdr.Read Then
            If rdr.Item("Active") = "N" Then
                rdr.Close()
                MessageBox.Show("User has been Suspended, Please Contact Administrator  !", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserName.Focus()
                Exit Sub
            End If
            If txtPassword.Text = rdr.Item("fldPassword") Then
                MDI.lblAccessType.Text = rdr.Item("AccessType")
                MDI.lblUserLoginID.Text = rdr.Item("UserID")
                MDI.lblCompanyID.Text = Val(cmbCompany.SelectedValue)
                MDI.lblSessionID.Text = Val(cmbSession.SelectedValue)
                rdr.Close()
                MDI.Text = "Welcome to eLozics Transport & Logistics Management ( " & cmbSession.Text & " )"
                MDI.Show()
                Me.Hide()
            Else
                rdr.Close()
                MessageBox.Show("Invalid Password, try again!", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Exit Sub
            End If
        Else
            rdr.Close()
            MessageBox.Show("User does not exist contact system administrator...!", cnn.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserName.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Application.Exit()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nExp As Expires = cnn.CheckExpDate(Date.Today())
        If nExp.Num < 0 Then
            cnn.ErrMsgBox("Your Software has been expired." & vbCrLf & "Please contact your Software Provider  !")
            cnn.executeSQL("UPDATE LOG_tblPara SET dExp = 1")
            Application.Exit()
        ElseIf nExp.Num = 1 Then
            cnn.ErrMsgBox("There is Problem in Software configuration." & vbCrLf & " Please contact your Software Provider  !")
            Exit Sub
        ElseIf nExp.Num = 2 Then
            cnn.InfoMsgBox("Software is going to be expire within " & nExp.Days & " Days." & vbCrLf & " Please contact your Software Provider  !")
            'Exit Sub
        End If

        Dim strSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        strSQL = "Select CompanyID, CompanyName from LOG_tblCompany ORDER BY CompanyName ASC"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        cmbCompany.DisplayMember = "CompanyName"
        cmbCompany.ValueMember = "CompanyID"
        cmbCompany.DataSource = ds.Tables(0)
        cmbCompany.SelectedIndex = 0
        '===========================
        strSQL = "Select ID, SessionName from LOG_tblSession ORDER BY ID DESC"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        cmbSession.DisplayMember = "SessionName"
        cmbSession.ValueMember = "ID"
        cmbSession.DataSource = ds.Tables(0)
        cmbSession.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub
End Class