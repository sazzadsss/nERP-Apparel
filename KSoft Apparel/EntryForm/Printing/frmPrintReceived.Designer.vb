<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintReceived
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintReceived))
        Dim PrintingReceiveIdLabel As System.Windows.Forms.Label
        Dim ReceivedDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim ModifiedOnLabel As System.Windows.Forms.Label
        Me.UserIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ModifiedOnGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PrintingReceivedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.PrintingReceivedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ReceivedDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.UserIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ModifiedOnGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.PrintingReceiveIdTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.PrintingReceivedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintReceivedDataSet = New KSoft_Apparel.PrintReceivedDataSet
        Me.PrintingReceivedTableAdapter = New KSoft_Apparel.PrintReceivedDataSetTableAdapters.PrintingReceivedTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintReceivedDataSetTableAdapters.TableAdapterManager
        Me.PrintingReceivedDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingReceivedDetailsTableAdapter = New KSoft_Apparel.PrintReceivedDataSetTableAdapters.PrintingReceivedDetailsTableAdapter
        Me.PrintingReceivedDetailsGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPrintOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceiveQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UserDataSet = New KSoft_Apparel.UserDataSet
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
        PrintingReceiveIdLabel = New System.Windows.Forms.Label
        ReceivedDateLabel = New System.Windows.Forms.Label
        RemarksLabel = New System.Windows.Forms.Label
        UserIdLabel = New System.Windows.Forms.Label
        ModifiedOnLabel = New System.Windows.Forms.Label
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedOnGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingReceivedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintingReceivedBindingNavigator.SuspendLayout()
        CType(Me.ReceivedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedOnGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingReceiveIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingReceivedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintReceivedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingReceivedDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingReceivedDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIdGridLookUpEditView
        '
        Me.UserIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UserIdGridLookUpEditView.Name = "UserIdGridLookUpEditView"
        Me.UserIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UserIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'ModifiedOnGridLookUpEditView
        '
        Me.ModifiedOnGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ModifiedOnGridLookUpEditView.Name = "ModifiedOnGridLookUpEditView"
        Me.ModifiedOnGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ModifiedOnGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'PrintingReceivedBindingNavigator
        '
        Me.PrintingReceivedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintingReceivedBindingNavigator.BindingSource = Me.PrintingReceivedBindingSource
        Me.PrintingReceivedBindingNavigator.CountItem = Nothing
        Me.PrintingReceivedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrintingReceivedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrintingReceivedBindingNavigatorSaveItem})
        Me.PrintingReceivedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrintingReceivedBindingNavigator.MoveFirstItem = Nothing
        Me.PrintingReceivedBindingNavigator.MoveLastItem = Nothing
        Me.PrintingReceivedBindingNavigator.MoveNextItem = Nothing
        Me.PrintingReceivedBindingNavigator.MovePreviousItem = Nothing
        Me.PrintingReceivedBindingNavigator.Name = "PrintingReceivedBindingNavigator"
        Me.PrintingReceivedBindingNavigator.PositionItem = Nothing
        Me.PrintingReceivedBindingNavigator.Size = New System.Drawing.Size(848, 25)
        Me.PrintingReceivedBindingNavigator.TabIndex = 0
        Me.PrintingReceivedBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PrintingReceivedBindingNavigatorSaveItem
        '
        Me.PrintingReceivedBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintingReceivedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintingReceivedBindingNavigatorSaveItem.Name = "PrintingReceivedBindingNavigatorSaveItem"
        Me.PrintingReceivedBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PrintingReceivedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintingReceiveIdLabel
        '
        PrintingReceiveIdLabel.AutoSize = True
        PrintingReceiveIdLabel.Location = New System.Drawing.Point(23, 24)
        PrintingReceiveIdLabel.Name = "PrintingReceiveIdLabel"
        PrintingReceiveIdLabel.Size = New System.Drawing.Size(108, 13)
        PrintingReceiveIdLabel.TabIndex = 1
        PrintingReceiveIdLabel.Text = "Printing Receive No :"
        '
        'ReceivedDateLabel
        '
        ReceivedDateLabel.AutoSize = True
        ReceivedDateLabel.Location = New System.Drawing.Point(23, 50)
        ReceivedDateLabel.Name = "ReceivedDateLabel"
        ReceivedDateLabel.Size = New System.Drawing.Size(82, 13)
        ReceivedDateLabel.TabIndex = 3
        ReceivedDateLabel.Text = "Received Date:"
        '
        'ReceivedDateDateEdit
        '
        Me.ReceivedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingReceivedBindingSource, "ReceivedDate", True))
        Me.ReceivedDateDateEdit.EditValue = Nothing
        Me.ReceivedDateDateEdit.Location = New System.Drawing.Point(134, 47)
        Me.ReceivedDateDateEdit.Name = "ReceivedDateDateEdit"
        Me.ReceivedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReceivedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ReceivedDateDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.ReceivedDateDateEdit.TabIndex = 4
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(23, 76)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 5
        RemarksLabel.Text = "Remarks:"
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingReceivedBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(134, 73)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(352, 20)
        Me.RemarksTextEdit.TabIndex = 6
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(280, 24)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(35, 13)
        UserIdLabel.TabIndex = 7
        UserIdLabel.Text = "User :"
        '
        'UserIdGridLookUpEdit
        '
        Me.UserIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingReceivedBindingSource, "UserId", True))
        Me.UserIdGridLookUpEdit.Location = New System.Drawing.Point(357, 21)
        Me.UserIdGridLookUpEdit.Name = "UserIdGridLookUpEdit"
        Me.UserIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIdGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserIdGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserIdGridLookUpEdit.Properties.NullText = ""
        Me.UserIdGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserIdGridLookUpEdit.Properties.View = Me.UserIdGridLookUpEditView
        Me.UserIdGridLookUpEdit.Size = New System.Drawing.Size(129, 20)
        Me.UserIdGridLookUpEdit.TabIndex = 8
        '
        'ModifiedOnLabel
        '
        ModifiedOnLabel.AutoSize = True
        ModifiedOnLabel.Location = New System.Drawing.Point(280, 50)
        ModifiedOnLabel.Name = "ModifiedOnLabel"
        ModifiedOnLabel.Size = New System.Drawing.Size(67, 13)
        ModifiedOnLabel.TabIndex = 9
        ModifiedOnLabel.Text = "Modified On:"
        '
        'ModifiedOnGridLookUpEdit
        '
        Me.ModifiedOnGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingReceivedBindingSource, "ModifiedOn", True))
        Me.ModifiedOnGridLookUpEdit.Location = New System.Drawing.Point(357, 47)
        Me.ModifiedOnGridLookUpEdit.Name = "ModifiedOnGridLookUpEdit"
        Me.ModifiedOnGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifiedOnGridLookUpEdit.Properties.NullText = ""
        Me.ModifiedOnGridLookUpEdit.Properties.View = Me.ModifiedOnGridLookUpEditView
        Me.ModifiedOnGridLookUpEdit.Size = New System.Drawing.Size(129, 20)
        Me.ModifiedOnGridLookUpEdit.TabIndex = 10
        '
        'PrintingReceiveIdTextEdit
        '
        Me.PrintingReceiveIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingReceivedBindingSource, "PrintingReceiveId", True))
        Me.PrintingReceiveIdTextEdit.Location = New System.Drawing.Point(134, 21)
        Me.PrintingReceiveIdTextEdit.Name = "PrintingReceiveIdTextEdit"
        Me.PrintingReceiveIdTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PrintingReceiveIdTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PrintingReceiveIdTextEdit.Size = New System.Drawing.Size(118, 20)
        Me.PrintingReceiveIdTextEdit.TabIndex = 11
        '
        'PrintingReceivedBindingSource
        '
        Me.PrintingReceivedBindingSource.DataMember = "PrintingReceived"
        Me.PrintingReceivedBindingSource.DataSource = Me.PrintReceivedDataSet
        '
        'PrintReceivedDataSet
        '
        Me.PrintReceivedDataSet.DataSetName = "PrintReceivedDataSet"
        Me.PrintReceivedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintingReceivedTableAdapter
        '
        Me.PrintingReceivedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintingReceivedDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PrintingReceivedTableAdapter = Me.PrintingReceivedTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintReceivedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintingReceivedDetailsBindingSource
        '
        Me.PrintingReceivedDetailsBindingSource.DataMember = "FK_PrintingReceivedDetails_PrintingReceived"
        Me.PrintingReceivedDetailsBindingSource.DataSource = Me.PrintingReceivedBindingSource
        '
        'PrintingReceivedDetailsTableAdapter
        '
        Me.PrintingReceivedDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintingReceivedDetailsGridControl
        '
        Me.PrintingReceivedDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintingReceivedDetailsGridControl.DataSource = Me.PrintingReceivedDetailsBindingSource
        Me.PrintingReceivedDetailsGridControl.Location = New System.Drawing.Point(12, 155)
        Me.PrintingReceivedDetailsGridControl.MainView = Me.GridView1
        Me.PrintingReceivedDetailsGridControl.Name = "PrintingReceivedDetailsGridControl"
        Me.PrintingReceivedDetailsGridControl.Size = New System.Drawing.Size(824, 267)
        Me.PrintingReceivedDetailsGridControl.TabIndex = 11
        Me.PrintingReceivedDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintOrderId, Me.colReceiveQuantity, Me.colRemarks})
        Me.GridView1.GridControl = Me.PrintingReceivedDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.PrintingReceivedDetailsGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colPrintOrderId
        '
        Me.colPrintOrderId.Caption = "Print Order"
        Me.colPrintOrderId.FieldName = "PrintOrderId"
        Me.colPrintOrderId.Name = "colPrintOrderId"
        Me.colPrintOrderId.Visible = True
        Me.colPrintOrderId.VisibleIndex = 0
        Me.colPrintOrderId.Width = 83
        '
        'colReceiveQuantity
        '
        Me.colReceiveQuantity.FieldName = "ReceiveQuantity"
        Me.colReceiveQuantity.Name = "colReceiveQuantity"
        Me.colReceiveQuantity.Visible = True
        Me.colReceiveQuantity.VisibleIndex = 1
        Me.colReceiveQuantity.Width = 134
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        Me.colRemarks.Width = 458
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PrintingReceiveIdTextEdit)
        Me.GroupBox1.Controls.Add(PrintingReceiveIdLabel)
        Me.GroupBox1.Controls.Add(ReceivedDateLabel)
        Me.GroupBox1.Controls.Add(Me.ReceivedDateDateEdit)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextEdit)
        Me.GroupBox1.Controls.Add(UserIdLabel)
        Me.GroupBox1.Controls.Add(Me.UserIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(ModifiedOnLabel)
        Me.GroupBox1.Controls.Add(Me.ModifiedOnGridLookUpEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 104)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gate Pass Main Information"
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'frmPrintReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PrintingReceivedDetailsGridControl)
        Me.Controls.Add(Me.PrintingReceivedBindingNavigator)
        Me.Name = "frmPrintReceived"
        Me.Text = "Print Received"
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedOnGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingReceivedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintingReceivedBindingNavigator.ResumeLayout(False)
        Me.PrintingReceivedBindingNavigator.PerformLayout()
        CType(Me.ReceivedDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedOnGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingReceiveIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingReceivedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintReceivedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingReceivedDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingReceivedDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintReceivedDataSet As KSoft_Apparel.PrintReceivedDataSet
    Friend WithEvents PrintingReceivedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintingReceivedTableAdapter As KSoft_Apparel.PrintReceivedDataSetTableAdapters.PrintingReceivedTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintReceivedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ModifiedOnGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintingReceivedBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintingReceivedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReceivedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ModifiedOnGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PrintingReceiveIdTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintingReceivedDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintingReceivedDetailsTableAdapter As KSoft_Apparel.PrintReceivedDataSetTableAdapters.PrintingReceivedDetailsTableAdapter
    Friend WithEvents PrintingReceivedDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
End Class
