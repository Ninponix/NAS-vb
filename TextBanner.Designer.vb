<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBanner
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.BannerChanger = New System.Windows.Forms.Timer(Me.components)
        Me.bannerDescriptionLabel = New System.Windows.Forms.Label()
        Me.bannerTitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BannerChanger
        '
        Me.BannerChanger.Enabled = True
        Me.BannerChanger.Interval = 25000
        '
        'bannerDescriptionLabel
        '
        Me.bannerDescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bannerDescriptionLabel.AutoEllipsis = True
        Me.bannerDescriptionLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bannerDescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bannerDescriptionLabel.ForeColor = System.Drawing.Color.Gray
        Me.bannerDescriptionLabel.Location = New System.Drawing.Point(19, 40)
        Me.bannerDescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bannerDescriptionLabel.Name = "bannerDescriptionLabel"
        Me.bannerDescriptionLabel.Size = New System.Drawing.Size(262, 21)
        Me.bannerDescriptionLabel.TabIndex = 3
        Me.bannerDescriptionLabel.Text = "Banner Description"
        '
        'bannerTitleLabel
        '
        Me.bannerTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bannerTitleLabel.AutoEllipsis = True
        Me.bannerTitleLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bannerTitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bannerTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bannerTitleLabel.Location = New System.Drawing.Point(19, 13)
        Me.bannerTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bannerTitleLabel.Name = "bannerTitleLabel"
        Me.bannerTitleLabel.Size = New System.Drawing.Size(262, 21)
        Me.bannerTitleLabel.TabIndex = 2
        Me.bannerTitleLabel.Text = "Banner Title"
        '
        'TextBanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.bannerDescriptionLabel)
        Me.Controls.Add(Me.bannerTitleLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TextBanner"
        Me.Size = New System.Drawing.Size(300, 75)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BannerChanger As Timer
    Private WithEvents bannerDescriptionLabel As Label
    Private WithEvents bannerTitleLabel As Label
End Class
