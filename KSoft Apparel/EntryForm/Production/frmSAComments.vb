Public Class frmSAComments
    Private _SADate As Date
    Private _BranchId As Integer
    Public Property SADate() As Date
        Get
            Return _SADate
        End Get
        Set(ByVal value As Date)
            _SADate = value
        End Set
    End Property
    Public Property BranchId() As Integer
        Get
            Return _BranchId
        End Get
        Set(ByVal value As Integer)
            _BranchId = value
        End Set
    End Property

    
   
    Private Sub frmSAComments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingAttendanceCommentsTableAdapter.Fill(Me.SewingAttendanceDataSet.SewingAttendanceComments, Me.SADate, Me.BranchId)

        Me.SewingAttendanceDataSet.SewingAttendanceComments.SADateColumn.DefaultValue = Me.SADate
        Me.SewingAttendanceDataSet.SewingAttendanceComments.BranchIdColumn.DefaultValue = Me.BranchId

        If Me.SewingAttendanceCommentsBindingSource.Position = -1 Then

            Me.SewingAttendanceCommentsBindingSource.AddNew()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Validate()
        Me.SewingAttendanceCommentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingAttendanceDataSet)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()



    End Sub
End Class