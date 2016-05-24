<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tenderedLabel = New System.Windows.Forms.Label()
        Me.saleLabel = New System.Windows.Forms.Label()
        Me.changeLabel = New System.Windows.Forms.Label()
        Me.dollarsLabel = New System.Windows.Forms.Label()
        Me.quartersLabel = New System.Windows.Forms.Label()
        Me.dimesLabel = New System.Windows.Forms.Label()
        Me.nickelsLabel = New System.Windows.Forms.Label()
        Me.penniesLabel = New System.Windows.Forms.Label()
        Me.tenderedValLabel = New System.Windows.Forms.Label()
        Me.saleValLabel = New System.Windows.Forms.Label()
        Me.changeValLabel = New System.Windows.Forms.Label()
        Me.dollarValLabel = New System.Windows.Forms.Label()
        Me.quartersValLabel = New System.Windows.Forms.Label()
        Me.dimesValLabel = New System.Windows.Forms.Label()
        Me.nickelsValLabel = New System.Windows.Forms.Label()
        Me.penniesValLabel = New System.Windows.Forms.Label()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tenderedLabel
        '
        Me.tenderedLabel.AutoSize = True
        Me.tenderedLabel.Location = New System.Drawing.Point(39, 43)
        Me.tenderedLabel.Name = "tenderedLabel"
        Me.tenderedLabel.Size = New System.Drawing.Size(147, 33)
        Me.tenderedLabel.TabIndex = 0
        Me.tenderedLabel.Text = "Tendered"
        '
        'saleLabel
        '
        Me.saleLabel.AutoSize = True
        Me.saleLabel.Location = New System.Drawing.Point(30, 102)
        Me.saleLabel.Name = "saleLabel"
        Me.saleLabel.Size = New System.Drawing.Size(156, 33)
        Me.saleLabel.TabIndex = 1
        Me.saleLabel.Text = "Sale Total"
        '
        'changeLabel
        '
        Me.changeLabel.AutoSize = True
        Me.changeLabel.Location = New System.Drawing.Point(64, 161)
        Me.changeLabel.Name = "changeLabel"
        Me.changeLabel.Size = New System.Drawing.Size(122, 33)
        Me.changeLabel.TabIndex = 2
        Me.changeLabel.Text = "Change"
        '
        'dollarsLabel
        '
        Me.dollarsLabel.AutoSize = True
        Me.dollarsLabel.Location = New System.Drawing.Point(72, 220)
        Me.dollarsLabel.Name = "dollarsLabel"
        Me.dollarsLabel.Size = New System.Drawing.Size(114, 33)
        Me.dollarsLabel.TabIndex = 3
        Me.dollarsLabel.Text = "Dollars"
        '
        'quartersLabel
        '
        Me.quartersLabel.AutoSize = True
        Me.quartersLabel.Location = New System.Drawing.Point(49, 279)
        Me.quartersLabel.Name = "quartersLabel"
        Me.quartersLabel.Size = New System.Drawing.Size(137, 33)
        Me.quartersLabel.TabIndex = 4
        Me.quartersLabel.Text = "Quarters"
        '
        'dimesLabel
        '
        Me.dimesLabel.AutoSize = True
        Me.dimesLabel.Location = New System.Drawing.Point(82, 338)
        Me.dimesLabel.Name = "dimesLabel"
        Me.dimesLabel.Size = New System.Drawing.Size(104, 33)
        Me.dimesLabel.TabIndex = 5
        Me.dimesLabel.Text = "Dimes"
        '
        'nickelsLabel
        '
        Me.nickelsLabel.AutoSize = True
        Me.nickelsLabel.Location = New System.Drawing.Point(68, 397)
        Me.nickelsLabel.Name = "nickelsLabel"
        Me.nickelsLabel.Size = New System.Drawing.Size(118, 33)
        Me.nickelsLabel.TabIndex = 6
        Me.nickelsLabel.Text = "Nickels"
        '
        'penniesLabel
        '
        Me.penniesLabel.AutoSize = True
        Me.penniesLabel.Location = New System.Drawing.Point(59, 456)
        Me.penniesLabel.Name = "penniesLabel"
        Me.penniesLabel.Size = New System.Drawing.Size(127, 33)
        Me.penniesLabel.TabIndex = 7
        Me.penniesLabel.Text = "Pennies"
        '
        'tenderedValLabel
        '
        Me.tenderedValLabel.BackColor = System.Drawing.Color.Black
        Me.tenderedValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tenderedValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.tenderedValLabel.Location = New System.Drawing.Point(219, 43)
        Me.tenderedValLabel.Name = "tenderedValLabel"
        Me.tenderedValLabel.Size = New System.Drawing.Size(153, 33)
        Me.tenderedValLabel.TabIndex = 8
        Me.tenderedValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'saleValLabel
        '
        Me.saleValLabel.BackColor = System.Drawing.Color.Black
        Me.saleValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.saleValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.saleValLabel.Location = New System.Drawing.Point(219, 102)
        Me.saleValLabel.Name = "saleValLabel"
        Me.saleValLabel.Size = New System.Drawing.Size(153, 33)
        Me.saleValLabel.TabIndex = 9
        Me.saleValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'changeValLabel
        '
        Me.changeValLabel.BackColor = System.Drawing.Color.Black
        Me.changeValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.changeValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.changeValLabel.Location = New System.Drawing.Point(219, 161)
        Me.changeValLabel.Name = "changeValLabel"
        Me.changeValLabel.Size = New System.Drawing.Size(153, 33)
        Me.changeValLabel.TabIndex = 10
        Me.changeValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dollarValLabel
        '
        Me.dollarValLabel.BackColor = System.Drawing.Color.Black
        Me.dollarValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dollarValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.dollarValLabel.Location = New System.Drawing.Point(219, 220)
        Me.dollarValLabel.Name = "dollarValLabel"
        Me.dollarValLabel.Size = New System.Drawing.Size(62, 33)
        Me.dollarValLabel.TabIndex = 11
        Me.dollarValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'quartersValLabel
        '
        Me.quartersValLabel.BackColor = System.Drawing.Color.Black
        Me.quartersValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.quartersValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.quartersValLabel.Location = New System.Drawing.Point(219, 279)
        Me.quartersValLabel.Name = "quartersValLabel"
        Me.quartersValLabel.Size = New System.Drawing.Size(62, 33)
        Me.quartersValLabel.TabIndex = 12
        Me.quartersValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dimesValLabel
        '
        Me.dimesValLabel.BackColor = System.Drawing.Color.Black
        Me.dimesValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dimesValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.dimesValLabel.Location = New System.Drawing.Point(219, 338)
        Me.dimesValLabel.Name = "dimesValLabel"
        Me.dimesValLabel.Size = New System.Drawing.Size(62, 33)
        Me.dimesValLabel.TabIndex = 13
        Me.dimesValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nickelsValLabel
        '
        Me.nickelsValLabel.BackColor = System.Drawing.Color.Black
        Me.nickelsValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nickelsValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.nickelsValLabel.Location = New System.Drawing.Point(219, 397)
        Me.nickelsValLabel.Name = "nickelsValLabel"
        Me.nickelsValLabel.Size = New System.Drawing.Size(62, 33)
        Me.nickelsValLabel.TabIndex = 14
        Me.nickelsValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'penniesValLabel
        '
        Me.penniesValLabel.BackColor = System.Drawing.Color.Black
        Me.penniesValLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.penniesValLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.penniesValLabel.Location = New System.Drawing.Point(219, 456)
        Me.penniesValLabel.Name = "penniesValLabel"
        Me.penniesValLabel.Size = New System.Drawing.Size(62, 33)
        Me.penniesValLabel.TabIndex = 15
        Me.penniesValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(332, 490)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(61, 58)
        Me.nextButton.TabIndex = 16
        Me.nextButton.Text = "&Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'changeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(429, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.penniesValLabel)
        Me.Controls.Add(Me.nickelsValLabel)
        Me.Controls.Add(Me.dimesValLabel)
        Me.Controls.Add(Me.quartersValLabel)
        Me.Controls.Add(Me.dollarValLabel)
        Me.Controls.Add(Me.changeValLabel)
        Me.Controls.Add(Me.saleValLabel)
        Me.Controls.Add(Me.tenderedValLabel)
        Me.Controls.Add(Me.penniesLabel)
        Me.Controls.Add(Me.nickelsLabel)
        Me.Controls.Add(Me.dimesLabel)
        Me.Controls.Add(Me.quartersLabel)
        Me.Controls.Add(Me.dollarsLabel)
        Me.Controls.Add(Me.changeLabel)
        Me.Controls.Add(Me.saleLabel)
        Me.Controls.Add(Me.tenderedLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "changeForm"
        Me.Text = "Pete's Shop - Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tenderedLabel As System.Windows.Forms.Label
    Friend WithEvents saleLabel As System.Windows.Forms.Label
    Friend WithEvents changeLabel As System.Windows.Forms.Label
    Friend WithEvents dollarsLabel As System.Windows.Forms.Label
    Friend WithEvents quartersLabel As System.Windows.Forms.Label
    Friend WithEvents dimesLabel As System.Windows.Forms.Label
    Friend WithEvents nickelsLabel As System.Windows.Forms.Label
    Friend WithEvents penniesLabel As System.Windows.Forms.Label
    Friend WithEvents tenderedValLabel As System.Windows.Forms.Label
    Friend WithEvents saleValLabel As System.Windows.Forms.Label
    Friend WithEvents changeValLabel As System.Windows.Forms.Label
    Friend WithEvents dollarValLabel As System.Windows.Forms.Label
    Friend WithEvents quartersValLabel As System.Windows.Forms.Label
    Friend WithEvents dimesValLabel As System.Windows.Forms.Label
    Friend WithEvents nickelsValLabel As System.Windows.Forms.Label
    Friend WithEvents penniesValLabel As System.Windows.Forms.Label
    Friend WithEvents nextButton As System.Windows.Forms.Button
End Class
