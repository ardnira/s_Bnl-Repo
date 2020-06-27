<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fData
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fData))
      Me.Spl = New System.Windows.Forms.SplitContainer()
      Me.gE = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
      Me.pnl_proses = New System.Windows.Forms.Panel()
      Me.bt_Edit = New System.Windows.Forms.Button()
      Me.bt_Add = New System.Windows.Forms.Button()
      Me.bt_Del = New System.Windows.Forms.Button()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.l_detil = New System.Windows.Forms.Label()
        Me.lCount = New System.Windows.Forms.Label()
        Me.G = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.pnlCari = New System.Windows.Forms.Panel()
        Me.bt_Print = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_Colapse = New System.Windows.Forms.Button()
        Me.btMax = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pjok_2 = New System.Windows.Forms.Label()
        Me.pjok_1 = New System.Windows.Forms.Label()
        Me.pjok_0 = New System.Windows.Forms.Label()
        Me.pjok_3 = New System.Windows.Forms.Label()
        Me.Ljudul = New System.Windows.Forms.Label()
        Me.lLoading = New System.Windows.Forms.Label()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnl_Cap_Data = New System.Windows.Forms.Panel()
        CType(Me.Spl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Spl.Panel1.SuspendLayout()
        Me.Spl.Panel2.SuspendLayout()
        Me.Spl.SuspendLayout()
        CType(Me.gE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_proses.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCari.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Spl
        '
        Me.Spl.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Spl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Spl.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Spl.Location = New System.Drawing.Point(5, 33)
        Me.Spl.Name = "Spl"
        '
        'Spl.Panel1
        '
        Me.Spl.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Spl.Panel1.Controls.Add(Me.gE)
        Me.Spl.Panel1.Controls.Add(Me.pnl_proses)
        Me.Spl.Panel1.Controls.Add(Me.Panel1)
        Me.Spl.Panel1MinSize = 177
        '
        'Spl.Panel2
        '
        Me.Spl.Panel2.BackColor = System.Drawing.Color.White
        Me.Spl.Panel2.Controls.Add(Me.lCount)
        Me.Spl.Panel2.Controls.Add(Me.G)
        Me.Spl.Panel2.Controls.Add(Me.pnlCari)
        Me.Spl.Size = New System.Drawing.Size(785, 341)
        Me.Spl.SplitterDistance = 177
        Me.Spl.SplitterWidth = 7
        Me.Spl.TabIndex = 0
        '
        'gE
        '
        Me.gE.BackColor = System.Drawing.Color.OldLace
        Me.gE.BackColorAlternate = System.Drawing.Color.Beige
        Me.gE.BackColorBkg = System.Drawing.Color.White
        Me.gE.BackColorFixed = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gE.BackColorSel = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gE.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.gE.Cols = 2
        Me.gE.ColumnInfo = resources.GetString("gE.ColumnInfo")
        Me.gE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gE.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.gE.ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMoveRows
        Me.gE.FixedRows = 0
        Me.gE.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy
        Me.gE.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.gE.ForeColor = System.Drawing.Color.Maroon
        Me.gE.ForeColorFixed = System.Drawing.Color.Black
        Me.gE.ForeColorSel = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gE.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gE.GridColorFixed = System.Drawing.Color.Gainsboro
        Me.gE.GridLines = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlatHorz
        Me.gE.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlat
        Me.gE.Location = New System.Drawing.Point(0, 53)
        Me.gE.Name = "gE"
        Me.gE.NodeClosedPicture = Nothing
        Me.gE.NodeOpenPicture = Nothing
        Me.gE.OutlineCol = -1
        Me.gE.Rows = 1
        Me.gE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gE.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.gE.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.gE.SheetBorder = System.Drawing.Color.White
        Me.gE.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.gE.ShowCellLabels = True
        Me.gE.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.gE.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.gE.Size = New System.Drawing.Size(177, 241)
        Me.gE.StyleInfo = resources.GetString("gE.StyleInfo")
        Me.gE.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
        Me.gE.TabIndex = 136
        Me.gE.TreeColor = System.Drawing.Color.DarkGray
        '
        'pnl_proses
        '
        Me.pnl_proses.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_proses.Controls.Add(Me.bt_Edit)
        Me.pnl_proses.Controls.Add(Me.bt_Add)
        Me.pnl_proses.Controls.Add(Me.bt_Del)
        Me.pnl_proses.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_proses.Location = New System.Drawing.Point(0, 294)
        Me.pnl_proses.Name = "pnl_proses"
        Me.pnl_proses.Size = New System.Drawing.Size(177, 47)
        Me.pnl_proses.TabIndex = 138
        '
        'bt_Edit
        '
        Me.bt_Edit.BackColor = System.Drawing.Color.Transparent
        Me.bt_Edit.FlatAppearance.BorderSize = 0
        Me.bt_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.bt_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Edit.ForeColor = System.Drawing.Color.Black
        Me.bt_Edit.Image = CType(resources.GetObject("bt_Edit.Image"), System.Drawing.Image)
        Me.bt_Edit.Location = New System.Drawing.Point(64, 12)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(49, 23)
        Me.bt_Edit.TabIndex = 135
        Me.bt_Edit.Text = "Edit"
        Me.bt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Edit.UseVisualStyleBackColor = False
        '
        'bt_Add
        '
        Me.bt_Add.BackColor = System.Drawing.Color.Transparent
        Me.bt_Add.FlatAppearance.BorderSize = 0
        Me.bt_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.bt_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Add.ForeColor = System.Drawing.Color.Black
        Me.bt_Add.Image = CType(resources.GetObject("bt_Add.Image"), System.Drawing.Image)
        Me.bt_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Add.Location = New System.Drawing.Point(11, 12)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.Size = New System.Drawing.Size(50, 23)
        Me.bt_Add.TabIndex = 134
        Me.bt_Add.Text = "Add"
        Me.bt_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'bt_Del
        '
        Me.bt_Del.BackColor = System.Drawing.Color.Transparent
        Me.bt_Del.FlatAppearance.BorderSize = 0
        Me.bt_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.bt_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Del.ForeColor = System.Drawing.Color.Black
        Me.bt_Del.Image = CType(resources.GetObject("bt_Del.Image"), System.Drawing.Image)
        Me.bt_Del.Location = New System.Drawing.Point(116, 12)
        Me.bt_Del.Name = "bt_Del"
        Me.bt_Del.Size = New System.Drawing.Size(49, 23)
        Me.bt_Del.TabIndex = 135
        Me.bt_Del.Text = "Del"
        Me.bt_Del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Del.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.l_detil)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 53)
        Me.Panel1.TabIndex = 141
        '
        'l_detil
        '
        Me.l_detil.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.l_detil.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_detil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.l_detil.ForeColor = System.Drawing.Color.Red
        Me.l_detil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_detil.Location = New System.Drawing.Point(0, 2)
        Me.l_detil.Name = "l_detil"
        Me.l_detil.Size = New System.Drawing.Size(177, 51)
        Me.l_detil.TabIndex = 0
        Me.l_detil.Text = "Detil"
        Me.l_detil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lCount
        '
        Me.lCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lCount.AutoSize = True
        Me.lCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lCount.Location = New System.Drawing.Point(5, 310)
        Me.lCount.Name = "lCount"
        Me.lCount.Size = New System.Drawing.Size(36, 13)
        Me.lCount.TabIndex = 139
        Me.lCount.Text = "lcount"
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.White
        Me.G.BackColorAlternate = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.G.BackColorBkg = System.Drawing.Color.White
        Me.G.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.G.BackColorSel = System.Drawing.Color.Silver
        Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.G.Cols = 7
        Me.G.ColumnInfo = "7,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:62;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.G.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.G.ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMoveRows
        Me.G.FixedCols = 0
        Me.G.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.G.ForeColor = System.Drawing.Color.Maroon
        Me.G.ForeColorFixed = System.Drawing.Color.Black
        Me.G.ForeColorSel = System.Drawing.Color.Blue
        Me.G.GridColor = System.Drawing.Color.WhiteSmoke
        Me.G.GridColorFixed = System.Drawing.Color.Black
        Me.G.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridSkipHorz
        Me.G.Location = New System.Drawing.Point(0, 32)
        Me.G.Name = "G"
        Me.G.NodeClosedPicture = Nothing
        Me.G.NodeOpenPicture = Nothing
        Me.G.OutlineCol = -1
        Me.G.Rows = 2
        Me.G.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.G.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.G.SheetBorder = System.Drawing.Color.White
        Me.G.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.G.Size = New System.Drawing.Size(601, 309)
        Me.G.StyleInfo = resources.GetString("G.StyleInfo")
        Me.G.TabIndex = 131
        Me.G.TreeColor = System.Drawing.Color.DarkGray
        '
        'pnlCari
        '
        Me.pnlCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlCari.Controls.Add(Me.bt_Print)
        Me.pnlCari.Controls.Add(Me.Button1)
        Me.pnlCari.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCari.Location = New System.Drawing.Point(0, 0)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.pnlCari.Size = New System.Drawing.Size(601, 32)
        Me.pnlCari.TabIndex = 132
        '
        'bt_Print
        '
        Me.bt_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_Print.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Print.Location = New System.Drawing.Point(498, 5)
        Me.bt_Print.Name = "bt_Print"
        Me.bt_Print.Size = New System.Drawing.Size(97, 23)
        Me.bt_Print.TabIndex = 141
        Me.bt_Print.Text = "Preview [Ctrl + P]"
        Me.bt_Print.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "        Cari [F3]"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_Colapse
        '
        Me.bt_Colapse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_Colapse.FlatAppearance.BorderSize = 0
        Me.bt_Colapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.bt_Colapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Colapse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_Colapse.ForeColor = System.Drawing.Color.White
        Me.bt_Colapse.Image = CType(resources.GetObject("bt_Colapse.Image"), System.Drawing.Image)
        Me.bt_Colapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Colapse.Location = New System.Drawing.Point(6, 8)
        Me.bt_Colapse.Name = "bt_Colapse"
        Me.bt_Colapse.Size = New System.Drawing.Size(28, 18)
        Me.bt_Colapse.TabIndex = 138
        Me.bt_Colapse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Colapse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Colapse.UseVisualStyleBackColor = False
        '
        'btMax
        '
        Me.btMax.AccessibleDescription = "tSiswa"
        Me.btMax.AccessibleName = ""
        Me.btMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMax.BackColor = System.Drawing.Color.LightGray
        Me.btMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btMax.FlatAppearance.BorderSize = 0
        Me.btMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMax.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.btMax.ForeColor = System.Drawing.Color.Azure
        Me.btMax.Image = CType(resources.GetObject("btMax.Image"), System.Drawing.Image)
        Me.btMax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMax.Location = New System.Drawing.Point(734, 8)
        Me.btMax.Margin = New System.Windows.Forms.Padding(0)
        Me.btMax.Name = "btMax"
        Me.btMax.Size = New System.Drawing.Size(23, 20)
        Me.btMax.TabIndex = 131
        Me.btMax.Tag = " (Ctrl+W)"
        Me.btMax.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btMax.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btMax.UseVisualStyleBackColor = False
        '
        'btClose
        '
        Me.btClose.AccessibleDescription = "tSiswa"
        Me.btClose.AccessibleName = ""
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.BackColor = System.Drawing.Color.LightGray
        Me.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btClose.FlatAppearance.BorderSize = 0
        Me.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btClose.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.btClose.ForeColor = System.Drawing.Color.Azure
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btClose.Location = New System.Drawing.Point(761, 8)
        Me.btClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(23, 20)
        Me.btClose.TabIndex = 132
        Me.btClose.Tag = " (Ctrl+W)"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(5, 374)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(785, 16)
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pjok_2
        '
        Me.pjok_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pjok_2.BackColor = System.Drawing.Color.Gray
        Me.pjok_2.Enabled = False
        Me.pjok_2.Location = New System.Drawing.Point(775, 384)
        Me.pjok_2.Name = "pjok_2"
        Me.pjok_2.Size = New System.Drawing.Size(3, 3)
        Me.pjok_2.TabIndex = 135
        Me.pjok_2.Visible = False
        '
        'pjok_1
        '
        Me.pjok_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pjok_1.BackColor = System.Drawing.Color.Gray
        Me.pjok_1.Enabled = False
        Me.pjok_1.Location = New System.Drawing.Point(779, 380)
        Me.pjok_1.Name = "pjok_1"
        Me.pjok_1.Size = New System.Drawing.Size(3, 3)
        Me.pjok_1.TabIndex = 135
        Me.pjok_1.Visible = False
        '
        'pjok_0
        '
        Me.pjok_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pjok_0.BackColor = System.Drawing.Color.Gray
        Me.pjok_0.Enabled = False
        Me.pjok_0.Location = New System.Drawing.Point(783, 376)
        Me.pjok_0.Name = "pjok_0"
        Me.pjok_0.Size = New System.Drawing.Size(3, 3)
        Me.pjok_0.TabIndex = 135
        Me.pjok_0.Visible = False
        '
        'pjok_3
        '
        Me.pjok_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pjok_3.BackColor = System.Drawing.Color.Gray
        Me.pjok_3.Enabled = False
        Me.pjok_3.Location = New System.Drawing.Point(783, 384)
        Me.pjok_3.Name = "pjok_3"
        Me.pjok_3.Size = New System.Drawing.Size(3, 3)
        Me.pjok_3.TabIndex = 136
        Me.pjok_3.Visible = False
        '
        'Ljudul
        '
        Me.Ljudul.BackColor = System.Drawing.Color.CadetBlue
        Me.Ljudul.Font = New System.Drawing.Font("Agency FB", 14.0!)
        Me.Ljudul.ForeColor = System.Drawing.Color.White
        Me.Ljudul.Location = New System.Drawing.Point(183, 4)
        Me.Ljudul.Name = "Ljudul"
        Me.Ljudul.Size = New System.Drawing.Size(160, 27)
        Me.Ljudul.TabIndex = 137
        Me.Ljudul.Text = "Form Daftar Bangunan"
        '
        'lLoading
        '
        Me.lLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lLoading.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lLoading.Location = New System.Drawing.Point(285, 157)
        Me.lLoading.Name = "lLoading"
        Me.lLoading.Size = New System.Drawing.Size(224, 59)
        Me.lLoading.TabIndex = 140
        Me.lLoading.Text = "Loading ..."
        Me.lLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctxMenu
        '
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(61, 4)
        '
        'pnl_Cap_Data
        '
        Me.pnl_Cap_Data.BackColor = System.Drawing.Color.CadetBlue
        Me.pnl_Cap_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_Cap_Data.Location = New System.Drawing.Point(129, 4)
        Me.pnl_Cap_Data.Name = "pnl_Cap_Data"
        Me.pnl_Cap_Data.Size = New System.Drawing.Size(54, 53)
        Me.pnl_Cap_Data.TabIndex = 141
        '
        'fData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(795, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_Cap_Data)
        Me.Controls.Add(Me.bt_Colapse)
        Me.Controls.Add(Me.lLoading)
        Me.Controls.Add(Me.Ljudul)
        Me.Controls.Add(Me.pjok_3)
        Me.Controls.Add(Me.pjok_0)
        Me.Controls.Add(Me.pjok_1)
        Me.Controls.Add(Me.pjok_2)
        Me.Controls.Add(Me.btMax)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.Spl)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fData"
        Me.Padding = New System.Windows.Forms.Padding(5, 33, 5, 3)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.Spl.Panel1.ResumeLayout(False)
        Me.Spl.Panel2.ResumeLayout(False)
        Me.Spl.Panel2.PerformLayout()
        CType(Me.Spl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Spl.ResumeLayout(False)
        CType(Me.gE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_proses.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCari.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Spl As SplitContainer
   Friend WithEvents btMax As Button
   Friend WithEvents btClose As Button
   Friend WithEvents l_detil As Label
   Friend WithEvents G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
   Friend WithEvents PictureBox1 As PictureBox
   Friend WithEvents bt_Add As Button
   Friend WithEvents bt_Del As Button
   Friend WithEvents pjok_2 As Label
   Friend WithEvents pjok_1 As Label
   Friend WithEvents pjok_0 As Label
   Friend WithEvents pjok_3 As Label
   Friend WithEvents bt_Edit As Button
   Friend WithEvents Ljudul As Label
   Friend WithEvents pnl_proses As Panel
   Friend WithEvents bt_Colapse As Button
   Friend WithEvents pnlCari As Panel
   Friend WithEvents lCount As Label
   Friend WithEvents lLoading As Label
   Friend WithEvents ctxMenu As ContextMenuStrip
   Friend WithEvents Button1 As Button
   Friend WithEvents bt_Print As Button
   Friend WithEvents Panel1 As Panel
   Friend WithEvents gE As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents pnl_Cap_Data As Panel
End Class
