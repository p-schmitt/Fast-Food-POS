'Program: Pete's Shop Tendered Form
'Me: tenderedForm.vb
'Author: P. Schmitt
'Date: 13-Nov-2014
'Purpose: A money tendered form for Pete's Shop. Input payment.
Option Strict On
Option Explicit On
'====================Class tenderedForm============================
Public Class tenderedForm
    Private m_tenderedString As String = ""
    Private m_isDecPointFlag As Boolean = False
    Private m_placeCountShort As Short
    '====================UseCalculator_Click============================
    Private Sub UseCalculator_Click(sender As Object, e As EventArgs) Handles sevenButton.Click, _
        zeroButton.Click, twoButton.Click, threeButton.Click, sixButton.Click, oneButton.Click, _
        nineButton.Click, fourButton.Click, fiveButton.Click, eightButton.Click

        Dim indexShort As Short
        Dim btn As Button = CType(sender, Button)
        If m_isDecPointFlag = True Then
            m_placeCountShort += 1S
        End If

        If m_placeCountShort <= 2 Then
            indexShort = CShort(btn.Tag)
            m_tenderedString &= indexShort.ToString
            tenderedLabel.Text = m_tenderedString
        End If
    End Sub
    '====================decimalButton_Click============================
    Private Sub decimalButton_Click(sender As Object, e As EventArgs) Handles decimalButton.Click
        m_tenderedString &= "."
        decimalButton.Enabled = False
        m_isDecPointFlag = True

    End Sub
    '====================clearButton_Click============================
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        m_isDecPointFlag = False
        m_placeCountShort = 0
        m_tenderedString = String.Empty
        tenderedLabel.Text = String.Empty
        decimalButton.Enabled = True
    End Sub
    '====================backButton_Click============================
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        posForm.Show()
        Me.Close()
    End Sub
    '====================tenderedForm_Activated============================
    Private Sub tenderedForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Me.Visible = False Then Me.Visible = True
        Call clearButton_Click(sender, e)
        g_stateTaxDecimal = CDec(CInt(g_netSaleDecimal * g_STATETAXRATE_DECIMAL * 100D + 0.5D)) / 100D
        g_localTaxDecimal = CDec(CInt(g_netSaleDecimal * g_LOCALTAXRATE_DECIMAL * 100D + 0.5D)) / 100D
        g_grossSaleDecimal = g_netSaleDecimal + g_stateTaxDecimal + g_localTaxDecimal


        netLabel.Text = g_netSaleDecimal.ToString("C")
        stateTaxLabel.Text = g_stateTaxDecimal.ToString("C")
        localTaxLabel.Text = g_localTaxDecimal.ToString("C")
        totalLabel.Text = g_grossSaleDecimal.ToString("C")
    End Sub

    '====================nextButton_Click============================
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Try
            g_tenderedDecimal = CDec(m_tenderedString)
            If g_tenderedDecimal >= g_grossSaleDecimal Then
                Me.Visible = False
                changeForm.ShowDialog()
            Else
                MessageBox.Show("Tendered must be more than gross!", "Tendered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call clearButton_Click(sender, e)
            End If
        Catch
            MessageBox.Show("You must enter an amount to pay the bill", "Error - Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

   
End Class