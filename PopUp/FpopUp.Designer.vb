<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FpopUp
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FpopUp))
      Me.PnlBwh = New DevExpress.XtraEditors.PanelControl()
      Me.CmdCancel = New System.Windows.Forms.Button()
      Me.CmdApply = New System.Windows.Forms.Button()
      Me.G = New C1.Win.C1FlexGrid.C1FlexGrid()
      CType(Me.PnlBwh, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PnlBwh.SuspendLayout()
      CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PnlBwh
      '
      Me.PnlBwh.Controls.Add(Me.CmdCancel)
      Me.PnlBwh.Controls.Add(Me.CmdApply)
      Me.PnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.PnlBwh.Location = New System.Drawing.Point(1, 212)
      Me.PnlBwh.Name = "PnlBwh"
      Me.PnlBwh.Size = New System.Drawing.Size(271, 38)
      Me.PnlBwh.TabIndex = 2
      '
      'CmdCancel
      '
      Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.CmdCancel.Location = New System.Drawing.Point(83, 5)
      Me.CmdCancel.Name = "CmdCancel"
      Me.CmdCancel.Size = New System.Drawing.Size(47, 28)
      Me.CmdCancel.TabIndex = 2
      Me.CmdCancel.Text = "Esc"
      Me.CmdCancel.UseVisualStyleBackColor = True
      '
      'CmdApply
      '
      Me.CmdApply.Location = New System.Drawing.Point(30, 5)
      Me.CmdApply.Name = "CmdApply"
      Me.CmdApply.Size = New System.Drawing.Size(47, 28)
      Me.CmdApply.TabIndex = 1
      Me.CmdApply.Text = "Apply"
      Me.CmdApply.UseVisualStyleBackColor = True
      '
      'G
      '
      Me.G.AllowEditing = False
      Me.G.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
      Me.G.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
      Me.G.AutoGenerateColumns = False
      Me.G.BackColor = System.Drawing.Color.White
      Me.G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
      Me.G.ColumnInfo = resources.GetString("G.ColumnInfo")
      Me.G.Dock = System.Windows.Forms.DockStyle.Fill
      Me.G.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
      Me.G.ForeColor = System.Drawing.Color.Black
      Me.G.Location = New System.Drawing.Point(1, 22)
      Me.G.Name = "G"
      Me.G.Rows.Count = 5
      Me.G.Rows.DefaultSize = 20
      Me.G.Rows.Fixed = 0
      Me.G.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.G.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.G.ShowCellLabels = True
      Me.G.ShowCursor = True
      Me.G.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
      Me.G.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
      Me.G.Size = New System.Drawing.Size(271, 190)
      Me.G.StyleInfo = resources.GetString("G.StyleInfo")
      Me.G.TabIndex = 0
      Me.G.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
      Me.G.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver
      '
      'FpopUp
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.CancelButton = Me.CmdCancel
      Me.ClientSize = New System.Drawing.Size(276, 254)
      Me.ControlBox = False
      Me.Controls.Add(Me.G)
      Me.Controls.Add(Me.PnlBwh)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FpopUp"
      Me.Padding = New System.Windows.Forms.Padding(1, 22, 4, 4)
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.Text = "sdf"
      CType(Me.PnlBwh, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PnlBwh.ResumeLayout(False)
      CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents PnlBwh As DevExpress.XtraEditors.PanelControl
   Friend WithEvents G As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents CmdCancel As System.Windows.Forms.Button
   Friend WithEvents CmdApply As System.Windows.Forms.Button
End Class
