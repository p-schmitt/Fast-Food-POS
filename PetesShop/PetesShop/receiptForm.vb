'Copyright (C) 2002 Microsoft Corporation
'All rights reserved.
'THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
'EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
'MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

'Requires the Trial or Release version of Visual Studio .NET Professional (or greater).
'Me: receiptForm.vb
'Amended By: P. Schmitt
'Date Amended: 4-Dec-2014
'Purpose: This form displays the receipt to either a print preview or to be printed. It
'    also calls to reset the array, and the posForm. NOTE: The posForms.clearButton_Click event
'    was changed from Private to Public
Option Strict On
Imports System.Drawing.Printing

Public Class receiptForm
    Inherits System.Windows.Forms.Form

    ' It's important that all the event procedures work with the same PrintDocument
    ' object.
    Private WithEvents pdoc As New PrintDocument()

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        ' So that we only need to set the title of the application once,
        ' we use the AssemblyInfo class (defined in the AssemblyInfo.vb file)
        ' to read the AssemblyTitle attribute.



    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnPageSetup As System.Windows.Forms.Button
    Friend WithEvents btnPrintDialog As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents newSaleButton As System.Windows.Forms.Button
    Friend WithEvents txtDocument As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(receiptForm))
        Me.btnPageSetup = New System.Windows.Forms.Button()
        Me.btnPrintDialog = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.txtDocument = New System.Windows.Forms.TextBox()
        Me.newSaleButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPageSetup
        '
        resources.ApplyResources(Me.btnPageSetup, "btnPageSetup")
        Me.btnPageSetup.Name = "btnPageSetup"
        '
        'btnPrintDialog
        '
        resources.ApplyResources(Me.btnPrintDialog, "btnPrintDialog")
        Me.btnPrintDialog.Name = "btnPrintDialog"
        '
        'btnPrintPreview
        '
        resources.ApplyResources(Me.btnPrintPreview, "btnPrintPreview")
        Me.btnPrintPreview.Name = "btnPrintPreview"
        '
        'txtDocument
        '
        resources.ApplyResources(Me.txtDocument, "txtDocument")
        Me.txtDocument.Name = "txtDocument"
        '
        'newSaleButton
        '
        resources.ApplyResources(Me.newSaleButton, "newSaleButton")
        Me.newSaleButton.BackColor = System.Drawing.Color.Yellow
        Me.newSaleButton.Name = "newSaleButton"
        Me.newSaleButton.UseVisualStyleBackColor = False
        '
        'receiptForm
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDocument)
        Me.Controls.Add(Me.btnPageSetup)
        Me.Controls.Add(Me.newSaleButton)
        Me.Controls.Add(Me.btnPrintDialog)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "receiptForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Standard Menu Code "
    ' <System.Diagnostics.DebuggerStepThrough()> has been added to some procedures since they are
    ' not the focus of the demo. Remove them if you wish to debug the procedures.
    ' This code simply shows the About form.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Open the About form in Dialog Mode

    End Sub

    ' This code will close the form.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Close the current form
        Me.Close()
    End Sub
