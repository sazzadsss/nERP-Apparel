Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Configuration
Imports System.Drawing

Module ResizeImage
    Sub Main()
        Dim photo As Int64
        Dim conntotal As New SqlClient.SqlConnection
        Dim cmdtotal As New SqlClient.SqlCommand
        Dim readertotal As SqlClient.SqlDataReader

        'connection string for the database that contains the images
        conntotal.ConnectionString = My.Settings.KSoft_ApparelConnectionString
        conntotal.Open()

        cmdtotal = conntotal.CreateCommand()

        'query to retrieve the rows from the table that contain images (only the actual column that contains the id is retrieved for all rows that contain a non-empty blob)
        cmdtotal.CommandText = "SELECT StyleId FROM Style WHERE Picture is not null"

        readertotal = cmdtotal.ExecuteReader

        'for each result in the dataset, run the resizer and pass it the id of the specific image
        Do Until readertotal.Read = False
            photo = readertotal.GetInt64(0)
            Resizer(photo)
        Loop

        'dispose of all used objects
        readertotal.Close()
        conntotal.Close()

        cmdtotal.Dispose()
        conntotal.Dispose()

        'Report done when finished
        Console.WriteLine("{0} ", "done...")


    End Sub

    Sub Resizer(ByVal photo As Int64)

        Dim conn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader

        'again the connection string for the database that contains the images 
        conn.ConnectionString = My.Settings.KSoft_ApparelConnectionString
        conn.Open()

        cmd = conn.CreateCommand()

        'query that retrieves a single image on basis of the passed id
        cmd.CommandText = "SELECT Picture FROM Style WHERE StyleId =" & photo

        reader = cmd.ExecuteReader

        If reader.Read Then
            Dim imgByteArray() As Byte

            'try to resize the image, else fail with error and resume to next
            Try
                'read the image as a stream and make a bitmap out of it
                imgByteArray = CType(reader(0), Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                stream.Close()

                'start resizing the retrieved image. First the current dimensions are checked.
                Dim Width As Integer = bmp.Width
                Dim Height As Integer = bmp.Height

                'next we declare the maximum size of the resized image. In this case all resized images need to be constrained to a 173x173 square.
                Dim Heightmax As Integer = 300
                Dim Widthmax As Integer = 300

                'declare the minimum value af the resizing factor before proceeding. All images with a lower factor than this will actually be resized
                Dim Factorlimit As Decimal = 1

                'determine if it is a portrait or landscape image
                Dim Relative As Decimal = Height / Width
                Dim Factor As Decimal

                'if the image is a portrait image, calculate the resizing factor based on its height. 
                'else the image is a landscape image, and we calculate the resizing factor based on its width.
                If Relative > 1 Then

                    If Height < (Heightmax + 1) Then
                        Factor = 1
                    Else
                        Factor = Heightmax / Height
                    End If

                    '
                Else

                    If Width < (Widthmax + 1) Then
                        Factor = 1
                    Else
                        Factor = Widthmax / Width
                    End If

                End If

                'if the resizing factor is lower than the set limit, start processing the image, else proceed to the next image
                If Factor < Factorlimit Then

                    'draw a new image with the dimensions that result from the resizing
                    Dim bmpnew As New Bitmap(bmp.Width * Factor, bmp.Height * Factor, Imaging.PixelFormat.Format24bppRgb)
                    Dim g As Graphics = Graphics.FromImage(bmpnew)

                    g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

                    'and paste the resized image into it
                    g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height)

                    reader.Close()

                    'Now we can sotre the image back into the table
                    Dim cmdstore As SqlClient.SqlCommand
                    cmdstore = conn.CreateCommand()

                    'run an update query to set the image back to its original tabelrow. Effectively reversing the retrieval mechanism, using the image stream as a variable in the query.
                    cmdstore.CommandText = "Update Style SET Picture=@image WHERE StyleId=" & photo

                    Dim streamstore As New MemoryStream

                    bmpnew.Save(streamstore, Imaging.ImageFormat.Jpeg)
                    imgByteArray = streamstore.ToArray()
                    streamstore.Close()

                    cmdstore.Parameters.AddWithValue("@Image", imgByteArray)

                    'Execue the query and report a succes if succeeded, else give the error.
                    If DirectCast(cmdstore.ExecuteNonQuery(), Integer) > 0 Then
                        Console.WriteLine("{0} ", photo & " stored")
                    End If

                End If

                ' if the processing fails, give the id of the image and the error
            Catch ex As Exception
                MessageBox.Show("{0} ", photo & ": " & ex.Message)
            End Try
        End If

        'Close and dispose the objects used. Ready to proceed to the next image.
        reader.Close()
        conn.Close()

        cmd.Dispose()
        conn.Dispose()
    End Sub

    Public Sub AutosizeImage(ByVal ImagePath As String, ByVal picBox As DevExpress.XtraEditors.PictureEdit, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)

        Try
            'picBox.Image = Nothing
            picBox.Properties.SizeMode = pSizeMode
            'If System.IO.File.Exists(ImagePath) Then
            If DBNull.Value.Equals(picBox.Image) = False Then

                Dim imgOrg As Bitmap
                Dim imgShow As Bitmap
                Dim g As Graphics
                Dim divideBy, divideByH, divideByW As Double
                imgOrg = DirectCast(picBox.Image, Bitmap)

                divideByW = imgOrg.Width / picBox.Width
                divideByH = imgOrg.Height / picBox.Height
                If divideByW > 1 Or divideByH > 1 Then
                    If divideByW > divideByH Then
                        divideBy = divideByW
                    Else
                        divideBy = divideByH
                    End If

                    imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                Else
                    imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                End If
                imgOrg.Dispose()

                picBox.Image = imgShow
            Else
                picBox.Image = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Module
