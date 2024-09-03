<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingTargetList
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
        Dim PictureLabel As System.Windows.Forms.Label
        Me.StylewiseSewingTargetDataSet = New KSoft_Apparel.StylewiseSewingTargetDataSet()
        Me.StylewiseTargetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StylewiseTargetTableAdapter = New KSoft_Apparel.StylewiseSewingTargetDataSetTableAdapters.StylewiseTargetTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.StylewiseSewingTargetDataSetTableAdapters.TableAdapterManager()
        Me.StylewiseTargetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ExporttoXLSLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.StyleNameLabel1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Machine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Manual = New DevExpress.XtraGrid.Columns.GridColumn()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.StylewiseSewingTargetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StylewiseTargetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StylewiseTargetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureLabel
        '
        PictureLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(1087, 46)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(64, 13)
        PictureLabel.TabIndex = 2
        PictureLabel.Text = "Picture For :"
        '
        'StylewiseSewingTargetDataSet
        '
        Me.StylewiseSewingTargetDataSet.DataSetName = "StylewiseSewingTargetDataSet"
        Me.StylewiseSewingTargetDataSet.EnforceConstraints = False
        Me.StylewiseSewingTargetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StylewiseTargetBindingSource
        '
        Me.StylewiseTargetBindingSource.DataMember = "StylewiseTarget"
        Me.StylewiseTargetBindingSource.DataSource = Me.StylewiseSewingTargetDataSet
        '
        'StylewiseTargetTableAdapter
        '
        Me.StylewiseTargetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StylewiseSewingTargetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StylewiseTargetGridControl
        '
        Me.StylewiseTargetGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StylewiseTargetGridControl.DataSource = Me.StylewiseTargetBindingSource
        Me.StylewiseTargetGridControl.Location = New System.Drawing.Point(15, 38)
        Me.StylewiseTargetGridControl.LookAndFeel.SkinName = "Money Twins"
        Me.StylewiseTargetGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StylewiseTargetGridControl.MainView = Me.GridView1
        Me.StylewiseTargetGridControl.Name = "StylewiseTargetGridControl"
        Me.StylewiseTargetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.StylewiseTargetGridControl.Size = New System.Drawing.Size(1055, 480)
        Me.StylewiseTargetGridControl.TabIndex = 1
        Me.StylewiseTargetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.PeachPuff
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName, Me.colMachineQuantity, Me.colOrderQuantity, Me.colTotalTargetQuantity, Me.colPicture, Me.colSMV, Me.colTotalSMV_Machine, Me.colTotalSMV_Manual})
        Me.GridView1.GridControl = Me.StylewiseTargetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 30
        '
        'colStyleName
        '
        Me.colStyleName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleName.Caption = "Style"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsColumn.AllowEdit = False
        Me.colStyleName.OptionsColumn.ReadOnly = True
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 1
        Me.colStyleName.Width = 185
        '
        'colMachineQuantity
        '
        Me.colMachineQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colMachineQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMachineQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMachineQuantity.Caption = "Machine"
        Me.colMachineQuantity.FieldName = "MachineQuantity"
        Me.colMachineQuantity.Name = "colMachineQuantity"
        Me.colMachineQuantity.OptionsColumn.AllowEdit = False
        Me.colMachineQuantity.OptionsColumn.ReadOnly = True
        Me.colMachineQuantity.Visible = True
        Me.colMachineQuantity.VisibleIndex = 2
        Me.colMachineQuantity.Width = 98
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.Caption = "Allocation Quantity"
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 3
        Me.colOrderQuantity.Width = 108
        '
        'colTotalTargetQuantity
        '
        Me.colTotalTargetQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalTargetQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalTargetQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalTargetQuantity.Caption = "Normal Target "
        Me.colTotalTargetQuantity.FieldName = "TotalTargetQuantity"
        Me.colTotalTargetQuantity.Name = "colTotalTargetQuantity"
        Me.colTotalTargetQuantity.OptionsColumn.AllowEdit = False
        Me.colTotalTargetQuantity.OptionsColumn.ReadOnly = True
        Me.colTotalTargetQuantity.Visible = True
        Me.colTotalTargetQuantity.VisibleIndex = 4
        Me.colTotalTargetQuantity.Width = 77
        '
        'colPicture
        '
        Me.colPicture.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.colPicture.AppearanceCell.Options.UseForeColor = True
        Me.colPicture.AppearanceHeader.Options.UseTextOptions = True
        Me.colPicture.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPicture.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPicture.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.OptionsColumn.ReadOnly = True
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 0
        Me.colPicture.Width = 80
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.StylewiseTargetGridControl
        Me.GridView2.Name = "GridView2"
        '
        'ExporttoXLSLinkLabel
        '
        Me.ExporttoXLSLinkLabel.Image = Global.KSoft_Apparel.My.Resources.Resources.Text_Document_icon
        Me.ExporttoXLSLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExporttoXLSLinkLabel.Location = New System.Drawing.Point(12, 6)
        Me.ExporttoXLSLinkLabel.Name = "ExporttoXLSLinkLabel"
        Me.ExporttoXLSLinkLabel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ExporttoXLSLinkLabel.Size = New System.Drawing.Size(91, 23)
        Me.ExporttoXLSLinkLabel.TabIndex = 2
        Me.ExporttoXLSLinkLabel.TabStop = True
        Me.ExporttoXLSLinkLabel.Text = "Export"
        Me.ExporttoXLSLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StylewiseTargetBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(1090, 72)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Size = New System.Drawing.Size(203, 191)
        Me.PicturePictureEdit.TabIndex = 3
        '
        'StyleNameLabel1
        '
        Me.StyleNameLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StyleNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StylewiseTargetBindingSource, "StyleName", True))
        Me.StyleNameLabel1.Location = New System.Drawing.Point(1142, 47)
        Me.StyleNameLabel1.Name = "StyleNameLabel1"
        Me.StyleNameLabel1.Size = New System.Drawing.Size(136, 22)
        Me.StyleNameLabel1.TabIndex = 5
        Me.StyleNameLabel1.Text = "-"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(90, 6)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 6
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        Me.colSMV.Visible = True
        Me.colSMV.VisibleIndex = 5
        '
        'colTotalSMV_Machine
        '
        Me.colTotalSMV_Machine.FieldName = "TotalSMV_Machine"
        Me.colTotalSMV_Machine.Name = "colTotalSMV_Machine"
        Me.colTotalSMV_Machine.Visible = True
        Me.colTotalSMV_Machine.VisibleIndex = 6
        '
        'colTotalSMV_Manual
        '
        Me.colTotalSMV_Manual.FieldName = "TotalSMV_Manual"
        Me.colTotalSMV_Manual.Name = "colTotalSMV_Manual"
        Me.colTotalSMV_Manual.Visible = True
        Me.colTotalSMV_Manual.VisibleIndex = 7
        '
        'frmSewingTargetList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 530)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.StyleNameLabel1)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PicturePictureEdit)
        Me.Controls.Add(Me.ExporttoXLSLinkLabel)
        Me.Controls.Add(Me.StylewiseTargetGridControl)
        Me.Name = "frmSewingTargetList"
        Me.Text = "Sewing Target List"
        CType(Me.StylewiseSewingTargetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StylewiseTargetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StylewiseTargetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StylewiseSewingTargetDataSet As KSoft_Apparel.StylewiseSewingTargetDataSet
    Friend WithEvents StylewiseTargetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StylewiseTargetTableAdapter As KSoft_Apparel.StylewiseSewingTargetDataSetTableAdapters.StylewiseTargetTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.StylewiseSewingTargetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StylewiseTargetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExporttoXLSLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents StyleNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Machine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Manual As DevExpress.XtraGrid.Columns.GridColumn
End Class
