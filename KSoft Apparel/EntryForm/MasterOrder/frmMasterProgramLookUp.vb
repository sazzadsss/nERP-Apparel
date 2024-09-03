Public Class frmMasterProgramLookUp

    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property


    Private Sub frmMasterProgramLookUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim PrgCode As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)
        Me.MasterProgramLookUpTableAdapter.FillByProgramCodeAndUser(Me.MasterProgramLookUpDataSet.MasterProgramLookUp, PrgCode, UserId)

    End Sub



    Private Sub MasterProgramLookUpGridControl_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MasterProgramLookUpGridControl.MouseDoubleClick

        If Me.MasterProgramLookUpBindingSource.Position > -1 Then

            Dim row As MasterProgramLookUpDataSet.MasterProgramLookUpRow
            row = CType(CType(Me.MasterProgramLookUpBindingSource.Current, DataRowView).Row, MasterProgramLookUpDataSet.MasterProgramLookUpRow)

            frmOrderReceived.PrgNo = row.ProgramNo
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If

    End Sub
End Class