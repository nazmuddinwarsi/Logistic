Imports System
Imports System.Data
Imports System.Drawing
Imports System.Data.Odbc
Public Class frmDoctorList
    Dim cnn As New DataConn.Conn

    Private Sub frmDoctorList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        ElseIf e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
    Private Sub frmDoctorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        '---------------------------
        Dim strSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet

        strSQL = "Select ID, fldName from tblMaster Where tType='DEPT' Order BY fldName ASC"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        cmbDept.DisplayMember = "fldName"
        cmbDept.ValueMember = "ID"
        cmbDept.DataSource = ds.Tables(0)
        cmbDept.SelectedIndex = -1
        ds = Nothing
        da = Nothing
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim strSQL, sSQL As String
        Dim da As New OdbcDataAdapter
        Dim ds As New DataSet
        sSQL = ""
        strSQL = "SELECT dbo.tblDoctor.ID, dbo.tblMaster.fldName, dbo.tblDoctor.DoctorName, dbo.tblDoctor.Degree, dbo.tblDoctor.MobileNo, dbo.tblDoctor.EmailID, dbo.tblDoctor.Gender, dbo.tblDoctor.Address, dbo.tblDoctor.City" _
        & " FROM dbo.tblDoctor INNER JOIN dbo.tblMaster ON dbo.tblDoctor.DeptID = dbo.tblMaster.ID ORDER BY dbo.tblMaster.fldName, dbo.tblDoctor.DoctorName"
        da = New OdbcDataAdapter(strSQL, cnn.cnn)
        ds = New DataSet()
        da.Fill(ds)
        Grid.DataSource = ds.Tables(0)
        Grid.Columns(0).HeaderText = "ID"
        Grid.Columns(0).Visible = False
        Grid.Columns(1).HeaderText = "Department Name"
        Grid.Columns(2).HeaderText = "Doctor Name"
        Grid.Columns(3).HeaderText = "Degree"
        Grid.Columns(4).HeaderText = "Mobile No"
        Grid.Columns(5).HeaderText = "Email ID"
        Grid.Columns(6).HeaderText = "Gender"
        Grid.Columns(7).HeaderText = "Address"
        Grid.Columns(8).HeaderText = "City"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frameSearch.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            cnn.ErrMsgBox("Please Enter Doctor Name  !")
            txtName.Focus()
            Exit Sub
        End If
        Dim strSQL, iSex As String
        If rbMale.Checked = True Then
            iSex = "M"
        Else
            iSex = "F"
        End If
        If lblID.Text <> "" Then
            strSQL = "UPDATE tblDoctor SET DeptID=" & Val(cmbDept.SelectedValue) & ", DoctorName=" & cnn.SQLquote(txtName.Text) & ", Degree=" & cnn.SQLquote(txtDegree.Text) _
            & ", MobileNo=" & cnn.SQLquote(txtMobileNo.Text) & ", EmailID=" & cnn.SQLquote(txtEmailID.Text) & ", Gender='" & iSex & "', Address=" & cnn.SQLquote(txtAddress.Text) _
            & ", City=" & cnn.SQLquote(txtCity.Text) & " WHERE ID=" & Val(lblID.Text)
        Else
            strSQL = "INSERT INTO tblDoctor (DeptID, DoctorName, Degree, MobileNo, EmailID, Gender, Address, City) VALUES (" _
            & Val(cmbDept.SelectedValue) & "," & cnn.SQLquote(txtName.Text) & "," & cnn.SQLquote(txtDegree.Text) & "," & cnn.SQLquote(txtMobileNo.Text) _
            & "," & cnn.SQLquote(txtEmailID.Text) & ",'" & iSex & "'," & cnn.SQLquote(txtAddress.Text) & "," & cnn.SQLquote(txtCity.Text) & ")"
        End If
        cnn.executeSQL(strSQL)
        If lblID.Text <> "" Then
            cnn.InfoMsgBox("Record has been Updated Successfully  !")
        Else
            cnn.InfoMsgBox("Record has been Added Successfully  !")
        End If
        txtName.Text = "" : cmbDept.SelectedIndex = -1 : txtDegree.Text = "" : txtMobileNo.Text = "" : txtEmailID.Text = "" : txtAddress.Text = "" : txtCity.Text = ""
        rbMale.Checked = True : lblID.Text = "" : BindGrid() ' : frameSearch.Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If MDI.lblAccessType.Text <> "A" Then
        '    If cnn.GetUserAccess(2, "fldAdd") = False Then
        '        cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
        '        Exit Sub
        '    End If
        'End If
        frameSearch.Visible = True : txtName.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        
        EditRecord()
    End Sub
    Private Sub EditRecord()
        'If MDI.lblAccessType.Text <> "A" Then
        '    If cnn.GetUserAccess(2, "fldEdit") = False Then
        '        cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
        '        Exit Sub
        '    End If
        'End If
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Modify  !")
            Exit Sub
        End If
        '--------------------
        Dim strSQL As String
        strSQL = "SELECT * FROM tblDoctor Where ID = " & Val(lblID.Text)
        Dim cmd As Data.Odbc.OdbcCommand
        Dim dr As Data.Odbc.OdbcDataReader
        cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
        If cmd.Connection.State = 1 Then cmd.Connection.Close()
        cmd.Connection.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            If Not IsDBNull(dr.Item("DeptID")) Then
                cmbDept.SelectedValue = dr.Item("DeptID")
            End If
            If Not IsDBNull(dr.Item("DoctorName")) Then
                txtName.Text = dr.Item("DoctorName")
            End If
            If Not IsDBNull(dr.Item("Degree")) Then
                txtDegree.Text = dr.Item("Degree")
            End If
            If Not IsDBNull(dr.Item("MobileNo")) Then
                txtMobileNo.Text = dr.Item("MobileNo")
            End If
            If Not IsDBNull(dr.Item("EmailID")) Then
                txtEmailID.Text = dr.Item("EmailID")
            End If
            If Not IsDBNull(dr.Item("Gender")) Then
                If dr.Item("Gender") = "M" Then
                    rbMale.Checked = True
                Else
                    rbFemale.Checked = True
                End If
            End If
            If Not IsDBNull(dr.Item("Address")) Then
                txtAddress.Text = dr.Item("Address")
            End If
            If Not IsDBNull(dr.Item("City")) Then
                txtCity.Text = dr.Item("City")
            End If
            dr.Close()
            cmd.Connection.Close()
            frameSearch.Visible = True : cmbDept.Focus()

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        'If MDI.lblAccessType.Text <> "A" Then
        '    If cnn.GetUserAccess(2, "fldDelete") = False Then
        '        cnn.ErrMsgBox("You are not Authorised to do this Operation  !")
        '        Exit Sub
        '    End If
        'End If
        If lblID.Text = "" Then
            cnn.ErrMsgBox("Please Select Record to Delete  !")
            Exit Sub
        End If
        '------------------
        Dim strSQL As String
        strSQL = "Select ID from tblPatient Where DocID=" & Val(lblID.Text)
        If cnn.CheckDuplicate(strSQL) = True Then
            cnn.ErrMsgBox("You can't delete this record  !")
            Exit Sub
        End If
        strSQL = "DELETE From tblDoctor WHere ID=" & Val(lblID.Text)
        cnn.executeSQL(strSQL)
        cnn.InfoMsgBox("Record has been Deleted  !")
        BindGrid()
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

    Private Sub frmDoctorList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        FormRes()
    End Sub
    Private Sub FormRes()
        Grid.Width = MDI.ClientSize.Width - (MDI.Panel.Width)
        Grid.Height = Me.Height - 37
        StripPanel.Width = Me.Width
    End Sub
End Class