#End Region


    ' The PrintDialog allows the user to select the printer that they want to print 
    ' to, as well as other printing options.
    Private Sub btnPrintDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDialog.Click
        Dim dialog As New PrintDialog()
        dialog.Document = pdoc

        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            pdoc.Print()
        End If
    End Sub

    ' The PrintPreviewDialog is associated with the PrintDocument as the preview is 
    ' rendered, the PrintPage event is triggered. This event is passed a graphics 
    ' context where it "draws" the page.
    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        Dim ppd As New PrintPreviewDialog()
        Try
            ppd.Document = pdoc
            ppd.ShowDialog()
        Catch exp As Exception
            MessageBox.Show("An error occurred while trying to load the " & _
                "document for Print Preview. Make sure you currently have " & _
                "access to a printer. A printer must be connected and " & _
                "accessible for Print Preview to work.", Me.Text, _
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Page setup lets you specify things like the paper size, portrait, 
    ' landscape, etc.
    Private Sub btnPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPageSetup.Click
        Dim psd As New PageSetupDialog()
        With psd
            .Document = pdoc
            .PageSettings = pdoc.DefaultPageSettings
        End With

        If psd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pdoc.DefaultPageSettings = psd.PageSettings
        End If
    End Sub

    ' Handles the Form's Load event, initializing the TextBox with some text
    ' for printing.
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strReceipt As String
        txtDocument.Text = "Pete's Shop" & ControlChars.NewLine & _
            "123 North Main Street" & ControlChars.NewLine & _
            "Peoria, IL 61614" & ControlChars.NewLine & _
            "Phone: (309) 678-5555" & ControlChars.NewLine & _
            "Email: pete@petesshop.com" & ControlChars.NewLine
        _
        For shoIndex As Short = 1 To 10
            strReceipt = ""
            If g_itemsString(shoIndex, 2) <> "0" Then
                strReceipt = g_itemsString(shoIndex, 2) & Space(4) & _
                    g_itemsString(shoIndex, 0) & Space(4) & _
                    g_itemsString(shoIndex, 1) & Space(4) & _
                    g_itemsString(shoIndex, 3) & ControlChars.NewLine
                txtDocument.Text &= strReceipt
            End If
        Next shoIndex
        strReceipt = "=======================" & ControlChars.NewLine & _
            "Net:      " & FormatCurrency(g_netSaleDecimal) & ControlChars.NewLine & _
            "State Tax:" & FormatCurrency(g_stateTaxDecimal) & ControlChars.NewLine & _
            "Local Tax:" & FormatCurrency(g_localTaxDecimal) & ControlChars.NewLine & _
            "==========================" & ControlChars.NewLine & _
            "Total:    " & FormatCurrency(g_grossSaleDecimal) & ControlChars.NewLine & _
            "Paid :    " & FormatCurrency(g_tenderedDecimal) & ControlChars.NewLine & _
            "Change:   " & FormatCurrency(g_changeDecimal) & ControlChars.NewLine
        txtDocument.Text &= strReceipt

        txtDocument.Text &= ControlChars.NewLine & Format(Now, "dddd MMMM dd, yyyy hh:mm:ss tt")


    End Sub

    ' PrintPage is the foundational printing event. This event gets fired for every 
    ' page that will be printed. You could also handle the BeginPrint and EndPrint
    ' events for more control.
    ' 
    ' The following is very 
    ' fast and useful for plain text as MeasureString calculates the text that
    ' can be fitted on an entire page. This is not that useful, however, for 
    ' formatted text. In that case you would want to have word-level (vs page-level)
    ' control, which is more complicated.
    Private Sub pdoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdoc.PrintPage
        ' Declare a variable to hold the position of the last printed char. Declare
        ' as static so that subsequent PrintPage events can reference it.
        Static intCurrentChar As Int32
        ' Initialize the font to be used for printing.
        Dim font As New Font("Microsoft Sans Serif", 24)

        Dim intPrintAreaHeight, intPrintAreaWidth, marginLeft, marginTop As Int32
        With pdoc.DefaultPageSettings
            ' Initialize local variables that contain the bounds of the printing 
            ' area rectangle.
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right

            ' Initialize local variables to hold margin values that will serve
            ' as the X and Y coordinates for the upper left corner of the printing 
            ' area rectangle.
            marginLeft = .Margins.Left ' X coordinate
            marginTop = .Margins.Top ' Y coordinate
        End With

        ' If the user selected Landscape mode, swap the printing area height 
        ' and width.
        If pdoc.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If

        ' Calculate the total number of lines in the document based on the height of
        ' the printing area and the height of the font.
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / font.Height)
        ' Initialize the rectangle structure that defines the printing area.
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight)

        ' Instantiate the StringFormat class, which encapsulates text layout 
        ' information (such as alignment and line spacing), display manipulations 
        ' (such as ellipsis insertion and national digit substitution) and OpenType 
        ' features. Use of StringFormat causes MeasureString and DrawString to use
        ' only an integer number of lines when printing each page, ignoring partial
        ' lines that would otherwise likely be printed if the number of lines per 
        ' page do not divide up cleanly for each page (which is usually the case).
        ' See further discussion in the SDK documentation about StringFormatFlags.
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        ' Call MeasureString to determine the number of characters that will fit in
        ' the printing area rectangle. The CharFitted Int32 is passed ByRef and used
        ' later when calculating intCurrentChar and thus HasMorePages. LinesFilled 
        ' is not needed for this sample but must be passed when passing CharsFitted.
        ' Mid is used to pass the segment of remaining text left off from the 
        ' previous page of printing (recall that intCurrentChar was declared as 
        ' static.
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(txtDocument.Text, intCurrentChar + 1), font, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, _
                    intCharsFitted, intLinesFilled)

        ' Print the text to the page.
        e.Graphics.DrawString(Mid(txtDocument.Text, intCurrentChar + 1), font, _
            Brushes.Black, rectPrintingArea, fmt)

        ' Advance the current char to the last char printed on this page. As 
        ' intCurrentChar is a static variable, its value can be used for the next
        ' page to be printed. It is advanced by 1 and passed to Mid() to print the
        ' next page (see above in MeasureString()).
        intCurrentChar += intCharsFitted

        ' HasMorePages tells the printing module whether another PrintPage event
        ' should be fired.
        If intCurrentChar < txtDocument.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            ' You must explicitly reset intCurrentChar as it is static.
            intCurrentChar = 0
        End If
    End Sub

    Private Sub newSaleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newSaleButton.Click
        Call posForm.clearButton_Click(sender, e)
        Call mainModule.InitializeItemArray()
        Me.Close()
        posForm.Show()


    End Sub


End Class