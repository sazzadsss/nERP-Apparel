Imports Microsoft.Office.Interop
Module xlmodule
    'Private Function FindLastCell(ByVal objExcel As ) As String

    '    Dim LastColumn As Integer
    '    Dim LastRow As Long
    '    Dim FirstColumn As Integer
    '    Dim FirstRow As Long
    '    Dim LastCell As Range
    '    Dim FirstCell As Range
    '    Dim strAddrRng As String

    '    If objExcel.WorksheetFunction.CountA(objExcel.Cells) > 0 Then
    '        FirstCell = objExcel.Cells(1, "A")
    '        strAddrRng = FirstCell.Address
    '        'Search for any entry, by searching backwards by Rows.
    '        LastRow = objExcel.Cells.Find(What:="*", After:=objExcel.Range("A1"), _
    '        searchOrder:=xlByRows, _
    '        SearchDirection:=xlPrevious).Row
    '        'Search for any entry, by searching backwards by Columns.
    '        LastColumn = objExcel.Cells.Find(What:="*", After:=objExcel.Range("A1"), _
    '        searchOrder:=xlByColumns, _
    '        SearchDirection:=xlPrevious).Column

    '        LastCell = objExcel.Cells(LastRow, LastColumn)
    '        strAddrRng = strAddrRng & ":" & LastCell.Address
    '    End If
    '    FindLastCell = strAddrRng
    '    FirstCell = Nothing
    '    LastCell = Nothing
    'End Function
End Module
