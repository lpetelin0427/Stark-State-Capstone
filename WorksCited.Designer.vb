<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorksCited
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Top10QBLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Top10RBLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.Top10WRLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.Top10DTLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.Top10LBLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Top10QBLnkLbl
        '
        Me.Top10QBLnkLbl.AutoSize = True
        Me.Top10QBLnkLbl.Location = New System.Drawing.Point(212, 96)
        Me.Top10QBLnkLbl.Name = "Top10QBLnkLbl"
        Me.Top10QBLnkLbl.Size = New System.Drawing.Size(143, 17)
        Me.Top10QBLnkLbl.TabIndex = 2
        Me.Top10QBLnkLbl.TabStop = True
        Me.Top10QBLnkLbl.Text = "Top 10 Quarterbacks"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(153, 64)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(263, 17)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "All statistics used from Sports Reference"
        '
        'Top10RBLnkLbl
        '
        Me.Top10RBLnkLbl.AutoSize = True
        Me.Top10RBLnkLbl.Location = New System.Drawing.Point(212, 126)
        Me.Top10RBLnkLbl.Name = "Top10RBLnkLbl"
        Me.Top10RBLnkLbl.Size = New System.Drawing.Size(151, 17)
        Me.Top10RBLnkLbl.TabIndex = 4
        Me.Top10RBLnkLbl.TabStop = True
        Me.Top10RBLnkLbl.Text = "Top 10 Running backs"
        '
        'Top10WRLnkLbl
        '
        Me.Top10WRLnkLbl.AutoSize = True
        Me.Top10WRLnkLbl.Location = New System.Drawing.Point(212, 157)
        Me.Top10WRLnkLbl.Name = "Top10WRLnkLbl"
        Me.Top10WRLnkLbl.Size = New System.Drawing.Size(156, 17)
        Me.Top10WRLnkLbl.TabIndex = 5
        Me.Top10WRLnkLbl.TabStop = True
        Me.Top10WRLnkLbl.Text = "Top 10 Wide Receivers"
        '
        'Top10DTLnkLbl
        '
        Me.Top10DTLnkLbl.AutoSize = True
        Me.Top10DTLnkLbl.Location = New System.Drawing.Point(195, 184)
        Me.Top10DTLnkLbl.Name = "Top10DTLnkLbl"
        Me.Top10DTLnkLbl.Size = New System.Drawing.Size(173, 17)
        Me.Top10DTLnkLbl.TabIndex = 6
        Me.Top10DTLnkLbl.TabStop = True
        Me.Top10DTLnkLbl.Text = "Top 10 Defensive Tackles"
        '
        'Top10LBLnkLbl
        '
        Me.Top10LBLnkLbl.AutoSize = True
        Me.Top10LBLnkLbl.Location = New System.Drawing.Point(215, 218)
        Me.Top10LBLnkLbl.Name = "Top10LBLnkLbl"
        Me.Top10LBLnkLbl.Size = New System.Drawing.Size(134, 17)
        Me.Top10LBLnkLbl.TabIndex = 7
        Me.Top10LBLnkLbl.TabStop = True
        Me.Top10LBLnkLbl.Text = "Top 10 Linebackers"
        '
        'WorksCited
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 353)
        Me.Controls.Add(Me.Top10LBLnkLbl)
        Me.Controls.Add(Me.Top10DTLnkLbl)
        Me.Controls.Add(Me.Top10WRLnkLbl)
        Me.Controls.Add(Me.Top10RBLnkLbl)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Top10QBLnkLbl)
        Me.Name = "WorksCited"
        Me.Text = "WorksCited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Top10QBLnkLbl As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Top10RBLnkLbl As LinkLabel
    Friend WithEvents Top10WRLnkLbl As LinkLabel
    Friend WithEvents Top10DTLnkLbl As LinkLabel
    Friend WithEvents Top10LBLnkLbl As LinkLabel
End Class
