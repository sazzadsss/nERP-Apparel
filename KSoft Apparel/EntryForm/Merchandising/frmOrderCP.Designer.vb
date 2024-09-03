<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderCP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderCP))
        Me.OrderCPDataSet = New KSoft_Apparel.OrderCPDataSet
        Me.OrderCPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderCPTableAdapter = New KSoft_Apparel.OrderCPDataSetTableAdapters.OrderCPTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.OrderCPDataSetTableAdapters.TableAdapterManager
        Me.OrderCPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OrderCPBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OrderCPGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderCPId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricBookingDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricRequireDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricReceiveQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTestCuttingDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintStartDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmbroideryStartDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmbroideryCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSewingStartDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSewingCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colShippedOn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colShippedQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompleted = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.SewingStartDateLabel = New System.Windows.Forms.Label
        Me.PrintStartDateLabel = New System.Windows.Forms.Label
        Me.OrderStatusGroupBox = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ShipmentQuantityLabel = New System.Windows.Forms.Label
        Me.ShipmentDateLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.OrderCPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderCPBindingNavigator.SuspendLayout()
        CType(Me.OrderCPGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderStatusGroupBox.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderCPDataSet
        '
        Me.OrderCPDataSet.DataSetName = "OrderCPDataSet"
        Me.OrderCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderCPBindingSource
        '
        Me.OrderCPBindingSource.DataMember = "OrderCP"
        Me.OrderCPBindingSource.DataSource = Me.OrderCPDataSet
        '
        'OrderCPTableAdapter
        '
        Me.OrderCPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderCPTableAdapter = Me.OrderCPTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderCPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderCPBindingNavigator
        '
        Me.OrderCPBindingNavigator.AddNewItem = Nothing
        Me.OrderCPBindingNavigator.BindingSource = Me.OrderCPBindingSource
        Me.OrderCPBindingNavigator.CountItem = Nothing
        Me.OrderCPBindingNavigator.DeleteItem = Nothing
        Me.OrderCPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderCPBindingNavigatorSaveItem})
        Me.OrderCPBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrderCPBindingNavigator.MoveFirstItem = Nothing
        Me.OrderCPBindingNavigator.MoveLastItem = Nothing
        Me.OrderCPBindingNavigator.MoveNextItem = Nothing
        Me.OrderCPBindingNavigator.MovePreviousItem = Nothing
        Me.OrderCPBindingNavigator.Name = "OrderCPBindingNavigator"
        Me.OrderCPBindingNavigator.PositionItem = Nothing
        Me.OrderCPBindingNavigator.Size = New System.Drawing.Size(1012, 25)
        Me.OrderCPBindingNavigator.TabIndex = 0
        Me.OrderCPBindingNavigator.Text = "BindingNavigator1"
        '
        'OrderCPBindingNavigatorSaveItem
        '
        Me.OrderCPBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrderCPBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrderCPBindingNavigatorSaveItem.Name = "OrderCPBindingNavigatorSaveItem"
        Me.OrderCPBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.OrderCPBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OrderCPGridControl
        '
        Me.OrderCPGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderCPGridControl.DataSource = Me.OrderCPBindingSource
        Me.OrderCPGridControl.Location = New System.Drawing.Point(0, 28)
        Me.OrderCPGridControl.LookAndFeel.SkinName = "Money Twins"
        Me.OrderCPGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OrderCPGridControl.MainView = Me.GridView1
        Me.OrderCPGridControl.Name = "OrderCPGridControl"
        Me.OrderCPGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.OrderCPGridControl.Size = New System.Drawing.Size(1012, 367)
        Me.OrderCPGridControl.TabIndex = 1
        Me.OrderCPGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderCPId, Me.colOrderId, Me.colOrderDate, Me.colExDate, Me.colOrderQuantity, Me.colFabricBookingDate, Me.colFabricBookingQuantity, Me.colFabricRequireDate, Me.colFabricReceiveDate, Me.colFabricReceiveQuantity, Me.colTestCuttingDate, Me.colPrintStartDate, Me.colPrintCompleteDate, Me.colEmbroideryStartDate, Me.colEmbroideryCompleteDate, Me.colSewingStartDate, Me.colSewingCompleteDate, Me.colShippedOn, Me.colShippedQuantity, Me.colRemarks, Me.colDiscontinue, Me.colCompleted})
        Me.GridView1.GridControl = Me.OrderCPGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCompleted, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOrderCPId
        '
        Me.colOrderCPId.FieldName = "OrderCPId"
        Me.colOrderCPId.Name = "colOrderCPId"
        Me.colOrderCPId.OptionsColumn.ReadOnly = True
        '
        'colOrderId
        '
        Me.colOrderId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colOrderId.AppearanceCell.Options.UseBackColor = True
        Me.colOrderId.Caption = "Order"
        Me.colOrderId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colOrderId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        Me.colOrderId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colOrderId.Visible = True
        Me.colOrderId.VisibleIndex = 0
        Me.colOrderId.Width = 97
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.OrderLookupBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "ProgramNo"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "OrderId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderDate
        '
        Me.colOrderDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colOrderDate.AppearanceCell.Options.UseBackColor = True
        Me.colOrderDate.Caption = "Or. Date"
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.OptionsColumn.ReadOnly = True
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        '
        'colExDate
        '
        Me.colExDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colExDate.AppearanceCell.Options.UseBackColor = True
        Me.colExDate.FieldName = "ExDate"
        Me.colExDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colExDate.Name = "colExDate"
        Me.colExDate.OptionsColumn.ReadOnly = True
        Me.colExDate.Visible = True
        Me.colExDate.VisibleIndex = 2
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colOrderQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colOrderQuantity.Caption = "Or. Qty."
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 3
        Me.colOrderQuantity.Width = 85
        '
        'colFabricBookingDate
        '
        Me.colFabricBookingDate.Caption = "Fab. Booking Date"
        Me.colFabricBookingDate.FieldName = "FabricBookingDate"
        Me.colFabricBookingDate.Name = "colFabricBookingDate"
        Me.colFabricBookingDate.Visible = True
        Me.colFabricBookingDate.VisibleIndex = 4
        Me.colFabricBookingDate.Width = 120
        '
        'colFabricBookingQuantity
        '
        Me.colFabricBookingQuantity.Caption = "Fab. Booking Qty"
        Me.colFabricBookingQuantity.FieldName = "FabricBookingQuantity"
        Me.colFabricBookingQuantity.Name = "colFabricBookingQuantity"
        Me.colFabricBookingQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colFabricBookingQuantity.Visible = True
        Me.colFabricBookingQuantity.VisibleIndex = 5
        Me.colFabricBookingQuantity.Width = 143
        '
        'colFabricRequireDate
        '
        Me.colFabricRequireDate.Caption = "Fab Req. Date"
        Me.colFabricRequireDate.FieldName = "FabricRequireDate"
        Me.colFabricRequireDate.Name = "colFabricRequireDate"
        Me.colFabricRequireDate.Visible = True
        Me.colFabricRequireDate.VisibleIndex = 6
        Me.colFabricRequireDate.Width = 116
        '
        'colFabricReceiveDate
        '
        Me.colFabricReceiveDate.Caption = "Fabric Rcv Date"
        Me.colFabricReceiveDate.FieldName = "FabricReceiveDate"
        Me.colFabricReceiveDate.Name = "colFabricReceiveDate"
        Me.colFabricReceiveDate.Visible = True
        Me.colFabricReceiveDate.VisibleIndex = 7
        Me.colFabricReceiveDate.Width = 120
        '
        'colFabricReceiveQuantity
        '
        Me.colFabricReceiveQuantity.Caption = "Fab. Rcv. Qty"
        Me.colFabricReceiveQuantity.FieldName = "FabricReceiveQuantity"
        Me.colFabricReceiveQuantity.Name = "colFabricReceiveQuantity"
        Me.colFabricReceiveQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colFabricReceiveQuantity.Visible = True
        Me.colFabricReceiveQuantity.VisibleIndex = 8
        Me.colFabricReceiveQuantity.Width = 97
        '
        'colTestCuttingDate
        '
        Me.colTestCuttingDate.FieldName = "TestCuttingDate"
        Me.colTestCuttingDate.Name = "colTestCuttingDate"
        Me.colTestCuttingDate.Visible = True
        Me.colTestCuttingDate.VisibleIndex = 9
        Me.colTestCuttingDate.Width = 118
        '
        'colPrintStartDate
        '
        Me.colPrintStartDate.FieldName = "PrintStartDate"
        Me.colPrintStartDate.Name = "colPrintStartDate"
        Me.colPrintStartDate.Visible = True
        Me.colPrintStartDate.VisibleIndex = 10
        Me.colPrintStartDate.Width = 115
        '
        'colPrintCompleteDate
        '
        Me.colPrintCompleteDate.FieldName = "PrintCompleteDate"
        Me.colPrintCompleteDate.Name = "colPrintCompleteDate"
        Me.colPrintCompleteDate.Visible = True
        Me.colPrintCompleteDate.VisibleIndex = 11
        Me.colPrintCompleteDate.Width = 121
        '
        'colEmbroideryStartDate
        '
        Me.colEmbroideryStartDate.Caption = "Emb. Start Date"
        Me.colEmbroideryStartDate.FieldName = "EmbroideryStartDate"
        Me.colEmbroideryStartDate.Name = "colEmbroideryStartDate"
        Me.colEmbroideryStartDate.Visible = True
        Me.colEmbroideryStartDate.VisibleIndex = 12
        Me.colEmbroideryStartDate.Width = 100
        '
        'colEmbroideryCompleteDate
        '
        Me.colEmbroideryCompleteDate.Caption = "Emb. Complete Date"
        Me.colEmbroideryCompleteDate.FieldName = "EmbroideryCompleteDate"
        Me.colEmbroideryCompleteDate.Name = "colEmbroideryCompleteDate"
        Me.colEmbroideryCompleteDate.Visible = True
        Me.colEmbroideryCompleteDate.VisibleIndex = 13
        Me.colEmbroideryCompleteDate.Width = 125
        '
        'colSewingStartDate
        '
        Me.colSewingStartDate.FieldName = "SewingStartDate"
        Me.colSewingStartDate.Name = "colSewingStartDate"
        Me.colSewingStartDate.Visible = True
        Me.colSewingStartDate.VisibleIndex = 14
        Me.colSewingStartDate.Width = 132
        '
        'colSewingCompleteDate
        '
        Me.colSewingCompleteDate.FieldName = "SewingCompleteDate"
        Me.colSewingCompleteDate.Name = "colSewingCompleteDate"
        Me.colSewingCompleteDate.Visible = True
        Me.colSewingCompleteDate.VisibleIndex = 15
        Me.colSewingCompleteDate.Width = 135
        '
        'colShippedOn
        '
        Me.colShippedOn.FieldName = "ShippedOn"
        Me.colShippedOn.Name = "colShippedOn"
        Me.colShippedOn.Visible = True
        Me.colShippedOn.VisibleIndex = 16
        Me.colShippedOn.Width = 112
        '
        'colShippedQuantity
        '
        Me.colShippedQuantity.Caption = "Shipped Qty."
        Me.colShippedQuantity.FieldName = "ShippedQuantity"
        Me.colShippedQuantity.Name = "colShippedQuantity"
        Me.colShippedQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colShippedQuantity.Visible = True
        Me.colShippedQuantity.VisibleIndex = 17
        Me.colShippedQuantity.Width = 104
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 18
        Me.colRemarks.Width = 300
        '
        'colDiscontinue
        '
        Me.colDiscontinue.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDiscontinue.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDiscontinue.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDiscontinue.AppearanceCell.Options.UseBackColor = True
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.Visible = True
        Me.colDiscontinue.VisibleIndex = 20
        '
        'colCompleted
        '
        Me.colCompleted.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompleted.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompleted.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCompleted.AppearanceCell.Options.UseBackColor = True
        Me.colCompleted.FieldName = "Completed"
        Me.colCompleted.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colCompleted.Name = "colCompleted"
        Me.colCompleted.Visible = True
        Me.colCompleted.VisibleIndex = 19
        Me.colCompleted.Width = 84
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.OrderCPGridControl
        Me.GridView2.Name = "GridView2"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'SewingStartDateLabel
        '
        Me.SewingStartDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SewingStartDateLabel.Location = New System.Drawing.Point(528, 26)
        Me.SewingStartDateLabel.Name = "SewingStartDateLabel"
        Me.SewingStartDateLabel.Size = New System.Drawing.Size(72, 22)
        Me.SewingStartDateLabel.TabIndex = 2
        Me.SewingStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintStartDateLabel
        '
        Me.PrintStartDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PrintStartDateLabel.Location = New System.Drawing.Point(313, 55)
        Me.PrintStartDateLabel.Name = "PrintStartDateLabel"
        Me.PrintStartDateLabel.Size = New System.Drawing.Size(69, 22)
        Me.PrintStartDateLabel.TabIndex = 3
        Me.PrintStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderStatusGroupBox
        '
        Me.OrderStatusGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderStatusGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderStatusGroupBox.Controls.Add(Me.Label20)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label29)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label30)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label19)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label21)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label22)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label23)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label24)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label25)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label26)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label27)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label28)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label17)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label18)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label15)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label16)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label14)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label11)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label12)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label7)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label8)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label1)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label4)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label2)
        Me.OrderStatusGroupBox.Controls.Add(Me.ShipmentQuantityLabel)
        Me.OrderStatusGroupBox.Controls.Add(Me.ShipmentDateLabel)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label3)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label6)
        Me.OrderStatusGroupBox.Controls.Add(Me.Label5)
        Me.OrderStatusGroupBox.Controls.Add(Me.PrintStartDateLabel)
        Me.OrderStatusGroupBox.Controls.Add(Me.SewingStartDateLabel)
        Me.OrderStatusGroupBox.Location = New System.Drawing.Point(8, 269)
        Me.OrderStatusGroupBox.Name = "OrderStatusGroupBox"
        Me.OrderStatusGroupBox.Size = New System.Drawing.Size(992, 115)
        Me.OrderStatusGroupBox.TabIndex = 5
        Me.OrderStatusGroupBox.TabStop = False
        Me.OrderStatusGroupBox.Text = "Order Status"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(388, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 22)
        Me.Label20.TabIndex = 39
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(214, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Farbic Rcv Date"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Location = New System.Drawing.Point(313, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 22)
        Me.Label30.TabIndex = 37
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(189, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 22)
        Me.Label19.TabIndex = 36
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Knitting Start Date"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(114, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 22)
        Me.Label22.TabIndex = 34
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Location = New System.Drawing.Point(189, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 22)
        Me.Label23.TabIndex = 33
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(189, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(22, 22)
        Me.Label24.TabIndex = 32
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 13)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Fab Booking Date"
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Location = New System.Drawing.Point(114, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 22)
        Me.Label26.TabIndex = 30
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(15, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "Dyeing Start Date"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Location = New System.Drawing.Point(114, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 22)
        Me.Label28.TabIndex = 28
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(388, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 22)
        Me.Label17.TabIndex = 25
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(388, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 22)
        Me.Label18.TabIndex = 24
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(214, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Print Comp Date"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(313, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 22)
        Me.Label16.TabIndex = 22
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(816, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 22)
        Me.Label14.TabIndex = 20
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(606, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(606, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sewing Quantity"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(528, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(429, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sewing Com. Date"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(528, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(638, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Shipment Quantity"
        '
        'ShipmentQuantityLabel
        '
        Me.ShipmentQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShipmentQuantityLabel.Location = New System.Drawing.Point(738, 55)
        Me.ShipmentQuantityLabel.Name = "ShipmentQuantityLabel"
        Me.ShipmentQuantityLabel.Size = New System.Drawing.Size(100, 22)
        Me.ShipmentQuantityLabel.TabIndex = 10
        Me.ShipmentQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShipmentDateLabel
        '
        Me.ShipmentDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShipmentDateLabel.Location = New System.Drawing.Point(738, 26)
        Me.ShipmentDateLabel.Name = "ShipmentDateLabel"
        Me.ShipmentDateLabel.Size = New System.Drawing.Size(72, 22)
        Me.ShipmentDateLabel.TabIndex = 9
        Me.ShipmentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(638, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Shipment Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Print Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sewing Start Date"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(139, 2)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Order No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(126, 20)
        Me.GridLookUpEdit1.TabIndex = 6
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId1, Me.colProgramNo, Me.colIsPrint})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        Me.colOrderId1.OptionsColumn.ReadOnly = True
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
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(271, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 23)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Insert into Order CP"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(396, 1)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(95, 23)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "Syncronize"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(575, 1)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(95, 23)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "Print"
        '
        'frmOrderCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 396)
        Me.Controls.Add(Me.OrderCPGridControl)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.OrderStatusGroupBox)
        Me.Controls.Add(Me.OrderCPBindingNavigator)
        Me.Name = "frmOrderCP"
        Me.Text = "frmOrderCP"
        CType(Me.OrderCPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderCPBindingNavigator.ResumeLayout(False)
        Me.OrderCPBindingNavigator.PerformLayout()
        CType(Me.OrderCPGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderStatusGroupBox.ResumeLayout(False)
        Me.OrderStatusGroupBox.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderCPDataSet As KSoft_Apparel.OrderCPDataSet
    Friend WithEvents OrderCPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderCPTableAdapter As KSoft_Apparel.OrderCPDataSetTableAdapters.OrderCPTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OrderCPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderCPBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents OrderCPBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrderCPGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderCPId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricRequireDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricReceiveQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestCuttingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroideryStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroideryCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippedQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents SewingStartDateLabel As System.Windows.Forms.Label
    Friend WithEvents PrintStartDateLabel As System.Windows.Forms.Label
    Friend WithEvents OrderStatusGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShipmentDateLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShipmentQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
