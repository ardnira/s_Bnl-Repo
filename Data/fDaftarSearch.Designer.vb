<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDaftarSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDaftarSearch))
        Me.pnlBawah = New System.Windows.Forms.Panel()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdApply = New System.Windows.Forms.Button()
        Me.lCount = New System.Windows.Forms.Label()
        Me.pnlCari = New System.Windows.Forms.Panel()
        Me.tSrch = New System.Windows.Forms.TextBox()
        Me.lF3 = New System.Windows.Forms.Label()
        Me.lSearch = New System.Windows.Forms.LinkLabel()
        Me.G = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.L_Tips = New System.Windows.Forms.Label()
        Me.l_Cari = New System.Windows.Forms.Label()
        Me.pnl_Cap_Data = New System.Windows.Forms.Panel()
        Me.pnlBawah.SuspendLayout()
        Me.pnlCari.SuspendLayout()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBawah
        '
        Me.pnlBawah.Controls.Add(Me.CmdCancel)
        Me.pnlBawah.Controls.Add(Me.CmdApply)
        Me.pnlBawah.Controls.Add(Me.lCount)
        Me.pnlBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBawah.Location = New System.Drawing.Point(8, 254)
        Me.pnlBawah.Name = "pnlBawah"
        Me.pnlBawah.Size = New System.Drawing.Size(327, 38)
        Me.pnlBawah.TabIndex = 17
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.CmdCancel.ForeColor = System.Drawing.Color.White
        Me.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdCancel.Location = New System.Drawing.Point(263, 10)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(58, 26)
        Me.CmdCancel.TabIndex = 6
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdApply
        '
        Me.CmdApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.CmdApply.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CmdApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.CmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdApply.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.CmdApply.ForeColor = System.Drawing.Color.White
        Me.CmdApply.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdApply.Location = New System.Drawing.Point(202, 10)
        Me.CmdApply.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdApply.Name = "CmdApply"
        Me.CmdApply.Size = New System.Drawing.Size(58, 26)
        Me.CmdApply.TabIndex = 5
        Me.CmdApply.Text = "Ok"
        Me.CmdApply.UseVisualStyleBackColor = False
        '
        'lCount
        '
        Me.lCount.AutoSize = True
        Me.lCount.BackColor = System.Drawing.Color.Transparent
        Me.lCount.Location = New System.Drawing.Point(7, 10)
        Me.lCount.Name = "lCount"
        Me.lCount.Size = New System.Drawing.Size(39, 13)
        Me.lCount.TabIndex = 17
        Me.lCount.Text = "Label1"
        '
        'pnlCari
        '
        Me.pnlCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCari.BackColor = System.Drawing.Color.Transparent
        Me.pnlCari.Controls.Add(Me.tSrch)
        Me.pnlCari.Controls.Add(Me.lF3)
        Me.pnlCari.Controls.Add(Me.lSearch)
        Me.pnlCari.Location = New System.Drawing.Point(60, 31)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Size = New System.Drawing.Size(276, 32)
        Me.pnlCari.TabIndex = 19
        '
        'tSrch
        '
        Me.tSrch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tSrch.Location = New System.Drawing.Point(26, 6)
        Me.tSrch.Name = "tSrch"
        Me.tSrch.Size = New System.Drawing.Size(98, 20)
        Me.tSrch.TabIndex = 9
        '
        'lF3
        '
        Me.lF3.AutoSize = True
        Me.lF3.Location = New System.Drawing.Point(4, 9)
        Me.lF3.Name = "lF3"
        Me.lF3.Size = New System.Drawing.Size(19, 13)
        Me.lF3.TabIndex = 8
        Me.lF3.Text = "F3"
        '
        'lSearch
        '
        Me.lSearch.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lSearch.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lSearch.LinkColor = System.Drawing.Color.Gray
        Me.lSearch.Location = New System.Drawing.Point(128, 8)
        Me.lSearch.Name = "lSearch"
        Me.lSearch.Size = New System.Drawing.Size(141, 18)
        Me.lSearch.TabIndex = 2
        Me.lSearch.TabStop = True
        Me.lSearch.Text = "Cari: "
        Me.lSearch.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.White
        Me.G.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.G.BackColorBkg = System.Drawing.Color.White
        Me.G.BackColorFixed = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.G.BackColorSel = System.Drawing.Color.LightGreen
        Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.G.Cols = 4
        Me.G.ColumnInfo = "4,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:62;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.G.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G.FixedCols = 0
        Me.G.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy
        Me.G.GridColorFixed = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.G.GridLineWidth = 0
        Me.G.Location = New System.Drawing.Point(8, 66)
        Me.G.Name = "G"
        Me.G.NodeClosedPicture = Nothing
        Me.G.NodeOpenPicture = Nothing
        Me.G.OutlineCol = -1
        Me.G.Rows = 8
        Me.G.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.G.SheetBorder = System.Drawing.Color.White
        Me.G.Size = New System.Drawing.Size(327, 188)
        Me.G.StyleInfo = resources.GetString("G.StyleInfo")
        Me.G.TabIndex = 18
        Me.G.TreeColor = System.Drawing.Color.DarkGray
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenu1.ShowCheckMargin = True
        Me.ContextMenu1.ShowImageMargin = False
        Me.ContextMenu1.Size = New System.Drawing.Size(61, 4)
        '
        'L_Tips
        '
        Me.L_Tips.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Tips.BackColor = System.Drawing.Color.White
        Me.L_Tips.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Tips.ForeColor = System.Drawing.Color.DarkGray
        Me.L_Tips.Location = New System.Drawing.Point(87, 40)
        Me.L_Tips.Name = "L_Tips"
        Me.L_Tips.Size = New System.Drawing.Size(94, 13)
        Me.L_Tips.TabIndex = 20
        Me.L_Tips.Text = "Cari..."
        '
        'l_Cari
        '
        Me.l_Cari.AutoSize = True
        Me.l_Cari.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Cari.ForeColor = System.Drawing.Color.Gray
        Me.l_Cari.Location = New System.Drawing.Point(57, 6)
        Me.l_Cari.Name = "l_Cari"
        Me.l_Cari.Size = New System.Drawing.Size(43, 15)
        Me.l_Cari.TabIndex = 21
        Me.l_Cari.Text = "Label1"
        '
        'pnl_Cap_Data
        '
        Me.pnl_Cap_Data.BackColor = System.Drawing.Color.Red
        Me.pnl_Cap_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_Cap_Data.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Cap_Data.Name = "pnl_Cap_Data"
        Me.pnl_Cap_Data.Size = New System.Drawing.Size(54, 53)
        Me.pnl_Cap_Data.TabIndex = 132
        '
        'fDaftarSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_Cap_Data)
        Me.Controls.Add(Me.l_Cari)
        Me.Controls.Add(Me.L_Tips)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.pnlBawah)
        Me.Controls.Add(Me.pnlCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fDaftarSearch"
        Me.Padding = New System.Windows.Forms.Padding(8, 66, 8, 8)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.pnlBawah.ResumeLayout(False)
        Me.pnlBawah.PerformLayout()
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBawah As Panel
    Friend WithEvents lCount As Label
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdApply As Button
    Friend WithEvents pnlCari As Panel
    Friend WithEvents lF3 As Label
    Friend WithEvents lSearch As LinkLabel
    Friend WithEvents G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents tSrch As TextBox
    Friend WithEvents L_Tips As Label
    Friend WithEvents l_Cari As Label
    Friend WithEvents pnl_Cap_Data As Panel
End Class
