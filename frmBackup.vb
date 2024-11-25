Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBackup
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Dim db As New DataConn.dbBackup
    Dim cnn As New DataConn.Conn
    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        Try
            db.DatabaseBackup()
        Catch ex As Exception
            cnn.ErrMsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GetServerList()
    End Sub
    Private Sub GetServerList()
        Try


            Dim Server As String = String.Empty
            Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
            Dim table As System.Data.DataTable = instance.GetDataSources()

            For Each row As System.Data.DataRow In table.Rows
                Server = String.Empty
                Server = row("ServerName")
                If row("InstanceName").ToString.Length > 0 Then
                    Server = Server & "\" & row("InstanceName")
                End If
                cmbserver.Items.Add(Server)
            Next
            cmbserver.SelectedIndex = cmbserver.FindStringExact(Environment.MachineName)
        Catch ex As Exception
            cnn.ErrMsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub cmbserver_LostFocus(sender As Object, e As EventArgs) Handles cmbserver.LostFocus
        connection()
    End Sub

    Private Sub cmbserver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbserver.SelectedIndexChanged

    End Sub
    Sub connection()
        'Try
        con = New SqlConnection("Data Source=" & Trim(cmbserver.Text) & ";Database=Master;integrated security=SSPI;")
        con.Open()
        cmbdatabase.Items.Clear()
        cmd = New SqlCommand("select * from sysdatabases", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbdatabase.Items.Add(dread(0))
        End While
        dread.Close()
        'Catch ex As Exception
        '    MessageBox.Show("Error : " & ex.Message)
        'End Try
    End Sub
    Sub query(ByVal que As String)
        Try
            'On Error Resume Next
            cmd = New SqlCommand(que, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("Successfully Done")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub
    Sub blank(ByVal str As String)
        If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
            MsgBox("Server Name & Database Blank Field")
            Exit Sub
        Else
            'Try
            If str = "backup" Then
                SaveFileDialog1.FileName = cmbdatabase.Text
                SaveFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                Dim s As String
                s = SaveFileDialog1.FileName
                query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")
            ElseIf str = "restore" Then
                OpenFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
            End If
            'Catch ex As Exception
            '    MessageBox.Show("Error" & ex.Message)
            'End Try

        End If
    End Sub

    Private Sub cmbbackup_Click(sender As Object, e As EventArgs) Handles cmbbackup.Click
        blank("backup")
    End Sub

    Private Sub cmdrestore_Click(sender As Object, e As EventArgs) Handles cmdrestore.Click
        blank("restore")
    End Sub

    Private Sub cmbserver_TextChanged(sender As Object, e As EventArgs) Handles cmbserver.TextChanged
        connection()
    End Sub
End Class