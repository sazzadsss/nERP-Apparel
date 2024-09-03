<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommercialInvoicePrint
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
        Me.InvoiceNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.CommercialInvoiceLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommercialInvoiceLookUpDataSet = New KSoft_Apparel.CommercialInvoiceLookUpDataSet
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCommercialInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCommercialInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ShowButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CommercialInvoiceLookUpTableAdapter = New KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.FormatComboBox = New System.Windows.Forms.ComboBox
        CType(Me.InvoiceNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceNoGridLookUpEdit
        '
        Me.InvoiceNoGridLookUpEdit.Location = New System.Drawing.Point(95, 5)
        Me.InvoiceNoGridLookUpEdit.Name = "InvoiceNoGridLookUpEdit"
        Me.InvoiceNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceNoGridLookUpEdit.Properties.DataSource = Me.CommercialInvoiceLookUpBindingSource
        Me.InvoiceNoGridLookUpEdit.Properties.DisplayMember = "CommercialInvoiceNo"
        Me.InvoiceNoGridLookUpEdit.Properties.NullText = ""
        Me.InvoiceNoGridLookUpEdit.Properties.ValueMember = "CommercialInvoiceMainId"
        Me.InvoiceNoGridLookUpEdit.Properties.View = Me.GridView2
        Me.InvoiceNoGridLookUpEdit.Size = New System.Drawing.Size(144, 20)
        Me.InvoiceNoGridLookUpEdit.TabIndex = 55
        '
        'CommercialInvoiceLookUpBindingSource
        '
        Me.CommercialInvoiceLookUpBindingSource.DataMember = "CommercialInvoiceLookUp"
        Me.CommercialInvoiceLookUpBindingSource.DataSource = Me.CommercialInvoiceLookUpDataSet
        '
        'CommercialInvoiceLookUpDataSet
        '
        Me.CommercialInvoiceLookUpDataSet.DataSetName = "CommercialInvoiceLookUpDataSet"
        Me.CommercialInvoiceLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommercialInvoiceNo, Me.colCommercialInvoiceDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 33)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(973, 475)
        Me.CrystalReportViewer1.TabIndex = 54
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(472, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 23)
        Me.ShowButton.TabIndex = 53
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Invoice No :"
        '
        'CommercialInvoiceLookUpTableAdapter
        '
        Me.CommercialInvoiceLookUpTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Select Format :"
        '
        'FormatComboBox
        '
        Me.FormatComboBox.FormattingEnabled = True
        Me.FormatComboBox.Items.AddRange(New Object() {"Standard Format", "Primark", "MGB", "Debenhams", "C&A", "Centerline", "GMS"})
        Me.FormatComboBox.Location = New System.Drawing.Point(334, 4)
        Me.FormatComboBox.Name = "FormatComboBox"
        Me.FormatComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FormatComboBox.TabIndex = 57
        '
        'frmCommercialInvoicePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 509)
        Me.Controls.Add(Me.FormatComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InvoiceNoGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCommercialInvoicePrint"
        Me.Text = "Commercial Invoice Print"
        CType(Me.InvoiceNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InvoiceNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CommercialInvoiceLookUpDataSet As KSoft_Apparel.CommercialInvoiceLookUpDataSet
    Friend WithEvents CommercialInvoiceLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceLookUpTableAdapter As KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter
    Friend WithEvents colCommercialInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FormatComboBox As System.Windows.Forms.ComboBox
End Class
