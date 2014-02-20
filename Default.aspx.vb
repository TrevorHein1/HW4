
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        'Declare Variables
        Dim Hours As Decimal
        Dim Wage As Decimal
        Dim PreTax As Decimal
        Dim GrossPay As Decimal
        Dim Taxable As Decimal
        Dim Tax As Decimal
        Dim Pay As Decimal
        Dim PostTax As Decimal

        'Assign Variables
        Hours = Val(HoursTB.Text)
        Wage = Val(WageTB.Text)
        PreTax = Val(PreTaxTB.Text)
        PostTax = Val(PostTaxTB.Text)

        'Calculate Gross Pay
        GrossPay = Hours * Wage

        'Calcualte Taxable Pay
        Taxable = GrossPay - PreTax

        'Calculate Tax Percentage
        If GrossPay < 500 Then
            Tax = Taxable * 0.18
        Else
            Tax = Taxable * 0.22
        End If

        'Calculate Pay
        Pay = Taxable - Tax

        'Calculate Net Pay
        NetPayLB.Text = Pay - Val(PostTaxTB.Text)

    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        'Clear All User Input and Output
        HoursTB.Text = String.Empty
        WageTB.Text = String.Empty
        PreTaxTB.Text = String.Empty
        PostTaxTB.Text = String.Empty
        NetPayLB.Text = String.Empty


    End Sub
End Class
