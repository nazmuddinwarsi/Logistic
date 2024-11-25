Imports System.Net
Imports System.IO
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Namespace DataConn
    Public Class dbBackup
        Dim cnn As New DataConn.Conn
        Private srvr As Server
#Region "DBBackup"
        Public Function DatabaseBackup() As Boolean
            Try
                Dim strSQL, SRVR_URL, SRVR_UserName, SRVR_Password, DB_Name, DB_SaveName, LCL_SRVR_Name As String
                SRVR_URL = "" : SRVR_UserName = "" : SRVR_Password = "" : DB_Name = "" : DB_SaveName = "" : LCL_SRVR_Name = ""
                strSQL = "Select SRVR_URL, SRVR_UserName, SRVR_Password, DB_Name, DB_SaveName, Local_SRVR_Name from LOG_tblPara Where CompanyID=" & Val(MDI.lblCompanyID.Text) & " AND SessionID=" & Val(MDI.lblSessionID.Text)
                Dim cmd As Data.Odbc.OdbcCommand
                Dim dr As Data.Odbc.OdbcDataReader
                cmd = New Data.Odbc.OdbcCommand(strSQL, cnn.cnn)
                If cmd.Connection.State = 1 Then cmd.Connection.Close()
                cmd.Connection.Open()
                dr = cmd.ExecuteReader
                If dr.Read Then
                    If Not IsDBNull(dr.Item("SRVR_URL")) Then
                        SRVR_URL = cnn.Decrypt(dr.Item("SRVR_URL"))
                    End If
                    If Not IsDBNull(dr.Item("SRVR_UserName")) Then
                        SRVR_UserName = cnn.Decrypt(dr.Item("SRVR_UserName"))
                    End If
                    If Not IsDBNull(dr.Item("SRVR_Password")) Then
                        SRVR_Password = cnn.Decrypt(dr.Item("SRVR_Password"))
                    End If
                    If Not IsDBNull(dr.Item("DB_Name")) Then
                        DB_Name = cnn.Decrypt(dr.Item("DB_Name"))
                    End If
                    If Not IsDBNull(dr.Item("DB_SaveName")) Then
                        DB_SaveName = cnn.Decrypt(dr.Item("DB_SaveName"))
                    End If
                    If Not IsDBNull(dr.Item("Local_SRVR_Name")) Then
                        LCL_SRVR_Name = dr.Item("Local_SRVR_Name")
                    End If
                End If
                'cnn.InfoMsgBox(SRVR_URL)
                'cnn.InfoMsgBox(SRVR_UserName)
                'cnn.InfoMsgBox(SRVR_Password)
                'cnn.InfoMsgBox(DB_Name)
                'cnn.InfoMsgBox(DB_SaveName)
                'cnn.InfoMsgBox(LCL_SRVR_Name)
                cnn.InfoMsgBox("OK1")
                Dim bBool As Boolean = False
                bBool = ServerDetails(SRVR_URL, SRVR_UserName, SRVR_Password, DB_Name, DB_SaveName, LCL_SRVR_Name)
                Return bBool
            Catch ex As Exception
                Return False
            End Try
        End Function
        Private Function ServerDetails(SRVR_URL As String, SRVR_UserName As String, SRVR_Password As String, DB_Name As String, DB_SaveName As String, SRVR_Name As String) As Boolean
            cnn.InfoMsgBox("OK2")
            Try
                Dim bBool As Boolean = True
                '1. FTP Server URL
                '2. FTP User Name
                '3. FTP Password
                '4. Local Server Name
                '5. Local DB Name
                '6. Database Alias Name
                Cursor.Current = Cursors.WaitCursor

                If DB_Name = "" Then
                    cnn.ErrMsgBox("Server Name & Database can not be Blank")
                    Return False
                    Exit Function
                Else
                    cnn.InfoMsgBox("DB OK")
                    Dim now As DateTime = DateTime.Now()
                    Dim FileName As String = DB_SaveName & "_" & now.ToString("dd") & now.ToString("MM") & now.ToString("yyyy") & "_" + now.ToString("HH") & now.ToString("mm") & now.ToString("ss") & ".bak"
                    cnn.InfoMsgBox("OK3")
                    Dim MAINDIR As String = AppDomain.CurrentDomain.BaseDirectory
                    If (Directory.Exists(MAINDIR & "backup")) Then
                        Directory.Delete(MAINDIR & "backup", True)
                    End If

                    Directory.CreateDirectory(MAINDIR & "backup")
                    Dim DBPath As String = MAINDIR & "backup\" & FileName

                    'Me.Cursor = Cursors.WaitCursor
                    Dim bkpDatabase As Backup = New Backup()
                    bkpDatabase.Action = BackupActionType.Database
                    bkpDatabase.Database = DB_Name
                    Dim bkpDevice As BackupDeviceItem = New BackupDeviceItem(DBPath, DeviceType.File)
                    bkpDatabase.Devices.Add(bkpDevice)
                    cnn.InfoMsgBox("OK4")
                    Dim srvConn As ServerConnection = New ServerConnection(SRVR_Name)
                    srvConn.LoginSecure = True
                    srvr = New Server(srvConn)
                    bkpDatabase.SqlBackup(srvr)
                    cnn.InfoMsgBox("OK5")
                    FtpUploadFile(DBPath, SRVR_URL & FileName, SRVR_UserName, SRVR_Password)
                    System.Threading.Thread.Sleep(2000)
                    'Me.Cursor = Cursors.Default

                End If
                Return True
            Catch ex As Exception
                cnn.ErrMsgBox(ex.Message.ToString())
                Cursor.Current = Cursors.Default
                Return False
            End Try
        End Function
        Private Sub FtpUploadFile(ByVal filetoupload As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
            ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.
            Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)
            Try
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
                ' Confirm the Network credentials based on the user name and password passed in.
                ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

                ftpRequest.Timeout = -1
                ftpRequest.ReadWriteTimeout = -1
                ' Read into a Byte array the contents of the file to be uploaded 
                Dim bytes() As Byte = System.IO.File.ReadAllBytes(filetoupload)
                ' Transfer the byte array contents into the request stream, write and then close when done.
                ftpRequest.ContentLength = bytes.Length
                Using UploadStream As Stream = ftpRequest.GetRequestStream()
                    UploadStream.Write(bytes, 0, bytes.Length)
                    UploadStream.Close()
                End Using
                cnn.InfoMsgBox("Bakup successfully created")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End Sub
#End Region
    End Class
End Namespace