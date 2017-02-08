Public Class MainForm

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBaseFee As Decimal   'base monthly fee
        Dim decTotalFee As Decimal  'total membership fee
        Dim intMonths As Integer     ' number of months
        Dim binInputOk As Boolean = True


        'Constants for the base fee
        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        'constants for additonal fee
        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        'validation for converting the number of months
        lblStatusStrip.Text = String.Empty
        If Integer.TryParse(txtBoxMonths.Text, intMonths) = False Then
            lblStatusStrip.Text = "Months must be an Integer"
            binInputOk = False
        End If

        'validate number of months 
        If intMonths < 1 Or intMonths > 24 Then
            lblStatusStrip.Text = "Months must be in the range of 1 - 24."
            binInputOk = False
        End If

        If binInputOk = True Then
            'determine the base month fee
            If rdbStandardAdult.Checked = True Then
                decBaseFee = decADULT_FEE
            ElseIf rdbChild.Checked = True Then
                decBaseFee = decCHILD_FEE
            ElseIf rdbStudent.Checked = True Then
                decBaseFee = decSTUDENT_FEE
            ElseIf rdbSenior.Checked = True Then
                decBaseFee = decSENIOR_FEE
            End If

            'check additonal services
            If cbxYoga.Checked = True Then
                decBaseFee += decYOGA_FEE
            End If

            If cbxKarate.Checked = True Then
                decBaseFee += decKARATE_FEE
            End If

            If cbxPersonalTrainer.Checked = True Then
                decBaseFee += decTRAINER_FEE
            End If


            'calculating the total fee
            decTotalFee = decBaseFee * intMonths

            'display the fees
            txtBoxMonthlyFee.Text = decBaseFee.ToString("c")
            txtBoxTotal.Text = decTotalFee.ToString("c")



        End If
    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub







    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the adult buttons
        rdbStandardAdult.Checked = True

        'clearing the check boxes
        cbxYoga.Checked = False
        cbxKarate.Checked = False
        cbxPersonalTrainer.Checked = False


        'clear the number of months
        txtBoxMonths.Clear()

        'clear the fee labels
        txtBoxMonthlyFee.Text = String.Empty
        txtBoxTotal.Text = String.Empty
        lblStatusStrip.Text = String.Empty

        'give txtMonths the focus
        txtBoxMonths.Focus()

    End Sub




    Private Sub txtBoxMonths_TextChanged(sender As Object, e As EventArgs) Handles txtBoxMonths.TextChanged

    End Sub
End Class
