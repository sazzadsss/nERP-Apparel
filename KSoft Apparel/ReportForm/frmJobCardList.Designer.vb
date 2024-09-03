<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobCardListDetails
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.MultipartLabel = New System.Windows.Forms.Label
        Me.MultipartComboBox = New System.Windows.Forms.ComboBox
        Me.TwinPackfilteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TwinPackLookupDataSet = New KSoft_Apparel.TwinPackLookupDataSet
        Me.Label13 = New System.Windows.Forms.Label
        Me.SizeComboBox = New System.Windows.Forms.ComboBox
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet
        Me.ShowButton = New System.Windows.Forms.Button
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.TwinPackfilteredTableAdapter = New KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 64)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1034, 414)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.FabricColorComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel2.Controls.Add(Me.SizeComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(906, 32)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Program No"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(72, 5)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 11
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Color"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(242, 5)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(5, 5, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(142, 21)
        Me.FabricColorComboBox.TabIndex = 1
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
        'MultipartLabel
        '
        Me.MultipartLabel.AutoSize = True
        Me.MultipartLabel.Location = New System.Drawing.Point(392, 9)
        Me.MultipartLabel.Margin = New System.Windows.Forms.Padding(5, 9, 3, 0)
        Me.MultipartLabel.Name = "MultipartLabel"
        Me.MultipartLabel.Size = New System.Drawing.Size(47, 13)
        Me.MultipartLabel.TabIndex = 6
        Me.MultipartLabel.Text = "Multipart"
        '
        'MultipartComboBox
        '
        Me.MultipartComboBox.DataSource = Me.TwinPackfilteredBindingSource
        Me.MultipartComboBox.DisplayMember = "Details"
        Me.MultipartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MultipartComboBox.FormattingEnabled = True
        Me.MultipartComboBox.Location = New System.Drawing.Point(445, 5)
        Me.MultipartComboBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.MultipartComboBox.Name = "MultipartComboBox"
        Me.MultipartComboBox.Size = New System.Drawing.Size(140, 21)
        Me.MultipartComboBox.TabIndex = 2
        Me.MultipartComboBox.ValueMember = "TwinPackId"
        '
        'TwinPackfilteredBindingSource
        '
        Me.TwinPackfilteredBindingSource.DataMember = "TwinPackfiltered"
        Me.TwinPackfilteredBindingSource.DataSource = Me.TwinPackLookupDataSet
        '
        'TwinPackLookupDataSet
        '
        Me.TwinPackLookupDataSet.DataSetName = "TwinPackLookupDataSet"
        Me.TwinPackLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(591, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 9, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Size No"
        '
        'SizeComboBox
        '
        Me.SizeComboBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.SizeComboBox.DataSource = Me.SizeLookupBindingSource
        Me.SizeComboBox.DisplayMember = "SizeCode"
        Me.SizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeComboBox.FormattingEnabled = True
        Me.SizeComboBox.Location = New System.Drawing.Point(641, 5)
        Me.SizeComboBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.SizeComboBox.Name = "SizeComboBox"
        Me.SizeComboBox.Size = New System.Drawing.Size(75, 21)
        Me.SizeComboBox.TabIndex = 8
        Me.SizeComboBox.ValueMember = "SizeId"
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
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowButton.Location = New System.Drawing.Point(727, 3)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(100, 24)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'TwinPackfilteredTableAdapter
        '
        Me.TwinPackfilteredTableAdapter.ClearBeforeFill = True
        '
        'frmJobCardListDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 480)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmJobCardListDetails"
        Me.Text = "Job Card List Details"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MultipartLabel As System.Windows.Forms.Label
    Friend WithEvents MultipartComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeLookupDataSet As KSoft_Apparel.SizeLookupDataSet
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents SizeLookupTableAdapter As KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents TwinPackfilteredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TwinPackLookupDataSet As KSoft_Apparel.TwinPackLookupDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents TwinPackfilteredTableAdapter As KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter
End Class
