Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class frmUsers
    Dim cnn As New DataConn.Conn
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        strSQL = "SELECT UserID, fldName, fldUserName, AccessType, Active FROM LOG_tblUsers ORDER BY fldName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Name"
        Grid.Columns(2).HeaderText = "User Name"
        Grid.Columns(3).HeaderText = "Access Type"
        Grid.Columns(4).HeaderText = "Active"

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Name  !")
            txtName.Focus()
            Exit Sub
        End If
        If txtUserName.Text = "" Then
            cnn.ErrMsgBox("Please Enter User Name  !")
            txtUserName.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            cnn.ErrMsgBox("Please Enter Password  !")
            txtPassword.Focus()
            Exit Sub
        End If
        If cmbAccess.Text = "ADMIN" Or cmbAccess.Text = "USER" Then
        Else
            cnn.ErrMsgBox("Please Select Access Type from List...!")
            cmbAccess.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        Dim iAccess, iAct As String
        If cmbAccess.Text = "ADMIN" Then
            iAccess = "A"
        Else
            iAccess = "U"
        End If
        If chkActive.Checked = True Then
            iAct = "Y"
        Else
            iAct = "N"
        End If
        If lblID.Text <> "" Then
            strSQL = "UPDATE LOG_tblUsers SET fldName=" & cnn.SQLquote(txtName.Text) & ", fldUserName=" & cnn.SQLquote(txtUserName.Text) _
            & ", fldPassword=" & cnn.SQLquote(txtPassword.Text) & ", AccessType=" & cnn.SQLquote(iAccess) & ", Active='" & iAct & "', EditedBy = " & Val(MDI.lblUserLoginID.Text) & ", EditedDate='" & cnn.GetDate(Date.Today()) & "' WHERE UserID=" & Val(lblID.Text)
        Else
            strSQL = "INSERT INTO LOG_tblUsers (fldName, fldUserName, fldPassword, AccessType, Active, CreatedBy, CreatedDate) VALUES (" & cnn.SQLquote(txtName.Text) _
            & "," & cnn.SQLquote(txtUserName.Text) & "," & cnn.SQLquote(txtPassword.Text) & "," & cnn.SQLquote(iAccess) & ",'" & iAct & "'," & Val(MDI.lblUserLoginID.Text) & ",'" & cnn.GetDate(Date.Today()) & "')"
        End If
        cnn.executeSQL(strSQL)
        If lblID.Text <> "" Then
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
        Else
            cnn.InfoMsgBox("Record has been Added Successfully  !")
        End If
        txtName.Text = "" : lblID.Text = "" : txtUserName.Text = "" : txtPassword.Text = "" : cmbAccess.Text = ""
        frameSearch.Visible = False : BindGrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frameSearch.Visible = True : txtName.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditRecord()
    End Sub
    Private Sub EditRecord()
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        '--------------------
        Dim strSQL As String
        strSQL = "SELECT * FROM LOG_tblUsers Where UserID = " & Val(lblID.Text)
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
            If Not IsDBNull(dr.Item("fldUserName")) Then
                txtUserName.Text = dr.Item("fldUserName")
            End If
            If Not IsDBNull(dr.Item("fldpassword")) Then
                txtPassword.Text = dr.Item("fldpassword")
            End If
            If Not IsDBNull(dr.Item("AccessType")) Then
                If dr.Item("AccessType") = "A" Then
                    cmbAccess.Text = "ADMIN"
                Else
                    cmbAccess.Text = "USER"
                End If
            End If
            If Not IsDBNull(dr.Item("Active")) Then
                If dr.Item("Active") = "Y" Then
                    chkActive.Checked = True
                Else
                    chkActive.Checked = False
                End If
            End If
            dr.Close()
            cmd.Connection.Close()
            frameSearch.Visible = True : txtName.Focus()
        End If
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
    Private Sub Grid_CursorChanged(sender As Object, e As EventArgs) Handles Grid.CursorChanged

    End Sub

    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
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
End Class