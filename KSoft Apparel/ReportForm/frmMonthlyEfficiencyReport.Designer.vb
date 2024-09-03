<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyEfficiencyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlyEfficiencyReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ActiveMonthGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ActiveMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActiveMonthDataSet = New KSoft_Apparel.ActiveMonthDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYearNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonthNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActiveMonthTableAdapter = New KSoft_Apparel.ActiveMonthDataSetTableAdapters.ActiveMonthTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ActiveMonthDataSetTableAdapters.TableAdapterManager()
        Me.ActiveMonthBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ActiveMonthBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ActiveMonthGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveMonthBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActiveMonthBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(569, 626)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ActiveMonthGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(809, 626)
        Me.SplitContainer1.SplitterDistance = 236
        Me.SplitContainer1.TabIndex = 1
        '
        'ActiveMonthGridControl
        '
        Me.ActiveMonthGridControl.DataSource = Me.ActiveMonthBindingSource
        Me.ActiveMonthGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActiveMonthGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ActiveMonthGridControl.MainView = Me.GridView1
        Me.ActiveMonthGridControl.Name = "ActiveMonthGridControl"
        Me.ActiveMonthGridControl.Size = New System.Drawing.Size(236, 626)
        Me.ActiveMonthGridControl.TabIndex = 0
        Me.ActiveMonthGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ActiveMonthBindingSource
        '
        Me.ActiveMonthBindingSource.DataMember = "ActiveMonth"
        Me.ActiveMonthBindingSource.DataSource = Me.ActiveMonthDataSet
        '
        'ActiveMonthDataSet
        '
        Me.ActiveMonthDataSet.DataSetName = "ActiveMonthDataSet"
        Me.ActiveMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYearNo, Me.colMonthNo, Me.colActive})
        Me.GridView1.GridControl = Me.ActiveMonthGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colYearNo
        '
        Me.colYearNo.FieldName = "YearNo"
        Me.colYearNo.Name = "colYearNo"
        Me.colYearNo.Visible = True
        Me.colYearNo.VisibleIndex = 0
        '
        'colMonthNo
        '
        Me.colMonthNo.FieldName = "MonthNo"
        Me.colMonthNo.Name = "colMonthNo"
        Me.colMonthNo.Visible = True
        Me.colMonthNo.VisibleIndex = 1
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 2
        '
        'ActiveMonthTableAdapter
        '
        Me.ActiveMonthTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActiveMonthTableAdapter = Me.ActiveMonthTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActiveMonthDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActiveMonthBindingNavigator
        '
        Me.ActiveMonthBindingNavigator.AddNewItem = Nothing
        Me.ActiveMonthBindingNavigator.BindingSource = Me.ActiveMonthBindingSource
        Me.ActiveMonthBindingNavigator.CountItem = Nothing
        Me.ActiveMonthBindingNavigator.DeleteItem = Nothing
        Me.ActiveMonthBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveMonthBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.ActiveMonthBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActiveMonthBindingNavigator.MoveFirstItem = Nothing
        Me.ActiveMonthBindingNavigator.MoveLastItem = Nothing
        Me.ActiveMonthBindingNavigator.MoveNextItem = Nothing
        Me.ActiveMonthBindingNavigator.MovePreviousItem = Nothing
        Me.ActiveMonthBindingNavigator.Name = "ActiveMonthBindingNavigator"
        Me.ActiveMonthBindingNavigator.PositionItem = Nothing
        Me.ActiveMonthBindingNavigator.Size = New System.Drawing.Size(809, 25)
        Me.ActiveMonthBindingNavigator.TabIndex = 2
        Me.ActiveMonthBindingNavigator.Text = "BindingNavigator1"
        '
        'ActiveMonthBindingNavigatorSaveItem
        '
        Me.ActiveMonthBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActiveMonthBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActiveMonthBindingNavigatorSaveItem.Name = "ActiveMonthBindingNavigatorSaveItem"
        Me.ActiveMonthBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ActiveMonthBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButton1.Text = "Show Report"
        '
        'frmMonthlyEfficiencyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 648)
        Me.Controls.Add(Me.ActiveMonthBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmMonthlyEfficiencyReport"
        Me.Text = "Monthly Efficiency Report"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ActiveMonthGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveMonthBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActiveMonthBindingNavigator.ResumeLayout(False)
        Me.ActiveMonthBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ActiveMonthDataSet As ActiveMonthDataSet
    Friend WithEvents ActiveMonthBindingSource As BindingSource
    Friend WithEvents ActiveMonthTableAdapter As ActiveMonthDataSetTableAdapters.ActiveMonthTableAdapter
    Friend WithEvents TableAdapterManager As ActiveMonthDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActiveMonthBindingNavigator As BindingNavigator
    Friend WithEvents ActiveMonthBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ActiveMonthGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYearNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonthNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
