<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipe
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
        Dim UsedQuantyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecipe))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RecipeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RecipeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceipeDataSet = New KSoft_Apparel.ReceipeDataSet()
        Me.RecipeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RecipeDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecipeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Development = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StyleId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.OrderId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleOrderDataSet = New KSoft_Apparel.StyleOrderDataSet()
        Me.BuyerId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceipeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeIn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Wt = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrintPartId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet()
        Me.Dollar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionMonthId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductionMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionMonthDataSet = New KSoft_Apparel.ProductionMonthDataSet()
        Me.ProductionFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrintTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddFoilPaperCost = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipeColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipeColorDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintColorId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrintColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintColorDataSet = New KSoft_Apparel.PrintColorDataSet()
        Me.PrintTypeId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Weight_BeforePrint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weight_AfterPrint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WastagePercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipeItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsedQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemNameDataSet = New KSoft_Apparel.ItemNameDataSet()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter()
        Me.VItemListTableAdapter = New KSoft_Apparel.ItemNameDataSetTableAdapters.vItemListTableAdapter()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceDataSet = New KSoft_Apparel.PriceDataSet()
        Me.ItemListTableAdapter = New KSoft_Apparel.PriceDataSetTableAdapters.ItemListTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.PriceDataSetTableAdapters.TableAdapterManager()
        Me.TotalRecipeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsedQuantyTextBox = New System.Windows.Forms.TextBox()
        Me.RecipeIdLabel = New System.Windows.Forms.Label()
        Me.ItemListTableAdapter1 = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StyleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StyleTableAdapter1 = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.PrintColorLookupDataSet = New KSoft_Apparel.PrintColorLookupDataSet()
        Me.RecipeColorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipeColorTableAdapter1 = New KSoft_Apparel.PrintColorLookupDataSetTableAdapters.RecipeColorTableAdapter()
        Me.PrintColorTableAdapter = New KSoft_Apparel.PrintColorDataSetTableAdapters.PrintColorTableAdapter()
        Me.PrintColorComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CopyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PasteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CopiedRecipeItemDataSet = New KSoft_Apparel.CopiedRecipeItemDataSet()
        Me.CopiedRecipeItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopiedRecipeItemTableAdapter = New KSoft_Apparel.CopiedRecipeItemDataSetTableAdapters.CopiedRecipeItemTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Apparel.CopiedRecipeItemDataSetTableAdapters.TableAdapterManager()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CopyPrintColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PastePrintColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CopiedRecipeColorDataSet = New KSoft_Apparel.CopiedRecipeColorDataSet()
        Me.CopiedRecipeColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopiedRecipeColorTableAdapter = New KSoft_Apparel.CopiedRecipeColorDataSetTableAdapters.CopiedRecipeColorTableAdapter()
        Me.TableAdapterManager3 = New KSoft_Apparel.CopiedRecipeColorDataSetTableAdapters.TableAdapterManager()
        Me.DefaultLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MinRecipeColorIdDataSet = New KSoft_Apparel.MinRecipeColorIdDataSet()
        Me.MinRecipeColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinRecipeColorTableAdapter = New KSoft_Apparel.MinRecipeColorIdDataSetTableAdapters.MinRecipeColorTableAdapter()
        Me.TableAdapterManager4 = New KSoft_Apparel.MinRecipeColorIdDataSetTableAdapters.TableAdapterManager()
        Me.ReceipeStyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceipeStyleLookupDataSet = New KSoft_Apparel.ReceipeStyleLookupDataSet()
        Me.ReceipeStyleLookupTableAdapter = New KSoft_Apparel.ReceipeStyleLookupDataSetTableAdapters.ReceipeStyleLookupTableAdapter()
        Me.StyleLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New KSoft_Apparel.StyleOrderDataSetTableAdapters.OrderTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.StyleBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddRecipeItemLink = New System.Windows.Forms.LinkLabel()
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter()
        Me.ProductionMonthTableAdapter = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter()
        Me.ClearProgramLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PrintColorLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderLookupTableAdapter1 = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet1 = New KSoft_Apparel.OrderLookupDataSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RecipeTableAdapter = New KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ReceipeDataSetTableAdapters.TableAdapterManager()
        Me.RecipeColorTableAdapter = New KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeColorTableAdapter()
        Me.RecipeItemTableAdapter = New KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeItemTableAdapter()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.PasteButton = New System.Windows.Forms.Button()
        Me.CalUsedQuantitiyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        UsedQuantyLabel = New System.Windows.Forms.Label()
        CType(Me.RecipeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecipeBindingNavigator.SuspendLayout()
        CType(Me.RecipeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipeColorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopiedRecipeItemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopiedRecipeItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopiedRecipeColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopiedRecipeColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinRecipeColorIdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinRecipeColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceipeStyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceipeStyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintColorLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsedQuantyLabel
        '
        UsedQuantyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UsedQuantyLabel.AutoSize = True
        UsedQuantyLabel.Location = New System.Drawing.Point(454, 368)
        UsedQuantyLabel.Name = "UsedQuantyLabel"
        UsedQuantyLabel.Size = New System.Drawing.Size(77, 13)
        UsedQuantyLabel.TabIndex = 14
        UsedQuantyLabel.Text = "Used Quantity:"
        '
        'RecipeBindingNavigator
        '
        Me.RecipeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecipeBindingNavigator.AutoSize = False
        Me.RecipeBindingNavigator.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.MenuBackground2
        Me.RecipeBindingNavigator.BindingSource = Me.RecipeBindingSource
        Me.RecipeBindingNavigator.CountItem = Nothing
        Me.RecipeBindingNavigator.DeleteItem = Nothing
        Me.RecipeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.RecipeBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.RecipeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecipeBindingNavigator.MoveFirstItem = Nothing
        Me.RecipeBindingNavigator.MoveLastItem = Nothing
        Me.RecipeBindingNavigator.MoveNextItem = Nothing
        Me.RecipeBindingNavigator.MovePreviousItem = Nothing
        Me.RecipeBindingNavigator.Name = "RecipeBindingNavigator"
        Me.RecipeBindingNavigator.PositionItem = Nothing
        Me.RecipeBindingNavigator.Size = New System.Drawing.Size(1004, 35)
        Me.RecipeBindingNavigator.TabIndex = 0
        Me.RecipeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 32)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'RecipeBindingSource
        '
        Me.RecipeBindingSource.DataMember = "Recipe"
        Me.RecipeBindingSource.DataSource = Me.ReceipeDataSet
        '
        'ReceipeDataSet
        '
        Me.ReceipeDataSet.DataSetName = "ReceipeDataSet"
        Me.ReceipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecipeBindingNavigatorSaveItem
        '
        Me.RecipeBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecipeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecipeBindingNavigatorSaveItem.Name = "RecipeBindingNavigatorSaveItem"
        Me.RecipeBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 32)
        Me.RecipeBindingNavigatorSaveItem.Text = "Save Data (F12)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 32)
        Me.ToolStripButton1.Text = "Refresh(F5)"
        Me.ToolStripButton1.Visible = False
        '
        'RecipeDataGridView
        '
        Me.RecipeDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RecipeDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RecipeDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecipeDataGridView.AutoGenerateColumns = False
        Me.RecipeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RecipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecipeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecipeId, Me.Development, Me.StyleId, Me.OrderId, Me.BuyerId, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.ReceipeDate, Me.MakeIn, Me.Wt, Me.PrintPartId, Me.Dollar, Me.ProductionMonthId, Me.ProductionFrom, Me.ProductionTo, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.AddFoilPaperCost})
        Me.RecipeDataGridView.DataSource = Me.RecipeBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecipeDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.RecipeDataGridView.Location = New System.Drawing.Point(24, 84)
        Me.RecipeDataGridView.Name = "RecipeDataGridView"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.RecipeDataGridView.Size = New System.Drawing.Size(954, 111)
        Me.RecipeDataGridView.TabIndex = 1
        '
        'RecipeId
        '
        Me.RecipeId.DataPropertyName = "RecipeId"
        Me.RecipeId.HeaderText = "Recipe No"
        Me.RecipeId.Name = "RecipeId"
        Me.RecipeId.ReadOnly = True
        Me.RecipeId.Width = 75
        '
        'Development
        '
        Me.Development.DataPropertyName = "Development"
        Me.Development.HeaderText = "Development"
        Me.Development.Name = "Development"
        Me.Development.Width = 70
        '
        'StyleId
        '
        Me.StyleId.DataPropertyName = "StyleId"
        Me.StyleId.DataSource = Me.StyleBindingSource
        Me.StyleId.DisplayMember = "StyleName"
        Me.StyleId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.StyleId.HeaderText = "Style"
        Me.StyleId.Name = "StyleId"
        Me.StyleId.ReadOnly = True
        Me.StyleId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StyleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StyleId.ValueMember = "StyleId"
        Me.StyleId.Width = 200
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderId
        '
        Me.OrderId.DataPropertyName = "OrderId"
        Me.OrderId.DataSource = Me.OrderBindingSource1
        Me.OrderId.DisplayMember = "ProgramNo"
        Me.OrderId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.OrderId.HeaderText = "Program No"
        Me.OrderId.Name = "OrderId"
        Me.OrderId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OrderId.ValueMember = "OrderId"
        '
        'OrderBindingSource1
        '
        Me.OrderBindingSource1.DataMember = "Order"
        Me.OrderBindingSource1.DataSource = Me.StyleOrderDataSet
        '
        'StyleOrderDataSet
        '
        Me.StyleOrderDataSet.DataSetName = "StyleOrderDataSet"
        Me.StyleOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerId
        '
        Me.BuyerId.DataPropertyName = "BuyerId"
        Me.BuyerId.DataSource = Me.BuyerBindingSource
        Me.BuyerId.DisplayMember = "BuyerCode"
        Me.BuyerId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BuyerId.HeaderText = "Buyer"
        Me.BuyerId.Name = "BuyerId"
        Me.BuyerId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BuyerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BuyerId.ValueMember = "BuyerId"
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.FabricColorBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "FabricColorId"
        Me.DataGridViewTextBoxColumn3.Width = 150
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GMQuantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "GM Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'ReceipeDate
        '
        Me.ReceipeDate.DataPropertyName = "ReceipeDate"
        DataGridViewCellStyle3.Format = "dd-MMM-yy"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ReceipeDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReceipeDate.HeaderText = "Receipe Date"
        Me.ReceipeDate.Name = "ReceipeDate"
        Me.ReceipeDate.ToolTipText = "Example: 05-Apr-09"
        Me.ReceipeDate.Width = 75
        '
        'MakeIn
        '
        Me.MakeIn.DataPropertyName = "MakeIn"
        Me.MakeIn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MakeIn.HeaderText = "Developed"
        Me.MakeIn.Items.AddRange(New Object() {"Machine", "Table"})
        Me.MakeIn.Name = "MakeIn"
        Me.MakeIn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MakeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MakeIn.Width = 75
        '
        'Wt
        '
        Me.Wt.DataPropertyName = "Wt"
        Me.Wt.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Wt.HeaderText = "Weight"
        Me.Wt.Items.AddRange(New Object() {"Chemical", "Garments"})
        Me.Wt.Name = "Wt"
        Me.Wt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Wt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Wt.Width = 75
        '
        'PrintPartId
        '
        Me.PrintPartId.DataPropertyName = "PrintPartId"
        Me.PrintPartId.DataSource = Me.PrintPartBindingSource
        Me.PrintPartId.DisplayMember = "PartName"
        Me.PrintPartId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PrintPartId.HeaderText = "Print Part"
        Me.PrintPartId.Name = "PrintPartId"
        Me.PrintPartId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrintPartId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PrintPartId.ValueMember = "PrintPartId"
        '
        'PrintPartBindingSource
        '
        Me.PrintPartBindingSource.DataMember = "PrintPart"
        Me.PrintPartBindingSource.DataSource = Me.PrintPartDataSet
        '
        'PrintPartDataSet
        '
        Me.PrintPartDataSet.DataSetName = "PrintPartDataSet"
        Me.PrintPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dollar
        '
        Me.Dollar.DataPropertyName = "Dollar"
        Me.Dollar.HeaderText = "Dollar"
        Me.Dollar.Name = "Dollar"
        '
        'ProductionMonthId
        '
        Me.ProductionMonthId.DataPropertyName = "ProductionMonthId"
        Me.ProductionMonthId.DataSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthId.DisplayMember = "ProductionMonthName"
        Me.ProductionMonthId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ProductionMonthId.HeaderText = "ProductionMonth"
        Me.ProductionMonthId.Name = "ProductionMonthId"
        Me.ProductionMonthId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductionMonthId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductionMonthId.ValueMember = "ProductionMonthId"
        '
        'ProductionMonthBindingSource
        '
        Me.ProductionMonthBindingSource.DataMember = "ProductionMonth"
        Me.ProductionMonthBindingSource.DataSource = Me.ProductionMonthDataSet
        '
        'ProductionMonthDataSet
        '
        Me.ProductionMonthDataSet.DataSetName = "ProductionMonthDataSet"
        Me.ProductionMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionFrom
        '
        Me.ProductionFrom.DataPropertyName = "ProductionFrom"
        Me.ProductionFrom.HeaderText = "ProductionFrom"
        Me.ProductionFrom.Name = "ProductionFrom"
        '
        'ProductionTo
        '
        Me.ProductionTo.DataPropertyName = "ProductionTo"
        Me.ProductionTo.HeaderText = "ProductionTo"
        Me.ProductionTo.Name = "ProductionTo"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "PrintTypeId"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.PrintTypeBindingSource1
        Me.DataGridViewComboBoxColumn1.DisplayMember = "PrintTypeName"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "Body PrintType"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "PrintTypeId"
        '
        'PrintTypeBindingSource1
        '
        Me.PrintTypeBindingSource1.DataMember = "PrintType"
        Me.PrintTypeBindingSource1.DataSource = Me.PrintTypeDataSet
        '
        'PrintTypeDataSet
        '
        Me.PrintTypeDataSet.DataSetName = "PrintTypeDataSet"
        Me.PrintTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'AddFoilPaperCost
        '
        Me.AddFoilPaperCost.DataPropertyName = "RecipeId"
        Me.AddFoilPaperCost.HeaderText = "Others Cost"
        Me.AddFoilPaperCost.Name = "AddFoilPaperCost"
        Me.AddFoilPaperCost.ReadOnly = True
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
        'PrintTypeBindingSource
        '
        Me.PrintTypeBindingSource.DataMember = "PrintType"
        Me.PrintTypeBindingSource.DataSource = Me.PrintTypeDataSet
        '
        'RecipeColorBindingSource
        '
        Me.RecipeColorBindingSource.DataMember = "FK_RecipeColor_Recipe"
        Me.RecipeColorBindingSource.DataSource = Me.RecipeBindingSource
        '
        'RecipeColorDataGridView
        '
        Me.RecipeColorDataGridView.AllowUserToAddRows = False
        Me.RecipeColorDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecipeColorDataGridView.AutoGenerateColumns = False
        Me.RecipeColorDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeColorDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.RecipeColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecipeColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrintColorId, Me.PrintTypeId, Me.Weight_BeforePrint, Me.Weight_AfterPrint, Me.WastagePercentage, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.RecipeColorDataGridView.DataSource = Me.RecipeColorBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecipeColorDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.RecipeColorDataGridView.Location = New System.Drawing.Point(24, 220)
        Me.RecipeColorDataGridView.Name = "RecipeColorDataGridView"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeColorDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.RecipeColorDataGridView.Size = New System.Drawing.Size(954, 112)
        Me.RecipeColorDataGridView.TabIndex = 2
        '
        'PrintColorId
        '
        Me.PrintColorId.DataPropertyName = "PrintColorId"
        Me.PrintColorId.DataSource = Me.PrintColorBindingSource
        Me.PrintColorId.DisplayMember = "PrintColor"
        Me.PrintColorId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PrintColorId.HeaderText = "Print Color"
        Me.PrintColorId.Name = "PrintColorId"
        Me.PrintColorId.ReadOnly = True
        Me.PrintColorId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrintColorId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PrintColorId.ValueMember = "PrintColorId"
        Me.PrintColorId.Width = 200
        '
        'PrintColorBindingSource
        '
        Me.PrintColorBindingSource.DataMember = "PrintColor"
        Me.PrintColorBindingSource.DataSource = Me.PrintColorDataSet
        '
        'PrintColorDataSet
        '
        Me.PrintColorDataSet.DataSetName = "PrintColorDataSet"
        Me.PrintColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintTypeId
        '
        Me.PrintTypeId.DataPropertyName = "PrintTypeId"
        Me.PrintTypeId.DataSource = Me.PrintTypeBindingSource
        Me.PrintTypeId.DisplayMember = "PrintTypeName"
        Me.PrintTypeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PrintTypeId.HeaderText = "Print Type"
        Me.PrintTypeId.Name = "PrintTypeId"
        Me.PrintTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrintTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PrintTypeId.ValueMember = "PrintTypeId"
        Me.PrintTypeId.Width = 150
        '
        'Weight_BeforePrint
        '
        Me.Weight_BeforePrint.DataPropertyName = "Weight_BeforePrint"
        Me.Weight_BeforePrint.HeaderText = "Weight  [BeforePrint]"
        Me.Weight_BeforePrint.Name = "Weight_BeforePrint"
        '
        'Weight_AfterPrint
        '
        Me.Weight_AfterPrint.DataPropertyName = "Weight_AfterPrint"
        Me.Weight_AfterPrint.HeaderText = "Weight [AfterPrint]"
        Me.Weight_AfterPrint.Name = "Weight_AfterPrint"
        '
        'WastagePercentage
        '
        Me.WastagePercentage.DataPropertyName = "WastagePercentage"
        Me.WastagePercentage.HeaderText = "Wastage Percentage"
        Me.WastagePercentage.Name = "WastagePercentage"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UsedQuanty"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Used Quanty"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'RecipeItemBindingSource
        '
        Me.RecipeItemBindingSource.DataMember = "FK_RecipeItem_RecipeColor"
        Me.RecipeItemBindingSource.DataSource = Me.RecipeColorBindingSource
        '
        'RecipeItemDataGridView
        '
        Me.RecipeItemDataGridView.AllowUserToAddRows = False
        Me.RecipeItemDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecipeItemDataGridView.AutoGenerateColumns = False
        Me.RecipeItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeItemDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.RecipeItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecipeItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.colUnitPrice, Me.DataGridViewTextBoxColumn16, Me.TotalPrice, Me.UsedQuantity, Me.DataGridViewTextBoxColumn18})
        Me.RecipeItemDataGridView.DataSource = Me.RecipeItemBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecipeItemDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.RecipeItemDataGridView.Location = New System.Drawing.Point(24, 364)
        Me.RecipeItemDataGridView.Name = "RecipeItemDataGridView"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecipeItemDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.RecipeItemDataGridView.Size = New System.Drawing.Size(954, 163)
        Me.RecipeItemDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ItemId"
        Me.DataGridViewTextBoxColumn15.DataSource = Me.ItemListBindingSource1
        Me.DataGridViewTextBoxColumn15.DisplayMember = "ItemName"
        Me.DataGridViewTextBoxColumn15.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn15.HeaderText = "Item  Name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn15.ValueMember = "ItemId"
        Me.DataGridViewTextBoxColumn15.Width = 200
        '
        'ItemListBindingSource1
        '
        Me.ItemListBindingSource1.DataMember = "ItemList"
        Me.ItemListBindingSource1.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colUnitPrice
        '
        Me.colUnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colUnitPrice.DefaultCellStyle = DataGridViewCellStyle10
        Me.colUnitPrice.HeaderText = "Unit Price"
        Me.colUnitPrice.Name = "colUnitPrice"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RecipeQuantity"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn16.HeaderText = "Recipe Quantity"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'TotalPrice
        '
        Me.TotalPrice.DataPropertyName = "TotalPrice"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.TotalPrice.DefaultCellStyle = DataGridViewCellStyle12
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'UsedQuantity
        '
        Me.UsedQuantity.DataPropertyName = "UsedQuantity"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N3"
        DataGridViewCellStyle13.NullValue = "0"
        Me.UsedQuantity.DefaultCellStyle = DataGridViewCellStyle13
        Me.UsedQuantity.HeaderText = "Used Quantity"
        Me.UsedQuantity.Name = "UsedQuantity"
        Me.UsedQuantity.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'VItemListBindingSource
        '
        Me.VItemListBindingSource.DataMember = "vItemList"
        Me.VItemListBindingSource.DataSource = Me.ItemNameDataSet
        '
        'ItemNameDataSet
        '
        Me.ItemNameDataSet.DataSetName = "ItemNameDataSet"
        Me.ItemNameDataSet.EnforceConstraints = False
        Me.ItemNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'VItemListTableAdapter
        '
        Me.VItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.PriceDataSet
        '
        'PriceDataSet
        '
        Me.PriceDataSet.DataSetName = "PriceDataSet"
        Me.PriceDataSet.EnforceConstraints = False
        Me.PriceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.PriceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TotalRecipeTextBox
        '
        Me.TotalRecipeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalRecipeTextBox.Location = New System.Drawing.Point(426, 533)
        Me.TotalRecipeTextBox.Name = "TotalRecipeTextBox"
        Me.TotalRecipeTextBox.ReadOnly = True
        Me.TotalRecipeTextBox.Size = New System.Drawing.Size(87, 20)
        Me.TotalRecipeTextBox.TabIndex = 12
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(594, 533)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.ReadOnly = True
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(85, 20)
        Me.TotalPriceTextBox.TabIndex = 13
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(903, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsedQuantyTextBox
        '
        Me.UsedQuantyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsedQuantyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipeColorBindingSource, "UsedQuanty", True))
        Me.UsedQuantyTextBox.Location = New System.Drawing.Point(532, 365)
        Me.UsedQuantyTextBox.Name = "UsedQuantyTextBox"
        Me.UsedQuantyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsedQuantyTextBox.TabIndex = 15
        '
        'RecipeIdLabel
        '
        Me.RecipeIdLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecipeIdLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipeBindingSource, "RecipeId", True))
        Me.RecipeIdLabel.Location = New System.Drawing.Point(888, 59)
        Me.RecipeIdLabel.Name = "RecipeIdLabel"
        Me.RecipeIdLabel.Size = New System.Drawing.Size(90, 16)
        Me.RecipeIdLabel.TabIndex = 16
        Me.RecipeIdLabel.Text = "###"
        Me.RecipeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ItemListTableAdapter1
        '
        Me.ItemListTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Total Recipe Quantity"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(814, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Receipe Id :"
        '
        'AddLinkLabel
        '
        Me.AddLinkLabel.AutoSize = True
        Me.AddLinkLabel.Location = New System.Drawing.Point(24, 340)
        Me.AddLinkLabel.Name = "AddLinkLabel"
        Me.AddLinkLabel.Size = New System.Drawing.Size(53, 13)
        Me.AddLinkLabel.TabIndex = 19
        Me.AddLinkLabel.TabStop = True
        Me.AddLinkLabel.Text = "Add Color"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(519, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Price"
        '
        'StyleBindingSource1
        '
        Me.StyleBindingSource1.DataMember = "Style"
        Me.StyleBindingSource1.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Select Style Name :"
        '
        'StyleTableAdapter1
        '
        Me.StyleTableAdapter1.ClearBeforeFill = True
        '
        'PrintColorLookupDataSet
        '
        Me.PrintColorLookupDataSet.DataSetName = "PrintColorLookupDataSet"
        Me.PrintColorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecipeColorBindingSource1
        '
        Me.RecipeColorBindingSource1.DataMember = "RecipeColor"
        Me.RecipeColorBindingSource1.DataSource = Me.PrintColorLookupDataSet
        '
        'RecipeColorTableAdapter1
        '
        Me.RecipeColorTableAdapter1.ClearBeforeFill = True
        '
        'PrintColorTableAdapter
        '
        Me.PrintColorTableAdapter.ClearBeforeFill = True
        '
        'PrintColorComboBox
        '
        Me.PrintColorComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintColorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PrintColorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PrintColorComboBox.DataSource = Me.PrintColorBindingSource
        Me.PrintColorComboBox.DisplayMember = "PrintColor"
        Me.PrintColorComboBox.FormattingEnabled = True
        Me.PrintColorComboBox.Location = New System.Drawing.Point(534, 7)
        Me.PrintColorComboBox.Name = "PrintColorComboBox"
        Me.PrintColorComboBox.Size = New System.Drawing.Size(133, 21)
        Me.PrintColorComboBox.TabIndex = 22
        Me.PrintColorComboBox.ValueMember = "PrintColorId"
        Me.PrintColorComboBox.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(876, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Search Recipe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CopyLinkLabel
        '
        Me.CopyLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CopyLinkLabel.AutoSize = True
        Me.CopyLinkLabel.Location = New System.Drawing.Point(91, 538)
        Me.CopyLinkLabel.Name = "CopyLinkLabel"
        Me.CopyLinkLabel.Size = New System.Drawing.Size(31, 13)
        Me.CopyLinkLabel.TabIndex = 24
        Me.CopyLinkLabel.TabStop = True
        Me.CopyLinkLabel.Text = "Copy"
        '
        'PasteLinkLabel
        '
        Me.PasteLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PasteLinkLabel.AutoSize = True
        Me.PasteLinkLabel.Location = New System.Drawing.Point(138, 538)
        Me.PasteLinkLabel.Name = "PasteLinkLabel"
        Me.PasteLinkLabel.Size = New System.Drawing.Size(34, 13)
        Me.PasteLinkLabel.TabIndex = 25
        Me.PasteLinkLabel.TabStop = True
        Me.PasteLinkLabel.Text = "Paste"
        '
        'CopiedRecipeItemDataSet
        '
        Me.CopiedRecipeItemDataSet.DataSetName = "CopiedRecipeItemDataSet"
        Me.CopiedRecipeItemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CopiedRecipeItemBindingSource
        '
        Me.CopiedRecipeItemBindingSource.DataMember = "CopiedRecipeItem"
        Me.CopiedRecipeItemBindingSource.DataSource = Me.CopiedRecipeItemDataSet
        '
        'CopiedRecipeItemTableAdapter
        '
        Me.CopiedRecipeItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CopiedRecipeItemTableAdapter = Me.CopiedRecipeItemTableAdapter
        Me.TableAdapterManager2.UpdateOrder = KSoft_Apparel.CopiedRecipeItemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(534, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Print Color     "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CopyPrintColorLinkLabel
        '
        Me.CopyPrintColorLinkLabel.AutoSize = True
        Me.CopyPrintColorLinkLabel.Location = New System.Drawing.Point(102, 340)
        Me.CopyPrintColorLinkLabel.Name = "CopyPrintColorLinkLabel"
        Me.CopyPrintColorLinkLabel.Size = New System.Drawing.Size(31, 13)
        Me.CopyPrintColorLinkLabel.TabIndex = 27
        Me.CopyPrintColorLinkLabel.TabStop = True
        Me.CopyPrintColorLinkLabel.Text = "Copy"
        Me.CopyPrintColorLinkLabel.Visible = False
        '
        'PastePrintColorLinkLabel
        '
        Me.PastePrintColorLinkLabel.AutoSize = True
        Me.PastePrintColorLinkLabel.Location = New System.Drawing.Point(150, 340)
        Me.PastePrintColorLinkLabel.Name = "PastePrintColorLinkLabel"
        Me.PastePrintColorLinkLabel.Size = New System.Drawing.Size(34, 13)
        Me.PastePrintColorLinkLabel.TabIndex = 28
        Me.PastePrintColorLinkLabel.TabStop = True
        Me.PastePrintColorLinkLabel.Text = "Paste"
        Me.PastePrintColorLinkLabel.Visible = False
        '
        'CopiedRecipeColorDataSet
        '
        Me.CopiedRecipeColorDataSet.DataSetName = "CopiedRecipeColorDataSet"
        Me.CopiedRecipeColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CopiedRecipeColorBindingSource
        '
        Me.CopiedRecipeColorBindingSource.DataMember = "CopiedRecipeColor"
        Me.CopiedRecipeColorBindingSource.DataSource = Me.CopiedRecipeColorDataSet
        '
        'CopiedRecipeColorTableAdapter
        '
        Me.CopiedRecipeColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.CopiedRecipeColorTableAdapter = Me.CopiedRecipeColorTableAdapter
        Me.TableAdapterManager3.UpdateOrder = KSoft_Apparel.CopiedRecipeColorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DefaultLinkLabel
        '
        Me.DefaultLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DefaultLinkLabel.AutoSize = True
        Me.DefaultLinkLabel.Location = New System.Drawing.Point(190, 538)
        Me.DefaultLinkLabel.Name = "DefaultLinkLabel"
        Me.DefaultLinkLabel.Size = New System.Drawing.Size(41, 13)
        Me.DefaultLinkLabel.TabIndex = 29
        Me.DefaultLinkLabel.TabStop = True
        Me.DefaultLinkLabel.Text = "Default"
        '
        'MinRecipeColorIdDataSet
        '
        Me.MinRecipeColorIdDataSet.DataSetName = "MinRecipeColorIdDataSet"
        Me.MinRecipeColorIdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MinRecipeColorBindingSource
        '
        Me.MinRecipeColorBindingSource.DataMember = "MinRecipeColor"
        Me.MinRecipeColorBindingSource.DataSource = Me.MinRecipeColorIdDataSet
        '
        'MinRecipeColorTableAdapter
        '
        Me.MinRecipeColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = KSoft_Apparel.MinRecipeColorIdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceipeStyleLookupBindingSource
        '
        Me.ReceipeStyleLookupBindingSource.DataMember = "ReceipeStyleLookup"
        Me.ReceipeStyleLookupBindingSource.DataSource = Me.ReceipeStyleLookupDataSet
        '
        'ReceipeStyleLookupDataSet
        '
        Me.ReceipeStyleLookupDataSet.DataSetName = "ReceipeStyleLookupDataSet"
        Me.ReceipeStyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceipeStyleLookupTableAdapter
        '
        Me.ReceipeStyleLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupGridLookUpEdit
        '
        Me.StyleLookupGridLookUpEdit.Location = New System.Drawing.Point(146, 58)
        Me.StyleLookupGridLookUpEdit.Name = "StyleLookupGridLookUpEdit"
        Me.StyleLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleLookupGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleLookupGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleLookupGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.StyleLookupGridLookUpEdit.Size = New System.Drawing.Size(144, 20)
        Me.StyleLookupGridLookUpEdit.TabIndex = 30
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.StyleOrderDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleBindingSource2
        '
        Me.StyleBindingSource2.DataMember = "Style"
        Me.StyleBindingSource2.DataSource = Me.StyleLookupDataSet
        '
        'AddRecipeItemLink
        '
        Me.AddRecipeItemLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddRecipeItemLink.AutoSize = True
        Me.AddRecipeItemLink.Location = New System.Drawing.Point(26, 539)
        Me.AddRecipeItemLink.Name = "AddRecipeItemLink"
        Me.AddRecipeItemLink.Size = New System.Drawing.Size(49, 13)
        Me.AddRecipeItemLink.TabIndex = 31
        Me.AddRecipeItemLink.TabStop = True
        Me.AddRecipeItemLink.Text = "Add Item"
        '
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'ProductionMonthTableAdapter
        '
        Me.ProductionMonthTableAdapter.ClearBeforeFill = True
        '
        'ClearProgramLinkLabel
        '
        Me.ClearProgramLinkLabel.AutoSize = True
        Me.ClearProgramLinkLabel.Location = New System.Drawing.Point(531, 62)
        Me.ClearProgramLinkLabel.Name = "ClearProgramLinkLabel"
        Me.ClearProgramLinkLabel.Size = New System.Drawing.Size(73, 13)
        Me.ClearProgramLinkLabel.TabIndex = 32
        Me.ClearProgramLinkLabel.TabStop = True
        Me.ClearProgramLinkLabel.Text = "Clear Program"
        '
        'PrintColorLookupGridLookUpEdit
        '
        Me.PrintColorLookupGridLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintColorLookupGridLookUpEdit.Location = New System.Drawing.Point(673, 7)
        Me.PrintColorLookupGridLookUpEdit.Name = "PrintColorLookupGridLookUpEdit"
        Me.PrintColorLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintColorLookupGridLookUpEdit.Properties.DataSource = Me.PrintColorBindingSource
        Me.PrintColorLookupGridLookUpEdit.Properties.DisplayMember = "PrintColor"
        Me.PrintColorLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrintColorLookupGridLookUpEdit.Properties.NullText = "[Type Print Color]"
        Me.PrintColorLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintColorLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintColorLookupGridLookUpEdit.Properties.ValueMember = "PrintColorId"
        Me.PrintColorLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.PrintColorLookupGridLookUpEdit.Size = New System.Drawing.Size(197, 20)
        Me.PrintColorLookupGridLookUpEdit.TabIndex = 34
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintColorId, Me.colPrintColor})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPrintColorId
        '
        Me.colPrintColorId.FieldName = "PrintColorId"
        Me.colPrintColorId.Name = "colPrintColorId"
        Me.colPrintColorId.OptionsColumn.ReadOnly = True
        '
        'colPrintColor
        '
        Me.colPrintColor.FieldName = "PrintColor"
        Me.colPrintColor.Name = "colPrintColor"
        Me.colPrintColor.Visible = True
        Me.colPrintColor.VisibleIndex = 0
        '
        'OrderLookupTableAdapter1
        '
        Me.OrderLookupTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "OrderLookup"
        Me.BindingSource1.DataSource = Me.OrderLookupDataSet1
        '
        'OrderLookupDataSet1
        '
        Me.OrderLookupDataSet1.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet1.EnforceConstraints = False
        Me.OrderLookupDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(298, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 14)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Program No :"
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(382, 58)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Select/Write  Program]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridView2
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 68
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'RecipeTableAdapter
        '
        Me.RecipeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RecipeColorTableAdapter = Me.RecipeColorTableAdapter
        Me.TableAdapterManager.RecipeItemTableAdapter = Me.RecipeItemTableAdapter
        Me.TableAdapterManager.RecipeTableAdapter = Me.RecipeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ReceipeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecipeColorTableAdapter
        '
        Me.RecipeColorTableAdapter.ClearBeforeFill = True
        '
        'RecipeItemTableAdapter
        '
        Me.RecipeItemTableAdapter.ClearBeforeFill = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(618, 57)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyButton.TabIndex = 70
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'PasteButton
        '
        Me.PasteButton.Location = New System.Drawing.Point(699, 57)
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(75, 23)
        Me.PasteButton.TabIndex = 71
        Me.PasteButton.Text = "Paste"
        Me.PasteButton.UseVisualStyleBackColor = True
        '
        'CalUsedQuantitiyLinkLabel
        '
        Me.CalUsedQuantitiyLinkLabel.AutoSize = True
        Me.CalUsedQuantitiyLinkLabel.Location = New System.Drawing.Point(238, 340)
        Me.CalUsedQuantitiyLinkLabel.Name = "CalUsedQuantitiyLinkLabel"
        Me.CalUsedQuantitiyLinkLabel.Size = New System.Drawing.Size(193, 13)
        Me.CalUsedQuantitiyLinkLabel.TabIndex = 72
        Me.CalUsedQuantitiyLinkLabel.TabStop = True
        Me.CalUsedQuantitiyLinkLabel.Text = "Set  Recipe Quantity  As Used Quantity"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(454, 340)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(121, 13)
        Me.LinkLabel1.TabIndex = 73
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Calculate Used Quantity"
        '
        'frmRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 577)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CalUsedQuantitiyLinkLabel)
        Me.Controls.Add(Me.PasteButton)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.PrintColorLookupGridLookUpEdit)
        Me.Controls.Add(Me.ClearProgramLinkLabel)
        Me.Controls.Add(Me.AddRecipeItemLink)
        Me.Controls.Add(Me.StyleLookupGridLookUpEdit)
        Me.Controls.Add(Me.DefaultLinkLabel)
        Me.Controls.Add(Me.PastePrintColorLinkLabel)
        Me.Controls.Add(Me.CopyPrintColorLinkLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasteLinkLabel)
        Me.Controls.Add(Me.CopyLinkLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PrintColorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AddLinkLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecipeIdLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalPriceTextBox)
        Me.Controls.Add(Me.TotalRecipeTextBox)
        Me.Controls.Add(Me.RecipeItemDataGridView)
        Me.Controls.Add(Me.RecipeColorDataGridView)
        Me.Controls.Add(Me.RecipeDataGridView)
        Me.Controls.Add(Me.RecipeBindingNavigator)
        Me.Controls.Add(UsedQuantyLabel)
        Me.Controls.Add(Me.UsedQuantyTextBox)
        Me.KeyPreview = True
        Me.Name = "frmRecipe"
        Me.Text = "Recipe"
        CType(Me.RecipeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecipeBindingNavigator.ResumeLayout(False)
        Me.RecipeBindingNavigator.PerformLayout()
        CType(Me.RecipeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipeColorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopiedRecipeItemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopiedRecipeItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopiedRecipeColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopiedRecipeColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinRecipeColorIdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinRecipeColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceipeStyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceipeStyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintColorLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceipeDataSet As KSoft_Apparel.ReceipeDataSet
    Friend WithEvents RecipeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecipeTableAdapter As KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ReceipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecipeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RecipeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RecipeColorTableAdapter As KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeColorTableAdapter
    Friend WithEvents RecipeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RecipeColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecipeItemTableAdapter As KSoft_Apparel.ReceipeDataSetTableAdapters.RecipeItemTableAdapter
    Friend WithEvents RecipeColorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RecipeItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecipeItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents ItemNameDataSet As KSoft_Apparel.ItemNameDataSet
    Friend WithEvents VItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VItemListTableAdapter As KSoft_Apparel.ItemNameDataSetTableAdapters.vItemListTableAdapter
    Friend WithEvents PriceDataSet As KSoft_Apparel.PriceDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.PriceDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.PriceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TotalRecipeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UsedQuantyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecipeIdLabel As System.Windows.Forms.Label
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter1 As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter1 As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents PrintColorLookupDataSet As KSoft_Apparel.PrintColorLookupDataSet
    Friend WithEvents RecipeColorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RecipeColorTableAdapter1 As KSoft_Apparel.PrintColorLookupDataSetTableAdapters.RecipeColorTableAdapter
    Friend WithEvents PrintColorDataSet As KSoft_Apparel.PrintColorDataSet
    Friend WithEvents PrintColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintColorTableAdapter As KSoft_Apparel.PrintColorDataSetTableAdapters.PrintColorTableAdapter
    Friend WithEvents PrintColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CopyLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PasteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CopiedRecipeItemDataSet As KSoft_Apparel.CopiedRecipeItemDataSet
    Friend WithEvents CopiedRecipeItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CopiedRecipeItemTableAdapter As KSoft_Apparel.CopiedRecipeItemDataSetTableAdapters.CopiedRecipeItemTableAdapter
    Friend WithEvents TableAdapterManager2 As KSoft_Apparel.CopiedRecipeItemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CopyPrintColorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PastePrintColorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CopiedRecipeColorDataSet As KSoft_Apparel.CopiedRecipeColorDataSet
    Friend WithEvents CopiedRecipeColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CopiedRecipeColorTableAdapter As KSoft_Apparel.CopiedRecipeColorDataSetTableAdapters.CopiedRecipeColorTableAdapter
    Friend WithEvents TableAdapterManager3 As KSoft_Apparel.CopiedRecipeColorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DefaultLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents MinRecipeColorIdDataSet As KSoft_Apparel.MinRecipeColorIdDataSet
    Friend WithEvents MinRecipeColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MinRecipeColorTableAdapter As KSoft_Apparel.MinRecipeColorIdDataSetTableAdapters.MinRecipeColorTableAdapter
    Friend WithEvents TableAdapterManager4 As KSoft_Apparel.MinRecipeColorIdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceipeStyleLookupDataSet As KSoft_Apparel.ReceipeStyleLookupDataSet
    Friend WithEvents ReceipeStyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceipeStyleLookupTableAdapter As KSoft_Apparel.ReceipeStyleLookupDataSetTableAdapters.ReceipeStyleLookupTableAdapter
    Friend WithEvents StyleLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleOrderDataSet As KSoft_Apparel.StyleOrderDataSet
    Friend WithEvents OrderTableAdapter As KSoft_Apparel.StyleOrderDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StyleBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents AddRecipeItemLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents ProductionMonthDataSet As KSoft_Apparel.ProductionMonthDataSet
    Friend WithEvents ProductionMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionMonthTableAdapter As KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
    Friend WithEvents ClearProgramLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintTypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PrintColorLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupTableAdapter1 As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet1 As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents PasteButton As System.Windows.Forms.Button
    Friend WithEvents PrintColorId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PrintTypeId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Weight_BeforePrint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weight_AfterPrint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WastagePercentage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Development As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StyleId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents OrderId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BuyerId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceipeDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MakeIn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Wt As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PrintPartId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Dollar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductionMonthId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductionFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductionTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddFoilPaperCost As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsedQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalUsedQuantitiyLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
