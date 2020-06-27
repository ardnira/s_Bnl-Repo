<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHutCus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHutCus))
        Me.PnlTembel = New System.Windows.Forms.Panel()
        Me.Lperiode = New System.Windows.Forms.Label()
        Me.CkAll = New System.Windows.Forms.CheckBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.PnlTgl = New System.Windows.Forms.Panel()
        Me.tglA = New System.Windows.Forms.DateTimePicker()
        Me.tglB = New System.Windows.Forms.DateTimePicker()
        Me.lSearch = New System.Windows.Forms.LinkLabel()
        Me.PnlAtas = New System.Windows.Forms.Panel()
        Me.CmdSupCus = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tSrch = New System.Windows.Forms.TextBox()
        Me.Lsaldo = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gBawah = New System.Windows.Forms.GroupBox()
        Me.pg = New PropertyGridEx.PropertyGridEx()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.strp_Add = New System.Windows.Forms.ToolStripButton()
        Me.strp_Edit = New System.Windows.Forms.ToolStripButton()
        Me.strp_Del = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.strp_Search = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_detil = New System.Windows.Forms.Label()
        Me.pctExpand = New System.Windows.Forms.PictureBox()
        Me.G = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.lLoading = New System.Windows.Forms.Label()
        Me.spl_Utama = New System.Windows.Forms.SplitContainer()
        Me.PnlTembel.SuspendLayout()
        Me.PnlTgl.SuspendLayout()
        Me.PnlAtas.SuspendLayout()
        Me.gBawah.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pctExpand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spl_Utama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spl_Utama.Panel1.SuspendLayout()
        Me.spl_Utama.Panel2.SuspendLayout()
        Me.spl_Utama.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTembel
        '
        Me.PnlTembel.Controls.Add(Me.CkAll)
        Me.PnlTembel.Controls.Add(Me.BtnOk)
        Me.PnlTembel.Controls.Add(Me.PnlTgl)
        Me.PnlTembel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlTembel.Location = New System.Drawing.Point(461, 0)
        Me.PnlTembel.Name = "PnlTembel"
        Me.PnlTembel.Size = New System.Drawing.Size(364, 37)
        Me.PnlTembel.TabIndex = 8
        '
        'Lperiode
        '
        Me.Lperiode.AutoSize = True
        Me.Lperiode.Location = New System.Drawing.Point(3, 8)
        Me.Lperiode.Name = "Lperiode"
        Me.Lperiode.Size = New System.Drawing.Size(43, 13)
        Me.Lperiode.TabIndex = 10
        Me.Lperiode.Text = "Periode"
        '
        'CkAll
        '
        Me.CkAll.AutoSize = True
        Me.CkAll.Location = New System.Drawing.Point(279, 9)
        Me.CkAll.Name = "CkAll"
        Me.CkAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CkAll.Size = New System.Drawing.Size(37, 17)
        Me.CkAll.TabIndex = 10
        Me.CkAll.Text = "All"
        Me.CkAll.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(322, 4)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(36, 24)
        Me.BtnOk.TabIndex = 10
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'PnlTgl
        '
        Me.PnlTgl.Controls.Add(Me.tglA)
        Me.PnlTgl.Controls.Add(Me.Lperiode)
        Me.PnlTgl.Controls.Add(Me.tglB)
        Me.PnlTgl.Location = New System.Drawing.Point(2, 2)
        Me.PnlTgl.Name = "PnlTgl"
        Me.PnlTgl.Size = New System.Drawing.Size(271, 32)
        Me.PnlTgl.TabIndex = 13
        '
        'tglA
        '
        Me.tglA.CustomFormat = "  dd MMM yyyy"
        Me.tglA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglA.Location = New System.Drawing.Point(45, 5)
        Me.tglA.Name = "tglA"
        Me.tglA.Size = New System.Drawing.Size(105, 20)
        Me.tglA.TabIndex = 7
        '
        'tglB
        '
        Me.tglB.CustomFormat = "  dd MMM yyyy"
        Me.tglB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglB.Location = New System.Drawing.Point(158, 5)
        Me.tglB.Name = "tglB"
        Me.tglB.Size = New System.Drawing.Size(105, 20)
        Me.tglB.TabIndex = 9
        '
        'lSearch
        '
        Me.lSearch.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lSearch.AutoSize = True
        Me.lSearch.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lSearch.LinkColor = System.Drawing.Color.Gray
        Me.lSearch.Location = New System.Drawing.Point(263, 12)
        Me.lSearch.Name = "lSearch"
        Me.lSearch.Size = New System.Drawing.Size(31, 13)
        Me.lSearch.TabIndex = 2
        Me.lSearch.TabStop = True
        Me.lSearch.Text = "Cari: "
        Me.lSearch.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'PnlAtas
        '
        Me.PnlAtas.BackColor = System.Drawing.Color.Silver
        Me.PnlAtas.Controls.Add(Me.CmdSupCus)
        Me.PnlAtas.Controls.Add(Me.LinkLabel1)
        Me.PnlAtas.Controls.Add(Me.tSrch)
        Me.PnlAtas.Controls.Add(Me.PnlTembel)
        Me.PnlAtas.Controls.Add(Me.lSearch)
        Me.PnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.PnlAtas.Name = "PnlAtas"
        Me.PnlAtas.Size = New System.Drawing.Size(825, 37)
        Me.PnlAtas.TabIndex = 15
        '
        'CmdSupCus
        '
        Me.CmdSupCus.Location = New System.Drawing.Point(228, 7)
        Me.CmdSupCus.Name = "CmdSupCus"
        Me.CmdSupCus.Size = New System.Drawing.Size(29, 23)
        Me.CmdSupCus.TabIndex = 13
        Me.CmdSupCus.Text = "v"
        Me.CmdSupCus.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(26, 12)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Id/Nama Customer"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'tSrch
        '
        Me.tSrch.Location = New System.Drawing.Point(124, 9)
        Me.tSrch.Name = "tSrch"
        Me.tSrch.Size = New System.Drawing.Size(104, 20)
        Me.tSrch.TabIndex = 9
        '
        'Lsaldo
        '
        Me.Lsaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Lsaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lsaldo.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lsaldo.ForeColor = System.Drawing.Color.Red
        Me.Lsaldo.Location = New System.Drawing.Point(6, 31)
        Me.Lsaldo.Name = "Lsaldo"
        Me.Lsaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lsaldo.Size = New System.Drawing.Size(762, 33)
        Me.Lsaldo.TabIndex = 16
        Me.Lsaldo.Text = "Saldo Piutang:      5.700.000"
        Me.Lsaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenu1.ShowCheckMargin = True
        Me.ContextMenu1.ShowImageMargin = False
        Me.ContextMenu1.Size = New System.Drawing.Size(61, 4)
        '
        'gBawah
        '
        Me.gBawah.Controls.Add(Me.Lsaldo)
        Me.gBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gBawah.Location = New System.Drawing.Point(0, 219)
        Me.gBawah.Name = "gBawah"
        Me.gBawah.Size = New System.Drawing.Size(825, 73)
        Me.gBawah.TabIndex = 17
        Me.gBawah.TabStop = False
        Me.gBawah.Text = "GroupBox1"
        '
        'pg
        '
        Me.pg.AutoSizeProperties = True
        Me.pg.BackColor = System.Drawing.Color.LightBlue
        Me.pg.CanShowVisualStyleGlyphs = False
        Me.pg.CategoryForeColor = System.Drawing.Color.Yellow
        Me.pg.CategorySplitterColor = System.Drawing.Color.OrangeRed
        Me.pg.CausesValidation = False
        Me.pg.CommandsBackColor = System.Drawing.Color.Teal
        Me.pg.CommandsForeColor = System.Drawing.Color.White
        Me.pg.CommandsVisibleIfAvailable = False
        '
        '
        '
        Me.pg.DocCommentDescription.AccessibleName = ""
        Me.pg.DocCommentDescription.AutoEllipsis = True
        Me.pg.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.pg.DocCommentDescription.Location = New System.Drawing.Point(3, 18)
        Me.pg.DocCommentDescription.Name = ""
        Me.pg.DocCommentDescription.Size = New System.Drawing.Size(207, 37)
        Me.pg.DocCommentDescription.TabIndex = 1
        Me.pg.DocCommentDescription.UseCompatibleTextRendering = True
        Me.pg.DocCommentImage = Nothing
        '
        '
        '
        Me.pg.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.pg.DocCommentTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pg.DocCommentTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pg.DocCommentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pg.DocCommentTitle.Location = New System.Drawing.Point(3, 3)
        Me.pg.DocCommentTitle.Name = ""
        Me.pg.DocCommentTitle.Size = New System.Drawing.Size(207, 15)
        Me.pg.DocCommentTitle.TabIndex = 0
        Me.pg.DocCommentTitle.Text = "New Property"
        Me.pg.DocCommentTitle.UseCompatibleTextRendering = True
        Me.pg.DocCommentTitle.UseMnemonic = False
        Me.pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg.DrawFlatToolbar = True
        Me.pg.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.pg.Item.Add(CType(resources.GetObject("pg.Item"), PropertyGridEx.CustomProperty))
        Me.pg.Item.Add(CType(resources.GetObject("pg.Item1"), PropertyGridEx.CustomProperty))
        Me.pg.Item.Add(CType(resources.GetObject("pg.Item2"), PropertyGridEx.CustomProperty))
        Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet"), PropertyGridEx.CustomPropertyCollection))
        Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet1"), PropertyGridEx.CustomPropertyCollection))
        Me.pg.Location = New System.Drawing.Point(0, 23)
        Me.pg.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pg.Name = "pg"
        Me.pg.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.pg.SelectedObject = CType(resources.GetObject("pg.SelectedObject"), Object)
        Me.pg.ShowCustomProperties = True
        Me.pg.Size = New System.Drawing.Size(213, 269)
        Me.pg.TabIndex = 161
        '
        '
        '
        Me.pg.ToolStrip.AccessibleName = "ToolBar"
        Me.pg.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.pg.ToolStrip.BackColor = System.Drawing.Color.CadetBlue
        Me.pg.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pg.ToolStrip.CanOverflow = False
        Me.pg.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.pg.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.pg.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.pg.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.pg.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.strp_Add, Me.strp_Edit, Me.strp_Del, Me.ToolStripSeparator1, Me.strp_Search})
        Me.pg.ToolStrip.Location = New System.Drawing.Point(0, 1)
        Me.pg.ToolStrip.Name = ""
        Me.pg.ToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pg.ToolStrip.Size = New System.Drawing.Size(254, 32)
        Me.pg.ToolStrip.TabIndex = 1
        Me.pg.ToolStrip.TabStop = True
        Me.pg.UseCompatibleTextRendering = True
        Me.pg.ViewForeColor = System.Drawing.Color.Black
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 28)
        Me.ToolStripLabel1.Tag = "proses"
        Me.ToolStripLabel1.Text = "Proses:"
        '
        'strp_Add
        '
        Me.strp_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.strp_Add.Image = CType(resources.GetObject("strp_Add.Image"), System.Drawing.Image)
        Me.strp_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.strp_Add.Name = "strp_Add"
        Me.strp_Add.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.strp_Add.Size = New System.Drawing.Size(28, 28)
        Me.strp_Add.Tag = "proses"
        Me.strp_Add.Text = "Add"
        Me.strp_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strp_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'strp_Edit
        '
        Me.strp_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.strp_Edit.Image = CType(resources.GetObject("strp_Edit.Image"), System.Drawing.Image)
        Me.strp_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.strp_Edit.Name = "strp_Edit"
        Me.strp_Edit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.strp_Edit.Size = New System.Drawing.Size(28, 28)
        Me.strp_Edit.Tag = "proses"
        Me.strp_Edit.Text = "Edit"
        Me.strp_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strp_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'strp_Del
        '
        Me.strp_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.strp_Del.Image = CType(resources.GetObject("strp_Del.Image"), System.Drawing.Image)
        Me.strp_Del.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.strp_Del.Name = "strp_Del"
        Me.strp_Del.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.strp_Del.Size = New System.Drawing.Size(28, 28)
        Me.strp_Del.Tag = "proses"
        Me.strp_Del.Text = "Del"
        Me.strp_Del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strp_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator1.Tag = "proses"
        '
        'strp_Search
        '
        Me.strp_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.strp_Search.Image = CType(resources.GetObject("strp_Search.Image"), System.Drawing.Image)
        Me.strp_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.strp_Search.Name = "strp_Search"
        Me.strp_Search.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.strp_Search.Size = New System.Drawing.Size(28, 28)
        Me.strp_Search.Tag = "proses"
        Me.strp_Search.Text = "Search"
        Me.strp_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strp_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel2.Controls.Add(Me.l_detil)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 23)
        Me.Panel2.TabIndex = 160
        '
        'l_detil
        '
        Me.l_detil.BackColor = System.Drawing.Color.Moccasin
        Me.l_detil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.l_detil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.l_detil.ForeColor = System.Drawing.Color.Red
        Me.l_detil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_detil.Location = New System.Drawing.Point(0, 0)
        Me.l_detil.Name = "l_detil"
        Me.l_detil.Size = New System.Drawing.Size(213, 23)
        Me.l_detil.TabIndex = 0
        Me.l_detil.Text = "Detil"
        Me.l_detil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctExpand
        '
        Me.pctExpand.BackColor = System.Drawing.Color.Black
        Me.pctExpand.BackgroundImage = CType(resources.GetObject("pctExpand.BackgroundImage"), System.Drawing.Image)
        Me.pctExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctExpand.ErrorImage = CType(resources.GetObject("pctExpand.ErrorImage"), System.Drawing.Image)
        Me.pctExpand.InitialImage = CType(resources.GetObject("pctExpand.InitialImage"), System.Drawing.Image)
        Me.pctExpand.Location = New System.Drawing.Point(156, 11)
        Me.pctExpand.Name = "pctExpand"
        Me.pctExpand.Size = New System.Drawing.Size(23, 23)
        Me.pctExpand.TabIndex = 124
        Me.pctExpand.TabStop = False
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
        Me.G.Location = New System.Drawing.Point(0, 37)
        Me.G.Name = "G"
        Me.G.NodeClosedPicture = Nothing
        Me.G.NodeOpenPicture = Nothing
        Me.G.OutlineCol = -1
        Me.G.Rows = 1
        Me.G.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.G.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.G.SheetBorder = System.Drawing.Color.White
        Me.G.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.G.Size = New System.Drawing.Size(825, 182)
        Me.G.StyleInfo = resources.GetString("G.StyleInfo")
        Me.G.TabIndex = 132
        Me.G.TreeColor = System.Drawing.Color.DarkGray
        '
        'lLoading
        '
        Me.lLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lLoading.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lLoading.Location = New System.Drawing.Point(221, 99)
        Me.lLoading.Name = "lLoading"
        Me.lLoading.Size = New System.Drawing.Size(121, 23)
        Me.lLoading.TabIndex = 133
        Me.lLoading.Text = "Loading ..."
        Me.lLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lLoading.Visible = False
        '
        'spl_Utama
        '
        Me.spl_Utama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spl_Utama.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spl_Utama.Location = New System.Drawing.Point(11, 11)
        Me.spl_Utama.Name = "spl_Utama"
        '
        'spl_Utama.Panel1
        '
        Me.spl_Utama.Panel1.Controls.Add(Me.pg)
        Me.spl_Utama.Panel1.Controls.Add(Me.Panel2)
        Me.spl_Utama.Panel1MinSize = 23
        '
        'spl_Utama.Panel2
        '
        Me.spl_Utama.Panel2.Controls.Add(Me.G)
        Me.spl_Utama.Panel2.Controls.Add(Me.gBawah)
        Me.spl_Utama.Panel2.Controls.Add(Me.PnlAtas)
        Me.spl_Utama.Panel2MinSize = 23
        Me.spl_Utama.Size = New System.Drawing.Size(1045, 292)
        Me.spl_Utama.SplitterDistance = 213
        Me.spl_Utama.SplitterWidth = 7
        Me.spl_Utama.TabIndex = 134
        '
        'fHutCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 314)
        Me.Controls.Add(Me.pctExpand)
        Me.Controls.Add(Me.lLoading)
        Me.Controls.Add(Me.spl_Utama)
        Me.Name = "fHutCus"
        Me.Padding = New System.Windows.Forms.Padding(11)
        Me.Text = "Hutang Customer"
        Me.PnlTembel.ResumeLayout(False)
        Me.PnlTembel.PerformLayout()
        Me.PnlTgl.ResumeLayout(False)
        Me.PnlTgl.PerformLayout()
        Me.PnlAtas.ResumeLayout(False)
        Me.PnlAtas.PerformLayout()
        Me.gBawah.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pctExpand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_Utama.Panel1.ResumeLayout(False)
        Me.spl_Utama.Panel2.ResumeLayout(False)
        CType(Me.spl_Utama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_Utama.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlTembel As Panel
    Friend WithEvents Lperiode As Label
    Friend WithEvents CkAll As CheckBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents PnlTgl As Panel
    Friend WithEvents tglA As DateTimePicker
    Friend WithEvents tglB As DateTimePicker
    Friend WithEvents lSearch As LinkLabel
    Friend WithEvents PnlAtas As Panel
    Friend WithEvents Lsaldo As Label
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents gBawah As GroupBox
    Friend WithEvents tSrch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents l_detil As Label
    Friend WithEvents G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents strp_Add As ToolStripButton
    Friend WithEvents strp_Edit As ToolStripButton
    Friend WithEvents strp_Del As ToolStripButton
    Friend WithEvents strp_Search As ToolStripButton
    Friend WithEvents lLoading As Label
    Friend WithEvents pctExpand As PictureBox
    Friend WithEvents spl_Utama As SplitContainer
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents pg As PropertyGridEx.PropertyGridEx
    Friend WithEvents CmdSupCus As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
