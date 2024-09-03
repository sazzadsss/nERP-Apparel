<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlow
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
        Me.OrderSummeryGroupControl = New DevExpress.XtraEditors.GroupControl
        CType(Me.OrderSummeryGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderSummeryGroupControl
        '
        Me.OrderSummeryGroupControl.Location = New System.Drawing.Point(27, 23)
        Me.OrderSummeryGroupControl.Name = "OrderSummeryGroupControl"
        Me.OrderSummeryGroupControl.Size = New System.Drawing.Size(303, 163)
        Me.OrderSummeryGroupControl.TabIndex = 0
        Me.OrderSummeryGroupControl.Text = "GroupControl1"
        '
        'frmFlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 458)
        Me.Controls.Add(Me.OrderSummeryGroupControl)
        Me.Name = "frmFlow"
        Me.Text = "Order Information"
        CType(Me.OrderSummeryGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderSummeryGroupControl As DevExpress.XtraEditors.GroupControl
End Class
