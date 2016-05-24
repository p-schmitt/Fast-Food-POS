'Program: Pete's Shop Splash
'Me: splashForm.vb
'Author: P. Schmitt
'Date: 06-Nov-2014
'Purpose: A splash screen for the Pete's Shop program

Option Strict On
Option Explicit On

'==========================Class_splashForm=======================
Public Class splashForm
    '==========================tmrSplash_click=======================
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        tmrSplash.Enabled = False
        Me.Close()
    End Sub
End Class