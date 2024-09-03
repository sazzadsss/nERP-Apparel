<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewAccessories
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
        Dim AccessoriesIdLabel As System.Windows.Forms.Label
        Dim AccessoriesNameLabel As System.Windows.Forms.Label
        Dim MaxPriceLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim WastagePercentageLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim CategoryLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Apparel.BookingDataSet
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet
        Me.ItemStyleTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.AccessoriesIdSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.AccessoriesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListDataSet = New KSoft_Apparel.AccessoriesListDataSet
        Me.MaxPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.IsSizeWiseCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.IsColorWiseCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.IsDestinationWiseCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.WastagePercentageSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IsPackCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.IsCostingCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.ItemStyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemStyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.UnitIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.PackTypeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.OKButton = New System.Windows.Forms.Button
        Me.AccessoriesNameTextBox = New System.Windows.Forms.TextBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ItemStyleLinkLabel = New System.Windows.Forms.LinkLabel
        Me.AccessoriesListTableAdapter = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListTableAdapter
        Me.AccessoriesListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListLookupTableAdapter = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.TableAdapterManager
        Me.CategoryIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCategoryId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCategoryDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CategoryIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Apparel.CategoryDataSet
        Me.SubCategoryIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSubCategoryId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCategoryId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSubCategoryName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSubCategoryDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPipeLineQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SubCategoryIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataSet = New KSoft_Apparel.SubCategoryDataSet
        Me.CategoryTableAdapter = New KSoft_Apparel.CategoryDataSetTableAdapters.CategoryTableAdapter
        Me.SubCategoryTableAdapter = New KSoft_Apparel.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
        AccessoriesIdLabel = New System.Windows.Forms.Label
        AccessoriesNameLabel = New System.Windows.Forms.Label
        MaxPriceLabel = New System.Windows.Forms.Label
        BuyerIdLabel = New System.Windows.Forms.Label
        WastagePercentageLabel = New System.Windows.Forms.Label
        RemarksLabel = New System.Windows.Forms.Label
        SupplierIdLabel = New System.Windows.Forms.Label
        PictureLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CategoryLabel1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsSizeWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsColorWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsDestinationWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WastagePercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPackCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCostingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccessoriesIdLabel
        '
        AccessoriesIdLabel.AutoSize = True
        AccessoriesIdLabel.Location = New System.Drawing.Point(14, 52)
        AccessoriesIdLabel.Name = "AccessoriesIdLabel"
        AccessoriesIdLabel.Size = New System.Drawing.Size(84, 13)
        AccessoriesIdLabel.TabIndex = 20
        AccessoriesIdLabel.Text = "Accessories No:"
        '
        'AccessoriesNameLabel
        '
        AccessoriesNameLabel.AutoSize = True
        AccessoriesNameLabel.Location = New System.Drawing.Point(14, 78)
        AccessoriesNameLabel.Name = "AccessoriesNameLabel"
        AccessoriesNameLabel.Size = New System.Drawing.Size(98, 13)
        AccessoriesNameLabel.TabIndex = 21
        AccessoriesNameLabel.Text = "Accessories Name:"
        '
        'MaxPriceLabel
        '
        MaxPriceLabel.AutoSize = True
        MaxPriceLabel.Location = New System.Drawing.Point(14, 196)
        MaxPriceLabel.Name = "MaxPriceLabel"
        MaxPriceLabel.Size = New System.Drawing.Size(57, 13)
        MaxPriceLabel.TabIndex = 25
        MaxPriceLabel.Text = "Max Price:"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(16, 131)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(37, 13)
        BuyerIdLabel.TabIndex = 23
        BuyerIdLabel.Text = "Buyer:"
        '
        'WastagePercentageLabel
        '
        WastagePercentageLabel.AutoSize = True
        WastagePercentageLabel.Location = New System.Drawing.Point(14, 222)
        WastagePercentageLabel.Name = "WastagePercentageLabel"
        WastagePercentageLabel.Size = New System.Drawing.Size(70, 13)
        WastagePercentageLabel.TabIndex = 26
        WastagePercentageLabel.Text = "Wastage (%):"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(14, 274)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 28
        RemarksLabel.Text = "Remarks:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(16, 154)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIdLabel.TabIndex = 24
        SupplierIdLabel.Text = "Supplier:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(523, 50)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(43, 13)
        PictureLabel.TabIndex = 19
        PictureLabel.Text = "Picture:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 246)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 31
        Label1.Text = "Booking Unit :"
        '
        'CategoryLabel1
        '
        CategoryLabel1.AutoSize = True
        CategoryLabel1.Location = New System.Drawing.Point(248, 196)
        CategoryLabel1.Name = "CategoryLabel1"
        CategoryLabel1.Size = New System.Drawing.Size(52, 13)
        CategoryLabel1.TabIndex = 10
        CategoryLabel1.Text = "Category:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(248, 222)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 13)
        Label2.TabIndex = 32
        Label2.Text = "Sub Category:"
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
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesIdSpinEdit
        '
        Me.AccessoriesIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "AccessoriesId", True))
        Me.AccessoriesIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AccessoriesIdSpinEdit.Location = New System.Drawing.Point(116, 47)
        Me.AccessoriesIdSpinEdit.Name = "AccessoriesIdSpinEdit"
        Me.AccessoriesIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.AccessoriesIdSpinEdit.Size = New System.Drawing.Size(72, 20)
        Me.AccessoriesIdSpinEdit.TabIndex = 1
        '
        'AccessoriesListBindingSource
        '
        Me.AccessoriesListBindingSource.DataMember = "AccessoriesList"
        Me.AccessoriesListBindingSource.DataSource = Me.AccessoriesListDataSet
        '
        'AccessoriesListDataSet
        '
        Me.AccessoriesListDataSet.DataSetName = "AccessoriesListDataSet"
        Me.AccessoriesListDataSet.EnforceConstraints = False
        Me.AccessoriesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaxPriceSpinEdit
        '
        Me.MaxPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "MaxPrice", True))
        Me.MaxPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaxPriceSpinEdit.Location = New System.Drawing.Point(116, 191)
        Me.MaxPriceSpinEdit.Name = "MaxPriceSpinEdit"
        Me.MaxPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MaxPriceSpinEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.MaxPriceSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaxPriceSpinEdit.Properties.EditFormat.FormatString = "n3"
        Me.MaxPriceSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaxPriceSpinEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.MaxPriceSpinEdit.Properties.Mask.EditMask = "n3"
        Me.MaxPriceSpinEdit.Size = New System.Drawing.Size(72, 20)
        Me.MaxPriceSpinEdit.TabIndex = 6
        '
        'IsSizeWiseCheckEdit
        '
        Me.IsSizeWiseCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "IsSizeWise", True))
        Me.IsSizeWiseCheckEdit.Location = New System.Drawing.Point(12, 444)
        Me.IsSizeWiseCheckEdit.Name = "IsSizeWiseCheckEdit"
        Me.IsSizeWiseCheckEdit.Properties.Caption = "Is Sizewise"
        Me.IsSizeWiseCheckEdit.Size = New System.Drawing.Size(86, 19)
        Me.IsSizeWiseCheckEdit.TabIndex = 17
        '
        'IsColorWiseCheckEdit
        '
        Me.IsColorWiseCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "IsColorWise", True))
        Me.IsColorWiseCheckEdit.Location = New System.Drawing.Point(12, 377)
        Me.IsColorWiseCheckEdit.Name = "IsColorWiseCheckEdit"
        Me.IsColorWiseCheckEdit.Properties.Caption = "Is Colorwise"
        Me.IsColorWiseCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.IsColorWiseCheckEdit.TabIndex = 14
        '
        'IsDestinationWiseCheckEdit
        '
        Me.IsDestinationWiseCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "IsDestinationWise", True))
        Me.IsDestinationWiseCheckEdit.Location = New System.Drawing.Point(12, 400)
        Me.IsDestinationWiseCheckEdit.Name = "IsDestinationWiseCheckEdit"
        Me.IsDestinationWiseCheckEdit.Properties.Caption = "Is Destinationwise"
        Me.IsDestinationWiseCheckEdit.Size = New System.Drawing.Size(129, 19)
        Me.IsDestinationWiseCheckEdit.TabIndex = 15
        '
        'WastagePercentageSpinEdit
        '
        Me.WastagePercentageSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "WastagePercentage", True))
        Me.WastagePercentageSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WastagePercentageSpinEdit.Location = New System.Drawing.Point(116, 217)
        Me.WastagePercentageSpinEdit.Name = "WastagePercentageSpinEdit"
        Me.WastagePercentageSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.WastagePercentageSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.WastagePercentageSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.WastagePercentageSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.WastagePercentageSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.WastagePercentageSpinEdit.Size = New System.Drawing.Size(72, 20)
        Me.WastagePercentageSpinEdit.TabIndex = 7
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(116, 269)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(387, 20)
        Me.RemarksTextEdit.TabIndex = 19
        '
        'IsPackCheckEdit
        '
        Me.IsPackCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "IsPack", True))
        Me.IsPackCheckEdit.Location = New System.Drawing.Point(12, 355)
        Me.IsPackCheckEdit.Name = "IsPackCheckEdit"
        Me.IsPackCheckEdit.Properties.Caption = "Is Pack"
        Me.IsPackCheckEdit.Size = New System.Drawing.Size(61, 19)
        Me.IsPackCheckEdit.TabIndex = 12
        '
        'IsCostingCheckEdit
        '
        Me.IsCostingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "IsCosting", True))
        Me.IsCostingCheckEdit.Location = New System.Drawing.Point(12, 421)
        Me.IsCostingCheckEdit.Name = "IsCostingCheckEdit"
        Me.IsCostingCheckEdit.Properties.Caption = "Is Costing"
        Me.IsCostingCheckEdit.Size = New System.Drawing.Size(86, 19)
        Me.IsCostingCheckEdit.TabIndex = 16
        '
        'ItemStyleIdGridLookUpEditView
        '
        Me.ItemStyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemStyleId, Me.colBuyerId1, Me.colUserId, Me.colModifiedDate, Me.colItemStyle})
        Me.ItemStyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ItemStyleIdGridLookUpEditView.Name = "ItemStyleIdGridLookUpEditView"
        Me.ItemStyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ItemStyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colItemStyleId
        '
        Me.colItemStyleId.FieldName = "ItemStyleId"
        Me.colItemStyleId.Name = "colItemStyleId"
        Me.colItemStyleId.OptionsColumn.ReadOnly = True
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'colItemStyle
        '
        Me.colItemStyle.FieldName = "ItemStyle"
        Me.colItemStyle.Name = "colItemStyle"
        Me.colItemStyle.Visible = True
        Me.colItemStyle.VisibleIndex = 0
        '
        'ItemStyleIdGridLookUpEdit
        '
        Me.ItemStyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "ItemStyleId", True))
        Me.ItemStyleIdGridLookUpEdit.Location = New System.Drawing.Point(116, 100)
        Me.ItemStyleIdGridLookUpEdit.Name = "ItemStyleIdGridLookUpEdit"
        Me.ItemStyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleIdGridLookUpEdit.Properties.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleIdGridLookUpEdit.Properties.DisplayMember = "ItemStyle"
        Me.ItemStyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemStyleIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemStyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemStyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemStyleIdGridLookUpEdit.Properties.ValueMember = "ItemStyleId"
        Me.ItemStyleIdGridLookUpEdit.Properties.View = Me.ItemStyleIdGridLookUpEditView
        Me.ItemStyleIdGridLookUpEdit.Size = New System.Drawing.Size(213, 20)
        Me.ItemStyleIdGridLookUpEdit.TabIndex = 3
        '
        'UnitIdGridLookUpEditView
        '
        Me.UnitIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId, Me.colUnitCode, Me.colUnitName})
        Me.UnitIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UnitIdGridLookUpEditView.Name = "UnitIdGridLookUpEditView"
        Me.UnitIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UnitIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUnitId
        '
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.ReadOnly = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "UnitId", True))
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(116, 243)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitCode"
        Me.UnitIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Properties.View = Me.UnitIdGridLookUpEditView
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(72, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 8
        '
        'PackTypeComboBoxEdit
        '
        Me.PackTypeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "PackType", True))
        Me.PackTypeComboBoxEdit.Location = New System.Drawing.Point(73, 355)
        Me.PackTypeComboBoxEdit.Name = "PackTypeComboBoxEdit"
        Me.PackTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PackTypeComboBoxEdit.Properties.ImmediatePopup = True
        Me.PackTypeComboBoxEdit.Properties.Items.AddRange(New Object() {"Normal", "Ratio"})
        Me.PackTypeComboBoxEdit.Size = New System.Drawing.Size(68, 20)
        Me.PackTypeComboBoxEdit.TabIndex = 13
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colAdd1
        '
        Me.colAdd1.FieldName = "Add1"
        Me.colAdd1.Name = "colAdd1"
        '
        'colAdd2
        '
        Me.colAdd2.FieldName = "Add2"
        Me.colAdd2.Name = "colAdd2"
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(116, 149)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(213, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 5
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
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(116, 124)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerCode"
        Me.BuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(213, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 4
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(526, 73)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Size = New System.Drawing.Size(219, 216)
        Me.PicturePictureEdit.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(769, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 7)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.NewLinkLabel.Name = "NewLinkLabel"
        Me.NewLinkLabel.Size = New System.Drawing.Size(26, 13)
        Me.NewLinkLabel.TabIndex = 0
        Me.NewLinkLabel.TabStop = True
        Me.NewLinkLabel.Text = "Add"
        Me.NewLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Location = New System.Drawing.Point(57, 7)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 1
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(95, 7)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 5, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.CancelLinkLabel.TabIndex = 2
        Me.CancelLinkLabel.TabStop = True
        Me.CancelLinkLabel.Text = "Cancel"
        Me.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(149, 7)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 5, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 3
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKButton.Location = New System.Drawing.Point(526, 303)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(10, 0, 3, 3)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(219, 34)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'AccessoriesNameTextBox
        '
        Me.AccessoriesNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccessoriesListBindingSource, "AccessoriesName", True))
        Me.AccessoriesNameTextBox.Location = New System.Drawing.Point(116, 73)
        Me.AccessoriesNameTextBox.Name = "AccessoriesNameTextBox"
        Me.AccessoriesNameTextBox.Size = New System.Drawing.Size(213, 20)
        Me.AccessoriesNameTextBox.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(769, 346)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 769
        Me.LineShape1.Y1 = 296
        Me.LineShape1.Y2 = 296
        '
        'ItemStyleLinkLabel
        '
        Me.ItemStyleLinkLabel.AutoSize = True
        Me.ItemStyleLinkLabel.Location = New System.Drawing.Point(14, 105)
        Me.ItemStyleLinkLabel.Name = "ItemStyleLinkLabel"
        Me.ItemStyleLinkLabel.Size = New System.Drawing.Size(53, 13)
        Me.ItemStyleLinkLabel.TabIndex = 30
        Me.ItemStyleLinkLabel.TabStop = True
        Me.ItemStyleLinkLabel.Text = "Item Style"
        '
        'AccessoriesListTableAdapter
        '
        Me.AccessoriesListTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesListLookupBindingSource
        '
        Me.AccessoriesListLookupBindingSource.DataMember = "AccessoriesListLookup"
        Me.AccessoriesListLookupBindingSource.DataSource = Me.AccessoriesListDataSet
        '
        'AccessoriesListLookupTableAdapter
        '
        Me.AccessoriesListLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesListTableAdapter = Me.AccessoriesListTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AccessoriesListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoryIdGridLookUpEditView
        '
        Me.CategoryIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryId, Me.colCategoryName, Me.colCategoryDescription, Me.colDepartmentId})
        Me.CategoryIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CategoryIdGridLookUpEditView.Name = "CategoryIdGridLookUpEditView"
        Me.CategoryIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CategoryIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCategoryId
        '
        Me.colCategoryId.FieldName = "CategoryId"
        Me.colCategoryId.Name = "colCategoryId"
        Me.colCategoryId.OptionsColumn.ReadOnly = True
        '
        'colCategoryName
        '
        Me.colCategoryName.FieldName = "CategoryName"
        Me.colCategoryName.Name = "colCategoryName"
        Me.colCategoryName.Visible = True
        Me.colCategoryName.VisibleIndex = 0
        '
        'colCategoryDescription
        '
        Me.colCategoryDescription.FieldName = "CategoryDescription"
        Me.colCategoryDescription.Name = "colCategoryDescription"
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'CategoryIdGridLookUpEdit
        '
        Me.CategoryIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "CategoryId", True))
        Me.CategoryIdGridLookUpEdit.Location = New System.Drawing.Point(328, 193)
        Me.CategoryIdGridLookUpEdit.Name = "CategoryIdGridLookUpEdit"
        Me.CategoryIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryIdGridLookUpEdit.Properties.DataSource = Me.CategoryBindingSource
        Me.CategoryIdGridLookUpEdit.Properties.DisplayMember = "CategoryName"
        Me.CategoryIdGridLookUpEdit.Properties.NullText = ""
        Me.CategoryIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CategoryIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CategoryIdGridLookUpEdit.Properties.ValueMember = "CategoryId"
        Me.CategoryIdGridLookUpEdit.Properties.View = Me.CategoryIdGridLookUpEditView
        Me.CategoryIdGridLookUpEdit.Size = New System.Drawing.Size(175, 20)
        Me.CategoryIdGridLookUpEdit.TabIndex = 1
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryIdGridLookUpEditView
        '
        Me.SubCategoryIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubCategoryId, Me.colCategoryId1, Me.colSubCategoryName, Me.colSubCategoryDescription, Me.colDepartmentId1, Me.colPipeLineQuantity})
        Me.SubCategoryIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SubCategoryIdGridLookUpEditView.Name = "SubCategoryIdGridLookUpEditView"
        Me.SubCategoryIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SubCategoryIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSubCategoryId
        '
        Me.colSubCategoryId.FieldName = "SubCategoryId"
        Me.colSubCategoryId.Name = "colSubCategoryId"
        Me.colSubCategoryId.OptionsColumn.ReadOnly = True
        '
        'colCategoryId1
        '
        Me.colCategoryId1.FieldName = "CategoryId"
        Me.colCategoryId1.Name = "colCategoryId1"
        '
        'colSubCategoryName
        '
        Me.colSubCategoryName.FieldName = "SubCategoryName"
        Me.colSubCategoryName.Name = "colSubCategoryName"
        Me.colSubCategoryName.Visible = True
        Me.colSubCategoryName.VisibleIndex = 0
        '
        'colSubCategoryDescription
        '
        Me.colSubCategoryDescription.FieldName = "SubCategoryDescription"
        Me.colSubCategoryDescription.Name = "colSubCategoryDescription"
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'colPipeLineQuantity
        '
        Me.colPipeLineQuantity.FieldName = "PipeLineQuantity"
        Me.colPipeLineQuantity.Name = "colPipeLineQuantity"
        '
        'SubCategoryIdGridLookUpEdit
        '
        Me.SubCategoryIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesListBindingSource, "SubCategoryId", True))
        Me.SubCategoryIdGridLookUpEdit.Location = New System.Drawing.Point(328, 219)
        Me.SubCategoryIdGridLookUpEdit.Name = "SubCategoryIdGridLookUpEdit"
        Me.SubCategoryIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubCategoryIdGridLookUpEdit.Properties.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryIdGridLookUpEdit.Properties.DisplayMember = "SubCategoryName"
        Me.SubCategoryIdGridLookUpEdit.Properties.NullText = ""
        Me.SubCategoryIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SubCategoryIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SubCategoryIdGridLookUpEdit.Properties.ValueMember = "SubCategoryId"
        Me.SubCategoryIdGridLookUpEdit.Properties.View = Me.SubCategoryIdGridLookUpEditView
        Me.SubCategoryIdGridLookUpEdit.Size = New System.Drawing.Size(175, 20)
        Me.SubCategoryIdGridLookUpEdit.TabIndex = 1
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'frmAddNewAccessories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 346)
        Me.Controls.Add(Me.SubCategoryIdGridLookUpEdit)
        Me.Controls.Add(Me.CategoryIdGridLookUpEdit)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ItemStyleLinkLabel)
        Me.Controls.Add(Me.AccessoriesNameTextBox)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(Me.PackTypeComboBoxEdit)
        Me.Controls.Add(CategoryLabel1)
        Me.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.Controls.Add(Me.ItemStyleIdGridLookUpEdit)
        Me.Controls.Add(AccessoriesIdLabel)
        Me.Controls.Add(Me.AccessoriesIdSpinEdit)
        Me.Controls.Add(AccessoriesNameLabel)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PicturePictureEdit)
        Me.Controls.Add(MaxPriceLabel)
        Me.Controls.Add(Me.MaxPriceSpinEdit)
        Me.Controls.Add(BuyerIdLabel)
        Me.Controls.Add(Me.IsSizeWiseCheckEdit)
        Me.Controls.Add(Me.IsColorWiseCheckEdit)
        Me.Controls.Add(Me.IsDestinationWiseCheckEdit)
        Me.Controls.Add(WastagePercentageLabel)
        Me.Controls.Add(Me.WastagePercentageSpinEdit)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextEdit)
        Me.Controls.Add(SupplierIdLabel)
        Me.Controls.Add(Me.IsPackCheckEdit)
        Me.Controls.Add(Me.IsCostingCheckEdit)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmAddNewAccessories"
        Me.Text = "Add Accessories"
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsSizeWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsColorWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsDestinationWiseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WastagePercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPackCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCostingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccessoriesListDataSet As KSoft_Apparel.AccessoriesListDataSet
    Friend WithEvents AccessoriesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListTableAdapter As KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListTableAdapter
    Friend WithEvents AccessoriesListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListLookupTableAdapter As KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
    Friend WithEvents BookingDataSet As KSoft_Apparel.BookingDataSet
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStyleTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AccessoriesListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoriesIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MaxPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IsSizeWiseCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsColorWiseCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsDestinationWiseCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents WastagePercentageSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsPackCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsCostingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemStyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemStyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents UnitIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PackTypeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents AccessoriesNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colItemStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ItemStyleLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CategoryIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CategoryIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SubCategoryIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SubCategoryIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CategoryDataSet As KSoft_Apparel.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Apparel.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents colCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubCategoryDataSet As KSoft_Apparel.SubCategoryDataSet
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As KSoft_Apparel.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents colSubCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPipeLineQuantity As DevExpress.XtraGrid.Columns.GridColumn
End Class
