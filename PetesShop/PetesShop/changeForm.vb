'Program: Pete's Shop Tendered Form
'Me: changeForm.vb
'Author: P. Schmitt
'Date: 20-Nov-2014
'Purpose: A change form for Pete's Shop. Breaks change into dollars, quarters, etc.
Option Strict On
Option Explicit On
'====================Class changeForm============================
Public Class changeForm
    '====================changeForm_Activated============================
    Private Sub changeForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Const DOLLAR As Decimal = 1D
        Const QUARTER As Decimal = 0.25D
        Const DIME As Decimal = 0.1D
        Const NICKEL As Decimal = 0.05D

        Dim changeTempDecimal As Decimal
        Dim dollarShort As Short
        Dim quarterShort As Short
        Dim quarterDecimal As Decimal
        Dim dimeShort As Short
        Dim dimeDecimal As Decimal
        Dim nickelShort As Short
        Dim nickelDecimal As Decimal
        Dim pennyShort As Short

        If Me.Visible = False Then Me.Visible = True

        g_changeDecimal = g_tenderedDecimal - g_grossSaleDecimal

        changeValLabel.Text = g_changeDecimal.ToString("C")
        saleValLabel.Text = g_grossSaleDecimal.ToString("C")
        tenderedValLabel.Text = g_tenderedDecimal.ToString("C")

        changeTempDecimal = g_changeDecimal
        dollarShort = CShort(changeTempDecimal - (changeTempDecimal Mod DOLLAR))
        dollarValLabel.Text = dollarShort.ToString
        changeTempDecimal = changeTempDecimal - (CDec(dollarShort) * DOLLAR)

        quarterDecimal = changeTempDecimal - (changeTempDecimal Mod QUARTER)
        quarterShort = CShort(quarterDecimal / QUARTER)
        quartersValLabel.Text = quarterShort.ToString
        changeTempDecimal = changeTempDecimal - (CDec(quarterShort) * QUARTER)

        dimeDecimal = changeTempDecimal - (changeTempDecimal Mod DIME)
        dimeShort = CShort(dimeDecimal / DIME)
        dimesValLabel.Text = dimeShort.ToString
        changeTempDecimal = changeTempDecimal - (CDec(dimeShort) * DIME)

        nickelDecimal = changeTempDecimal - (changeTempDecimal Mod NICKEL)
        nickelShort = CShort(nickelDecimal / NICKEL)
        nickelsValLabel.Text = nickelShort.ToString
        changeTempDecimal = changeTempDecimal - (CDec(nickelShort) * NICKEL)

        pennyShort = CShort(changeTempDecimal * 100D)
        penniesValLabel.Text = pennyShort.ToString
    End Sub
    '====================nextButton_Click============================
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Me.Visible = False
        receiptForm.ShowDialog()
    End Sub
End Class