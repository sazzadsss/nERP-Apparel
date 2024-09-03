<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelivery
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
        Me.components = New System.ComponentModel.Container()
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim SampleLabel As System.Windows.Forms.Label
        Dim EmptyCartonLabel As System.Windows.Forms.Label
        Dim GumtapeLabel As System.Windows.Forms.Label
        Dim ShippedByLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelivery))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChallanNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DeliveryChallanLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryChallanLookUpDataSet = New KSoft_Apparel.DeliveryChallanLookUpDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeliveryDataSet = New KSoft_Apparel.DeliveryDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.DeliveryChallanLookUpTableAdapter = New KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.DeliveryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeliveryDetailsTableAdapter = New KSoft_Apparel.DeliveryDataSetTableAdapters.DeliveryDetailsTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.DeliveryDataSetTableAdapters.TableAdapterManager()
        Me.DeliverySizeDetailsTableAdapter = New KSoft_Apparel.DeliveryDataSetTableAdapters.DeliverySizeDetailsTableAdapter()
        Me.DeliveryTableAdapter = New KSoft_Apparel.DeliveryDataSetTableAdapters.DeliveryTableAdapter()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.DeliveryDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeliveryQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfCarton = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderDetailsGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPGAndStyleAndPOAndColorAndDes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommercialInvoiceId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CommercialInvoiceLookupByCIIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommercialInvoiceLookUpDataSet = New KSoft_Apparel.CommercialInvoiceLookUpDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCommercialInvoiceNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommercialInvoiceDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialInvoiceLookupByPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.AttentionTextBox = New System.Windows.Forms.TextBox()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanNoTextBox = New System.Windows.Forms.TextBox()
        Me.colPGAndStyleAndPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleTextBox = New System.Windows.Forms.TextBox()
        Me.EmptyCartonTextBox = New System.Windows.Forms.TextBox()
        Me.GumtapeTextBox = New System.Windows.Forms.TextBox()
        Me.ShippedByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComInvGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCommercialInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommercialInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialInvoiceLookupByPOTableAdapter = New KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookupByPOTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.RemarksDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.PieceQTYTextBox = New System.Windows.Forms.TextBox()
        Me.CartonQTYTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CommercialInvoiceLookupByCIIDTableAdapter = New KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookupByCIIDTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GetSizeButton = New System.Windows.Forms.Button()
        Me.DeliverySizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.DeliverySizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
        ChallanDateLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ChallanNoLabel = New System.Windows.Forms.Label()
        SampleLabel = New System.Windows.Forms.Label()
        EmptyCartonLabel = New System.Windows.Forms.Label()
        GumtapeLabel = New System.Windows.Forms.Label()
        ShippedByLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeliveryBindingNavigator.SuspendLayout()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookupByCIIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookupByPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComInvGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(22, 86)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 38
        ChallanDateLabel.Text = "Challan Date:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(300, 51)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(74, 13)
        SupplierIdLabel.TabIndex = 40
        SupplierIdLabel.Text = "Delivered To :"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(300, 84)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 48
        AttentionLabel.Text = "Attention:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(300, 115)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 50
        Label2.Text = "Remarks:"
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(22, 54)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 50
        ChallanNoLabel.Text = "Challan No:"
        '
        'SampleLabel
        '
        SampleLabel.AutoSize = True
        SampleLabel.Location = New System.Drawing.Point(653, 54)
        SampleLabel.Name = "SampleLabel"
        SampleLabel.Size = New System.Drawing.Size(45, 13)
        SampleLabel.TabIndex = 51
        SampleLabel.Text = "Sample:"
        '
        'EmptyCartonLabel
        '
        EmptyCartonLabel.AutoSize = True
        EmptyCartonLabel.Location = New System.Drawing.Point(653, 86)
        EmptyCartonLabel.Name = "EmptyCartonLabel"
        EmptyCartonLabel.Size = New System.Drawing.Size(73, 13)
        EmptyCartonLabel.TabIndex = 52
        EmptyCartonLabel.Text = "Empty Carton:"
        '
        'GumtapeLabel
        '
        GumtapeLabel.AutoSize = True
        GumtapeLabel.Location = New System.Drawing.Point(653, 115)
        GumtapeLabel.Name = "GumtapeLabel"
        GumtapeLabel.Size = New System.Drawing.Size(53, 13)
        GumtapeLabel.TabIndex = 53
        GumtapeLabel.Text = "Gumtape:"
        '
        'ShippedByLabel
        '
        ShippedByLabel.AutoSize = True
        ShippedByLabel.Location = New System.Drawing.Point(22, 115)
        ShippedByLabel.Name = "ShippedByLabel"
        ShippedByLabel.Size = New System.Drawing.Size(91, 13)
        ShippedByLabel.TabIndex = 54
        ShippedByLabel.Text = "Mode of Shipped:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 41)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(91, 13)
        Label3.TabIndex = 10
        Label3.Text = "Destination Code:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(314, 41)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 13)
        Label4.TabIndex = 95
        Label4.Text = "Carton QTY:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(588, 16)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(62, 13)
        Label5.TabIndex = 97
        Label5.Text = "Piece QTY:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(588, 40)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(29, 13)
        Label6.TabIndex = 99
        Label6.Text = "Unit:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(814, 16)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(52, 13)
        Label7.TabIndex = 101
        Label7.Text = "Remarks:"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(621, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 22
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(540, 2)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 21
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(273, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Challan No :"
        '
        'ChallanNoGridLookUpEdit
        '
        Me.ChallanNoGridLookUpEdit.Location = New System.Drawing.Point(344, 4)
        Me.ChallanNoGridLookUpEdit.Name = "ChallanNoGridLookUpEdit"
        Me.ChallanNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanNoGridLookUpEdit.Properties.DataSource = Me.DeliveryChallanLookUpBindingSource
        Me.ChallanNoGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanNoGridLookUpEdit.Properties.NullText = ""
        Me.ChallanNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ChallanNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanNoGridLookUpEdit.Properties.ValueMember = "DeliveryId"
        Me.ChallanNoGridLookUpEdit.Size = New System.Drawing.Size(190, 20)
        Me.ChallanNoGridLookUpEdit.TabIndex = 0
        '
        'DeliveryChallanLookUpBindingSource
        '
        Me.DeliveryChallanLookUpBindingSource.DataMember = "DeliveryChallanLookUp"
        Me.DeliveryChallanLookUpBindingSource.DataSource = Me.DeliveryChallanLookUpDataSet
        '
        'DeliveryChallanLookUpDataSet
        '
        Me.DeliveryChallanLookUpDataSet.DataSetName = "DeliveryChallanLookUpDataSet"
        Me.DeliveryChallanLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'DeliveryDataSet
        '
        Me.DeliveryDataSet.DataSetName = "DeliveryDataSet"
        Me.DeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DeliveryChallanLookUpTableAdapter
        '
        Me.DeliveryChallanLookUpTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'DeliveryBindingNavigator
        '
        Me.DeliveryBindingNavigator.AddNewItem = Nothing
        Me.DeliveryBindingNavigator.BindingSource = Me.DeliveryBindingSource
        Me.DeliveryBindingNavigator.CountItem = Nothing
        Me.DeliveryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DeliveryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem})
        Me.DeliveryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryBindingNavigator.MoveFirstItem = Nothing
        Me.DeliveryBindingNavigator.MoveLastItem = Nothing
        Me.DeliveryBindingNavigator.MoveNextItem = Nothing
        Me.DeliveryBindingNavigator.MovePreviousItem = Nothing
        Me.DeliveryBindingNavigator.Name = "DeliveryBindingNavigator"
        Me.DeliveryBindingNavigator.PositionItem = Nothing
        Me.DeliveryBindingNavigator.Size = New System.Drawing.Size(1154, 25)
        Me.DeliveryBindingNavigator.TabIndex = 10
        Me.DeliveryBindingNavigator.Text = "BindingNavigator1"
        '
        'DeliveryBindingSource
        '
        Me.DeliveryBindingSource.DataMember = "Delivery"
        Me.DeliveryBindingSource.DataSource = Me.DeliveryDataSet
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeliveryDetailsTableAdapter
        '
        Me.DeliveryDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DeliveryDetailsTableAdapter = Me.DeliveryDetailsTableAdapter
        Me.TableAdapterManager.DeliverySizeDetailsTableAdapter = Me.DeliverySizeDetailsTableAdapter
        Me.TableAdapterManager.DeliveryTableAdapter = Me.DeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DeliverySizeDetailsTableAdapter
        '
        Me.DeliverySizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'DeliveryTableAdapter
        '
        Me.DeliveryTableAdapter.ClearBeforeFill = True
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode1, Me.colSupplierName1})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 0
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 1
        '
        'ChallanDateDateTimePicker
        '
        Me.ChallanDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ChallanDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DeliveryBindingSource, "ChallanDate", True))
        Me.ChallanDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ChallanDateDateTimePicker.Location = New System.Drawing.Point(133, 80)
        Me.ChallanDateDateTimePicker.Name = "ChallanDateDateTimePicker"
        Me.ChallanDateDateTimePicker.Size = New System.Drawing.Size(134, 20)
        Me.ChallanDateDateTimePicker.TabIndex = 2
        Me.ChallanDateDateTimePicker.Value = New Date(2016, 6, 11, 10, 48, 50, 0)
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DeliveryBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.EditValue = " "
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(380, 51)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(257, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 4
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(380, 112)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(257, 20)
        Me.RemarksTextBox.TabIndex = 6
        '
        'DeliveryDetailsGridControl
        '
        Me.DeliveryDetailsGridControl.DataSource = Me.DeliveryDetailsBindingSource1
        Me.DeliveryDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveryDetailsGridControl.EmbeddedNavigator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeliveryDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DeliveryDetailsGridControl.MainView = Me.GridView1
        Me.DeliveryDetailsGridControl.Name = "DeliveryDetailsGridControl"
        Me.DeliveryDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitGridLookUpEdit, Me.OrderDetailsGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1})
        Me.DeliveryDetailsGridControl.Size = New System.Drawing.Size(1118, 175)
        Me.DeliveryDetailsGridControl.TabIndex = 47
        Me.DeliveryDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DeliveryDetailsBindingSource1
        '
        Me.DeliveryDetailsBindingSource1.DataMember = "FK_DeliveryDetails_Delivery1"
        Me.DeliveryDetailsBindingSource1.DataSource = Me.DeliveryBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDeliveryQuantity, Me.colUnitId, Me.colNoOfCarton, Me.colRemarks, Me.colOrderDetailsId, Me.colDestinationCode, Me.colCommercialInvoiceId})
        Me.GridView1.GridControl = Me.DeliveryDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDeliveryQuantity
        '
        Me.colDeliveryQuantity.Caption = "Piece QTY"
        Me.colDeliveryQuantity.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity.Name = "colDeliveryQuantity"
        Me.colDeliveryQuantity.OptionsColumn.AllowEdit = False
        Me.colDeliveryQuantity.Visible = True
        Me.colDeliveryQuantity.VisibleIndex = 4
        Me.colDeliveryQuantity.Width = 71
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.AllowEdit = False
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 5
        Me.colUnitId.Width = 65
        '
        'UnitGridLookUpEdit
        '
        Me.UnitGridLookUpEdit.AutoHeight = False
        Me.UnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitGridLookUpEdit.DisplayMember = "UnitName"
        Me.UnitGridLookUpEdit.ImmediatePopup = True
        Me.UnitGridLookUpEdit.Name = "UnitGridLookUpEdit"
        Me.UnitGridLookUpEdit.NullText = ""
        Me.UnitGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.UnitGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitGridLookUpEdit.ValueMember = "UnitId"
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitName2})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUnitName2
        '
        Me.colUnitName2.FieldName = "UnitName"
        Me.colUnitName2.Name = "colUnitName2"
        Me.colUnitName2.Visible = True
        Me.colUnitName2.VisibleIndex = 0
        '
        'colNoOfCarton
        '
        Me.colNoOfCarton.Caption = "Carton QTY"
        Me.colNoOfCarton.FieldName = "NoOfCarton"
        Me.colNoOfCarton.Name = "colNoOfCarton"
        Me.colNoOfCarton.OptionsColumn.AllowEdit = False
        Me.colNoOfCarton.Visible = True
        Me.colNoOfCarton.VisibleIndex = 3
        Me.colNoOfCarton.Width = 87
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 319
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.Caption = "Order Details"
        Me.colOrderDetailsId.ColumnEdit = Me.OrderDetailsGridLookUpEdit
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.OptionsColumn.AllowEdit = False
        Me.colOrderDetailsId.Visible = True
        Me.colOrderDetailsId.VisibleIndex = 0
        Me.colOrderDetailsId.Width = 303
        '
        'OrderDetailsGridLookUpEdit
        '
        Me.OrderDetailsGridLookUpEdit.AutoHeight = False
        Me.OrderDetailsGridLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.OrderDetailsGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDetailsGridLookUpEdit.DataSource = Me.OrderPOLookupAllBindingSource
        Me.OrderDetailsGridLookUpEdit.DisplayMember = "PGAndStyleAndPOAndColorAndDes"
        Me.OrderDetailsGridLookUpEdit.ImmediatePopup = True
        Me.OrderDetailsGridLookUpEdit.Name = "OrderDetailsGridLookUpEdit"
        Me.OrderDetailsGridLookUpEdit.NullText = ""
        Me.OrderDetailsGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderDetailsGridLookUpEdit.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize
        Me.OrderDetailsGridLookUpEdit.PopupView = Me.GridView2
        Me.OrderDetailsGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderDetailsGridLookUpEdit.ValueMember = "OrderDetailsId"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPGAndStyleAndPOAndColorAndDes1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colPGAndStyleAndPOAndColorAndDes1
        '
        Me.colPGAndStyleAndPOAndColorAndDes1.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes1.Name = "colPGAndStyleAndPOAndColorAndDes1"
        Me.colPGAndStyleAndPOAndColorAndDes1.Visible = True
        Me.colPGAndStyleAndPOAndColorAndDes1.VisibleIndex = 0
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.OptionsColumn.AllowEdit = False
        Me.colDestinationCode.Visible = True
        Me.colDestinationCode.VisibleIndex = 2
        Me.colDestinationCode.Width = 117
        '
        'colCommercialInvoiceId
        '
        Me.colCommercialInvoiceId.Caption = "Commercial Invoice No"
        Me.colCommercialInvoiceId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colCommercialInvoiceId.FieldName = "CommercialInvoiceId"
        Me.colCommercialInvoiceId.Name = "colCommercialInvoiceId"
        Me.colCommercialInvoiceId.OptionsColumn.AllowEdit = False
        Me.colCommercialInvoiceId.Visible = True
        Me.colCommercialInvoiceId.VisibleIndex = 1
        Me.colCommercialInvoiceId.Width = 174
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.CommercialInvoiceLookupByCIIDBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "CommercialInvoiceNo"
        Me.RepositoryItemGridLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView5
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "CommercialInvoiceId"
        '
        'CommercialInvoiceLookupByCIIDBindingSource
        '
        Me.CommercialInvoiceLookupByCIIDBindingSource.DataMember = "CommercialInvoiceLookupByCIID"
        Me.CommercialInvoiceLookupByCIIDBindingSource.DataSource = Me.CommercialInvoiceLookUpDataSet
        '
        'CommercialInvoiceLookUpDataSet
        '
        Me.CommercialInvoiceLookUpDataSet.DataSetName = "CommercialInvoiceLookUpDataSet"
        Me.CommercialInvoiceLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommercialInvoiceNo1, Me.colCommercialInvoiceDate1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colCommercialInvoiceNo1
        '
        Me.colCommercialInvoiceNo1.FieldName = "CommercialInvoiceNo"
        Me.colCommercialInvoiceNo1.Name = "colCommercialInvoiceNo1"
        Me.colCommercialInvoiceNo1.Visible = True
        Me.colCommercialInvoiceNo1.VisibleIndex = 0
        '
        'colCommercialInvoiceDate1
        '
        Me.colCommercialInvoiceDate1.FieldName = "CommercialInvoiceDate"
        Me.colCommercialInvoiceDate1.Name = "colCommercialInvoiceDate1"
        Me.colCommercialInvoiceDate1.Visible = True
        Me.colCommercialInvoiceDate1.VisibleIndex = 1
        '
        'CommercialInvoiceLookupByPOBindingSource
        '
        Me.CommercialInvoiceLookupByPOBindingSource.DataMember = "CommercialInvoiceLookupByPO"
        Me.CommercialInvoiceLookupByPOBindingSource.DataSource = Me.CommercialInvoiceLookUpDataSet
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'AttentionTextBox
        '
        Me.AttentionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "Attention", True))
        Me.AttentionTextBox.Location = New System.Drawing.Point(380, 81)
        Me.AttentionTextBox.Name = "AttentionTextBox"
        Me.AttentionTextBox.Size = New System.Drawing.Size(257, 20)
        Me.AttentionTextBox.TabIndex = 5
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 0
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        Me.colUnitName1.Visible = True
        Me.colUnitName1.VisibleIndex = 0
        '
        'ChallanNoTextBox
        '
        Me.ChallanNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "ChallanNo", True))
        Me.ChallanNoTextBox.Location = New System.Drawing.Point(133, 51)
        Me.ChallanNoTextBox.Name = "ChallanNoTextBox"
        Me.ChallanNoTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ChallanNoTextBox.TabIndex = 1
        '
        'colPGAndStyleAndPOAndColorAndDes
        '
        Me.colPGAndStyleAndPOAndColorAndDes.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.Name = "colPGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.Visible = True
        Me.colPGAndStyleAndPOAndColorAndDes.VisibleIndex = 0
        '
        'SampleTextBox
        '
        Me.SampleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "Sample", True))
        Me.SampleTextBox.Location = New System.Drawing.Point(735, 51)
        Me.SampleTextBox.Name = "SampleTextBox"
        Me.SampleTextBox.Size = New System.Drawing.Size(159, 20)
        Me.SampleTextBox.TabIndex = 7
        '
        'EmptyCartonTextBox
        '
        Me.EmptyCartonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "EmptyCarton", True))
        Me.EmptyCartonTextBox.Location = New System.Drawing.Point(735, 81)
        Me.EmptyCartonTextBox.Name = "EmptyCartonTextBox"
        Me.EmptyCartonTextBox.Size = New System.Drawing.Size(159, 20)
        Me.EmptyCartonTextBox.TabIndex = 8
        '
        'GumtapeTextBox
        '
        Me.GumtapeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "Gumtape", True))
        Me.GumtapeTextBox.Location = New System.Drawing.Point(735, 112)
        Me.GumtapeTextBox.Name = "GumtapeTextBox"
        Me.GumtapeTextBox.Size = New System.Drawing.Size(159, 20)
        Me.GumtapeTextBox.TabIndex = 9
        '
        'ShippedByComboBox
        '
        Me.ShippedByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveryBindingSource, "ShippedBy", True))
        Me.ShippedByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShippedByComboBox.FormattingEnabled = True
        Me.ShippedByComboBox.Items.AddRange(New Object() {"Sea", "Air", "Sea_Air"})
        Me.ShippedByComboBox.Location = New System.Drawing.Point(133, 112)
        Me.ShippedByComboBox.Name = "ShippedByComboBox"
        Me.ShippedByComboBox.Size = New System.Drawing.Size(134, 21)
        Me.ShippedByComboBox.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(314, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 13)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Commercial Invoice :"
        '
        'ComInvGridLookUpEdit
        '
        Me.ComInvGridLookUpEdit.Location = New System.Drawing.Point(421, 13)
        Me.ComInvGridLookUpEdit.Name = "ComInvGridLookUpEdit"
        Me.ComInvGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComInvGridLookUpEdit.Properties.DataSource = Me.CommercialInvoiceLookupByPOBindingSource
        Me.ComInvGridLookUpEdit.Properties.DisplayMember = "CommercialInvoiceNo"
        Me.ComInvGridLookUpEdit.Properties.NullText = ""
        Me.ComInvGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.ComInvGridLookUpEdit.Properties.ValueMember = "CommercialInvoiceId"
        Me.ComInvGridLookUpEdit.Size = New System.Drawing.Size(152, 20)
        Me.ComInvGridLookUpEdit.TabIndex = 1
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommercialInvoiceNo, Me.colCommercialInvoiceDate})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colCommercialInvoiceNo
        '
        Me.colCommercialInvoiceNo.FieldName = "CommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Name = "colCommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Visible = True
        Me.colCommercialInvoiceNo.VisibleIndex = 0
        '
        'colCommercialInvoiceDate
        '
        Me.colCommercialInvoiceDate.FieldName = "CommercialInvoiceDate"
        Me.colCommercialInvoiceDate.Name = "colCommercialInvoiceDate"
        Me.colCommercialInvoiceDate.Visible = True
        Me.colCommercialInvoiceDate.VisibleIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(21, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Select PO No"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(119, 171)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderPOLookupAllBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "PGAndStyleAndPOAndColorAndDes"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView3
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderDetailsId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(192, 20)
        Me.GridLookUpEdit1.TabIndex = 10
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'CommercialInvoiceLookupByPOTableAdapter
        '
        Me.CommercialInvoiceLookupByPOTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GridLookUpEdit2)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.RemarksDetailsTextBox)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.PieceQTYTextBox)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.ComInvGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.CartonQTYTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.DestinationCodeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1118, 89)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Branch"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(107, 63)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.BranchBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "BranchName"
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.PopupView = Me.GridView6
        Me.GridLookUpEdit2.Properties.ValueMember = "BranchId"
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(192, 20)
        Me.GridLookUpEdit2.TabIndex = 103
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchName})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DeleteButton.Location = New System.Drawing.Point(995, 38)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(108, 45)
        Me.DeleteButton.TabIndex = 102
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(656, 38)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitName"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(152, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 4
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitName3})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colUnitName3
        '
        Me.colUnitName3.FieldName = "UnitName"
        Me.colUnitName3.Name = "colUnitName3"
        Me.colUnitName3.Visible = True
        Me.colUnitName3.VisibleIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveButton.Location = New System.Drawing.Point(872, 38)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(117, 45)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Add"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'RemarksDetailsTextBox
        '
        Me.RemarksDetailsTextBox.Location = New System.Drawing.Point(872, 13)
        Me.RemarksDetailsTextBox.Name = "RemarksDetailsTextBox"
        Me.RemarksDetailsTextBox.Size = New System.Drawing.Size(231, 20)
        Me.RemarksDetailsTextBox.TabIndex = 5
        '
        'PieceQTYTextBox
        '
        Me.PieceQTYTextBox.Location = New System.Drawing.Point(656, 13)
        Me.PieceQTYTextBox.Name = "PieceQTYTextBox"
        Me.PieceQTYTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PieceQTYTextBox.TabIndex = 3
        '
        'CartonQTYTextBox
        '
        Me.CartonQTYTextBox.Location = New System.Drawing.Point(421, 38)
        Me.CartonQTYTextBox.Name = "CartonQTYTextBox"
        Me.CartonQTYTextBox.Size = New System.Drawing.Size(152, 20)
        Me.CartonQTYTextBox.TabIndex = 2
        '
        'DestinationCodeTextBox
        '
        Me.DestinationCodeTextBox.Location = New System.Drawing.Point(107, 38)
        Me.DestinationCodeTextBox.Name = "DestinationCodeTextBox"
        Me.DestinationCodeTextBox.Size = New System.Drawing.Size(192, 20)
        Me.DestinationCodeTextBox.TabIndex = 0
        '
        'CommercialInvoiceLookupByCIIDTableAdapter
        '
        Me.CommercialInvoiceLookupByCIIDTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 252)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DeliveryDetailsGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GetSizeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DeliverySizeDetailsGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1118, 351)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 55
        '
        'GetSizeButton
        '
        Me.GetSizeButton.Location = New System.Drawing.Point(346, 13)
        Me.GetSizeButton.Name = "GetSizeButton"
        Me.GetSizeButton.Size = New System.Drawing.Size(98, 39)
        Me.GetSizeButton.TabIndex = 2
        Me.GetSizeButton.Text = "Get Size List"
        Me.GetSizeButton.UseVisualStyleBackColor = True
        '
        'DeliverySizeDetailsGridControl
        '
        Me.DeliverySizeDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeliverySizeDetailsGridControl.DataSource = Me.DeliverySizeDetailsBindingSource
        Me.DeliverySizeDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DeliverySizeDetailsGridControl.MainView = Me.GridView7
        Me.DeliverySizeDetailsGridControl.Name = "DeliverySizeDetailsGridControl"
        Me.DeliverySizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeLookupGridLookUpEdit})
        Me.DeliverySizeDetailsGridControl.Size = New System.Drawing.Size(326, 172)
        Me.DeliverySizeDetailsGridControl.TabIndex = 0
        Me.DeliverySizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.DeliverySizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'DeliverySizeDetailsBindingSource
        '
        Me.DeliverySizeDetailsBindingSource.DataMember = "FK_DeliverySizeDetails_DeliveryDetails"
        Me.DeliverySizeDetailsBindingSource.DataSource = Me.DeliveryDetailsBindingSource1
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colDeliveryQuantity1, Me.colOrderQuantity})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GridView7.FormatRules.Add(GridFormatRule1)
        Me.GridView7.GridControl = Me.DeliverySizeDetailsGridControl
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeLookupGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.OptionsColumn.ReadOnly = True
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 71
        '
        'SizeLookupGridLookUpEdit
        '
        Me.SizeLookupGridLookUpEdit.AutoHeight = False
        Me.SizeLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookupGridLookUpEdit.DataSource = Me.SizeLookupBindingSource
        Me.SizeLookupGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookupGridLookUpEdit.Name = "SizeLookupGridLookUpEdit"
        Me.SizeLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.SizeLookupGridLookUpEdit.ValueMember = "SizeId"
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colDeliveryQuantity1
        '
        Me.colDeliveryQuantity1.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity1.Name = "colDeliveryQuantity1"
        Me.colDeliveryQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQuantity", "{0:0.##}")})
        Me.colDeliveryQuantity1.Visible = True
        Me.colDeliveryQuantity1.VisibleIndex = 2
        Me.colDeliveryQuantity1.Width = 136
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:0.##}")})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 1
        Me.colOrderQuantity.Width = 101
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'frmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 615)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(ShippedByLabel)
        Me.Controls.Add(Me.ShippedByComboBox)
        Me.Controls.Add(GumtapeLabel)
        Me.Controls.Add(Me.GumtapeTextBox)
        Me.Controls.Add(EmptyCartonLabel)
        Me.Controls.Add(Me.EmptyCartonTextBox)
        Me.Controls.Add(SampleLabel)
        Me.Controls.Add(Me.SampleTextBox)
        Me.Controls.Add(ChallanNoLabel)
        Me.Controls.Add(Me.ChallanNoTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(AttentionLabel)
        Me.Controls.Add(Me.AttentionTextBox)
        Me.Controls.Add(ChallanDateLabel)
        Me.Controls.Add(Me.ChallanDateDateTimePicker)
        Me.Controls.Add(SupplierIdLabel)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChallanNoGridLookUpEdit)
        Me.Controls.Add(Me.DeliveryBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDelivery"
        Me.Text = "Shipment Delivery"
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeliveryBindingNavigator.ResumeLayout(False)
        Me.DeliveryBindingNavigator.PerformLayout()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookupByCIIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookupByPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComInvGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChallanNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeliveryChallanLookUpDataSet As KSoft_Apparel.DeliveryChallanLookUpDataSet
    Friend WithEvents DeliveryChallanLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryChallanLookUpTableAdapter As KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents DeliveryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeliveryDataSet As KSoft_Apparel.DeliveryDataSet
    Friend WithEvents DeliveryDetailsTableAdapter As KSoft_Apparel.DeliveryDataSetTableAdapters.DeliveryDetailsTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DeliveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryTableAdapter As KSoft_Apparel.DeliveryDataSetTableAdapters.DeliveryTableAdapter
    Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOLookupAllTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDeliveryQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfCarton As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents AttentionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colUnitName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderDetailsGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPGAndStyleAndPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeliveryDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colPGAndStyleAndPOAndColorAndDes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmptyCartonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GumtapeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShippedByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ComInvGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCommercialInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommercialInvoiceLookupByPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceLookUpDataSet As KSoft_Apparel.CommercialInvoiceLookUpDataSet
    Friend WithEvents CommercialInvoiceLookupByPOTableAdapter As KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookupByPOTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CartonQTYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinationCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksDetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PieceQTYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialInvoiceId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCommercialInvoiceNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialInvoiceDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CommercialInvoiceLookupByCIIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceLookupByCIIDTableAdapter As KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookupByCIIDTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DeliverySizeDetailsBindingSource As BindingSource
    Friend WithEvents DeliverySizeDetailsTableAdapter As DeliveryDataSetTableAdapters.DeliverySizeDetailsTableAdapter
    Friend WithEvents DeliverySizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetSizeButton As Button
    Friend WithEvents SizeLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SizeLookupBindingSource As BindingSource
    Friend WithEvents SizeLookupDataSet As SizeLookupDataSet
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookupTableAdapter As SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
End Class
