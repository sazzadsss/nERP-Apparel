
Imports System.Reflection

Public Class frmMasterOrderPrint

    Private _MOID As Integer
    Public Property MOID() As Integer
        Get
            Return _MOID
        End Get
        Set(ByVal value As Integer)
            _MOID = value
        End Set
    End Property
    Dim filterstring As String = ""

    Private Sub frmMasterOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

        Me.DivisionTableAdapter.Fill(Me.DivisionDataSet.Division)
        Me.StyleTypeMstTableAdapter.Fill(Me.StyleTypeDataSet.StyleTypeMst)

        Me.SeasonTableAdapter.Fill(Me.SeasonDataSet.Season)
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)
        Me.MasterDetailsProgramLookUpTableAdapter.Fill(Me.MasterDetailsProgramLookUpDataSet.MasterDetailsProgramLookUp)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        Me.MasterOrderLookUpTableAdapter.Fill(Me.MasterOrderLookUpDataSet.MasterOrderLookUp)

        If Me.MOID > 1 Then

            Me.MasterOrderLookUpEdit.EditValue = Me.MOID
            filterstring = "{MasterOrder.MasterOrderId} =" & MasterOrderLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrint
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        ColorGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

        Me.UserLookupTableAdapter.FillByDepartmentName(Me.UserLookupDataSet.UserLookup, "Merchandising HO")

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        filterstring = "{MasterOrder.MasterOrderId} =" & MasterOrderLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub btnRFIDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text
        filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
        MyReport.SetParameterValue("ShowFormat", "RFIDate")
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
    Private Sub ProgrmaShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrmaShowButton.Click

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text

        filterstring = "{MasterOrderDetails.ProgramNo} ='" & ProgramNoGridLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
        MyReport.SetParameterValue("ShowFormat", "Program")
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub BuyerRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerRadioButton.CheckedChanged

        BuyerIdGridLookUpEdit.Enabled = True
        DateBuyerRunningButton.Enabled = True
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        ColorGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub
    Private Sub StyleRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleRadioButton.CheckedChanged

        StyleIdGridLookUpEdit.Enabled = True
        DateBuyerRunningButton.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        ColorGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub BrandRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandRadioButton.CheckedChanged

        BrandGridLookUpEdit.Enabled = True
        DateBuyerRunningButton.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        ColorGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub ColorRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorRadioButton.CheckedChanged

        ColorGridLookUpEdit.Enabled = True
        DateBuyerRunningButton.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub SeasonRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeasonRadioButton.CheckedChanged

        SeasonGridLookUpEdit.Enabled = True
        DateBuyerRunningButton.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        ColorGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub btnProgramDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgramDate.Click

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text

        If CreatedDateRadioButton.Checked = True Then


            If BuyerRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"
            ElseIf StyleRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.StyleName} = '" & StyleIdGridLookUpEdit.Text & "'"
            ElseIf BrandRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {GMTBrand.GMTBrandName} = '" & BrandGridLookUpEdit.Text & "'"
            ElseIf ColorRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {FabricColor.FabricColorName} = '" & ColorGridLookUpEdit.Text & "'"
            ElseIf SeasonRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Season.SeasonName} = '" & SeasonGridLookUpEdit.Text & "'"
            ElseIf StyleTypeRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrder.StyleType} = '" & StyleTypeGridLookUpEdit.EditValue & "'"
            ElseIf DivisionRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.DivisionId} = " & DivisionGridLookUpEdit.EditValue
            ElseIf RunningRadioButton.Checked = True Then
                filterstring = "not {@IsShipout} and {MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
            ElseIf RunningAllRadioButton.Checked = True Then
                filterstring = "not {@IsShipout}"
            ElseIf ShipoutRadioButton.Checked = True Then
                filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrderDetails.Shipout}"
            End If

        ElseIf ExFactoryDateRadioButton.Checked = True Then

            If BuyerRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"
            ElseIf StyleRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.StyleName} = '" & StyleIdGridLookUpEdit.Text & "'"
            ElseIf BrandRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {GMTBrand.GMTBrandName} = '" & BrandGridLookUpEdit.Text & "'"
            ElseIf ColorRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {FabricColor.FabricColorName} = '" & ColorGridLookUpEdit.Text & "'"
            ElseIf SeasonRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Season.SeasonName} = '" & SeasonGridLookUpEdit.Text & "'"
            ElseIf StyleTypeRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrder.StyleType} = '" & StyleTypeGridLookUpEdit.EditValue & "'"
            ElseIf DivisionRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.DivisionId} = " & DivisionGridLookUpEdit.EditValue
            ElseIf RunningRadioButton.Checked = True Then
                filterstring = "not {@IsShipout} and {MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
            ElseIf RunningAllRadioButton.Checked = True Then
                filterstring = "not {@IsShipout}"
            ElseIf ShipoutRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrderDetails.Shipout}"

            End If

        ElseIf ShipmentDateRadioButton.Checked = True Then

            If BuyerRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"
            ElseIf StyleRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.StyleName} = '" & StyleIdGridLookUpEdit.Text & "'"
            ElseIf BrandRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {GMTBrand.GMTBrandName} = '" & BrandGridLookUpEdit.Text & "'"
            ElseIf ColorRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {FabricColor.FabricColorName} = '" & ColorGridLookUpEdit.Text & "'"
            ElseIf SeasonRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Season.SeasonName} = '" & SeasonGridLookUpEdit.Text & "'"
            ElseIf StyleTypeRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrder.StyleType} = '" & StyleTypeGridLookUpEdit.EditValue & "'"
            ElseIf DivisionRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.DivisionId} = " & DivisionGridLookUpEdit.EditValue
            ElseIf RunningRadioButton.Checked = True Then
                filterstring = "not {@IsShipout} and {MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
            ElseIf RunningAllRadioButton.Checked = True Then
                filterstring = "not {@IsShipout}"
            ElseIf ShipoutRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrderDetails.Shipout}"

            End If

        ElseIf RFIDateRadioButton.Checked = True Then

            If BuyerRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"
            ElseIf StyleRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.StyleName} = '" & StyleIdGridLookUpEdit.Text & "'"
            ElseIf BrandRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {GMTBrand.GMTBrandName} = '" & BrandGridLookUpEdit.Text & "'"
            ElseIf ColorRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {FabricColor.FabricColorName} = '" & ColorGridLookUpEdit.Text & "'"
            ElseIf SeasonRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Season.SeasonName} = '" & SeasonGridLookUpEdit.Text & "'"
            ElseIf StyleTypeRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrder.StyleType} = '" & StyleTypeGridLookUpEdit.EditValue & "'"
            ElseIf DivisionRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Style.DivisionId} = " & DivisionGridLookUpEdit.EditValue
            ElseIf RunningRadioButton.Checked = True Then
                filterstring = "not {@IsShipout} and {MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"
            ElseIf RunningAllRadioButton.Checked = True Then
                filterstring = "not {@IsShipout}"
            ElseIf ShipoutRadioButton.Checked = True Then
                filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {MasterOrderDetails.Shipout}"
            End If

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
        MyReport.SetParameterValue("ShowFormat", "")
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub



    Private Sub ShowByFirstExDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByFirstExDateButton.Click

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text

        If RFIDateRadioButton.Checked = True Then

            filterstring = "{MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
            MyReport.SetParameterValue("ShowFormat", "RFI")
            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf ExFactoryDateRadioButton.Checked = True Then

            filterstring = "{MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
            MyReport.SetParameterValue("ShowFormat", "Shipment")
            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        ElseIf ShipmentDateRadioButton.Checked = True Then


            filterstring = "{MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
            MyReport.SetParameterValue("ShowFormat", "Shipment")
            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        Else

            filterstring = "{MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
            MyReport.SetParameterValue("ShowFormat", "Created On")
            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub StyleTypeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles StyleTypeRadioButton.CheckedChanged

        ColorGridLookUpEdit.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = True
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub DivisionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivisionRadioButton.CheckedChanged
        ColorGridLookUpEdit.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text

        If Me.ByMerchComboBox.Text = "By NFL Merchandiser" Then

            If RFIDateRadioButton.Checked = True Then

                filterstring = "{MasterOrder.UserId}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "RFI")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf ExFactoryDateRadioButton.Checked = True Then

                filterstring = "{MasterOrder.UserId}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Shipment")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            ElseIf ShipmentDateRadioButton.Checked = True Then

                filterstring = "{MasterOrder.UserId}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Shipment")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                filterstring = "{MasterOrder.UserId}=" & UserGridLookUpEdit.EditValue & " And {MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Created On")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If

        Else

            If RFIDateRadioButton.Checked = True Then

                filterstring = "{MasterOrderDetails.AsignedForMerchandeiser}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "RFI")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf ExFactoryDateRadioButton.Checked = True Then

                filterstring = "{MasterOrderDetails.AsignedForMerchandeiser}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.Re_ExFactory} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Shipment")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf ShipmentDateRadioButton.Checked = True Then

                filterstring = "{MasterOrderDetails.AsignedForMerchandeiser}=" & UserGridLookUpEdit.EditValue & " And {MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Shipment")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                filterstring = "{MasterOrderDetails.AsignedForMerchandeiser}=" & UserGridLookUpEdit.EditValue & " And {MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
                MyReport.SetParameterValue("ShowFormat", "Created On")
                MyReport.SetParameterValue("FromDate", SFDate.Date)
                MyReport.SetParameterValue("ToDate", STDate.Date)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If

        End If



    End Sub

    Private Sub ByMerchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ByMerchComboBox.SelectedIndexChanged

        If Me.ByMerchComboBox.Text = "By NFL Merchandiser" Then
            Me.UserLookupTableAdapter.FillByDepartmentName(Me.UserLookupDataSet.UserLookup, "Merchandising HO")
        ElseIf Me.ByMerchComboBox.Text = "By FAC Merchandiser" Then
            Me.UserLookupTableAdapter.FillByFactoryMerchandiser(Me.UserLookupDataSet.UserLookup, "Merchandising NCL", "Merchandising HAL")
        End If

    End Sub

    Private Sub ShipoutRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ShipoutRadioButton.CheckedChanged

        ColorGridLookUpEdit.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub RunningRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RunningAllRadioButton.CheckedChanged, RunningRadioButton.CheckedChanged

        ColorGridLookUpEdit.Enabled = False
        BuyerIdGridLookUpEdit.Enabled = False
        StyleIdGridLookUpEdit.Enabled = False
        BrandGridLookUpEdit.Enabled = False
        SeasonGridLookUpEdit.Enabled = False
        StyleTypeGridLookUpEdit.Enabled = False
        DivisionGridLookUpEdit.Enabled = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles ShipmentDateRadioButton.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DateBuyerRunningButton.Click

        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text

        If CreatedDateRadioButton.Checked = True Then

            filterstring = "not {@IsShipout} And {MasterOrder.CreatedOn} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"

        ElseIf ExFactoryDateRadioButton.Checked = True Then

            filterstring = "not {@IsShipout} And {MasterOrderDetails.Ex} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"

        ElseIf ShipmentDateRadioButton.Checked = True Then

            filterstring = "not {@IsShipout} And {MasterOrderDetails.ShipoutDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"

        ElseIf RFIDateRadioButton.Checked = True Then

            filterstring = "not {@IsShipout} And {MasterOrderDetails.RFIDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59) AND {Buyer.BuyerName} = '" & BuyerIdGridLookUpEdit.Text & "'"

        End If
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrintByDateWise
        MyReport.SetParameterValue("ShowFormat", "")
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub




    'for hide .rpt format at export report

    'Public Sub DisableUnwantedExportFormat(ByVal ReportViewerID As ReportViewer, ByVal strFormatName As String)
    '    Dim info As FieldInfo

    '    For Each extension As RenderingExtension In ReportViewerID.LocalReport.ListRenderingExtensions()
    '        If extension.Name = strFormatName Then
    '            info = extension.[GetType]().GetField("m_isVisible", BindingFlags.Instance Or BindingFlags.NonPublic)
    '            info.SetValue(extension, False)
    '        End If
    '    Next
    'End Sub

    ' DisableUnwantedExportFormat(ReportViewer1, "PDF");

End Class