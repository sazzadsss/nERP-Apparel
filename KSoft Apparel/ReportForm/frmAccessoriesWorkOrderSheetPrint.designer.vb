<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesWorkOrderSheetPrint
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AWSButton = New System.Windows.Forms.Button()
        Me.AWSNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AWSLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWSLookupDataSet = New KSoft_Apparel.AWSLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAWSNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToProgramDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromProgramDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.AWSLookupTableAdapter = New KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter()
        Me.AWSProgramLookupGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AWSProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAWSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AWSProgramLookupTableAdapter = New KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSProgramLookupTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AWSLookupDataSetTableAdapters.TableAdapterManager()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSProgramLookupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(985, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "&Show NL Care Label Format"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'AWSButton
        '
        Me.AWSButton.Location = New System.Drawing.Point(388, 8)
        Me.AWSButton.Name = "AWSButton"
        Me.AWSButton.Size = New System.Drawing.Size(83, 23)
        Me.AWSButton.TabIndex = 62
        Me.AWSButton.Text = "&Show Format1"
        Me.AWSButton.UseVisualStyleBackColor = True
        '
        'AWSNoLookUpEdit
        '
        Me.AWSNoLookUpEdit.Location = New System.Drawing.Point(154, 9)
        Me.AWSNoLookUpEdit.Name = "AWSNoLookUpEdit"
        Me.AWSNoLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.AWSNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AWSNoLookUpEdit.Properties.DataSource = Me.AWSLookupBindingSource
        Me.AWSNoLookUpEdit.Properties.DisplayMember = "AWSNo"
        Me.AWSNoLookUpEdit.Properties.ImmediatePopup = True
        Me.AWSNoLookUpEdit.Properties.NullText = ""
        Me.AWSNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AWSNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AWSNoLookUpEdit.Properties.ValueMember = "AWSId"
        Me.AWSNoLookUpEdit.Properties.View = Me.GridView2
        Me.AWSNoLookUpEdit.Size = New System.Drawing.Size(230, 20)
        Me.AWSNoLookUpEdit.TabIndex = 61
        '
        'AWSLookupBindingSource
        '
        Me.AWSLookupBindingSource.DataMember = "AWSLookup"
        Me.AWSLookupBindingSource.DataSource = Me.AWSLookupDataSet
        '
        'AWSLookupDataSet
        '
        Me.AWSLookupDataSet.DataSetName = "AWSLookupDataSet"
        Me.AWSLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAWSNo1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colAWSNo1
        '
        Me.colAWSNo1.FieldName = "AWSNo"
        Me.colAWSNo1.Name = "colAWSNo1"
        Me.colAWSNo1.Visible = True
        Me.colAWSNo1.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Accessories Work Sheet No:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(847, 636)
        Me.CrystalReportViewer1.TabIndex = 64
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Date Range From:"
        '
        'ToProgramDateTimePicker
        '
        Me.ToProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToProgramDateTimePicker.Location = New System.Drawing.Point(804, 10)
        Me.ToProgramDateTimePicker.Name = "ToProgramDateTimePicker"
        Me.ToProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.ToProgramDateTimePicker.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(772, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "To :"
        '
        'FromProgramDateTimePicker
        '
        Me.FromProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromProgramDateTimePicker.Location = New System.Drawing.Point(678, 10)
        Me.FromProgramDateTimePicker.Name = "FromProgramDateTimePicker"
        Me.FromProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.FromProgramDateTimePicker.TabIndex = 69
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(898, 8)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(81, 23)
        Me.ShowButton.TabIndex = 68
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'AWSLookupTableAdapter
        '
        Me.AWSLookupTableAdapter.ClearBeforeFill = True
        '
        'AWSProgramLookupGridControl
        '
        Me.AWSProgramLookupGridControl.DataSource = Me.AWSProgramLookupBindingSource
        Me.AWSProgramLookupGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AWSProgramLookupGridControl.Location = New System.Drawing.Point(0, 0)
        Me.AWSProgramLookupGridControl.MainView = Me.GridView1
        Me.AWSProgramLookupGridControl.Name = "AWSProgramLookupGridControl"
        Me.AWSProgramLookupGridControl.Size = New System.Drawing.Size(348, 636)
        Me.AWSProgramLookupGridControl.TabIndex = 0
        Me.AWSProgramLookupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AWSProgramLookupBindingSource
        '
        Me.AWSProgramLookupBindingSource.DataMember = "AWSProgramLookup"
        Me.AWSProgramLookupBindingSource.DataSource = Me.AWSLookupDataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAWSNo, Me.colSupplierName, Me.colProgramNo, Me.colStyleName, Me.colBuyerName})
        Me.GridView1.GridControl = Me.AWSProgramLookupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAWSNo
        '
        Me.colAWSNo.FieldName = "AWSNo"
        Me.colAWSNo.Name = "colAWSNo"
        Me.colAWSNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAWSNo.Visible = True
        Me.colAWSNo.VisibleIndex = 0
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 4
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 2
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 3
        '
        'AWSProgramLookupTableAdapter
        '
        Me.AWSProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AWSLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(5, 37)
        Me.SplitContainerControl1.LookAndFeel.SkinName = "Black"
        Me.SplitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.AWSProgramLookupGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1201, 636)
        Me.SplitContainerControl1.SplitterPosition = 847
        Me.SplitContainerControl1.TabIndex = 73
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "&Show Format2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAccessoriesWorkOrderSheetPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 677)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToProgramDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromProgramDateTimePicker)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AWSButton)
        Me.Controls.Add(Me.AWSNoLookUpEdit)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmAccessoriesWorkOrderSheetPrint"
        Me.Text = "Accessories Work Order Sheet Print"
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSProgramLookupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AWSButton As System.Windows.Forms.Button
    Friend WithEvents AWSNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AWSLookupDataSet As KSoft_Apparel.AWSLookupDataSet
    Friend WithEvents AWSLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSLookupTableAdapter As KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FromProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents AWSProgramLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSProgramLookupTableAdapter As KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSProgramLookupTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AWSLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AWSProgramLookupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAWSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents colAWSNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
End Class
