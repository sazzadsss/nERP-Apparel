<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGatePassPrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GatePassLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GatePassDataSet = New KSoft_Apparel.GatePassDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGatePassNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGatepassDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GatePassLookupTableAdapter = New KSoft_Apparel.GatePassDataSetTableAdapters.GatePassLookupTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowByChallanDateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GatePassTypeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RequestGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestNoAndStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 70)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1193, 481)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sample Delivery Gate Pass No :"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(175, 25)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.GatePassLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "GatePassNo"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "GatePassId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(141, 20)
        Me.GridLookUpEdit1.TabIndex = 15
        '
        'GatePassLookupBindingSource
        '
        Me.GatePassLookupBindingSource.DataMember = "GatePassLookup"
        Me.GatePassLookupBindingSource.DataSource = Me.GatePassDataSet
        '
        'GatePassDataSet
        '
        Me.GatePassDataSet.DataSetName = "GatePassDataSet"
        Me.GatePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGatePassNo, Me.colGatepassDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colGatePassNo
        '
        Me.colGatePassNo.FieldName = "GatePassNo"
        Me.colGatePassNo.Name = "colGatePassNo"
        Me.colGatePassNo.Visible = True
        Me.colGatePassNo.VisibleIndex = 0
        '
        'colGatepassDate
        '
        Me.colGatepassDate.FieldName = "GatepassDate"
        Me.colGatepassDate.Name = "colGatepassDate"
        Me.colGatepassDate.Visible = True
        Me.colGatepassDate.VisibleIndex = 1
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(322, 10)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 54)
        Me.ShowButton.TabIndex = 16
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GatePassLookupTableAdapter
        '
        Me.GatePassLookupTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "From :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(527, 44)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.ToDateTimePicker.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(485, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "To :"
        '
        'ShowByChallanDateButton
        '
        Me.ShowByChallanDateButton.Location = New System.Drawing.Point(737, 17)
        Me.ShowByChallanDateButton.Name = "ShowByChallanDateButton"
        Me.ShowByChallanDateButton.Size = New System.Drawing.Size(73, 47)
        Me.ShowByChallanDateButton.TabIndex = 57
        Me.ShowByChallanDateButton.Text = "&Show Details"
        Me.ShowByChallanDateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Sample Delivery Gate Pass Date :"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(527, 20)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.FromDateTimePicker.TabIndex = 55
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(402, 10)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 54)
        Me.PrintButton.TabIndex = 16
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 47)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "&Show Summery"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(825, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Gate Pass Sample Type:"
        '
        'GatePassTypeComboBoxEdit
        '
        Me.GatePassTypeComboBoxEdit.Location = New System.Drawing.Point(955, 14)
        Me.GatePassTypeComboBoxEdit.Name = "GatePassTypeComboBoxEdit"
        Me.GatePassTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GatePassTypeComboBoxEdit.Properties.Items.AddRange(New Object() {"Devolopment", "Fit", "Size Set", "Gold Seal", "Black Seal", "Red Seal", "PP", "Test", "Quatation", "Production", "Shipping", "Styling", "SMS", "Gift", "Shading", "Photo", "FFP", "K&O", "Proto"})
        Me.GatePassTypeComboBoxEdit.Size = New System.Drawing.Size(155, 20)
        Me.GatePassTypeComboBoxEdit.TabIndex = 63
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1116, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 26)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SampleRequestLookupDataSet
        '
        Me.SampleRequestLookupDataSet.DataSetName = "SampleRequestLookupDataSet"
        Me.SampleRequestLookupDataSet.EnforceConstraints = False
        Me.SampleRequestLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(825, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Sample Program No:"
        '
        'RequestGridLookUpEdit
        '
        Me.RequestGridLookUpEdit.Location = New System.Drawing.Point(955, 41)
        Me.RequestGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.RequestGridLookUpEdit.Name = "RequestGridLookUpEdit"
        Me.RequestGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequestGridLookUpEdit.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.RequestGridLookUpEdit.Properties.DisplayMember = "RequestNoAndStyleNo"
        Me.RequestGridLookUpEdit.Properties.ImmediatePopup = True
        Me.RequestGridLookUpEdit.Properties.NullText = ""
        Me.RequestGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RequestGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.RequestGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RequestGridLookUpEdit.Properties.ValueMember = "SampleRequestId"
        Me.RequestGridLookUpEdit.Size = New System.Drawing.Size(155, 20)
        Me.RequestGridLookUpEdit.TabIndex = 72
        Me.RequestGridLookUpEdit.Tag = "NR"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequestNoAndStyleNo, Me.colRequestDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRequestNoAndStyleNo
        '
        Me.colRequestNoAndStyleNo.FieldName = "RequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Name = "colRequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Visible = True
        Me.colRequestNoAndStyleNo.VisibleIndex = 0
        '
        'colRequestDate
        '
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.Visible = True
        Me.colRequestDate.VisibleIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1116, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 26)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmGatePassPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 551)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RequestGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GatePassTypeComboBoxEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowByChallanDateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmGatePassPrint"
        Me.Text = "Sample Development Delivery Gate Pass Print"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGatepassDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents GatePassDataSet As KSoft_Apparel.GatePassDataSet
    Friend WithEvents GatePassLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GatePassLookupTableAdapter As KSoft_Apparel.GatePassDataSetTableAdapters.GatePassLookupTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ShowByChallanDateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents colGatePassNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GatePassTypeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Button2 As Button
    Friend WithEvents SampleRequestLookupDataSet As SampleRequestLookupDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents RequestGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequestNoAndStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
End Class
