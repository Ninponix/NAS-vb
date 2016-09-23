<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphBanner
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
        Me.GraphUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.graph_view = New System.Windows.Forms.PictureBox()
        CType(Me.graph_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraphUpdater
        '
        Me.GraphUpdater.Enabled = True
        Me.GraphUpdater.Interval = 25000
        '
        'graph_view
        '
        Me.graph_view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.graph_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graph_view.ErrorImage = Nothing
        Me.graph_view.InitialImage = Nothing
        Me.graph_view.Location = New System.Drawing.Point(0, 0)
        Me.graph_view.Name = "graph_view"
        Me.graph_view.Size = New System.Drawing.Size(300, 75)
        Me.graph_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.graph_view.TabIndex = 1
        Me.graph_view.TabStop = False
        '
        'GraphBanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.graph_view)
        Me.Name = "GraphBanner"
        Me.Size = New System.Drawing.Size(300, 75)
        CType(Me.graph_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GraphUpdater As Timer
    Private WithEvents graph_view As PictureBox
End Class
