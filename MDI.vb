Imports System.Windows.Forms

Public Class MDI
    Dim cnn As New DataConn.Conn
    Dim db As New DataConn.dbBackup
    Private Sub MDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblAccessType.Text <> "A" Then
            btnUsers.Visible = False : btnUserRight.Visible = False
        End If
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmProducts)
    End Sub

    Private Sub btnConsignee_Click(sender As Object, e As EventArgs) Handles btnConsignee.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmConsignee)
    End Sub

    Private Sub btnCity_Click(sender As Object, e As EventArgs) Handles btnCity.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmCity)
    End Sub

    Private Sub btnConsigners_Click(sender As Object, e As EventArgs) Handles btnConsigners.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmConsigner)
    End Sub

    Private Sub smnuBillSundry_Click(sender As Object, e As EventArgs) Handles smnuBillSundry.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmBillSundryList)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmTransporter)
    End Sub

    Private Sub smnuUserList_Click(sender As Object, e As EventArgs) Handles smnuUserList.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmUsers)
    End Sub

    Private Sub smnuInvoice_Click(sender As Object, e As EventArgs) Handles smnuInvoice.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(2, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmInvoiceList)
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(2, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmInvoice)
    End Sub

    Private Sub btnBilty_Click(sender As Object, e As EventArgs) Handles btnBilty.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBilty)
    End Sub

    Private Sub btnTransporter_Click(sender As Object, e As EventArgs)
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmTransporter)
    End Sub

    Private Sub smnuBilty_Click(sender As Object, e As EventArgs) Handles smnuBilty.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBiltyList)
    End Sub

    Private Sub smnuProductList_Click(sender As Object, e As EventArgs) Handles smnuProductList.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmProducts)
    End Sub

    Private Sub smnuConsignerList_Click(sender As Object, e As EventArgs) Handles smnuConsignerList.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmConsigner)
    End Sub

    Private Sub smnuConsigneeList_Click(sender As Object, e As EventArgs) Handles smnuConsigneeList.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmConsignee)
    End Sub

    Private Sub smnuCityList_Click(sender As Object, e As EventArgs) Handles smnuCityList.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmCity)
    End Sub

    Private Sub mnuTransporter_Click(sender As Object, e As EventArgs) Handles mnuTransporter.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(1, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmTransporter)
    End Sub

    Private Sub mnuLogOff_Click(sender As Object, e As EventArgs) Handles mnuLogOff.Click
        Application.Exit()
    End Sub

    Private Sub smnuExit_Click(sender As Object, e As EventArgs) Handles smnuExit.Click
        Application.Exit()
    End Sub

    Private Sub smnuUserRights_Click(sender As Object, e As EventArgs) Handles smnuUserRights.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmUserRight)
    End Sub

    Private Sub mnuBackup_Click(sender As Object, e As EventArgs) Handles mnuBackup.Click
        'If lblAccessType.Text <> "A" Then
        '    Exit Sub
        'End If
        cnn.dbBackup()
    End Sub

    Private Sub mnuRestore_Click(sender As Object, e As EventArgs) Handles mnuRestore.Click
        'If lblAccessType.Text <> "A" Then
        '    Exit Sub
        'End If
        cnn.DBRestore()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        cnn.ShowForm(frmReport)
    End Sub

    Private Sub btnUserRight_Click(sender As Object, e As EventArgs) Handles btnUserRight.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmUserRight)
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldAdd") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBill)
    End Sub

    Private Sub smnuBill_Click(sender As Object, e As EventArgs) Handles smnuBill.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmBillList)
    End Sub

    Private Sub mnuSession_Click(sender As Object, e As EventArgs) Handles mnuSession.Click
        If lblAccessType.Text = "A" Then
            cnn.ShowForm(frmSession)
        End If
    End Sub

    Private Sub mnuCompany_Click(sender As Object, e As EventArgs) Handles mnuCompany.Click
        If lblAccessType.Text = "A" Then
            cnn.ShowForm(frmCompany)
        End If
    End Sub

    Private Sub smnuUnUpdaedBilty_Click(sender As Object, e As EventArgs) Handles smnuUnUpdaedBilty.Click
        If lblAccessType.Text <> "A" Then
            If cnn.GetUserAccess(3, "fldView") = False Then
                cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
                Exit Sub
            End If
        End If
        cnn.ShowForm(frmLeftInvoiceList)
    End Sub

    Private Sub mnuCNSRAdmin_Click(sender As Object, e As EventArgs) Handles mnuCNSRAdmin.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmCNSR)
    End Sub

    Private Sub mnuCNSEAdmin_Click(sender As Object, e As EventArgs) Handles mnuCNSEAdmin.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmCNSE)
    End Sub

    Private Sub mnuTransAdmin_Click(sender As Object, e As EventArgs) Handles mnuTransAdmin.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmTrans)
    End Sub

    Private Sub smnuCNSERate_Click(sender As Object, e As EventArgs) Handles smnuCNSERate.Click
        If lblAccessType.Text <> "A" Then
            Exit Sub
        End If
        cnn.ShowForm(frmCNSERate)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
