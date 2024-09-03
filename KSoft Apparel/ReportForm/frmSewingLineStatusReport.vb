Imports System.Data.SqlClient
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSplashScreen


Public Class frmSewingLineStatusReport

    Dim ColorLine() As Integer
    Dim A As Integer
    Dim SewingDate As DateTime
    Dim Unit As Integer = 0
    'Make sure you put a space " " at the end of your string.
    Dim scrolledString As String = "NORBAN COMTEX LIMITED : {0} "
    Dim myStrings(scrolledString.Length - 1) As String
    Dim position As Integer = -1
    Dim FontSize As Integer = 15
    Dim UnitFlag As String = "All"
    Dim ScrollFlag As Boolean = False
    Dim RowHeight As Integer = 0
    Private Sub frmSewingLineStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LineDataSet.Line' table. You can move, or remove it, as needed.
        Me.LineTableAdapter.FillByPlanning(Me.LineDataSet.Line)

        Me.SewingLineStatusNewTableAdapter.Fill(Me.SewingLineStatusDataSet.SewingLineStatusNew)
        Me.SewingDateDateEdit.EditValue = Today
        Timer1.Start()
        ClockLabel.Text = TimeOfDay

        'Scrolling Text
        Dim labelSize As Size
        labelSize.Width = 1300
        labelSize.Height = 52
        'UnitLabel.MinimumSize = labelSize
        UnitLabel.MaximumSize = labelSize
        UnitLabel.Size = labelSize

        'Make this value smaller say as low as 25 for
        'a faster scroll effect.

        Timer2.Interval = 50

        Timer2.Enabled = True
        Timer2.Start()
        Timer3.Interval = 50
        Timer3.Enabled = True
        Timer3.Stop()
        SpinEdit1.Value = 30

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle

        Dim View As GridView = sender
        Dim OpenLine As Boolean = True
        Dim prevalue As Integer = 0

        For i As Integer = 1 To 12

            Dim Tr As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TargetPerHour"))
            Dim LineName As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Line"))
            Dim check As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("NL"))

            If check = "" Then
                check = 0
            End If

            Dim Targets As Integer

            If Tr = "" Then
                Targets = Nothing
            Else
                Targets = System.Convert.ToInt64(Tr)
            End If

            Dim ColName As String = "H" + System.Convert.ToString(i)

            Dim ColV As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns(ColName))

            Dim ColValue As Integer
            If ColV = "" Then
                ColValue = Nothing
            Else
                ColValue = System.Convert.ToInt64(ColV)
                prevalue = prevalue + ColValue
            End If

            If (Targets = Nothing OrElse Targets = 0) AndAlso (LineName <> "Others") Then

                If (LineName <> "Training") Then
                    e.Appearance.ForeColor = Color.DimGray
                End If

            Else
                If e.Column.FieldName = ColName Then

                    If ColValue = Nothing Then

                        If System.Convert.ToInt32(check) = 1 AndAlso prevalue = 0 Then

                            e.Appearance.BackColor = Color.Yellow
                            e.Appearance.BackColor2 = Color.Yellow

                        Else


                            e.Appearance.BackColor = Color.DimGray
                            e.Appearance.BackColor2 = Color.DimGray


                        End If


                            ElseIf ColValue = Targets Then


                        e.Appearance.BackColor = Color.Green
                        e.Appearance.BackColor2 = Color.Green


                    ElseIf ColValue > Targets Then

                        e.Appearance.BackColor = Color.RoyalBlue
                        e.Appearance.BackColor2 = Color.RoyalBlue


                    ElseIf ColValue < Targets Then

                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red

                    End If

                End If

            End If


            'For A = 0 To ColorLine.Count - 1 Step +1
            '    If ColValue > 0 Then
            '        OpenLine = False
            '    End If
            '    If (e.RowHandle = ColorLine(A)) And e.Column.FieldName = ColName And OpenLine = True Then
            '        e.Appearance.BackColor = Color.Yellow
            '        e.Appearance.BackColor2 = Color.Yellow
            '    End If
            'Next


        Next

    End Sub

    Private Sub ShowLine(ByVal BranchId As Integer, ByVal MFlag As Boolean)

        SewingDate = SewingDateDateEdit.EditValue
        ColorLine = {1000}
        A = 0
        On Error Resume Next
        For i As Integer = Me.GridView1.RowCount - 1 To 0 Step -1
            Me.GridView1.DeleteRow(i)
        Next
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String

        If BranchId > 0 Then
            sqlstring = "Select * From Line where Planning=1 And BranchId=" & BranchId
        Else
            If MFlag = True Then
                Dim LineString As String = CheckedComboBoxEdit1.Text

                Dim LineString1 As String = LineString.Replace(", ", "','") 'You should use one space after first comma
                LineString1 = Trim(LineString1)
                sqlstring = "Select * From Line where Planning=1 And Line in ('" & LineString1 & "')"
            Else
                sqlstring = "Select * From Line where Planning=1"
            End If

        End If

        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim LineId As Integer = reader("LineId")

            If LineId = ReadIntegerData("Select LineId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId, cnn) Then
                SewingProduction(LineId)
            Else
                Dim newRow = CType(Me.SewingLineStatusDataSet.SewingLineStatusNew.NewRow(), SewingLineStatusDataSet.SewingLineStatusNewRow)
                newRow.LineId = LineId
                newRow.Line = reader("Line").ToString
                newRow.Present_Operator = ReadIntData("Select Present_Operator From SewingAttendance Where AttendanceDate='" & SewingDate & "' And LineId=" & LineId, cnn)
                newRow.Present_Helper = ReadIntData("Select Present_Helper From SewingAttendance Where AttendanceDate='" & SewingDate & "' And LineId=" & LineId, cnn)
                Me.SewingLineStatusDataSet.SewingLineStatusNew.Rows.Add(newRow)
            End If
        End While

        reader.Close()
        connection.Close()
        LastRefreshLabel.Text = TimeOfDay

    End Sub

    Private Sub SewingProduction(ByVal LineId As Integer)

        On Error Resume Next

        Dim connection As New SqlConnection(cnn)
        connection.Open()

        Dim cmd As SqlCommand = New SqlCommand("Select LineId,SewingDate,SewingLayoutId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & "Group by SewingDate,LineId,SewingLayoutId ", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim newRow = CType(Me.SewingLineStatusDataSet.SewingLineStatusNew.NewRow(), SewingLineStatusDataSet.SewingLineStatusNewRow)
            newRow.LineId = LineId
            newRow.Line = ReadStringData("Select Line From Line Where LineId =" & LineId, cnn)
            newRow.SewingLayoutId = reader("SewingLayoutId")
            newRow.SewingDate = reader("SewingDate").ToString
            newRow.TargetPerHour = ReadData("Select Top 1 TargetsPerHour from SewingLayout Where LayoutId =" & reader("SewingLayoutId"), cnn)
            newRow.H1 = ReadData("Select SUM(h1) AS h1 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H2 = ReadData("Select SUM(h2) As h2 from SewingHourlyProduction Where SewingId In ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H3 = ReadData("Select SUM(h3) AS h3 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H4 = ReadData("Select SUM(h4) AS h4 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H5 = ReadData("Select SUM(h5) AS h5 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H6 = ReadData("Select SUM(h6) AS h6 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H7 = ReadData("Select SUM(h7) AS h7 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H8 = ReadData("Select SUM(h8) AS h8 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H9 = ReadData("Select SUM(h9) AS h9 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H10 = ReadData("Select SUM(h10) AS h10 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H11 = ReadData("Select SUM(h11) AS h11 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.H12 = ReadData("Select SUM(h12) AS h12 from SewingHourlyProduction Where SewingId in ( Select SewingId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & LineId & " And  SewingLayoutId =" & reader("SewingLayoutId") & ")", cnn)
            newRow.Present_Operator = ReadIntData("Select Present_Operator From SewingAttendance Where AttendanceDate='" & SewingDate & "' And LineId=" & LineId, cnn)
            newRow.Present_Helper = ReadIntData("Select Present_Helper From SewingAttendance Where AttendanceDate='" & SewingDate & "' And LineId=" & LineId, cnn)

            Debug.Print(newRow.Line.ToString() & ":" & newRow.Present_Operator.ToString())
            newRow.MCUsage = ReadData("Select TTLMC From SewingAttendanceSummery Where AttendanceDate='" & SewingDate & "' And LineId=" & LineId, cnn)



            Dim LastProductionDate As Date = ReadDateData("Select Max(SewingDate) from SewingProduction Where SewingDate < '" & reader("SewingDate") & "'", cnn)
            Dim NewLayout As Integer = ReadIntegerData("Select StyleId from SewingLayout Where LayoutId =" & reader("SewingLayoutId"), cnn)
            Dim CheckLayout As Integer = ReadIntegerData("Select StyleId from SewingLayout Where LayoutId = (Select Max(SewingLayoutId) As LayoutId From SewingProduction Where  SewingDate = '" & LastProductionDate & "' And LineId = " & LineId & " And SewingLayoutId= " & reader("SewingLayoutId") & ")", cnn)

            'MessageBox.Show("NewLayout : " & NewLayout.ToString & "::" & "CheckLayout:" & CheckLayout.ToString() & " LastProductionDate : " & LastProductionDate.ToString())

            If NewLayout > 0 AndAlso CheckLayout = 0 AndAlso reader("TargetsPerHour") > 0 Then

                ColorLine = ColorLine.Concat({LineId - 1}).ToArray
                'ColorLine(A) = LineId - 1
                A = A + 1
                newRow.NL = 1

            End If

            'Dim LastSewingDate As DateTime = ReadDateData("Select Max(SewingDate) from SewingProduction Where SewingLayoutId =" & reader("SewingLayoutId"), cnn)
            'Dim LastProductionDate As DateTime = ReadDateData("Select Max(SewingDate) from SewingProduction Where SewingDate < " & reader("SewingDate"), cnn)


            'Dim CurrentStyle As Integer = ReadIntegerData("Select StyleId from SewingLayout Where LayoutId =" & reader("SewingLayoutId"), cnn)

            'Dim LastDayLayout As Integer = ReadIntegerData("Select MaxSewingLayoutId From SewingProduction Where SewingDate=" & LastProductionDate & "And SewingLayoutId in ( Select LayoutId From SewingLayout Where StyleId=" & CurrentStyle & ")", cnn)


            ''If CheckLayout <> 0 And NewLayout <> CheckLayout Then
            ''    ColorLine = ColorLine.Concat({LineId - 1}).ToArray
            ''    'ColorLine(A) = LineId - 1
            ''    A = A + 1
            ''End If

            ''If CheckLastDayLayout <> 0 And NewLayout <> CheckLastDayLayout Then
            ''    ColorLine = ColorLine.Concat({LineId - 1}).ToArray
            ''    'ColorLine(A) = LineId - 1
            ''    A = A + 1
            ''    newRow.ISNL = True
            ''Else
            ''    newRow.ISNL = False
            ''End If

            ''If CheckLastDayLayout = 0 And NewLayout <> CheckLastDayLayout Then

            ''    newRow.ISNL = True
            ''Else
            ''    newRow.ISNL = False

            ''End If

            ''If LastSewingDate = reader("SewingDate") Then
            ''    newRow.ISNL = True
            ''Else
            ''    newRow.ISNL = False
            ''End If

            'If LastDayLayout = 0 Then
            '    newRow.ISNL = True
            'Else
            '    newRow.ISNL = True
            'End If


            Me.SewingLineStatusDataSet.SewingLineStatusNew.Rows.Add(newRow)

        End While

        reader.Close()
        connection.Close()

    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click

        ' Create a PrintingSystem component. 
        Dim ps As New DevExpress.XtraPrinting.PrintingSystem()

        ' Create a link that will print a control. 
        Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)

        ' Specify the control to be printed. 
        link.Component = GridControl1

        ' Generate a report. 
        link.CreateDocument()

        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Sewing Line Status"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                link.PrintingSystem.ExportToXlsx(objSaveFileDialog.FileName)
                'GridControl1.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If


        Dim process As New System.Diagnostics.Process()
        process.StartInfo.FileName = objSaveFileDialog.FileName
        process.Start()


        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing



        '' Export a report to a PDF file. 
        'Dim filePath As String = "e:\gridcontrol.xlsx"


        ' Use the code below if you want the created file to be automatically 
        ' opened in the appropriate application. 


    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 0
        UnitFlag = "All"
        UnitLabel.Text = System.String.Format(scrolledString, "ALL")
        ShowLine(0, False)
        FormatGridNormal()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

        Dim ProgramNo As String = String.Empty
        Dim BuyerName As String = String.Empty
        Dim StyleName As String = String.Empty
        Dim ColorName As String = String.Empty

        Dim row As SewingLineStatusDataSet.SewingLineStatusNewRow
        row = CType(CType(Me.SewingLineStatusNewBindingSource.Current, DataRowView).Row, SewingLineStatusDataSet.SewingLineStatusNewRow)

        On Error Resume Next

        Dim connection As New SqlConnection(cnn)
        connection.Open()

        Dim OrderId As Integer = ReadIntegerData("Select Distinct OrderId From SewingProduction Where SewingDate = '" & row.SewingDate & "' And LineId =" & row.LineId & " And SewingLayoutId = " & row.SewingLayoutId, cnn)
        'MessageBox.Show(row.SewingDate.ToString() & "::" & row.LineId.ToString() & "::" & row.SewingLayoutId.ToString())
        'Dim OrderDetailsId As Integer = ReadIntegerData("Select OrderDetailsId From SewingProduction Where SewingDate = '" & SewingDate & "' And LineId =" & row.LineId & "And SewingLayoutId = " & row.SewingLayoutId, cnn)
        Dim cmd As SqlCommand = New SqlCommand("Select ProgramNo,BuyerName,StyleName,FabricColorName From vOrder Where OrderId= " & OrderId, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()


        While reader.Read()

            ProgramNo = reader("ProgramNo")
            BuyerName = reader("BuyerName")
            StyleName = reader("StyleName")

            If ColorName = String.Empty Then
                ColorName = reader("FabricColorName")
            Else
                ColorName = ColorName & "," & reader("FabricColorName")
            End If

        End While

        MessageBox.Show("BuyerName : " + BuyerName & vbNewLine & "Program No : " + ProgramNo & vbNewLine & "StyleName : " + StyleName & vbNewLine & "Color : " + ColorName, "")

        reader.Close()
        connection.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ClockLabel.Text = TimeOfDay

        Static mCount As Long
        mCount = mCount + 1

        If mCount >= SpinEdit1.Value * 60 Then
            SewingDateDateEdit.Text = Today()

            Select Case UnitFlag
                Case "All"
                    ShowLine(0, False)
                    FormatGridNormal()

                Case "1"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit1'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "2"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit2'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "3"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit3'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "4"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit4'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "5"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit5'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "6"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit6'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "7"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit7'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "8"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit8'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "9"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit9'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "10"
                    Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit10'", cnn)
                    If BranchId > 0 Then
                        ShowLine(BranchId, False)
                    Else
                        MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    FormatGrid()
                Case "SL"

                    ShowLine(0, True)
                    'FormatGrid()

            End Select

            mCount = 1

        End If

    End Sub

    Private Sub CloseSimpleButton_Click(sender As Object, e As EventArgs) Handles CloseSimpleButton.Click

        Me.Close()

    End Sub
    Private Sub FormatGrid()

        Dim fontsize As Integer = 15

        'GridView1.Appearance.Row.Font = New Font("Arial", 50, FontStyle.Bold)

        GridView1.OptionsView.RowAutoHeight = False
        GridView1.RowHeight = RowHeight

        colLine.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colTargetPerHour.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colH1.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH2.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH3.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH4.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH5.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH6.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH7.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH8.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH9.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH10.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH11.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH12.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colPresent_Operator.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colPresent_Helper.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colMCUsage.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)

        colTTLProduction.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)


    End Sub
    Private Sub FormatGridNormal()

        Dim fontsize As Integer = 8.25

        'GridView1.Appearance.Row.Font = New Font("Arial", 50, FontStyle.Bold)

        GridView1.OptionsView.RowAutoHeight = True
        GridView1.RowHeight = 3

        colLine.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colTargetPerHour.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colH1.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH2.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH3.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH4.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH5.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH6.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH7.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH8.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH9.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH10.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH11.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH12.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colTTLProduction.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colPresent_Operator.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colPresent_Helper.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colMCUsage.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)

    End Sub

    Private Sub FormatGridByFontSize(ByVal FS As Integer)

        Dim fontsize As Integer = FS

        colLine.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colTargetPerHour.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)
        colH1.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH2.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH3.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH4.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH5.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH6.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH7.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH8.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH9.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH10.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH11.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colH12.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colMCUsage.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colPresent_Operator.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colPresent_Helper.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colNL.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Regular)
        colTTLProduction.AppearanceCell.Font = New Font("Arial", fontsize, FontStyle.Bold)


    End Sub

    Private Sub U1Button_Click(sender As Object, e As EventArgs) Handles U1Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 1
        UnitFlag = "1"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-1")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit1'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 1 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U2Button_Click(sender As Object, e As EventArgs) Handles U2Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 2
        UnitFlag = "2"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-2")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit2'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 2 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U3Button_Click(sender As Object, e As EventArgs) Handles U3Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 3
        UnitFlag = "3"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-3")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit3'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 3 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U4Button_Click(sender As Object, e As EventArgs) Handles U4Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 4
        UnitFlag = "4"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-4")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit4'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 4 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U5Button_Click(sender As Object, e As EventArgs) Handles U5Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 5
        UnitFlag = "5"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-5")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit5'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 5 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U6Button_Click(sender As Object, e As EventArgs) Handles U6Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 6
        UnitFlag = "6"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-6")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit6'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 6 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U7Button_Click(sender As Object, e As EventArgs) Handles U7Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 7
        UnitFlag = "7"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-7")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit7'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 7 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub U8Button_Click(sender As Object, e As EventArgs) Handles U8Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 8
        UnitFlag = "8"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-8")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit8'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 8 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub Unit9Button_Click(sender As Object, e As EventArgs) Handles Unit9Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 9
        UnitFlag = "9"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-9")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit9'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 9 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub Unit10Button_Click(sender As Object, e As EventArgs) Handles Unit10Button.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Unit = 10
        UnitFlag = "10"
        UnitLabel.Text = System.String.Format(scrolledString, "SEWING UNIT-10")
        Dim BranchId = ReadIntegerData("Select BranchId From Branch Where BranchCode='Sewing Unit10'", cnn)
        If BranchId > 0 Then
            ShowLine(BranchId, False)
        Else
            MessageBox.Show("Sewing Unit 10 Is Not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FormatGrid()
        SplashScreenManager.CloseForm(False)
    End Sub



    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        GridView1.OptionsView.RowAutoHeight = False

        GridView1.RowHeight += 10
        RowHeight = GridView1.RowHeight
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        GridView1.RowHeight -= 10
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FontSize += 1
        FormatGridByFontSize(FontSize)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        FontSize -= 1
        FormatGridByFontSize(FontSize)
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        UnitLabel.Location = New Point(UnitLabel.Location.X + 2, UnitLabel.Location.Y)
        If (UnitLabel.Location.X + UnitLabel.Width > Me.Width) Then
            Timer2.Stop()
            Timer3.Start()
        End If

    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        UnitLabel.Location = New Point(UnitLabel.Location.X - 2, UnitLabel.Location.Y)
        If (UnitLabel.Location.X < 0) Then
            Timer2.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub CheckedComboBoxEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles CheckedComboBoxEdit1.EditValueChanged

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        UnitFlag = "SL"
        UnitLabel.Text = "NORBAN COMTEX LIMITED" 'System.String.Format(scrolledString, "ALL")
        ShowLine(0, True)
        SplashScreenManager.CloseForm(False)
    End Sub
End Class
