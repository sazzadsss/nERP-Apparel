Imports System.Data.SqlClient

Module DataTableModule


    'Sub Main()
    '    ' Get a DataTable instance from helper function.
    '    Dim table As DataTable = GetTable()
    'End Sub

    '''' <summary>
    '''' Helper function that creates new DataTable.
    '''' </summary>
    'Function GetTable() As DataTable
    '    ' Create new DataTable instance.
    '    Dim table As New DataTable
    '    ' Create four typed columns in the DataTable.
    '    table.Columns.Add("Dosage", GetType(Integer))
    '    table.Columns.Add("Drug", GetType(String))
    '    table.Columns.Add("Patient", GetType(String))
    '    table.Columns.Add("Date", GetType(DateTime))
    '    ' Add five rows with those columns filled in the DataTable.
    '    table.Rows.Add(25, "Indocin", "David", DateTime.Now)
    '    table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now)
    '    table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now)
    '    table.Rows.Add(21, "Combivent", "Janet", DateTime.Now)
    '    table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now)
    '    Return table
    'End Function



    Function GetDeyingTypeTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("DyeingTypeId", GetType(Integer))
        table.Columns.Add("DyeingType", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(1, "ExtraDark")
        table.Rows.Add(2, "Dark")
        table.Rows.Add(3, "Medium")
        table.Rows.Add(4, "Light")
        table.Rows.Add(5, "White")
        table.Rows.Add(6, "Wash")

        Return table

    End Function
    Function GetChallanForTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("ChallanFor", GetType(Integer))
        table.Columns.Add("Details", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(1, "Sewing")
        table.Rows.Add(2, "Printing")
        table.Rows.Add(3, "Embroidery")


        Return table

    End Function


    Function GetGSM() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("GSMId", GetType(Integer))
        table.Columns.Add("GSM", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select GSMId,GSM From GSM Order By GSM", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("GSMId"), reader("GSM").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function


    Function GetStyleName(ByVal filterstring As String) As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("StyleId", GetType(Integer))
        table.Columns.Add("StyleName", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select StyleName From Style  Order By StyleName", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("StyleId"), reader("StyleName").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function


    Function GetLabelTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("LabelId", GetType(Integer))
        table.Columns.Add("Label", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(1, "None")
        table.Rows.Add(2, "FabricReceived")
        table.Rows.Add(3, "Cutting")
        table.Rows.Add(4, "Sewing")
        table.Rows.Add(5, "Finishing")
        table.Rows.Add(6, "Shipped")

        Return table

    End Function

    Function GetStatusTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("StatusId", GetType(Integer))
        table.Columns.Add("Status", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(0, "Waiting")
        table.Rows.Add(1, "Running")
        table.Rows.Add(2, "Completed")
       

        Return table

    End Function

    Function GetProgramNo() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("OrderId", GetType(Integer))
        table.Columns.Add("ProgramNo", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select OrderId,ProgramNo From [Order]", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("OrderId"), reader("ProgramNo").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function


    Function GetLine() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("LineId", GetType(Integer))
        table.Columns.Add("Line", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select LineId,Line From Line Order By Line", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("LineId"), reader("Line").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function


    Function GetOrderListAgainstStyle(ByVal SID As Integer) As DataTable 'SID=StyleId

        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("OrderId", GetType(Integer))
        table.Columns.Add("ProgramNo", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select OrderId,ProgramNo From [Order] Where StyleId=" & SID & "And Discontinue=0 Order By ProgramNo", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("OrderId"), reader("ProgramNo").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function
    Function GetYarnDyingType() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("YarnDyeingTypeId", GetType(Integer))
        table.Columns.Add("YarnDyeingType", GetType(String))

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select YarnDyeingTypeId,YarnDyeingType From YarnDyeingType Order By YarnDyeingType", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("YarnDyeingTypeId"), reader("YarnDyeingType").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function
End Module

