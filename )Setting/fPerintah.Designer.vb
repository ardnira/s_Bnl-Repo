<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPerintah
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
        Me.tSetPerintah = New System.Windows.Forms.TextBox()
        Me.tGetPerintah = New System.Windows.Forms.TextBox()
        Me.Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.tInterval = New System.Windows.Forms.NumericUpDown()
        Me.klp = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ck_Pin = New System.Windows.Forms.CheckBox()
        Me.L_id = New System.Windows.Forms.Label()
        CType(Me.tInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.klp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tSetPerintah
        '
        Me.tSetPerintah.Location = New System.Drawing.Point(83, 23)
        Me.tSetPerintah.Name = "tSetPerintah"
        Me.tSetPerintah.Size = New System.Drawing.Size(131, 20)
        Me.tSetPerintah.TabIndex = 0
        '
        'tGetPerintah
        '
        Me.tGetPerintah.Location = New System.Drawing.Point(83, 49)
        Me.tGetPerintah.Name = "tGetPerintah"
        Me.tGetPerintah.Size = New System.Drawing.Size(131, 20)
        Me.tGetPerintah.TabIndex = 0
        '
        'Tmr
        '
        '
        'tInterval
        '
        Me.tInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tInterval.Location = New System.Drawing.Point(238, 94)
        Me.tInterval.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.tInterval.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.tInterval.Name = "tInterval"
        Me.tInterval.Size = New System.Drawing.Size(55, 20)
        Me.tInterval.TabIndex = 2
        Me.tInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tInterval.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'klp
        '
        Me.klp.Location = New System.Drawing.Point(223, 22)
        Me.klp.Name = "klp"
        Me.klp.Size = New System.Drawing.Size(23, 20)
        Me.klp.TabIndex = 3
        Me.klp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Set Parent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Get Client"
        '
        'Ck_Pin
        '
        Me.Ck_Pin.AutoSize = True
        Me.Ck_Pin.Location = New System.Drawing.Point(30, 99)
        Me.Ck_Pin.Name = "Ck_Pin"
        Me.Ck_Pin.Size = New System.Drawing.Size(41, 17)
        Me.Ck_Pin.TabIndex = 5
        Me.Ck_Pin.Text = "Pin"
        Me.Ck_Pin.UseVisualStyleBackColor = True
        '
        'L_id
        '
        Me.L_id.AutoSize = True
        Me.L_id.ForeColor = System.Drawing.Color.Yellow
        Me.L_id.Location = New System.Drawing.Point(12, 77)
        Me.L_id.Name = "L_id"
        Me.L_id.Size = New System.Drawing.Size(39, 13)
        Me.L_id.TabIndex = 6
        Me.L_id.Text = "Label3"
        '
        'fPerintah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(325, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.L_id)
        Me.Controls.Add(Me.Ck_Pin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.klp)
        Me.Controls.Add(Me.tInterval)
        Me.Controls.Add(Me.tGetPerintah)
        Me.Controls.Add(Me.tSetPerintah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "fPerintah"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.tInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.klp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tSetPerintah As TextBox
    Friend WithEvents tGetPerintah As TextBox
    Friend WithEvents Tmr As Timer
    Friend WithEvents tInterval As NumericUpDown
    Friend WithEvents klp As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ck_Pin As CheckBox
    Friend WithEvents L_id As Label
End Class
