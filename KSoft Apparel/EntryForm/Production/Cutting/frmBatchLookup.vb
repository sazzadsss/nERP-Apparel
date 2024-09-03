Public Class frmBatchLookup
    Private _ProgramNo As String
    Public Property ProgramNo() As String
        Get
            Return _ProgramNo
        End Get
        Set(ByVal value As String)
            _ProgramNo = value
        End Set
    End Property
    Private _BatchNo As String
    Public Property BatchNo() As String
        Get
            Return _BatchNo
        End Get
        Set(ByVal value As String)
            _BatchNo = value
        End Set
    End Property

    Private Sub BatchLookupBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BatchLookupBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BatchLookupDataSet)

    End Sub

    Private Sub frmBatchLookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup, Me.ProgramNo)

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        If BatchLookupBindingSource.Position > -1 Then

            Dim row As BatchLookupDataSet.BatchLookupRow
            row = CType(CType(Me.BatchLookupBindingSource.Current, DataRowView).Row, BatchLookupDataSet.BatchLookupRow)

            frmCuttingProductionNew.pBatchNo = row.BatchNo
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If

        Me.Close()

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class