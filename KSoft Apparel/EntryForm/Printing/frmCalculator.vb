Public Class frmCalculator
    Dim summeryvalue As Decimal = 0
    Dim cancelaction As Boolean
    Private _TTLValue As Decimal
    Public Property TTLValue() As Decimal
        Get
            Return _TTLValue
        End Get
        Set(ByVal value As Decimal)
            _TTLValue = value
        End Set
    End Property



    Private Sub frmCalculator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cancelaction = False Then

            If frmMain.ActiveMdiChild.Name = "frmRecipe" Then

                frmRecipe.RecipeItemDataGridView.CurrentCell.Value = summeryvalue
                summeryvalue = 0

                'ElseIf frmMain.ActiveMdiChild.Name = "frmOrder" Then

                '    frmOrder.OrderSizeDetailsDataGridView.CurrentCell.Value = summeryvalue
                '    summeryvalue = 0

            ElseIf frmMain.ActiveMdiChild.Name = "frmPrintProduction" Then

                frmPrintProduction.PrintProductionDataGridView.CurrentCell.Value = summeryvalue
                summeryvalue = 0


            End If

        End If



    End Sub

    Private Sub frmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        

        If e.KeyData = Keys.Enter Then

            If TextBox1.Text = String.Empty Then

                Me.TTLValue = summeryvalue
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()

            Else

                If Label1.Text = String.Empty Then
                    Label1.Text = String.Format("={0}", TextBox1.Text)
                Else
                    Label1.Text = String.Format("{0}+{1}", Label1.Text, TextBox1.Text)
                End If

                If Not IsNumeric(TextBox1.Text) Then
                    MsgBox("Only Numeric Value is allowed", vbExclamation)

                Else
                    summeryvalue = summeryvalue + CDec(TextBox1.Text)

                End If

                TextBox1.Text = String.Empty
            End If



        ElseIf e.KeyData = Keys.Escape Then

            cancelaction = True
            Me.Close()

        End If



    End Sub

   

    

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Only Numeric Value is allowed", vbExclamation)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CalcEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcEdit1.EditValueChanged

        TextBox1.Text = CalcEdit1.Text


    End Sub
End Class