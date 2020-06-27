<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHelp
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
        Me.Rtf = New System.Windows.Forms.RichTextBox()
        Me.lHelp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Rtf
        '
        Me.Rtf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rtf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rtf.Location = New System.Drawing.Point(33, 35)
        Me.Rtf.Name = "Rtf"
        Me.Rtf.ReadOnly = True
        Me.Rtf.Size = New System.Drawing.Size(279, 373)
        Me.Rtf.TabIndex = 2
        Me.Rtf.Text = ""
        '
        'lHelp
        '
        Me.lHelp.AutoSize = True
        Me.lHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lHelp.Location = New System.Drawing.Point(33, 22)
        Me.lHelp.Name = "lHelp"
        Me.lHelp.Size = New System.Drawing.Size(29, 13)
        Me.lHelp.TabIndex = 3
        Me.lHelp.Text = "Help"
        '
        'fHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 430)
        Me.Controls.Add(Me.Rtf)
        Me.Controls.Add(Me.lHelp)
        Me.KeyPreview = True
        Me.Name = "fHelp"
        Me.Padding = New System.Windows.Forms.Padding(33, 22, 22, 22)
        Me.Text = "fHelp"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rtf As RichTextBox
    Friend WithEvents lHelp As Label
End Class
