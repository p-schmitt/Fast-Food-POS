'Program: Pete's Shop 
'Me: mainModule.vb
'Author: P. Schmitt
'Date: 06-Nov-2014
'Purpose: The main module for for Pete's Shop.
Option Strict On
Option Explicit On

'=====================Module mainModule=========================
Module mainModule
    Public Const g_STATETAXRATE_DECIMAL As Decimal = 0.07D
    Public Const g_LOCALTAXRATE_DECIMAL As Decimal = 0.01D

    Public g_netSaleDecimal As Decimal = 0D
    Public g_grossSaleDecimal As Decimal = 0D
    Public g_stateTaxDecimal As Decimal = 0D
    Public g_localTaxDecimal As Decimal = 0D
    Public g_tenderedDecimal As Decimal = 0D
    Public g_changeDecimal As Decimal = 0D
    Public g_itemsString(10, 4) As String

    Public g_isEndFlagBoolean As Boolean = False
    '=====================Sub Main=========================
    Public Sub main()
        Do
            splashForm.ShowDialog()
            Call InitializeItemArray()
            posForm.ShowDialog()
        Loop Until g_isEndFlagBoolean = True
    End Sub
    '=====================Sub InitializeItemArray=========================
    Public Sub InitializeItemArray()
        g_itemsString(1, 0) = "Hamb."
        g_itemsString(1, 1) = "1.50"
        g_itemsString(1, 2) = "0"
        g_itemsString(1, 3) = "0"
        g_itemsString(2, 0) = "ChzBrg."
        g_itemsString(2, 1) = "2.00"
        g_itemsString(2, 2) = "0"
        g_itemsString(2, 3) = "0"
        g_itemsString(3, 0) = "HotDog"
        g_itemsString(3, 1) = "1.29"
        g_itemsString(3, 2) = "0"
        g_itemsString(3, 3) = "0"
        g_itemsString(4, 0) = "Sm.Fry"
        g_itemsString(4, 1) = ".99"
        g_itemsString(4, 2) = "0"
        g_itemsString(4, 3) = "0"
        g_itemsString(5, 0) = "Lg.Fry"
        g_itemsString(5, 1) = "1.49"
        g_itemsString(5, 2) = "0"
        g_itemsString(5, 3) = "0"
        g_itemsString(6, 0) = "Fish"
        g_itemsString(6, 1) = "3.50"
        g_itemsString(6, 2) = "0"
        g_itemsString(6, 3) = "0"
        g_itemsString(7, 0) = "Chick"
        g_itemsString(7, 1) = "2.29"
        g_itemsString(7, 2) = "0"
        g_itemsString(8, 0) = "KidMeal"
        g_itemsString(8, 1) = "3.50"
        g_itemsString(8, 2) = "0"
        g_itemsString(8, 3) = "0"
        g_itemsString(9, 0) = "Soda"
        g_itemsString(9, 1) = "1.00"
        g_itemsString(9, 2) = "0"
        g_itemsString(9, 3) = "0"
        g_itemsString(10, 0) = "Shake"
        g_itemsString(10, 1) = "2.50"
        g_itemsString(10, 2) = "0"
        g_itemsString(10, 3) = "0"
    End Sub
End Module
