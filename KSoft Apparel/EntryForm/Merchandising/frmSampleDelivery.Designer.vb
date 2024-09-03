<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleDelivery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim RequestNoLabel As System.Windows.Forms.Label
        Dim DevTypeIdLabel As System.Windows.Forms.Label
        Dim WashTypeIdLabel As System.Windows.Forms.Label
        Dim GMDepartmentIdLabel As System.Windows.Forms.Label
        Dim StyleIdLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim ExDateLabel As System.Windows.Forms.Label
        Dim GarmentsDescriptionLabel As System.Windows.Forms.Label
        Dim RequestDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim StyleLabel As System.Windows.Forms.Label
        Dim MesurementLabel As System.Windows.Forms.Label
        Dim PrintTypeIdLabel As System.Windows.Forms.Label
        Dim PrintPositionLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim SendPhotoStrikeOffLabel1 As System.Windows.Forms.Label
        Dim WidthLabel As System.Windows.Forms.Label
        Dim PrintSizeLabel As System.Windows.Forms.Label
        Dim ApplicationLabel As System.Windows.Forms.Label
        Dim SpecialBackNeckReferenceLabel As System.Windows.Forms.Label
        Dim ArtworkLocationLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.TrimDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SampleRequestFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet
        Me.IsTrimCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.colStyle1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRequestNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSampleRequestId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AgreedLinkLabel = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SendPhotoStrikeOffCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.IsEmbroideryCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
        Me.colStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ExTrimRcvDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet
        Me.IsTrimAvailableCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbroideryDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.RemarksMemoEdit = New DevExpress.XtraEditors.MemoEdit
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.PrintTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PrintTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.colRequestNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GetDataLinkLabel = New System.Windows.Forms.LinkLabel
        Me.SampleFabricDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.SPNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MainFabric = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BookingQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsDelivered = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DeliveredDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintSend = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintReceived = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SampleFabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SampleRequireQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequireQuantityDataGridView = New System.Windows.Forms.DataGridView
        Me.SamplePrintColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSampleRequestId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.NewButton = New System.Windows.Forms.Button
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DevTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet
        Me.DevTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.StyleTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colWashTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet
        Me.GMDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGMDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGMDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SampleUpdateCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleNameId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ExDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.RequestNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.GarmentsDescriptionTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.RequestDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
        Me.SampleRequireQuantityTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequireQuantityTableAdapter
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter
        Me.SampleRequestFinalDetailsTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalDetailsTableAdapter
        Me.SampleRequestFinalTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager
        Me.SampleFabricTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleFabricTableAdapter
        Me.SamplePrintColorTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SamplePrintColorTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PrintSizeTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.MesurementSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.PrintPositionTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.HeightSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.WidthSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ApplicationTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SpecialBackNeckReferenceTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ArtworkLocationTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.AddNewColorLinkLabel = New System.Windows.Forms.LinkLabel
        Me.SampleRequestFinalDetailsGridControl = New DevExpress.XtraGrid.GridControl
        Me.SampleRequestFinalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSampleRequestDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSampleRequestId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKnittingTypeId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingType1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingTypeCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompositionId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCompositionId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComposition1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsFabricAvailable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colELD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSampleSendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsSealed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSealedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgreedLeadTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExFabricRcvDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsAOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsYDS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExSendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColorItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricColorId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.SamplePrintColorDataGridView = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        RequestNoLabel = New System.Windows.Forms.Label
        DevTypeIdLabel = New System.Windows.Forms.Label
        WashTypeIdLabel = New System.Windows.Forms.Label
        GMDepartmentIdLabel = New System.Windows.Forms.Label
        StyleIdLabel = New System.Windows.Forms.Label
        BuyerIdLabel = New System.Windows.Forms.Label
        ExDateLabel = New System.Windows.Forms.Label
        GarmentsDescriptionLabel = New System.Windows.Forms.Label
        RequestDateLabel = New System.Windows.Forms.Label
        RemarksLabel = New System.Windows.Forms.Label
        StyleLabel = New System.Windows.Forms.Label
        MesurementLabel = New System.Windows.Forms.Label
        PrintTypeIdLabel = New System.Windows.Forms.Label
        PrintPositionLabel = New System.Windows.Forms.Label
        HeightLabel = New System.Windows.Forms.Label
        SendPhotoStrikeOffLabel1 = New System.Windows.Forms.Label
        WidthLabel = New System.Windows.Forms.Label
        PrintSizeLabel = New System.Windows.Forms.Label
        ApplicationLabel = New System.Windows.Forms.Label
        SpecialBackNeckReferenceLabel = New System.Windows.Forms.Label
        ArtworkLocationLabel = New System.Windows.Forms.Label
        CType(Me.TrimDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTrimCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendPhotoStrikeOffCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTrimAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbroideryDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.SampleFabricDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequireQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequireQuantityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleUpdateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsDescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrintSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesurementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPositionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialBackNeckReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtworkLocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.SampleRequestFinalDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RequestNoLabel
        '
        RequestNoLabel.AutoSize = True
        RequestNoLabel.Location = New System.Drawing.Point(17, 32)
        RequestNoLabel.Name = "RequestNoLabel"
        RequestNoLabel.Size = New System.Drawing.Size(67, 13)
        RequestNoLabel.TabIndex = 16
        RequestNoLabel.Text = "Request No:"
        '
        'DevTypeIdLabel
        '
        DevTypeIdLabel.AutoSize = True
        DevTypeIdLabel.Location = New System.Drawing.Point(17, 56)
        DevTypeIdLabel.Name = "DevTypeIdLabel"
        DevTypeIdLabel.Size = New System.Drawing.Size(60, 13)
        DevTypeIdLabel.TabIndex = 30
        DevTypeIdLabel.Text = "Dev Type :"
        '
        'WashTypeIdLabel
        '
        WashTypeIdLabel.AutoSize = True
        WashTypeIdLabel.Location = New System.Drawing.Point(282, 204)
        WashTypeIdLabel.Name = "WashTypeIdLabel"
        WashTypeIdLabel.Size = New System.Drawing.Size(65, 13)
        WashTypeIdLabel.TabIndex = 29
        WashTypeIdLabel.Text = "Wash Type:"
        '
        'GMDepartmentIdLabel
        '
        GMDepartmentIdLabel.AutoSize = True
        GMDepartmentIdLabel.Location = New System.Drawing.Point(17, 103)
        GMDepartmentIdLabel.Name = "GMDepartmentIdLabel"
        GMDepartmentIdLabel.Size = New System.Drawing.Size(68, 13)
        GMDepartmentIdLabel.TabIndex = 19
        GMDepartmentIdLabel.Text = "Department :"
        '
        'StyleIdLabel
        '
        StyleIdLabel.AutoSize = True
        StyleIdLabel.Location = New System.Drawing.Point(17, 79)
        StyleIdLabel.Name = "StyleIdLabel"
        StyleIdLabel.Size = New System.Drawing.Size(64, 13)
        StyleIdLabel.TabIndex = 18
        StyleIdLabel.Text = "Style [New]:"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(282, 56)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(37, 13)
        BuyerIdLabel.TabIndex = 26
        BuyerIdLabel.Text = "Buyer:"
        '
        'ExDateLabel
        '
        ExDateLabel.AutoSize = True
        ExDateLabel.ForeColor = System.Drawing.Color.Black
        ExDateLabel.Location = New System.Drawing.Point(282, 103)
        ExDateLabel.Name = "ExDateLabel"
        ExDateLabel.Size = New System.Drawing.Size(80, 13)
        ExDateLabel.TabIndex = 28
        ExDateLabel.Text = "Fabric Ex  Date"
        '
        'GarmentsDescriptionLabel
        '
        GarmentsDescriptionLabel.AutoSize = True
        GarmentsDescriptionLabel.Location = New System.Drawing.Point(17, 128)
        GarmentsDescriptionLabel.Name = "GarmentsDescriptionLabel"
        GarmentsDescriptionLabel.Size = New System.Drawing.Size(111, 13)
        GarmentsDescriptionLabel.TabIndex = 20
        GarmentsDescriptionLabel.Text = "Garments Description:"
        '
        'RequestDateLabel
        '
        RequestDateLabel.AutoSize = True
        RequestDateLabel.Location = New System.Drawing.Point(282, 32)
        RequestDateLabel.Name = "RequestDateLabel"
        RequestDateLabel.Size = New System.Drawing.Size(76, 13)
        RequestDateLabel.TabIndex = 25
        RequestDateLabel.Text = "Request Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(17, 230)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 24
        RemarksLabel.Text = "Remarks:"
        '
        'StyleLabel
        '
        StyleLabel.AutoSize = True
        StyleLabel.ForeColor = System.Drawing.Color.Black
        StyleLabel.Location = New System.Drawing.Point(282, 79)
        StyleLabel.Name = "StyleLabel"
        StyleLabel.Size = New System.Drawing.Size(64, 13)
        StyleLabel.TabIndex = 27
        StyleLabel.Text = "Style (OLD):"
        '
        'MesurementLabel
        '
        MesurementLabel.AutoSize = True
        MesurementLabel.Location = New System.Drawing.Point(20, 204)
        MesurementLabel.Name = "MesurementLabel"
        MesurementLabel.Size = New System.Drawing.Size(68, 13)
        MesurementLabel.TabIndex = 16
        MesurementLabel.Text = "Mesurement:"
        '
        'PrintTypeIdLabel
        '
        PrintTypeIdLabel.AutoSize = True
        PrintTypeIdLabel.Location = New System.Drawing.Point(21, 61)
        PrintTypeIdLabel.Name = "PrintTypeIdLabel"
        PrintTypeIdLabel.Size = New System.Drawing.Size(61, 13)
        PrintTypeIdLabel.TabIndex = 11
        PrintTypeIdLabel.Text = "Print Type :"
        '
        'PrintPositionLabel
        '
        PrintPositionLabel.AutoSize = True
        PrintPositionLabel.Location = New System.Drawing.Point(20, 178)
        PrintPositionLabel.Name = "PrintPositionLabel"
        PrintPositionLabel.Size = New System.Drawing.Size(71, 13)
        PrintPositionLabel.TabIndex = 15
        PrintPositionLabel.Text = "Print Position:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(20, 152)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(41, 13)
        HeightLabel.TabIndex = 14
        HeightLabel.Text = "Height:"
        '
        'SendPhotoStrikeOffLabel1
        '
        SendPhotoStrikeOffLabel1.AutoSize = True
        SendPhotoStrikeOffLabel1.Location = New System.Drawing.Point(20, 307)
        SendPhotoStrikeOffLabel1.Name = "SendPhotoStrikeOffLabel1"
        SendPhotoStrikeOffLabel1.Size = New System.Drawing.Size(113, 13)
        SendPhotoStrikeOffLabel1.TabIndex = 20
        SendPhotoStrikeOffLabel1.Text = "Send Photo Strike Off:"
        '
        'WidthLabel
        '
        WidthLabel.AutoSize = True
        WidthLabel.Location = New System.Drawing.Point(20, 126)
        WidthLabel.Name = "WidthLabel"
        WidthLabel.Size = New System.Drawing.Size(38, 13)
        WidthLabel.TabIndex = 13
        WidthLabel.Text = "Width:"
        '
        'PrintSizeLabel
        '
        PrintSizeLabel.AutoSize = True
        PrintSizeLabel.Location = New System.Drawing.Point(20, 100)
        PrintSizeLabel.Name = "PrintSizeLabel"
        PrintSizeLabel.Size = New System.Drawing.Size(54, 13)
        PrintSizeLabel.TabIndex = 12
        PrintSizeLabel.Text = "Print Size:"
        '
        'ApplicationLabel
        '
        ApplicationLabel.AutoSize = True
        ApplicationLabel.Location = New System.Drawing.Point(20, 282)
        ApplicationLabel.Name = "ApplicationLabel"
        ApplicationLabel.Size = New System.Drawing.Size(62, 13)
        ApplicationLabel.TabIndex = 19
        ApplicationLabel.Text = "Application:"
        '
        'SpecialBackNeckReferenceLabel
        '
        SpecialBackNeckReferenceLabel.AutoSize = True
        SpecialBackNeckReferenceLabel.Location = New System.Drawing.Point(20, 256)
        SpecialBackNeckReferenceLabel.Name = "SpecialBackNeckReferenceLabel"
        SpecialBackNeckReferenceLabel.Size = New System.Drawing.Size(125, 13)
        SpecialBackNeckReferenceLabel.TabIndex = 18
        SpecialBackNeckReferenceLabel.Text = "Special Back Neck Ref :"
        '
        'ArtworkLocationLabel
        '
        ArtworkLocationLabel.AutoSize = True
        ArtworkLocationLabel.Location = New System.Drawing.Point(20, 230)
        ArtworkLocationLabel.Name = "ArtworkLocationLabel"
        ArtworkLocationLabel.Size = New System.Drawing.Size(90, 13)
        ArtworkLocationLabel.TabIndex = 17
        ArtworkLocationLabel.Text = "Artwork Location:"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.OptionsColumn.ReadOnly = True
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.RefreshButton.Location = New System.Drawing.Point(429, 6)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(39, 22)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Tag = "NR"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'TrimDetailsTextEdit
        '
        Me.TrimDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "TrimDetails", True))
        Me.TrimDetailsTextEdit.Location = New System.Drawing.Point(143, 175)
        Me.TrimDetailsTextEdit.Name = "TrimDetailsTextEdit"
        Me.TrimDetailsTextEdit.Size = New System.Drawing.Size(380, 20)
        Me.TrimDetailsTextEdit.TabIndex = 11
        '
        'SampleRequestFinalBindingSource
        '
        Me.SampleRequestFinalBindingSource.DataMember = "SampleRequestFinal"
        Me.SampleRequestFinalBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsTrimCheckEdit
        '
        Me.IsTrimCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsTrim", True))
        Me.IsTrimCheckEdit.Location = New System.Drawing.Point(17, 175)
        Me.IsTrimCheckEdit.Name = "IsTrimCheckEdit"
        Me.IsTrimCheckEdit.Properties.Caption = "Trims Require"
        Me.IsTrimCheckEdit.Size = New System.Drawing.Size(120, 19)
        Me.IsTrimCheckEdit.TabIndex = 22
        '
        'colStyle1
        '
        Me.colStyle1.FieldName = "Style"
        Me.colStyle1.Name = "colStyle1"
        '
        'colRequestNo1
        '
        Me.colRequestNo1.FieldName = "RequestNo"
        Me.colRequestNo1.Name = "colRequestNo1"
        '
        'colSampleRequestId1
        '
        Me.colSampleRequestId1.FieldName = "SampleRequestId"
        Me.colSampleRequestId1.Name = "colSampleRequestId1"
        Me.colSampleRequestId1.OptionsColumn.ReadOnly = True
        '
        'AgreedLinkLabel
        '
        Me.AgreedLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AgreedLinkLabel.Location = New System.Drawing.Point(354, 293)
        Me.AgreedLinkLabel.Name = "AgreedLinkLabel"
        Me.AgreedLinkLabel.Size = New System.Drawing.Size(169, 27)
        Me.AgreedLinkLabel.TabIndex = 14
        Me.AgreedLinkLabel.TabStop = True
        Me.AgreedLinkLabel.Text = "Calculate Agreed Lead Time"
        Me.AgreedLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Style"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(288, 7)
        Me.GridLookUpEdit2.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "SampleRequestId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(135, 20)
        Me.GridLookUpEdit2.TabIndex = 1
        Me.GridLookUpEdit2.Tag = "NR"
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestId1, Me.colRequestNo1, Me.colStyle1, Me.colDetails1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SendPhotoStrikeOffCheckEdit
        '
        Me.SendPhotoStrikeOffCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SendPhotoStrikeOff", True))
        Me.SendPhotoStrikeOffCheckEdit.Location = New System.Drawing.Point(155, 304)
        Me.SendPhotoStrikeOffCheckEdit.Name = "SendPhotoStrikeOffCheckEdit"
        Me.SendPhotoStrikeOffCheckEdit.Properties.Caption = ""
        Me.SendPhotoStrikeOffCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.SendPhotoStrikeOffCheckEdit.TabIndex = 10
        '
        'IsEmbroideryCheckEdit
        '
        Me.IsEmbroideryCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit.Location = New System.Drawing.Point(17, 151)
        Me.IsEmbroideryCheckEdit.Name = "IsEmbroideryCheckEdit"
        Me.IsEmbroideryCheckEdit.Properties.Caption = "Embroidery Require"
        Me.IsEmbroideryCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsEmbroideryCheckEdit.TabIndex = 21
        '
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'colStyle
        '
        Me.colStyle.FieldName = "Style"
        Me.colStyle.Name = "colStyle"
        '
        'ExTrimRcvDateDateEdit
        '
        Me.ExTrimRcvDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ExTrimRcvDate", True))
        Me.ExTrimRcvDateDateEdit.EditValue = Nothing
        Me.ExTrimRcvDateDateEdit.Location = New System.Drawing.Point(143, 201)
        Me.ExTrimRcvDateDateEdit.Name = "ExTrimRcvDateDateEdit"
        Me.ExTrimRcvDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExTrimRcvDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ExTrimRcvDateDateEdit.Size = New System.Drawing.Size(128, 20)
        Me.ExTrimRcvDateDateEdit.TabIndex = 12
        Me.ExTrimRcvDateDateEdit.ToolTip = "Ex Trim Received Date"
        '
        'PrintTypeDataSet
        '
        Me.PrintTypeDataSet.DataSetName = "PrintTypeDataSet"
        Me.PrintTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsTrimAvailableCheckEdit
        '
        Me.IsTrimAvailableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsTrimAvailable", True))
        Me.IsTrimAvailableCheckEdit.Location = New System.Drawing.Point(17, 201)
        Me.IsTrimAvailableCheckEdit.Name = "IsTrimAvailableCheckEdit"
        Me.IsTrimAvailableCheckEdit.Properties.Caption = "Trims Available"
        Me.IsTrimAvailableCheckEdit.Size = New System.Drawing.Size(105, 19)
        Me.IsTrimAvailableCheckEdit.TabIndex = 23
        '
        'PrintTypeBindingSource
        '
        Me.PrintTypeBindingSource.DataMember = "PrintType"
        Me.PrintTypeBindingSource.DataSource = Me.PrintTypeDataSet
        '
        'EmbroideryDetailsTextEdit
        '
        Me.EmbroideryDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "EmbroideryDetails", True))
        Me.EmbroideryDetailsTextEdit.Location = New System.Drawing.Point(143, 150)
        Me.EmbroideryDetailsTextEdit.Name = "EmbroideryDetailsTextEdit"
        Me.EmbroideryDetailsTextEdit.Size = New System.Drawing.Size(380, 20)
        Me.EmbroideryDetailsTextEdit.TabIndex = 9
        Me.EmbroideryDetailsTextEdit.ToolTip = "Embroidery Details"
        '
        'RemarksMemoEdit
        '
        Me.RemarksMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Remarks", True))
        Me.RemarksMemoEdit.Location = New System.Drawing.Point(143, 233)
        Me.RemarksMemoEdit.Name = "RemarksMemoEdit"
        Me.RemarksMemoEdit.Size = New System.Drawing.Size(380, 49)
        Me.RemarksMemoEdit.TabIndex = 13
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(22, 29)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print Line"
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsPrintCheckEdit.TabIndex = 0
        '
        'PrintTypeIdGridLookUpEditView
        '
        Me.PrintTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PrintTypeIdGridLookUpEditView.Name = "PrintTypeIdGridLookUpEditView"
        Me.PrintTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PrintTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'PrintTypeIdGridLookUpEdit
        '
        Me.PrintTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintTypeId", True))
        Me.PrintTypeIdGridLookUpEdit.Location = New System.Drawing.Point(157, 58)
        Me.PrintTypeIdGridLookUpEdit.Name = "PrintTypeIdGridLookUpEdit"
        Me.PrintTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintTypeIdGridLookUpEdit.Properties.DataSource = Me.PrintTypeBindingSource
        Me.PrintTypeIdGridLookUpEdit.Properties.DisplayMember = "PrintTypeName"
        Me.PrintTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.PrintTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintTypeIdGridLookUpEdit.Properties.ValueMember = "PrintTypeId"
        Me.PrintTypeIdGridLookUpEdit.Properties.View = Me.PrintTypeIdGridLookUpEditView
        Me.PrintTypeIdGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintTypeIdGridLookUpEdit.TabIndex = 1
        '
        'colRequestNo
        '
        Me.colRequestNo.FieldName = "RequestNo"
        Me.colRequestNo.Name = "colRequestNo"
        Me.colRequestNo.Visible = True
        Me.colRequestNo.VisibleIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GetDataLinkLabel)
        Me.TabPage1.Controls.Add(Me.SampleFabricDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(863, 165)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fabric Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GetDataLinkLabel
        '
        Me.GetDataLinkLabel.AutoSize = True
        Me.GetDataLinkLabel.Location = New System.Drawing.Point(6, 5)
        Me.GetDataLinkLabel.Name = "GetDataLinkLabel"
        Me.GetDataLinkLabel.Size = New System.Drawing.Size(280, 13)
        Me.GetDataLinkLabel.TabIndex = 1
        Me.GetDataLinkLabel.TabStop = True
        Me.GetDataLinkLabel.Text = "Get From Sample Color Details  [ Exclude available fabric ]"
        '
        'SampleFabricDataGridView
        '
        Me.SampleFabricDataGridView.AllowUserToAddRows = False
        Me.SampleFabricDataGridView.AllowUserToDeleteRows = False
        Me.SampleFabricDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleFabricDataGridView.AutoGenerateColumns = False
        Me.SampleFabricDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SampleFabricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SampleFabricDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.SPNote, Me.MainFabric, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.BookingQuantity, Me.IsDelivered, Me.DeliveredDate, Me.PrintSend, Me.PrintReceived, Me.Status, Me.Remarks})
        Me.SampleFabricDataGridView.DataSource = Me.SampleFabricBindingSource
        Me.SampleFabricDataGridView.Location = New System.Drawing.Point(3, 24)
        Me.SampleFabricDataGridView.Name = "SampleFabricDataGridView"
        Me.SampleFabricDataGridView.ReadOnly = True
        Me.SampleFabricDataGridView.Size = New System.Drawing.Size(854, 137)
        Me.SampleFabricDataGridView.TabIndex = 0
        Me.SampleFabricDataGridView.Tag = "NR"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ELD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ELD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GarmentsPartId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.GarmentsPartBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Garments Part"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "GarmentsPartId"
        '
        'GarmentsPartBindingSource
        '
        Me.GarmentsPartBindingSource.DataMember = "GarmentsPart"
        Me.GarmentsPartBindingSource.DataSource = Me.GarmentsPartDataSet
        '
        'GarmentsPartDataSet
        '
        Me.GarmentsPartDataSet.DataSetName = "GarmentsPartDataSet"
        Me.GarmentsPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KnittingTypeId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.KnittingTypeBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "KnittingType"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fabric Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "KnittingTypeId"
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CompositionId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.CompositionBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Composition"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Composition"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "CompositionId"
        '
        'CompositionBindingSource
        '
        Me.CompositionBindingSource.DataMember = "Composition"
        Me.CompositionBindingSource.DataSource = Me.CompositionDataSet
        '
        'CompositionDataSet
        '
        Me.CompositionDataSet.DataSetName = "CompositionDataSet"
        Me.CompositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPNote
        '
        Me.SPNote.DataPropertyName = "SPNote"
        Me.SPNote.HeaderText = "SPNote"
        Me.SPNote.Name = "SPNote"
        Me.SPNote.ReadOnly = True
        '
        'MainFabric
        '
        Me.MainFabric.DataPropertyName = "MainFabric"
        Me.MainFabric.HeaderText = "Main Fabric"
        Me.MainFabric.Name = "MainFabric"
        Me.MainFabric.ReadOnly = True
        Me.MainFabric.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FGSM"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.GSMBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "GSM"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "FGSM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "GSM"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'GSMBindingSource
        '
        Me.GSMBindingSource.DataMember = "GSM"
        Me.GSMBindingSource.DataSource = Me.GSMDataSet
        '
        'GSMDataSet
        '
        Me.GSMDataSet.DataSetName = "GSMDataSet"
        Me.GSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Dia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DiaType"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.HeaderText = "DiaType"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"Open", "Tube"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FinishUnit"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "FinishUnit"
        Me.DataGridViewTextBoxColumn11.Items.AddRange(New Object() {"Kg", "Yrds", "Mtr", "Pcs"})
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BookingQuantity
        '
        Me.BookingQuantity.DataPropertyName = "BookingQuantity"
        Me.BookingQuantity.HeaderText = "Booking Quantity"
        Me.BookingQuantity.Name = "BookingQuantity"
        Me.BookingQuantity.ReadOnly = True
        Me.BookingQuantity.Width = 80
        '
        'IsDelivered
        '
        Me.IsDelivered.DataPropertyName = "IsDelivered"
        Me.IsDelivered.HeaderText = "IsDelivered"
        Me.IsDelivered.Name = "IsDelivered"
        Me.IsDelivered.ReadOnly = True
        '
        'DeliveredDate
        '
        Me.DeliveredDate.DataPropertyName = "DeliveredDate"
        DataGridViewCellStyle4.Format = "dd-MMM-yy"
        Me.DeliveredDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.DeliveredDate.HeaderText = "Delivered Date"
        Me.DeliveredDate.Name = "DeliveredDate"
        Me.DeliveredDate.ReadOnly = True
        '
        'PrintSend
        '
        Me.PrintSend.DataPropertyName = "PrintSend"
        DataGridViewCellStyle5.Format = "dd-MMM-yy"
        Me.PrintSend.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrintSend.HeaderText = "Print Send"
        Me.PrintSend.Name = "PrintSend"
        Me.PrintSend.ReadOnly = True
        '
        'PrintReceived
        '
        Me.PrintReceived.DataPropertyName = "PrintReceived"
        DataGridViewCellStyle6.Format = "dd-MMM-yy"
        Me.PrintReceived.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrintReceived.HeaderText = "Print Received"
        Me.PrintReceived.Name = "PrintReceived"
        Me.PrintReceived.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Items.AddRange(New Object() {"Send to Print", "Received from Print", "Pending", "Delivered"})
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'SampleFabricBindingSource
        '
        Me.SampleFabricBindingSource.DataMember = "FK_SampleFabric_SampleRequestFinal"
        Me.SampleFabricBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "RequireFor"
        Me.DataGridViewTextBoxColumn21.HeaderText = "RequireFor"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "GarmentsSize"
        Me.DataGridViewTextBoxColumn22.HeaderText = "GarmentsSize"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'SampleRequireQuantityBindingSource
        '
        Me.SampleRequireQuantityBindingSource.DataMember = "FK_SampleRequireQuantity_SampleRequestFinal"
        Me.SampleRequireQuantityBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'SampleRequireQuantityDataGridView
        '
        Me.SampleRequireQuantityDataGridView.AllowUserToAddRows = False
        Me.SampleRequireQuantityDataGridView.AllowUserToDeleteRows = False
        Me.SampleRequireQuantityDataGridView.AutoGenerateColumns = False
        Me.SampleRequireQuantityDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SampleRequireQuantityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SampleRequireQuantityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.SampleRequireQuantityDataGridView.DataSource = Me.SampleRequireQuantityBindingSource
        Me.SampleRequireQuantityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleRequireQuantityDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SampleRequireQuantityDataGridView.Name = "SampleRequireQuantityDataGridView"
        Me.SampleRequireQuantityDataGridView.ReadOnly = True
        Me.SampleRequireQuantityDataGridView.Size = New System.Drawing.Size(857, 159)
        Me.SampleRequireQuantityDataGridView.TabIndex = 0
        '
        'SamplePrintColorBindingSource
        '
        Me.SamplePrintColorBindingSource.DataMember = "FK_SamplePrintColor_SampleRequestFinal"
        Me.SamplePrintColorBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Mesh"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Mesh"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 200
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ref"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ref"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RefType"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RefType"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "InkType"
        Me.DataGridViewTextBoxColumn17.HeaderText = "InkType"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(97, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequestNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "SampleRequestId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(135, 20)
        Me.GridLookUpEdit1.TabIndex = 0
        Me.GridLookUpEdit1.Tag = "NR"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestId, Me.colRequestNo, Me.colStyle, Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colSampleRequestId
        '
        Me.colSampleRequestId.FieldName = "SampleRequestId"
        Me.colSampleRequestId.Name = "colSampleRequestId"
        Me.colSampleRequestId.OptionsColumn.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Request No"
        '
        'NewButton
        '
        Me.NewButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton.Location = New System.Drawing.Point(501, 4)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(30, 4, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.NewButton.Size = New System.Drawing.Size(88, 26)
        Me.NewButton.TabIndex = 3
        Me.NewButton.Text = "&Add"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Edit
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(602, 4)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(92, 26)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "&Edit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.KSoft_Apparel.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(10, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(105, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(DevTypeIdLabel)
        Me.GroupBox3.Controls.Add(Me.DevTypeIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.StyleTextEdit)
        Me.GroupBox3.Controls.Add(WashTypeIdLabel)
        Me.GroupBox3.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(GMDepartmentIdLabel)
        Me.GroupBox3.Controls.Add(Me.GMDepartmentIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.SampleUpdateCheckEdit)
        Me.GroupBox3.Controls.Add(StyleIdLabel)
        Me.GroupBox3.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.AgreedLinkLabel)
        Me.GroupBox3.Controls.Add(BuyerIdLabel)
        Me.GroupBox3.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.TrimDetailsTextEdit)
        Me.GroupBox3.Controls.Add(Me.IsTrimCheckEdit)
        Me.GroupBox3.Controls.Add(Me.EmbroideryDetailsTextEdit)
        Me.GroupBox3.Controls.Add(Me.IsEmbroideryCheckEdit)
        Me.GroupBox3.Controls.Add(Me.ExTrimRcvDateDateEdit)
        Me.GroupBox3.Controls.Add(Me.RemarksMemoEdit)
        Me.GroupBox3.Controls.Add(Me.IsTrimAvailableCheckEdit)
        Me.GroupBox3.Controls.Add(ExDateLabel)
        Me.GroupBox3.Controls.Add(Me.ExDateDateEdit)
        Me.GroupBox3.Controls.Add(RequestNoLabel)
        Me.GroupBox3.Controls.Add(Me.RequestNoTextEdit)
        Me.GroupBox3.Controls.Add(GarmentsDescriptionLabel)
        Me.GroupBox3.Controls.Add(Me.GarmentsDescriptionTextEdit)
        Me.GroupBox3.Controls.Add(RequestDateLabel)
        Me.GroupBox3.Controls.Add(Me.RequestDateDateEdit)
        Me.GroupBox3.Controls.Add(RemarksLabel)
        Me.GroupBox3.Controls.Add(StyleLabel)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 340)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Basic Information"
        '
        'DevTypeIdGridLookUpEdit
        '
        Me.DevTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "DevTypeId", True))
        Me.DevTypeIdGridLookUpEdit.Location = New System.Drawing.Point(143, 52)
        Me.DevTypeIdGridLookUpEdit.Name = "DevTypeIdGridLookUpEdit"
        Me.DevTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DevTypeIdGridLookUpEdit.Properties.DataSource = Me.DevTypeMstBindingSource
        Me.DevTypeIdGridLookUpEdit.Properties.DisplayMember = "DevType"
        Me.DevTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DevTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.DevTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DevTypeIdGridLookUpEdit.Properties.ValueMember = "DevTypeId"
        Me.DevTypeIdGridLookUpEdit.Properties.View = Me.DevTypeIdGridLookUpEditView
        Me.DevTypeIdGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.DevTypeIdGridLookUpEdit.TabIndex = 31
        '
        'DevTypeMstBindingSource
        '
        Me.DevTypeMstBindingSource.DataMember = "DevTypeMst"
        Me.DevTypeMstBindingSource.DataSource = Me.DevTypeDataSet
        '
        'DevTypeDataSet
        '
        Me.DevTypeDataSet.DataSetName = "DevTypeDataSet"
        Me.DevTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevTypeIdGridLookUpEditView
        '
        Me.DevTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DevTypeIdGridLookUpEditView.Name = "DevTypeIdGridLookUpEditView"
        Me.DevTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DevTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'StyleTextEdit
        '
        Me.StyleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Style", True))
        Me.StyleTextEdit.Location = New System.Drawing.Point(385, 76)
        Me.StyleTextEdit.Name = "StyleTextEdit"
        Me.StyleTextEdit.Size = New System.Drawing.Size(138, 20)
        Me.StyleTextEdit.TabIndex = 6
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(385, 201)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.WashTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.WashTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Properties.View = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 10
        '
        'WashTypeMstBindingSource
        '
        Me.WashTypeMstBindingSource.DataMember = "WashTypeMst"
        Me.WashTypeMstBindingSource.DataSource = Me.WashTypeDataSet
        '
        'WashTypeDataSet
        '
        Me.WashTypeDataSet.DataSetName = "WashTypeDataSet"
        Me.WashTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashTypeIdGridLookUpEditView
        '
        Me.WashTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashTypeId, Me.colWashType})
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colWashTypeId
        '
        Me.colWashTypeId.FieldName = "WashTypeId"
        Me.colWashTypeId.Name = "colWashTypeId"
        Me.colWashTypeId.OptionsColumn.ReadOnly = True
        '
        'colWashType
        '
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.Visible = True
        Me.colWashType.VisibleIndex = 0
        '
        'GMDepartmentIdGridLookUpEdit
        '
        Me.GMDepartmentIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "GMDepartmentId", True))
        Me.GMDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(143, 100)
        Me.GMDepartmentIdGridLookUpEdit.Name = "GMDepartmentIdGridLookUpEdit"
        Me.GMDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMDepartmentIdGridLookUpEdit.Properties.DataSource = Me.GMDepartmentBindingSource
        Me.GMDepartmentIdGridLookUpEdit.Properties.DisplayMember = "GMDepartmentName"
        Me.GMDepartmentIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GMDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.GMDepartmentIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GMDepartmentIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMDepartmentIdGridLookUpEdit.Properties.ValueMember = "GMDepartmentId"
        Me.GMDepartmentIdGridLookUpEdit.Properties.View = Me.GMDepartmentIdGridLookUpEditView
        Me.GMDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.GMDepartmentIdGridLookUpEdit.TabIndex = 3
        '
        'GMDepartmentBindingSource
        '
        Me.GMDepartmentBindingSource.DataMember = "GMDepartment"
        Me.GMDepartmentBindingSource.DataSource = Me.GMDepartmentDataSet
        '
        'GMDepartmentDataSet
        '
        Me.GMDepartmentDataSet.DataSetName = "GMDepartmentDataSet"
        Me.GMDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMDepartmentIdGridLookUpEditView
        '
        Me.GMDepartmentIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMDepartmentId, Me.colGMDepartmentName})
        Me.GMDepartmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMDepartmentIdGridLookUpEditView.Name = "GMDepartmentIdGridLookUpEditView"
        Me.GMDepartmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMDepartmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGMDepartmentId
        '
        Me.colGMDepartmentId.FieldName = "GMDepartmentId"
        Me.colGMDepartmentId.Name = "colGMDepartmentId"
        Me.colGMDepartmentId.OptionsColumn.ReadOnly = True
        '
        'colGMDepartmentName
        '
        Me.colGMDepartmentName.FieldName = "GMDepartmentName"
        Me.colGMDepartmentName.Name = "colGMDepartmentName"
        Me.colGMDepartmentName.Visible = True
        Me.colGMDepartmentName.VisibleIndex = 0
        '
        'SampleUpdateCheckEdit
        '
        Me.SampleUpdateCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleUpdate", True))
        Me.SampleUpdateCheckEdit.Location = New System.Drawing.Point(20, 301)
        Me.SampleUpdateCheckEdit.Name = "SampleUpdateCheckEdit"
        Me.SampleUpdateCheckEdit.Properties.Caption = "Show in Sample Update"
        Me.SampleUpdateCheckEdit.Size = New System.Drawing.Size(164, 19)
        Me.SampleUpdateCheckEdit.TabIndex = 15
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(143, 76)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Properties.View = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 2
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "d"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName, Me.colBuyerId1, Me.colDefaultTarget, Me.colSMV, Me.colPicture, Me.colIsPrint, Me.colPrintDetails, Me.colPrintTypeId, Me.colStyleName2, Me.colStyleNameId})
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colDefaultTarget
        '
        Me.colDefaultTarget.FieldName = "DefaultTarget"
        Me.colDefaultTarget.Name = "colDefaultTarget"
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        '
        'colPicture
        '
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'colPrintDetails
        '
        Me.colPrintDetails.FieldName = "PrintDetails"
        Me.colPrintDetails.Name = "colPrintDetails"
        '
        'colPrintTypeId
        '
        Me.colPrintTypeId.FieldName = "PrintTypeId"
        Me.colPrintTypeId.Name = "colPrintTypeId"
        '
        'colStyleName2
        '
        Me.colStyleName2.FieldName = "StyleName2"
        Me.colStyleName2.Name = "colStyleName2"
        '
        'colStyleNameId
        '
        Me.colStyleNameId.FieldName = "StyleNameId"
        Me.colStyleNameId.Name = "colStyleNameId"
        '
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(385, 53)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 5
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerIdGridLookUpEditView
        '
        Me.BuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.colBuyerCode, Me.colBuyerName})
        Me.BuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerIdGridLookUpEditView.Name = "BuyerIdGridLookUpEditView"
        Me.BuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'ExDateDateEdit
        '
        Me.ExDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ExDate", True))
        Me.ExDateDateEdit.EditValue = Nothing
        Me.ExDateDateEdit.Location = New System.Drawing.Point(385, 100)
        Me.ExDateDateEdit.Name = "ExDateDateEdit"
        Me.ExDateDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ExDateDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ExDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ExDateDateEdit.Size = New System.Drawing.Size(138, 20)
        Me.ExDateDateEdit.TabIndex = 7
        '
        'RequestNoTextEdit
        '
        Me.RequestNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "RequestNo", True))
        Me.RequestNoTextEdit.Location = New System.Drawing.Point(143, 29)
        Me.RequestNoTextEdit.Name = "RequestNoTextEdit"
        Me.RequestNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RequestNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RequestNoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RequestNoTextEdit.Size = New System.Drawing.Size(123, 20)
        Me.RequestNoTextEdit.TabIndex = 0
        '
        'GarmentsDescriptionTextEdit
        '
        Me.GarmentsDescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "GarmentsDescription", True))
        Me.GarmentsDescriptionTextEdit.Location = New System.Drawing.Point(143, 125)
        Me.GarmentsDescriptionTextEdit.Name = "GarmentsDescriptionTextEdit"
        Me.GarmentsDescriptionTextEdit.Size = New System.Drawing.Size(380, 20)
        Me.GarmentsDescriptionTextEdit.TabIndex = 8
        '
        'RequestDateDateEdit
        '
        Me.RequestDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "RequestDate", True))
        Me.RequestDateDateEdit.EditValue = Nothing
        Me.RequestDateDateEdit.Location = New System.Drawing.Point(385, 29)
        Me.RequestDateDateEdit.Name = "RequestDateDateEdit"
        Me.RequestDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequestDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.RequestDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RequestDateDateEdit.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.RequestDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RequestDateDateEdit.Size = New System.Drawing.Size(138, 20)
        Me.RequestDateDateEdit.TabIndex = 4
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Delete
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(702, 4)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(5, 4, 3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DeleteButton.Size = New System.Drawing.Size(91, 26)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit2)
        Me.FlowLayoutPanel3.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(908, 32)
        Me.FlowLayoutPanel3.TabIndex = 4
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'SampleRequireQuantityTableAdapter
        '
        Me.SampleRequireQuantityTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestFinalDetailsTableAdapter
        '
        Me.SampleRequestFinalDetailsTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestFinalTableAdapter
        '
        Me.SampleRequestFinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricTableAdapter = Me.SampleFabricTableAdapter
        Me.TableAdapterManager.SamplePrintColorTableAdapter = Me.SamplePrintColorTableAdapter
        Me.TableAdapterManager.SampleRequestFinalDetailsTableAdapter = Me.SampleRequestFinalDetailsTableAdapter
        Me.TableAdapterManager.SampleRequestFinalTableAdapter = Me.SampleRequestFinalTableAdapter
        'Me.TableAdapterManager.SampleRequestNoLookupTableAdapter = Me.SampleRequestNoLookupTableAdapter
        Me.TableAdapterManager.SampleRequireQuantityTableAdapter = Me.SampleRequireQuantityTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SampleFabricTableAdapter
        '
        Me.SampleFabricTableAdapter.ClearBeforeFill = True
        '
        'SamplePrintColorTableAdapter
        '
        Me.SamplePrintColorTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SendPhotoStrikeOffCheckEdit)
        Me.GroupBox1.Controls.Add(Me.PrintSizeTextEdit)
        Me.GroupBox1.Controls.Add(Me.IsPrintCheckEdit)
        Me.GroupBox1.Controls.Add(Me.MesurementSpinEdit)
        Me.GroupBox1.Controls.Add(MesurementLabel)
        Me.GroupBox1.Controls.Add(Me.PrintTypeIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(PrintTypeIdLabel)
        Me.GroupBox1.Controls.Add(Me.PrintPositionTextEdit)
        Me.GroupBox1.Controls.Add(PrintPositionLabel)
        Me.GroupBox1.Controls.Add(Me.HeightSpinEdit)
        Me.GroupBox1.Controls.Add(HeightLabel)
        Me.GroupBox1.Controls.Add(SendPhotoStrikeOffLabel1)
        Me.GroupBox1.Controls.Add(Me.WidthSpinEdit)
        Me.GroupBox1.Controls.Add(WidthLabel)
        Me.GroupBox1.Controls.Add(PrintSizeLabel)
        Me.GroupBox1.Controls.Add(Me.ApplicationTextEdit)
        Me.GroupBox1.Controls.Add(ApplicationLabel)
        Me.GroupBox1.Controls.Add(Me.SpecialBackNeckReferenceTextEdit)
        Me.GroupBox1.Controls.Add(SpecialBackNeckReferenceLabel)
        Me.GroupBox1.Controls.Add(Me.ArtworkLocationTextEdit)
        Me.GroupBox1.Controls.Add(ArtworkLocationLabel)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(602, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 340)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Information"
        '
        'PrintSizeTextEdit
        '
        Me.PrintSizeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintSize", True))
        Me.PrintSizeTextEdit.Location = New System.Drawing.Point(157, 97)
        Me.PrintSizeTextEdit.Name = "PrintSizeTextEdit"
        Me.PrintSizeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintSizeTextEdit.TabIndex = 2
        '
        'MesurementSpinEdit
        '
        Me.MesurementSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Mesurement", True))
        Me.MesurementSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MesurementSpinEdit.Location = New System.Drawing.Point(157, 201)
        Me.MesurementSpinEdit.Name = "MesurementSpinEdit"
        Me.MesurementSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MesurementSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MesurementSpinEdit.TabIndex = 6
        '
        'PrintPositionTextEdit
        '
        Me.PrintPositionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintPosition", True))
        Me.PrintPositionTextEdit.Location = New System.Drawing.Point(157, 175)
        Me.PrintPositionTextEdit.Name = "PrintPositionTextEdit"
        Me.PrintPositionTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintPositionTextEdit.TabIndex = 5
        '
        'HeightSpinEdit
        '
        Me.HeightSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Height", True))
        Me.HeightSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HeightSpinEdit.Location = New System.Drawing.Point(157, 149)
        Me.HeightSpinEdit.Name = "HeightSpinEdit"
        Me.HeightSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HeightSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.HeightSpinEdit.TabIndex = 4
        '
        'WidthSpinEdit
        '
        Me.WidthSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Width", True))
        Me.WidthSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WidthSpinEdit.Location = New System.Drawing.Point(157, 123)
        Me.WidthSpinEdit.Name = "WidthSpinEdit"
        Me.WidthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.WidthSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.WidthSpinEdit.TabIndex = 3
        '
        'ApplicationTextEdit
        '
        Me.ApplicationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Application", True))
        Me.ApplicationTextEdit.Location = New System.Drawing.Point(157, 279)
        Me.ApplicationTextEdit.Name = "ApplicationTextEdit"
        Me.ApplicationTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ApplicationTextEdit.TabIndex = 9
        '
        'SpecialBackNeckReferenceTextEdit
        '
        Me.SpecialBackNeckReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SpecialBackNeckReference", True))
        Me.SpecialBackNeckReferenceTextEdit.Location = New System.Drawing.Point(157, 253)
        Me.SpecialBackNeckReferenceTextEdit.Name = "SpecialBackNeckReferenceTextEdit"
        Me.SpecialBackNeckReferenceTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.SpecialBackNeckReferenceTextEdit.TabIndex = 8
        '
        'ArtworkLocationTextEdit
        '
        Me.ArtworkLocationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ArtworkLocation", True))
        Me.ArtworkLocationTextEdit.Location = New System.Drawing.Point(157, 227)
        Me.ArtworkLocationTextEdit.Name = "ArtworkLocationTextEdit"
        Me.ArtworkLocationTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ArtworkLocationTextEdit.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.AddNewColorLinkLabel)
        Me.TabPage4.Controls.Add(Me.SampleRequestFinalDetailsGridControl)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(863, 165)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sample Color Details [For Body Only]"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'AddNewColorLinkLabel
        '
        Me.AddNewColorLinkLabel.AutoSize = True
        Me.AddNewColorLinkLabel.Enabled = False
        Me.AddNewColorLinkLabel.Location = New System.Drawing.Point(16, 7)
        Me.AddNewColorLinkLabel.Name = "AddNewColorLinkLabel"
        Me.AddNewColorLinkLabel.Size = New System.Drawing.Size(96, 13)
        Me.AddNewColorLinkLabel.TabIndex = 1
        Me.AddNewColorLinkLabel.TabStop = True
        Me.AddNewColorLinkLabel.Text = "Show Color Master"
        '
        'SampleRequestFinalDetailsGridControl
        '
        Me.SampleRequestFinalDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRequestFinalDetailsGridControl.DataSource = Me.SampleRequestFinalDetailsBindingSource
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.SampleRequestFinalDetailsGridControl.Location = New System.Drawing.Point(16, 23)
        Me.SampleRequestFinalDetailsGridControl.MainView = Me.GridView2
        Me.SampleRequestFinalDetailsGridControl.Name = "SampleRequestFinalDetailsGridControl"
        Me.SampleRequestFinalDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricTypeGridLookUpEdit, Me.CompositionGridLookUpEdit, Me.ColorItemGridLookUpEdit, Me.RepositoryItemButtonEdit1})
        Me.SampleRequestFinalDetailsGridControl.Size = New System.Drawing.Size(841, 126)
        Me.SampleRequestFinalDetailsGridControl.TabIndex = 0
        Me.SampleRequestFinalDetailsGridControl.UseEmbeddedNavigator = True
        Me.SampleRequestFinalDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SampleRequestFinalDetailsBindingSource
        '
        Me.SampleRequestFinalDetailsBindingSource.DataMember = "SampleRequestFinal_SampleRequestFinalDetails"
        Me.SampleRequestFinalDetailsBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'GridView2
        '
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestDetailsId, Me.colSampleRequestId2, Me.colKnittingTypeId1, Me.colCompositionId1, Me.colGSM, Me.colIsFabricAvailable, Me.colColor, Me.colELD, Me.colSampleSendDate, Me.colIsSealed, Me.colSealedDate, Me.colAgreedLeadTime, Me.colExFabricRcvDate, Me.colIsAOP, Me.colIsYDS, Me.colExSendDate, Me.colFabricColorId, Me.colRemarks})
        Me.GridView2.GridControl = Me.SampleRequestFinalDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSampleRequestDetailsId
        '
        Me.colSampleRequestDetailsId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleRequestDetailsId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleRequestDetailsId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleRequestDetailsId.FieldName = "SampleRequestDetailsId"
        Me.colSampleRequestDetailsId.Name = "colSampleRequestDetailsId"
        Me.colSampleRequestDetailsId.OptionsColumn.AllowEdit = False
        Me.colSampleRequestDetailsId.OptionsColumn.ReadOnly = True
        '
        'colSampleRequestId2
        '
        Me.colSampleRequestId2.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleRequestId2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleRequestId2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleRequestId2.FieldName = "SampleRequestId"
        Me.colSampleRequestId2.Name = "colSampleRequestId2"
        Me.colSampleRequestId2.OptionsColumn.AllowEdit = False
        Me.colSampleRequestId2.OptionsColumn.ReadOnly = True
        Me.colSampleRequestId2.Width = 133
        '
        'colKnittingTypeId1
        '
        Me.colKnittingTypeId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingTypeId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingTypeId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingTypeId1.Caption = "Fabric Type"
        Me.colKnittingTypeId1.ColumnEdit = Me.FabricTypeGridLookUpEdit
        Me.colKnittingTypeId1.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId1.Name = "colKnittingTypeId1"
        Me.colKnittingTypeId1.OptionsColumn.AllowEdit = False
        Me.colKnittingTypeId1.OptionsColumn.ReadOnly = True
        Me.colKnittingTypeId1.Visible = True
        Me.colKnittingTypeId1.VisibleIndex = 2
        Me.colKnittingTypeId1.Width = 82
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.AutoHeight = False
        Me.FabricTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.NullText = ""
        Me.FabricTypeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FabricTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
        Me.FabricTypeGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingTypeId2, Me.colKnittingType1, Me.colDiscontinue2, Me.colKnittingTypeCode1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId2
        '
        Me.colKnittingTypeId2.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId2.Name = "colKnittingTypeId2"
        Me.colKnittingTypeId2.OptionsColumn.ReadOnly = True
        '
        'colKnittingType1
        '
        Me.colKnittingType1.FieldName = "KnittingType"
        Me.colKnittingType1.Name = "colKnittingType1"
        Me.colKnittingType1.Visible = True
        Me.colKnittingType1.VisibleIndex = 0
        '
        'colDiscontinue2
        '
        Me.colDiscontinue2.FieldName = "Discontinue"
        Me.colDiscontinue2.Name = "colDiscontinue2"
        '
        'colKnittingTypeCode1
        '
        Me.colKnittingTypeCode1.FieldName = "KnittingTypeCode"
        Me.colKnittingTypeCode1.Name = "colKnittingTypeCode1"
        '
        'colCompositionId1
        '
        Me.colCompositionId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompositionId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompositionId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompositionId1.Caption = "Composition"
        Me.colCompositionId1.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId1.FieldName = "CompositionId"
        Me.colCompositionId1.Name = "colCompositionId1"
        Me.colCompositionId1.OptionsColumn.AllowEdit = False
        Me.colCompositionId1.OptionsColumn.ReadOnly = True
        Me.colCompositionId1.Visible = True
        Me.colCompositionId1.VisibleIndex = 3
        Me.colCompositionId1.Width = 98
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.ImmediatePopup = True
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.NullText = ""
        Me.CompositionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
        Me.CompositionGridLookUpEdit.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompositionId2, Me.colComposition1, Me.colDiscontinue3, Me.colCode1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCompositionId2
        '
        Me.colCompositionId2.FieldName = "CompositionId"
        Me.colCompositionId2.Name = "colCompositionId2"
        '
        'colComposition1
        '
        Me.colComposition1.FieldName = "Composition"
        Me.colComposition1.Name = "colComposition1"
        Me.colComposition1.Visible = True
        Me.colComposition1.VisibleIndex = 0
        '
        'colDiscontinue3
        '
        Me.colDiscontinue3.FieldName = "Discontinue"
        Me.colDiscontinue3.Name = "colDiscontinue3"
        '
        'colCode1
        '
        Me.colCode1.FieldName = "Code"
        Me.colCode1.Name = "colCode1"
        '
        'colGSM
        '
        Me.colGSM.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.OptionsColumn.AllowEdit = False
        Me.colGSM.OptionsColumn.ReadOnly = True
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 4
        Me.colGSM.Width = 54
        '
        'colIsFabricAvailable
        '
        Me.colIsFabricAvailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsFabricAvailable.Caption = "Fabric Available"
        Me.colIsFabricAvailable.FieldName = "IsFabricAvailable"
        Me.colIsFabricAvailable.Name = "colIsFabricAvailable"
        Me.colIsFabricAvailable.OptionsColumn.AllowEdit = False
        Me.colIsFabricAvailable.OptionsColumn.ReadOnly = True
        Me.colIsFabricAvailable.Visible = True
        Me.colIsFabricAvailable.VisibleIndex = 7
        Me.colIsFabricAvailable.Width = 76
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor.Caption = "Color(OLD)"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.AllowEdit = False
        Me.colColor.OptionsColumn.ReadOnly = True
        Me.colColor.Width = 151
        '
        'colELD
        '
        Me.colELD.AppearanceHeader.Options.UseTextOptions = True
        Me.colELD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colELD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colELD.FieldName = "ELD"
        Me.colELD.Name = "colELD"
        Me.colELD.OptionsColumn.AllowEdit = False
        Me.colELD.OptionsColumn.ReadOnly = True
        Me.colELD.Visible = True
        Me.colELD.VisibleIndex = 1
        Me.colELD.Width = 98
        '
        'colSampleSendDate
        '
        Me.colSampleSendDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSampleSendDate.AppearanceCell.Options.UseBackColor = True
        Me.colSampleSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleSendDate.FieldName = "SampleSendDate"
        Me.colSampleSendDate.Name = "colSampleSendDate"
        Me.colSampleSendDate.Visible = True
        Me.colSampleSendDate.VisibleIndex = 11
        Me.colSampleSendDate.Width = 78
        '
        'colIsSealed
        '
        Me.colIsSealed.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colIsSealed.AppearanceCell.Options.UseBackColor = True
        Me.colIsSealed.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSealed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSealed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSealed.FieldName = "IsSealed"
        Me.colIsSealed.Name = "colIsSealed"
        Me.colIsSealed.Visible = True
        Me.colIsSealed.VisibleIndex = 12
        Me.colIsSealed.Width = 56
        '
        'colSealedDate
        '
        Me.colSealedDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSealedDate.AppearanceCell.Options.UseBackColor = True
        Me.colSealedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSealedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSealedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSealedDate.FieldName = "SealedDate"
        Me.colSealedDate.Name = "colSealedDate"
        Me.colSealedDate.Visible = True
        Me.colSealedDate.VisibleIndex = 13
        Me.colSealedDate.Width = 72
        '
        'colAgreedLeadTime
        '
        Me.colAgreedLeadTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colAgreedLeadTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgreedLeadTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAgreedLeadTime.FieldName = "AgreedLeadTime"
        Me.colAgreedLeadTime.Name = "colAgreedLeadTime"
        Me.colAgreedLeadTime.OptionsColumn.AllowEdit = False
        Me.colAgreedLeadTime.OptionsColumn.ReadOnly = True
        Me.colAgreedLeadTime.Visible = True
        Me.colAgreedLeadTime.VisibleIndex = 9
        Me.colAgreedLeadTime.Width = 87
        '
        'colExFabricRcvDate
        '
        Me.colExFabricRcvDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExFabricRcvDate.FieldName = "ExFabricRcvDate"
        Me.colExFabricRcvDate.Name = "colExFabricRcvDate"
        Me.colExFabricRcvDate.OptionsColumn.AllowEdit = False
        Me.colExFabricRcvDate.OptionsColumn.ReadOnly = True
        Me.colExFabricRcvDate.Visible = True
        Me.colExFabricRcvDate.VisibleIndex = 8
        Me.colExFabricRcvDate.Width = 78
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAOP.Caption = "AOP"
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.OptionsColumn.AllowEdit = False
        Me.colIsAOP.OptionsColumn.ReadOnly = True
        Me.colIsAOP.Visible = True
        Me.colIsAOP.VisibleIndex = 6
        Me.colIsAOP.Width = 41
        '
        'colIsYDS
        '
        Me.colIsYDS.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYDS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYDS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYDS.Caption = "YDS"
        Me.colIsYDS.FieldName = "IsYDS"
        Me.colIsYDS.Name = "colIsYDS"
        Me.colIsYDS.OptionsColumn.AllowEdit = False
        Me.colIsYDS.OptionsColumn.ReadOnly = True
        Me.colIsYDS.Visible = True
        Me.colIsYDS.VisibleIndex = 5
        Me.colIsYDS.Width = 43
        '
        'colExSendDate
        '
        Me.colExSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExSendDate.FieldName = "ExSendDate"
        Me.colExSendDate.Name = "colExSendDate"
        Me.colExSendDate.Visible = True
        Me.colExSendDate.VisibleIndex = 10
        Me.colExSendDate.Width = 77
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.ColorItemGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 0
        Me.colFabricColorId.Width = 153
        '
        'ColorItemGridLookUpEdit
        '
        Me.ColorItemGridLookUpEdit.AutoHeight = False
        Me.ColorItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorItemGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.ColorItemGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorItemGridLookUpEdit.Name = "ColorItemGridLookUpEdit"
        Me.ColorItemGridLookUpEdit.NullText = ""
        Me.ColorItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ColorItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ColorItemGridLookUpEdit.ValueMember = "FabricColorId"
        Me.ColorItemGridLookUpEdit.View = Me.GridView4
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId1, Me.colFabricColorName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId1
        '
        Me.colFabricColorId1.FieldName = "FabricColorId"
        Me.colFabricColorId1.Name = "colFabricColorId1"
        Me.colFabricColorId1.OptionsColumn.ReadOnly = True
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.OptionsColumn.ReadOnly = True
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 14
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'SamplePrintColorDataGridView
        '
        Me.SamplePrintColorDataGridView.AllowUserToAddRows = False
        Me.SamplePrintColorDataGridView.AllowUserToDeleteRows = False
        Me.SamplePrintColorDataGridView.AutoGenerateColumns = False
        Me.SamplePrintColorDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SamplePrintColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SamplePrintColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SamplePrintColorDataGridView.DataSource = Me.SamplePrintColorBindingSource
        Me.SamplePrintColorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SamplePrintColorDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SamplePrintColorDataGridView.Name = "SamplePrintColorDataGridView"
        Me.SamplePrintColorDataGridView.ReadOnly = True
        Me.SamplePrintColorDataGridView.Size = New System.Drawing.Size(857, 159)
        Me.SamplePrintColorDataGridView.TabIndex = 0
        Me.SamplePrintColorDataGridView.Tag = "NR"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.SamplePrintColorDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(863, 165)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Color Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 393)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(871, 194)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.Tag = "NR"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.SampleRequireQuantityDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 165)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sizewise Require Quantity"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'frmSampleDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 599)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSampleDelivery"
        Me.Text = "frmSampleDelivery"
        CType(Me.TrimDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTrimCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendPhotoStrikeOffCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTrimAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbroideryDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SampleFabricDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequireQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequireQuantityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleUpdateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsDescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PrintSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesurementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPositionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialBackNeckReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtworkLocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.SampleRequestFinalDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents TrimDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleRequestFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestDataSet As KSoft_Apparel.SampleRequestDataSet
    Friend WithEvents IsTrimCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colStyle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequestId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AgreedLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SampleRequestNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SendPhotoStrikeOffCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsEmbroideryCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents colStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExTrimRcvDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents IsTrimAvailableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbroideryDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents colRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GetDataLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SampleFabricDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents SPNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MainFabric As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BookingQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsDelivered As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeliveredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintSend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleFabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleRequireQuantityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequireQuantityDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SamplePrintColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSampleRequestId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DevTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DevTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevTypeDataSet As KSoft_Apparel.DevTypeDataSet
    Friend WithEvents DevTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGMDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleUpdateCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNameId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequestNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GarmentsDescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequestDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents DevTypeMstTableAdapter As KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents SampleRequireQuantityTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequireQuantityTableAdapter
    Friend WithEvents SampleRequestNoLookupTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents SampleRequestFinalDetailsTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalDetailsTableAdapter
    Friend WithEvents SampleRequestFinalTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SampleFabricTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleFabricTableAdapter
    Friend WithEvents SamplePrintColorTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SamplePrintColorTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintSizeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MesurementSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PrintPositionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HeightSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WidthSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ApplicationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpecialBackNeckReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ArtworkLocationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents AddNewColorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SampleRequestFinalDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents SampleRequestFinalDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSampleRequestDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequestId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingTypeId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompositionId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFabricAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleSendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSealed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSealedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgreedLeadTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExFabricRcvDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYDS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExSendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColorItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SamplePrintColorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
End Class
