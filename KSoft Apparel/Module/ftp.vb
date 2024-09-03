Imports System.Net
Imports System.IO

Class ftp
    Private host As String = Nothing
    Private user As String = Nothing
    Private pass As String = Nothing
    Private ftpRequest As FtpWebRequest = Nothing
    Private ftpResponse As FtpWebResponse = Nothing
    Private ftpStream As Stream = Nothing
    Private bufferSize As Integer = 2048

    ' Construct Object 

    Public Sub New(ByVal hostIP As String, ByVal userName As String, ByVal password As String)
        host = hostIP
        user = userName
        pass = password
    End Sub

    ' Download File 

    Public Sub download(ByVal remoteFile As String, ByVal localFile As String)
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & remoteFile), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Get the FTP Server's Response Stream 

            ftpStream = ftpResponse.GetResponseStream()
            ' Open a File Stream to Write the Downloaded File 

            Dim localFileStream As New FileStream(localFile, FileMode.Create)
            ' Buffer for the Downloaded Data 

            Dim byteBuffer As Byte() = New Byte(bufferSize - 1) {}
            Dim bytesRead As Integer = ftpStream.Read(byteBuffer, 0, bufferSize)
            ' Download the File by Writing the Buffered Data Until the Transfer is Complete 

            Try
                While bytesRead > 0
                    localFileStream.Write(byteBuffer, 0, bytesRead)
                    bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize)
                End While
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            localFileStream.Close()
            ftpStream.Close()
            ftpResponse.Close()
            ftpRequest = Nothing

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return
    End Sub

    ' Upload File 

    Public Sub upload(ByVal remoteFile As String, ByVal localFile As String)
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & remoteFile), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
            ' Establish Return Communication with the FTP Server 

            ftpStream = ftpRequest.GetRequestStream()
            ' Open a File Stream to Read the File for Upload 

            Dim localFileStream As New FileStream(localFile, FileMode.Open)
            ' Buffer for the Downloaded Data 

            Dim byteBuffer As Byte() = New Byte(bufferSize - 1) {}
            Dim bytesSent As Integer = localFileStream.Read(byteBuffer, 0, bufferSize)
            ' Upload the File by Sending the Buffered Data Until the Transfer is Complete 

            Try
                While bytesSent <> 0
                    ftpStream.Write(byteBuffer, 0, bytesSent)
                    bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize)
                End While
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            localFileStream.Close()
            ftpStream.Close()
            ftpRequest = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return

    End Sub

    ' Delete File 

    Public Sub delete(ByVal deleteFile As String)
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(WebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & deleteFile), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Resource Cleanup 

            ftpResponse.Close()
            ftpRequest = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return
    End Sub

    ' Rename File 

    Public Sub rename(ByVal currentFileNameAndPath As String, ByVal newFileName As String)
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(WebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & currentFileNameAndPath), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.Rename
            ' Rename the File 

            ftpRequest.RenameTo = newFileName
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Resource Cleanup 

            ftpResponse.Close()
            ftpRequest = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return
    End Sub

    ' Create a New Directory on the FTP Server 

    Public Sub createDirectory(ByVal newDirectory As String)
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(WebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & newDirectory), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Resource Cleanup 

            ftpResponse.Close()
            ftpRequest = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return
    End Sub

    ' Get the Date/Time a File was Created 

    Public Function getFileCreatedDateTime(ByVal fileName As String) As String
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & fileName), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.GetDateTimestamp
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Establish Return Communication with the FTP Server 

            ftpStream = ftpResponse.GetResponseStream()
            ' Get the FTP Server's Response Stream 

            Dim ftpReader As New StreamReader(ftpStream)
            ' Store the Raw Response 

            Dim fileInfo As String = Nothing
            ' Read the Full Response Stream 

            Try
                fileInfo = ftpReader.ReadToEnd()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            ftpReader.Close()
            ftpStream.Close()
            ftpResponse.Close()
            ftpRequest = Nothing
            ' Return File Created Date Time 

            Return fileInfo
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        ' Return an Empty string Array if an Exception Occurs 

        Return ""
    End Function

    ' Get the Size of a File 

    Public Function getFileSize(ByVal fileName As String) As String
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & fileName), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.GetFileSize
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Establish Return Communication with the FTP Server 

            ftpStream = ftpResponse.GetResponseStream()
            ' Get the FTP Server's Response Stream 

            Dim ftpReader As New StreamReader(ftpStream)
            ' Store the Raw Response 

            Dim fileInfo As String = Nothing
            ' Read the Full Response Stream 

            Try
                While ftpReader.Peek() <> -1
                    fileInfo = ftpReader.ReadToEnd()
                End While
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            ftpReader.Close()
            ftpStream.Close()
            ftpResponse.Close()
            ftpRequest = Nothing
            ' Return File Size 

            Return fileInfo
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        ' Return an Empty string Array if an Exception Occurs 

        Return ""
    End Function

    ' List Directory Contents File/Folder Name Only 

    Public Function directoryListSimple(ByVal directory As String) As String()
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & directory), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Establish Return Communication with the FTP Server 

            ftpStream = ftpResponse.GetResponseStream()
            ' Get the FTP Server's Response Stream 

            Dim ftpReader As New StreamReader(ftpStream)
            ' Store the Raw Response 

            Dim directoryRaw As String = Nothing
            ' Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing 

            Try
                While ftpReader.Peek() <> -1
                    directoryRaw += ftpReader.ReadLine() + "|"
                End While
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            ftpReader.Close()
            ftpStream.Close()
            ftpResponse.Close()
            ftpRequest = Nothing
            ' Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) 

            Try
                Dim directoryList As String() = directoryRaw.Split("|".ToCharArray())
                Return directoryList
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        ' Return an Empty string Array if an Exception Occurs 

        Return New String() {""}
    End Function

    ' List Directory Contents in Detail (Name, Size, Created, etc.) 

    Public Function directoryListDetailed(ByVal directory As String) As String()
        Try
            ' Create an FTP Request 

            ftpRequest = DirectCast(FtpWebRequest.Create(Convert.ToString(host & Convert.ToString("/")) & directory), FtpWebRequest)
            ' Log in to the FTP Server with the User Name and Password Provided 

            ftpRequest.Credentials = New NetworkCredential(user, pass)
            ' When in doubt, use these options 

            ftpRequest.UseBinary = True
            ftpRequest.UsePassive = True
            ftpRequest.KeepAlive = True
            ' Specify the Type of FTP Request 

            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            ' Establish Return Communication with the FTP Server 

            ftpResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
            ' Establish Return Communication with the FTP Server 

            ftpStream = ftpResponse.GetResponseStream()
            ' Get the FTP Server's Response Stream 

            Dim ftpReader As New StreamReader(ftpStream)
            ' Store the Raw Response 

            Dim directoryRaw As String = Nothing
            ' Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing 

            Try
                While ftpReader.Peek() <> -1
                    directoryRaw += ftpReader.ReadLine() + "|"
                End While
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            ' Resource Cleanup 

            ftpReader.Close()
            ftpStream.Close()
            ftpResponse.Close()
            ftpRequest = Nothing
            ' Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) 

            Try
                Dim directoryList As String() = directoryRaw.Split("|".ToCharArray())
                Return directoryList
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        ' Return an Empty string Array if an Exception Occurs 

        Return New String() {""}
    End Function

    '====================== Example ===============================================

    '    ' Create Object Instance 

    '    Dim ftpClient As New ftp("ftp://10.10.10.10/", "user", "password")

    '    ' Upload a File 

    'ftpClient.upload("etc/test.txt", "C:\Users\metastruct\Desktop\test.txt")

    '    ' Download a File 

    'ftpClient.download("etc/test.txt", "C:\Users\metastruct\Desktop\test.txt")

    '    ' Delete a File 

    'ftpClient.delete("etc/test.txt")

    '    ' Rename a File 

    'ftpClient.rename("etc/test.txt", "test2.txt")

    '    ' Create a New Directory 

    'ftpClient.createDirectory("etc/test")

    '    ' Get the Date/Time a File was Created 

    '    Dim fileDateTime As String = ftpClient.getFileCreatedDateTime("etc/test.txt")
    'Console.WriteLine(fileDateTime)

    '    ' Get the Size of a File 

    '    Dim fileSize As String = ftpClient.getFileSize("etc/test.txt")
    'Console.WriteLine(fileSize)

    '    ' Get Contents of a Directory (Names Only) 

    '    Dim simpleDirectoryListing As String() = ftpClient.directoryListDetailed("/etc")
    'For i As Integer = 0 To simpleDirectoryListing.Count() - 1
    '	Console.WriteLine(simpleDirectoryListing(i))
    'Next

    '    ' Get Contents of a Directory with Detailed File/Directory Info 

    '    Dim detailDirectoryListing As String() = ftpClient.directoryListDetailed("/etc")
    'For i As Integer = 0 To detailDirectoryListing.Count() - 1
    '	Console.WriteLine(detailDirectoryListing(i))
    'Next
    '    ' Release Resources 

    'ftpClient = Nothing





End Class


