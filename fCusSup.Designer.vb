<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCusSup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCusSup))
        Me.PnlProses = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lCount = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tSrch = New System.Windows.Forms.TextBox()
        Me.lF3 = New System.Windows.Forms.Label()
        Me.lSearch = New System.Windows.Forms.LinkLabel()
        Me.Gb = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.L_Tips = New System.Windows.Forms.Label()
        Me.l_Cari = New System.Windows.Forms.Label()
        Me.PnlProses.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Gb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlProses
        '
        Me.PnlProses.Controls.Add(Me.Cancel_Button)
        Me.PnlProses.Controls.Add(Me.OK_Button)
        Me.PnlProses.Controls.Add(Me.lCount)
        Me.PnlProses.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlProses.Location = New System.Drawing.Point(8, 254)
        Me.PnlProses.Name = "PnlProses"
        Me.PnlProses.Size = New System.Drawing.Size(327, 38)
        Me.PnlProses.TabIndex = 17
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(263, 10)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(58, 26)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.OK_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OK_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OK_Button.Location = New System.Drawing.Point(202, 10)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(58, 26)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "Ok"
        Me.OK_Button.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.tSrch)
        Me.Panel2.Controls.Add(Me.lF3)
        Me.Panel2.Controls.Add(Me.lSearch)
        Me.Panel2.Location = New System.Drawing.Point(8, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 32)
        Me.Panel2.TabIndex = 19
        '
        'tSrch
        '
        Me.tSrch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tSrch.Location = New System.Drawing.Point(24, 6)
        Me.tSrch.Name = "tSrch"
        Me.tSrch.Size = New System.Drawing.Size(189, 20)
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
        Me.lSearch.Location = New System.Drawing.Point(219, 8)
        Me.lSearch.Name = "lSearch"
        Me.lSearch.Size = New System.Drawing.Size(102, 18)
        Me.lSearch.TabIndex = 2
        Me.lSearch.TabStop = True
        Me.lSearch.Text = "Cari: "
        Me.lSearch.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Gb
        '
        Me.Gb.BackColor = System.Drawing.Color.White
        Me.Gb.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.Gb.BackColorBkg = System.Drawing.Color.White
        Me.Gb.BackColorFixed = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Gb.BackColorSel = System.Drawing.Color.LightGreen
        Me.Gb.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.Gb.Cols = 4
        Me.Gb.ColumnInfo = "4,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:62;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.Gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb.FixedCols = 0
        Me.Gb.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy
        Me.Gb.GridColorFixed = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Gb.GridLineWidth = 0
        Me.Gb.Location = New System.Drawing.Point(8, 66)
        Me.Gb.Name = "Gb"
        Me.Gb.NodeClosedPicture = Nothing
        Me.Gb.NodeOpenPicture = Nothing
        Me.Gb.OutlineCol = -1
        Me.Gb.Rows = 8
        Me.Gb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Gb.SheetBorder = System.Drawing.Color.White
        Me.Gb.Size = New System.Drawing.Size(327, 188)
        Me.Gb.StyleInfo = resources.GetString("Gb.StyleInfo")
        Me.Gb.TabIndex = 18
        Me.Gb.TreeColor = System.Drawing.Color.DarkGray
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
        Me.L_Tips.Location = New System.Drawing.Point(33, 40)
        Me.L_Tips.Name = "L_Tips"
        Me.L_Tips.Size = New System.Drawing.Size(127, 13)
        Me.L_Tips.TabIndex = 20
        Me.L_Tips.Text = "Cari..."
        '
        'l_Cari
        '
        Me.l_Cari.AutoSize = True
        Me.l_Cari.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Cari.ForeColor = System.Drawing.Color.Gray
        Me.l_Cari.Location = New System.Drawing.Point(6, 6)
        Me.l_Cari.Name = "l_Cari"
        Me.l_Cari.Size = New System.Drawing.Size(43, 15)
        Me.l_Cari.TabIndex = 21
        Me.l_Cari.Text = "Label1"
        '
        'fCusSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.l_Cari)
        Me.Controls.Add(Me.L_Tips)
        Me.Controls.Add(Me.Gb)
        Me.Controls.Add(Me.PnlProses)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fCusSup"
        Me.Padding = New System.Windows.Forms.Padding(8, 66, 8, 8)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.PnlProses.ResumeLayout(False)
        Me.PnlProses.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Gb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlProses As Panel
    Friend WithEvents lCount As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lF3 As Label
    Friend WithEvents lSearch As LinkLabel
    Friend WithEvents Gb As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents tSrch As TextBox
    Friend WithEvents L_Tips As Label
    Friend WithEvents l_Cari As Label
End Class
