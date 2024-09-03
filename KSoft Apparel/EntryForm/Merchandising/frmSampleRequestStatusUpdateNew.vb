Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen


Public Class frmSampleRequestStatusUpdateNew
    Private _MISFlag As Boolean
    Public Property MISFlag() As Boolean
        Get
            Return _MISFlag
        End Get
        Set(ByVal value As Boolean)
            _MISFlag = value
        End Set
    End Property
    Private Sub frmSampleRequestStatusUpdateNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SampleRequestLookupDataSet.SampleRequestNoLookup' table. You can move, or remove it, as needed [Blank Show].

        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)

        Me.SampleRequestStatusTableAdapter.SetCommandTimeOut(60000)

        'For Show Running
        'Me.SampleRequestStatusTableAdapter.FillByRunning(Me.SampleRequestStatusDataSet.SampleRequestStatus)

        'For Show All
        'Me.SampleRequestStatusTableAdapter.Fill(Me.SampleRequestStatusDataSet.SampleRequestStatus)

        If Me.MISFlag = True Then
            SaveButton.Enabled = False
        Else
            SaveButton.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        Me.SampleRequestStatusTableAdapter.SetCommandTimeOut(60000)
        If Me.MISFlag = True Then
            Me.SampleRequestStatusTableAdapter.Fill(Me.SampleRequestStatusDataSet.SampleRequestStatus)
        Else
            Me.SampleRequestStatusTableAdapter.FillByAllAndUser(Me.SampleRequestStatusDataSet.SampleRequestStatus, UserId)
        End If

        SplashScreenManager.CloseForm(False)
    End Sub


    Private Sub BandedGridView1_DoubleClick(sender As Object, e As EventArgs) Handles BandedGridView1.DoubleClick

        Dim row As SampleRequestStatusDataSet.SampleRequestStatusRow
        row = CType(CType(Me.SampleRequestStatusBindingSource.Current, DataRowView).Row, SampleRequestStatusDataSet.SampleRequestStatusRow)

        If BandedGridView1.FocusedColumn.Caption = "Buyer" Or BandedGridView1.FocusedColumn.Caption = "Style" Or BandedGridView1.FocusedColumn.Caption = "Sample Program No" Or BandedGridView1.FocusedColumn.Caption = "Sample Program Date" Or BandedGridView1.FocusedColumn.Caption = "Division" Or BandedGridView1.FocusedColumn.Caption = "Season" Or BandedGridView1.FocusedColumn.Caption = "Brand/Group" Or BandedGridView1.FocusedColumn.Caption = "Sample Require Date" Or BandedGridView1.FocusedColumn.Caption = "Fabric Require Date" Or BandedGridView1.FocusedColumn.Caption = "Sample Fabric Booking Date" Or BandedGridView1.FocusedColumn.Caption = "Sample Fabric Booking Complete" Or BandedGridView1.FocusedColumn.Caption = "Revised No" Or BandedGridView1.FocusedColumn.Caption = "Revised Date" Or BandedGridView1.FocusedColumn.Caption = "Cause Of Revised" Or BandedGridView1.FocusedColumn.Caption = "Sample Fabric Booking Remarks" Or BandedGridView1.FocusedColumn.Caption = "NLD No" Or BandedGridView1.FocusedColumn.Caption = "Attention" Or BandedGridView1.FocusedColumn.Caption = "CC" Or BandedGridView1.FocusedColumn.Caption = "Is Receive By Dyeing" Or BandedGridView1.FocusedColumn.Caption = "Style Type" Or BandedGridView1.FocusedColumn.Caption = "Style Description" Or BandedGridView1.FocusedColumn.Caption = "Garments Color" Or BandedGridView1.FocusedColumn.Caption = "GSM" Or BandedGridView1.FocusedColumn.Caption = "Fabric Details" Or BandedGridView1.FocusedColumn.Caption = "Knitting Type" Or BandedGridView1.FocusedColumn.Caption = "Composition" Or BandedGridView1.FocusedColumn.Caption = "Sample Type" Or BandedGridView1.FocusedColumn.Caption = "Sample Size" Or BandedGridView1.FocusedColumn.Caption = "Sample Qty" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Required Qty" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Required Qty" Or BandedGridView1.FocusedColumn.Caption = "Merchandiser" Or BandedGridView1.FocusedColumn.Caption = "Shade Name" Or BandedGridView1.FocusedColumn.Caption = "Is Fabric Available" Or BandedGridView1.FocusedColumn.Caption = "Fabric Type" Then

            With frmSampleOrder_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "First Sample Delivery Date" Or BandedGridView1.FocusedColumn.Caption = "Last Sample Delivery Date" Or BandedGridView1.FocusedColumn.Caption = "Sample Delivery Qty" Or BandedGridView1.FocusedColumn.Caption = "Sample Gate Pass Type" Then

            With frmSampleGatePass_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Yarn Issue Qty" Or BandedGridView1.FocusedColumn.Caption = "Yarn Issue Bal Qty" Or BandedGridView1.FocusedColumn.Caption = "Yarn Require Qty" Or BandedGridView1.FocusedColumn.Caption = "Yarn Details" Or BandedGridView1.FocusedColumn.Caption = "Yarn Brand" Or BandedGridView1.FocusedColumn.Caption = "Yarn Lot" Then

            With frmYarnIssue_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Yarn Delivery Challan No" Or BandedGridView1.FocusedColumn.Caption = "First Yarn Delivery Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last Yarn Delivery Challan Date" Then

            With frmYarnDelivery_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "First Yarn Requisition Date" Or BandedGridView1.FocusedColumn.Caption = "Last Yarn Requisition Date" Or BandedGridView1.FocusedColumn.Caption = "Yarn Requisition No" Then

            With frmYarnRequisition_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Stitch Length" Or BandedGridView1.FocusedColumn.Caption = "MC Dia" Or BandedGridView1.FocusedColumn.Caption = "MC Gauge" Then

            With frmKnittingWorkOrder_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Knitting Production Qty" Then

            With frmKnittingProduction_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "GFI Delivery Qty" Or BandedGridView1.FocusedColumn.Caption = "GFI Delivery Challan No" Or BandedGridView1.FocusedColumn.Caption = "First GFI Delivery Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last GFI Delivery Challan Date" Then

            With frmGFIDelivey_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Grey Fabric Rcv Qty" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Rcv Bal Qty" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Rcv Challan No" Or BandedGridView1.FocusedColumn.Caption = "First Grey Fabric Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "Last Grey Fabric Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Issue Qty" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Issue Bal Qty" Or BandedGridView1.FocusedColumn.Caption = "Grey Fabric Issue Challan No" Or BandedGridView1.FocusedColumn.Caption = "First Grey Fabric Delivery Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last Grey Fabric Delivery Challan Date" Then

            With frmGreyFabricReceiveIssue_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With


        ElseIf BandedGridView1.FocusedColumn.Caption = "First FF Recv Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last FF Recv Challan Date" Or BandedGridView1.FocusedColumn.Caption = "FF Recv Challan No" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Recv Qty" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Recv Bal Qty" Or BandedGridView1.FocusedColumn.Caption = "First FF Delivery Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last FF Delivery Challan Date" Or BandedGridView1.FocusedColumn.Caption = "FF Delivery Challan No" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Issue Qty" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Issue Bal Qty" Or BandedGridView1.FocusedColumn.Caption = "Finish Fabric Delivery Qty" Then

            With frmFinishFabricReceiveIssue_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With



        ElseIf BandedGridView1.FocusedColumn.Caption = "Batch No" Or BandedGridView1.FocusedColumn.Caption = "Batch Qty" Or BandedGridView1.FocusedColumn.Caption = "First Batch Date" Or BandedGridView1.FocusedColumn.Caption = "Last Batch Date" Then

            With frmBatch_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "First Dyeing Date" Or BandedGridView1.FocusedColumn.Caption = "Last Dyeing Date" Or BandedGridView1.FocusedColumn.Caption = "Dyeing Production Qty" Then

            With frmDyeingProduction_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Dyeing Finishing Process" Or BandedGridView1.FocusedColumn.Caption = "First Dyeing Finishing Date" Or BandedGridView1.FocusedColumn.Caption = "Last Dyeing Finishing Date" Or BandedGridView1.FocusedColumn.Caption = "Dyeing Finishing Production Qty" Or BandedGridView1.FocusedColumn.Caption = "Dyeing Finishing QC Status" Then

            With frmDyeingFinishingProduction_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "First LD Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "Last LD Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "First LD Approved Date" Or BandedGridView1.FocusedColumn.Caption = "First Swatch Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "Last Swatch Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "First Fabric Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "Last Fabric Rcv Date" Or BandedGridView1.FocusedColumn.Caption = "First Lab Dip Prepare Date" Or BandedGridView1.FocusedColumn.Caption = "Last Lab Dip Prepare Date" Or BandedGridView1.FocusedColumn.Caption = "Last LD Approved Date" Or BandedGridView1.FocusedColumn.Caption = "First Lap Dip Sent For Floor Date" Or BandedGridView1.FocusedColumn.Caption = "Last Lap Dip Sent For Floor Date" Or BandedGridView1.FocusedColumn.Caption = "First Lab Dip Sent For App Date" Or BandedGridView1.FocusedColumn.Caption = "Last Lab Dip Sent For App Date" Or BandedGridView1.FocusedColumn.Caption = "LD Recipe No" Or BandedGridView1.FocusedColumn.Caption = "TTL LD Cost" Or BandedGridView1.FocusedColumn.Caption = "LD Status" Then

            With frmLabDipStatus_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "QAD Delivey Challan No" Or BandedGridView1.FocusedColumn.Caption = "First QAD Delivey Challan Date" Or BandedGridView1.FocusedColumn.Caption = "Last QAD Delivey Challan Date" Or BandedGridView1.FocusedColumn.Caption = "QAD Delivey Qty" Then

            With frmQADStatus_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "RND Fabric Test No" Or BandedGridView1.FocusedColumn.Caption = "RND Fabric Test Status" Or BandedGridView1.FocusedColumn.Caption = "RND First Fabric Test Date" Or BandedGridView1.FocusedColumn.Caption = "RND Last Fabric Test Date" Or BandedGridView1.FocusedColumn.Caption = "RND First Receive Date" Or BandedGridView1.FocusedColumn.Caption = "RND Last Receive Date" Or BandedGridView1.FocusedColumn.Caption = "RND First Submit Date" Or BandedGridView1.FocusedColumn.Caption = "RND Last Submit Date" Or BandedGridView1.FocusedColumn.Caption = "RND First Approved Date" Or BandedGridView1.FocusedColumn.Caption = "RND Last Approved Date" Then

            With frmRNDStatus_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Artwork" Then

            With frmArtwork_srf

                .StyleId = ReadIntegerData("Select Styleid From [SampleRequestFinal] Where RequestNo='" & row.RequestNo & "'", cnn)
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterParent
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Dyeing Finishing QC Status" Then

            With frmDyeingShadeQC_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        ElseIf BandedGridView1.FocusedColumn.Caption = "Dyeline Batch No" Or BandedGridView1.FocusedColumn.Caption = "Enzime %" Or BandedGridView1.FocusedColumn.Caption = "Softerner %" Or BandedGridView1.FocusedColumn.Caption = "Shade %" Then

            With frmDyeline_srf

                .MdiParent = frmMain
                .PrgNo = row.RequestNo
                .WindowState = FormWindowState.Maximized
                .Show()

            End With




        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Sample Order Tracking Sheet"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                SampleRequestStatusGridControl.ExportToXls(objSaveFileDialog.FileName)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        'For Show Running
        If Me.MISFlag = True Then
            Me.SampleRequestStatusTableAdapter.FillByRunning(Me.SampleRequestStatusDataSet.SampleRequestStatus)
        Else
            Me.SampleRequestStatusTableAdapter.FillByRunningAndUser(Me.SampleRequestStatusDataSet.SampleRequestStatus, UserId)
        End If


        'For Show All
        'Me.SampleRequestStatusTableAdapter.Fill(Me.SampleRequestStatusDataSet.SampleRequestStatus)

        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If Me.SampleRequestStatusBindingSource.Count <> 1 Then
            MessageBox.Show("Please, filter by Sample Request No.")
            Exit Sub
        End If

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        Dim row As SampleRequestStatusDataSet.SampleRequestStatusRow
        row = CType(CType(Me.SampleRequestStatusBindingSource.Current, DataRowView).Row, SampleRequestStatusDataSet.SampleRequestStatusRow)



        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("UpdateSampleStatus", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@SampleRequestId", row.SampleRequestId)

            If row.IsFileReceiveDateNull = False Then
                cmd.Parameters.AddWithValue("@FileReceivedDate", row.FileReceiveDate)
            End If
            If row.IsFileReceiveDetailsNull = False Then
                cmd.Parameters.AddWithValue("@FileReceiveDetails", row.FileReceiveDetails)
            End If
            If row.IsEmbroideryDetailsNull = False Then
                cmd.Parameters.AddWithValue("@EmbroideryDetails", row.EmbroideryDetails)
            End If
            If row.IsTrimDetailsNull = False Then
                cmd.Parameters.AddWithValue("@TrimDetails", row.TrimDetails)
            End If
            If row.IsIsTrimAvailableNull = False Then
                cmd.Parameters.AddWithValue("@IsTrimAvailable", row.IsTrimAvailable)
            End If

            If row.IsExTrimRcvDateNull = False Then
                cmd.Parameters.AddWithValue("@ExTrimReceiveDate", row.ExTrimRcvDate)
            End If
            If row.IsAccReceiveDateNull = False Then
                cmd.Parameters.AddWithValue("@AccReceiveDate", row.AccReceiveDate)
            End If
            If row.IsAccReceiveDetailsNull = False Then
                cmd.Parameters.AddWithValue("@AccReceiveDetails", row.AccReceiveDetails)
            End If
            If row.IsIsFabricAvailableNull = False Then
                cmd.Parameters.AddWithValue("@IsFabricAvailable", row.IsFabricAvailable)
            End If

            If row.IsSampleCuttingStartDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleCuttingStartDate", row.SampleCuttingStartDate)
            End If
            If row.IsSampleCuttingEndDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleCuttingEndDate", row.SampleCuttingEndDate)
            End If
            If row.IsSamplePrintSendDateNull = False Then
                cmd.Parameters.AddWithValue("@SamplePrintSendDate", row.SamplePrintSendDate)
            End If
            If row.IsSamplePrintSendQtyNull = False Then
                cmd.Parameters.AddWithValue("@SamplePrintSendQty", row.SamplePrintSendQty)
            End If

            If row.IssamplePrintReceiveDateNull = False Then
                cmd.Parameters.AddWithValue("@SamplePrintRcvDate", row.samplePrintReceiveDate)
            End If
            If row.IsSamplePrintReceiveQtyNull = False Then
                cmd.Parameters.AddWithValue("@SamplePrintRcvQty", row.SamplePrintReceiveQty)
            End If

            If row.IsSampleEmbSendDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleEmbSendDate", row.SampleEmbSendDate)
            End If
            If row.IsSampleEmbSendQtyNull = False Then
                cmd.Parameters.AddWithValue("@SampleEmbSendQty", row.SampleEmbSendQty)
            End If
            If row.IsSampleEmbReceiveDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleEmbReceiveDate", row.SampleEmbReceiveDate)
            End If
            If row.IsSampleEmbReceiveQtyNull = False Then
                cmd.Parameters.AddWithValue("@SampleEmbReceiveQty", row.SampleEmbReceiveQty)
            End If

            If row.IsSampleSewingStartDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleSewingStartDate", row.SampleSewingStartDate)
            End If
            If row.IsSampleSewingEndDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleSewingEndDate", row.SampleSewingEndDate)
            End If
            If row.IsSampleStatusNull = False Then
                cmd.Parameters.AddWithValue("@SampleStatus", row.SampleStatus)
            End If
            If row.IsCommentStatusNull = False Then
                cmd.Parameters.AddWithValue("@CommentsStatus", row.CommentStatus)
            End If

            If row.IsCommentsReceiveDateNull = False Then
                cmd.Parameters.AddWithValue("@CommentsReceiveDate", row.CommentsReceiveDate)
            End If

            If row.IsSampleExDeliveryDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleExDeliveryDate", row.SampleExDeliveryDate)
            End If

            If row.IsSampleSendDateNull = False Then
                cmd.Parameters.AddWithValue("@SampleSendDate", row.SampleSendDate)
            End If

            If row.IsSampleSendingInfoNull = False Then
                cmd.Parameters.AddWithValue("@SampleSendingInfo", row.SampleSendingInfo)
            End If


            If row.IsApprovalStatusNull = False Then
                cmd.Parameters.AddWithValue("@ApprovalStatus", row.ApprovalStatus)
            End If

            cmd.Parameters.AddWithValue("@IsComplete", row.IsComplete)
            If row.IsCompletedOnNull = False Then
                cmd.Parameters.AddWithValue("@SampleCloseDate", row.CompletedOn)
            End If
            If row.IsRemarksNull = False Then
                cmd.Parameters.AddWithValue("@Remarks", row.Remarks)
            End If

            If row.IsCompletedOnNull = False Then
                cmd.Parameters.AddWithValue("@CompletedOn", row.CompletedOn)
            End If
            If row.IsSamplePreparedByNull = False Then
                cmd.Parameters.AddWithValue("@SamplePreparedBy", row.SamplePreparedBy)
            End If


            cmd.ExecuteNonQuery()

        End Using
        Me.SampleRequestStatusTableAdapter.FillBySampleRequestId(Me.SampleRequestStatusDataSet.SampleRequestStatus, Me.ProgramNoGridLookUpEdit.EditValue)

        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

        Me.SampleRequestStatusTableAdapter.FillBySampleRequestId(Me.SampleRequestStatusDataSet.SampleRequestStatus, Me.ProgramNoGridLookUpEdit.EditValue)

        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

    End Sub

    Private Sub LastUpdateLabel_Click(sender As Object, e As EventArgs) Handles LastUpdateLabel.Click

    End Sub

    Private Sub SaveAsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class