<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingTargetAllocation
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
        Dim SelectedLCDayLabel As System.Windows.Forms.Label
        Dim LCDayReasonLabel As System.Windows.Forms.Label
        Dim LayoutTimeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSewingTargetAllocation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim SplineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.SewingTargetAllocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingTargetAllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingTargetAllocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.LCComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ReasonTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.LayoutTimeTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SewingTargetAllocationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMVMachineLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProdEfficiencyLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AllocatingQuantityLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BonusTargetLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TargetLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SelectedLCDayLabel1 = New System.Windows.Forms.Label()
        Me.LCDayReasonLabel2 = New System.Windows.Forms.Label()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.SewingTargetAllocationTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingTargetAllocationTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager()
        Me.LayoutTimeLabel1 = New System.Windows.Forms.Label()
        Me.WHPerDayLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        SelectedLCDayLabel = New System.Windows.Forms.Label()
        LCDayReasonLabel = New System.Windows.Forms.Label()
        LayoutTimeLabel = New System.Windows.Forms.Label()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTargetAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingTargetAllocationBindingNavigator.SuspendLayout()
        CType(Me.SewingTargetAllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTargetAllocationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectedLCDayLabel
        '
        SelectedLCDayLabel.AutoSize = True
        SelectedLCDayLabel.ForeColor = System.Drawing.Color.Red
        SelectedLCDayLabel.Location = New System.Drawing.Point(330, 402)
        SelectedLCDayLabel.Name = "SelectedLCDayLabel"
        SelectedLCDayLabel.Size = New System.Drawing.Size(87, 13)
        SelectedLCDayLabel.TabIndex = 61
        SelectedLCDayLabel.Text = "Selected LCDay:"
        '
        'LCDayReasonLabel
        '
        LCDayReasonLabel.AutoSize = True
        LCDayReasonLabel.ForeColor = System.Drawing.Color.Red
        LCDayReasonLabel.Location = New System.Drawing.Point(330, 425)
        LCDayReasonLabel.Name = "LCDayReasonLabel"
        LCDayReasonLabel.Size = New System.Drawing.Size(82, 13)
        LCDayReasonLabel.TabIndex = 62
        LCDayReasonLabel.Text = "LCDay Reason:"
        '
        'LayoutTimeLabel
        '
        LayoutTimeLabel.AutoSize = True
        LayoutTimeLabel.ForeColor = System.Drawing.Color.Red
        LayoutTimeLabel.Location = New System.Drawing.Point(330, 457)
        LayoutTimeLabel.Name = "LayoutTimeLabel"
        LayoutTimeLabel.Size = New System.Drawing.Size(68, 13)
        LayoutTimeLabel.TabIndex = 63
        LayoutTimeLabel.Text = "Layout Time:"
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingTargetAllocationBindingNavigator
        '
        Me.SewingTargetAllocationBindingNavigator.AddNewItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SewingTargetAllocationBindingNavigator.BindingSource = Me.SewingTargetAllocationBindingSource
        Me.SewingTargetAllocationBindingNavigator.CountItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.DeleteItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingTargetAllocationBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.LCComboBox, Me.ToolStripLabel2, Me.ReasonTextBox, Me.ToolStripLabel3, Me.LayoutTimeTextBox, Me.ToolStripButton1})
        Me.SewingTargetAllocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingTargetAllocationBindingNavigator.MoveFirstItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.MoveLastItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.MoveNextItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.MovePreviousItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.Name = "SewingTargetAllocationBindingNavigator"
        Me.SewingTargetAllocationBindingNavigator.PositionItem = Nothing
        Me.SewingTargetAllocationBindingNavigator.Size = New System.Drawing.Size(901, 25)
        Me.SewingTargetAllocationBindingNavigator.TabIndex = 0
        Me.SewingTargetAllocationBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingTargetAllocationBindingSource
        '
        Me.SewingTargetAllocationBindingSource.DataMember = "SewingTargetAllocation"
        Me.SewingTargetAllocationBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingTargetAllocationBindingNavigatorSaveItem
        '
        Me.SewingTargetAllocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingTargetAllocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingTargetAllocationBindingNavigatorSaveItem.Name = "SewingTargetAllocationBindingNavigatorSaveItem"
        Me.SewingTargetAllocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingTargetAllocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripLabel1.Text = "From Learning Curve Day :"
        '
        'LCComboBox
        '
        Me.LCComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.LCComboBox.Name = "LCComboBox"
        Me.LCComboBox.Size = New System.Drawing.Size(75, 25)
        Me.LCComboBox.Text = "1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel2.Text = "Reason"
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(200, 25)
        Me.ReasonTextBox.Text = "-"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel3.Text = "Layout Time"
        '
        'LayoutTimeTextBox
        '
        Me.LayoutTimeTextBox.Name = "LayoutTimeTextBox"
        Me.LayoutTimeTextBox.Size = New System.Drawing.Size(50, 25)
        Me.LayoutTimeTextBox.Text = "0"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButton1.Text = "Calculate Target"
        '
        'SewingTargetAllocationDataGridView
        '
        Me.SewingTargetAllocationDataGridView.AllowUserToAddRows = False
        Me.SewingTargetAllocationDataGridView.AutoGenerateColumns = False
        Me.SewingTargetAllocationDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingTargetAllocationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingTargetAllocationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SewingTargetAllocationDataGridView.DataSource = Me.SewingTargetAllocationBindingSource
        Me.SewingTargetAllocationDataGridView.Location = New System.Drawing.Point(18, 47)
        Me.SewingTargetAllocationDataGridView.Name = "SewingTargetAllocationDataGridView"
        Me.SewingTargetAllocationDataGridView.ReadOnly = True
        Me.SewingTargetAllocationDataGridView.Size = New System.Drawing.Size(476, 343)
        Me.SewingTargetAllocationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DaySerial"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Efficiency"
        DataGridViewCellStyle2.Format = "#%"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Efficiency"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NormalQuantity"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Normal Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CumNormalQuantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cum Normal Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BonusQuanitty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Bonus Quanitty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CumBonusQuantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cum Bonus Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'SMVMachineLabel
        '
        Me.SMVMachineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SMVMachineLabel.Location = New System.Drawing.Point(764, 70)
        Me.SMVMachineLabel.Name = "SMVMachineLabel"
        Me.SMVMachineLabel.Size = New System.Drawing.Size(112, 20)
        Me.SMVMachineLabel.TabIndex = 50
        Me.SMVMachineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(508, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "SMV [Machine]"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProdEfficiencyLabel
        '
        Me.ProdEfficiencyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProdEfficiencyLabel.Location = New System.Drawing.Point(764, 93)
        Me.ProdEfficiencyLabel.Name = "ProdEfficiencyLabel"
        Me.ProdEfficiencyLabel.Size = New System.Drawing.Size(112, 20)
        Me.ProdEfficiencyLabel.TabIndex = 52
        Me.ProdEfficiencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(508, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Production 100% Efficiency"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllocatingQuantityLabel
        '
        Me.AllocatingQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AllocatingQuantityLabel.Location = New System.Drawing.Point(764, 47)
        Me.AllocatingQuantityLabel.Name = "AllocatingQuantityLabel"
        Me.AllocatingQuantityLabel.Size = New System.Drawing.Size(112, 20)
        Me.AllocatingQuantityLabel.TabIndex = 54
        Me.AllocatingQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(508, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Allocating Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BonusTargetLabel
        '
        Me.BonusTargetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BonusTargetLabel.Location = New System.Drawing.Point(234, 420)
        Me.BonusTargetLabel.Name = "BonusTargetLabel"
        Me.BonusTargetLabel.Size = New System.Drawing.Size(84, 20)
        Me.BonusTargetLabel.TabIndex = 59
        Me.BonusTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(18, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Bonus Target [Per Hour]"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetLabel
        '
        Me.TargetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TargetLabel.Location = New System.Drawing.Point(234, 397)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(84, 20)
        Me.TargetLabel.TabIndex = 57
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(18, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Target [Per Hour]"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKButton.Location = New System.Drawing.Point(764, 397)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(112, 82)
        Me.OKButton.TabIndex = 61
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SelectedLCDayLabel1
        '
        Me.SelectedLCDayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SelectedLCDayLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewingTargetAllocationBindingSource, "SelectedLCDay", True))
        Me.SelectedLCDayLabel1.Location = New System.Drawing.Point(423, 397)
        Me.SelectedLCDayLabel1.Name = "SelectedLCDayLabel1"
        Me.SelectedLCDayLabel1.Size = New System.Drawing.Size(71, 21)
        Me.SelectedLCDayLabel1.TabIndex = 62
        Me.SelectedLCDayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LCDayReasonLabel2
        '
        Me.LCDayReasonLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LCDayReasonLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewingTargetAllocationBindingSource, "LCDayReason", True))
        Me.LCDayReasonLabel2.Location = New System.Drawing.Point(423, 421)
        Me.LCDayReasonLabel2.Name = "LCDayReasonLabel2"
        Me.LCDayReasonLabel2.Size = New System.Drawing.Size(319, 23)
        Me.LCDayReasonLabel2.TabIndex = 63
        Me.LCDayReasonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Dark Flat"
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.SewingLayoutDataSet.SewingLayout
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Location = New System.Drawing.Point(508, 149)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Nature Colors"
        Series1.ArgumentDataMember = "DaySerial"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series1.DataSource = Me.SewingLayoutDataSet.SewingTargetAllocation
        PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = PointSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "NormalQuantity"
        Series1.View = SplineSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = PointSeriesLabel2
        Me.ChartControl1.SeriesTemplate.View = SplineSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(368, 241)
        Me.ChartControl1.TabIndex = 60
        '
        'SewingTargetAllocationTableAdapter
        '
        Me.SewingTargetAllocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingBreakDownCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingBreakDownTableAdapter = Nothing
        Me.TableAdapterManager.SewingCategoryTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingLearningCurveTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineTableAdapter = Nothing
        Me.TableAdapterManager.SewingProcessTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Me.SewingTargetAllocationTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LayoutTimeLabel1
        '
        Me.LayoutTimeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LayoutTimeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewingTargetAllocationBindingSource, "LayoutTime", True))
        Me.LayoutTimeLabel1.Location = New System.Drawing.Point(423, 452)
        Me.LayoutTimeLabel1.Name = "LayoutTimeLabel1"
        Me.LayoutTimeLabel1.Size = New System.Drawing.Size(71, 23)
        Me.LayoutTimeLabel1.TabIndex = 64
        '
        'WHPerDayLabel
        '
        Me.WHPerDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WHPerDayLabel.Location = New System.Drawing.Point(764, 117)
        Me.WHPerDayLabel.Name = "WHPerDayLabel"
        Me.WHPerDayLabel.Size = New System.Drawing.Size(112, 20)
        Me.WHPerDayLabel.TabIndex = 65
        Me.WHPerDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(508, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 20)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Working Hour Per Day"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSewingTargetAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 498)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WHPerDayLabel)
        Me.Controls.Add(LayoutTimeLabel)
        Me.Controls.Add(Me.LayoutTimeLabel1)
        Me.Controls.Add(Me.LCDayReasonLabel2)
        Me.Controls.Add(LCDayReasonLabel)
        Me.Controls.Add(SelectedLCDayLabel)
        Me.Controls.Add(Me.SelectedLCDayLabel1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.BonusTargetLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TargetLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AllocatingQuantityLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProdEfficiencyLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SMVMachineLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SewingTargetAllocationDataGridView)
        Me.Controls.Add(Me.SewingTargetAllocationBindingNavigator)
        Me.Name = "frmSewingTargetAllocation"
        Me.Text = "Sewing Target Allocation"
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTargetAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingTargetAllocationBindingNavigator.ResumeLayout(False)
        Me.SewingTargetAllocationBindingNavigator.PerformLayout()
        CType(Me.SewingTargetAllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTargetAllocationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingTargetAllocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingTargetAllocationTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingTargetAllocationTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingTargetAllocationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingTargetAllocationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingTargetAllocationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SMVMachineLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProdEfficiencyLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AllocatingQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BonusTargetLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TargetLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LCComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ReasonTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SelectedLCDayLabel1 As System.Windows.Forms.Label
    Friend WithEvents LCDayReasonLabel2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LayoutTimeTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LayoutTimeLabel1 As System.Windows.Forms.Label
    Friend WithEvents WHPerDayLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
