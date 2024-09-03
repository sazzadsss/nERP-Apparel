'Private Sub mygridview_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles mygridview.CellValueChanged
'    Try
'        Dim ColumnIndex, RowIndex, RowValue
'        ColumnIndex = mygridview.CurrentCell.ColumnIndex
'        'MsgBox(ColumnIndex)
'        RowIndex = CStr(mygridview.CurrentCell.RowIndex)
'        RowValue = CStr(mygridview.CurrentCell.Value)
'        MsgBox(RowIndex + RowValue)
'        'Dim s As String = CStr(mygridview.Rows(RowIndex).Cells("course").Val ue)
'        s = "select distinct venue from cvs1 where course='" + RowValue + "' "
'        'MsgBox(s)
'        ''and enrolno ='" + txtenrolno.Text + "'"
'        cmd = New System.Data.OleDb.OleDbCommand(s, cn)
'        rs = cmd.ExecuteReader()
'        While (rs.Read())
'            MsgBox(rs.GetValue(0))
'            ' mygridview.Item(1, 0) = rs.GetValue(0)
'            mygridview.Rows(RowIndex).Cells(1).Value() = rs.GetValue(0)
'            'mygridview.Item(mygridview(1, cnt), ColumnIndex + 1) = rs(0)
'            'MsgBox(a)
'            'mygridview.Rows(RowIndex).Cells("venue") = rs(0)
'        End While
'    Catch ex As Exception
'        MsgBox(ex.Message)
'    End Try
'End Sub





''=============================
'Search
'==============================
'Private returnValue As DataRow()
'Private SurnameSearchPosition As Integer
'Public Sub Surnamesearch(ByVal SearchText As String)
'    ' PURPOSE: Search for a Searname in Applicants Datatable
'    ' 
'    ' ARGUMENTS:  SearchText As String
'    ' RETURNS:  
'    ' CODED BY: JWilcock
'    ' DATE: 10/01/2007
'    ' NOTES:    

'    ' declare variables
'    Dim ReturnID As Integer
'    Dim filter As String

'    Try
'        returnValue = Nothing
'        SurnameSearchPosition = 0
'        filter = "Surname Like '" & SearchText & "'"
'        returnValue = iMain.objDataConnection.ddsApplicantCollection.tbl_Applicants.Select(filter)
'        If returnValue.GetUpperBound(0) >= 0 Then
'            ReturnID = returnValue(SurnameSearchPosition).Item(0)
'            ReturnToApplicant(ReturnID)
'        Else
'        End If
'    Catch ex As System.Exception
'        MsgBox("Error occured in ApplicantCollection.Surnamesearch " & ex.ToString & ControlChars.CrLf & "Contact the IT Department Immediately", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "An Error Has Occured!")
'    End Try

'End Sub
'Public Sub SurnameSearchNext()

'    Dim ReturnID As Integer
'    If SurnameSearchPosition < returnValue.GetUpperBound(0) Then
'        SurnameSearchPosition = SurnameSearchPosition + 1

'        ReturnID = returnValue(SurnameSearchPosition).Item(0)
'        ReturnToApplicant(ReturnID)
'    Else
'    End If

'End Sub
'Public Sub SurnameSearchPrevious()

'    Dim ReturnID As Integer
'    If SurnameSearchPosition > returnValue.GetLowerBound(0) Then
'        SurnameSearchPosition = SurnameSearchPosition - 1

'        ReturnID = returnValue(SurnameSearchPosition).Item(0)
'        ReturnToApplicant(ReturnID)
'    Else
'    End If

'End Sub
'Public Sub ReturnToApplicant(ByVal ReturnID)
'    ' PURPOSE: Return 
'    ' 
'    ' ARGUMENTS:  
'    ' RETURNS:  
'    ' CODED BY: JWilcock
'    ' DATE: 10/01/2007
'    ' NOTES:    

'    ' declare variables
'    Try
'        Dim index As Integer = iMain.bsrcApplicants.Find("PK_ApplicantID", ReturnID)
'        iMain.bsrcApplicants.Position = index
'    Catch ex As System.Exception
'        MsgBox("Error occured in ApplicantCollection.ReturnToApplicant " & ex.ToString & ControlChars.CrLf & "Contact the IT Department Immediately", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "An Error Has Occured!")
'    End Try



'Crystal Report
'PageNumber=TotalPageCount 
'and OnLastRecord 
'End Sub