
Imports System.Data.SqlClient

Namespace OrderAndProductionStatusDataSetTableAdapters

    Partial Class MasterOrderAndProductionStatusPrgTableAdapter


        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)

            For Each command As SqlCommand In Me.CommandCollection

                command.CommandTimeout = timeOut

            Next

        End Sub

    End Class

End Namespace
