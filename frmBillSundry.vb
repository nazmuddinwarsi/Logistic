Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class frmBillSundry
    Dim cnn As New DataConn.Conn

    Private Sub frmBillSundry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmBillSundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        StripPanel.Width = MDI.Width
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Trim(txtName.Text) = "" Then
            cnn.ErrMsgBox("Please Enter Sundry Name...!")
            txtName.Focus()
            Exit Sub
        End If
        '---------------
        Try
            Dim strSQL, sType, sRoundOff, sRoundType, sAmtAs, sPercOf, iFix As String
            If optAdd.Checked = True Then
                sType = "ADD"
            Else
                sType = "SUB"
            End If
            If chkFix.Checked = True Then
                iFix = "Y"
            Else
                iFix = "N"
            End If
            If chkRoundOff.Checked = 0 Then
                sRoundOff = "N"
                sRoundType = ""
            Else
                sRoundOff = "Y"
                If optAuto.Checked = True Then
                    sRoundType = "AUTO"
                ElseIf optUp.Checked = True Then
                    sRoundType = "UP"
                ElseIf optLow.Checked = True Then
                    sRoundType = "LOW"
                End If
            End If
            If optAmt.Checked = True Then
                sAmtAs = "AMT" : sPercOf = ""
            Else
                sAmtAs = "PER"
                If optBasic.Checked = True Then
                    sPercOf = "BASIC"
                ElseIf optTaxable.Checked = True Then
                    sPercOf = "TAX"
                ElseIf optBill.Checked = True Then
                    sPercOf = "BILL"
                ElseIf optPrevious.Checked = True Then
                    sPercOf = "PREV"
                End If
            End If

            If lblID.Text = "" Then
                If cnn.CheckDuplicate("Select SundryID from LOG_BillSundry Where SundryName=" & cnn.SQLquote(UCase(txtName.Text))) = True Then
                    cnn.ErrMsgBox("Duplicate Entry Please check...!")
                    txtName.Focus()
                    Exit Sub
                End If
            End If
            'cnn.OpenConn()
            'cnn.Tran = cnn.cnn.BeginTransaction
            If lblID.Text <> "" Then
                strSQL = "UPDATE  LOG_BillSundry SET SundryName=" & cnn.SQLquote(UCase(txtName.Text)) & ", DefaultValue=" & Val(txtValue.Text) & ", SundryType='" & sType & "'" _
                & ", RoundOff='" & sRoundOff & "'" & ", RoundOffType='" & sRoundType & "', AmountAs='" & sAmtAs & "', PercentOf='" & sPercOf & "', Active = " & Val(chkActive.Checked) _
                & ", EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "'" _
                & ", Enable='" & iFix & "' WHERE SundryID=" & Val(lblID.Text)
                cnn.executeSQL(strSQL)
                cnn.GenerateLog("Bill Sundry", "Edit", lblID.Text, cnn.SQLquote(UCase(txtName.Text)))
            Else
                strSQL = "INSERT INTO LOG_BillSundry (SundryName, DefaultValue, SundryType, RoundOff, RoundOffType, AmountAs, PercentOf, Active, Enable, CreatedBy, CreatedDate) VALUES ("
                strSQL = strSQL & cnn.SQLquote(UCase(txtName.Text)) & "," & Val(txtValue.Text) & ",'" & sType & "'" _
                & ",'" & sRoundOff & "','" & sRoundType & "','" & sAmtAs & "','" & sPercOf & "'," & Val(chkActive.Checked) & ",'" & iFix & "'" _
                & "," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
                cnn.executeSQL(strSQL)
                cnn.GenerateLog("Bill Sundry", "Add", 0, cnn.SQLquote(UCase(txtName.Text)))
            End If
            'cnn.Tran.Commit()
            cnn.CloseConn()
            If lblID.Text <> "" Then
                cnn.InfoMsgBox("Record has been Updated Successfully  !")
                Me.Close()
            Else
                cnn.InfoMsgBox("Record has been Added Successfully  !")
                lblID.Text = ""
                txtName.Text = ""
                txtValue.Text = ""
                chkRoundOff.Checked = False
                optAuto.Checked = True
                optAdd.Checked = True
                optAmt.Checked = True
                optBasic.Checked = True
                chkActive.Checked = True
                txtName.Focus()
            End If
        Catch ex As Exception
            'cnn.Tran.Rollback()
            cnn.ErrMsgBox("There is a Problem due to " & ex.Message)
        End Try
    End Sub

    Private Sub chkRoundOff_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoundOff.CheckedChanged
        If chkRoundOff.Checked = True Then
            frameRoundOff.Enabled = True
        Else
            frameRoundOff.Enabled = False
        End If
    End Sub

    Private Sub optAmt_CheckedChanged(sender As Object, e As EventArgs) Handles optAmt.CheckedChanged
        frameOf.Enabled = False
    End Sub

    Private Sub optPer_CheckedChanged(sender As Object, e As EventArgs) Handles optPer.CheckedChanged
        frameOf.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class