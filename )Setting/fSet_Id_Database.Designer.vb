<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fSet_Id_Database
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSet_Id_Database))
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaColorTransition1 = New Guna.UI.WinForms.GunaColorTransition(Me.components)
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.RyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.G = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.l_idPilih = New System.Windows.Forms.Label()
        Me.pnl = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Cancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmd_Apply = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaContextMenuStrip1.SuspendLayout()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.GunaAnimateWindow1.Interval = 1000
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'GunaColorTransition1
        '
        Me.GunaColorTransition1.AutoTransition = True
        Me.GunaColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        Me.GunaColorTransition1.EndColor = System.Drawing.Color.Blue
        Me.GunaColorTransition1.StartColor = System.Drawing.Color.Red
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RyToolStripMenuItem, Me.ToolStripComboBox1, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripMenuItem1})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(182, 106)
        '
        'RyToolStripMenuItem
        '
        Me.RyToolStripMenuItem.Name = "RyToolStripMenuItem"
        Me.RyToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RyToolStripMenuItem.Text = "ry"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.White
        Me.G.BackColorAlternate = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.G.BackColorBkg = System.Drawing.Color.White
        Me.G.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.G.BackColorSel = System.Drawing.Color.Silver
        Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.G.Cols = 4
        Me.G.ColumnInfo = "4,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:62;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.G.Dock = System.Windows.Forms.DockStyle.Left
        Me.G.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.G.ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExNone
        Me.G.FillStyle = C1.Win.C1FlexGrid.Classic.FillStyleSettings.flexFillRepeat
        Me.G.FixedCols = 0
        Me.G.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.G.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.G.ForeColor = System.Drawing.Color.Maroon
        Me.G.ForeColorFixed = System.Drawing.Color.Black
        Me.G.ForeColorSel = System.Drawing.Color.Blue
        Me.G.GridColor = System.Drawing.Color.WhiteSmoke
        Me.G.GridColorFixed = System.Drawing.Color.Black
        Me.G.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridSkipHorz
        Me.G.Location = New System.Drawing.Point(11, 11)
        Me.G.Name = "G"
        Me.G.NodeClosedPicture = Nothing
        Me.G.NodeOpenPicture = Nothing
        Me.G.OutlineCol = -1
        Me.G.Rows = 8
        Me.G.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.G.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.G.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.G.SheetBorder = System.Drawing.Color.White
        Me.G.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.G.Size = New System.Drawing.Size(180, 286)
        Me.G.StyleInfo = resources.GetString("G.StyleInfo")
        Me.G.TabIndex = 132
        Me.G.TreeColor = System.Drawing.Color.DarkGray
        '
        'l_idPilih
        '
        Me.l_idPilih.BackColor = System.Drawing.Color.White
        Me.l_idPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_idPilih.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_idPilih.ForeColor = System.Drawing.Color.Black
        Me.l_idPilih.Location = New System.Drawing.Point(9, 53)
        Me.l_idPilih.Name = "l_idPilih"
        Me.l_idPilih.Size = New System.Drawing.Size(177, 19)
        Me.l_idPilih.TabIndex = 133
        Me.l_idPilih.Text = "Label1"
        '
        'pnl
        '
        Me.pnl.BackgroundImage = CType(resources.GetObject("pnl.BackgroundImage"), System.Drawing.Image)
        Me.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl.Controls.Add(Me.Label1)
        Me.pnl.Controls.Add(Me.l_idPilih)
        Me.pnl.Controls.Add(Me.cmd_Cancel)
        Me.pnl.Controls.Add(Me.cmd_Apply)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.GradientColor1 = System.Drawing.Color.White
        Me.pnl.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl.Location = New System.Drawing.Point(191, 11)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(200, 286)
        Me.pnl.TabIndex = 134
        Me.pnl.Text = "GunaGradientPanel1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "ID yang Di Pilih: "
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.Animated = True
        Me.cmd_Cancel.AnimationHoverSpeed = 0.07!
        Me.cmd_Cancel.AnimationSpeed = 0.03!
        Me.cmd_Cancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.BorderColor = System.Drawing.Color.Black
        Me.cmd_Cancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.cmd_Cancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmd_Cancel.CheckedForeColor = System.Drawing.Color.White
        Me.cmd_Cancel.CheckedImage = CType(resources.GetObject("cmd_Cancel.CheckedImage"), System.Drawing.Image)
        Me.cmd_Cancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cancel.FocusedColor = System.Drawing.Color.Empty
        Me.cmd_Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmd_Cancel.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cmd_Cancel.Location = New System.Drawing.Point(88, 232)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmd_Cancel.OnHoverForeColor = System.Drawing.Color.White
        Me.cmd_Cancel.OnHoverImage = Nothing
        Me.cmd_Cancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cmd_Cancel.OnPressedColor = System.Drawing.Color.Black
        Me.cmd_Cancel.Size = New System.Drawing.Size(98, 40)
        Me.cmd_Cancel.TabIndex = 0
        Me.cmd_Cancel.Text = "Cancel"
        '
        'cmd_Apply
        '
        Me.cmd_Apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Apply.Animated = True
        Me.cmd_Apply.AnimationHoverSpeed = 0.07!
        Me.cmd_Apply.AnimationSpeed = 0.03!
        Me.cmd_Apply.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Apply.BorderColor = System.Drawing.Color.Black
        Me.cmd_Apply.CheckedBaseColor = System.Drawing.Color.Gray
        Me.cmd_Apply.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmd_Apply.CheckedForeColor = System.Drawing.Color.White
        Me.cmd_Apply.CheckedImage = CType(resources.GetObject("cmd_Apply.CheckedImage"), System.Drawing.Image)
        Me.cmd_Apply.CheckedLineColor = System.Drawing.Color.DimGray
        Me.cmd_Apply.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmd_Apply.FocusedColor = System.Drawing.Color.Empty
        Me.cmd_Apply.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Apply.ForeColor = System.Drawing.Color.White
        Me.cmd_Apply.Image = CType(resources.GetObject("cmd_Apply.Image"), System.Drawing.Image)
        Me.cmd_Apply.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmd_Apply.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cmd_Apply.Location = New System.Drawing.Point(88, 186)
        Me.cmd_Apply.Name = "cmd_Apply"
        Me.cmd_Apply.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Apply.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmd_Apply.OnHoverForeColor = System.Drawing.Color.White
        Me.cmd_Apply.OnHoverImage = Nothing
        Me.cmd_Apply.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cmd_Apply.OnPressedColor = System.Drawing.Color.Black
        Me.cmd_Apply.Size = New System.Drawing.Size(98, 40)
        Me.cmd_Apply.TabIndex = 0
        Me.cmd_Apply.Text = "Apply"
        '
        'fSet_Id_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.cmd_Cancel
        Me.ClientSize = New System.Drawing.Size(402, 308)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.G)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fSet_Id_Database"
        Me.Padding = New System.Windows.Forms.Padding(11)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.TopMost = True
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.GunaContextMenuStrip1.PerformLayout()
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaColorTransition1 As Guna.UI.WinForms.GunaColorTransition
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents RyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents l_idPilih As Label
    Friend WithEvents pnl As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents cmd_Cancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmd_Apply As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
End Class
