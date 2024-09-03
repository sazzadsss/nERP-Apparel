<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStyle
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
        Dim StyleNameLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim PrintDetailsLabel As System.Windows.Forms.Label
        Dim GSMLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim KnittingTypeIdLabel1 As System.Windows.Forms.Label
        Dim CompositionIdLabel1 As System.Windows.Forms.Label
        Dim StyleTypeLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DefaultTargetLabel As System.Windows.Forms.Label
        Dim SMVLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim GMDescriptionLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim GaugeLabel As System.Windows.Forms.Label
        Dim SeasonIdLabel As System.Windows.Forms.Label
        Dim EmbDetailsLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RefreshLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ExportLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StyleLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.StyleNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PrintDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GSMSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PrintTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet()
        Me.KnittingTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingTypeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.CompositionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompositionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.StyleNameIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleNameId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNameGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleNameIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleNameMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet()
        Me.IsEmbroideryCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsAOPCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsYDSCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TableAdapterManager1 = New KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintDetailsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TrimDetailsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.FabricDetailsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter()
        Me.PrintPartIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintPartId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintPartIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet()
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter()
        Me.MergeButton = New System.Windows.Forms.Button()
        Me.Openfile = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.FRStyleProcessDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FRProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FRProcessDataSet = New KSoft_Apparel.FRProcessDataSet()
        Me.Factor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FRStyleProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager()
        Me.FRStyleProcessTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.FRStyleProcessTableAdapter()
        Me.StyleNameMstTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.FRProcessTableAdapter = New KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter()
        Me.DivisionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.DivisionLookupByBuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionLookupByBuyerDataSet = New KSoft_Apparel.DivisionLookupByBuyerDataSet()
        Me.DiaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.IsWashCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet()
        Me.DefaultTargetTextBox = New System.Windows.Forms.TextBox()
        Me.SMVTextBox = New System.Windows.Forms.TextBox()
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter()
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMDescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.DivisionLookupByBuyerTableAdapter = New KSoft_Apparel.DivisionLookupByBuyerDataSetTableAdapters.DivisionLookupByBuyerTableAdapter()
        Me.IsBrushCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsPeachFinishCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PrintTypeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PrintPartLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.GMTBrandIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTBrandIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GaugeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SeasonIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.EmbDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MCQtyTextBox = New System.Windows.Forms.TextBox()
        Me.SublimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SequenceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ForeignCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.YarnDyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnDyeingTypeGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        StyleNameLabel = New System.Windows.Forms.Label()
        BuyerIdLabel = New System.Windows.Forms.Label()
        PrintDetailsLabel = New System.Windows.Forms.Label()
        GSMLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        KnittingTypeIdLabel1 = New System.Windows.Forms.Label()
        CompositionIdLabel1 = New System.Windows.Forms.Label()
        StyleTypeLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DefaultTargetLabel = New System.Windows.Forms.Label()
        SMVLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        GMDescriptionLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        GaugeLabel = New System.Windows.Forms.Label()
        SeasonIdLabel = New System.Windows.Forms.Label()
        EmbDetailsLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PrintPartIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FRStyleProcessDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRStyleProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionLookupByBuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionLookupByBuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaugeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForeignCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleNameLabel
        '
        StyleNameLabel.AutoSize = True
        StyleNameLabel.Location = New System.Drawing.Point(23, 52)
        StyleNameLabel.Name = "StyleNameLabel"
        StyleNameLabel.Size = New System.Drawing.Size(50, 13)
        StyleNameLabel.TabIndex = 19
        StyleNameLabel.Text = "Style No:"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(23, 104)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(37, 13)
        BuyerIdLabel.TabIndex = 21
        BuyerIdLabel.Text = "Buyer:"
        '
        'PrintDetailsLabel
        '
        PrintDetailsLabel.AutoSize = True
        PrintDetailsLabel.Location = New System.Drawing.Point(24, 302)
        PrintDetailsLabel.Name = "PrintDetailsLabel"
        PrintDetailsLabel.Size = New System.Drawing.Size(66, 13)
        PrintDetailsLabel.TabIndex = 23
        PrintDetailsLabel.Text = "Print Details:"
        '
        'GSMLabel
        '
        GSMLabel.AutoSize = True
        GSMLabel.Location = New System.Drawing.Point(294, 102)
        GSMLabel.Name = "GSMLabel"
        GSMLabel.Size = New System.Drawing.Size(34, 13)
        GSMLabel.TabIndex = 16
        GSMLabel.Text = "GSM:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(28, 463)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 24
        RemarksLabel.Text = "Remarks:"
        '
        'KnittingTypeIdLabel1
        '
        KnittingTypeIdLabel1.AutoSize = True
        KnittingTypeIdLabel1.Location = New System.Drawing.Point(294, 52)
        KnittingTypeIdLabel1.Name = "KnittingTypeIdLabel1"
        KnittingTypeIdLabel1.Size = New System.Drawing.Size(63, 13)
        KnittingTypeIdLabel1.TabIndex = 18
        KnittingTypeIdLabel1.Text = "Fabric Type"
        '
        'CompositionIdLabel1
        '
        CompositionIdLabel1.AutoSize = True
        CompositionIdLabel1.Location = New System.Drawing.Point(294, 77)
        CompositionIdLabel1.Name = "CompositionIdLabel1"
        CompositionIdLabel1.Size = New System.Drawing.Size(67, 13)
        CompositionIdLabel1.TabIndex = 17
        CompositionIdLabel1.Text = "Composition:"
        '
        'StyleTypeLabel1
        '
        StyleTypeLabel1.AutoSize = True
        StyleTypeLabel1.Location = New System.Drawing.Point(294, 154)
        StyleTypeLabel1.Name = "StyleTypeLabel1"
        StyleTypeLabel1.Size = New System.Drawing.Size(60, 13)
        StyleTypeLabel1.TabIndex = 0
        StyleTypeLabel1.Text = "Style Type:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(432, 102)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(26, 13)
        Label2.TabIndex = 37
        Label2.Text = "Dia:"
        '
        'DefaultTargetLabel
        '
        DefaultTargetLabel.AutoSize = True
        DefaultTargetLabel.Location = New System.Drawing.Point(168, 434)
        DefaultTargetLabel.Name = "DefaultTargetLabel"
        DefaultTargetLabel.Size = New System.Drawing.Size(55, 13)
        DefaultTargetLabel.TabIndex = 0
        DefaultTargetLabel.Text = "Target/hr:"
        '
        'SMVLabel
        '
        SMVLabel.AutoSize = True
        SMVLabel.Location = New System.Drawing.Point(28, 433)
        SMVLabel.Name = "SMVLabel"
        SMVLabel.Size = New System.Drawing.Size(33, 13)
        SMVLabel.TabIndex = 0
        SMVLabel.Text = "SMV:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(23, 156)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 39
        Label3.Text = "Division:"
        '
        'GMDescriptionLabel
        '
        GMDescriptionLabel.AutoSize = True
        GMDescriptionLabel.Location = New System.Drawing.Point(23, 204)
        GMDescriptionLabel.Name = "GMDescriptionLabel"
        GMDescriptionLabel.Size = New System.Drawing.Size(80, 13)
        GMDescriptionLabel.TabIndex = 0
        GMDescriptionLabel.Text = "GMDescription:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(24, 130)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(38, 13)
        BrandLabel.TabIndex = 0
        BrandLabel.Text = "Brand:"
        '
        'GaugeLabel
        '
        GaugeLabel.AutoSize = True
        GaugeLabel.Location = New System.Drawing.Point(294, 129)
        GaugeLabel.Name = "GaugeLabel"
        GaugeLabel.Size = New System.Drawing.Size(42, 13)
        GaugeLabel.TabIndex = 0
        GaugeLabel.Text = "Gauge:"
        '
        'SeasonIdLabel
        '
        SeasonIdLabel.AutoSize = True
        SeasonIdLabel.Location = New System.Drawing.Point(23, 179)
        SeasonIdLabel.Name = "SeasonIdLabel"
        SeasonIdLabel.Size = New System.Drawing.Size(49, 13)
        SeasonIdLabel.TabIndex = 0
        SeasonIdLabel.Text = "Season :"
        '
        'EmbDetailsLabel
        '
        EmbDetailsLabel.AutoSize = True
        EmbDetailsLabel.Location = New System.Drawing.Point(28, 387)
        EmbDetailsLabel.Name = "EmbDetailsLabel"
        EmbDetailsLabel.Size = New System.Drawing.Size(66, 13)
        EmbDetailsLabel.TabIndex = 0
        EmbDetailsLabel.Text = "Emb Details:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(303, 434)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(26, 13)
        Label4.TabIndex = 0
        Label4.Text = "CM:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(414, 434)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(26, 13)
        Label5.TabIndex = 0
        Label5.Text = "MC:"
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 7)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 7, 5, 5)
        Me.NewLinkLabel.Name = "NewLinkLabel"
        Me.NewLinkLabel.Size = New System.Drawing.Size(29, 15)
        Me.NewLinkLabel.TabIndex = 0
        Me.NewLinkLabel.TabStop = True
        Me.NewLinkLabel.Text = "Add"
        Me.NewLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(102, 7)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 7, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(43, 15)
        Me.DeleteLinkLabel.TabIndex = 2
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelLinkLabel.Location = New System.Drawing.Point(158, 7)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 7, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(46, 15)
        Me.CancelLinkLabel.TabIndex = 3
        Me.CancelLinkLabel.TabStop = True
        Me.CancelLinkLabel.Text = "Cancel"
        Me.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditLinkLabel.Location = New System.Drawing.Point(60, 7)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 7, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(28, 15)
        Me.EditLinkLabel.TabIndex = 1
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExportLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkLabel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1026, 31)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.AutoSize = True
        Me.RefreshLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(217, 7)
        Me.RefreshLinkLabel.Margin = New System.Windows.Forms.Padding(8, 7, 5, 5)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(52, 15)
        Me.RefreshLinkLabel.TabIndex = 6
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh"
        Me.RefreshLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExportLinkLabel
        '
        Me.ExportLinkLabel.AutoSize = True
        Me.ExportLinkLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportLinkLabel.Location = New System.Drawing.Point(282, 7)
        Me.ExportLinkLabel.Margin = New System.Windows.Forms.Padding(8, 7, 5, 5)
        Me.ExportLinkLabel.Name = "ExportLinkLabel"
        Me.ExportLinkLabel.Size = New System.Drawing.Size(82, 15)
        Me.ExportLinkLabel.TabIndex = 7
        Me.ExportLinkLabel.TabStop = True
        Me.ExportLinkLabel.Text = "Export For FR"
        Me.ExportLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ExportLinkLabel.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(377, 7)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(8, 7, 5, 5)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(35, 15)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Copy"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(567, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(150, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search Style No"
        '
        'StyleLookupGridLookUpEdit
        '
        Me.StyleLookupGridLookUpEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StyleLookupGridLookUpEdit.Location = New System.Drawing.Point(657, 5)
        Me.StyleLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.StyleLookupGridLookUpEdit.Name = "StyleLookupGridLookUpEdit"
        Me.StyleLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleLookupGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleLookupGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleLookupGridLookUpEdit.Properties.NullText = ""
        Me.StyleLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleLookupGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.StyleLookupGridLookUpEdit.Size = New System.Drawing.Size(315, 20)
        Me.StyleLookupGridLookUpEdit.TabIndex = 5
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
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
        'StyleNameTextEdit
        '
        Me.StyleNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "StyleName", True))
        Me.StyleNameTextEdit.Location = New System.Drawing.Point(110, 49)
        Me.StyleNameTextEdit.Name = "StyleNameTextEdit"
        Me.StyleNameTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StyleNameTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.StyleNameTextEdit.Size = New System.Drawing.Size(169, 20)
        Me.StyleNameTextEdit.TabIndex = 1
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(23, 271)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print "
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(74, 19)
        Me.IsPrintCheckEdit.TabIndex = 18
        '
        'PrintDetailsTextEdit
        '
        Me.PrintDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "PrintDetails", True))
        Me.PrintDetailsTextEdit.Location = New System.Drawing.Point(103, 299)
        Me.PrintDetailsTextEdit.Name = "PrintDetailsTextEdit"
        Me.PrintDetailsTextEdit.Size = New System.Drawing.Size(422, 20)
        Me.PrintDetailsTextEdit.TabIndex = 19
        '
        'GSMSpinEdit
        '
        Me.GSMSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "GSM", True))
        Me.GSMSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GSMSpinEdit.Location = New System.Drawing.Point(367, 99)
        Me.GSMSpinEdit.Name = "GSMSpinEdit"
        Me.GSMSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GSMSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.GSMSpinEdit.TabIndex = 10
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(104, 460)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(421, 20)
        Me.RemarksTextEdit.TabIndex = 35
        '
        'PrintTypeIdGridLookUpEditView
        '
        Me.PrintTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintTypeId, Me.colPrintTypeName, Me.colRemarks})
        Me.PrintTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PrintTypeIdGridLookUpEditView.Name = "PrintTypeIdGridLookUpEditView"
        Me.PrintTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PrintTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colPrintTypeId
        '
        Me.colPrintTypeId.FieldName = "PrintTypeId"
        Me.colPrintTypeId.Name = "colPrintTypeId"
        Me.colPrintTypeId.OptionsColumn.ReadOnly = True
        '
        'colPrintTypeName
        '
        Me.colPrintTypeName.FieldName = "PrintTypeName"
        Me.colPrintTypeName.Name = "colPrintTypeName"
        Me.colPrintTypeName.Visible = True
        Me.colPrintTypeName.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'PrintTypeIdGridLookUpEdit
        '
        Me.PrintTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "PrintTypeId", True))
        Me.PrintTypeIdGridLookUpEdit.Location = New System.Drawing.Point(163, 272)
        Me.PrintTypeIdGridLookUpEdit.Name = "PrintTypeIdGridLookUpEdit"
        Me.PrintTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintTypeIdGridLookUpEdit.Properties.DataSource = Me.PrintTypeBindingSource
        Me.PrintTypeIdGridLookUpEdit.Properties.DisplayMember = "PrintTypeName"
        Me.PrintTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.PrintTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintTypeIdGridLookUpEdit.Properties.ValueMember = "PrintTypeId"
        Me.PrintTypeIdGridLookUpEdit.Properties.View = Me.PrintTypeIdGridLookUpEditView
        Me.PrintTypeIdGridLookUpEdit.Size = New System.Drawing.Size(133, 20)
        Me.PrintTypeIdGridLookUpEdit.TabIndex = 15
        '
        'PrintTypeBindingSource
        '
        Me.PrintTypeBindingSource.DataMember = "PrintType"
        Me.PrintTypeBindingSource.DataSource = Me.PrintTypeDataSet
        '
        'PrintTypeDataSet
        '
        Me.PrintTypeDataSet.DataSetName = "PrintTypeDataSet"
        Me.PrintTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeIdGridLookUpEditView
        '
        Me.KnittingTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingTypeId, Me.colKnittingType, Me.colDiscontinue1, Me.colKnittingTypeCode})
        Me.KnittingTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.KnittingTypeIdGridLookUpEditView.Name = "KnittingTypeIdGridLookUpEditView"
        Me.KnittingTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.KnittingTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsColumn.ReadOnly = True
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colDiscontinue1
        '
        Me.colDiscontinue1.FieldName = "Discontinue"
        Me.colDiscontinue1.Name = "colDiscontinue1"
        '
        'colKnittingTypeCode
        '
        Me.colKnittingTypeCode.FieldName = "KnittingTypeCode"
        Me.colKnittingTypeCode.Name = "colKnittingTypeCode"
        '
        'KnittingTypeIdGridLookUpEdit
        '
        Me.KnittingTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "KnittingTypeId", True))
        Me.KnittingTypeIdGridLookUpEdit.Location = New System.Drawing.Point(367, 49)
        Me.KnittingTypeIdGridLookUpEdit.Name = "KnittingTypeIdGridLookUpEdit"
        Me.KnittingTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingTypeIdGridLookUpEdit.Properties.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeIdGridLookUpEdit.Properties.DisplayMember = "KnittingType"
        Me.KnittingTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.KnittingTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.KnittingTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KnittingTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingTypeIdGridLookUpEdit.Properties.ValueMember = "KnittingTypeId"
        Me.KnittingTypeIdGridLookUpEdit.Properties.View = Me.KnittingTypeIdGridLookUpEditView
        Me.KnittingTypeIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.KnittingTypeIdGridLookUpEdit.TabIndex = 8
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
        'CompositionIdGridLookUpEditView
        '
        Me.CompositionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompositionId, Me.colComposition, Me.colDiscontinue, Me.colCode})
        Me.CompositionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CompositionIdGridLookUpEditView.Name = "CompositionIdGridLookUpEditView"
        Me.CompositionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CompositionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCompositionId
        '
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colDiscontinue
        '
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        '
        'CompositionIdGridLookUpEdit
        '
        Me.CompositionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "CompositionId", True))
        Me.CompositionIdGridLookUpEdit.Location = New System.Drawing.Point(367, 74)
        Me.CompositionIdGridLookUpEdit.Name = "CompositionIdGridLookUpEdit"
        Me.CompositionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionIdGridLookUpEdit.Properties.DataSource = Me.CompositionBindingSource
        Me.CompositionIdGridLookUpEdit.Properties.DisplayMember = "Composition"
        Me.CompositionIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.CompositionIdGridLookUpEdit.Properties.NullText = ""
        Me.CompositionIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CompositionIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionIdGridLookUpEdit.Properties.ValueMember = "CompositionId"
        Me.CompositionIdGridLookUpEdit.Properties.View = Me.CompositionIdGridLookUpEditView
        Me.CompositionIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.CompositionIdGridLookUpEdit.TabIndex = 9
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
        'StyleNameIdGridLookUpEditView
        '
        Me.StyleNameIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleNameId1, Me.colStyleName1, Me.colStyleNameGroup})
        Me.StyleNameIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleNameIdGridLookUpEditView.Name = "StyleNameIdGridLookUpEditView"
        Me.StyleNameIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleNameIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleNameId1
        '
        Me.colStyleNameId1.FieldName = "StyleNameId"
        Me.colStyleNameId1.Name = "colStyleNameId1"
        Me.colStyleNameId1.OptionsColumn.ReadOnly = True
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 0
        '
        'colStyleNameGroup
        '
        Me.colStyleNameGroup.FieldName = "StyleNameGroup"
        Me.colStyleNameGroup.Name = "colStyleNameGroup"
        '
        'StyleNameIdGridLookUpEdit
        '
        Me.StyleNameIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "StyleNameId", True))
        Me.StyleNameIdGridLookUpEdit.Location = New System.Drawing.Point(110, 75)
        Me.StyleNameIdGridLookUpEdit.Name = "StyleNameIdGridLookUpEdit"
        Me.StyleNameIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleNameIdGridLookUpEdit.Properties.DataSource = Me.StyleNameMstBindingSource
        Me.StyleNameIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleNameIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleNameIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleNameIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleNameIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleNameIdGridLookUpEdit.Properties.ValueMember = "StyleNameId"
        Me.StyleNameIdGridLookUpEdit.Properties.View = Me.StyleNameIdGridLookUpEditView
        Me.StyleNameIdGridLookUpEdit.Size = New System.Drawing.Size(169, 20)
        Me.StyleNameIdGridLookUpEdit.TabIndex = 2
        Me.StyleNameIdGridLookUpEdit.ToolTip = "Type And Press F10 to add in the list"
        '
        'StyleNameMstBindingSource
        '
        Me.StyleNameMstBindingSource.DataMember = "StyleNameMst"
        Me.StyleNameMstBindingSource.DataSource = Me.StyleDataSet
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
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(110, 101)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(169, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 3
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
        'IsEmbroideryCheckEdit
        '
        Me.IsEmbroideryCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit.Location = New System.Drawing.Point(26, 358)
        Me.IsEmbroideryCheckEdit.Name = "IsEmbroideryCheckEdit"
        Me.IsEmbroideryCheckEdit.Properties.Caption = "Embroidery"
        Me.IsEmbroideryCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsEmbroideryCheckEdit.TabIndex = 21
        '
        'IsAOPCheckEdit
        '
        Me.IsAOPCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsAOP", True))
        Me.IsAOPCheckEdit.Location = New System.Drawing.Point(108, 358)
        Me.IsAOPCheckEdit.Name = "IsAOPCheckEdit"
        Me.IsAOPCheckEdit.Properties.Caption = "AOP"
        Me.IsAOPCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsAOPCheckEdit.TabIndex = 22
        '
        'IsYDSCheckEdit
        '
        Me.IsYDSCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsYDS", True))
        Me.IsYDSCheckEdit.Location = New System.Drawing.Point(294, 175)
        Me.IsYDSCheckEdit.Name = "IsYDSCheckEdit"
        Me.IsYDSCheckEdit.Properties.Caption = "YD/YDS"
        Me.IsYDSCheckEdit.Size = New System.Drawing.Size(70, 19)
        Me.IsYDSCheckEdit.TabIndex = 23
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.FabricForSizeTableAdapter = Nothing
        Me.TableAdapterManager1.FabricTableAdapter = Nothing
        Me.TableAdapterManager1.FinishingProcessTableAdapter = Nothing
        Me.TableAdapterManager1.FROrderProcessTableAdapter = Nothing
        Me.TableAdapterManager1.OrderActivitiesPredecessorTableAdapter = Nothing
        Me.TableAdapterManager1.OrderActivitiesTableAdapter = Nothing
        Me.TableAdapterManager1.OrderAmndDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.OrderCPTableAdapter = Nothing
        Me.TableAdapterManager1.OrderCuttingPercentageTableAdapter = Nothing
        Me.TableAdapterManager1.OrderDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.OrderGarmentsPartTableAdapter = Nothing
        Me.TableAdapterManager1.OrderInstructionTableAdapter = Nothing
        Me.TableAdapterManager1.OrderPictureTableAdapter = Nothing
        Me.TableAdapterManager1.OrderSizeDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.OrderTableAdapter = Nothing
        Me.TableAdapterManager1.OrderTrimTableAdapter = Nothing
        Me.TableAdapterManager1.TwinPackDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(691, 5)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(293, 25)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52439!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47561!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 366.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PrintDetailsLinkLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TrimDetailsLinkLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FabricDetailsLinkLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OKButton, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 499)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1026, 35)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PrintDetailsLinkLabel
        '
        Me.PrintDetailsLinkLabel.AutoSize = True
        Me.PrintDetailsLinkLabel.Enabled = False
        Me.PrintDetailsLinkLabel.Location = New System.Drawing.Point(306, 10)
        Me.PrintDetailsLinkLabel.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.PrintDetailsLinkLabel.Name = "PrintDetailsLinkLabel"
        Me.PrintDetailsLinkLabel.Size = New System.Drawing.Size(90, 13)
        Me.PrintDetailsLinkLabel.TabIndex = 31
        Me.PrintDetailsLinkLabel.TabStop = True
        Me.PrintDetailsLinkLabel.Text = "More Print Details"
        '
        'TrimDetailsLinkLabel
        '
        Me.TrimDetailsLinkLabel.AutoSize = True
        Me.TrimDetailsLinkLabel.Location = New System.Drawing.Point(160, 10)
        Me.TrimDetailsLinkLabel.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.TrimDetailsLinkLabel.Name = "TrimDetailsLinkLabel"
        Me.TrimDetailsLinkLabel.Size = New System.Drawing.Size(89, 13)
        Me.TrimDetailsLinkLabel.TabIndex = 30
        Me.TrimDetailsLinkLabel.TabStop = True
        Me.TrimDetailsLinkLabel.Text = "More Trim Details"
        '
        'FabricDetailsLinkLabel
        '
        Me.FabricDetailsLinkLabel.AutoSize = True
        Me.FabricDetailsLinkLabel.Location = New System.Drawing.Point(5, 10)
        Me.FabricDetailsLinkLabel.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.FabricDetailsLinkLabel.Name = "FabricDetailsLinkLabel"
        Me.FabricDetailsLinkLabel.Size = New System.Drawing.Size(98, 13)
        Me.FabricDetailsLinkLabel.TabIndex = 29
        Me.FabricDetailsLinkLabel.TabStop = True
        Me.FabricDetailsLinkLabel.Text = "More Fabric Details"
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1026, 534)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Gray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 27
        Me.LineShape2.X2 = 523
        Me.LineShape2.Y1 = 348
        Me.LineShape2.Y2 = 348
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 28
        Me.LineShape1.X2 = 524
        Me.LineShape1.Y1 = 261
        Me.LineShape1.Y2 = 261
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'PrintPartIdGridLookUpEditView
        '
        Me.PrintPartIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintPartId, Me.colPartName})
        Me.PrintPartIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PrintPartIdGridLookUpEditView.Name = "PrintPartIdGridLookUpEditView"
        Me.PrintPartIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PrintPartIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colPrintPartId
        '
        Me.colPrintPartId.FieldName = "PrintPartId"
        Me.colPrintPartId.Name = "colPrintPartId"
        Me.colPrintPartId.OptionsColumn.ReadOnly = True
        '
        'colPartName
        '
        Me.colPartName.FieldName = "PartName"
        Me.colPartName.Name = "colPartName"
        Me.colPartName.Visible = True
        Me.colPartName.VisibleIndex = 0
        '
        'PrintPartIdGridLookUpEdit
        '
        Me.PrintPartIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "PrintPartId", True))
        Me.PrintPartIdGridLookUpEdit.Location = New System.Drawing.Point(368, 272)
        Me.PrintPartIdGridLookUpEdit.Name = "PrintPartIdGridLookUpEdit"
        Me.PrintPartIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPartIdGridLookUpEdit.Properties.DataSource = Me.PrintPartBindingSource
        Me.PrintPartIdGridLookUpEdit.Properties.DisplayMember = "PartName"
        Me.PrintPartIdGridLookUpEdit.Properties.NullText = ""
        Me.PrintPartIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintPartIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintPartIdGridLookUpEdit.Properties.ValueMember = "PrintPartId"
        Me.PrintPartIdGridLookUpEdit.Properties.View = Me.PrintPartIdGridLookUpEditView
        Me.PrintPartIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.PrintPartIdGridLookUpEdit.TabIndex = 17
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
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'MergeButton
        '
        Me.MergeButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MergeButton.Location = New System.Drawing.Point(6, 385)
        Me.MergeButton.Name = "MergeButton"
        Me.MergeButton.Size = New System.Drawing.Size(452, 23)
        Me.MergeButton.TabIndex = 29
        Me.MergeButton.Text = "Merge From 2 Picture"
        Me.MergeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(152, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Take Picture"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(23, 78)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Style Name"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(542, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 445)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.PicturePictureEdit)
        Me.TabPage1.Controls.Add(Me.MergeButton)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(464, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Picture"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(6, 6)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PicturePictureEdit.Size = New System.Drawing.Size(452, 367)
        Me.PicturePictureEdit.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.LinkLabel2)
        Me.TabPage2.Controls.Add(Me.FRStyleProcessDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(73, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Get Operation"
        '
        'FRStyleProcessDataGridView
        '
        Me.FRStyleProcessDataGridView.AutoGenerateColumns = False
        Me.FRStyleProcessDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FRStyleProcessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FRStyleProcessDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Factor, Me.DataGridViewTextBoxColumn4})
        Me.FRStyleProcessDataGridView.DataSource = Me.FRStyleProcessBindingSource
        Me.FRStyleProcessDataGridView.Location = New System.Drawing.Point(3, 24)
        Me.FRStyleProcessDataGridView.Name = "FRStyleProcessDataGridView"
        Me.FRStyleProcessDataGridView.Size = New System.Drawing.Size(458, 354)
        Me.FRStyleProcessDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FRProcessId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.FRProcessBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "FRProcessName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "FR Process"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "FRProcessId"
        '
        'FRProcessBindingSource
        '
        Me.FRProcessBindingSource.DataMember = "FRProcess"
        Me.FRProcessBindingSource.DataSource = Me.FRProcessDataSet
        '
        'FRProcessDataSet
        '
        Me.FRProcessDataSet.DataSetName = "FRProcessDataSet"
        Me.FRProcessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Factor
        '
        Me.Factor.DataPropertyName = "Factor"
        Me.Factor.HeaderText = "Factor"
        Me.Factor.Name = "Factor"
        Me.Factor.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SMV"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SMV"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'FRStyleProcessBindingSource
        '
        Me.FRStyleProcessBindingSource.DataMember = "FK_FRStyleProcess_Style"
        Me.FRStyleProcessBindingSource.DataSource = Me.StyleBindingSource
        '
        'StyleTypeComboBox
        '
        Me.StyleTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StyleBindingSource, "StyleType", True))
        Me.StyleTypeComboBox.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeComboBox.DisplayMember = "StyleType"
        Me.StyleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StyleTypeComboBox.FormattingEnabled = True
        Me.StyleTypeComboBox.Location = New System.Drawing.Point(368, 150)
        Me.StyleTypeComboBox.Name = "StyleTypeComboBox"
        Me.StyleTypeComboBox.Size = New System.Drawing.Size(156, 21)
        Me.StyleTypeComboBox.TabIndex = 13
        Me.StyleTypeComboBox.ValueMember = "StyleType"
        '
        'StyleTypeMstBindingSource
        '
        Me.StyleTypeMstBindingSource.DataMember = "StyleTypeMst"
        Me.StyleTypeMstBindingSource.DataSource = Me.StyleTypeDataSet
        '
        'StyleTypeDataSet
        '
        Me.StyleTypeDataSet.DataSetName = "StyleTypeDataSet"
        Me.StyleTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FRStyleProcessTableAdapter = Me.FRStyleProcessTableAdapter
        Me.TableAdapterManager.StyleNameMstTableAdapter = Me.StyleNameMstTableAdapter
        Me.TableAdapterManager.StyleTableAdapter = Me.StyleTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FRStyleProcessTableAdapter
        '
        Me.FRStyleProcessTableAdapter.ClearBeforeFill = True
        '
        'StyleNameMstTableAdapter
        '
        Me.StyleNameMstTableAdapter.ClearBeforeFill = True
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'FRProcessTableAdapter
        '
        Me.FRProcessTableAdapter.ClearBeforeFill = True
        '
        'DivisionIdGridLookUpEditView
        '
        Me.DivisionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName})
        Me.DivisionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DivisionIdGridLookUpEditView.Name = "DivisionIdGridLookUpEditView"
        Me.DivisionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DivisionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "DivisionId", True))
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(110, 151)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Properties.View = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(168, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 5
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DivisionLookupByBuyerBindingSource
        '
        Me.DivisionLookupByBuyerBindingSource.DataMember = "DivisionLookupByBuyer"
        Me.DivisionLookupByBuyerBindingSource.DataSource = Me.DivisionLookupByBuyerDataSet
        '
        'DivisionLookupByBuyerDataSet
        '
        Me.DivisionLookupByBuyerDataSet.DataSetName = "DivisionLookupByBuyerDataSet"
        Me.DivisionLookupByBuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiaSpinEdit
        '
        Me.DiaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Dia", True))
        Me.DiaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiaSpinEdit.Location = New System.Drawing.Point(464, 99)
        Me.DiaSpinEdit.Name = "DiaSpinEdit"
        Me.DiaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DiaSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.DiaSpinEdit.TabIndex = 11
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'IsWashCheckEdit
        '
        Me.IsWashCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsWash", True))
        Me.IsWashCheckEdit.Location = New System.Drawing.Point(383, 360)
        Me.IsWashCheckEdit.Name = "IsWashCheckEdit"
        Me.IsWashCheckEdit.Properties.Caption = "Wash"
        Me.IsWashCheckEdit.Size = New System.Drawing.Size(56, 19)
        Me.IsWashCheckEdit.TabIndex = 26
        '
        'WashTypeIdGridLookUpEditView
        '
        Me.WashTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashType1})
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colWashType1
        '
        Me.colWashType1.FieldName = "WashType"
        Me.colWashType1.Name = "colWashType1"
        Me.colWashType1.Visible = True
        Me.colWashType1.VisibleIndex = 0
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(435, 360)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.WashTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Properties.View = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(89, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 27
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
        'DefaultTargetTextBox
        '
        Me.DefaultTargetTextBox.BackColor = System.Drawing.Color.Yellow
        Me.DefaultTargetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StyleBindingSource, "DefaultTarget", True))
        Me.DefaultTargetTextBox.Location = New System.Drawing.Point(227, 430)
        Me.DefaultTargetTextBox.Name = "DefaultTargetTextBox"
        Me.DefaultTargetTextBox.Size = New System.Drawing.Size(68, 20)
        Me.DefaultTargetTextBox.TabIndex = 32
        '
        'SMVTextBox
        '
        Me.SMVTextBox.BackColor = System.Drawing.Color.Yellow
        Me.SMVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StyleBindingSource, "SMV", True))
        Me.SMVTextBox.Location = New System.Drawing.Point(104, 430)
        Me.SMVTextBox.Name = "SMVTextBox"
        Me.SMVTextBox.Size = New System.Drawing.Size(61, 20)
        Me.SMVTextBox.TabIndex = 31
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'colWashType
        '
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.Visible = True
        Me.colWashType.VisibleIndex = 0
        '
        'GMDescriptionMemoEdit
        '
        Me.GMDescriptionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "GMDescription", True))
        Me.GMDescriptionMemoEdit.Location = New System.Drawing.Point(110, 201)
        Me.GMDescriptionMemoEdit.Name = "GMDescriptionMemoEdit"
        Me.GMDescriptionMemoEdit.Size = New System.Drawing.Size(413, 52)
        Me.GMDescriptionMemoEdit.TabIndex = 7
        '
        'DivisionLookupByBuyerTableAdapter
        '
        Me.DivisionLookupByBuyerTableAdapter.ClearBeforeFill = True
        '
        'IsBrushCheckEdit
        '
        Me.IsBrushCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsBrush", True))
        Me.IsBrushCheckEdit.Location = New System.Drawing.Point(161, 358)
        Me.IsBrushCheckEdit.Name = "IsBrushCheckEdit"
        Me.IsBrushCheckEdit.Properties.Caption = "Brush"
        Me.IsBrushCheckEdit.Size = New System.Drawing.Size(64, 19)
        Me.IsBrushCheckEdit.TabIndex = 24
        '
        'IsPeachFinishCheckEdit
        '
        Me.IsPeachFinishCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsPeachFinish", True))
        Me.IsPeachFinishCheckEdit.Location = New System.Drawing.Point(298, 359)
        Me.IsPeachFinishCheckEdit.Name = "IsPeachFinishCheckEdit"
        Me.IsPeachFinishCheckEdit.Properties.Caption = "Peach Finish"
        Me.IsPeachFinishCheckEdit.Size = New System.Drawing.Size(79, 19)
        Me.IsPeachFinishCheckEdit.TabIndex = 25
        '
        'PrintTypeLinkLabel
        '
        Me.PrintTypeLinkLabel.AutoSize = True
        Me.PrintTypeLinkLabel.Location = New System.Drawing.Point(100, 273)
        Me.PrintTypeLinkLabel.Name = "PrintTypeLinkLabel"
        Me.PrintTypeLinkLabel.Size = New System.Drawing.Size(55, 13)
        Me.PrintTypeLinkLabel.TabIndex = 14
        Me.PrintTypeLinkLabel.TabStop = True
        Me.PrintTypeLinkLabel.Text = "Print Type"
        '
        'PrintPartLinkLabel
        '
        Me.PrintPartLinkLabel.AutoSize = True
        Me.PrintPartLinkLabel.Location = New System.Drawing.Point(302, 275)
        Me.PrintPartLinkLabel.Name = "PrintPartLinkLabel"
        Me.PrintPartLinkLabel.Size = New System.Drawing.Size(50, 13)
        Me.PrintPartLinkLabel.TabIndex = 16
        Me.PrintPartLinkLabel.TabStop = True
        Me.PrintPartLinkLabel.Text = "Print Part"
        '
        'GMTBrandBindingSource
        '
        Me.GMTBrandBindingSource.DataMember = "GMTBrand"
        Me.GMTBrandBindingSource.DataSource = Me.GMTBrandDataSet
        '
        'GMTBrandDataSet
        '
        Me.GMTBrandDataSet.DataSetName = "GMTBrandDataSet"
        Me.GMTBrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'GMTBrandIdGridLookUpEditView
        '
        Me.GMTBrandIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName})
        Me.GMTBrandIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMTBrandIdGridLookUpEditView.Name = "GMTBrandIdGridLookUpEditView"
        Me.GMTBrandIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMTBrandIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'GMTBrandIdGridLookUpEdit
        '
        Me.GMTBrandIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "GMTBrandId", True))
        Me.GMTBrandIdGridLookUpEdit.Location = New System.Drawing.Point(110, 127)
        Me.GMTBrandIdGridLookUpEdit.Name = "GMTBrandIdGridLookUpEdit"
        Me.GMTBrandIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMTBrandIdGridLookUpEdit.Properties.DataSource = Me.GMTBrandBindingSource
        Me.GMTBrandIdGridLookUpEdit.Properties.DisplayMember = "GMTBrandName"
        Me.GMTBrandIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GMTBrandIdGridLookUpEdit.Properties.NullText = ""
        Me.GMTBrandIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GMTBrandIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMTBrandIdGridLookUpEdit.Properties.ValueMember = "GMTBrandId"
        Me.GMTBrandIdGridLookUpEdit.Properties.View = Me.GMTBrandIdGridLookUpEditView
        Me.GMTBrandIdGridLookUpEdit.Size = New System.Drawing.Size(168, 20)
        Me.GMTBrandIdGridLookUpEdit.TabIndex = 4
        '
        'GaugeTextEdit
        '
        Me.GaugeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Gauge", True))
        Me.GaugeTextEdit.Location = New System.Drawing.Point(367, 124)
        Me.GaugeTextEdit.Name = "GaugeTextEdit"
        Me.GaugeTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.GaugeTextEdit.TabIndex = 12
        '
        'SeasonIdGridLookUpEditView
        '
        Me.SeasonIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeasonName})
        Me.SeasonIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SeasonIdGridLookUpEditView.Name = "SeasonIdGridLookUpEditView"
        Me.SeasonIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SeasonIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSeasonName
        '
        Me.colSeasonName.FieldName = "SeasonName"
        Me.colSeasonName.Name = "colSeasonName"
        Me.colSeasonName.Visible = True
        Me.colSeasonName.VisibleIndex = 0
        '
        'SeasonIdGridLookUpEdit
        '
        Me.SeasonIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "SeasonId", True))
        Me.SeasonIdGridLookUpEdit.Location = New System.Drawing.Point(110, 176)
        Me.SeasonIdGridLookUpEdit.Name = "SeasonIdGridLookUpEdit"
        Me.SeasonIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonIdGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonIdGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SeasonIdGridLookUpEdit.Properties.NullText = ""
        Me.SeasonIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SeasonIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SeasonIdGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonIdGridLookUpEdit.Properties.View = Me.SeasonIdGridLookUpEditView
        Me.SeasonIdGridLookUpEdit.Size = New System.Drawing.Size(168, 20)
        Me.SeasonIdGridLookUpEdit.TabIndex = 6
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'EmbDetailsTextEdit
        '
        Me.EmbDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "EmbDetails", True))
        Me.EmbDetailsTextEdit.Location = New System.Drawing.Point(103, 384)
        Me.EmbDetailsTextEdit.Name = "EmbDetailsTextEdit"
        Me.EmbDetailsTextEdit.Size = New System.Drawing.Size(420, 20)
        Me.EmbDetailsTextEdit.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StyleBindingSource, "CostingCM", True))
        Me.TextBox1.Location = New System.Drawing.Point(335, 430)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 33
        '
        'MCQtyTextBox
        '
        Me.MCQtyTextBox.BackColor = System.Drawing.Color.Yellow
        Me.MCQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StyleBindingSource, "MCQty", True))
        Me.MCQtyTextBox.Location = New System.Drawing.Point(446, 429)
        Me.MCQtyTextBox.Name = "MCQtyTextBox"
        Me.MCQtyTextBox.Size = New System.Drawing.Size(78, 20)
        Me.MCQtyTextBox.TabIndex = 34
        '
        'SublimationCheckEdit
        '
        Me.SublimationCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsSublimation", True))
        Me.SublimationCheckEdit.Location = New System.Drawing.Point(103, 324)
        Me.SublimationCheckEdit.Name = "SublimationCheckEdit"
        Me.SublimationCheckEdit.Properties.Caption = "Sublimation"
        Me.SublimationCheckEdit.Size = New System.Drawing.Size(74, 19)
        Me.SublimationCheckEdit.TabIndex = 20
        '
        'SequenceCheckEdit
        '
        Me.SequenceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsSequence", True))
        Me.SequenceCheckEdit.Location = New System.Drawing.Point(103, 407)
        Me.SequenceCheckEdit.Name = "SequenceCheckEdit"
        Me.SequenceCheckEdit.Properties.Caption = "Sequence"
        Me.SequenceCheckEdit.Size = New System.Drawing.Size(74, 19)
        Me.SequenceCheckEdit.TabIndex = 29
        '
        'ForeignCheckEdit
        '
        Me.ForeignCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "IsSpecialYarn", True))
        Me.ForeignCheckEdit.Location = New System.Drawing.Point(195, 407)
        Me.ForeignCheckEdit.Name = "ForeignCheckEdit"
        Me.ForeignCheckEdit.Properties.Caption = "Foreign Yarn"
        Me.ForeignCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.ForeignCheckEdit.TabIndex = 30
        '
        'YarnDyeingTypeGridLookUpEdit
        '
        Me.YarnDyeingTypeGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "YarnDyeingTypeId", True))
        Me.YarnDyeingTypeGridLookUpEdit.Location = New System.Drawing.Point(368, 174)
        Me.YarnDyeingTypeGridLookUpEdit.Name = "YarnDyeingTypeGridLookUpEdit"
        Me.YarnDyeingTypeGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnDyeingTypeGridLookUpEdit.Properties.ImmediatePopup = True
        Me.YarnDyeingTypeGridLookUpEdit.Properties.NullText = ""
        Me.YarnDyeingTypeGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnDyeingTypeGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnDyeingTypeGridLookUpEdit.Properties.View = Me.YarnDyeingTypeGridView
        Me.YarnDyeingTypeGridLookUpEdit.Size = New System.Drawing.Size(155, 20)
        Me.YarnDyeingTypeGridLookUpEdit.TabIndex = 6
        '
        'YarnDyeingTypeGridView
        '
        Me.YarnDyeingTypeGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnDyeingTypeGridView.Name = "YarnDyeingTypeGridView"
        Me.YarnDyeingTypeGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnDyeingTypeGridView.OptionsView.ShowGroupPanel = False
        '
        'frmStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1026, 534)
        Me.Controls.Add(Me.YarnDyeingTypeGridLookUpEdit)
        Me.Controls.Add(Me.ForeignCheckEdit)
        Me.Controls.Add(Me.SequenceCheckEdit)
        Me.Controls.Add(Me.SublimationCheckEdit)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.MCQtyTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label4)
        Me.Controls.Add(EmbDetailsLabel)
        Me.Controls.Add(Me.EmbDetailsTextEdit)
        Me.Controls.Add(SeasonIdLabel)
        Me.Controls.Add(Me.SeasonIdGridLookUpEdit)
        Me.Controls.Add(GaugeLabel)
        Me.Controls.Add(Me.GaugeTextEdit)
        Me.Controls.Add(Me.GMTBrandIdGridLookUpEdit)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.IsPeachFinishCheckEdit)
        Me.Controls.Add(Me.IsBrushCheckEdit)
        Me.Controls.Add(GMDescriptionLabel)
        Me.Controls.Add(Me.GMDescriptionMemoEdit)
        Me.Controls.Add(Label3)
        Me.Controls.Add(SMVLabel)
        Me.Controls.Add(Me.SMVTextBox)
        Me.Controls.Add(DefaultTargetLabel)
        Me.Controls.Add(Me.DefaultTargetTextBox)
        Me.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.IsWashCheckEdit)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.DiaSpinEdit)
        Me.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.Controls.Add(StyleTypeLabel1)
        Me.Controls.Add(Me.StyleTypeComboBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PrintPartLinkLabel)
        Me.Controls.Add(Me.PrintTypeLinkLabel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PrintPartIdGridLookUpEdit)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.IsYDSCheckEdit)
        Me.Controls.Add(Me.IsAOPCheckEdit)
        Me.Controls.Add(Me.IsEmbroideryCheckEdit)
        Me.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.Controls.Add(Me.StyleNameIdGridLookUpEdit)
        Me.Controls.Add(CompositionIdLabel1)
        Me.Controls.Add(Me.CompositionIdGridLookUpEdit)
        Me.Controls.Add(KnittingTypeIdLabel1)
        Me.Controls.Add(Me.KnittingTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.PrintTypeIdGridLookUpEdit)
        Me.Controls.Add(StyleNameLabel)
        Me.Controls.Add(Me.StyleNameTextEdit)
        Me.Controls.Add(BuyerIdLabel)
        Me.Controls.Add(Me.IsPrintCheckEdit)
        Me.Controls.Add(PrintDetailsLabel)
        Me.Controls.Add(Me.PrintDetailsTextEdit)
        Me.Controls.Add(GSMLabel)
        Me.Controls.Add(Me.GSMSpinEdit)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextEdit)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStyle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Style Master"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PrintPartIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.FRStyleProcessDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRStyleProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionLookupByBuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionLookupByBuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaugeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForeignCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents StyleNameMstTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter
    Friend WithEvents StyleNameMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GSMSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents KnittingTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnittingTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CompositionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompositionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleNameIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleNameIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents IsEmbroideryCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsAOPCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsYDSCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colPrintTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNameId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNameGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PrintPartIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintPartIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintPartId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricDetailsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TrimDetailsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintDetailsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents MergeButton As System.Windows.Forms.Button
    Friend WithEvents Openfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RefreshLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ExportLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FRStyleProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FRStyleProcessTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.FRStyleProcessTableAdapter
    Friend WithEvents FRStyleProcessDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StyleTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StyleTypeDataSet As KSoft_Apparel.StyleTypeDataSet
    Friend WithEvents StyleTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTypeMstTableAdapter As KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents FRProcessDataSet As KSoft_Apparel.FRProcessDataSet
    Friend WithEvents FRProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FRProcessTableAdapter As KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Factor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DivisionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DiaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents IsWashCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DefaultTargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SMVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DivisionLookupByBuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionLookupByBuyerDataSet As KSoft_Apparel.DivisionLookupByBuyerDataSet
    Friend WithEvents DivisionLookupByBuyerTableAdapter As KSoft_Apparel.DivisionLookupByBuyerDataSetTableAdapters.DivisionLookupByBuyerTableAdapter
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsBrushCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsPeachFinishCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintTypeLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintPartLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colWashType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandDataSet As KSoft_Apparel.GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMTBrandTableAdapter As KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents GMTBrandIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GaugeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeasonIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeasonIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MCQtyTextBox As TextBox
    Friend WithEvents SublimationCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SequenceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ForeignCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents YarnDyeingTypeGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnDyeingTypeGridView As DevExpress.XtraGrid.Views.Grid.GridView
End Class
