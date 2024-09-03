Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmSewingLayoutTopSheet
    Dim filterstring As String = ""

    Private _SewingLayoutId As Integer
    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property
    Private _MIS As Boolean
    Public Property MIS() As Boolean
        Get
            Return _MIS
        End Get
        Set(ByVal value As Boolean)
            _MIS = value
        End Set
    End Property


    Private Sub frmSewingLayoutTopSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)



        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)
        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)
        Me.BonusTopSheetNameLookupTableAdapter.Fill(Me.BonusDataSet.BonusTopSheetNameLookup)


        If Me.MIS = False Then

            Dim index As Integer = Me.SewingLayoutBindingSource.Find("LayoutId", Me.SewingLayoutId)
            Me.SewingLayoutBindingSource.Position = index

            filterstring = "{SewingLayout.LayoutId}=" & Me.SewingLayoutId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingLayoutDetails
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If





    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Me.SewingLayoutId = Me.GridLookUpEdit1.EditValue
        filterstring = "{SewingLayout.LayoutId}=" & Me.SewingLayoutId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingLayout
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    
    Private Sub ShowBonusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowBonusButton.Click



        If MultipleBounstextBox.Text <> String.Empty Then

            Dim s As String = ""
            Dim s1 As String = ""

            s = MultipleBounstextBox.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
            'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)

            'filterstring = "{vOrder.ProgramNo} like ['" & s1 & "']"

            filterstring = "{BonusTopSheet.BonusTopSheetName} like ['" & s1 & "']"


            'Previous

            'Me.SewingLayoutId = Me.GridLookUpEdit1.EditValue
            'filterstring = "{BonusTopSheet.BonusTopSheetName} = '" & Me.BonusTopSheetNoGridLookUpEdit.EditValue & "'"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BonusTopSheet
            ShowReport(MyReport, filterstring, CrystalReportViewer1)




        End If




      

    End Sub

   
    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged, GridLookUpEdit1.Closed

    End Sub

    Private Sub MonthlyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyButton.Click


        filterstring = "{ProductionMonth.ProductionMonthId} =" & ProductionMonthComboBox.SelectedValue & "and {Branch.BranchId} =" & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyBonusTopSheet
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub ByStyleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByStyleButton.Click

        filterstring = "{Style.StyleId} = " & StyleLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BonusTopSheet_Programwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowbyProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowbyProgramButton.Click

        filterstring = "{Order.ProgramNo} = '" & ProgramNoGridLookUpEdit.Text.ToString & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BonusTopSheet_Programwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Me.SewingLayoutId = Me.GridLookUpEdit1.EditValue
        'filterstring = "{BonusTopSheet.BonusTopSheetName} = '" & Me.BonusTopSheetNoGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LossHourSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.MultipleBounstextBox.Text = String.Empty Then
            Me.MultipleBounstextBox.Text = BonusTopSheetNoGridLookUpEdit.EditValue
        Else
            Me.MultipleBounstextBox.Text = Me.MultipleBounstextBox.Text.ToString & ", " & BonusTopSheetNoGridLookUpEdit.EditValue
        End If

    End Sub

    Private Sub TargetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetButton.Click
        Me.SewingLayoutId = Me.GridLookUpEdit1.EditValue
        filterstring = "{SewingLayout.LayoutId}=" & Me.SewingLayoutId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingTargetAllocation
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SewingLayoutId = Me.GridLookUpEdit1.EditValue
        filterstring = "{SewingLayout.LayoutId}=" & Me.SewingLayoutId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingLayoutDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class