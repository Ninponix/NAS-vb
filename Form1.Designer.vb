<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBanner1 = New NAS_vb.TextBanner()
        Me.SuspendLayout()
        '
        'TextBanner1
        '
        Me.TextBanner1.AdUpdateRate = 25000
        Me.TextBanner1.BackColor = System.Drawing.Color.White
        Me.TextBanner1.BannerDescription = "Banner Description"
        Me.TextBanner1.BannerDescriptionFont = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.TextBanner1.BannerSizeFormat = NAS_vb.TextBanner.BannerSize.Normal
        Me.TextBanner1.BannerTitle = "Banner Text"
        Me.TextBanner1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBanner1.DeveloperID = 0
        Me.TextBanner1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBanner1.LinkURL = ""
        Me.TextBanner1.Location = New System.Drawing.Point(320, 13)
        Me.TextBanner1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBanner1.Name = "TextBanner1"
        Me.TextBanner1.Size = New System.Drawing.Size(300, 75)
        Me.TextBanner1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 104)
        Me.Controls.Add(Me.TextBanner1)
        Me.Name = "Form1"
        Me.Text = "Windows Form Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBanner1 As TextBanner
End Class
