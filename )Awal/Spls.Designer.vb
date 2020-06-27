<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Spls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Spls))
        Me.Version = New System.Windows.Forms.Label()
        Me.l_Nm_app_this = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.peImage = New DevExpress.XtraEditors.PictureEdit()
        Me.labelStatus = New DevExpress.XtraEditors.LabelControl()
        Me.labelCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.progressBarControl = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Black
        Me.Version.Location = New System.Drawing.Point(373, 336)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(136, 17)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l_Nm_app_this
        '
        Me.l_Nm_app_this.Dock = System.Windows.Forms.DockStyle.Top
        Me.l_Nm_app_this.Font = New System.Drawing.Font("Niagara Engraved", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Nm_app_this.ForeColor = System.Drawing.Color.Black
        Me.l_Nm_app_this.Location = New System.Drawing.Point(11, 11)
        Me.l_Nm_app_this.Name = "l_Nm_app_this"
        Me.l_Nm_app_this.Size = New System.Drawing.Size(498, 18)
        Me.l_Nm_app_this.TabIndex = 5
        Me.l_Nm_app_this.Text = "Label1"
        Me.l_Nm_app_this.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Copyright
        '
        Me.Copyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Copyright.Font = New System.Drawing.Font("Niagara Engraved", 11.0!)
        Me.Copyright.ForeColor = System.Drawing.Color.Black
        Me.Copyright.Location = New System.Drawing.Point(11, 333)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(498, 23)
        Me.Copyright.TabIndex = 6
        Me.Copyright.Text = "Label1"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'peImage
        '
        Me.peImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.peImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.peImage.EditValue = CType(resources.GetObject("peImage.EditValue"), Object)
        Me.peImage.Location = New System.Drawing.Point(11, 29)
        Me.peImage.Name = "peImage"
        Me.peImage.Properties.AllowFocused = False
        Me.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peImage.Properties.Appearance.Options.UseBackColor = True
        Me.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peImage.Properties.ShowMenu = False
        Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.peImage.Size = New System.Drawing.Size(498, 200)
        Me.peImage.TabIndex = 18
        '
        'labelStatus
        '
        Me.labelStatus.Appearance.ForeColor = System.Drawing.Color.Black
        Me.labelStatus.Appearance.Options.UseForeColor = True
        Me.labelStatus.Location = New System.Drawing.Point(24, 243)
        Me.labelStatus.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(50, 13)
        Me.labelStatus.TabIndex = 17
        Me.labelStatus.Text = "Starting..."
        '
        'labelCopyright
        '
        Me.labelCopyright.Appearance.ForeColor = System.Drawing.Color.Black
        Me.labelCopyright.Appearance.Options.UseForeColor = True
        Me.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelCopyright.Location = New System.Drawing.Point(24, 315)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(47, 13)
        Me.labelCopyright.TabIndex = 16
        Me.labelCopyright.Text = "Copyright"
        '
        'progressBarControl
        '
        Me.progressBarControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBarControl.EditValue = 0
        Me.progressBarControl.Location = New System.Drawing.Point(24, 260)
        Me.progressBarControl.Name = "progressBarControl"
        Me.progressBarControl.Size = New System.Drawing.Size(469, 12)
        Me.progressBarControl.TabIndex = 15
        '
        'Spls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.peImage)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.progressBarControl)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.l_Nm_app_this)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Spls"
        Me.Padding = New System.Windows.Forms.Padding(11)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Version As Label
    Friend WithEvents l_Nm_app_this As Label
    Friend WithEvents Copyright As Label
    Private WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelStatus As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelCopyright As DevExpress.XtraEditors.LabelControl
    Private WithEvents progressBarControl As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
