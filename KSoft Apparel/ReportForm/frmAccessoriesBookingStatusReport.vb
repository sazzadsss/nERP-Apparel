Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmAccessoriesBookingStatusReport

    Dim filterstring As String = ""

    Private Sub frmAccessoriesBookingStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AWSProgramLookupTableAdapter.Fill(Me.AWSLookupDataSet.AWSProgramLookup)
        Me.AccBookingLookupTableAdapter.FillByAll(Me.AccBOMLookUpDataSet.AccBookingLookup)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.DepartmentGridLookUpEdit.EditValue = My.Settings.AccDepartmentId

        BookingProgramNoLookupTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoLookup, My.Settings.AccDepartmentId)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim row As BookingDataSet.BookingProgramNoLookupRow
        'row = CType(CType(Me.BookingProgramNoLookupBindingSource.Current, DataRowView).Row, BookingDataSet.BookingProgramNoLookupRow)

        filterstring = "{Booking.BookingId} = " & ProgramNoGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatus2
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click

        If UserLevel = 1 Then

            filterstring = ""

        Else

            filterstring = "{Booking.DepartmentId} = " & DepartmentId

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatus2
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub


    Private Sub GridLookUpEdit3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentGridLookUpEdit.EditValueChanged
        ' Me.SubCategoryLookupTableAdapter.FillByDepartmentId(Me.SubCategoryDataSet.SubCategoryLookup, GridLookUpEdit3.EditValue)
        On Error Resume Next
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, DepartmentGridLookUpEdit.EditValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        filterstring = "{ItemList.ItemId} = " & SubCatGridLookUpEdit.EditValue & " and {Buyer.BuyerId} = " & BuyerGridLookUpEdit.EditValue & " and{ItemList.DepartmentId} = " & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatusByItem
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        filterstring = "{Booking.OrderId} = " & OrderIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatus2
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub AWSNoShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWSNoShowButton.Click

        filterstring = "{Booking.ProgramNo} = '" & AWSNoLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatusAWSNo
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub PGNoShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PGNoShowButton.Click

        filterstring = "{Order.ProgramNo} = '" & ProgramSearchGridLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AccessoriesBookingStatusProgramNo
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class