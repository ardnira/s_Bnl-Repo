<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fStart
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
      Me.components = New System.ComponentModel.Container()
      Me.btApply = New System.Windows.Forms.Button()
      Me.btCancel = New System.Windows.Forms.Button()
      Me.tmr_f12 = New System.Windows.Forms.Timer(Me.components)
      Me.tPassword = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.tServer = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.tLogin = New System.Windows.Forms.TextBox()
      Me.l_f12 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'btApply
      '
      Me.btApply.Location = New System.Drawing.Point(254, 64)
      Me.btApply.Name = "btApply"
      Me.btApply.Size = New System.Drawing.Size(74, 31)
      Me.btApply.TabIndex = 2
      Me.btApply.Text = "Apply"
      Me.btApply.UseVisualStyleBackColor = True
      '
      'btCancel
      '
      Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btCancel.Location = New System.Drawing.Point(334, 64)
      Me.btCancel.Name = "btCancel"
      Me.btCancel.Size = New System.Drawing.Size(74, 31)
      Me.btCancel.TabIndex = 2
      Me.btCancel.Text = "Cancel"
      Me.btCancel.UseVisualStyleBackColor = True
      '
      'tmr_f12
      '
      '
      'tPassword
      '
      Me.tPassword.Location = New System.Drawing.Point(77, 74)
      Me.tPassword.Name = "tPassword"
      Me.tPassword.Size = New System.Drawing.Size(136, 20)
      Me.tPassword.TabIndex = 6
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(38, 27)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(38, 13)
      Me.Label1.TabIndex = 7
      Me.Label1.Text = "Server"
      '
      'tServer
      '
      Me.tServer.Location = New System.Drawing.Point(77, 24)
      Me.tServer.Name = "tServer"
      Me.tServer.Size = New System.Drawing.Size(136, 20)
      Me.tServer.TabIndex = 4
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(23, 77)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(53, 13)
      Me.Label3.TabIndex = 8
      Me.Label3.Text = "Password"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(43, 51)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(33, 13)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Login"
      '
      'tLogin
      '
      Me.tLogin.Location = New System.Drawing.Point(77, 49)
      Me.tLogin.Name = "tLogin"
      Me.tLogin.Size = New System.Drawing.Size(136, 20)
      Me.tLogin.TabIndex = 5
      '
      'l_f12
      '
      Me.l_f12.AutoSize = True
      Me.l_f12.Location = New System.Drawing.Point(251, 24)
      Me.l_f12.Name = "l_f12"
      Me.l_f12.Size = New System.Drawing.Size(30, 13)
      Me.l_f12.TabIndex = 10
      Me.l_f12.Text = "l_f12"
      Me.l_f12.Visible = False
      '
      'fStart
      '
      Me.AcceptButton = Me.btApply
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.btCancel
      Me.ClientSize = New System.Drawing.Size(434, 111)
      Me.Controls.Add(Me.l_f12)
      Me.Controls.Add(Me.tPassword)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.tServer)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.tLogin)
      Me.Controls.Add(Me.btCancel)
      Me.Controls.Add(Me.btApply)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.KeyPreview = True
      Me.Name = "fStart"
      Me.Text = "Set Server "
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btApply As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents tmr_f12 As Timer
    Friend WithEvents tPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tServer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tLogin As TextBox
    Friend WithEvents l_f12 As Label
End Class
