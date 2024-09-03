<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSampleRequestStatusUpdateNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SampleRequestStatusDataSet = New KSoft_Apparel.SampleRequestStatusDataSet()
        Me.SampleRequestStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestStatusTableAdapter = New KSoft_Apparel.SampleRequestStatusDataSetTableAdapters.SampleRequestStatusTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleRequestStatusDataSetTableAdapters.TableAdapterManager()
        Me.SampleRequestStatusGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPicture = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBuyer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit46 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit28 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colRequestNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRequestDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDivision = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSeason = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit29 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFileReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFileReceiveDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit19 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSampleRequireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricRequireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricBookingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleFabricBookingRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit25 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsBookingComplete = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRevisedNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRevisedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCauseOfRevised = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit30 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colAttention = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsReceivedByDyeing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStyleType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGarmentsDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit31 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsPrint = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrintType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsSublimation = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsEmbroidery = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsSequence = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEmbroideryDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit20 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsAOP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsYds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsWash = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWashType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsBrush = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsPeachFinish = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsTrim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTrimDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit21 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsTrimAvailable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExTrimRcvDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAccReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAccReceiveDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit22 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsFabricAvailable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExFabricRcvDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNLD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit47 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colGSM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit48 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFabricDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit23 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colKnittingType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit33 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colComposition = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit34 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colDevType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit35 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit36 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSampleQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFinishQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGreyQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFDeliveryQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleCuttingStartDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleCuttingEndDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSamplePrintSendDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSamplePrintSendQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colsamplePrintReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSamplePrintReceiveQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleEmbSendDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleEmbSendQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleEmbReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleEmbReceiveQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleSewingStartDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleSewingEndDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit37 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colStatusRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit26 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colCommentsReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleExDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleSendDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSendingInfo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit38 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstSampleDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastSampleDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSampleDeliveryQuantity2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGatePassType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit41 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colApprovalStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit39 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsComplete = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompletedOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit27 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSamplePreparedBy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit40 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colProgramNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit45 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMerchandiser = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colGreyQuantity1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstYarnRequisitonDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastYarnRequisitonDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYarnRequisitonNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colYarnIssueQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYarnIssueBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYarnDelChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstYarnDelChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastYarnDelChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYarnName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit24 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colYarnBrand = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit42 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colLotNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colStitchLength = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMCDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMCGauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colKnittingProduction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFIDeliveryQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFIChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstGFIDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastGFIDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTTLGFReceiveQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFReceiveBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFReceiveChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstGFSReceiveChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastGFSReceiveChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTTLGFIssueQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFIssueBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGFIssueChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstGFSIssueChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastGFSIssueChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFirstBatchDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastBatchDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colKnittingType1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colBatchQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFirstDyeingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDyeingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDyeingQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDLBatchNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEnzyme = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colSoftner = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colShade = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFirstLDReceivedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLDReceivedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstSwatchReceivedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastSwatchReceivedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstLabFabricDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLabFabricDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstLabPreparedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLabPreparedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstLDApprovedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLDApprovedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstLDSenttoFloorDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLDSenttoFloorDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstLDSentForAppDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastLDSentForAppDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLDRecipeNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colLDCost = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLDStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFabricTestNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstFabricTestDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFabricTestDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstFabricTestReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFabricTestReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstSubmitDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastSubmitDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstFabricTestApprovedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFabricTestApprovedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricTestStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFinishingProcessed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit43 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFirstFinishingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFinishingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTTLDyeingFinishingQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQADStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstFFIDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFFIDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFIChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colTTLFFIDeliveryQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFirstFFRcvChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFFRcvChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFReceiveChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colTTLFFReceiveQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFReceiveBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstFFIssChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastFFIssChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFIssueChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colTTLFFIssueQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFFIssueBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIsBookingCompleteOn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoEdit32 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit44 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestNoAndStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LastUpdateLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.SaveLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.SampleRequestStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SampleRequestStatusDataSet
        '
        Me.SampleRequestStatusDataSet.DataSetName = "SampleRequestStatusDataSet"
        Me.SampleRequestStatusDataSet.EnforceConstraints = False
        Me.SampleRequestStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleRequestStatusBindingSource
        '
        Me.SampleRequestStatusBindingSource.DataMember = "SampleRequestStatus"
        Me.SampleRequestStatusBindingSource.DataSource = Me.SampleRequestStatusDataSet
        '
        'SampleRequestStatusTableAdapter
        '
        Me.SampleRequestStatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleRequestStatusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SampleRequestStatusGridControl
        '
        Me.SampleRequestStatusGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRequestStatusGridControl.DataSource = Me.SampleRequestStatusBindingSource
        Me.SampleRequestStatusGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.SampleRequestStatusGridControl.Location = New System.Drawing.Point(0, 50)
        Me.SampleRequestStatusGridControl.MainView = Me.BandedGridView1
        Me.SampleRequestStatusGridControl.Margin = New System.Windows.Forms.Padding(2)
        Me.SampleRequestStatusGridControl.Name = "SampleRequestStatusGridControl"
        Me.SampleRequestStatusGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5, Me.RepositoryItemMemoEdit6, Me.RepositoryItemMemoEdit7, Me.RepositoryItemMemoEdit8, Me.RepositoryItemMemoEdit9, Me.RepositoryItemMemoEdit10, Me.RepositoryItemMemoEdit11, Me.RepositoryItemMemoEdit12, Me.RepositoryItemMemoEdit13, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit14, Me.RepositoryItemMemoEdit15, Me.RepositoryItemMemoEdit16, Me.RepositoryItemMemoEdit17, Me.RepositoryItemMemoEdit18, Me.RepositoryItemMemoEdit19, Me.RepositoryItemMemoEdit20, Me.RepositoryItemMemoEdit21, Me.RepositoryItemMemoEdit22, Me.RepositoryItemMemoEdit23, Me.RepositoryItemMemoEdit24, Me.RepositoryItemMemoEdit25, Me.RepositoryItemMemoEdit26, Me.RepositoryItemMemoEdit27, Me.RepositoryItemMemoEdit28, Me.RepositoryItemMemoEdit29, Me.RepositoryItemMemoEdit30, Me.RepositoryItemMemoEdit31, Me.RepositoryItemMemoEdit32, Me.RepositoryItemMemoEdit33, Me.RepositoryItemMemoEdit34, Me.RepositoryItemMemoEdit35, Me.RepositoryItemMemoEdit36, Me.RepositoryItemMemoEdit37, Me.RepositoryItemMemoEdit38, Me.RepositoryItemMemoEdit39, Me.RepositoryItemMemoEdit40, Me.RepositoryItemMemoEdit41, Me.RepositoryItemMemoEdit42, Me.RepositoryItemMemoEdit43, Me.RepositoryItemMemoEdit44, Me.RepositoryItemMemoEdit45, Me.RepositoryItemMemoEdit46, Me.RepositoryItemMemoEdit47, Me.RepositoryItemMemoEdit48})
        Me.SampleRequestStatusGridControl.Size = New System.Drawing.Size(1344, 679)
        Me.SampleRequestStatusGridControl.TabIndex = 1
        Me.SampleRequestStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand3, Me.GridBand1, Me.gridBand2, Me.gridBand9, Me.gridBand8, Me.gridBand7, Me.gridBand6, Me.gridBand10, Me.gridBand5, Me.gridBand4})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPicture, Me.colBuyer, Me.colStyle, Me.colRequestNo, Me.colRequestDate, Me.colDivision, Me.colSeason, Me.colBrand, Me.colFileReceiveDate, Me.colFileReceiveDetails, Me.colSampleRequireDate, Me.colFabricRequireDate, Me.colStyleType, Me.colGarmentsDescription, Me.colFabricBookingDate, Me.colSampleFabricBookingRemarks, Me.colIsBookingComplete, Me.colIsBookingCompleteOn, Me.colRevisedNo, Me.colRevisedDate, Me.colCauseOfRevised, Me.colAttention, Me.colCC, Me.colIsReceivedByDyeing, Me.colIsPrint, Me.colPrintType, Me.colIsSublimation, Me.colIsEmbroidery, Me.colIsSequence, Me.colEmbroideryDetails, Me.colIsAOP, Me.colIsYds, Me.colIsWash, Me.colWashType, Me.colIsBrush, Me.colIsPeachFinish, Me.colIsTrim, Me.colTrimDetails, Me.colIsTrimAvailable, Me.colExTrimRcvDate, Me.colIsFabricAvailable, Me.colExFabricRcvDate, Me.colAccReceiveDate, Me.colAccReceiveDetails, Me.colNLD, Me.colFabricColorName, Me.colGSM, Me.colFabricDetails, Me.colKnittingType, Me.colComposition, Me.colDevType, Me.colSize, Me.colSampleQuantity, Me.colFinishQuantity, Me.colGreyQuantity, Me.colFirstChallanDate, Me.colLastChallanDate, Me.colFFDeliveryQuantity, Me.colSampleCuttingStartDate, Me.colSampleCuttingEndDate, Me.colSamplePrintSendDate, Me.colSamplePrintSendQty, Me.colsamplePrintReceiveDate, Me.colSamplePrintReceiveQty, Me.colSampleEmbSendDate, Me.colSampleEmbSendQty, Me.colSampleEmbReceiveDate, Me.colSampleEmbReceiveQty, Me.colSampleSewingStartDate, Me.colSampleSewingEndDate, Me.colSampleStatus, Me.colCommentsReceiveDate, Me.colStatusRemarks, Me.colSampleExDeliveryDate, Me.colSampleSendDate, Me.colSendingInfo, Me.colFirstSampleDeliveryDate, Me.colLastSampleDeliveryDate, Me.colSampleDeliveryQuantity2, Me.colGatePassType, Me.colApprovalStatus, Me.colIsComplete, Me.colCompletedOn, Me.colRemarks, Me.colSamplePreparedBy, Me.colMerchandiser, Me.colProgramNo, Me.colGreyQuantity1, Me.colFirstYarnRequisitonDate, Me.colLastYarnRequisitonDate, Me.colYarnRequisitonNo, Me.colYarnIssueQuantity, Me.colFirstYarnDelChallanDate, Me.colLastYarnDelChallanDate, Me.colYarnDelChallanNo, Me.colYarnName, Me.colYarnBrand, Me.colLotNo, Me.colStitchLength, Me.colMCDia, Me.colMCGauge, Me.colKnittingProduction, Me.colFirstGFIDate, Me.colLastGFIDate, Me.colGFIChallanNo, Me.colGFIDeliveryQty, Me.colTTLGFReceiveQuantity, Me.colGFReceiveChallanNo, Me.colFirstGFSReceiveChallanDate, Me.colLastGFSReceiveChallanDate, Me.colGFIssueChallanNo, Me.colFirstGFSIssueChallanDate, Me.colLastGFSIssueChallanDate, Me.colTTLGFIssueQuantity, Me.colFirstBatchDate, Me.colLastBatchDate, Me.colBatchNo, Me.colBatchQuantity, Me.colFabricColorName1, Me.colKnittingType1, Me.colFirstLDReceivedDate, Me.colLastLDReceivedDate, Me.colFirstLDApprovedDate, Me.colLastLDApprovedDate, Me.colLDRecipeNo, Me.colDyeingQuantity, Me.colFirstDyeingDate, Me.colLastDyeingDate, Me.colFinishingProcessed, Me.colFirstFinishingDate, Me.colLastFinishingDate, Me.colTTLDyeingFinishingQuantity, Me.colFFIChallanNo, Me.colFirstFFIDate, Me.colLastFFIDate, Me.colTTLFFIDeliveryQuantity, Me.colFirstLDSentForAppDate, Me.colLastLDSentForAppDate, Me.colLDCost, Me.colLDStatus, Me.colFirstLabPreparedDate, Me.colLastLabPreparedDate, Me.colFirstLabFabricDate, Me.colLastLabFabricDate, Me.colFirstSwatchReceivedDate, Me.colLastSwatchReceivedDate, Me.colFabricTestNo, Me.colFabricTestStatus, Me.colFirstFabricTestDate, Me.colLastFabricTestDate, Me.colFirstFabricTestReceiveDate, Me.colLastFabricTestReceiveDate, Me.colFirstSubmitDate, Me.colLastSubmitDate, Me.colFirstFabricTestApprovedDate, Me.colLastFabricTestApprovedDate, Me.colFFReceiveChallanNo, Me.colFirstFFRcvChallanDate, Me.colLastFFRcvChallanDate, Me.colTTLFFReceiveQuantity, Me.colTTLFFIssueQuantity, Me.colFirstFFIssChallanDate, Me.colLastFFIssChallanDate, Me.colFFIssueChallanNo, Me.colYarnIssueBalance, Me.colEnzyme, Me.colFFReceiveBalance, Me.colFFIssueBalance, Me.colGFReceiveBalance, Me.colGFIssueBalance, Me.colDLBatchNo, Me.colShade, Me.colSoftner, Me.colQADStatus, Me.colFirstLDSenttoFloorDate, Me.colLastLDSenttoFloorDate})
        Me.BandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1064, 400, 266, 208)
        Me.BandedGridView1.DetailHeight = 284
        Me.BandedGridView1.GridControl = Me.SampleRequestStatusGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFirstLDSenttoFloorDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "Sample Arkwork-Program-Style-Buyer"
        Me.gridBand3.Columns.Add(Me.colPicture)
        Me.gridBand3.Columns.Add(Me.colBuyer)
        Me.gridBand3.Columns.Add(Me.colStyle)
        Me.gridBand3.Columns.Add(Me.colRequestNo)
        Me.gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 0
        Me.gridBand3.Width = 309
        '
        'colPicture
        '
        Me.colPicture.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPicture.AppearanceCell.Options.UseBackColor = True
        Me.colPicture.AppearanceHeader.Options.UseTextOptions = True
        Me.colPicture.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPicture.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPicture.Caption = "Artwork"
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.MinWidth = 19
        Me.colPicture.Name = "colPicture"
        Me.colPicture.OptionsColumn.AllowEdit = False
        Me.colPicture.Visible = True
        Me.colPicture.Width = 52
        '
        'colBuyer
        '
        Me.colBuyer.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBuyer.AppearanceCell.Options.UseBackColor = True
        Me.colBuyer.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuyer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuyer.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBuyer.Caption = "Buyer"
        Me.colBuyer.ColumnEdit = Me.RepositoryItemMemoEdit46
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.MinWidth = 19
        Me.colBuyer.Name = "colBuyer"
        Me.colBuyer.OptionsColumn.AllowEdit = False
        Me.colBuyer.Visible = True
        Me.colBuyer.Width = 80
        '
        'RepositoryItemMemoEdit46
        '
        Me.RepositoryItemMemoEdit46.Name = "RepositoryItemMemoEdit46"
        '
        'colStyle
        '
        Me.colStyle.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyle.AppearanceCell.Options.UseBackColor = True
        Me.colStyle.AppearanceCell.Options.UseTextOptions = True
        Me.colStyle.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyle.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyle.Caption = "Style"
        Me.colStyle.ColumnEdit = Me.RepositoryItemMemoEdit28
        Me.colStyle.FieldName = "Style"
        Me.colStyle.MinWidth = 19
        Me.colStyle.Name = "colStyle"
        Me.colStyle.OptionsColumn.AllowEdit = False
        Me.colStyle.Visible = True
        Me.colStyle.Width = 96
        '
        'RepositoryItemMemoEdit28
        '
        Me.RepositoryItemMemoEdit28.Name = "RepositoryItemMemoEdit28"
        '
        'colRequestNo
        '
        Me.colRequestNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colRequestNo.AppearanceCell.Options.UseBackColor = True
        Me.colRequestNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequestNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequestNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequestNo.Caption = "Sample Program No"
        Me.colRequestNo.FieldName = "RequestNo"
        Me.colRequestNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colRequestNo.MinWidth = 19
        Me.colRequestNo.Name = "colRequestNo"
        Me.colRequestNo.OptionsColumn.AllowEdit = False
        Me.colRequestNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colRequestNo.OptionsFilter.AllowFilter = False
        Me.colRequestNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RequestNo", "{0}")})
        Me.colRequestNo.Visible = True
        Me.colRequestNo.Width = 81
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Merchandiser Department"
        Me.GridBand1.Columns.Add(Me.colRequestDate)
        Me.GridBand1.Columns.Add(Me.colDivision)
        Me.GridBand1.Columns.Add(Me.colSeason)
        Me.GridBand1.Columns.Add(Me.colBrand)
        Me.GridBand1.Columns.Add(Me.colFileReceiveDate)
        Me.GridBand1.Columns.Add(Me.colFileReceiveDetails)
        Me.GridBand1.Columns.Add(Me.colSampleRequireDate)
        Me.GridBand1.Columns.Add(Me.colFabricRequireDate)
        Me.GridBand1.Columns.Add(Me.colFabricBookingDate)
        Me.GridBand1.Columns.Add(Me.colSampleFabricBookingRemarks)
        Me.GridBand1.Columns.Add(Me.colIsBookingComplete)
        Me.GridBand1.Columns.Add(Me.colRevisedNo)
        Me.GridBand1.Columns.Add(Me.colRevisedDate)
        Me.GridBand1.Columns.Add(Me.colCauseOfRevised)
        Me.GridBand1.Columns.Add(Me.colAttention)
        Me.GridBand1.Columns.Add(Me.colCC)
        Me.GridBand1.Columns.Add(Me.colIsReceivedByDyeing)
        Me.GridBand1.Columns.Add(Me.colStyleType)
        Me.GridBand1.Columns.Add(Me.colGarmentsDescription)
        Me.GridBand1.Columns.Add(Me.colIsPrint)
        Me.GridBand1.Columns.Add(Me.colPrintType)
        Me.GridBand1.Columns.Add(Me.colIsSublimation)
        Me.GridBand1.Columns.Add(Me.colIsEmbroidery)
        Me.GridBand1.Columns.Add(Me.colIsSequence)
        Me.GridBand1.Columns.Add(Me.colEmbroideryDetails)
        Me.GridBand1.Columns.Add(Me.colIsAOP)
        Me.GridBand1.Columns.Add(Me.colIsYds)
        Me.GridBand1.Columns.Add(Me.colIsWash)
        Me.GridBand1.Columns.Add(Me.colWashType)
        Me.GridBand1.Columns.Add(Me.colIsBrush)
        Me.GridBand1.Columns.Add(Me.colIsPeachFinish)
        Me.GridBand1.Columns.Add(Me.colIsTrim)
        Me.GridBand1.Columns.Add(Me.colTrimDetails)
        Me.GridBand1.Columns.Add(Me.colIsTrimAvailable)
        Me.GridBand1.Columns.Add(Me.colExTrimRcvDate)
        Me.GridBand1.Columns.Add(Me.colAccReceiveDate)
        Me.GridBand1.Columns.Add(Me.colAccReceiveDetails)
        Me.GridBand1.Columns.Add(Me.colIsFabricAvailable)
        Me.GridBand1.Columns.Add(Me.colExFabricRcvDate)
        Me.GridBand1.Columns.Add(Me.colNLD)
        Me.GridBand1.Columns.Add(Me.colFabricColorName)
        Me.GridBand1.Columns.Add(Me.colGSM)
        Me.GridBand1.Columns.Add(Me.colFabricDetails)
        Me.GridBand1.Columns.Add(Me.colKnittingType)
        Me.GridBand1.Columns.Add(Me.colComposition)
        Me.GridBand1.Columns.Add(Me.colDevType)
        Me.GridBand1.Columns.Add(Me.colSize)
        Me.GridBand1.Columns.Add(Me.colSampleQuantity)
        Me.GridBand1.Columns.Add(Me.colFinishQuantity)
        Me.GridBand1.Columns.Add(Me.colGreyQuantity)
        Me.GridBand1.Columns.Add(Me.colFirstChallanDate)
        Me.GridBand1.Columns.Add(Me.colLastChallanDate)
        Me.GridBand1.Columns.Add(Me.colFFDeliveryQuantity)
        Me.GridBand1.Columns.Add(Me.colSampleCuttingStartDate)
        Me.GridBand1.Columns.Add(Me.colSampleCuttingEndDate)
        Me.GridBand1.Columns.Add(Me.colSamplePrintSendDate)
        Me.GridBand1.Columns.Add(Me.colSamplePrintSendQty)
        Me.GridBand1.Columns.Add(Me.colsamplePrintReceiveDate)
        Me.GridBand1.Columns.Add(Me.colSamplePrintReceiveQty)
        Me.GridBand1.Columns.Add(Me.colSampleEmbSendDate)
        Me.GridBand1.Columns.Add(Me.colSampleEmbSendQty)
        Me.GridBand1.Columns.Add(Me.colSampleEmbReceiveDate)
        Me.GridBand1.Columns.Add(Me.colSampleEmbReceiveQty)
        Me.GridBand1.Columns.Add(Me.colSampleSewingStartDate)
        Me.GridBand1.Columns.Add(Me.colSampleSewingEndDate)
        Me.GridBand1.Columns.Add(Me.colSampleStatus)
        Me.GridBand1.Columns.Add(Me.colStatusRemarks)
        Me.GridBand1.Columns.Add(Me.colCommentsReceiveDate)
        Me.GridBand1.Columns.Add(Me.colSampleExDeliveryDate)
        Me.GridBand1.Columns.Add(Me.colSampleSendDate)
        Me.GridBand1.Columns.Add(Me.colSendingInfo)
        Me.GridBand1.Columns.Add(Me.colFirstSampleDeliveryDate)
        Me.GridBand1.Columns.Add(Me.colLastSampleDeliveryDate)
        Me.GridBand1.Columns.Add(Me.colSampleDeliveryQuantity2)
        Me.GridBand1.Columns.Add(Me.colGatePassType)
        Me.GridBand1.Columns.Add(Me.colApprovalStatus)
        Me.GridBand1.Columns.Add(Me.colIsComplete)
        Me.GridBand1.Columns.Add(Me.colCompletedOn)
        Me.GridBand1.Columns.Add(Me.colRemarks)
        Me.GridBand1.Columns.Add(Me.colSamplePreparedBy)
        Me.GridBand1.Columns.Add(Me.colProgramNo)
        Me.GridBand1.Columns.Add(Me.colMerchandiser)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 1
        Me.GridBand1.Width = 5521
        '
        'colRequestDate
        '
        Me.colRequestDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequestDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequestDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequestDate.Caption = "Sample Program Date"
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.MinWidth = 19
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.OptionsColumn.AllowEdit = False
        Me.colRequestDate.Visible = True
        Me.colRequestDate.Width = 77
        '
        'colDivision
        '
        Me.colDivision.AppearanceHeader.Options.UseTextOptions = True
        Me.colDivision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDivision.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDivision.Caption = "Division"
        Me.colDivision.FieldName = "Division"
        Me.colDivision.Name = "colDivision"
        Me.colDivision.OptionsColumn.AllowEdit = False
        Me.colDivision.Visible = True
        Me.colDivision.Width = 52
        '
        'colSeason
        '
        Me.colSeason.AppearanceHeader.Options.UseTextOptions = True
        Me.colSeason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSeason.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSeason.Caption = "Season"
        Me.colSeason.FieldName = "Season"
        Me.colSeason.Name = "colSeason"
        Me.colSeason.OptionsColumn.AllowEdit = False
        Me.colSeason.Visible = True
        Me.colSeason.Width = 53
        '
        'colBrand
        '
        Me.colBrand.AppearanceHeader.Options.UseTextOptions = True
        Me.colBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBrand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBrand.Caption = "Brand/Group"
        Me.colBrand.ColumnEdit = Me.RepositoryItemMemoEdit29
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.OptionsColumn.AllowEdit = False
        Me.colBrand.Visible = True
        Me.colBrand.Width = 71
        '
        'RepositoryItemMemoEdit29
        '
        Me.RepositoryItemMemoEdit29.Name = "RepositoryItemMemoEdit29"
        '
        'colFileReceiveDate
        '
        Me.colFileReceiveDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colFileReceiveDate.AppearanceHeader.Options.UseBackColor = True
        Me.colFileReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFileReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFileReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFileReceiveDate.Caption = "File Receive Date"
        Me.colFileReceiveDate.FieldName = "FileReceiveDate"
        Me.colFileReceiveDate.MinWidth = 19
        Me.colFileReceiveDate.Name = "colFileReceiveDate"
        Me.colFileReceiveDate.Visible = True
        Me.colFileReceiveDate.Width = 66
        '
        'colFileReceiveDetails
        '
        Me.colFileReceiveDetails.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colFileReceiveDetails.AppearanceHeader.Options.UseBackColor = True
        Me.colFileReceiveDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colFileReceiveDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFileReceiveDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFileReceiveDetails.Caption = "File Receive Details"
        Me.colFileReceiveDetails.ColumnEdit = Me.RepositoryItemMemoEdit19
        Me.colFileReceiveDetails.FieldName = "FileReceiveDetails"
        Me.colFileReceiveDetails.MinWidth = 19
        Me.colFileReceiveDetails.Name = "colFileReceiveDetails"
        Me.colFileReceiveDetails.Visible = True
        Me.colFileReceiveDetails.Width = 109
        '
        'RepositoryItemMemoEdit19
        '
        Me.RepositoryItemMemoEdit19.Name = "RepositoryItemMemoEdit19"
        '
        'colSampleRequireDate
        '
        Me.colSampleRequireDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleRequireDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleRequireDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleRequireDate.Caption = "Sample Require Date"
        Me.colSampleRequireDate.FieldName = "SampleRequireDate"
        Me.colSampleRequireDate.MinWidth = 19
        Me.colSampleRequireDate.Name = "colSampleRequireDate"
        Me.colSampleRequireDate.OptionsColumn.AllowEdit = False
        Me.colSampleRequireDate.Visible = True
        Me.colSampleRequireDate.Width = 71
        '
        'colFabricRequireDate
        '
        Me.colFabricRequireDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricRequireDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricRequireDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricRequireDate.Caption = "Fabric Require Date"
        Me.colFabricRequireDate.FieldName = "FabricRequireDate"
        Me.colFabricRequireDate.Name = "colFabricRequireDate"
        Me.colFabricRequireDate.OptionsColumn.AllowEdit = False
        Me.colFabricRequireDate.Visible = True
        Me.colFabricRequireDate.Width = 71
        '
        'colFabricBookingDate
        '
        Me.colFabricBookingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricBookingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricBookingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricBookingDate.Caption = "Sample Fabric Booking Date"
        Me.colFabricBookingDate.FieldName = "FabricBookingDate"
        Me.colFabricBookingDate.Name = "colFabricBookingDate"
        Me.colFabricBookingDate.OptionsColumn.AllowEdit = False
        Me.colFabricBookingDate.Visible = True
        '
        'colSampleFabricBookingRemarks
        '
        Me.colSampleFabricBookingRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleFabricBookingRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleFabricBookingRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleFabricBookingRemarks.Caption = "Sample Fabric Booking Remarks"
        Me.colSampleFabricBookingRemarks.ColumnEdit = Me.RepositoryItemMemoEdit25
        Me.colSampleFabricBookingRemarks.FieldName = "SampleFabricBookingRemarks"
        Me.colSampleFabricBookingRemarks.Name = "colSampleFabricBookingRemarks"
        Me.colSampleFabricBookingRemarks.OptionsColumn.AllowEdit = False
        Me.colSampleFabricBookingRemarks.Visible = True
        Me.colSampleFabricBookingRemarks.Width = 114
        '
        'RepositoryItemMemoEdit25
        '
        Me.RepositoryItemMemoEdit25.Name = "RepositoryItemMemoEdit25"
        '
        'colIsBookingComplete
        '
        Me.colIsBookingComplete.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsBookingComplete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsBookingComplete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsBookingComplete.Caption = "Sample Fabric Booking Complete"
        Me.colIsBookingComplete.FieldName = "IsBookingComplete"
        Me.colIsBookingComplete.Name = "colIsBookingComplete"
        Me.colIsBookingComplete.OptionsColumn.AllowEdit = False
        Me.colIsBookingComplete.Visible = True
        Me.colIsBookingComplete.Width = 93
        '
        'colRevisedNo
        '
        Me.colRevisedNo.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colRevisedNo.AppearanceCell.Options.UseBackColor = True
        Me.colRevisedNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colRevisedNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRevisedNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRevisedNo.Caption = "Revised No"
        Me.colRevisedNo.FieldName = "RevisedNo"
        Me.colRevisedNo.Name = "colRevisedNo"
        Me.colRevisedNo.OptionsColumn.AllowEdit = False
        Me.colRevisedNo.Visible = True
        Me.colRevisedNo.Width = 49
        '
        'colRevisedDate
        '
        Me.colRevisedDate.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colRevisedDate.AppearanceCell.Options.UseBackColor = True
        Me.colRevisedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colRevisedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRevisedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRevisedDate.Caption = "Revised Date"
        Me.colRevisedDate.FieldName = "RevisedDate"
        Me.colRevisedDate.Name = "colRevisedDate"
        Me.colRevisedDate.OptionsColumn.AllowEdit = False
        Me.colRevisedDate.Visible = True
        Me.colRevisedDate.Width = 51
        '
        'colCauseOfRevised
        '
        Me.colCauseOfRevised.AppearanceHeader.Options.UseTextOptions = True
        Me.colCauseOfRevised.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCauseOfRevised.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCauseOfRevised.Caption = "Cause Of Revised"
        Me.colCauseOfRevised.ColumnEdit = Me.RepositoryItemMemoEdit30
        Me.colCauseOfRevised.FieldName = "CauseOfRevised"
        Me.colCauseOfRevised.Name = "colCauseOfRevised"
        Me.colCauseOfRevised.OptionsColumn.AllowEdit = False
        Me.colCauseOfRevised.Visible = True
        Me.colCauseOfRevised.Width = 102
        '
        'RepositoryItemMemoEdit30
        '
        Me.RepositoryItemMemoEdit30.Name = "RepositoryItemMemoEdit30"
        '
        'colAttention
        '
        Me.colAttention.AppearanceHeader.Options.UseTextOptions = True
        Me.colAttention.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAttention.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAttention.Caption = "Attention"
        Me.colAttention.FieldName = "Attention"
        Me.colAttention.Name = "colAttention"
        Me.colAttention.OptionsColumn.AllowEdit = False
        Me.colAttention.Visible = True
        Me.colAttention.Width = 65
        '
        'colCC
        '
        Me.colCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCC.Caption = "CC"
        Me.colCC.FieldName = "CC"
        Me.colCC.Name = "colCC"
        Me.colCC.OptionsColumn.AllowEdit = False
        Me.colCC.Visible = True
        Me.colCC.Width = 66
        '
        'colIsReceivedByDyeing
        '
        Me.colIsReceivedByDyeing.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsReceivedByDyeing.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsReceivedByDyeing.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsReceivedByDyeing.Caption = "Is Receive By Dyeing"
        Me.colIsReceivedByDyeing.FieldName = "IsReceivedByDyeing"
        Me.colIsReceivedByDyeing.Name = "colIsReceivedByDyeing"
        Me.colIsReceivedByDyeing.OptionsColumn.AllowEdit = False
        Me.colIsReceivedByDyeing.Visible = True
        Me.colIsReceivedByDyeing.Width = 60
        '
        'colStyleType
        '
        Me.colStyleType.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleType.Caption = "Style Type"
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.MinWidth = 19
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.OptionsColumn.AllowEdit = False
        Me.colStyleType.Visible = True
        Me.colStyleType.Width = 68
        '
        'colGarmentsDescription
        '
        Me.colGarmentsDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsDescription.Caption = "Style Description"
        Me.colGarmentsDescription.ColumnEdit = Me.RepositoryItemMemoEdit31
        Me.colGarmentsDescription.FieldName = "GarmentsDescription"
        Me.colGarmentsDescription.MinWidth = 19
        Me.colGarmentsDescription.Name = "colGarmentsDescription"
        Me.colGarmentsDescription.OptionsColumn.AllowEdit = False
        Me.colGarmentsDescription.Visible = True
        Me.colGarmentsDescription.Width = 120
        '
        'RepositoryItemMemoEdit31
        '
        Me.RepositoryItemMemoEdit31.Name = "RepositoryItemMemoEdit31"
        '
        'colIsPrint
        '
        Me.colIsPrint.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsPrint.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.MinWidth = 19
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.OptionsColumn.AllowEdit = False
        Me.colIsPrint.Visible = True
        Me.colIsPrint.Width = 30
        '
        'colPrintType
        '
        Me.colPrintType.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintType.Caption = "Print Type"
        Me.colPrintType.FieldName = "PrintType"
        Me.colPrintType.Name = "colPrintType"
        Me.colPrintType.OptionsColumn.AllowEdit = False
        Me.colPrintType.Visible = True
        Me.colPrintType.Width = 54
        '
        'colIsSublimation
        '
        Me.colIsSublimation.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSublimation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSublimation.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSublimation.Caption = "Is Sublimation"
        Me.colIsSublimation.FieldName = "IsSublimation"
        Me.colIsSublimation.Name = "colIsSublimation"
        Me.colIsSublimation.OptionsColumn.AllowEdit = False
        Me.colIsSublimation.Visible = True
        Me.colIsSublimation.Width = 65
        '
        'colIsEmbroidery
        '
        Me.colIsEmbroidery.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsEmbroidery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsEmbroidery.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsEmbroidery.Caption = "Is Embroidery"
        Me.colIsEmbroidery.FieldName = "IsEmbroidery"
        Me.colIsEmbroidery.MinWidth = 19
        Me.colIsEmbroidery.Name = "colIsEmbroidery"
        Me.colIsEmbroidery.OptionsColumn.AllowEdit = False
        Me.colIsEmbroidery.Visible = True
        Me.colIsEmbroidery.Width = 62
        '
        'colIsSequence
        '
        Me.colIsSequence.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSequence.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSequence.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSequence.Caption = "Is Sequence"
        Me.colIsSequence.FieldName = "IsSequence"
        Me.colIsSequence.Name = "colIsSequence"
        Me.colIsSequence.OptionsColumn.AllowEdit = False
        Me.colIsSequence.Visible = True
        Me.colIsSequence.Width = 57
        '
        'colEmbroideryDetails
        '
        Me.colEmbroideryDetails.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colEmbroideryDetails.AppearanceHeader.Options.UseBackColor = True
        Me.colEmbroideryDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbroideryDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbroideryDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbroideryDetails.Caption = "Embroidery Details"
        Me.colEmbroideryDetails.ColumnEdit = Me.RepositoryItemMemoEdit20
        Me.colEmbroideryDetails.FieldName = "EmbroideryDetails"
        Me.colEmbroideryDetails.Name = "colEmbroideryDetails"
        Me.colEmbroideryDetails.Visible = True
        Me.colEmbroideryDetails.Width = 101
        '
        'RepositoryItemMemoEdit20
        '
        Me.RepositoryItemMemoEdit20.Name = "RepositoryItemMemoEdit20"
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAOP.Caption = "Is AOP"
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.MinWidth = 19
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.OptionsColumn.AllowEdit = False
        Me.colIsAOP.Visible = True
        Me.colIsAOP.Width = 30
        '
        'colIsYds
        '
        Me.colIsYds.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYds.Caption = "Is Yds"
        Me.colIsYds.FieldName = "IsYds"
        Me.colIsYds.MinWidth = 19
        Me.colIsYds.Name = "colIsYds"
        Me.colIsYds.OptionsColumn.AllowEdit = False
        Me.colIsYds.Visible = True
        Me.colIsYds.Width = 29
        '
        'colIsWash
        '
        Me.colIsWash.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsWash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsWash.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsWash.Caption = "Is Wash"
        Me.colIsWash.FieldName = "IsWash"
        Me.colIsWash.MinWidth = 19
        Me.colIsWash.Name = "colIsWash"
        Me.colIsWash.OptionsColumn.AllowEdit = False
        Me.colIsWash.Visible = True
        Me.colIsWash.Width = 38
        '
        'colWashType
        '
        Me.colWashType.AppearanceHeader.Options.UseTextOptions = True
        Me.colWashType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWashType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWashType.Caption = "Wash Type"
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.OptionsColumn.AllowEdit = False
        Me.colWashType.Visible = True
        Me.colWashType.Width = 48
        '
        'colIsBrush
        '
        Me.colIsBrush.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsBrush.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsBrush.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsBrush.Caption = "Is Brush"
        Me.colIsBrush.FieldName = "IsBrush"
        Me.colIsBrush.MinWidth = 19
        Me.colIsBrush.Name = "colIsBrush"
        Me.colIsBrush.OptionsColumn.AllowEdit = False
        Me.colIsBrush.Visible = True
        Me.colIsBrush.Width = 38
        '
        'colIsPeachFinish
        '
        Me.colIsPeachFinish.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsPeachFinish.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsPeachFinish.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsPeachFinish.Caption = "Is Peach Finish"
        Me.colIsPeachFinish.FieldName = "IsPeachFinish"
        Me.colIsPeachFinish.MinWidth = 19
        Me.colIsPeachFinish.Name = "colIsPeachFinish"
        Me.colIsPeachFinish.OptionsColumn.AllowEdit = False
        Me.colIsPeachFinish.Visible = True
        Me.colIsPeachFinish.Width = 53
        '
        'colIsTrim
        '
        Me.colIsTrim.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsTrim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsTrim.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsTrim.Caption = "Is Trim"
        Me.colIsTrim.FieldName = "IsTrim"
        Me.colIsTrim.MinWidth = 19
        Me.colIsTrim.Name = "colIsTrim"
        Me.colIsTrim.OptionsColumn.AllowEdit = False
        Me.colIsTrim.Visible = True
        Me.colIsTrim.Width = 28
        '
        'colTrimDetails
        '
        Me.colTrimDetails.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colTrimDetails.AppearanceHeader.Options.UseBackColor = True
        Me.colTrimDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colTrimDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTrimDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTrimDetails.Caption = "Trim Details"
        Me.colTrimDetails.ColumnEdit = Me.RepositoryItemMemoEdit21
        Me.colTrimDetails.FieldName = "TrimDetails"
        Me.colTrimDetails.Name = "colTrimDetails"
        Me.colTrimDetails.Visible = True
        Me.colTrimDetails.Width = 71
        '
        'RepositoryItemMemoEdit21
        '
        Me.RepositoryItemMemoEdit21.Name = "RepositoryItemMemoEdit21"
        '
        'colIsTrimAvailable
        '
        Me.colIsTrimAvailable.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colIsTrimAvailable.AppearanceHeader.Options.UseBackColor = True
        Me.colIsTrimAvailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsTrimAvailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsTrimAvailable.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsTrimAvailable.Caption = "Is Trim Available"
        Me.colIsTrimAvailable.FieldName = "IsTrimAvailable"
        Me.colIsTrimAvailable.MinWidth = 19
        Me.colIsTrimAvailable.Name = "colIsTrimAvailable"
        Me.colIsTrimAvailable.Visible = True
        Me.colIsTrimAvailable.Width = 51
        '
        'colExTrimRcvDate
        '
        Me.colExTrimRcvDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colExTrimRcvDate.AppearanceHeader.Options.UseBackColor = True
        Me.colExTrimRcvDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExTrimRcvDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExTrimRcvDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExTrimRcvDate.Caption = "Ex Trim Rcv Date"
        Me.colExTrimRcvDate.FieldName = "ExTrimRcvDate"
        Me.colExTrimRcvDate.MinWidth = 19
        Me.colExTrimRcvDate.Name = "colExTrimRcvDate"
        Me.colExTrimRcvDate.Visible = True
        Me.colExTrimRcvDate.Width = 56
        '
        'colAccReceiveDate
        '
        Me.colAccReceiveDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colAccReceiveDate.AppearanceHeader.Options.UseBackColor = True
        Me.colAccReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccReceiveDate.Caption = "Acc Receive Date"
        Me.colAccReceiveDate.FieldName = "AccReceiveDate"
        Me.colAccReceiveDate.MinWidth = 19
        Me.colAccReceiveDate.Name = "colAccReceiveDate"
        Me.colAccReceiveDate.Visible = True
        Me.colAccReceiveDate.Width = 66
        '
        'colAccReceiveDetails
        '
        Me.colAccReceiveDetails.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colAccReceiveDetails.AppearanceHeader.Options.UseBackColor = True
        Me.colAccReceiveDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccReceiveDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccReceiveDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccReceiveDetails.Caption = "Acc Receive Details"
        Me.colAccReceiveDetails.ColumnEdit = Me.RepositoryItemMemoEdit22
        Me.colAccReceiveDetails.FieldName = "AccReceiveDetails"
        Me.colAccReceiveDetails.MinWidth = 19
        Me.colAccReceiveDetails.Name = "colAccReceiveDetails"
        Me.colAccReceiveDetails.Visible = True
        Me.colAccReceiveDetails.Width = 108
        '
        'RepositoryItemMemoEdit22
        '
        Me.RepositoryItemMemoEdit22.Name = "RepositoryItemMemoEdit22"
        '
        'colIsFabricAvailable
        '
        Me.colIsFabricAvailable.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colIsFabricAvailable.AppearanceHeader.Options.UseBackColor = True
        Me.colIsFabricAvailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsFabricAvailable.Caption = "Is Fabric Available"
        Me.colIsFabricAvailable.FieldName = "IsFabricAvailable"
        Me.colIsFabricAvailable.MinWidth = 19
        Me.colIsFabricAvailable.Name = "colIsFabricAvailable"
        Me.colIsFabricAvailable.Visible = True
        Me.colIsFabricAvailable.Width = 55
        '
        'colExFabricRcvDate
        '
        Me.colExFabricRcvDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colExFabricRcvDate.AppearanceHeader.Options.UseBackColor = True
        Me.colExFabricRcvDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExFabricRcvDate.Caption = "Ex Fabric Rcv Date"
        Me.colExFabricRcvDate.FieldName = "ExFabricRcvDate"
        Me.colExFabricRcvDate.MinWidth = 19
        Me.colExFabricRcvDate.Name = "colExFabricRcvDate"
        Me.colExFabricRcvDate.Visible = True
        Me.colExFabricRcvDate.Width = 55
        '
        'colNLD
        '
        Me.colNLD.AppearanceHeader.Options.UseTextOptions = True
        Me.colNLD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNLD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNLD.Caption = "NLD No"
        Me.colNLD.FieldName = "NLD"
        Me.colNLD.Name = "colNLD"
        Me.colNLD.OptionsColumn.AllowEdit = False
        Me.colNLD.Visible = True
        Me.colNLD.Width = 60
        '
        'colFabricColorName
        '
        Me.colFabricColorName.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorName.Caption = "Garments Color"
        Me.colFabricColorName.ColumnEdit = Me.RepositoryItemMemoEdit47
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.OptionsColumn.AllowEdit = False
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.Width = 58
        '
        'RepositoryItemMemoEdit47
        '
        Me.RepositoryItemMemoEdit47.Name = "RepositoryItemMemoEdit47"
        '
        'colGSM
        '
        Me.colGSM.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSM.Caption = "GSM"
        Me.colGSM.ColumnEdit = Me.RepositoryItemMemoEdit48
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.MinWidth = 19
        Me.colGSM.Name = "colGSM"
        Me.colGSM.OptionsColumn.AllowEdit = False
        Me.colGSM.Visible = True
        Me.colGSM.Width = 41
        '
        'RepositoryItemMemoEdit48
        '
        Me.RepositoryItemMemoEdit48.Name = "RepositoryItemMemoEdit48"
        '
        'colFabricDetails
        '
        Me.colFabricDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricDetails.Caption = "Fabric Details"
        Me.colFabricDetails.ColumnEdit = Me.RepositoryItemMemoEdit23
        Me.colFabricDetails.FieldName = "FabricDetails"
        Me.colFabricDetails.Name = "colFabricDetails"
        Me.colFabricDetails.OptionsColumn.AllowEdit = False
        Me.colFabricDetails.Visible = True
        Me.colFabricDetails.Width = 81
        '
        'RepositoryItemMemoEdit23
        '
        Me.RepositoryItemMemoEdit23.Name = "RepositoryItemMemoEdit23"
        '
        'colKnittingType
        '
        Me.colKnittingType.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingType.Caption = "Knitting Type"
        Me.colKnittingType.ColumnEdit = Me.RepositoryItemMemoEdit33
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.OptionsColumn.AllowEdit = False
        Me.colKnittingType.Visible = True
        Me.colKnittingType.Width = 83
        '
        'RepositoryItemMemoEdit33
        '
        Me.RepositoryItemMemoEdit33.Name = "RepositoryItemMemoEdit33"
        '
        'colComposition
        '
        Me.colComposition.AppearanceHeader.Options.UseTextOptions = True
        Me.colComposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComposition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComposition.Caption = "Composition"
        Me.colComposition.ColumnEdit = Me.RepositoryItemMemoEdit34
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.OptionsColumn.AllowEdit = False
        Me.colComposition.Visible = True
        Me.colComposition.Width = 84
        '
        'RepositoryItemMemoEdit34
        '
        Me.RepositoryItemMemoEdit34.Name = "RepositoryItemMemoEdit34"
        '
        'colDevType
        '
        Me.colDevType.AppearanceHeader.Options.UseTextOptions = True
        Me.colDevType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDevType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDevType.Caption = "Sample Type"
        Me.colDevType.ColumnEdit = Me.RepositoryItemMemoEdit35
        Me.colDevType.FieldName = "DevType"
        Me.colDevType.MinWidth = 19
        Me.colDevType.Name = "colDevType"
        Me.colDevType.OptionsColumn.AllowEdit = False
        Me.colDevType.Visible = True
        Me.colDevType.Width = 88
        '
        'RepositoryItemMemoEdit35
        '
        Me.RepositoryItemMemoEdit35.Name = "RepositoryItemMemoEdit35"
        '
        'colSize
        '
        Me.colSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSize.Caption = "Sample Size"
        Me.colSize.ColumnEdit = Me.RepositoryItemMemoEdit36
        Me.colSize.FieldName = "Size"
        Me.colSize.Name = "colSize"
        Me.colSize.OptionsColumn.AllowEdit = False
        Me.colSize.Visible = True
        Me.colSize.Width = 51
        '
        'RepositoryItemMemoEdit36
        '
        Me.RepositoryItemMemoEdit36.Name = "RepositoryItemMemoEdit36"
        '
        'colSampleQuantity
        '
        Me.colSampleQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleQuantity.Caption = "Sample Qty"
        Me.colSampleQuantity.DisplayFormat.FormatString = "n0"
        Me.colSampleQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSampleQuantity.FieldName = "SampleQuantity"
        Me.colSampleQuantity.MinWidth = 19
        Me.colSampleQuantity.Name = "colSampleQuantity"
        Me.colSampleQuantity.OptionsColumn.AllowEdit = False
        Me.colSampleQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SampleQuantity", "{0:n0}")})
        Me.colSampleQuantity.Visible = True
        Me.colSampleQuantity.Width = 55
        '
        'colFinishQuantity
        '
        Me.colFinishQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishQuantity.Caption = "Finish Fabric Required Qty"
        Me.colFinishQuantity.DisplayFormat.FormatString = "n2"
        Me.colFinishQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFinishQuantity.FieldName = "FinishQuantity"
        Me.colFinishQuantity.Name = "colFinishQuantity"
        Me.colFinishQuantity.OptionsColumn.AllowEdit = False
        Me.colFinishQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FinishQuantity", "{0:n2}")})
        Me.colFinishQuantity.Visible = True
        Me.colFinishQuantity.Width = 73
        '
        'colGreyQuantity
        '
        Me.colGreyQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colGreyQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGreyQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGreyQuantity.Caption = "Grey Fabric Required Qty"
        Me.colGreyQuantity.DisplayFormat.FormatString = "n2"
        Me.colGreyQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colGreyQuantity.FieldName = "GreyQuantity"
        Me.colGreyQuantity.Name = "colGreyQuantity"
        Me.colGreyQuantity.OptionsColumn.AllowEdit = False
        Me.colGreyQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GreyQuantity", "{0:n2}")})
        Me.colGreyQuantity.Visible = True
        Me.colGreyQuantity.Width = 79
        '
        'colFirstChallanDate
        '
        Me.colFirstChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstChallanDate.Caption = "First FF Delivery Challan Date"
        Me.colFirstChallanDate.FieldName = "FirstChallanDate"
        Me.colFirstChallanDate.Name = "colFirstChallanDate"
        Me.colFirstChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstChallanDate.Visible = True
        Me.colFirstChallanDate.Width = 88
        '
        'colLastChallanDate
        '
        Me.colLastChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastChallanDate.Caption = "Last FF Delivery Challan Date"
        Me.colLastChallanDate.FieldName = "LastChallanDate"
        Me.colLastChallanDate.Name = "colLastChallanDate"
        Me.colLastChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastChallanDate.Visible = True
        Me.colLastChallanDate.Width = 88
        '
        'colFFDeliveryQuantity
        '
        Me.colFFDeliveryQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFDeliveryQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFDeliveryQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFDeliveryQuantity.Caption = "Finish Fabric Delivery Qty"
        Me.colFFDeliveryQuantity.DisplayFormat.FormatString = "n2"
        Me.colFFDeliveryQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFFDeliveryQuantity.FieldName = "FFDeliveryQuantity"
        Me.colFFDeliveryQuantity.Name = "colFFDeliveryQuantity"
        Me.colFFDeliveryQuantity.OptionsColumn.AllowEdit = False
        Me.colFFDeliveryQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FFDeliveryQuantity", "{0:n2}")})
        Me.colFFDeliveryQuantity.Visible = True
        Me.colFFDeliveryQuantity.Width = 74
        '
        'colSampleCuttingStartDate
        '
        Me.colSampleCuttingStartDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleCuttingStartDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleCuttingStartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleCuttingStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleCuttingStartDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleCuttingStartDate.Caption = "Cutting Start Date"
        Me.colSampleCuttingStartDate.FieldName = "SampleCuttingStartDate"
        Me.colSampleCuttingStartDate.MinWidth = 19
        Me.colSampleCuttingStartDate.Name = "colSampleCuttingStartDate"
        Me.colSampleCuttingStartDate.Visible = True
        Me.colSampleCuttingStartDate.Width = 60
        '
        'colSampleCuttingEndDate
        '
        Me.colSampleCuttingEndDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleCuttingEndDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleCuttingEndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleCuttingEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleCuttingEndDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleCuttingEndDate.Caption = "Cutting End Date"
        Me.colSampleCuttingEndDate.FieldName = "SampleCuttingEndDate"
        Me.colSampleCuttingEndDate.MinWidth = 19
        Me.colSampleCuttingEndDate.Name = "colSampleCuttingEndDate"
        Me.colSampleCuttingEndDate.Visible = True
        Me.colSampleCuttingEndDate.Width = 52
        '
        'colSamplePrintSendDate
        '
        Me.colSamplePrintSendDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSamplePrintSendDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSamplePrintSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSamplePrintSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSamplePrintSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSamplePrintSendDate.Caption = "Print Send Date"
        Me.colSamplePrintSendDate.FieldName = "SamplePrintSendDate"
        Me.colSamplePrintSendDate.Name = "colSamplePrintSendDate"
        Me.colSamplePrintSendDate.Visible = True
        Me.colSamplePrintSendDate.Width = 58
        '
        'colSamplePrintSendQty
        '
        Me.colSamplePrintSendQty.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSamplePrintSendQty.AppearanceHeader.Options.UseBackColor = True
        Me.colSamplePrintSendQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colSamplePrintSendQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSamplePrintSendQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSamplePrintSendQty.Caption = "Print Send Qty"
        Me.colSamplePrintSendQty.DisplayFormat.FormatString = "n0"
        Me.colSamplePrintSendQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSamplePrintSendQty.FieldName = "SamplePrintSendQty"
        Me.colSamplePrintSendQty.Name = "colSamplePrintSendQty"
        Me.colSamplePrintSendQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SamplePrintSendQty", "{0:n0}")})
        Me.colSamplePrintSendQty.Visible = True
        Me.colSamplePrintSendQty.Width = 56
        '
        'colsamplePrintReceiveDate
        '
        Me.colsamplePrintReceiveDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colsamplePrintReceiveDate.AppearanceHeader.Options.UseBackColor = True
        Me.colsamplePrintReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colsamplePrintReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsamplePrintReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colsamplePrintReceiveDate.Caption = "Print Rcv Date"
        Me.colsamplePrintReceiveDate.FieldName = "samplePrintReceiveDate"
        Me.colsamplePrintReceiveDate.Name = "colsamplePrintReceiveDate"
        Me.colsamplePrintReceiveDate.Visible = True
        Me.colsamplePrintReceiveDate.Width = 62
        '
        'colSamplePrintReceiveQty
        '
        Me.colSamplePrintReceiveQty.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSamplePrintReceiveQty.AppearanceHeader.Options.UseBackColor = True
        Me.colSamplePrintReceiveQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colSamplePrintReceiveQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSamplePrintReceiveQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSamplePrintReceiveQty.Caption = "Print Rcv Qty"
        Me.colSamplePrintReceiveQty.DisplayFormat.FormatString = "n0"
        Me.colSamplePrintReceiveQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSamplePrintReceiveQty.FieldName = "SamplePrintReceiveQty"
        Me.colSamplePrintReceiveQty.Name = "colSamplePrintReceiveQty"
        Me.colSamplePrintReceiveQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SamplePrintReceiveQty", "{0:n0}")})
        Me.colSamplePrintReceiveQty.Visible = True
        Me.colSamplePrintReceiveQty.Width = 61
        '
        'colSampleEmbSendDate
        '
        Me.colSampleEmbSendDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleEmbSendDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleEmbSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleEmbSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleEmbSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleEmbSendDate.Caption = "Embroidery Send Date"
        Me.colSampleEmbSendDate.FieldName = "SampleEmbSendDate"
        Me.colSampleEmbSendDate.Name = "colSampleEmbSendDate"
        Me.colSampleEmbSendDate.Visible = True
        Me.colSampleEmbSendDate.Width = 62
        '
        'colSampleEmbSendQty
        '
        Me.colSampleEmbSendQty.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleEmbSendQty.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleEmbSendQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleEmbSendQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleEmbSendQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleEmbSendQty.Caption = "Embroidery Send Qty"
        Me.colSampleEmbSendQty.DisplayFormat.FormatString = "n0"
        Me.colSampleEmbSendQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSampleEmbSendQty.FieldName = "SampleEmbSendQty"
        Me.colSampleEmbSendQty.Name = "colSampleEmbSendQty"
        Me.colSampleEmbSendQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SampleEmbSendQty", "{0:n0}")})
        Me.colSampleEmbSendQty.Visible = True
        Me.colSampleEmbSendQty.Width = 62
        '
        'colSampleEmbReceiveDate
        '
        Me.colSampleEmbReceiveDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleEmbReceiveDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleEmbReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleEmbReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleEmbReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleEmbReceiveDate.Caption = "Embroidery Rcv Date"
        Me.colSampleEmbReceiveDate.FieldName = "SampleEmbReceiveDate"
        Me.colSampleEmbReceiveDate.Name = "colSampleEmbReceiveDate"
        Me.colSampleEmbReceiveDate.Visible = True
        Me.colSampleEmbReceiveDate.Width = 63
        '
        'colSampleEmbReceiveQty
        '
        Me.colSampleEmbReceiveQty.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleEmbReceiveQty.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleEmbReceiveQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleEmbReceiveQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleEmbReceiveQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleEmbReceiveQty.Caption = "Embroidery Rcv Qty"
        Me.colSampleEmbReceiveQty.DisplayFormat.FormatString = "n0"
        Me.colSampleEmbReceiveQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSampleEmbReceiveQty.FieldName = "SampleEmbReceiveQty"
        Me.colSampleEmbReceiveQty.Name = "colSampleEmbReceiveQty"
        Me.colSampleEmbReceiveQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SampleEmbReceiveQty", "{0:n0}")})
        Me.colSampleEmbReceiveQty.Visible = True
        Me.colSampleEmbReceiveQty.Width = 62
        '
        'colSampleSewingStartDate
        '
        Me.colSampleSewingStartDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleSewingStartDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleSewingStartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleSewingStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleSewingStartDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleSewingStartDate.Caption = "Sewing Start Date"
        Me.colSampleSewingStartDate.FieldName = "SampleSewingStartDate"
        Me.colSampleSewingStartDate.MinWidth = 19
        Me.colSampleSewingStartDate.Name = "colSampleSewingStartDate"
        Me.colSampleSewingStartDate.Visible = True
        Me.colSampleSewingStartDate.Width = 57
        '
        'colSampleSewingEndDate
        '
        Me.colSampleSewingEndDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleSewingEndDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleSewingEndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleSewingEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleSewingEndDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleSewingEndDate.Caption = "Sewing End Date"
        Me.colSampleSewingEndDate.FieldName = "SampleSewingEndDate"
        Me.colSampleSewingEndDate.MinWidth = 19
        Me.colSampleSewingEndDate.Name = "colSampleSewingEndDate"
        Me.colSampleSewingEndDate.Visible = True
        Me.colSampleSewingEndDate.Width = 53
        '
        'colSampleStatus
        '
        Me.colSampleStatus.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleStatus.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleStatus.Caption = "Sample Status"
        Me.colSampleStatus.ColumnEdit = Me.RepositoryItemMemoEdit37
        Me.colSampleStatus.FieldName = "SampleStatus"
        Me.colSampleStatus.MinWidth = 19
        Me.colSampleStatus.Name = "colSampleStatus"
        Me.colSampleStatus.Visible = True
        Me.colSampleStatus.Width = 76
        '
        'RepositoryItemMemoEdit37
        '
        Me.RepositoryItemMemoEdit37.Name = "RepositoryItemMemoEdit37"
        '
        'colStatusRemarks
        '
        Me.colStatusRemarks.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colStatusRemarks.AppearanceHeader.Options.UseBackColor = True
        Me.colStatusRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colStatusRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatusRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStatusRemarks.Caption = "Comments Status"
        Me.colStatusRemarks.ColumnEdit = Me.RepositoryItemMemoEdit26
        Me.colStatusRemarks.FieldName = "StatusRemarks"
        Me.colStatusRemarks.Name = "colStatusRemarks"
        Me.colStatusRemarks.Visible = True
        Me.colStatusRemarks.Width = 93
        '
        'RepositoryItemMemoEdit26
        '
        Me.RepositoryItemMemoEdit26.Name = "RepositoryItemMemoEdit26"
        '
        'colCommentsReceiveDate
        '
        Me.colCommentsReceiveDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colCommentsReceiveDate.AppearanceHeader.Options.UseBackColor = True
        Me.colCommentsReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colCommentsReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCommentsReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCommentsReceiveDate.Caption = "Comments Rcv Date"
        Me.colCommentsReceiveDate.FieldName = "CommentsReceiveDate"
        Me.colCommentsReceiveDate.MinWidth = 19
        Me.colCommentsReceiveDate.Name = "colCommentsReceiveDate"
        Me.colCommentsReceiveDate.Visible = True
        Me.colCommentsReceiveDate.Width = 66
        '
        'colSampleExDeliveryDate
        '
        Me.colSampleExDeliveryDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleExDeliveryDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleExDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleExDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleExDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleExDeliveryDate.Caption = "Sample Ex Send Date"
        Me.colSampleExDeliveryDate.FieldName = "SampleExDeliveryDate"
        Me.colSampleExDeliveryDate.Name = "colSampleExDeliveryDate"
        Me.colSampleExDeliveryDate.Visible = True
        Me.colSampleExDeliveryDate.Width = 71
        '
        'colSampleSendDate
        '
        Me.colSampleSendDate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSampleSendDate.AppearanceHeader.Options.UseBackColor = True
        Me.colSampleSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleSendDate.Caption = "Sample Send Date"
        Me.colSampleSendDate.FieldName = "SampleSendDate"
        Me.colSampleSendDate.Name = "colSampleSendDate"
        Me.colSampleSendDate.Visible = True
        Me.colSampleSendDate.Width = 60
        '
        'colSendingInfo
        '
        Me.colSendingInfo.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSendingInfo.AppearanceHeader.Options.UseBackColor = True
        Me.colSendingInfo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSendingInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSendingInfo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSendingInfo.Caption = "Sample Sending Info"
        Me.colSendingInfo.ColumnEdit = Me.RepositoryItemMemoEdit38
        Me.colSendingInfo.FieldName = "SendingInfo"
        Me.colSendingInfo.Name = "colSendingInfo"
        Me.colSendingInfo.Visible = True
        Me.colSendingInfo.Width = 84
        '
        'RepositoryItemMemoEdit38
        '
        Me.RepositoryItemMemoEdit38.Name = "RepositoryItemMemoEdit38"
        '
        'colFirstSampleDeliveryDate
        '
        Me.colFirstSampleDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstSampleDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstSampleDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstSampleDeliveryDate.Caption = "First Sample Delivery Date"
        Me.colFirstSampleDeliveryDate.FieldName = "FirstSampleDeliveryDate"
        Me.colFirstSampleDeliveryDate.Name = "colFirstSampleDeliveryDate"
        Me.colFirstSampleDeliveryDate.OptionsColumn.AllowEdit = False
        Me.colFirstSampleDeliveryDate.Visible = True
        '
        'colLastSampleDeliveryDate
        '
        Me.colLastSampleDeliveryDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastSampleDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastSampleDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastSampleDeliveryDate.Caption = "Last Sample Delivery Date"
        Me.colLastSampleDeliveryDate.FieldName = "LastSampleDeliveryDate"
        Me.colLastSampleDeliveryDate.Name = "colLastSampleDeliveryDate"
        Me.colLastSampleDeliveryDate.OptionsColumn.AllowEdit = False
        Me.colLastSampleDeliveryDate.Visible = True
        Me.colLastSampleDeliveryDate.Width = 79
        '
        'colSampleDeliveryQuantity2
        '
        Me.colSampleDeliveryQuantity2.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleDeliveryQuantity2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleDeliveryQuantity2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleDeliveryQuantity2.Caption = "Sample Delivery Qty"
        Me.colSampleDeliveryQuantity2.DisplayFormat.FormatString = "n0"
        Me.colSampleDeliveryQuantity2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSampleDeliveryQuantity2.FieldName = "SampleDeliveryQuantity2"
        Me.colSampleDeliveryQuantity2.Name = "colSampleDeliveryQuantity2"
        Me.colSampleDeliveryQuantity2.OptionsColumn.AllowEdit = False
        Me.colSampleDeliveryQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SampleDeliveryQuantity2", "{0:n0}")})
        Me.colSampleDeliveryQuantity2.Visible = True
        Me.colSampleDeliveryQuantity2.Width = 68
        '
        'colGatePassType
        '
        Me.colGatePassType.AppearanceHeader.Options.UseTextOptions = True
        Me.colGatePassType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGatePassType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGatePassType.Caption = "Sample Gate Pass Type"
        Me.colGatePassType.ColumnEdit = Me.RepositoryItemMemoEdit41
        Me.colGatePassType.FieldName = "GatePassType"
        Me.colGatePassType.Name = "colGatePassType"
        Me.colGatePassType.OptionsColumn.AllowEdit = False
        Me.colGatePassType.Visible = True
        Me.colGatePassType.Width = 79
        '
        'RepositoryItemMemoEdit41
        '
        Me.RepositoryItemMemoEdit41.Name = "RepositoryItemMemoEdit41"
        '
        'colApprovalStatus
        '
        Me.colApprovalStatus.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colApprovalStatus.AppearanceHeader.Options.UseBackColor = True
        Me.colApprovalStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovalStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovalStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovalStatus.Caption = "Approval Status"
        Me.colApprovalStatus.ColumnEdit = Me.RepositoryItemMemoEdit39
        Me.colApprovalStatus.FieldName = "ApprovalStatus"
        Me.colApprovalStatus.Name = "colApprovalStatus"
        Me.colApprovalStatus.Visible = True
        Me.colApprovalStatus.Width = 73
        '
        'RepositoryItemMemoEdit39
        '
        Me.RepositoryItemMemoEdit39.Name = "RepositoryItemMemoEdit39"
        '
        'colIsComplete
        '
        Me.colIsComplete.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colIsComplete.AppearanceHeader.Options.UseBackColor = True
        Me.colIsComplete.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsComplete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsComplete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsComplete.Caption = "Is Sample Close"
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.MinWidth = 19
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.Visible = True
        Me.colIsComplete.Width = 54
        '
        'colCompletedOn
        '
        Me.colCompletedOn.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colCompletedOn.AppearanceHeader.Options.UseBackColor = True
        Me.colCompletedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompletedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompletedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompletedOn.Caption = "Sample Close Date"
        Me.colCompletedOn.FieldName = "CompletedOn"
        Me.colCompletedOn.MinWidth = 19
        Me.colCompletedOn.Name = "colCompletedOn"
        Me.colCompletedOn.OptionsColumn.AllowEdit = False
        Me.colCompletedOn.Visible = True
        Me.colCompletedOn.Width = 63
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colRemarks.AppearanceHeader.Options.UseBackColor = True
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.Caption = "Remarks"
        Me.colRemarks.ColumnEdit = Me.RepositoryItemMemoEdit27
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.MinWidth = 19
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.Width = 95
        '
        'RepositoryItemMemoEdit27
        '
        Me.RepositoryItemMemoEdit27.Name = "RepositoryItemMemoEdit27"
        '
        'colSamplePreparedBy
        '
        Me.colSamplePreparedBy.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colSamplePreparedBy.AppearanceHeader.Options.UseBackColor = True
        Me.colSamplePreparedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colSamplePreparedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSamplePreparedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSamplePreparedBy.Caption = "Sample Prepared By"
        Me.colSamplePreparedBy.ColumnEdit = Me.RepositoryItemMemoEdit40
        Me.colSamplePreparedBy.FieldName = "SamplePreparedBy"
        Me.colSamplePreparedBy.Name = "colSamplePreparedBy"
        Me.colSamplePreparedBy.Visible = True
        '
        'RepositoryItemMemoEdit40
        '
        Me.RepositoryItemMemoEdit40.Name = "RepositoryItemMemoEdit40"
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.ColumnEdit = Me.RepositoryItemMemoEdit45
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.Visible = True
        Me.colProgramNo.Width = 74
        '
        'RepositoryItemMemoEdit45
        '
        Me.RepositoryItemMemoEdit45.Name = "RepositoryItemMemoEdit45"
        '
        'colMerchandiser
        '
        Me.colMerchandiser.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colMerchandiser.AppearanceCell.Options.UseBackColor = True
        Me.colMerchandiser.AppearanceHeader.Options.UseTextOptions = True
        Me.colMerchandiser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMerchandiser.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMerchandiser.Caption = "Merchandiser"
        Me.colMerchandiser.FieldName = "Merchandiser"
        Me.colMerchandiser.Name = "colMerchandiser"
        Me.colMerchandiser.OptionsColumn.AllowEdit = False
        Me.colMerchandiser.Visible = True
        Me.colMerchandiser.Width = 97
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "R&D Department"
        Me.gridBand2.Columns.Add(Me.colGreyQuantity1)
        Me.gridBand2.Columns.Add(Me.colFirstYarnRequisitonDate)
        Me.gridBand2.Columns.Add(Me.colLastYarnRequisitonDate)
        Me.gridBand2.Columns.Add(Me.colYarnRequisitonNo)
        Me.gridBand2.Columns.Add(Me.colYarnIssueQuantity)
        Me.gridBand2.Columns.Add(Me.colYarnIssueBalance)
        Me.gridBand2.Columns.Add(Me.colYarnDelChallanNo)
        Me.gridBand2.Columns.Add(Me.colFirstYarnDelChallanDate)
        Me.gridBand2.Columns.Add(Me.colLastYarnDelChallanDate)
        Me.gridBand2.Columns.Add(Me.colYarnName)
        Me.gridBand2.Columns.Add(Me.colYarnBrand)
        Me.gridBand2.Columns.Add(Me.colLotNo)
        Me.gridBand2.Columns.Add(Me.colStitchLength)
        Me.gridBand2.Columns.Add(Me.colMCDia)
        Me.gridBand2.Columns.Add(Me.colMCGauge)
        Me.gridBand2.Columns.Add(Me.colKnittingProduction)
        Me.gridBand2.Columns.Add(Me.colGFIDeliveryQty)
        Me.gridBand2.Columns.Add(Me.colGFIChallanNo)
        Me.gridBand2.Columns.Add(Me.colFirstGFIDate)
        Me.gridBand2.Columns.Add(Me.colLastGFIDate)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 1753
        '
        'colGreyQuantity1
        '
        Me.colGreyQuantity1.AppearanceHeader.Options.UseTextOptions = True
        Me.colGreyQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGreyQuantity1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGreyQuantity1.Caption = "Yarn Require Qty"
        Me.colGreyQuantity1.DisplayFormat.FormatString = "n2"
        Me.colGreyQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colGreyQuantity1.FieldName = "GreyQuantity"
        Me.colGreyQuantity1.Name = "colGreyQuantity1"
        Me.colGreyQuantity1.OptionsColumn.AllowEdit = False
        Me.colGreyQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GreyQuantity", "{0:n2}")})
        Me.colGreyQuantity1.Visible = True
        Me.colGreyQuantity1.Width = 70
        '
        'colFirstYarnRequisitonDate
        '
        Me.colFirstYarnRequisitonDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstYarnRequisitonDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstYarnRequisitonDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstYarnRequisitonDate.Caption = "First Yarn Requisition Date"
        Me.colFirstYarnRequisitonDate.FieldName = "FirstYarnRequisitonDate"
        Me.colFirstYarnRequisitonDate.Name = "colFirstYarnRequisitonDate"
        Me.colFirstYarnRequisitonDate.OptionsColumn.AllowEdit = False
        Me.colFirstYarnRequisitonDate.Visible = True
        Me.colFirstYarnRequisitonDate.Width = 92
        '
        'colLastYarnRequisitonDate
        '
        Me.colLastYarnRequisitonDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastYarnRequisitonDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastYarnRequisitonDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastYarnRequisitonDate.Caption = "Last Yarn Requisition Date"
        Me.colLastYarnRequisitonDate.FieldName = "LastYarnRequisitonDate"
        Me.colLastYarnRequisitonDate.Name = "colLastYarnRequisitonDate"
        Me.colLastYarnRequisitonDate.OptionsColumn.AllowEdit = False
        Me.colLastYarnRequisitonDate.Visible = True
        Me.colLastYarnRequisitonDate.Width = 89
        '
        'colYarnRequisitonNo
        '
        Me.colYarnRequisitonNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnRequisitonNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnRequisitonNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnRequisitonNo.Caption = "Yarn Requisition No"
        Me.colYarnRequisitonNo.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.colYarnRequisitonNo.FieldName = "YarnRequisitonNo"
        Me.colYarnRequisitonNo.Name = "colYarnRequisitonNo"
        Me.colYarnRequisitonNo.OptionsColumn.AllowEdit = False
        Me.colYarnRequisitonNo.Visible = True
        Me.colYarnRequisitonNo.Width = 106
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'colYarnIssueQuantity
        '
        Me.colYarnIssueQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnIssueQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnIssueQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnIssueQuantity.Caption = "Yarn Issue Qty"
        Me.colYarnIssueQuantity.DisplayFormat.FormatString = "n2"
        Me.colYarnIssueQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colYarnIssueQuantity.FieldName = "YarnIssueQuantity"
        Me.colYarnIssueQuantity.Name = "colYarnIssueQuantity"
        Me.colYarnIssueQuantity.OptionsColumn.AllowEdit = False
        Me.colYarnIssueQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YarnIssueQuantity", "{0:n2}")})
        Me.colYarnIssueQuantity.Visible = True
        Me.colYarnIssueQuantity.Width = 74
        '
        'colYarnIssueBalance
        '
        Me.colYarnIssueBalance.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colYarnIssueBalance.AppearanceCell.Options.UseBackColor = True
        Me.colYarnIssueBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnIssueBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnIssueBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnIssueBalance.Caption = "Yarn Issue Bal Qty"
        Me.colYarnIssueBalance.DisplayFormat.FormatString = "n2"
        Me.colYarnIssueBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colYarnIssueBalance.FieldName = "YarnIssueBalance"
        Me.colYarnIssueBalance.Name = "colYarnIssueBalance"
        Me.colYarnIssueBalance.OptionsColumn.AllowEdit = False
        Me.colYarnIssueBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YarnIssueBalance", "{0:n2}")})
        Me.colYarnIssueBalance.Visible = True
        '
        'colYarnDelChallanNo
        '
        Me.colYarnDelChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnDelChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnDelChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnDelChallanNo.Caption = "Yarn Delivery Challan No"
        Me.colYarnDelChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit5
        Me.colYarnDelChallanNo.FieldName = "YarnDelChallanNo"
        Me.colYarnDelChallanNo.Name = "colYarnDelChallanNo"
        Me.colYarnDelChallanNo.OptionsColumn.AllowEdit = False
        Me.colYarnDelChallanNo.Visible = True
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        '
        'colFirstYarnDelChallanDate
        '
        Me.colFirstYarnDelChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstYarnDelChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstYarnDelChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstYarnDelChallanDate.Caption = "First Yarn Delivery Challan Date"
        Me.colFirstYarnDelChallanDate.FieldName = "FirstYarnDelChallanDate"
        Me.colFirstYarnDelChallanDate.Name = "colFirstYarnDelChallanDate"
        Me.colFirstYarnDelChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstYarnDelChallanDate.Visible = True
        Me.colFirstYarnDelChallanDate.Width = 99
        '
        'colLastYarnDelChallanDate
        '
        Me.colLastYarnDelChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastYarnDelChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastYarnDelChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastYarnDelChallanDate.Caption = "Last Yarn Delivery Challan Date"
        Me.colLastYarnDelChallanDate.FieldName = "LastYarnDelChallanDate"
        Me.colLastYarnDelChallanDate.Name = "colLastYarnDelChallanDate"
        Me.colLastYarnDelChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastYarnDelChallanDate.Visible = True
        Me.colLastYarnDelChallanDate.Width = 98
        '
        'colYarnName
        '
        Me.colYarnName.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnName.Caption = "Yarn Details"
        Me.colYarnName.ColumnEdit = Me.RepositoryItemMemoEdit24
        Me.colYarnName.FieldName = "YarnName"
        Me.colYarnName.Name = "colYarnName"
        Me.colYarnName.OptionsColumn.AllowEdit = False
        Me.colYarnName.Visible = True
        Me.colYarnName.Width = 167
        '
        'RepositoryItemMemoEdit24
        '
        Me.RepositoryItemMemoEdit24.Name = "RepositoryItemMemoEdit24"
        '
        'colYarnBrand
        '
        Me.colYarnBrand.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnBrand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnBrand.Caption = "Yarn Brand"
        Me.colYarnBrand.ColumnEdit = Me.RepositoryItemMemoEdit42
        Me.colYarnBrand.FieldName = "YarnBrand"
        Me.colYarnBrand.Name = "colYarnBrand"
        Me.colYarnBrand.OptionsColumn.AllowEdit = False
        Me.colYarnBrand.Visible = True
        '
        'RepositoryItemMemoEdit42
        '
        Me.RepositoryItemMemoEdit42.Name = "RepositoryItemMemoEdit42"
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLotNo.Caption = "Yarn Lot"
        Me.colLotNo.ColumnEdit = Me.RepositoryItemMemoEdit6
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.Visible = True
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'colStitchLength
        '
        Me.colStitchLength.AppearanceHeader.Options.UseTextOptions = True
        Me.colStitchLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStitchLength.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStitchLength.Caption = "Stitch Length"
        Me.colStitchLength.FieldName = "StitchLength"
        Me.colStitchLength.Name = "colStitchLength"
        Me.colStitchLength.OptionsColumn.AllowEdit = False
        Me.colStitchLength.Visible = True
        '
        'colMCDia
        '
        Me.colMCDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colMCDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCDia.Caption = "MC Dia"
        Me.colMCDia.FieldName = "MCDia"
        Me.colMCDia.Name = "colMCDia"
        Me.colMCDia.OptionsColumn.AllowEdit = False
        Me.colMCDia.Visible = True
        '
        'colMCGauge
        '
        Me.colMCGauge.AppearanceHeader.Options.UseTextOptions = True
        Me.colMCGauge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCGauge.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCGauge.Caption = "MC Gauge"
        Me.colMCGauge.FieldName = "MCGauge"
        Me.colMCGauge.Name = "colMCGauge"
        Me.colMCGauge.OptionsColumn.AllowEdit = False
        Me.colMCGauge.Visible = True
        '
        'colKnittingProduction
        '
        Me.colKnittingProduction.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingProduction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingProduction.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingProduction.Caption = "Knitting Production Qty"
        Me.colKnittingProduction.DisplayFormat.FormatString = "n2"
        Me.colKnittingProduction.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colKnittingProduction.FieldName = "KnittingProduction"
        Me.colKnittingProduction.Name = "colKnittingProduction"
        Me.colKnittingProduction.OptionsColumn.AllowEdit = False
        Me.colKnittingProduction.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KnittingProduction", "{0:n2}")})
        Me.colKnittingProduction.Visible = True
        Me.colKnittingProduction.Width = 91
        '
        'colGFIDeliveryQty
        '
        Me.colGFIDeliveryQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFIDeliveryQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFIDeliveryQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFIDeliveryQty.Caption = "GFI Delivery Qty"
        Me.colGFIDeliveryQty.DisplayFormat.FormatString = "n2"
        Me.colGFIDeliveryQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colGFIDeliveryQty.FieldName = "GFIDeliveryQty"
        Me.colGFIDeliveryQty.Name = "colGFIDeliveryQty"
        Me.colGFIDeliveryQty.OptionsColumn.AllowEdit = False
        Me.colGFIDeliveryQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GFIDeliveryQty", "{0:n2}")})
        Me.colGFIDeliveryQty.Visible = True
        '
        'colGFIChallanNo
        '
        Me.colGFIChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFIChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFIChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFIChallanNo.Caption = "GFI Delivery Challan No"
        Me.colGFIChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit7
        Me.colGFIChallanNo.FieldName = "GFIChallanNo"
        Me.colGFIChallanNo.Name = "colGFIChallanNo"
        Me.colGFIChallanNo.OptionsColumn.AllowEdit = False
        Me.colGFIChallanNo.Visible = True
        '
        'RepositoryItemMemoEdit7
        '
        Me.RepositoryItemMemoEdit7.Name = "RepositoryItemMemoEdit7"
        '
        'colFirstGFIDate
        '
        Me.colFirstGFIDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstGFIDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstGFIDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstGFIDate.Caption = "First GFI Delivery Challan Date"
        Me.colFirstGFIDate.FieldName = "FirstGFIDate"
        Me.colFirstGFIDate.Name = "colFirstGFIDate"
        Me.colFirstGFIDate.OptionsColumn.AllowEdit = False
        Me.colFirstGFIDate.Visible = True
        Me.colFirstGFIDate.Width = 100
        '
        'colLastGFIDate
        '
        Me.colLastGFIDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastGFIDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastGFIDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastGFIDate.Caption = "Last GFI Delivery Challan Date"
        Me.colLastGFIDate.FieldName = "LastGFIDate"
        Me.colLastGFIDate.Name = "colLastGFIDate"
        Me.colLastGFIDate.OptionsColumn.AllowEdit = False
        Me.colLastGFIDate.Visible = True
        Me.colLastGFIDate.Width = 92
        '
        'gridBand9
        '
        Me.gridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand9.Caption = "Grey Fabric Store"
        Me.gridBand9.Columns.Add(Me.colTTLGFReceiveQuantity)
        Me.gridBand9.Columns.Add(Me.colGFReceiveBalance)
        Me.gridBand9.Columns.Add(Me.colGFReceiveChallanNo)
        Me.gridBand9.Columns.Add(Me.colFirstGFSReceiveChallanDate)
        Me.gridBand9.Columns.Add(Me.colLastGFSReceiveChallanDate)
        Me.gridBand9.Columns.Add(Me.colTTLGFIssueQuantity)
        Me.gridBand9.Columns.Add(Me.colGFIssueBalance)
        Me.gridBand9.Columns.Add(Me.colGFIssueChallanNo)
        Me.gridBand9.Columns.Add(Me.colFirstGFSIssueChallanDate)
        Me.gridBand9.Columns.Add(Me.colLastGFSIssueChallanDate)
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 3
        Me.gridBand9.Width = 875
        '
        'colTTLGFReceiveQuantity
        '
        Me.colTTLGFReceiveQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLGFReceiveQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLGFReceiveQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLGFReceiveQuantity.Caption = "Grey Fabric Rcv Qty"
        Me.colTTLGFReceiveQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLGFReceiveQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLGFReceiveQuantity.FieldName = "TTLGFReceiveQuantity"
        Me.colTTLGFReceiveQuantity.Name = "colTTLGFReceiveQuantity"
        Me.colTTLGFReceiveQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLGFReceiveQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLGFReceiveQuantity", "{0:n2}")})
        Me.colTTLGFReceiveQuantity.Visible = True
        '
        'colGFReceiveBalance
        '
        Me.colGFReceiveBalance.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colGFReceiveBalance.AppearanceCell.Options.UseBackColor = True
        Me.colGFReceiveBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFReceiveBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFReceiveBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFReceiveBalance.Caption = "Grey Fabric Rcv Bal Qty"
        Me.colGFReceiveBalance.DisplayFormat.FormatString = "n2"
        Me.colGFReceiveBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colGFReceiveBalance.FieldName = "GFReceiveBalance"
        Me.colGFReceiveBalance.Name = "colGFReceiveBalance"
        Me.colGFReceiveBalance.OptionsColumn.AllowEdit = False
        Me.colGFReceiveBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GFReceiveBalance", "{0:n2}")})
        Me.colGFReceiveBalance.Visible = True
        Me.colGFReceiveBalance.Width = 68
        '
        'colGFReceiveChallanNo
        '
        Me.colGFReceiveChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFReceiveChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFReceiveChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFReceiveChallanNo.Caption = "Grey Fabric Rcv Challan No"
        Me.colGFReceiveChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit8
        Me.colGFReceiveChallanNo.FieldName = "GFReceiveChallanNo"
        Me.colGFReceiveChallanNo.Name = "colGFReceiveChallanNo"
        Me.colGFReceiveChallanNo.OptionsColumn.AllowEdit = False
        Me.colGFReceiveChallanNo.Visible = True
        Me.colGFReceiveChallanNo.Width = 86
        '
        'RepositoryItemMemoEdit8
        '
        Me.RepositoryItemMemoEdit8.Name = "RepositoryItemMemoEdit8"
        '
        'colFirstGFSReceiveChallanDate
        '
        Me.colFirstGFSReceiveChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstGFSReceiveChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstGFSReceiveChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstGFSReceiveChallanDate.Caption = "First Grey Fabric Rcv Date"
        Me.colFirstGFSReceiveChallanDate.FieldName = "FirstGFSReceiveChallanDate"
        Me.colFirstGFSReceiveChallanDate.Name = "colFirstGFSReceiveChallanDate"
        Me.colFirstGFSReceiveChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstGFSReceiveChallanDate.Visible = True
        Me.colFirstGFSReceiveChallanDate.Width = 85
        '
        'colLastGFSReceiveChallanDate
        '
        Me.colLastGFSReceiveChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastGFSReceiveChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastGFSReceiveChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastGFSReceiveChallanDate.Caption = "Last Grey Fabric Rcv Date"
        Me.colLastGFSReceiveChallanDate.FieldName = "LastGFSReceiveChallanDate"
        Me.colLastGFSReceiveChallanDate.Name = "colLastGFSReceiveChallanDate"
        Me.colLastGFSReceiveChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastGFSReceiveChallanDate.Visible = True
        Me.colLastGFSReceiveChallanDate.Width = 89
        '
        'colTTLGFIssueQuantity
        '
        Me.colTTLGFIssueQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLGFIssueQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLGFIssueQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLGFIssueQuantity.Caption = "Grey Fabric Issue Qty"
        Me.colTTLGFIssueQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLGFIssueQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLGFIssueQuantity.FieldName = "TTLGFIssueQuantity"
        Me.colTTLGFIssueQuantity.Name = "colTTLGFIssueQuantity"
        Me.colTTLGFIssueQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLGFIssueQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLGFIssueQuantity", "{0:n2}")})
        Me.colTTLGFIssueQuantity.Visible = True
        '
        'colGFIssueBalance
        '
        Me.colGFIssueBalance.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colGFIssueBalance.AppearanceCell.Options.UseBackColor = True
        Me.colGFIssueBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFIssueBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFIssueBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFIssueBalance.Caption = "Grey Fabric Issue Bal Qty"
        Me.colGFIssueBalance.DisplayFormat.FormatString = "n2"
        Me.colGFIssueBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colGFIssueBalance.FieldName = "GFIssueBalance"
        Me.colGFIssueBalance.Name = "colGFIssueBalance"
        Me.colGFIssueBalance.OptionsColumn.AllowEdit = False
        Me.colGFIssueBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GFIssueBalance", "{0:n2}")})
        Me.colGFIssueBalance.Visible = True
        '
        'colGFIssueChallanNo
        '
        Me.colGFIssueChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGFIssueChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGFIssueChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGFIssueChallanNo.Caption = "Grey Fabric Issue Challan No"
        Me.colGFIssueChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit9
        Me.colGFIssueChallanNo.FieldName = "GFIssueChallanNo"
        Me.colGFIssueChallanNo.Name = "colGFIssueChallanNo"
        Me.colGFIssueChallanNo.OptionsColumn.AllowEdit = False
        Me.colGFIssueChallanNo.Visible = True
        Me.colGFIssueChallanNo.Width = 91
        '
        'RepositoryItemMemoEdit9
        '
        Me.RepositoryItemMemoEdit9.Name = "RepositoryItemMemoEdit9"
        '
        'colFirstGFSIssueChallanDate
        '
        Me.colFirstGFSIssueChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstGFSIssueChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstGFSIssueChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstGFSIssueChallanDate.Caption = "First Grey Fabric Delivery Challan Date"
        Me.colFirstGFSIssueChallanDate.FieldName = "FirstGFSIssueChallanDate"
        Me.colFirstGFSIssueChallanDate.Name = "colFirstGFSIssueChallanDate"
        Me.colFirstGFSIssueChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstGFSIssueChallanDate.Visible = True
        Me.colFirstGFSIssueChallanDate.Width = 113
        '
        'colLastGFSIssueChallanDate
        '
        Me.colLastGFSIssueChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastGFSIssueChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastGFSIssueChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastGFSIssueChallanDate.Caption = "Last Grey Fabric Delivery Challan Date"
        Me.colLastGFSIssueChallanDate.FieldName = "LastGFSIssueChallanDate"
        Me.colLastGFSIssueChallanDate.Name = "colLastGFSIssueChallanDate"
        Me.colLastGFSIssueChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastGFSIssueChallanDate.Visible = True
        Me.colLastGFSIssueChallanDate.Width = 118
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand8.Caption = "Batch Section"
        Me.gridBand8.Columns.Add(Me.colFirstBatchDate)
        Me.gridBand8.Columns.Add(Me.colLastBatchDate)
        Me.gridBand8.Columns.Add(Me.colFabricColorName1)
        Me.gridBand8.Columns.Add(Me.colKnittingType1)
        Me.gridBand8.Columns.Add(Me.colBatchNo)
        Me.gridBand8.Columns.Add(Me.colBatchQuantity)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 4
        Me.gridBand8.Width = 450
        '
        'colFirstBatchDate
        '
        Me.colFirstBatchDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstBatchDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstBatchDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstBatchDate.Caption = "First Batch Date"
        Me.colFirstBatchDate.FieldName = "FirstBatchDate"
        Me.colFirstBatchDate.Name = "colFirstBatchDate"
        Me.colFirstBatchDate.OptionsColumn.AllowEdit = False
        Me.colFirstBatchDate.Visible = True
        '
        'colLastBatchDate
        '
        Me.colLastBatchDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastBatchDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastBatchDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastBatchDate.Caption = "Last Batch Date"
        Me.colLastBatchDate.FieldName = "LastBatchDate"
        Me.colLastBatchDate.Name = "colLastBatchDate"
        Me.colLastBatchDate.OptionsColumn.AllowEdit = False
        Me.colLastBatchDate.Visible = True
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorName1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorName1.Caption = "Shade Name"
        Me.colFabricColorName1.ColumnEdit = Me.RepositoryItemMemoEdit17
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.OptionsColumn.AllowEdit = False
        Me.colFabricColorName1.Visible = True
        '
        'RepositoryItemMemoEdit17
        '
        Me.RepositoryItemMemoEdit17.Name = "RepositoryItemMemoEdit17"
        '
        'colKnittingType1
        '
        Me.colKnittingType1.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingType1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingType1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingType1.Caption = "Fabric Type"
        Me.colKnittingType1.FieldName = "KnittingType"
        Me.colKnittingType1.Name = "colKnittingType1"
        Me.colKnittingType1.OptionsColumn.AllowEdit = False
        Me.colKnittingType1.Visible = True
        '
        'colBatchNo
        '
        Me.colBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchNo.Caption = "Batch No"
        Me.colBatchNo.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.OptionsColumn.AllowEdit = False
        Me.colBatchNo.Visible = True
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colBatchQuantity
        '
        Me.colBatchQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchQuantity.Caption = "Batch Qty"
        Me.colBatchQuantity.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colBatchQuantity.DisplayFormat.FormatString = "n2"
        Me.colBatchQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBatchQuantity.FieldName = "BatchQuantity"
        Me.colBatchQuantity.Name = "colBatchQuantity"
        Me.colBatchQuantity.OptionsColumn.AllowEdit = False
        Me.colBatchQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BatchQuantity", "{0:n2}")})
        Me.colBatchQuantity.Visible = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand7.Caption = "Dyeing Department"
        Me.gridBand7.Columns.Add(Me.colFirstDyeingDate)
        Me.gridBand7.Columns.Add(Me.colLastDyeingDate)
        Me.gridBand7.Columns.Add(Me.colDyeingQuantity)
        Me.gridBand7.Columns.Add(Me.colDLBatchNo)
        Me.gridBand7.Columns.Add(Me.colEnzyme)
        Me.gridBand7.Columns.Add(Me.colSoftner)
        Me.gridBand7.Columns.Add(Me.colShade)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 5
        Me.gridBand7.Width = 536
        '
        'colFirstDyeingDate
        '
        Me.colFirstDyeingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstDyeingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstDyeingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstDyeingDate.Caption = "First Dyeing Date"
        Me.colFirstDyeingDate.FieldName = "FirstDyeingDate"
        Me.colFirstDyeingDate.Name = "colFirstDyeingDate"
        Me.colFirstDyeingDate.OptionsColumn.AllowEdit = False
        Me.colFirstDyeingDate.Visible = True
        '
        'colLastDyeingDate
        '
        Me.colLastDyeingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDyeingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDyeingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDyeingDate.Caption = "Last Dyeing Date"
        Me.colLastDyeingDate.FieldName = "LastDyeingDate"
        Me.colLastDyeingDate.Name = "colLastDyeingDate"
        Me.colLastDyeingDate.OptionsColumn.AllowEdit = False
        Me.colLastDyeingDate.Visible = True
        '
        'colDyeingQuantity
        '
        Me.colDyeingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeingQuantity.Caption = "Dyeing Production Qty"
        Me.colDyeingQuantity.DisplayFormat.FormatString = "n2"
        Me.colDyeingQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDyeingQuantity.FieldName = "DyeingQuantity"
        Me.colDyeingQuantity.Name = "colDyeingQuantity"
        Me.colDyeingQuantity.OptionsColumn.AllowEdit = False
        Me.colDyeingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DyeingQuantity", "{0:n2}")})
        Me.colDyeingQuantity.Visible = True
        Me.colDyeingQuantity.Width = 86
        '
        'colDLBatchNo
        '
        Me.colDLBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colDLBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDLBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDLBatchNo.Caption = "Dyeline Batch No"
        Me.colDLBatchNo.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colDLBatchNo.FieldName = "DLBatchNo"
        Me.colDLBatchNo.Name = "colDLBatchNo"
        Me.colDLBatchNo.OptionsColumn.AllowEdit = False
        Me.colDLBatchNo.Visible = True
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colEnzyme
        '
        Me.colEnzyme.AppearanceHeader.Options.UseTextOptions = True
        Me.colEnzyme.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEnzyme.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEnzyme.Caption = "Enzime %"
        Me.colEnzyme.ColumnEdit = Me.RepositoryItemMemoEdit15
        Me.colEnzyme.FieldName = "Enzyme"
        Me.colEnzyme.Name = "colEnzyme"
        Me.colEnzyme.OptionsColumn.AllowEdit = False
        Me.colEnzyme.Visible = True
        '
        'RepositoryItemMemoEdit15
        '
        Me.RepositoryItemMemoEdit15.Name = "RepositoryItemMemoEdit15"
        '
        'colSoftner
        '
        Me.colSoftner.AppearanceHeader.Options.UseTextOptions = True
        Me.colSoftner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSoftner.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSoftner.Caption = "Softner %"
        Me.colSoftner.ColumnEdit = Me.RepositoryItemMemoEdit16
        Me.colSoftner.FieldName = "Softner"
        Me.colSoftner.Name = "colSoftner"
        Me.colSoftner.OptionsColumn.AllowEdit = False
        Me.colSoftner.Visible = True
        '
        'RepositoryItemMemoEdit16
        '
        Me.RepositoryItemMemoEdit16.Name = "RepositoryItemMemoEdit16"
        '
        'colShade
        '
        Me.colShade.AppearanceHeader.Options.UseTextOptions = True
        Me.colShade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShade.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShade.Caption = "Shade %"
        Me.colShade.ColumnEdit = Me.RepositoryItemMemoEdit18
        Me.colShade.FieldName = "Shade"
        Me.colShade.Name = "colShade"
        Me.colShade.OptionsColumn.AllowEdit = False
        Me.colShade.Visible = True
        '
        'RepositoryItemMemoEdit18
        '
        Me.RepositoryItemMemoEdit18.Name = "RepositoryItemMemoEdit18"
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand6.Caption = "Lab Department"
        Me.gridBand6.Columns.Add(Me.colFirstLDReceivedDate)
        Me.gridBand6.Columns.Add(Me.colLastLDReceivedDate)
        Me.gridBand6.Columns.Add(Me.colFirstSwatchReceivedDate)
        Me.gridBand6.Columns.Add(Me.colLastSwatchReceivedDate)
        Me.gridBand6.Columns.Add(Me.colFirstLabFabricDate)
        Me.gridBand6.Columns.Add(Me.colLastLabFabricDate)
        Me.gridBand6.Columns.Add(Me.colFirstLabPreparedDate)
        Me.gridBand6.Columns.Add(Me.colLastLabPreparedDate)
        Me.gridBand6.Columns.Add(Me.colFirstLDApprovedDate)
        Me.gridBand6.Columns.Add(Me.colLastLDApprovedDate)
        Me.gridBand6.Columns.Add(Me.colFirstLDSentForAppDate)
        Me.gridBand6.Columns.Add(Me.colLastLDSentForAppDate)
        Me.gridBand6.Columns.Add(Me.colFirstLDSenttoFloorDate)
        Me.gridBand6.Columns.Add(Me.colLastLDSenttoFloorDate)
        Me.gridBand6.Columns.Add(Me.colLDRecipeNo)
        Me.gridBand6.Columns.Add(Me.colLDCost)
        Me.gridBand6.Columns.Add(Me.colLDStatus)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 6
        Me.gridBand6.Width = 1409
        '
        'colFirstLDReceivedDate
        '
        Me.colFirstLDReceivedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLDReceivedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLDReceivedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLDReceivedDate.Caption = "First LD Rcv Date"
        Me.colFirstLDReceivedDate.FieldName = "FirstLDReceivedDate"
        Me.colFirstLDReceivedDate.Name = "colFirstLDReceivedDate"
        Me.colFirstLDReceivedDate.OptionsColumn.AllowEdit = False
        Me.colFirstLDReceivedDate.Visible = True
        '
        'colLastLDReceivedDate
        '
        Me.colLastLDReceivedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLDReceivedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLDReceivedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLDReceivedDate.Caption = "Last LD Rcv Date"
        Me.colLastLDReceivedDate.FieldName = "LastLDReceivedDate"
        Me.colLastLDReceivedDate.Name = "colLastLDReceivedDate"
        Me.colLastLDReceivedDate.OptionsColumn.AllowEdit = False
        Me.colLastLDReceivedDate.Visible = True
        '
        'colFirstSwatchReceivedDate
        '
        Me.colFirstSwatchReceivedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstSwatchReceivedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstSwatchReceivedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstSwatchReceivedDate.Caption = "First Swatch Rcv Date"
        Me.colFirstSwatchReceivedDate.FieldName = "FirstSwatchReceivedDate"
        Me.colFirstSwatchReceivedDate.Name = "colFirstSwatchReceivedDate"
        Me.colFirstSwatchReceivedDate.OptionsColumn.AllowEdit = False
        Me.colFirstSwatchReceivedDate.Visible = True
        Me.colFirstSwatchReceivedDate.Width = 79
        '
        'colLastSwatchReceivedDate
        '
        Me.colLastSwatchReceivedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastSwatchReceivedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastSwatchReceivedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastSwatchReceivedDate.Caption = "Last Swatch Rcv Date"
        Me.colLastSwatchReceivedDate.FieldName = "LastSwatchReceivedDate"
        Me.colLastSwatchReceivedDate.Name = "colLastSwatchReceivedDate"
        Me.colLastSwatchReceivedDate.OptionsColumn.AllowEdit = False
        Me.colLastSwatchReceivedDate.Visible = True
        Me.colLastSwatchReceivedDate.Width = 81
        '
        'colFirstLabFabricDate
        '
        Me.colFirstLabFabricDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLabFabricDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLabFabricDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLabFabricDate.Caption = "First Fabric Rcv Date"
        Me.colFirstLabFabricDate.FieldName = "FirstLabFabricDate"
        Me.colFirstLabFabricDate.Name = "colFirstLabFabricDate"
        Me.colFirstLabFabricDate.OptionsColumn.AllowEdit = False
        Me.colFirstLabFabricDate.Visible = True
        Me.colFirstLabFabricDate.Width = 80
        '
        'colLastLabFabricDate
        '
        Me.colLastLabFabricDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLabFabricDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLabFabricDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLabFabricDate.Caption = "Last Fabric Rcv Date"
        Me.colLastLabFabricDate.FieldName = "LastLabFabricDate"
        Me.colLastLabFabricDate.Name = "colLastLabFabricDate"
        Me.colLastLabFabricDate.OptionsColumn.AllowEdit = False
        Me.colLastLabFabricDate.Visible = True
        Me.colLastLabFabricDate.Width = 81
        '
        'colFirstLabPreparedDate
        '
        Me.colFirstLabPreparedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLabPreparedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLabPreparedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLabPreparedDate.Caption = "First Lab Dip Prepare Date"
        Me.colFirstLabPreparedDate.FieldName = "FirstLabPreparedDate"
        Me.colFirstLabPreparedDate.Name = "colFirstLabPreparedDate"
        Me.colFirstLabPreparedDate.OptionsColumn.AllowEdit = False
        Me.colFirstLabPreparedDate.Visible = True
        Me.colFirstLabPreparedDate.Width = 82
        '
        'colLastLabPreparedDate
        '
        Me.colLastLabPreparedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLabPreparedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLabPreparedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLabPreparedDate.Caption = "Last Lab Dip Prepare Date"
        Me.colLastLabPreparedDate.FieldName = "LastLabPreparedDate"
        Me.colLastLabPreparedDate.Name = "colLastLabPreparedDate"
        Me.colLastLabPreparedDate.OptionsColumn.AllowEdit = False
        Me.colLastLabPreparedDate.Visible = True
        Me.colLastLabPreparedDate.Width = 84
        '
        'colFirstLDApprovedDate
        '
        Me.colFirstLDApprovedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLDApprovedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLDApprovedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLDApprovedDate.Caption = "First LD Approved Date"
        Me.colFirstLDApprovedDate.FieldName = "FirstLDApprovedDate"
        Me.colFirstLDApprovedDate.Name = "colFirstLDApprovedDate"
        Me.colFirstLDApprovedDate.OptionsColumn.AllowEdit = False
        Me.colFirstLDApprovedDate.Visible = True
        Me.colFirstLDApprovedDate.Width = 81
        '
        'colLastLDApprovedDate
        '
        Me.colLastLDApprovedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLDApprovedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLDApprovedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLDApprovedDate.Caption = "Last LD Approved Date"
        Me.colLastLDApprovedDate.FieldName = "LastLDApprovedDate"
        Me.colLastLDApprovedDate.Name = "colLastLDApprovedDate"
        Me.colLastLDApprovedDate.OptionsColumn.AllowEdit = False
        Me.colLastLDApprovedDate.Visible = True
        Me.colLastLDApprovedDate.Width = 83
        '
        'colFirstLDSenttoFloorDate
        '
        Me.colFirstLDSenttoFloorDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLDSenttoFloorDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLDSenttoFloorDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLDSenttoFloorDate.Caption = "First Lap Dip Sent For Floor Date"
        Me.colFirstLDSenttoFloorDate.FieldName = "FirstLDSenttoFloorDate"
        Me.colFirstLDSenttoFloorDate.Name = "colFirstLDSenttoFloorDate"
        Me.colFirstLDSenttoFloorDate.OptionsColumn.AllowEdit = False
        Me.colFirstLDSenttoFloorDate.Visible = True
        Me.colFirstLDSenttoFloorDate.Width = 105
        '
        'colLastLDSenttoFloorDate
        '
        Me.colLastLDSenttoFloorDate.AppearanceCell.Options.UseTextOptions = True
        Me.colLastLDSenttoFloorDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLDSenttoFloorDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLDSenttoFloorDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLDSenttoFloorDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLDSenttoFloorDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLDSenttoFloorDate.Caption = "Last Lap Dip Sent For Floor Date"
        Me.colLastLDSenttoFloorDate.FieldName = "LastLDSenttoFloorDate"
        Me.colLastLDSenttoFloorDate.Name = "colLastLDSenttoFloorDate"
        Me.colLastLDSenttoFloorDate.OptionsColumn.AllowEdit = False
        Me.colLastLDSenttoFloorDate.Visible = True
        Me.colLastLDSenttoFloorDate.Width = 92
        '
        'colFirstLDSentForAppDate
        '
        Me.colFirstLDSentForAppDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstLDSentForAppDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstLDSentForAppDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstLDSentForAppDate.Caption = "First Lab Dip Sent For App Date"
        Me.colFirstLDSentForAppDate.FieldName = "FirstLDSentForAppDate"
        Me.colFirstLDSentForAppDate.Name = "colFirstLDSentForAppDate"
        Me.colFirstLDSentForAppDate.OptionsColumn.AllowEdit = False
        Me.colFirstLDSentForAppDate.Visible = True
        Me.colFirstLDSentForAppDate.Width = 94
        '
        'colLastLDSentForAppDate
        '
        Me.colLastLDSentForAppDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastLDSentForAppDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastLDSentForAppDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastLDSentForAppDate.Caption = "Last Lab Dip Sent For App Date"
        Me.colLastLDSentForAppDate.FieldName = "LastLDSentForAppDate"
        Me.colLastLDSentForAppDate.Name = "colLastLDSentForAppDate"
        Me.colLastLDSentForAppDate.OptionsColumn.AllowEdit = False
        Me.colLastLDSentForAppDate.Visible = True
        Me.colLastLDSentForAppDate.Width = 92
        '
        'colLDRecipeNo
        '
        Me.colLDRecipeNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLDRecipeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLDRecipeNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLDRecipeNo.Caption = "LD Recipe No"
        Me.colLDRecipeNo.ColumnEdit = Me.RepositoryItemMemoEdit10
        Me.colLDRecipeNo.FieldName = "LDRecipeNo"
        Me.colLDRecipeNo.Name = "colLDRecipeNo"
        Me.colLDRecipeNo.OptionsColumn.AllowEdit = False
        Me.colLDRecipeNo.Visible = True
        '
        'RepositoryItemMemoEdit10
        '
        Me.RepositoryItemMemoEdit10.Name = "RepositoryItemMemoEdit10"
        '
        'colLDCost
        '
        Me.colLDCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colLDCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLDCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLDCost.Caption = "TTL LD Cost"
        Me.colLDCost.DisplayFormat.FormatString = "c2"
        Me.colLDCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colLDCost.FieldName = "LDCost"
        Me.colLDCost.Name = "colLDCost"
        Me.colLDCost.OptionsColumn.AllowEdit = False
        Me.colLDCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LDCost", "{0:c2}")})
        Me.colLDCost.Visible = True
        '
        'colLDStatus
        '
        Me.colLDStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colLDStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLDStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLDStatus.Caption = "LD Status"
        Me.colLDStatus.FieldName = "LDStatus"
        Me.colLDStatus.Name = "colLDStatus"
        Me.colLDStatus.OptionsColumn.AllowEdit = False
        Me.colLDStatus.Visible = True
        '
        'gridBand10
        '
        Me.gridBand10.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand10.Caption = "R&D Department"
        Me.gridBand10.Columns.Add(Me.colFabricTestNo)
        Me.gridBand10.Columns.Add(Me.colFirstFabricTestDate)
        Me.gridBand10.Columns.Add(Me.colLastFabricTestDate)
        Me.gridBand10.Columns.Add(Me.colFirstFabricTestReceiveDate)
        Me.gridBand10.Columns.Add(Me.colLastFabricTestReceiveDate)
        Me.gridBand10.Columns.Add(Me.colFirstSubmitDate)
        Me.gridBand10.Columns.Add(Me.colLastSubmitDate)
        Me.gridBand10.Columns.Add(Me.colFirstFabricTestApprovedDate)
        Me.gridBand10.Columns.Add(Me.colLastFabricTestApprovedDate)
        Me.gridBand10.Columns.Add(Me.colFabricTestStatus)
        Me.gridBand10.Name = "gridBand10"
        Me.gridBand10.VisibleIndex = 7
        Me.gridBand10.Width = 791
        '
        'colFabricTestNo
        '
        Me.colFabricTestNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricTestNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricTestNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricTestNo.Caption = "RND Fabric Test No"
        Me.colFabricTestNo.ColumnEdit = Me.RepositoryItemMemoEdit12
        Me.colFabricTestNo.FieldName = "FabricTestNo"
        Me.colFabricTestNo.Name = "colFabricTestNo"
        Me.colFabricTestNo.OptionsColumn.AllowEdit = False
        Me.colFabricTestNo.Visible = True
        '
        'RepositoryItemMemoEdit12
        '
        Me.RepositoryItemMemoEdit12.Name = "RepositoryItemMemoEdit12"
        '
        'colFirstFabricTestDate
        '
        Me.colFirstFabricTestDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFabricTestDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFabricTestDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFabricTestDate.Caption = "RND First Fabric Test Date"
        Me.colFirstFabricTestDate.FieldName = "FirstFabricTestDate"
        Me.colFirstFabricTestDate.Name = "colFirstFabricTestDate"
        Me.colFirstFabricTestDate.OptionsColumn.AllowEdit = False
        Me.colFirstFabricTestDate.Visible = True
        Me.colFirstFabricTestDate.Width = 85
        '
        'colLastFabricTestDate
        '
        Me.colLastFabricTestDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFabricTestDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFabricTestDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFabricTestDate.Caption = "RND Last Fabric Test Date"
        Me.colLastFabricTestDate.FieldName = "LastFabricTestDate"
        Me.colLastFabricTestDate.Name = "colLastFabricTestDate"
        Me.colLastFabricTestDate.OptionsColumn.AllowEdit = False
        Me.colLastFabricTestDate.Visible = True
        Me.colLastFabricTestDate.Width = 86
        '
        'colFirstFabricTestReceiveDate
        '
        Me.colFirstFabricTestReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFabricTestReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFabricTestReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFabricTestReceiveDate.Caption = "RND First Receive Date"
        Me.colFirstFabricTestReceiveDate.FieldName = "FirstFabricTestReceiveDate"
        Me.colFirstFabricTestReceiveDate.Name = "colFirstFabricTestReceiveDate"
        Me.colFirstFabricTestReceiveDate.OptionsColumn.AllowEdit = False
        Me.colFirstFabricTestReceiveDate.Visible = True
        '
        'colLastFabricTestReceiveDate
        '
        Me.colLastFabricTestReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFabricTestReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFabricTestReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFabricTestReceiveDate.Caption = "RND Last Receive Date"
        Me.colLastFabricTestReceiveDate.FieldName = "LastFabricTestReceiveDate"
        Me.colLastFabricTestReceiveDate.Name = "colLastFabricTestReceiveDate"
        Me.colLastFabricTestReceiveDate.OptionsColumn.AllowEdit = False
        Me.colLastFabricTestReceiveDate.Visible = True
        '
        'colFirstSubmitDate
        '
        Me.colFirstSubmitDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstSubmitDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstSubmitDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstSubmitDate.Caption = "RND First Submit Date"
        Me.colFirstSubmitDate.FieldName = "FirstSubmitDate"
        Me.colFirstSubmitDate.Name = "colFirstSubmitDate"
        Me.colFirstSubmitDate.OptionsColumn.AllowEdit = False
        Me.colFirstSubmitDate.Visible = True
        '
        'colLastSubmitDate
        '
        Me.colLastSubmitDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastSubmitDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastSubmitDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastSubmitDate.Caption = "RND Last Submit Date"
        Me.colLastSubmitDate.FieldName = "LastSubmitDate"
        Me.colLastSubmitDate.Name = "colLastSubmitDate"
        Me.colLastSubmitDate.OptionsColumn.AllowEdit = False
        Me.colLastSubmitDate.Visible = True
        '
        'colFirstFabricTestApprovedDate
        '
        Me.colFirstFabricTestApprovedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFabricTestApprovedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFabricTestApprovedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFabricTestApprovedDate.Caption = "RND First Approved Date"
        Me.colFirstFabricTestApprovedDate.FieldName = "FirstFabricTestApprovedDate"
        Me.colFirstFabricTestApprovedDate.Name = "colFirstFabricTestApprovedDate"
        Me.colFirstFabricTestApprovedDate.OptionsColumn.AllowEdit = False
        Me.colFirstFabricTestApprovedDate.Visible = True
        Me.colFirstFabricTestApprovedDate.Width = 83
        '
        'colLastFabricTestApprovedDate
        '
        Me.colLastFabricTestApprovedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFabricTestApprovedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFabricTestApprovedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFabricTestApprovedDate.Caption = "RND Last Approved Date"
        Me.colLastFabricTestApprovedDate.FieldName = "LastFabricTestApprovedDate"
        Me.colLastFabricTestApprovedDate.Name = "colLastFabricTestApprovedDate"
        Me.colLastFabricTestApprovedDate.OptionsColumn.AllowEdit = False
        Me.colLastFabricTestApprovedDate.Visible = True
        Me.colLastFabricTestApprovedDate.Width = 87
        '
        'colFabricTestStatus
        '
        Me.colFabricTestStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricTestStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricTestStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricTestStatus.Caption = "RND Fabric Test Status"
        Me.colFabricTestStatus.FieldName = "FabricTestStatus"
        Me.colFabricTestStatus.Name = "colFabricTestStatus"
        Me.colFabricTestStatus.OptionsColumn.AllowEdit = False
        Me.colFabricTestStatus.Visible = True
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand5.Caption = "Dyeing Finishing Department"
        Me.gridBand5.Columns.Add(Me.colFinishingProcessed)
        Me.gridBand5.Columns.Add(Me.colFirstFinishingDate)
        Me.gridBand5.Columns.Add(Me.colLastFinishingDate)
        Me.gridBand5.Columns.Add(Me.colTTLDyeingFinishingQuantity)
        Me.gridBand5.Columns.Add(Me.colQADStatus)
        Me.gridBand5.Columns.Add(Me.colFirstFFIDate)
        Me.gridBand5.Columns.Add(Me.colLastFFIDate)
        Me.gridBand5.Columns.Add(Me.colFFIChallanNo)
        Me.gridBand5.Columns.Add(Me.colTTLFFIDeliveryQuantity)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 8
        Me.gridBand5.Width = 778
        '
        'colFinishingProcessed
        '
        Me.colFinishingProcessed.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishingProcessed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishingProcessed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishingProcessed.Caption = "Dyeing Finishing Process"
        Me.colFinishingProcessed.ColumnEdit = Me.RepositoryItemMemoEdit43
        Me.colFinishingProcessed.FieldName = "FinishingProcessed"
        Me.colFinishingProcessed.Name = "colFinishingProcessed"
        Me.colFinishingProcessed.OptionsColumn.AllowEdit = False
        Me.colFinishingProcessed.Visible = True
        Me.colFinishingProcessed.Width = 87
        '
        'RepositoryItemMemoEdit43
        '
        Me.RepositoryItemMemoEdit43.Name = "RepositoryItemMemoEdit43"
        '
        'colFirstFinishingDate
        '
        Me.colFirstFinishingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFinishingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFinishingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFinishingDate.Caption = "First Dyeing Finishing Date"
        Me.colFirstFinishingDate.FieldName = "FirstFinishingDate"
        Me.colFirstFinishingDate.Name = "colFirstFinishingDate"
        Me.colFirstFinishingDate.OptionsColumn.AllowEdit = False
        Me.colFirstFinishingDate.Visible = True
        Me.colFirstFinishingDate.Width = 78
        '
        'colLastFinishingDate
        '
        Me.colLastFinishingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFinishingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFinishingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFinishingDate.Caption = "Last Dyeing Finishing Date"
        Me.colLastFinishingDate.FieldName = "LastFinishingDate"
        Me.colLastFinishingDate.Name = "colLastFinishingDate"
        Me.colLastFinishingDate.OptionsColumn.AllowEdit = False
        Me.colLastFinishingDate.Visible = True
        Me.colLastFinishingDate.Width = 76
        '
        'colTTLDyeingFinishingQuantity
        '
        Me.colTTLDyeingFinishingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLDyeingFinishingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLDyeingFinishingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLDyeingFinishingQuantity.Caption = "Dyeing Finishing Production Qty"
        Me.colTTLDyeingFinishingQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLDyeingFinishingQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLDyeingFinishingQuantity.FieldName = "TTLDyeingFinishingQuantity"
        Me.colTTLDyeingFinishingQuantity.Name = "colTTLDyeingFinishingQuantity"
        Me.colTTLDyeingFinishingQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLDyeingFinishingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLDyeingFinishingQuantity", "{0:n2}")})
        Me.colTTLDyeingFinishingQuantity.Visible = True
        Me.colTTLDyeingFinishingQuantity.Width = 97
        '
        'colQADStatus
        '
        Me.colQADStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colQADStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQADStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQADStatus.Caption = "Dyeing Finishing QC Status"
        Me.colQADStatus.FieldName = "QADStatus"
        Me.colQADStatus.Name = "colQADStatus"
        Me.colQADStatus.Visible = True
        Me.colQADStatus.Width = 88
        '
        'colFirstFFIDate
        '
        Me.colFirstFFIDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFFIDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFFIDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFFIDate.Caption = "First QAD Delivey Challan Date"
        Me.colFirstFFIDate.FieldName = "FirstFFIDate"
        Me.colFirstFFIDate.Name = "colFirstFFIDate"
        Me.colFirstFFIDate.OptionsColumn.AllowEdit = False
        Me.colFirstFFIDate.Visible = True
        Me.colFirstFFIDate.Width = 108
        '
        'colLastFFIDate
        '
        Me.colLastFFIDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFFIDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFFIDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFFIDate.Caption = "Last QAD Delivey Challan Date"
        Me.colLastFFIDate.FieldName = "LastFFIDate"
        Me.colLastFFIDate.Name = "colLastFFIDate"
        Me.colLastFFIDate.OptionsColumn.AllowEdit = False
        Me.colLastFFIDate.Visible = True
        Me.colLastFFIDate.Width = 94
        '
        'colFFIChallanNo
        '
        Me.colFFIChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFIChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFIChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFIChallanNo.Caption = "QAD Delivey Challan No"
        Me.colFFIChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit11
        Me.colFFIChallanNo.FieldName = "FFIChallanNo"
        Me.colFFIChallanNo.Name = "colFFIChallanNo"
        Me.colFFIChallanNo.OptionsColumn.AllowEdit = False
        Me.colFFIChallanNo.Visible = True
        '
        'RepositoryItemMemoEdit11
        '
        Me.RepositoryItemMemoEdit11.Name = "RepositoryItemMemoEdit11"
        '
        'colTTLFFIDeliveryQuantity
        '
        Me.colTTLFFIDeliveryQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLFFIDeliveryQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLFFIDeliveryQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLFFIDeliveryQuantity.Caption = "QAD Delivey Qty"
        Me.colTTLFFIDeliveryQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLFFIDeliveryQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLFFIDeliveryQuantity.FieldName = "TTLFFIDeliveryQuantity"
        Me.colTTLFFIDeliveryQuantity.Name = "colTTLFFIDeliveryQuantity"
        Me.colTTLFFIDeliveryQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLFFIDeliveryQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLFFIDeliveryQuantity", "{0:n2}")})
        Me.colTTLFFIDeliveryQuantity.Visible = True
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridBand4.Caption = "Finish Fabric Store"
        Me.gridBand4.Columns.Add(Me.colFirstFFRcvChallanDate)
        Me.gridBand4.Columns.Add(Me.colLastFFRcvChallanDate)
        Me.gridBand4.Columns.Add(Me.colFFReceiveChallanNo)
        Me.gridBand4.Columns.Add(Me.colTTLFFReceiveQuantity)
        Me.gridBand4.Columns.Add(Me.colFFReceiveBalance)
        Me.gridBand4.Columns.Add(Me.colFirstFFIssChallanDate)
        Me.gridBand4.Columns.Add(Me.colLastFFIssChallanDate)
        Me.gridBand4.Columns.Add(Me.colFFIssueChallanNo)
        Me.gridBand4.Columns.Add(Me.colTTLFFIssueQuantity)
        Me.gridBand4.Columns.Add(Me.colFFIssueBalance)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 9
        Me.gridBand4.Width = 787
        '
        'colFirstFFRcvChallanDate
        '
        Me.colFirstFFRcvChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFFRcvChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFFRcvChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFFRcvChallanDate.Caption = "First FF Recv Challan Date"
        Me.colFirstFFRcvChallanDate.FieldName = "FirstFFRcvChallanDate"
        Me.colFirstFFRcvChallanDate.Name = "colFirstFFRcvChallanDate"
        Me.colFirstFFRcvChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstFFRcvChallanDate.Visible = True
        Me.colFirstFFRcvChallanDate.Width = 85
        '
        'colLastFFRcvChallanDate
        '
        Me.colLastFFRcvChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFFRcvChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFFRcvChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFFRcvChallanDate.Caption = "Last FF Recv Challan Date"
        Me.colLastFFRcvChallanDate.FieldName = "LastFFRcvChallanDate"
        Me.colLastFFRcvChallanDate.Name = "colLastFFRcvChallanDate"
        Me.colLastFFRcvChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastFFRcvChallanDate.Visible = True
        Me.colLastFFRcvChallanDate.Width = 77
        '
        'colFFReceiveChallanNo
        '
        Me.colFFReceiveChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFReceiveChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFReceiveChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFReceiveChallanNo.Caption = "FF Recv Challan No"
        Me.colFFReceiveChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit13
        Me.colFFReceiveChallanNo.FieldName = "FFReceiveChallanNo"
        Me.colFFReceiveChallanNo.Name = "colFFReceiveChallanNo"
        Me.colFFReceiveChallanNo.OptionsColumn.AllowEdit = False
        Me.colFFReceiveChallanNo.Visible = True
        Me.colFFReceiveChallanNo.Width = 73
        '
        'RepositoryItemMemoEdit13
        '
        Me.RepositoryItemMemoEdit13.Name = "RepositoryItemMemoEdit13"
        '
        'colTTLFFReceiveQuantity
        '
        Me.colTTLFFReceiveQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLFFReceiveQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLFFReceiveQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLFFReceiveQuantity.Caption = "Finish Fabric Recv Qty"
        Me.colTTLFFReceiveQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLFFReceiveQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLFFReceiveQuantity.FieldName = "TTLFFReceiveQuantity"
        Me.colTTLFFReceiveQuantity.Name = "colTTLFFReceiveQuantity"
        Me.colTTLFFReceiveQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLFFReceiveQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLFFReceiveQuantity", "{0:n2}")})
        Me.colTTLFFReceiveQuantity.Visible = True
        '
        'colFFReceiveBalance
        '
        Me.colFFReceiveBalance.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colFFReceiveBalance.AppearanceCell.Options.UseBackColor = True
        Me.colFFReceiveBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFReceiveBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFReceiveBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFReceiveBalance.Caption = "Finish Fabric Rcv Bal Qty"
        Me.colFFReceiveBalance.DisplayFormat.FormatString = "n2"
        Me.colFFReceiveBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFFReceiveBalance.FieldName = "FFReceiveBalance"
        Me.colFFReceiveBalance.Name = "colFFReceiveBalance"
        Me.colFFReceiveBalance.OptionsColumn.AllowEdit = False
        Me.colFFReceiveBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FFReceiveBalance", "{0:n2}")})
        Me.colFFReceiveBalance.Visible = True
        '
        'colFirstFFIssChallanDate
        '
        Me.colFirstFFIssChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstFFIssChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstFFIssChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstFFIssChallanDate.Caption = "First FF Delivery Challan Date"
        Me.colFirstFFIssChallanDate.FieldName = "FirstFFIssChallanDate"
        Me.colFirstFFIssChallanDate.Name = "colFirstFFIssChallanDate"
        Me.colFirstFFIssChallanDate.OptionsColumn.AllowEdit = False
        Me.colFirstFFIssChallanDate.Visible = True
        Me.colFirstFFIssChallanDate.Width = 88
        '
        'colLastFFIssChallanDate
        '
        Me.colLastFFIssChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastFFIssChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastFFIssChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastFFIssChallanDate.Caption = "Last FF Delivery Challan Date"
        Me.colLastFFIssChallanDate.FieldName = "LastFFIssChallanDate"
        Me.colLastFFIssChallanDate.Name = "colLastFFIssChallanDate"
        Me.colLastFFIssChallanDate.OptionsColumn.AllowEdit = False
        Me.colLastFFIssChallanDate.Visible = True
        Me.colLastFFIssChallanDate.Width = 89
        '
        'colFFIssueChallanNo
        '
        Me.colFFIssueChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFIssueChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFIssueChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFIssueChallanNo.Caption = "FF Delivery Challan No"
        Me.colFFIssueChallanNo.ColumnEdit = Me.RepositoryItemMemoEdit14
        Me.colFFIssueChallanNo.FieldName = "FFIssueChallanNo"
        Me.colFFIssueChallanNo.Name = "colFFIssueChallanNo"
        Me.colFFIssueChallanNo.OptionsColumn.AllowEdit = False
        Me.colFFIssueChallanNo.Visible = True
        '
        'RepositoryItemMemoEdit14
        '
        Me.RepositoryItemMemoEdit14.Name = "RepositoryItemMemoEdit14"
        '
        'colTTLFFIssueQuantity
        '
        Me.colTTLFFIssueQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLFFIssueQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLFFIssueQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLFFIssueQuantity.Caption = "Finish Fabric Issue Qty"
        Me.colTTLFFIssueQuantity.DisplayFormat.FormatString = "n2"
        Me.colTTLFFIssueQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLFFIssueQuantity.FieldName = "TTLFFIssueQuantity"
        Me.colTTLFFIssueQuantity.Name = "colTTLFFIssueQuantity"
        Me.colTTLFFIssueQuantity.OptionsColumn.AllowEdit = False
        Me.colTTLFFIssueQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLFFIssueQuantity", "{0:n2}")})
        Me.colTTLFFIssueQuantity.Visible = True
        '
        'colFFIssueBalance
        '
        Me.colFFIssueBalance.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.colFFIssueBalance.AppearanceCell.Options.UseBackColor = True
        Me.colFFIssueBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFIssueBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFIssueBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFIssueBalance.Caption = "Finish Fabric Issue Bal Qty"
        Me.colFFIssueBalance.DisplayFormat.FormatString = "n2"
        Me.colFFIssueBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFFIssueBalance.FieldName = "FFIssueBalance"
        Me.colFFIssueBalance.Name = "colFFIssueBalance"
        Me.colFFIssueBalance.OptionsColumn.AllowEdit = False
        Me.colFFIssueBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FFIssueBalance", "{0:n2}")})
        Me.colFFIssueBalance.Visible = True
        '
        'colIsBookingCompleteOn
        '
        Me.colIsBookingCompleteOn.FieldName = "IsBookingCompleteOn"
        Me.colIsBookingCompleteOn.Name = "colIsBookingCompleteOn"
        Me.colIsBookingCompleteOn.Visible = True
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemMemoEdit32
        '
        Me.RepositoryItemMemoEdit32.Name = "RepositoryItemMemoEdit32"
        '
        'RepositoryItemMemoEdit44
        '
        Me.RepositoryItemMemoEdit44.Name = "RepositoryItemMemoEdit44"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show All "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1207, 27)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(78, 13)
        Me.LinkLabel2.TabIndex = 79
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Export to Excel"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(977, 7)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabel3.TabIndex = 83
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Refresh Program List"
        '
        'ShowButton
        '
        Me.ShowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ShowButton.Location = New System.Drawing.Point(1091, 3)
        Me.ShowButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(63, 41)
        Me.ShowButton.TabIndex = 82
        Me.ShowButton.Text = "&Show"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(809, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl1.TabIndex = 81
        Me.LabelControl1.Text = "Sample Program :: Style :: Buyer :"
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgramNoGridLookUpEdit.EditValue = ""
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(639, 24)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "RequestNoAndStyleNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Properties.ShowNullValuePromptWhenFocused = True
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "SampleRequestId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(446, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 80
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleRequestLookupDataSet
        '
        Me.SampleRequestLookupDataSet.DataSetName = "SampleRequestLookupDataSet"
        Me.SampleRequestLookupDataSet.EnforceConstraints = False
        Me.SampleRequestLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequestNoAndStyleNo, Me.colBuyerName, Me.colRequestDate1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRequestNoAndStyleNo
        '
        Me.colRequestNoAndStyleNo.FieldName = "RequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Name = "colRequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Visible = True
        Me.colRequestNoAndStyleNo.VisibleIndex = 0
        Me.colRequestNoAndStyleNo.Width = 984
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        Me.colBuyerName.Width = 287
        '
        'colRequestDate1
        '
        Me.colRequestDate1.FieldName = "RequestDate"
        Me.colRequestDate1.Name = "colRequestDate1"
        Me.colRequestDate1.Visible = True
        Me.colRequestDate1.VisibleIndex = 2
        Me.colRequestDate1.Width = 290
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 41)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Show Running"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(12, 17)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(164, 13)
        Me.LinkLabel4.TabIndex = 86
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Generate Sample Program Status"
        '
        'LastUpdateLabel
        '
        Me.LastUpdateLabel.AutoSize = True
        Me.LastUpdateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastUpdateLabel.ForeColor = System.Drawing.Color.Red
        Me.LastUpdateLabel.Location = New System.Drawing.Point(12, 34)
        Me.LastUpdateLabel.Name = "LastUpdateLabel"
        Me.LastUpdateLabel.Size = New System.Drawing.Size(11, 13)
        Me.LastUpdateLabel.TabIndex = 85
        Me.LastUpdateLabel.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Note: This data show on generated time data."
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveButton.Location = New System.Drawing.Point(437, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(90, 41)
        Me.SaveButton.TabIndex = 88
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'SaveLinkLabel
        '
        Me.SaveLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveLinkLabel.AutoSize = True
        Me.SaveLinkLabel.Location = New System.Drawing.Point(1166, 3)
        Me.SaveLinkLabel.Name = "SaveLinkLabel"
        Me.SaveLinkLabel.Size = New System.Drawing.Size(67, 13)
        Me.SaveLinkLabel.TabIndex = 90
        Me.SaveLinkLabel.TabStop = True
        Me.SaveLinkLabel.Text = "Save Layout"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1238, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel1.TabIndex = 91
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Save Default Layout"
        '
        'frmSampleRequestStatusUpdateNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SaveLinkLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LastUpdateLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SampleRequestStatusGridControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSampleRequestStatusUpdateNew"
        Me.Text = "Sample Program Status Update"
        CType(Me.SampleRequestStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SampleRequestStatusDataSet As SampleRequestStatusDataSet
    Friend WithEvents SampleRequestStatusBindingSource As BindingSource
    Friend WithEvents SampleRequestStatusTableAdapter As SampleRequestStatusDataSetTableAdapters.SampleRequestStatusTableAdapter
    Friend WithEvents TableAdapterManager As SampleRequestStatusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SampleRequestStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colRequestNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGarmentsDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsEmbroidery As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsTrim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsFabricAvailable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExFabricRcvDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsTrimAvailable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExTrimRcvDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDevType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsYds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsWash As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsPeachFinish As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsBrush As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCommentsReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompletedOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFileReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAccReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleRequireDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFileReceiveDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAccReceiveDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleCuttingStartDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleCuttingEndDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleSewingStartDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleSewingEndDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDivision As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSeason As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricRequireDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSamplePrintSendDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSamplePrintSendQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsamplePrintReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSamplePrintReceiveQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleEmbSendDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleEmbSendQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleEmbReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleEmbReceiveQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleExDeliveryDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStatusRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricBookingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsSequence As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsSublimation As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTrimDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colApprovalStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleSendDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSendingInfo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsBookingComplete As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRevisedNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsReceivedByDyeing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRevisedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAttention As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleFabricBookingRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbroideryDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWashType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSamplePreparedBy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGreyQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMerchandiser As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstSampleDeliveryDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastSampleDeliveryDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSampleDeliveryQuantity2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFDeliveryQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGatePassType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCauseOfRevised As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGreyQuantity1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarnRequisitonNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarnIssueQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarnName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarnBrand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStitchLength As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMCDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMCGauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents colKnittingProduction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFIDeliveryQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFIChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstGFIDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastGFIDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstYarnRequisitonDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastYarnRequisitonDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnittingType1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFReceiveChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstGFSReceiveChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastGFSReceiveChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLGFIssueQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFIssueChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstGFSIssueChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastGFSIssueChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNLD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsBookingCompleteOn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarnDelChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstYarnDelChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastYarnDelChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLGFReceiveQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstBatchDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastBatchDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBatchQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstLDReceivedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLDReceivedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstLDApprovedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLDApprovedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLDRecipeNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstDyeingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDyeingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishingProcessed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFinishingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFinishingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLDyeingFinishingQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFFIDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFFIDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFIChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLFFIDeliveryQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstSwatchReceivedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastSwatchReceivedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstLabFabricDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLabFabricDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstLabPreparedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLabPreparedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstLDSentForAppDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLDSentForAppDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLDCost As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLDStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFabricTestNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFabricTestDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFabricTestDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFabricTestReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFabricTestReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstSubmitDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastSubmitDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFabricTestApprovedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFabricTestApprovedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricTestStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFirstFFRcvChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFFRcvChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFReceiveChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLFFReceiveQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstFFIssChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastFFIssChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFIssueChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLFFIssueQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LastUpdateLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents colYarnIssueBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFReceiveBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGFIssueBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFReceiveBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFIssueBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEnzyme As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDLBatchNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSoftner As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colShade As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SampleRequestLookupDataSet As SampleRequestLookupDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents colRequestNoAndStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit19 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit20 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit21 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit22 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit23 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit24 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit25 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit26 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit27 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit28 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents SaveLinkLabel As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents colQADStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoEdit29 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit30 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit31 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit32 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit33 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit34 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit35 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit36 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit37 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit38 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit41 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit39 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit40 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit42 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit43 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit44 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit45 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit46 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit47 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit48 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFirstLDSenttoFloorDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastLDSenttoFloorDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
