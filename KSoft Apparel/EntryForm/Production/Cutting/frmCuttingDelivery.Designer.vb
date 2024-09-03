<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuttingDelivery
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
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim ChallanForLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim BranchIdLabel As System.Windows.Forms.Label
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CuttingDeliveryCNDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CuttingDeliveryCNDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryDataSet = New KSoft_Apparel.CuttingDeliveryDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCuttingNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChallanLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CuttingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryChallanLookupDataSet = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanFor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.DelCNButton = New System.Windows.Forms.Button()
        Me.InsertCNButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuttingDeliveryDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LineGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuttingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProdPercentageGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChallanDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CuttingNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CuttingNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingNoLookupDataSet = New KSoft_Apparel.CuttingNoLookupDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCuttingNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LineGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchIdTextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanForLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.POQtyLabel = New System.Windows.Forms.Label()
        Me.CuttingDeliveryPODetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CuttingDeliveryPODetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderColorPOGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderColorPOLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderColorPOLookupDataSet = New KSoft_Apparel.OrderColorPOLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.EmbOrderGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EmbOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderLookupDataSet = New KSoft_Apparel.EmbOrderLookupDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CuttingDeliveryEmbDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CuttingDeliveryEmbDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmbOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbOrderDetailsGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.EmbOrderDetailsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderDetailsLookupDataSet = New KSoft_Apparel.EmbOrderDetailsLookupDataSet()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuanity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuttingDeliveryPrintDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CuttingDeliveryPrintDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PrintOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintProductionDataSet = New KSoft_Apparel.PrintProductionDataSet()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderSizeDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintOrderNewLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderNewLookupDataSet = New KSoft_Apparel.PrintOrderNewLookupDataSet()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CuttingDeliveryTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.TableAdapterManager()
        Me.CuttingDeliveryCNDetailsTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryCNDetailsTableAdapter()
        Me.CuttingDeliveryDetailsTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryDetailsTableAdapter()
        Me.CuttingDeliveryEmbDetailsTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryEmbDetailsTableAdapter()
        Me.CuttingDeliveryPODetailsTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryPODetailsTableAdapter()
        Me.CuttingDeliveryPrintDetailsTableAdapter = New KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.CuttingDeliveryPrintDetailsTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.OrderColorPOLookupTableAdapter = New KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.CuttingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter()
        Me.CuttingNoLookupTableAdapter = New KSoft_Apparel.CuttingNoLookupDataSetTableAdapters.CuttingNoLookupTableAdapter()
        Me.EmbOrderDetailsLookupTableAdapter = New KSoft_Apparel.EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupTableAdapter()
        Me.EmbOrderLookupTableAdapter = New KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter()
        Me.PrintOrderLookupTableAdapter = New KSoft_Apparel.PrintProductionDataSetTableAdapters.PrintOrderLookupTableAdapter()
        Me.PrintOrderNewLookupTableAdapter = New KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter()
        ChallanNoLabel = New System.Windows.Forms.Label()
        ChallanDateLabel = New System.Windows.Forms.Label()
        ChallanForLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        BranchIdLabel = New System.Windows.Forms.Label()
        OrderIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CuttingDeliveryCNDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryCNDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanForLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.CuttingDeliveryPODetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryPODetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.EmbOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryEmbDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryEmbDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryPrintDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryPrintDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(15, 49)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 2
        ChallanNoLabel.Text = "Challan No:"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(15, 73)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(72, 13)
        ChallanDateLabel.TabIndex = 4
        ChallanDateLabel.Text = "Challan Date:"
        '
        'ChallanForLabel
        '
        ChallanForLabel.AutoSize = True
        ChallanForLabel.Location = New System.Drawing.Point(15, 98)
        ChallanForLabel.Name = "ChallanForLabel"
        ChallanForLabel.Size = New System.Drawing.Size(65, 13)
        ChallanForLabel.TabIndex = 6
        ChallanForLabel.Text = "Challan For:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(15, 198)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(52, 13)
        SupplierIdLabel.TabIndex = 8
        SupplierIdLabel.Text = "Supplier :"
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(15, 173)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(44, 13)
        BranchIdLabel.TabIndex = 10
        BranchIdLabel.Text = "Branch:"
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(15, 122)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(67, 13)
        OrderIdLabel.TabIndex = 12
        OrderIdLabel.Text = "Program No:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(15, 223)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 14
        RemarksLabel.Text = "Remarks:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(6, 8)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(78, 13)
        Label4.TabIndex = 55
        Label4.Text = "EMB Order No:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(4, 9)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 13)
        Label5.TabIndex = 55
        Label5.Text = "Print Order No:"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CuttingDeliveryCNDetailsGridControl)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DelCNButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.InsertCNButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.InsertButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FabricColorComboBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CuttingDeliveryDetailsGridControl)
        Me.SplitContainerControl1.Panel1.Controls.Add(ChallanNoLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ChallanNoTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(ChallanDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ChallanDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(ChallanForLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(SupplierIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(BranchIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(RemarksLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.RemarksTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CuttingNoGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LineGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BranchIdTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ChallanForLookupEdit)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1355, 674)
        Me.SplitContainerControl1.SplitterPosition = 307
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CuttingDeliveryCNDetailsGridControl
        '
        Me.CuttingDeliveryCNDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingDeliveryCNDetailsGridControl.DataSource = Me.CuttingDeliveryCNDetailsBindingSource
        Me.CuttingDeliveryCNDetailsGridControl.Location = New System.Drawing.Point(1027, 72)
        Me.CuttingDeliveryCNDetailsGridControl.MainView = Me.GridView8
        Me.CuttingDeliveryCNDetailsGridControl.Name = "CuttingDeliveryCNDetailsGridControl"
        Me.CuttingDeliveryCNDetailsGridControl.Size = New System.Drawing.Size(300, 216)
        Me.CuttingDeliveryCNDetailsGridControl.TabIndex = 53
        Me.CuttingDeliveryCNDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'CuttingDeliveryCNDetailsBindingSource
        '
        Me.CuttingDeliveryCNDetailsBindingSource.DataMember = "CuttingDeliveryDetails_CuttingDeliveryCNDetails"
        Me.CuttingDeliveryCNDetailsBindingSource.DataSource = Me.CuttingDeliveryDetailsBindingSource
        '
        'CuttingDeliveryDetailsBindingSource
        '
        Me.CuttingDeliveryDetailsBindingSource.DataMember = "FK_CuttingDeliveryDetailsColorwise_CuttingDelivery"
        Me.CuttingDeliveryDetailsBindingSource.DataSource = Me.CuttingDeliveryBindingSource
        '
        'CuttingDeliveryBindingSource
        '
        Me.CuttingDeliveryBindingSource.DataMember = "CuttingDelivery"
        Me.CuttingDeliveryBindingSource.DataSource = Me.CuttingDeliveryDataSet
        '
        'CuttingDeliveryDataSet
        '
        Me.CuttingDeliveryDataSet.DataSetName = "CuttingDeliveryDataSet"
        Me.CuttingDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCuttingNo, Me.colInputQuantity2})
        Me.GridView8.GridControl = Me.CuttingDeliveryCNDetailsGridControl
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsView.ShowFooter = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCuttingNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCuttingNo
        '
        Me.colCuttingNo.FieldName = "CuttingNo"
        Me.colCuttingNo.Name = "colCuttingNo"
        Me.colCuttingNo.OptionsColumn.AllowEdit = False
        Me.colCuttingNo.OptionsColumn.ReadOnly = True
        Me.colCuttingNo.Visible = True
        Me.colCuttingNo.VisibleIndex = 0
        '
        'colInputQuantity2
        '
        Me.colInputQuantity2.FieldName = "InputQuantity"
        Me.colInputQuantity2.Name = "colInputQuantity2"
        Me.colInputQuantity2.OptionsColumn.AllowEdit = False
        Me.colInputQuantity2.OptionsColumn.ReadOnly = True
        Me.colInputQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0.##}")})
        Me.colInputQuantity2.Visible = True
        Me.colInputQuantity2.VisibleIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChallanLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1355, 35)
        Me.FlowLayoutPanel1.TabIndex = 52
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(82, 27)
        Me.NewButton.TabIndex = 4
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(91, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 27)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(160, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 27)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(229, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 27)
        Me.CancelEntryButton.TabIndex = 7
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshButton.Location = New System.Drawing.Point(298, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 27)
        Me.RefreshButton.TabIndex = 48
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        Me.RefreshButton.Visible = False
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Location = New System.Drawing.Point(379, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 27)
        Me.PrintButton.TabIndex = 35
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Challan No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChallanLookupGridLookUpEdit
        '
        Me.ChallanLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ChallanLookupGridLookUpEdit.Location = New System.Drawing.Point(592, 7)
        Me.ChallanLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ChallanLookupGridLookUpEdit.Name = "ChallanLookupGridLookUpEdit"
        Me.ChallanLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanLookupGridLookUpEdit.Properties.DataSource = Me.CuttingDeliveryChallanLookupBindingSource
        Me.ChallanLookupGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ChallanLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanLookupGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.ChallanLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.ChallanLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanLookupGridLookUpEdit.Properties.ValueMember = "CuttingDeliveryId"
        Me.ChallanLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.ChallanLookupGridLookUpEdit.TabIndex = 36
        Me.ChallanLookupGridLookUpEdit.Tag = "NR"
        '
        'CuttingDeliveryChallanLookupBindingSource
        '
        Me.CuttingDeliveryChallanLookupBindingSource.DataMember = "CuttingDeliveryChallanLookup"
        Me.CuttingDeliveryChallanLookupBindingSource.DataSource = Me.CuttingDeliveryChallanLookupDataSet
        '
        'CuttingDeliveryChallanLookupDataSet
        '
        Me.CuttingDeliveryChallanLookupDataSet.DataSetName = "CuttingDeliveryChallanLookupDataSet"
        Me.CuttingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate, Me.colChallanFor})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 0
        '
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'colChallanFor
        '
        Me.colChallanFor.FieldName = "ChallanFor"
        Me.colChallanFor.Name = "colChallanFor"
        Me.colChallanFor.Visible = True
        Me.colChallanFor.VisibleIndex = 2
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(849, 6)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'DelCNButton
        '
        Me.DelCNButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelCNButton.Location = New System.Drawing.Point(1252, 46)
        Me.DelCNButton.Name = "DelCNButton"
        Me.DelCNButton.Size = New System.Drawing.Size(75, 23)
        Me.DelCNButton.TabIndex = 27
        Me.DelCNButton.Text = "CN Delete"
        Me.DelCNButton.UseVisualStyleBackColor = True
        '
        'InsertCNButton
        '
        Me.InsertCNButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InsertCNButton.Location = New System.Drawing.Point(1133, 46)
        Me.InsertCNButton.Name = "InsertCNButton"
        Me.InsertCNButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertCNButton.TabIndex = 27
        Me.InsertCNButton.Text = "Get Data"
        Me.InsertCNButton.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(698, 44)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertButton.TabIndex = 27
        Me.InsertButton.Text = "Get Data"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(396, 45)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(138, 21)
        Me.FabricColorComboBox.TabIndex = 25
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(553, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Line :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Color"
        '
        'CuttingDeliveryDetailsGridControl
        '
        Me.CuttingDeliveryDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingDeliveryDetailsGridControl.DataSource = Me.CuttingDeliveryDetailsBindingSource
        Me.CuttingDeliveryDetailsGridControl.Location = New System.Drawing.Point(348, 72)
        Me.CuttingDeliveryDetailsGridControl.MainView = Me.GridView1
        Me.CuttingDeliveryDetailsGridControl.Name = "CuttingDeliveryDetailsGridControl"
        Me.CuttingDeliveryDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LineGridLookUpEdit1, Me.GMTColorGridLookUpEdit, Me.SizeGridLookUpEdit1})
        Me.CuttingDeliveryDetailsGridControl.Size = New System.Drawing.Size(657, 216)
        Me.CuttingDeliveryDetailsGridControl.TabIndex = 24
        Me.CuttingDeliveryDetailsGridControl.UseEmbeddedNavigator = True
        Me.CuttingDeliveryDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colSizeId, Me.colInputQuantity, Me.colLineId, Me.colRemarks, Me.colInputBalance, Me.colOrderQuantity, Me.colCuttingQuantity, Me.ProdPercentageGridColumn, Me.colProdPercentage})
        Me.GridView1.GridControl = Me.CuttingDeliveryDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Garments Color"
        Me.colFabricColorId.ColumnEdit = Me.GMTColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 1
        Me.colFabricColorId.Width = 65
        '
        'GMTColorGridLookUpEdit
        '
        Me.GMTColorGridLookUpEdit.AutoHeight = False
        Me.GMTColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMTColorGridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.GMTColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.GMTColorGridLookUpEdit.Name = "GMTColorGridLookUpEdit"
        Me.GMTColorGridLookUpEdit.NullText = ""
        Me.GMTColorGridLookUpEdit.PopupView = Me.GridView6
        Me.GMTColorGridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeGridLookUpEdit1
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.OptionsColumn.AllowEdit = False
        Me.colSizeId.OptionsColumn.ReadOnly = True
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 2
        Me.colSizeId.Width = 45
        '
        'SizeGridLookUpEdit1
        '
        Me.SizeGridLookUpEdit1.AutoHeight = False
        Me.SizeGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit1.DataSource = Me.SizeLookupBindingSource
        Me.SizeGridLookUpEdit1.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit1.Name = "SizeGridLookUpEdit1"
        Me.SizeGridLookUpEdit1.PopupView = Me.GridView7
        Me.SizeGridLookUpEdit1.ValueMember = "SizeId"
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeLookupDataSet
        '
        'SizeLookupDataSet
        '
        Me.SizeLookupDataSet.DataSetName = "SizeLookupDataSet"
        Me.SizeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colInputQuantity
        '
        Me.colInputQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colInputQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colInputQuantity.Caption = "Input Quantity"
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0.##}")})
        Me.colInputQuantity.Visible = True
        Me.colInputQuantity.VisibleIndex = 6
        Me.colInputQuantity.Width = 56
        '
        'colLineId
        '
        Me.colLineId.Caption = "Line"
        Me.colLineId.ColumnEdit = Me.LineGridLookUpEdit1
        Me.colLineId.FieldName = "LineId"
        Me.colLineId.Name = "colLineId"
        Me.colLineId.OptionsColumn.AllowEdit = False
        Me.colLineId.OptionsColumn.ReadOnly = True
        Me.colLineId.Visible = True
        Me.colLineId.VisibleIndex = 0
        Me.colLineId.Width = 40
        '
        'LineGridLookUpEdit1
        '
        Me.LineGridLookUpEdit1.AutoHeight = False
        Me.LineGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineGridLookUpEdit1.DataSource = Me.LineBindingSource
        Me.LineGridLookUpEdit1.DisplayMember = "Line"
        Me.LineGridLookUpEdit1.Name = "LineGridLookUpEdit1"
        Me.LineGridLookUpEdit1.PopupView = Me.GridView5
        Me.LineGridLookUpEdit1.ValueMember = "LineId"
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colLine
        '
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.OptionsColumn.ReadOnly = True
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        Me.colRemarks.Width = 192
        '
        'colInputBalance
        '
        Me.colInputBalance.FieldName = "InputBalance"
        Me.colInputBalance.Name = "colInputBalance"
        Me.colInputBalance.OptionsColumn.AllowEdit = False
        Me.colInputBalance.OptionsColumn.ReadOnly = True
        Me.colInputBalance.Visible = True
        Me.colInputBalance.VisibleIndex = 5
        Me.colInputBalance.Width = 52
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.Caption = "Order Quantity With C%"
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:0.##}")})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 3
        Me.colOrderQuantity.Width = 90
        '
        'colCuttingQuantity
        '
        Me.colCuttingQuantity.FieldName = "CuttingQuantity"
        Me.colCuttingQuantity.Name = "colCuttingQuantity"
        Me.colCuttingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CuttingQuantity", "{0:0.##}")})
        Me.colCuttingQuantity.Visible = True
        Me.colCuttingQuantity.VisibleIndex = 4
        Me.colCuttingQuantity.Width = 50
        '
        'ProdPercentageGridColumn
        '
        Me.ProdPercentageGridColumn.Caption = "Prod Percentage"
        Me.ProdPercentageGridColumn.Name = "ProdPercentageGridColumn"
        Me.ProdPercentageGridColumn.Width = 211
        '
        'colProdPercentage
        '
        Me.colProdPercentage.Caption = "Require Excess Input Percentage"
        Me.colProdPercentage.FieldName = "ProdPercentage"
        Me.colProdPercentage.Name = "colProdPercentage"
        Me.colProdPercentage.Width = 95
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "ChallanNo", True))
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(122, 46)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ChallanNoTextEdit.TabIndex = 3
        '
        'ChallanDateDateEdit
        '
        Me.ChallanDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "ChallanDate", True))
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(122, 70)
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ChallanDateDateEdit.TabIndex = 5
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(122, 195)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(212, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 9
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Enabled = False
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(122, 119)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(212, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 13
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(122, 220)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(212, 68)
        Me.RemarksTextEdit.TabIndex = 15
        '
        'CuttingNoGridLookUpEdit
        '
        Me.CuttingNoGridLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingNoGridLookUpEdit.Location = New System.Drawing.Point(1027, 48)
        Me.CuttingNoGridLookUpEdit.Name = "CuttingNoGridLookUpEdit"
        Me.CuttingNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CuttingNoGridLookUpEdit.Properties.DataSource = Me.CuttingNoLookupBindingSource
        Me.CuttingNoGridLookUpEdit.Properties.DisplayMember = "CuttingNo"
        Me.CuttingNoGridLookUpEdit.Properties.NullText = ""
        Me.CuttingNoGridLookUpEdit.Properties.PopupView = Me.GridView9
        Me.CuttingNoGridLookUpEdit.Properties.ValueMember = "CuttingNo"
        Me.CuttingNoGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.CuttingNoGridLookUpEdit.TabIndex = 11
        '
        'CuttingNoLookupBindingSource
        '
        Me.CuttingNoLookupBindingSource.DataMember = "CuttingNoLookup"
        Me.CuttingNoLookupBindingSource.DataSource = Me.CuttingNoLookupDataSet
        '
        'CuttingNoLookupDataSet
        '
        Me.CuttingNoLookupDataSet.DataSetName = "CuttingNoLookupDataSet"
        Me.CuttingNoLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCuttingNo1})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colCuttingNo1
        '
        Me.colCuttingNo1.FieldName = "CuttingNo"
        Me.colCuttingNo1.Name = "colCuttingNo1"
        Me.colCuttingNo1.Visible = True
        Me.colCuttingNo1.VisibleIndex = 0
        '
        'LineGridLookUpEdit
        '
        Me.LineGridLookUpEdit.Location = New System.Drawing.Point(592, 46)
        Me.LineGridLookUpEdit.Name = "LineGridLookUpEdit"
        Me.LineGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineGridLookUpEdit.Properties.DataSource = Me.LineBindingSource
        Me.LineGridLookUpEdit.Properties.DisplayMember = "Line"
        Me.LineGridLookUpEdit.Properties.NullText = ""
        Me.LineGridLookUpEdit.Properties.PopupView = Me.GridView3
        Me.LineGridLookUpEdit.Properties.ValueMember = "LineId"
        Me.LineGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.LineGridLookUpEdit.TabIndex = 11
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colLine1
        '
        Me.colLine1.FieldName = "Line"
        Me.colLine1.Name = "colLine1"
        Me.colLine1.Visible = True
        Me.colLine1.VisibleIndex = 0
        '
        'BranchIdTextEdit
        '
        Me.BranchIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "BranchId", True))
        Me.BranchIdTextEdit.Location = New System.Drawing.Point(122, 170)
        Me.BranchIdTextEdit.Name = "BranchIdTextEdit"
        Me.BranchIdTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchIdTextEdit.Properties.DataSource = Me.BranchBindingSource
        Me.BranchIdTextEdit.Properties.DisplayMember = "BranchName"
        Me.BranchIdTextEdit.Properties.ImmediatePopup = True
        Me.BranchIdTextEdit.Properties.NullText = ""
        Me.BranchIdTextEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.BranchIdTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BranchIdTextEdit.Properties.ValueMember = "BranchId"
        Me.BranchIdTextEdit.Size = New System.Drawing.Size(212, 20)
        Me.BranchIdTextEdit.TabIndex = 11
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'ChallanForLookupEdit
        '
        Me.ChallanForLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "ChallanFor", True))
        Me.ChallanForLookupEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ChallanForLookupEdit.Enabled = False
        Me.ChallanForLookupEdit.Location = New System.Drawing.Point(122, 95)
        Me.ChallanForLookupEdit.Name = "ChallanForLookupEdit"
        Me.ChallanForLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanForLookupEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ChallanForLookupEdit.Properties.NullText = ""
        Me.ChallanForLookupEdit.Properties.PopupSizeable = False
        Me.ChallanForLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanForLookupEdit.Size = New System.Drawing.Size(100, 20)
        Me.ChallanForLookupEdit.TabIndex = 7
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.POQtyLabel)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.CuttingDeliveryPODetailsGridControl)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.DeleteLinkLabel)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1355, 362)
        Me.SplitContainerControl2.SplitterPosition = 529
        Me.SplitContainerControl2.TabIndex = 1
        '
        'POQtyLabel
        '
        Me.POQtyLabel.AutoSize = True
        Me.POQtyLabel.Location = New System.Drawing.Point(119, 9)
        Me.POQtyLabel.Name = "POQtyLabel"
        Me.POQtyLabel.Size = New System.Drawing.Size(21, 13)
        Me.POQtyLabel.TabIndex = 54
        Me.POQtyLabel.Text = "PO"
        '
        'CuttingDeliveryPODetailsGridControl
        '
        Me.CuttingDeliveryPODetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingDeliveryPODetailsGridControl.DataSource = Me.CuttingDeliveryPODetailsBindingSource
        Me.CuttingDeliveryPODetailsGridControl.Location = New System.Drawing.Point(0, 33)
        Me.CuttingDeliveryPODetailsGridControl.MainView = Me.GridView2
        Me.CuttingDeliveryPODetailsGridControl.Name = "CuttingDeliveryPODetailsGridControl"
        Me.CuttingDeliveryPODetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OrderColorPOGridLookUpEdit})
        Me.CuttingDeliveryPODetailsGridControl.Size = New System.Drawing.Size(529, 329)
        Me.CuttingDeliveryPODetailsGridControl.TabIndex = 0
        Me.CuttingDeliveryPODetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CuttingDeliveryPODetailsBindingSource
        '
        Me.CuttingDeliveryPODetailsBindingSource.DataMember = "FK_CuttingDeliveryPODetails_CuttingDeliveryDetails"
        Me.CuttingDeliveryPODetailsBindingSource.DataSource = Me.CuttingDeliveryDetailsBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId, Me.colInputQuantity1, Me.colRemarks1, Me.colInputBalance1, Me.colOrderQuantity1, Me.colOrderDetailsId1})
        Me.GridView2.GridControl = Me.CuttingDeliveryPODetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.Caption = "Order Details"
        Me.colOrderDetailsId.ColumnEdit = Me.OrderColorPOGridLookUpEdit
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.Visible = True
        Me.colOrderDetailsId.VisibleIndex = 0
        Me.colOrderDetailsId.Width = 207
        '
        'OrderColorPOGridLookUpEdit
        '
        Me.OrderColorPOGridLookUpEdit.AutoHeight = False
        Me.OrderColorPOGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderColorPOGridLookUpEdit.DataSource = Me.OrderColorPOLookupBindingSource
        Me.OrderColorPOGridLookUpEdit.DisplayMember = "Details"
        Me.OrderColorPOGridLookUpEdit.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.OrderColorPOGridLookUpEdit.Name = "OrderColorPOGridLookUpEdit"
        Me.OrderColorPOGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.OrderColorPOGridLookUpEdit.ValueMember = "OrderDetailsId"
        '
        'OrderColorPOLookupBindingSource
        '
        Me.OrderColorPOLookupBindingSource.DataMember = "OrderColorPOLookup"
        Me.OrderColorPOLookupBindingSource.DataSource = Me.OrderColorPOLookupDataSet
        '
        'OrderColorPOLookupDataSet
        '
        Me.OrderColorPOLookupDataSet.DataSetName = "OrderColorPOLookupDataSet"
        Me.OrderColorPOLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'colInputQuantity1
        '
        Me.colInputQuantity1.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colInputQuantity1.AppearanceCell.Options.UseBackColor = True
        Me.colInputQuantity1.FieldName = "InputQuantity"
        Me.colInputQuantity1.Name = "colInputQuantity1"
        Me.colInputQuantity1.OptionsColumn.AllowEdit = False
        Me.colInputQuantity1.OptionsColumn.ReadOnly = True
        Me.colInputQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0.##}")})
        Me.colInputQuantity1.Visible = True
        Me.colInputQuantity1.VisibleIndex = 2
        Me.colInputQuantity1.Width = 104
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Width = 424
        '
        'colInputBalance1
        '
        Me.colInputBalance1.FieldName = "InputBalance"
        Me.colInputBalance1.Name = "colInputBalance1"
        Me.colInputBalance1.Visible = True
        Me.colInputBalance1.VisibleIndex = 3
        Me.colInputBalance1.Width = 88
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.VisibleIndex = 1
        Me.colOrderQuantity1.Width = 117
        '
        'colOrderDetailsId1
        '
        Me.colOrderDetailsId1.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId1.Name = "colOrderDetailsId1"
        Me.colOrderDetailsId1.Width = 99
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(15, 9)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(90, 13)
        Me.DeleteLinkLabel.TabIndex = 53
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete PO Details"
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.EmbOrderGridLookUpEdit)
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.CuttingDeliveryEmbDetailsGridControl)
        Me.SplitContainerControl3.Panel1.Controls.Add(Label4)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.CuttingDeliveryPrintDetailsGridControl)
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.PrintOrderGridLookUpEdit)
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainerControl3.Panel2.Controls.Add(Label5)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(821, 362)
        Me.SplitContainerControl3.SplitterPosition = 418
        Me.SplitContainerControl3.TabIndex = 56
        '
        'EmbOrderGridLookUpEdit
        '
        Me.EmbOrderGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "EmbOrderId", True))
        Me.EmbOrderGridLookUpEdit.Enabled = False
        Me.EmbOrderGridLookUpEdit.Location = New System.Drawing.Point(90, 6)
        Me.EmbOrderGridLookUpEdit.Name = "EmbOrderGridLookUpEdit"
        Me.EmbOrderGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderGridLookUpEdit.Properties.DataSource = Me.EmbOrderLookupBindingSource
        Me.EmbOrderGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.EmbOrderGridLookUpEdit.Properties.ImmediatePopup = True
        Me.EmbOrderGridLookUpEdit.Properties.NullText = ""
        Me.EmbOrderGridLookUpEdit.Properties.PopupView = Me.GridView11
        Me.EmbOrderGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.EmbOrderGridLookUpEdit.Properties.ValueMember = "EmbOrderId"
        Me.EmbOrderGridLookUpEdit.Size = New System.Drawing.Size(201, 20)
        Me.EmbOrderGridLookUpEdit.TabIndex = 13
        '
        'EmbOrderLookupBindingSource
        '
        Me.EmbOrderLookupBindingSource.DataMember = "EmbOrderLookup"
        Me.EmbOrderLookupBindingSource.DataSource = Me.EmbOrderLookupDataSet
        '
        'EmbOrderLookupDataSet
        '
        Me.EmbOrderLookupDataSet.DataSetName = "EmbOrderLookupDataSet"
        Me.EmbOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Details"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Get Emb Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CuttingDeliveryEmbDetailsGridControl
        '
        Me.CuttingDeliveryEmbDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingDeliveryEmbDetailsGridControl.DataSource = Me.CuttingDeliveryEmbDetailsBindingSource
        Me.CuttingDeliveryEmbDetailsGridControl.Location = New System.Drawing.Point(3, 33)
        Me.CuttingDeliveryEmbDetailsGridControl.MainView = Me.GridView10
        Me.CuttingDeliveryEmbDetailsGridControl.Name = "CuttingDeliveryEmbDetailsGridControl"
        Me.CuttingDeliveryEmbDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.EmbOrderDetailsGridLookUpEdit})
        Me.CuttingDeliveryEmbDetailsGridControl.Size = New System.Drawing.Size(411, 329)
        Me.CuttingDeliveryEmbDetailsGridControl.TabIndex = 0
        Me.CuttingDeliveryEmbDetailsGridControl.UseEmbeddedNavigator = True
        Me.CuttingDeliveryEmbDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'CuttingDeliveryEmbDetailsBindingSource
        '
        Me.CuttingDeliveryEmbDetailsBindingSource.DataMember = "FK_CuttingDeliveryEmbDetails_CuttingDeliveryDetails"
        Me.CuttingDeliveryEmbDetailsBindingSource.DataSource = Me.CuttingDeliveryDetailsBindingSource
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmbOrderDetailsId, Me.colInputQuanity})
        Me.GridView10.GridControl = Me.CuttingDeliveryEmbDetailsGridControl
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colEmbOrderDetailsId
        '
        Me.colEmbOrderDetailsId.Caption = "Emb Order Details"
        Me.colEmbOrderDetailsId.ColumnEdit = Me.EmbOrderDetailsGridLookUpEdit
        Me.colEmbOrderDetailsId.FieldName = "EmbOrderDetailsId"
        Me.colEmbOrderDetailsId.Name = "colEmbOrderDetailsId"
        Me.colEmbOrderDetailsId.Visible = True
        Me.colEmbOrderDetailsId.VisibleIndex = 0
        '
        'EmbOrderDetailsGridLookUpEdit
        '
        Me.EmbOrderDetailsGridLookUpEdit.AutoHeight = False
        Me.EmbOrderDetailsGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderDetailsGridLookUpEdit.DataSource = Me.EmbOrderDetailsLookupBindingSource
        Me.EmbOrderDetailsGridLookUpEdit.DisplayMember = "Details"
        Me.EmbOrderDetailsGridLookUpEdit.Name = "EmbOrderDetailsGridLookUpEdit"
        Me.EmbOrderDetailsGridLookUpEdit.PopupView = Me.GridView12
        Me.EmbOrderDetailsGridLookUpEdit.ValueMember = "EmbOrderDetailsId"
        '
        'EmbOrderDetailsLookupBindingSource
        '
        Me.EmbOrderDetailsLookupBindingSource.DataMember = "EmbOrderDetailsLookup"
        Me.EmbOrderDetailsLookupBindingSource.DataSource = Me.EmbOrderDetailsLookupDataSet
        '
        'EmbOrderDetailsLookupDataSet
        '
        Me.EmbOrderDetailsLookupDataSet.DataSetName = "EmbOrderDetailsLookupDataSet"
        Me.EmbOrderDetailsLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails2})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'colInputQuanity
        '
        Me.colInputQuanity.FieldName = "InputQuanity"
        Me.colInputQuanity.Name = "colInputQuanity"
        Me.colInputQuanity.Visible = True
        Me.colInputQuanity.VisibleIndex = 1
        '
        'CuttingDeliveryPrintDetailsGridControl
        '
        Me.CuttingDeliveryPrintDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingDeliveryPrintDetailsGridControl.DataSource = Me.CuttingDeliveryPrintDetailsBindingSource
        Me.CuttingDeliveryPrintDetailsGridControl.Location = New System.Drawing.Point(7, 33)
        Me.CuttingDeliveryPrintDetailsGridControl.MainView = Me.GridView14
        Me.CuttingDeliveryPrintDetailsGridControl.Name = "CuttingDeliveryPrintDetailsGridControl"
        Me.CuttingDeliveryPrintDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PrintOrderLookupGridLookUpEdit})
        Me.CuttingDeliveryPrintDetailsGridControl.Size = New System.Drawing.Size(383, 329)
        Me.CuttingDeliveryPrintDetailsGridControl.TabIndex = 55
        Me.CuttingDeliveryPrintDetailsGridControl.UseEmbeddedNavigator = True
        Me.CuttingDeliveryPrintDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView14})
        '
        'CuttingDeliveryPrintDetailsBindingSource
        '
        Me.CuttingDeliveryPrintDetailsBindingSource.DataMember = "FK_CuttingDeliveryPrintDetails_CuttingDeliveryDetails"
        Me.CuttingDeliveryPrintDetailsBindingSource.DataSource = Me.CuttingDeliveryDetailsBindingSource
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintOrderId, Me.colPrintOrderSizeDetailsId, Me.colInputQuantity3})
        Me.GridView14.GridControl = Me.CuttingDeliveryPrintDetailsGridControl
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsView.ShowFooter = True
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colPrintOrderId
        '
        Me.colPrintOrderId.Caption = "Print Order Details"
        Me.colPrintOrderId.ColumnEdit = Me.PrintOrderLookupGridLookUpEdit
        Me.colPrintOrderId.FieldName = "PrintOrderId"
        Me.colPrintOrderId.Name = "colPrintOrderId"
        Me.colPrintOrderId.Visible = True
        Me.colPrintOrderId.VisibleIndex = 0
        '
        'PrintOrderLookupGridLookUpEdit
        '
        Me.PrintOrderLookupGridLookUpEdit.AutoHeight = False
        Me.PrintOrderLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintOrderLookupGridLookUpEdit.DataSource = Me.PrintOrderLookupBindingSource
        Me.PrintOrderLookupGridLookUpEdit.DisplayMember = "Details"
        Me.PrintOrderLookupGridLookUpEdit.Name = "PrintOrderLookupGridLookUpEdit"
        Me.PrintOrderLookupGridLookUpEdit.PopupView = Me.GridView15
        Me.PrintOrderLookupGridLookUpEdit.ValueMember = "PrintOrderId"
        '
        'PrintOrderLookupBindingSource
        '
        Me.PrintOrderLookupBindingSource.DataMember = "PrintOrderLookup"
        Me.PrintOrderLookupBindingSource.DataSource = Me.PrintProductionDataSet
        '
        'PrintProductionDataSet
        '
        Me.PrintProductionDataSet.DataSetName = "PrintProductionDataSet"
        Me.PrintProductionDataSet.EnforceConstraints = False
        Me.PrintProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails4})
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'colDetails4
        '
        Me.colDetails4.FieldName = "Details"
        Me.colDetails4.Name = "colDetails4"
        Me.colDetails4.Visible = True
        Me.colDetails4.VisibleIndex = 0
        '
        'colPrintOrderSizeDetailsId
        '
        Me.colPrintOrderSizeDetailsId.FieldName = "PrintOrderSizeDetailsId"
        Me.colPrintOrderSizeDetailsId.Name = "colPrintOrderSizeDetailsId"
        '
        'colInputQuantity3
        '
        Me.colInputQuantity3.FieldName = "InputQuantity"
        Me.colInputQuantity3.Name = "colInputQuantity3"
        Me.colInputQuantity3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0}")})
        Me.colInputQuantity3.Visible = True
        Me.colInputQuantity3.VisibleIndex = 1
        '
        'PrintOrderGridLookUpEdit
        '
        Me.PrintOrderGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CuttingDeliveryBindingSource, "PrintOrderNewId", True))
        Me.PrintOrderGridLookUpEdit.Enabled = False
        Me.PrintOrderGridLookUpEdit.Location = New System.Drawing.Point(101, 6)
        Me.PrintOrderGridLookUpEdit.Name = "PrintOrderGridLookUpEdit"
        Me.PrintOrderGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintOrderGridLookUpEdit.Properties.DataSource = Me.PrintOrderNewLookupBindingSource
        Me.PrintOrderGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.PrintOrderGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrintOrderGridLookUpEdit.Properties.NullText = ""
        Me.PrintOrderGridLookUpEdit.Properties.PopupView = Me.GridView13
        Me.PrintOrderGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintOrderGridLookUpEdit.Properties.ValueMember = "PrintOrderNewId"
        Me.PrintOrderGridLookUpEdit.Size = New System.Drawing.Size(176, 20)
        Me.PrintOrderGridLookUpEdit.TabIndex = 13
        '
        'PrintOrderNewLookupBindingSource
        '
        Me.PrintOrderNewLookupBindingSource.DataMember = "PrintOrderNewLookup"
        Me.PrintOrderNewLookupBindingSource.DataSource = Me.PrintOrderNewLookupDataSet
        '
        'PrintOrderNewLookupDataSet
        '
        Me.PrintOrderNewLookupDataSet.DataSetName = "PrintOrderNewLookupDataSet"
        Me.PrintOrderNewLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails3})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'colDetails3
        '
        Me.colDetails3.FieldName = "Details"
        Me.colDetails3.Name = "colDetails3"
        Me.colDetails3.Visible = True
        Me.colDetails3.VisibleIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(283, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Get Print Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CuttingDeliveryTableAdapter
        '
        Me.CuttingDeliveryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingDeliveryCNDetailsTableAdapter = Me.CuttingDeliveryCNDetailsTableAdapter
        Me.TableAdapterManager.CuttingDeliveryDetailsTableAdapter = Me.CuttingDeliveryDetailsTableAdapter
        Me.TableAdapterManager.CuttingDeliveryEmbDetailsTableAdapter = Me.CuttingDeliveryEmbDetailsTableAdapter
        Me.TableAdapterManager.CuttingDeliveryPODetailsTableAdapter = Me.CuttingDeliveryPODetailsTableAdapter
        Me.TableAdapterManager.CuttingDeliveryPrintDetailsTableAdapter = Me.CuttingDeliveryPrintDetailsTableAdapter
        Me.TableAdapterManager.CuttingDeliveryTableAdapter = Me.CuttingDeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingDeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuttingDeliveryCNDetailsTableAdapter
        '
        Me.CuttingDeliveryCNDetailsTableAdapter.ClearBeforeFill = True
        '
        'CuttingDeliveryDetailsTableAdapter
        '
        Me.CuttingDeliveryDetailsTableAdapter.ClearBeforeFill = True
        '
        'CuttingDeliveryEmbDetailsTableAdapter
        '
        Me.CuttingDeliveryEmbDetailsTableAdapter.ClearBeforeFill = True
        '
        'CuttingDeliveryPODetailsTableAdapter
        '
        Me.CuttingDeliveryPODetailsTableAdapter.ClearBeforeFill = True
        '
        'CuttingDeliveryPrintDetailsTableAdapter
        '
        Me.CuttingDeliveryPrintDetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderColorPOLookupTableAdapter
        '
        Me.OrderColorPOLookupTableAdapter.ClearBeforeFill = True
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'CuttingDeliveryChallanLookupTableAdapter
        '
        Me.CuttingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'CuttingNoLookupTableAdapter
        '
        Me.CuttingNoLookupTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderDetailsLookupTableAdapter
        '
        Me.EmbOrderDetailsLookupTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderLookupTableAdapter
        '
        Me.EmbOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderLookupTableAdapter
        '
        Me.PrintOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderNewLookupTableAdapter
        '
        Me.PrintOrderNewLookupTableAdapter.ClearBeforeFill = True
        '
        'frmCuttingDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 674)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmCuttingDelivery"
        Me.Text = "Cutting Delivery Challan"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CuttingDeliveryCNDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryCNDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanForLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.CuttingDeliveryPODetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryPODetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.EmbOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryEmbDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryEmbDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryPrintDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryPrintDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CuttingDeliveryDataSet As CuttingDeliveryDataSet
    Friend WithEvents CuttingDeliveryBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryTableAdapter
    Friend WithEvents TableAdapterManager As CuttingDeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CuttingDeliveryDetailsTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryDetailsTableAdapter
    Friend WithEvents CuttingDeliveryDetailsBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CuttingDeliveryPODetailsTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryPODetailsTableAdapter
    Friend WithEvents CuttingDeliveryPODetailsBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryPODetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchIdTextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderFabricColorTableAdapter As OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As BindingSource
    Friend WithEvents OrderFabricColorDataSet As OrderFabricColorDataSet
    Friend WithEvents SizeLookupTableAdapter As SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents SizeLookupBindingSource As BindingSource
    Friend WithEvents SizeLookupDataSet As SizeLookupDataSet
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderColorPOLookupDataSet As OrderColorPOLookupDataSet
    Friend WithEvents OrderColorPOLookupBindingSource As BindingSource
    Friend WithEvents OrderColorPOLookupTableAdapter As OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter
    Friend WithEvents LineDataSet As LineDataSet
    Friend WithEvents LineBindingSource As BindingSource
    Friend WithEvents LineTableAdapter As LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents InsertButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ChallanLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As Button
    Friend WithEvents OrderColorPOGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LineGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents CuttingDeliveryChallanLookupTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter
    Friend WithEvents ChallanForLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputBalance1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProdPercentageGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents CuttingDeliveryChallanLookupDataSet As CuttingDeliveryChallanLookupDataSet
    Friend WithEvents CuttingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryChallanLookupTableAdapter As CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuttingNoLookupBindingSource As BindingSource
    Friend WithEvents CuttingNoLookupDataSet As CuttingNoLookupDataSet
    Friend WithEvents CuttingNoLookupTableAdapter As CuttingNoLookupDataSetTableAdapters.CuttingNoLookupTableAdapter
    Friend WithEvents CuttingDeliveryCNDetailsBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryCNDetailsTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryCNDetailsTableAdapter
    Friend WithEvents CuttingDeliveryCNDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCuttingNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InsertCNButton As Button
    Friend WithEvents CuttingNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCuttingNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DelCNButton As Button
    Friend WithEvents POQtyLabel As Label
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CuttingDeliveryEmbDetailsBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryEmbDetailsTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryEmbDetailsTableAdapter
    Friend WithEvents CuttingDeliveryEmbDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmbOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbOrderGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbOrderDetailsGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmbOrderDetailsLookupDataSet As EmbOrderDetailsLookupDataSet
    Friend WithEvents EmbOrderDetailsLookupBindingSource As BindingSource
    Friend WithEvents EmbOrderDetailsLookupTableAdapter As EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupTableAdapter
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbOrderLookupDataSet As EmbOrderLookupDataSet
    Friend WithEvents EmbOrderLookupBindingSource As BindingSource
    Friend WithEvents EmbOrderLookupTableAdapter As EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents colInputQuanity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PrintOrderGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As Button
    Friend WithEvents CuttingDeliveryPrintDetailsBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryPrintDetailsTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryPrintDetailsTableAdapter
    Friend WithEvents CuttingDeliveryPrintDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderSizeDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintOrderLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents PrintOrderLookupBindingSource As BindingSource
    Friend WithEvents PrintProductionDataSet As PrintProductionDataSet
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintOrderLookupTableAdapter As PrintProductionDataSetTableAdapters.PrintOrderLookupTableAdapter
    Friend WithEvents PrintOrderNewLookupBindingSource As BindingSource
    Friend WithEvents PrintOrderNewLookupDataSet As PrintOrderNewLookupDataSet
    Friend WithEvents PrintOrderNewLookupTableAdapter As PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter
    Friend WithEvents colDetails3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
