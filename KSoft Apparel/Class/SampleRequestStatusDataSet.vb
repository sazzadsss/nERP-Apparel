﻿
Imports System.Data.SqlClient

Namespace SampleRequestStatusDataSetTableAdapters

    Partial Class SampleRequestStatusTableAdapter


        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)

            For Each command As SqlCommand In Me.CommandCollection

                command.CommandTimeout = timeOut

            Next

        End Sub

    End Class

End Namespace
