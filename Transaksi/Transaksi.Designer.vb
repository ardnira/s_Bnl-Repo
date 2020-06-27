<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.splUtama = New System.Windows.Forms.SplitContainer()
        Me.pctExpand = New System.Windows.Forms.PictureBox()
        Me.G = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pnl_Crud_Master = New System.Windows.Forms.Panel()
        Me.mt_Edit = New System.Windows.Forms.Button()
        Me.mt_Del = New System.Windows.Forms.Button()
        Me.mt_Add = New System.Windows.Forms.Button()
        Me.spl_Detil = New System.Windows.Forms.SplitContainer()
        Me.lHistory = New System.Windows.Forms.Label()
        Me.gTotal = New System.Windows.Forms.SplitContainer()
        Me.tHutPiu = New System.Windows.Forms.TextBox()
        Me.tTunai = New System.Windows.Forms.TextBox()
        Me.lTunai = New System.Windows.Forms.Label()
        Me.LhutPiu = New System.Windows.Forms.Label()
        Me.lTotal_RP = New System.Windows.Forms.Label()
        Me.CmdBayar = New System.Windows.Forms.Button()
        Me.Gd = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.pnl_Crud_detil = New System.Windows.Forms.Panel()
        Me.lrincian = New System.Windows.Forms.Label()
        Me.bt_Edit = New System.Windows.Forms.Button()
        Me.bt_Del = New System.Windows.Forms.Button()
        Me.bt_Add = New System.Windows.Forms.Button()
        Me.spl_Bawah = New System.Windows.Forms.SplitContainer()
        Me.tTangBayar = New System.Windows.Forms.TextBox()
        Me.tTang = New System.Windows.Forms.TextBox()
        Me.GhutPiu = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.lTotalharusBayar = New System.Windows.Forms.Label()
        Me.tTangHarus = New System.Windows.Forms.TextBox()
        Me.gTang = New System.Windows.Forms.Label()
        Me.spl_AtasKnn = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ltransport = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.tRef = New System.Windows.Forms.Label()
        Me.ldate = New System.Windows.Forms.Label()
        Me.lref = New System.Windows.Forms.Label()
        Me.tKodeCS = New System.Windows.Forms.Label()
        Me.tNamaCS = New System.Windows.Forms.Label()
        Me.lNamaCS = New System.Windows.Forms.Label()
        Me.lCodeCS = New System.Windows.Forms.Label()
        Me.lJudul = New System.Windows.Forms.Label()
        Me.pnl_Cap_Data = New System.Windows.Forms.Panel()
        Me.lHeader = New System.Windows.Forms.Label()
        Me.btMax = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        CType(Me.splUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splUtama.Panel1.SuspendLayout()
        Me.splUtama.Panel2.SuspendLayout()
        Me.splUtama.SuspendLayout()
        CType(Me.pctExpand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Crud_Master.SuspendLayout()
        CType(Me.spl_Detil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spl_Detil.Panel1.SuspendLayout()
        Me.spl_Detil.Panel2.SuspendLayout()
        Me.spl_Detil.SuspendLayout()
        CType(Me.gTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gTotal.Panel1.SuspendLayout()
        Me.gTotal.Panel2.SuspendLayout()
        Me.gTotal.SuspendLayout()
        CType(Me.Gd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Crud_detil.SuspendLayout()
        CType(Me.spl_Bawah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spl_Bawah.Panel1.SuspendLayout()
        Me.spl_Bawah.Panel2.SuspendLayout()
        Me.spl_Bawah.SuspendLayout()
        CType(Me.GhutPiu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spl_AtasKnn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spl_AtasKnn.Panel1.SuspendLayout()
        Me.spl_AtasKnn.Panel2.SuspendLayout()
        Me.spl_AtasKnn.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'splUtama
        '
        Me.splUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splUtama.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splUtama.Location = New System.Drawing.Point(0, 33)
        Me.splUtama.Name = "splUtama"
        '
        'splUtama.Panel1
        '
        Me.splUtama.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splUtama.Panel1.Controls.Add(Me.pctExpand)
        Me.splUtama.Panel1.Controls.Add(Me.G)
        Me.splUtama.Panel1.Controls.Add(Me.pnl_Crud_Master)
        Me.splUtama.Panel1.Padding = New System.Windows.Forms.Padding(11, 0, 11, 11)
        '
        'splUtama.Panel2
        '
        Me.splUtama.Panel2.BackColor = System.Drawing.Color.White
        Me.splUtama.Panel2.Controls.Add(Me.spl_Detil)
        Me.splUtama.Panel2.Controls.Add(Me.gTang)
        Me.splUtama.Panel2.Controls.Add(Me.spl_AtasKnn)
        Me.splUtama.Panel2.Controls.Add(Me.lJudul)
        Me.splUtama.Panel2.Padding = New System.Windows.Forms.Padding(11)
        Me.splUtama.Size = New System.Drawing.Size(827, 348)
        Me.splUtama.SplitterDistance = 227
        Me.splUtama.TabIndex = 0
        '
        'pctExpand
        '
        Me.pctExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctExpand.BackColor = System.Drawing.Color.Black
        Me.pctExpand.BackgroundImage = CType(resources.GetObject("pctExpand.BackgroundImage"), System.Drawing.Image)
        Me.pctExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctExpand.ErrorImage = CType(resources.GetObject("pctExpand.ErrorImage"), System.Drawing.Image)
        Me.pctExpand.InitialImage = CType(resources.GetObject("pctExpand.InitialImage"), System.Drawing.Image)
        Me.pctExpand.Location = New System.Drawing.Point(202, 2)
        Me.pctExpand.Name = "pctExpand"
        Me.pctExpand.Size = New System.Drawing.Size(23, 23)
        Me.pctExpand.TabIndex = 147
        Me.pctExpand.TabStop = False
        '
        'G
        '
        Me.G.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.G.AllowEditing = False
        Me.G.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.G.BackColor = System.Drawing.Color.White
        Me.G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.G.ColumnInfo = "3,1,0,0,0,100,Columns:"
        Me.G.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.G.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.G.ForeColor = System.Drawing.Color.Black
        Me.G.Location = New System.Drawing.Point(11, 45)
        Me.G.Name = "G"
        Me.G.Rows.Count = 1
        Me.G.Rows.DefaultSize = 20
        Me.G.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.G.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.G.Size = New System.Drawing.Size(205, 292)
        Me.G.StyleInfo = resources.GetString("G.StyleInfo")
        Me.G.TabIndex = 11
        Me.G.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        '
        'pnl_Crud_Master
        '
        Me.pnl_Crud_Master.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_Crud_Master.Controls.Add(Me.mt_Edit)
        Me.pnl_Crud_Master.Controls.Add(Me.mt_Del)
        Me.pnl_Crud_Master.Controls.Add(Me.mt_Add)
        Me.pnl_Crud_Master.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Crud_Master.Location = New System.Drawing.Point(11, 0)
        Me.pnl_Crud_Master.Name = "pnl_Crud_Master"
        Me.pnl_Crud_Master.Size = New System.Drawing.Size(205, 45)
        Me.pnl_Crud_Master.TabIndex = 0
        '
        'mt_Edit
        '
        Me.mt_Edit.BackColor = System.Drawing.Color.Transparent
        Me.mt_Edit.FlatAppearance.BorderSize = 0
        Me.mt_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.mt_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mt_Edit.Font = New System.Drawing.Font("Arial Narrow", 7.0!)
        Me.mt_Edit.ForeColor = System.Drawing.Color.Black
        Me.mt_Edit.Image = CType(resources.GetObject("mt_Edit.Image"), System.Drawing.Image)
        Me.mt_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Edit.Location = New System.Drawing.Point(35, -3)
        Me.mt_Edit.Name = "mt_Edit"
        Me.mt_Edit.Size = New System.Drawing.Size(34, 49)
        Me.mt_Edit.TabIndex = 143
        Me.mt_Edit.Text = "Edit"
        Me.mt_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mt_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mt_Edit.UseVisualStyleBackColor = False
        '
        'mt_Del
        '
        Me.mt_Del.BackColor = System.Drawing.Color.Transparent
        Me.mt_Del.FlatAppearance.BorderSize = 0
        Me.mt_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.mt_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mt_Del.Font = New System.Drawing.Font("Arial Narrow", 7.0!)
        Me.mt_Del.ForeColor = System.Drawing.Color.Black
        Me.mt_Del.Image = CType(resources.GetObject("mt_Del.Image"), System.Drawing.Image)
        Me.mt_Del.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Del.Location = New System.Drawing.Point(69, -3)
        Me.mt_Del.Name = "mt_Del"
        Me.mt_Del.Size = New System.Drawing.Size(34, 49)
        Me.mt_Del.TabIndex = 144
        Me.mt_Del.Text = "Del"
        Me.mt_Del.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mt_Del.UseVisualStyleBackColor = False
        '
        'mt_Add
        '
        Me.mt_Add.BackColor = System.Drawing.Color.Transparent
        Me.mt_Add.FlatAppearance.BorderSize = 0
        Me.mt_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.mt_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mt_Add.Font = New System.Drawing.Font("Arial Narrow", 7.0!)
        Me.mt_Add.ForeColor = System.Drawing.Color.Black
        Me.mt_Add.Image = CType(resources.GetObject("mt_Add.Image"), System.Drawing.Image)
        Me.mt_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Add.Location = New System.Drawing.Point(1, -3)
        Me.mt_Add.Name = "mt_Add"
        Me.mt_Add.Size = New System.Drawing.Size(34, 49)
        Me.mt_Add.TabIndex = 142
        Me.mt_Add.Text = "New"
        Me.mt_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mt_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mt_Add.UseVisualStyleBackColor = False
        '
        'spl_Detil
        '
        Me.spl_Detil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spl_Detil.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spl_Detil.Location = New System.Drawing.Point(11, 100)
        Me.spl_Detil.Name = "spl_Detil"
        Me.spl_Detil.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spl_Detil.Panel1
        '
        Me.spl_Detil.Panel1.Controls.Add(Me.lHistory)
        Me.spl_Detil.Panel1.Controls.Add(Me.gTotal)
        Me.spl_Detil.Panel1.Controls.Add(Me.Gd)
        Me.spl_Detil.Panel1.Controls.Add(Me.pnl_Crud_detil)
        '
        'spl_Detil.Panel2
        '
        Me.spl_Detil.Panel2.Controls.Add(Me.spl_Bawah)
        Me.spl_Detil.Size = New System.Drawing.Size(574, 219)
        Me.spl_Detil.SplitterDistance = 117
        Me.spl_Detil.TabIndex = 1
        '
        'lHistory
        '
        Me.lHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lHistory.Location = New System.Drawing.Point(0, 98)
        Me.lHistory.Name = "lHistory"
        Me.lHistory.Size = New System.Drawing.Size(574, 19)
        Me.lHistory.TabIndex = 7
        Me.lHistory.Text = "Histori: "
        Me.lHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gTotal
        '
        Me.gTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gTotal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.gTotal.Location = New System.Drawing.Point(255, 30)
        Me.gTotal.Name = "gTotal"
        '
        'gTotal.Panel1
        '
        Me.gTotal.Panel1.Controls.Add(Me.tHutPiu)
        Me.gTotal.Panel1.Controls.Add(Me.tTunai)
        Me.gTotal.Panel1.Controls.Add(Me.lTunai)
        Me.gTotal.Panel1.Controls.Add(Me.LhutPiu)
        Me.gTotal.Panel1.Controls.Add(Me.lTotal_RP)
        '
        'gTotal.Panel2
        '
        Me.gTotal.Panel2.Controls.Add(Me.CmdBayar)
        Me.gTotal.Size = New System.Drawing.Size(310, 59)
        Me.gTotal.SplitterDistance = 237
        Me.gTotal.TabIndex = 0
        '
        'tHutPiu
        '
        Me.tHutPiu.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.tHutPiu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tHutPiu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tHutPiu.ForeColor = System.Drawing.Color.Black
        Me.tHutPiu.Location = New System.Drawing.Point(158, 37)
        Me.tHutPiu.Name = "tHutPiu"
        Me.tHutPiu.ReadOnly = True
        Me.tHutPiu.Size = New System.Drawing.Size(69, 15)
        Me.tHutPiu.TabIndex = 20
        Me.tHutPiu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tHutPiu.WordWrap = False
        '
        'tTunai
        '
        Me.tTunai.BackColor = System.Drawing.Color.White
        Me.tTunai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTunai.Enabled = False
        Me.tTunai.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.tTunai.Location = New System.Drawing.Point(43, 25)
        Me.tTunai.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.tTunai.Name = "tTunai"
        Me.tTunai.Size = New System.Drawing.Size(110, 25)
        Me.tTunai.TabIndex = 19
        Me.tTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lTunai
        '
        Me.lTunai.AutoSize = True
        Me.lTunai.Location = New System.Drawing.Point(5, 25)
        Me.lTunai.Name = "lTunai"
        Me.lTunai.Size = New System.Drawing.Size(34, 13)
        Me.lTunai.TabIndex = 17
        Me.lTunai.Text = "Tunai"
        '
        'LhutPiu
        '
        Me.LhutPiu.AutoSize = True
        Me.LhutPiu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LhutPiu.ForeColor = System.Drawing.Color.Red
        Me.LhutPiu.Location = New System.Drawing.Point(186, 20)
        Me.LhutPiu.Name = "LhutPiu"
        Me.LhutPiu.Size = New System.Drawing.Size(45, 14)
        Me.LhutPiu.TabIndex = 18
        Me.LhutPiu.Text = "Kurang"
        '
        'lTotal_RP
        '
        Me.lTotal_RP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lTotal_RP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lTotal_RP.Location = New System.Drawing.Point(0, 0)
        Me.lTotal_RP.Name = "lTotal_RP"
        Me.lTotal_RP.Size = New System.Drawing.Size(235, 19)
        Me.lTotal_RP.TabIndex = 0
        Me.lTotal_RP.Text = "Label1"
        Me.lTotal_RP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdBayar
        '
        Me.CmdBayar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdBayar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmdBayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdBayar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdBayar.ForeColor = System.Drawing.Color.LightGray
        Me.CmdBayar.Location = New System.Drawing.Point(0, 0)
        Me.CmdBayar.Name = "CmdBayar"
        Me.CmdBayar.Size = New System.Drawing.Size(67, 57)
        Me.CmdBayar.TabIndex = 7
        Me.CmdBayar.Text = "Bayar"
        Me.CmdBayar.UseVisualStyleBackColor = False
        '
        'Gd
        '
        Me.Gd.BackColor = System.Drawing.Color.White
        Me.Gd.BackColorAlternate = System.Drawing.Color.White
        Me.Gd.BackColorBkg = System.Drawing.Color.White
        Me.Gd.BackColorFixed = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.Gd.Cols = 4
        Me.Gd.ColumnInfo = "4,0,0,0,0,100,Columns:"
        Me.Gd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gd.FixedCols = 0
        Me.Gd.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy
        Me.Gd.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gd.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Gd.GridColorFixed = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gd.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlatHorz
        Me.Gd.GridLineWidth = 0
        Me.Gd.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Gd.Location = New System.Drawing.Point(0, 26)
        Me.Gd.Name = "Gd"
        Me.Gd.NodeClosedPicture = Nothing
        Me.Gd.NodeOpenPicture = Nothing
        Me.Gd.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarNone
        Me.Gd.OutlineCol = -1
        Me.Gd.Rows = 4
        Me.Gd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Gd.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.Gd.SheetBorder = System.Drawing.Color.White
        Me.Gd.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.Gd.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.Gd.Size = New System.Drawing.Size(574, 91)
        Me.Gd.StyleInfo = resources.GetString("Gd.StyleInfo")
        Me.Gd.TabIndex = 6
        Me.Gd.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        Me.Gd.TreeColor = System.Drawing.Color.DarkGray
        '
        'pnl_Crud_detil
        '
        Me.pnl_Crud_detil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_Crud_detil.Controls.Add(Me.lrincian)
        Me.pnl_Crud_detil.Controls.Add(Me.bt_Edit)
        Me.pnl_Crud_detil.Controls.Add(Me.bt_Del)
        Me.pnl_Crud_detil.Controls.Add(Me.bt_Add)
        Me.pnl_Crud_detil.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Crud_detil.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Crud_detil.Name = "pnl_Crud_detil"
        Me.pnl_Crud_detil.Size = New System.Drawing.Size(574, 26)
        Me.pnl_Crud_detil.TabIndex = 1
        '
        'lrincian
        '
        Me.lrincian.AutoSize = True
        Me.lrincian.Location = New System.Drawing.Point(3, 6)
        Me.lrincian.Name = "lrincian"
        Me.lrincian.Size = New System.Drawing.Size(49, 13)
        Me.lrincian.TabIndex = 139
        Me.lrincian.Text = "Rincian: "
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
        Me.bt_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_Edit.Location = New System.Drawing.Point(148, 0)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(53, 24)
        Me.bt_Edit.TabIndex = 137
        Me.bt_Edit.Text = "Edit"
        Me.bt_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Edit.UseVisualStyleBackColor = False
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
        Me.bt_Del.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_Del.Location = New System.Drawing.Point(201, 0)
        Me.bt_Del.Name = "bt_Del"
        Me.bt_Del.Size = New System.Drawing.Size(53, 24)
        Me.bt_Del.TabIndex = 138
        Me.bt_Del.Text = "Del"
        Me.bt_Del.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Del.UseVisualStyleBackColor = False
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
        Me.bt_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_Add.Location = New System.Drawing.Point(95, 0)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.Size = New System.Drawing.Size(53, 24)
        Me.bt_Add.TabIndex = 136
        Me.bt_Add.Text = "Add"
        Me.bt_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'spl_Bawah
        '
        Me.spl_Bawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spl_Bawah.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spl_Bawah.Location = New System.Drawing.Point(0, 0)
        Me.spl_Bawah.Name = "spl_Bawah"
        '
        'spl_Bawah.Panel1
        '
        Me.spl_Bawah.Panel1.Controls.Add(Me.tTangBayar)
        Me.spl_Bawah.Panel1.Controls.Add(Me.tTang)
        Me.spl_Bawah.Panel1.Controls.Add(Me.GhutPiu)
        '
        'spl_Bawah.Panel2
        '
        Me.spl_Bawah.Panel2.Controls.Add(Me.lTotalharusBayar)
        Me.spl_Bawah.Panel2.Controls.Add(Me.tTangHarus)
        Me.spl_Bawah.Size = New System.Drawing.Size(574, 98)
        Me.spl_Bawah.SplitterDistance = 396
        Me.spl_Bawah.TabIndex = 0
        '
        'tTangBayar
        '
        Me.tTangBayar.BackColor = System.Drawing.SystemColors.Control
        Me.tTangBayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTangBayar.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.tTangBayar.Location = New System.Drawing.Point(133, 52)
        Me.tTangBayar.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.tTangBayar.Name = "tTangBayar"
        Me.tTangBayar.Size = New System.Drawing.Size(106, 23)
        Me.tTangBayar.TabIndex = 27
        Me.tTangBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tTangBayar.Visible = False
        '
        'tTang
        '
        Me.tTang.BackColor = System.Drawing.SystemColors.Control
        Me.tTang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTang.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.tTang.Location = New System.Drawing.Point(30, 28)
        Me.tTang.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.tTang.Name = "tTang"
        Me.tTang.Size = New System.Drawing.Size(106, 23)
        Me.tTang.TabIndex = 26
        Me.tTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tTang.Visible = False
        '
        'GhutPiu
        '
        Me.GhutPiu.BackColor = System.Drawing.Color.White
        Me.GhutPiu.BackColorAlternate = System.Drawing.Color.White
        Me.GhutPiu.BackColorBkg = System.Drawing.Color.White
        Me.GhutPiu.BackColorFixed = System.Drawing.Color.White
        Me.GhutPiu.BackColorSel = System.Drawing.Color.White
        Me.GhutPiu.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.GhutPiu.Cols = 4
        Me.GhutPiu.ColumnInfo = "4,0,0,0,0,100,Columns:"
        Me.GhutPiu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhutPiu.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.GhutPiu.FixedCols = 0
        Me.GhutPiu.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.GhutPiu.GridColor = System.Drawing.Color.White
        Me.GhutPiu.GridColorFixed = System.Drawing.Color.Black
        Me.GhutPiu.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlatHorz
        Me.GhutPiu.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.GhutPiu.Location = New System.Drawing.Point(0, 0)
        Me.GhutPiu.Name = "GhutPiu"
        Me.GhutPiu.NodeClosedPicture = Nothing
        Me.GhutPiu.NodeOpenPicture = Nothing
        Me.GhutPiu.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarNone
        Me.GhutPiu.OutlineCol = -1
        Me.GhutPiu.Rows = 4
        Me.GhutPiu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GhutPiu.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.GhutPiu.SheetBorder = System.Drawing.Color.White
        Me.GhutPiu.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.GhutPiu.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.GhutPiu.Size = New System.Drawing.Size(396, 98)
        Me.GhutPiu.StyleInfo = resources.GetString("GhutPiu.StyleInfo")
        Me.GhutPiu.TabIndex = 25
        Me.GhutPiu.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        Me.GhutPiu.TreeColor = System.Drawing.Color.DarkGray
        '
        'lTotalharusBayar
        '
        Me.lTotalharusBayar.AutoSize = True
        Me.lTotalharusBayar.Location = New System.Drawing.Point(10, 22)
        Me.lTotalharusBayar.Name = "lTotalharusBayar"
        Me.lTotalharusBayar.Size = New System.Drawing.Size(92, 13)
        Me.lTotalharusBayar.TabIndex = 25
        Me.lTotalharusBayar.Text = "Total Harus Bayar"
        Me.lTotalharusBayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tTangHarus
        '
        Me.tTangHarus.BackColor = System.Drawing.Color.White
        Me.tTangHarus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTangHarus.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.tTangHarus.ForeColor = System.Drawing.Color.Red
        Me.tTangHarus.Location = New System.Drawing.Point(9, 40)
        Me.tTangHarus.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.tTangHarus.Name = "tTangHarus"
        Me.tTangHarus.ReadOnly = True
        Me.tTangHarus.Size = New System.Drawing.Size(156, 38)
        Me.tTangHarus.TabIndex = 26
        Me.tTangHarus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gTang
        '
        Me.gTang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gTang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gTang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gTang.Location = New System.Drawing.Point(11, 319)
        Me.gTang.Name = "gTang"
        Me.gTang.Size = New System.Drawing.Size(574, 18)
        Me.gTang.TabIndex = 24
        Me.gTang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spl_AtasKnn
        '
        Me.spl_AtasKnn.Dock = System.Windows.Forms.DockStyle.Top
        Me.spl_AtasKnn.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spl_AtasKnn.Location = New System.Drawing.Point(11, 36)
        Me.spl_AtasKnn.Name = "spl_AtasKnn"
        '
        'spl_AtasKnn.Panel1
        '
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.Label4)
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.Ltransport)
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.Panel2)
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.tRef)
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.ldate)
        Me.spl_AtasKnn.Panel1.Controls.Add(Me.lref)
        '
        'spl_AtasKnn.Panel2
        '
        Me.spl_AtasKnn.Panel2.Controls.Add(Me.tKodeCS)
        Me.spl_AtasKnn.Panel2.Controls.Add(Me.tNamaCS)
        Me.spl_AtasKnn.Panel2.Controls.Add(Me.lNamaCS)
        Me.spl_AtasKnn.Panel2.Controls.Add(Me.lCodeCS)
        Me.spl_AtasKnn.Size = New System.Drawing.Size(574, 64)
        Me.spl_AtasKnn.SplitterDistance = 333
        Me.spl_AtasKnn.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(332, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 64)
        Me.Label4.TabIndex = 17
        '
        'Ltransport
        '
        Me.Ltransport.AutoSize = True
        Me.Ltransport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Ltransport.LinkColor = System.Drawing.Color.Blue
        Me.Ltransport.Location = New System.Drawing.Point(177, 37)
        Me.Ltransport.Name = "Ltransport"
        Me.Ltransport.Size = New System.Drawing.Size(52, 13)
        Me.Ltransport.TabIndex = 16
        Me.Ltransport.TabStop = True
        Me.Ltransport.Text = "Trnsprt: 0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtTanggal)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(34, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(79, 18)
        Me.Panel2.TabIndex = 15
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "  dd MMM yyyy"
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(-1, -2)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(120, 20)
        Me.dtTanggal.TabIndex = 0
        '
        'tRef
        '
        Me.tRef.BackColor = System.Drawing.Color.Transparent
        Me.tRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tRef.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRef.Location = New System.Drawing.Point(34, 7)
        Me.tRef.Name = "tRef"
        Me.tRef.Size = New System.Drawing.Size(144, 16)
        Me.tRef.TabIndex = 14
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Location = New System.Drawing.Point(0, 38)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(36, 13)
        Me.ldate.TabIndex = 13
        Me.ldate.Text = "Date :"
        Me.ldate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lref
        '
        Me.lref.AutoSize = True
        Me.lref.Location = New System.Drawing.Point(0, 7)
        Me.lref.Name = "lref"
        Me.lref.Size = New System.Drawing.Size(30, 13)
        Me.lref.TabIndex = 12
        Me.lref.Text = "Ref :"
        Me.lref.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tKodeCS
        '
        Me.tKodeCS.BackColor = System.Drawing.Color.Transparent
        Me.tKodeCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tKodeCS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeCS.Location = New System.Drawing.Point(86, 8)
        Me.tKodeCS.Name = "tKodeCS"
        Me.tKodeCS.Size = New System.Drawing.Size(142, 16)
        Me.tKodeCS.TabIndex = 12
        '
        'tNamaCS
        '
        Me.tNamaCS.BackColor = System.Drawing.Color.Transparent
        Me.tNamaCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tNamaCS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaCS.Location = New System.Drawing.Point(86, 38)
        Me.tNamaCS.Name = "tNamaCS"
        Me.tNamaCS.Size = New System.Drawing.Size(143, 16)
        Me.tNamaCS.TabIndex = 13
        '
        'lNamaCS
        '
        Me.lNamaCS.Location = New System.Drawing.Point(7, 38)
        Me.lNamaCS.Name = "lNamaCS"
        Me.lNamaCS.Size = New System.Drawing.Size(77, 13)
        Me.lNamaCS.TabIndex = 11
        Me.lNamaCS.Text = "Suplier Name :"
        Me.lNamaCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lCodeCS
        '
        Me.lCodeCS.Location = New System.Drawing.Point(7, 8)
        Me.lCodeCS.Name = "lCodeCS"
        Me.lCodeCS.Size = New System.Drawing.Size(77, 13)
        Me.lCodeCS.TabIndex = 10
        Me.lCodeCS.Text = "Suplier Code :"
        Me.lCodeCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lJudul
        '
        Me.lJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.lJudul.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJudul.Location = New System.Drawing.Point(11, 11)
        Me.lJudul.Name = "lJudul"
        Me.lJudul.Size = New System.Drawing.Size(574, 25)
        Me.lJudul.TabIndex = 2
        Me.lJudul.Text = "Detil"
        Me.lJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Cap_Data
        '
        Me.pnl_Cap_Data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_Cap_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_Cap_Data.Location = New System.Drawing.Point(231, 5)
        Me.pnl_Cap_Data.Name = "pnl_Cap_Data"
        Me.pnl_Cap_Data.Size = New System.Drawing.Size(54, 53)
        Me.pnl_Cap_Data.TabIndex = 142
        '
        'lHeader
        '
        Me.lHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHeader.ForeColor = System.Drawing.Color.White
        Me.lHeader.Location = New System.Drawing.Point(285, 5)
        Me.lHeader.Name = "lHeader"
        Me.lHeader.Size = New System.Drawing.Size(222, 23)
        Me.lHeader.TabIndex = 143
        Me.lHeader.Text = "Label3"
        Me.lHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btMax.Location = New System.Drawing.Point(770, 5)
        Me.btMax.Margin = New System.Windows.Forms.Padding(0)
        Me.btMax.Name = "btMax"
        Me.btMax.Size = New System.Drawing.Size(23, 20)
        Me.btMax.TabIndex = 144
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
        Me.btClose.Location = New System.Drawing.Point(797, 5)
        Me.btClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(23, 20)
        Me.btClose.TabIndex = 145
        Me.btClose.Tag = " (Ctrl+W)"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btClose.UseVisualStyleBackColor = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.btMax)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.lHeader)
        Me.Controls.Add(Me.pnl_Cap_Data)
        Me.Controls.Add(Me.splUtama)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transaksi"
        Me.Padding = New System.Windows.Forms.Padding(0, 33, 0, 0)
        Me.ShowIcon = False
        Me.splUtama.Panel1.ResumeLayout(False)
        Me.splUtama.Panel2.ResumeLayout(False)
        CType(Me.splUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splUtama.ResumeLayout(False)
        CType(Me.pctExpand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Crud_Master.ResumeLayout(False)
        Me.spl_Detil.Panel1.ResumeLayout(False)
        Me.spl_Detil.Panel2.ResumeLayout(False)
        CType(Me.spl_Detil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_Detil.ResumeLayout(False)
        Me.gTotal.Panel1.ResumeLayout(False)
        Me.gTotal.Panel1.PerformLayout()
        Me.gTotal.Panel2.ResumeLayout(False)
        CType(Me.gTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gTotal.ResumeLayout(False)
        CType(Me.Gd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Crud_detil.ResumeLayout(False)
        Me.pnl_Crud_detil.PerformLayout()
        Me.spl_Bawah.Panel1.ResumeLayout(False)
        Me.spl_Bawah.Panel1.PerformLayout()
        Me.spl_Bawah.Panel2.ResumeLayout(False)
        Me.spl_Bawah.Panel2.PerformLayout()
        CType(Me.spl_Bawah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_Bawah.ResumeLayout(False)
        CType(Me.GhutPiu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_AtasKnn.Panel1.ResumeLayout(False)
        Me.spl_AtasKnn.Panel1.PerformLayout()
        Me.spl_AtasKnn.Panel2.ResumeLayout(False)
        CType(Me.spl_AtasKnn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_AtasKnn.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splUtama As SplitContainer
    Friend WithEvents G As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents spl_AtasKnn As SplitContainer
    Friend WithEvents spl_Detil As SplitContainer
    Friend WithEvents spl_Bawah As SplitContainer
    Friend WithEvents gTotal As SplitContainer
    Friend WithEvents lTotal_RP As Label
    Friend WithEvents tTunai As TextBox
    Friend WithEvents lTunai As Label
    Friend WithEvents LhutPiu As Label
    Friend WithEvents pnl_Crud_detil As Panel
    Friend WithEvents Gd As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents CmdBayar As Button
    Friend WithEvents bt_Edit As Button
    Friend WithEvents bt_Add As Button
    Friend WithEvents bt_Del As Button
    Friend WithEvents lJudul As Label
    Friend WithEvents mt_Edit As Button
    Friend WithEvents mt_Add As Button
    Friend WithEvents mt_Del As Button
    Friend WithEvents pnl_Crud_Master As Panel
    Friend WithEvents pctExpand As PictureBox
    Friend WithEvents tTangBayar As TextBox
    Friend WithEvents tTang As TextBox
    Friend WithEvents GhutPiu As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents gTang As Label
    Friend WithEvents lTotalharusBayar As Label
    Friend WithEvents tTangHarus As TextBox
    Friend WithEvents tKodeCS As Label
    Friend WithEvents tNamaCS As Label
    Friend WithEvents lNamaCS As Label
    Friend WithEvents lCodeCS As Label
    Friend WithEvents Ltransport As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents tRef As Label
    Friend WithEvents ldate As Label
    Friend WithEvents lref As Label
    Friend WithEvents tHutPiu As TextBox
    Friend WithEvents lHistory As Label
    Friend WithEvents pnl_Cap_Data As Panel
    Friend WithEvents lHeader As Label
    Friend WithEvents btMax As Button
    Friend WithEvents btClose As Button
    Friend WithEvents lrincian As Label
    Friend WithEvents Label4 As Label
End Class
