<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicture
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
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FRStyleProcessTableAdapter = Nothing
        Me.TableAdapterManager.StyleNameMstTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Me.StyleTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StyleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(0, 0)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PicturePictureEdit.Size = New System.Drawing.Size(561, 475)
        Me.PicturePictureEdit.TabIndex = 2
        '
        'frmPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 473)
        Me.Controls.Add(Me.PicturePictureEdit)
        Me.Name = "frmPicture"
        Me.Text = "Picture"
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleDataSet As StyleDataSet
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleTableAdapter As StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents TableAdapterManager As StyleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
End Class
