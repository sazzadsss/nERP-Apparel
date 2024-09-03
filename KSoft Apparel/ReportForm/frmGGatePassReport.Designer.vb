<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGGatePassPrint
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GGatePassLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GGatePassLookupDataSet = New KSoft_Apparel.GGatePassLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGatePassNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGatePaseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GeneralGatePassDataSet = New KSoft_Apparel.GeneralGatePassDataSet()
        Me.GeneralGatePassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralGatePassTableAdapter = New KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GGatePassLookupDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GGatePassLookupTableAdapter = New KSoft_Apparel.GGatePassLookupDataSetTableAdapters.GGatePassLookupTableAdapter()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Gate Pass No :"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(97, 6)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.GGatePassLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "GatePassNo"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.ValueMember = "GeneralGatePassId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView3
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(176, 20)
        Me.GridLookUpEdit1.TabIndex = 22
        '
        'GGatePassLookupBindingSource
        '
        Me.GGatePassLookupBindingSource.DataMember = "GGatePassLookup"
        Me.GGatePassLookupBindingSource.DataSource = Me.GGatePassLookupDataSet
        '
        'GGatePassLookupDataSet
        '
        Me.GGatePassLookupDataSet.DataSetName = "GGatePassLookupDataSet"
        Me.GGatePassLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGatePassNo, Me.colGatePaseDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colGatePassNo
        '
        Me.colGatePassNo.FieldName = "GatePassNo"
        Me.colGatePassNo.Name = "colGatePassNo"
        Me.colGatePassNo.Visible = True
        Me.colGatePassNo.VisibleIndex = 0
        '
        'colGatePaseDate
        '
        Me.colGatePaseDate.FieldName = "GatePaseDate"
        Me.colGatePaseDate.Name = "colGatePaseDate"
        Me.colGatePaseDate.Visible = True
        Me.colGatePaseDate.VisibleIndex = 1
        '
        'GeneralGatePassDataSet
        '
        Me.GeneralGatePassDataSet.DataSetName = "GeneralGatePassDataSet"
        Me.GeneralGatePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralGatePassBindingSource
        '
        Me.GeneralGatePassBindingSource.DataMember = "GeneralGatePass"
        Me.GeneralGatePassBindingSource.DataSource = Me.GeneralGatePassDataSet
        '
        'GeneralGatePassTableAdapter
        '
        Me.GeneralGatePassTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(279, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 23
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 33)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1046, 536)
        Me.CrystalReportViewer1.TabIndex = 24
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GGatePassLookupDataSetBindingSource
        '
        Me.GGatePassLookupDataSetBindingSource.DataSource = Me.GGatePassLookupDataSet
        Me.GGatePassLookupDataSetBindingSource.Position = 0
        '
        'GGatePassLookupTableAdapter
        '
        Me.GGatePassLookupTableAdapter.ClearBeforeFill = True
        '
        'frmGGatePassPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 569)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmGGatePassPrint"
        Me.Text = "GGatePass"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GeneralGatePassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralGatePassDataSet As KSoft_Apparel.GeneralGatePassDataSet
    Friend WithEvents GeneralGatePassTableAdapter As KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GGatePassLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GGatePassLookupDataSet As KSoft_Apparel.GGatePassLookupDataSet
    Friend WithEvents GGatePassLookupDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GGatePassLookupTableAdapter As KSoft_Apparel.GGatePassLookupDataSetTableAdapters.GGatePassLookupTableAdapter
    Friend WithEvents colGatePassNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGatePaseDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
