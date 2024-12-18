﻿Imports System
Imports System.Data
Imports System.Drawing
Imports System.Data.Odbc

Public Class frmCompany
    Dim cnn As New DataConn.Conn

    Private Sub frmCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub frmCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.SetBounds(0, 0, MDI.Width, MDI.Height)
        Me.MdiParent = MDI
        StripPanel.Width = MDI.Width
        '=========================================
        Dim strSQL As String
        strSQL = "SELECT CompanyName, CompanyAddress, CompanyCity, CompanyState, CompanyPhone, CompanyEmailID, CompanyWebsite, CopanyGSTinNo" _
        & " FROM LOG_tblCompany Where CompanyID = " & Val(MDI.lblCompanyID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            lblID.Text = Val(MDI.lblCompanyID.Text)
            If Not IsDBNull(dr.Item("CompanyName")) Then
                txtName.Text = dr.Item("CompanyName")
            End If
            If Not IsDBNull(dr.Item("CompanyAddress")) Then
                txtAddress.Text = dr.Item("CompanyAddress")
            End If
            If Not IsDBNull(dr.Item("CompanyCity")) Then
                txtCity.Text = dr.Item("CompanyCity")
            End If
            If Not IsDBNull(dr.Item("CompanyState")) Then
                txtState.Text = dr.Item("CompanyState")
            End If
            If Not IsDBNull(dr.Item("CompanyPhone")) Then
                txtPhone.Text = dr.Item("CompanyPhone")
            End If
            If Not IsDBNull(dr.Item("CompanyEmailID")) Then
                txtEmail.Text = dr.Item("CompanyEmailID")
            End If
            If Not IsDBNull(dr.Item("CompanyWebsite")) Then
                txtWebsite.Text = dr.Item("CompanyWebsite")
            End If
            If Not IsDBNull(dr.Item("CopanyGSTinNo")) Then
                txtTIN.Text = dr.Item("CopanyGSTinNo")
            End If
            dr.Close()
            cmd.Connection.Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtName.Text) = "" Then
            cnn.ErrMsgBox("Please Enter Company Name...!")
            txtName.Focus()
            Exit Sub
        End If
        If Trim(txtAddress.Text) = "" Then
            cnn.ErrMsgBox("Please Enter Address...!")
            txtAddress.Focus()
            Exit Sub
        End If
        If Trim(txtCity.Text) = "" Then
            cnn.ErrMsgBox("Please Enter City Name...!")
            txtCity.Focus()
            Exit Sub
        End If
        '---------------
        Try

            Dim strSQL As String
            'If lblID.Text = "" Then
            '    strSQL = "Select ID from CompanyMaster Where CompanyName=" & cnn.SQLquote(txtName.Text)
            '    If cnn.CheckDuplicate(strSQL) = True Then
            '        cnn.ErrMsgBox("Duplicate Entry Please check...!")
            '        txtName.Focus()
            '        Exit Sub
            '    End If
            'End If
            If lblID.Text <> "" Then
                strSQL = "UPDATE LOG_tblCompany Set CompanyName=" & cnn.SQLquote(UCase(txtName.Text)) & ", CompanyAddress=" & cnn.SQLquote(txtAddress.Text)
                strSQL = strSQL & ", CompanyCity=" & cnn.SQLquote(txtCity.Text) & ", CompanyState=" & cnn.SQLquote(txtState.Text) _
                & ", CompanyPhone=" & cnn.SQLquote(txtPhone.Text) & ", CompanyEmailID=" & cnn.SQLquote(txtEmail.Text) & ", CompanyWebsite=" & cnn.SQLquote(txtWebsite.Text) _
                & ", CopanyGSTinNo=" & cnn.SQLquote(txtTIN.Text) & " Where CompanyID=" & lblID.Text
                cnn.executeSQL(strSQL)
                cnn.GenerateLog("Master Company", "Edit", lblID.Text, UCase(txtName.Text))
            Else
                'strSQL = "INSERT INTO LOG_tblCompany (CompanyName, Address, City, State, Country, Phone, Fax, EmailID, Website, MasterTIN, MasterCST, MasterPAN, MasterServiceTax, MasterSalesTax) VALUES ("
                'strSQL = strSQL & cnn.SQLquote(UCase(txtName.Text)) & "," & cnn.SQLquote(UCase(txtAddress.Text)) & "," & cnn.SQLquote(txtCity.Text) & "," & cnn.SQLquote(txtState.Text) & "," & cnn.SQLquote(txtCountry.Text)
                'strSQL = strSQL & "," & cnn.SQLquote(txtPhone.Text) & "," & cnn.SQLquote(txtFax.Text) & "," & cnn.SQLquote(txtEmail.Text) & "," & cnn.SQLquote(txtWebsite.Text) & "," & cnn.SQLquote(txtTIN.Text) & "," & cnn.SQLquote(txtCST.Text)
                'strSQL = strSQL & "," & cnn.SQLquote(txtPAN.Text) & "," & cnn.SQLquote(txtServiceTax.Text) & "," & cnn.SQLquote(txtSalesTax.Text) & ")"
                'cnn.executeSQL(strSQL)
                'cnn.GenerateLog("Master COmpany", "Add", 0, UCase(txtName.Text))
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
                txtAddress.Text = ""
                txtCity.Text = ""
                txtState.Text = ""
                txtCountry.Text = ""
                txtPhone.Text = ""
                txtFax.Text = ""
                txtEmail.Text = ""
                txtWebsite.Text = ""
                txtTIN.Text = ""
                txtCST.Text = ""
                txtPAN.Text = ""
                txtServiceTax.Text = ""
                txtSalesTax.Text = ""
                txtName.Focus()
            End If
        Catch ex As Exception
            'cnn.Tran.Rollback()
            cnn.ErrMsgBox("There is a Problem due to " & ex.Message)
        End Try
    End Sub
End Class