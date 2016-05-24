'Program: Pete's Shop POS Form
'Me: posForm.vb
'Author: P. Schmitt
'Date: 06-Nov-2014
'Purpose: A point-of-sale form for Pete's Shop. Calculate totals based on items sold.

Option Strict On
Option Explicit On

'=================class posForm=============================
Public Class posForm
    Private m_tempNetDecimal As Decimal
    Private m_runCount As Short
    '=================posForm_FormClosing=============================
    Private Sub posForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgDecision As System.Windows.Forms.DialogResult
        dlgDecision = MessageBox.Show("Yes to close, " & ControlChars.NewLine & "No to start a new sale, " & ControlChars.NewLine & "Cancel to continue current sale", _
                                      "Pete's Shop - Quit/New Sale/Continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Select Case dlgDecision
            Case Windows.Forms.DialogResult.Yes
                g_isEndFlagBoolean = True
            Case Windows.Forms.DialogResult.Cancel
                e.Cancel = True
            Case Else
                clearButton.PerformClick()
        End Select

    End Sub


    '=================posForm_Load=============================
    Private Sub posForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myControl As New Control
        For Each thisControl As System.Windows.Forms.Control In Me.Controls
            If CShort(thisControl.Tag) > 0 Then
                thisControl.Text = g_itemsString(CShort(thisControl.Tag), 0)
            End If
        Next thisControl

    End Sub
    '===================itemSoldButton_Click=====================
    Private Sub itemSoldButtonClick(sender As Object, e As EventArgs) Handles item1Button.Click, _
        item9Button.Click, item8Button.Click, item7Button.Click, item6Button.Click, _
        item5Button.Click, item4Button.Click, item3Button.Click, item2Button.Click, item10Button.Click

        Dim indexShort As Short

        If sender Is item1Button Then
            indexShort = 1
        ElseIf sender Is item2Button Then
            indexShort = 2
        ElseIf sender Is item3Button Then
            indexShort = 3
        ElseIf sender Is item4Button Then
            indexShort = 4
        ElseIf sender Is item5Button Then
            indexShort = 5
        ElseIf sender Is item6Button Then
            indexShort = 6
        ElseIf sender Is item7Button Then
            indexShort = 7
        ElseIf sender Is item8Button Then
            indexShort = 8
        ElseIf sender Is item9Button Then
            indexShort = 9
        Else
            indexShort = 10
        End If
        If subtractCheckbox.Checked = False Then
            g_itemsString(indexShort, 2) = CStr(CShort(g_itemsString(indexShort, 2)) + 1S)
            m_tempNetDecimal += CDec(g_itemsString(indexShort, 1))
            itemSaleLabel.Text = FormatCurrency(g_itemsString(indexShort, 1))
        ElseIf subtractCheckbox.Checked = True And CShort(g_itemsString(indexShort, 2)) >= 1 Then
            g_itemsString(indexShort, 2) = CStr(CShort(g_itemsString(indexShort, 2)) - 1S)
            m_tempNetDecimal -= CDec(g_itemsString(indexShort, 1))
            itemSaleLabel.Text = "-" & g_itemsString(indexShort, 1)
            subtractCheckbox.Checked = False
        Else
            MessageBox.Show("You do not have any of " & ControlChars.NewLine & g_itemsString(indexShort, 0) _
                            & Space(1) & "to remove.", "Subtract Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            subtractCheckbox.Checked = False

        End If

        g_itemsString(indexShort, 3) = CStr(CDec(CShort(g_itemsString(indexShort, 2)) * CDec(g_itemsString(indexShort, 1))))

        netSaleLabel.Text = m_tempNetDecimal.ToString("C")

        itemsListbox.Items.Clear()
        For shoIndex As Short = 1 To 10
            If g_itemsString(shoIndex, 2) <> "0" Then
                Dim inputLineString As String = g_itemsString(shoIndex, 2) & _
                    Space(2) & g_itemsString(shoIndex, 0) & Space(2) & g_itemsString(shoIndex, 1) _
                    & Space(2) & FormatCurrency(g_itemsString(shoIndex, 3))
                itemsListbox.Items.Add(inputLineString)
            End If
        Next shoIndex

    End Sub
    '===================clearButton_Click=====================
    Public Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        Call mainModule.InitializeItemArray()
        g_netSaleDecimal = 0D
        m_tempNetDecimal = 0D
        itemSaleLabel.Text = String.Empty
        netSaleLabel.Text = String.Empty
        itemsListbox.Items.Clear()
        subtractCheckbox.Checked = False
    End Sub
    '===================subtractCheckbox_CheckedChanged=====================
    Private Sub subtractCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles subtractCheckbox.CheckedChanged
        If subtractCheckbox.Checked Then
            subtractCheckbox.BackColor = Color.Red
        Else
            subtractCheckbox.BackColor = Color.LightGray
        End If
    End Sub
    '===================nextButton_Click=====================
    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        g_netSaleDecimal = m_tempNetDecimal
        Me.Visible = False
        tenderedForm.ShowDialog()
    End Sub
End Class
