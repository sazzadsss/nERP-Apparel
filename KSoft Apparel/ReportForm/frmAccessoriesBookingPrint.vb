Public Class frmAccessoriesBookingPrint


    Private _OID As Integer

    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Private _SuplierId As Integer
    Public Property SuplierId() As Integer
        Get
            Return _SuplierId
        End Get
        Set(ByVal value As Integer)
            _SuplierId = value
        End Set
    End Property

    Dim filterstring As String = ""

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOMShowButton.Click



        filterstring = "{AccessoriesBooking.AccessoriesBookingId} = " & Me.ProgramSearchGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingNew

        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub


    Private Sub AccessoriesBookingPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AccBookingLookupTableAdapter.FillByAll(Me.AccBOMLookUpDataSet.AccBookingLookup)


        If Me.OID > 0 Then

            ProgramSearchGridLookUpEdit.EditValue = ReadIntegerData("Select AccessoriesBookingId From AccessoriesBooking Where Orderid=" & Me.OID, cnn)

            filterstring = "{AccessoriesBooking.AccessoriesBookingId} = " & Me.ProgramSearchGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingNew

            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If


    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        filterstring = "{AccessoriesBooking.AccessoriesBookingId} = " & Me.ProgramSearchGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBOMAndAWSReport

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub ProgramSearchGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramSearchGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub ShowButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text
        filterstring = "{AccessoriesBooking.BookingDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingNewDateWise
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class