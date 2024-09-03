<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMailingAddress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MailAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailAddressDataSet = New KSoft_Apparel.EmailAddressDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMailAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMailType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMobileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MailAddressTableAdapter = New KSoft_Apparel.EmailAddressDataSetTableAdapters.MailAddressTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SendProdMailButton = New System.Windows.Forms.Button()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmailHostTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SSLCheckBox = New System.Windows.Forms.CheckBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.SendProdSMSButton = New System.Windows.Forms.Button()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.PrintSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SelectAllButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailAddressDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.MailAddressBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 29)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(926, 408)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MailAddressBindingSource
        '
        Me.MailAddressBindingSource.DataMember = "MailAddress"
        Me.MailAddressBindingSource.DataSource = Me.EmailAddressDataSet
        '
        'EmailAddressDataSet
        '
        Me.EmailAddressDataSet.DataSetName = "EmailAddressDataSet"
        Me.EmailAddressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMailAddress, Me.colMailType, Me.colIsActive, Me.colMobileNo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colMailAddress
        '
        Me.colMailAddress.FieldName = "MailAddress"
        Me.colMailAddress.Name = "colMailAddress"
        Me.colMailAddress.Visible = True
        Me.colMailAddress.VisibleIndex = 0
        Me.colMailAddress.Width = 171
        '
        'colMailType
        '
        Me.colMailType.FieldName = "MailType"
        Me.colMailType.Name = "colMailType"
        Me.colMailType.Visible = True
        Me.colMailType.VisibleIndex = 1
        Me.colMailType.Width = 184
        '
        'colIsActive
        '
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.Visible = True
        Me.colIsActive.VisibleIndex = 3
        Me.colIsActive.Width = 114
        '
        'colMobileNo
        '
        Me.colMobileNo.FieldName = "MobileNo"
        Me.colMobileNo.Name = "colMobileNo"
        Me.colMobileNo.Visible = True
        Me.colMobileNo.VisibleIndex = 2
        Me.colMobileNo.Width = 139
        '
        'MailAddressTableAdapter
        '
        Me.MailAddressTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(7, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SendProdMailButton
        '
        Me.SendProdMailButton.Location = New System.Drawing.Point(249, 2)
        Me.SendProdMailButton.Name = "SendProdMailButton"
        Me.SendProdMailButton.Size = New System.Drawing.Size(128, 23)
        Me.SendProdMailButton.TabIndex = 1
        Me.SendProdMailButton.Text = "Send Production Mail"
        Me.SendProdMailButton.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(110, 30)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(297, 20)
        Me.EmailTextBox.TabIndex = 2
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(110, 56)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(297, 20)
        Me.PassTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Email Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PassTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 450)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.EmailHostTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.SSLCheckBox)
        Me.GroupBox2.Controls.Add(Me.PortTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(481, 450)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuration"
        '
        'EmailHostTextBox
        '
        Me.EmailHostTextBox.Location = New System.Drawing.Point(94, 30)
        Me.EmailHostTextBox.Name = "EmailHostTextBox"
        Me.EmailHostTextBox.Size = New System.Drawing.Size(273, 20)
        Me.EmailHostTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Host"
        '
        'SSLCheckBox
        '
        Me.SSLCheckBox.AutoSize = True
        Me.SSLCheckBox.Location = New System.Drawing.Point(151, 59)
        Me.SSLCheckBox.Name = "SSLCheckBox"
        Me.SSLCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.SSLCheckBox.TabIndex = 2
        Me.SSLCheckBox.Text = "SSL"
        Me.SSLCheckBox.UseVisualStyleBackColor = True
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(94, 57)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(42, 20)
        Me.PortTextBox.TabIndex = 1
        '
        'SendProdSMSButton
        '
        Me.SendProdSMSButton.Location = New System.Drawing.Point(383, 2)
        Me.SendProdSMSButton.Name = "SendProdSMSButton"
        Me.SendProdSMSButton.Size = New System.Drawing.Size(133, 23)
        Me.SendProdSMSButton.TabIndex = 1
        Me.SendProdSMSButton.Text = "Send Production SMS"
        Me.SendProdSMSButton.UseVisualStyleBackColor = True
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(88, 3)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Size = New System.Drawing.Size(155, 20)
        Me.DateEdit1.TabIndex = 7
        '
        'PrintSimpleButton
        '
        Me.PrintSimpleButton.Location = New System.Drawing.Point(522, 2)
        Me.PrintSimpleButton.Name = "PrintSimpleButton"
        Me.PrintSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintSimpleButton.TabIndex = 8
        Me.PrintSimpleButton.Text = "&Print"
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectAllButton.Location = New System.Drawing.Point(820, 2)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectAllButton.TabIndex = 8
        Me.SelectAllButton.Text = "&Select All"
        '
        'frmMailingAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 562)
        Me.Controls.Add(Me.SelectAllButton)
        Me.Controls.Add(Me.PrintSimpleButton)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SendProdSMSButton)
        Me.Controls.Add(Me.SendProdMailButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmMailingAddress"
        Me.Text = "Mailing Address"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailAddressDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmailAddressDataSet As EmailAddressDataSet
    Friend WithEvents MailAddressBindingSource As BindingSource
    Friend WithEvents MailAddressTableAdapter As EmailAddressDataSetTableAdapters.MailAddressTableAdapter
    Friend WithEvents colMailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMailType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveButton As Button
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMobileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendProdMailButton As Button
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PortTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SSLCheckBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SendProdSMSButton As Button
    Friend WithEvents EmailHostTextBox As TextBox
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PrintSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SelectAllButton As DevExpress.XtraEditors.SimpleButton
End Class
