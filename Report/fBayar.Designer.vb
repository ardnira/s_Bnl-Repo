<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBayar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBayar))
        Me.pLogo = New System.Windows.Forms.PictureBox()
        Me.Gd = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.tTunai = New System.Windows.Forms.TextBox()
        Me.CmdBayar = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.PnlBawah = New System.Windows.Forms.Panel()
        Me.gProses = New DevExpress.XtraEditors.GroupControl()
        Me.BtnSuratJalan = New System.Windows.Forms.Button()
        Me.ckPreview = New System.Windows.Forms.CheckBox()
        Me.pnlBayar = New DevExpress.XtraEditors.PanelControl()
        Me.lTangBaru = New System.Windows.Forms.TextBox()
        Me.TngNext = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TtlBiaya = New System.Windows.Forms.TextBox()
        Me.TngLama = New System.Windows.Forms.TextBox()
        Me.lTotalBiaya = New System.Windows.Forms.Label()
        Me.lTanggunganLama = New System.Windows.Forms.Label()
        Me.ThrsByr = New System.Windows.Forms.TextBox()
        Me.LgarisTotal = New System.Windows.Forms.Label()
        Me.lGaris = New System.Windows.Forms.Label()
        Me.PrintStruk = New System.Drawing.Printing.PrintDocument()
        Me.lAlamat = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.lKontak = New System.Windows.Forms.Label()
        Me.lNamaUsaha = New System.Windows.Forms.Label()
        Me.LkasirDate = New System.Windows.Forms.Label()
        Me.lCust = New System.Windows.Forms.Label()
        Me.lll = New System.Windows.Forms.Label()
        Me.Lref = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.srtNama = New System.Windows.Forms.TextBox()
        Me.gSuratJalan = New DevExpress.XtraEditors.GroupControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.BtnSrtJ = New System.Windows.Forms.Button()
        Me.BtnCancelSrtJ = New System.Windows.Forms.Button()
        Me.srtKet = New System.Windows.Forms.TextBox()
        Me.srtAlamat = New System.Windows.Forms.TextBox()
        Me.srtTelp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintSrtJ = New System.Drawing.Printing.PrintDocument()
        Me.lLoading = New System.Windows.Forms.Label()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBawah.SuspendLayout()
        CType(Me.gProses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gProses.SuspendLayout()
        CType(Me.pnlBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBayar.SuspendLayout()
        CType(Me.gSuratJalan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gSuratJalan.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pLogo
        '
        Me.pLogo.Location = New System.Drawing.Point(2, 7)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(75, 70)
        Me.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogo.TabIndex = 0
        Me.pLogo.TabStop = False
        '
        'Gd
        '
        Me.Gd.BackColorBkg = System.Drawing.Color.White
        Me.Gd.BackColorFixed = System.Drawing.Color.WhiteSmoke
        Me.Gd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.Gd.Cols = 5
        Me.Gd.ColumnInfo = resources.GetString("Gd.ColumnInfo")
        Me.Gd.ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExNone
        Me.Gd.FixedCols = 0
        Me.Gd.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Gd.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gd.GridColor = System.Drawing.Color.DarkGray
        Me.Gd.GridColorFixed = System.Drawing.Color.DarkGray
        Me.Gd.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlat
        Me.Gd.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Gd.Location = New System.Drawing.Point(9, 108)
        Me.Gd.Name = "Gd"
        Me.Gd.NodeClosedPicture = Nothing
        Me.Gd.NodeOpenPicture = Nothing
        Me.Gd.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarNone
        Me.Gd.OutlineCol = -1
        Me.Gd.RowHeightMax = 17
        Me.Gd.Rows = 13
        Me.Gd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Gd.SheetBorder = System.Drawing.Color.White
        Me.Gd.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.Gd.Size = New System.Drawing.Size(374, 223)
        Me.Gd.StyleInfo = resources.GetString("Gd.StyleInfo")
        Me.Gd.TabIndex = 6
        Me.Gd.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        Me.Gd.TreeColor = System.Drawing.Color.DarkGray
        '
        'tTunai
        '
        Me.tTunai.BackColor = System.Drawing.Color.White
        Me.tTunai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tTunai.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.tTunai.Location = New System.Drawing.Point(76, 2)
        Me.tTunai.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.tTunai.Name = "tTunai"
        Me.tTunai.Size = New System.Drawing.Size(121, 21)
        Me.tTunai.TabIndex = 0
        Me.tTunai.Text = "23,000,000"
        Me.tTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmdBayar
        '
        Me.CmdBayar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdBayar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmdBayar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdBayar.ForeColor = System.Drawing.Color.LightGray
        Me.CmdBayar.Location = New System.Drawing.Point(11, 40)
        Me.CmdBayar.Name = "CmdBayar"
        Me.CmdBayar.Size = New System.Drawing.Size(78, 27)
        Me.CmdBayar.TabIndex = 1
        Me.CmdBayar.Text = "Bayar"
        Me.CmdBayar.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdCancel.ForeColor = System.Drawing.Color.LightGray
        Me.CmdCancel.Location = New System.Drawing.Point(95, 40)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(78, 27)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'PnlBawah
        '
        Me.PnlBawah.Controls.Add(Me.gProses)
        Me.PnlBawah.Controls.Add(Me.pnlBayar)
        Me.PnlBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBawah.Location = New System.Drawing.Point(0, 411)
        Me.PnlBawah.Name = "PnlBawah"
        Me.PnlBawah.Size = New System.Drawing.Size(721, 78)
        Me.PnlBawah.TabIndex = 23
        '
        'gProses
        '
        Me.gProses.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gProses.Controls.Add(Me.BtnSuratJalan)
        Me.gProses.Controls.Add(Me.ckPreview)
        Me.gProses.Controls.Add(Me.CmdBayar)
        Me.gProses.Controls.Add(Me.CmdCancel)
        Me.gProses.Dock = System.Windows.Forms.DockStyle.Right
        Me.gProses.Location = New System.Drawing.Point(536, 0)
        Me.gProses.Name = "gProses"
        Me.gProses.ShowCaption = False
        Me.gProses.Size = New System.Drawing.Size(185, 78)
        Me.gProses.TabIndex = 23
        '
        'BtnSuratJalan
        '
        Me.BtnSuratJalan.Location = New System.Drawing.Point(95, 7)
        Me.BtnSuratJalan.Name = "BtnSuratJalan"
        Me.BtnSuratJalan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSuratJalan.TabIndex = 53
        Me.BtnSuratJalan.Text = "Srt Jalan >"
        Me.BtnSuratJalan.UseVisualStyleBackColor = True
        '
        'ckPreview
        '
        Me.ckPreview.AutoSize = True
        Me.ckPreview.Checked = True
        Me.ckPreview.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPreview.Location = New System.Drawing.Point(13, 22)
        Me.ckPreview.Name = "ckPreview"
        Me.ckPreview.Size = New System.Drawing.Size(64, 17)
        Me.ckPreview.TabIndex = 3
        Me.ckPreview.Text = "Preview"
        Me.ckPreview.UseVisualStyleBackColor = True
        '
        'pnlBayar
        '
        Me.pnlBayar.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlBayar.Appearance.Options.UseBackColor = True
        Me.pnlBayar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlBayar.Controls.Add(Me.lTangBaru)
        Me.pnlBayar.Controls.Add(Me.tTunai)
        Me.pnlBayar.Controls.Add(Me.TngNext)
        Me.pnlBayar.Controls.Add(Me.Label4)
        Me.pnlBayar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBayar.Location = New System.Drawing.Point(0, 0)
        Me.pnlBayar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnlBayar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlBayar.Name = "pnlBayar"
        Me.pnlBayar.Size = New System.Drawing.Size(202, 78)
        Me.pnlBayar.TabIndex = 33
        '
        'lTangBaru
        '
        Me.lTangBaru.BackColor = System.Drawing.Color.White
        Me.lTangBaru.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lTangBaru.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.lTangBaru.Location = New System.Drawing.Point(-26, 34)
        Me.lTangBaru.Name = "lTangBaru"
        Me.lTangBaru.ReadOnly = True
        Me.lTangBaru.Size = New System.Drawing.Size(101, 14)
        Me.lTangBaru.TabIndex = 43
        Me.lTangBaru.Text = "Tangg. baru"
        Me.lTangBaru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lTangBaru.WordWrap = False
        '
        'TngNext
        '
        Me.TngNext.BackColor = System.Drawing.Color.White
        Me.TngNext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TngNext.Enabled = False
        Me.TngNext.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.TngNext.ForeColor = System.Drawing.Color.DarkRed
        Me.TngNext.Location = New System.Drawing.Point(75, 36)
        Me.TngNext.Margin = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.TngNext.Name = "TngNext"
        Me.TngNext.ReadOnly = True
        Me.TngNext.Size = New System.Drawing.Size(121, 14)
        Me.TngNext.TabIndex = 32
        Me.TngNext.Text = "23,000,000"
        Me.TngNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(9, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Jml Bayar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TtlBiaya
        '
        Me.TtlBiaya.BackColor = System.Drawing.Color.White
        Me.TtlBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TtlBiaya.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.TtlBiaya.Location = New System.Drawing.Point(218, 338)
        Me.TtlBiaya.Name = "TtlBiaya"
        Me.TtlBiaya.ReadOnly = True
        Me.TtlBiaya.Size = New System.Drawing.Size(146, 14)
        Me.TtlBiaya.TabIndex = 24
        Me.TtlBiaya.Text = "13.750.000"
        Me.TtlBiaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TngLama
        '
        Me.TngLama.BackColor = System.Drawing.Color.White
        Me.TngLama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TngLama.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.TngLama.Location = New System.Drawing.Point(220, 360)
        Me.TngLama.Name = "TngLama"
        Me.TngLama.ReadOnly = True
        Me.TngLama.Size = New System.Drawing.Size(145, 14)
        Me.TngLama.TabIndex = 25
        Me.TngLama.Text = "13.750.000"
        Me.TngLama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lTotalBiaya
        '
        Me.lTotalBiaya.AutoSize = True
        Me.lTotalBiaya.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.lTotalBiaya.Location = New System.Drawing.Point(250, 339)
        Me.lTotalBiaya.Name = "lTotalBiaya"
        Me.lTotalBiaya.Size = New System.Drawing.Size(61, 13)
        Me.lTotalBiaya.TabIndex = 26
        Me.lTotalBiaya.Text = "Total Biaya:"
        '
        'lTanggunganLama
        '
        Me.lTanggunganLama.AutoSize = True
        Me.lTanggunganLama.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.lTanggunganLama.Location = New System.Drawing.Point(218, 360)
        Me.lTanggunganLama.Name = "lTanggunganLama"
        Me.lTanggunganLama.Size = New System.Drawing.Size(93, 13)
        Me.lTanggunganLama.TabIndex = 27
        Me.lTanggunganLama.Text = "Tanggungan Lama:"
        '
        'ThrsByr
        '
        Me.ThrsByr.BackColor = System.Drawing.Color.White
        Me.ThrsByr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ThrsByr.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.ThrsByr.Location = New System.Drawing.Point(220, 387)
        Me.ThrsByr.Name = "ThrsByr"
        Me.ThrsByr.ReadOnly = True
        Me.ThrsByr.Size = New System.Drawing.Size(145, 14)
        Me.ThrsByr.TabIndex = 28
        Me.ThrsByr.Text = "13.750.000"
        Me.ThrsByr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LgarisTotal
        '
        Me.LgarisTotal.BackColor = System.Drawing.Color.Black
        Me.LgarisTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LgarisTotal.Location = New System.Drawing.Point(234, 383)
        Me.LgarisTotal.Name = "LgarisTotal"
        Me.LgarisTotal.Size = New System.Drawing.Size(131, 1)
        Me.LgarisTotal.TabIndex = 29
        Me.LgarisTotal.Text = "                                 "
        '
        'lGaris
        '
        Me.lGaris.BackColor = System.Drawing.Color.Transparent
        Me.lGaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lGaris.Location = New System.Drawing.Point(74, 67)
        Me.lGaris.Name = "lGaris"
        Me.lGaris.Size = New System.Drawing.Size(305, 11)
        Me.lGaris.TabIndex = 31
        Me.lGaris.Text = "---------------------------------------------------------------------------------" & _
    "--------------"
        '
        'PrintStruk
        '
        '
        'lAlamat
        '
        Me.lAlamat.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lAlamat.Location = New System.Drawing.Point(77, 33)
        Me.lAlamat.Name = "lAlamat"
        Me.lAlamat.Size = New System.Drawing.Size(310, 12)
        Me.lAlamat.TabIndex = 44
        Me.lAlamat.Text = "Alamat: Jatisari Rt. 002/005 Kel. Gedangan Kec. Kutoreo Mojokerto"
        '
        'lEmail
        '
        Me.lEmail.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lEmail.Location = New System.Drawing.Point(77, 45)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(308, 13)
        Me.lEmail.TabIndex = 45
        Me.lEmail.Text = "Email: lukmantenggiri89@gmail.com - WA: 08 1111 0666"
        '
        'lKontak
        '
        Me.lKontak.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lKontak.Location = New System.Drawing.Point(77, 58)
        Me.lKontak.Name = "lKontak"
        Me.lKontak.Size = New System.Drawing.Size(308, 16)
        Me.lKontak.TabIndex = 46
        Me.lKontak.Text = "Call/Sms: 08 222 555 0 666  -  BBM: 570DE016"
        '
        'lNamaUsaha
        '
        Me.lNamaUsaha.AutoSize = True
        Me.lNamaUsaha.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lNamaUsaha.Location = New System.Drawing.Point(74, 9)
        Me.lNamaUsaha.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lNamaUsaha.Name = "lNamaUsaha"
        Me.lNamaUsaha.Size = New System.Drawing.Size(206, 24)
        Me.lNamaUsaha.TabIndex = 43
        Me.lNamaUsaha.Text = "BERKAH NDARU LAUT"
        '
        'LkasirDate
        '
        Me.LkasirDate.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.LkasirDate.Location = New System.Drawing.Point(236, 91)
        Me.LkasirDate.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LkasirDate.Name = "LkasirDate"
        Me.LkasirDate.Size = New System.Drawing.Size(136, 13)
        Me.LkasirDate.TabIndex = 48
        Me.LkasirDate.Text = "Lukman, Kamis 21 Jan 2017"
        Me.LkasirDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lCust
        '
        Me.lCust.AutoSize = True
        Me.lCust.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCust.Location = New System.Drawing.Point(9, 91)
        Me.lCust.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lCust.Name = "lCust"
        Me.lCust.Size = New System.Drawing.Size(104, 13)
        Me.lCust.TabIndex = 49
        Me.lCust.Text = "Kud Sumber Makmur"
        Me.lCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lll
        '
        Me.lll.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lll.Location = New System.Drawing.Point(143, 251)
        Me.lll.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lll.Name = "lll"
        Me.lll.Size = New System.Drawing.Size(104, 13)
        Me.lll.TabIndex = 50
        Me.lll.Text = "555"
        Me.lll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lll.Visible = False
        '
        'Lref
        '
        Me.Lref.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Underline)
        Me.Lref.Location = New System.Drawing.Point(296, 15)
        Me.Lref.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Lref.Name = "Lref"
        Me.Lref.Size = New System.Drawing.Size(79, 13)
        Me.Lref.TabIndex = 51
        Me.Lref.Text = "Ref: 34523"
        Me.Lref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(244, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Harus Bayar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Kepada Yth:"
        '
        'srtNama
        '
        Me.srtNama.BackColor = System.Drawing.Color.White
        Me.srtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.srtNama.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.srtNama.Location = New System.Drawing.Point(61, 93)
        Me.srtNama.Name = "srtNama"
        Me.srtNama.Size = New System.Drawing.Size(179, 14)
        Me.srtNama.TabIndex = 1
        '
        'gSuratJalan
        '
        Me.gSuratJalan.AppearanceCaption.Options.UseTextOptions = True
        Me.gSuratJalan.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gSuratJalan.Controls.Add(Me.Panel2)
        Me.gSuratJalan.Controls.Add(Me.BtnSrtJ)
        Me.gSuratJalan.Controls.Add(Me.BtnCancelSrtJ)
        Me.gSuratJalan.Controls.Add(Me.srtKet)
        Me.gSuratJalan.Controls.Add(Me.srtAlamat)
        Me.gSuratJalan.Controls.Add(Me.srtTelp)
        Me.gSuratJalan.Controls.Add(Me.srtNama)
        Me.gSuratJalan.Controls.Add(Me.Label7)
        Me.gSuratJalan.Controls.Add(Me.Label6)
        Me.gSuratJalan.Controls.Add(Me.Label5)
        Me.gSuratJalan.Controls.Add(Me.Label3)
        Me.gSuratJalan.Controls.Add(Me.Label2)
        Me.gSuratJalan.Location = New System.Drawing.Point(425, 15)
        Me.gSuratJalan.Name = "gSuratJalan"
        Me.gSuratJalan.Size = New System.Drawing.Size(284, 462)
        Me.gSuratJalan.TabIndex = 55
        Me.gSuratJalan.Text = "Surat Jalan"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtTanggal)
        Me.Panel2.Location = New System.Drawing.Point(192, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(79, 18)
        Me.Panel2.TabIndex = 57
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "  dd MMM yyyy"
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(-1, -2)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(120, 21)
        Me.dtTanggal.TabIndex = 0
        '
        'BtnSrtJ
        '
        Me.BtnSrtJ.Location = New System.Drawing.Point(114, 346)
        Me.BtnSrtJ.Name = "BtnSrtJ"
        Me.BtnSrtJ.Size = New System.Drawing.Size(75, 23)
        Me.BtnSrtJ.TabIndex = 5
        Me.BtnSrtJ.Text = "Print"
        Me.BtnSrtJ.UseVisualStyleBackColor = True
        '
        'BtnCancelSrtJ
        '
        Me.BtnCancelSrtJ.Location = New System.Drawing.Point(193, 346)
        Me.BtnCancelSrtJ.Name = "BtnCancelSrtJ"
        Me.BtnCancelSrtJ.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelSrtJ.TabIndex = 6
        Me.BtnCancelSrtJ.Text = "Cancel"
        Me.BtnCancelSrtJ.UseVisualStyleBackColor = True
        '
        'srtKet
        '
        Me.srtKet.BackColor = System.Drawing.Color.White
        Me.srtKet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.srtKet.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.srtKet.Location = New System.Drawing.Point(18, 179)
        Me.srtKet.Multiline = True
        Me.srtKet.Name = "srtKet"
        Me.srtKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.srtKet.Size = New System.Drawing.Size(250, 154)
        Me.srtKet.TabIndex = 4
        '
        'srtAlamat
        '
        Me.srtAlamat.BackColor = System.Drawing.Color.White
        Me.srtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.srtAlamat.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.srtAlamat.Location = New System.Drawing.Point(61, 139)
        Me.srtAlamat.Name = "srtAlamat"
        Me.srtAlamat.Size = New System.Drawing.Size(205, 14)
        Me.srtAlamat.TabIndex = 3
        '
        'srtTelp
        '
        Me.srtTelp.BackColor = System.Drawing.Color.White
        Me.srtTelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.srtTelp.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.srtTelp.Location = New System.Drawing.Point(61, 116)
        Me.srtTelp.Name = "srtTelp"
        Me.srtTelp.Size = New System.Drawing.Size(100, 14)
        Me.srtTelp.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(13, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Keterangan:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(13, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Alamat:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "No. Telp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Nama:"
        '
        'PrintSrtJ
        '
        '
        'lLoading
        '
        Me.lLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lLoading.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lLoading.Location = New System.Drawing.Point(119, 74)
        Me.lLoading.Name = "lLoading"
        Me.lLoading.Size = New System.Drawing.Size(132, 23)
        Me.lLoading.TabIndex = 56
        Me.lLoading.Text = "Loading ..."
        Me.lLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 489)
        Me.Controls.Add(Me.lLoading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lref)
        Me.Controls.Add(Me.lll)
        Me.Controls.Add(Me.lCust)
        Me.Controls.Add(Me.LkasirDate)
        Me.Controls.Add(Me.lAlamat)
        Me.Controls.Add(Me.lEmail)
        Me.Controls.Add(Me.lKontak)
        Me.Controls.Add(Me.lNamaUsaha)
        Me.Controls.Add(Me.lGaris)
        Me.Controls.Add(Me.Gd)
        Me.Controls.Add(Me.LgarisTotal)
        Me.Controls.Add(Me.lTotalBiaya)
        Me.Controls.Add(Me.ThrsByr)
        Me.Controls.Add(Me.lTanggunganLama)
        Me.Controls.Add(Me.TngLama)
        Me.Controls.Add(Me.TtlBiaya)
        Me.Controls.Add(Me.pLogo)
        Me.Controls.Add(Me.PnlBawah)
        Me.Controls.Add(Me.gSuratJalan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "fBayar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fBayar"
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBawah.ResumeLayout(False)
        CType(Me.gProses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gProses.ResumeLayout(False)
        Me.gProses.PerformLayout()
        CType(Me.pnlBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBayar.ResumeLayout(False)
        Me.pnlBayar.PerformLayout()
        CType(Me.gSuratJalan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gSuratJalan.ResumeLayout(False)
        Me.gSuratJalan.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents pLogo As System.Windows.Forms.PictureBox
   Friend WithEvents Gd As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
   Friend WithEvents tTunai As System.Windows.Forms.TextBox
   Friend WithEvents CmdBayar As System.Windows.Forms.Button
   Friend WithEvents CmdCancel As System.Windows.Forms.Button
   Friend WithEvents PnlBawah As System.Windows.Forms.Panel
   Friend WithEvents TtlBiaya As System.Windows.Forms.TextBox
   Friend WithEvents TngLama As System.Windows.Forms.TextBox
   Friend WithEvents lTotalBiaya As System.Windows.Forms.Label
   Friend WithEvents lTanggunganLama As System.Windows.Forms.Label
   Friend WithEvents ThrsByr As System.Windows.Forms.TextBox
   Friend WithEvents LgarisTotal As System.Windows.Forms.Label
   Friend WithEvents gProses As DevExpress.XtraEditors.GroupControl
   Friend WithEvents TngNext As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents pnlBayar As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lGaris As System.Windows.Forms.Label
   Friend WithEvents lTangBaru As System.Windows.Forms.TextBox
   Friend WithEvents ckPreview As System.Windows.Forms.CheckBox
   Friend WithEvents PrintStruk As System.Drawing.Printing.PrintDocument
   Friend WithEvents lAlamat As System.Windows.Forms.Label
   Friend WithEvents lEmail As System.Windows.Forms.Label
   Friend WithEvents lKontak As System.Windows.Forms.Label
   Friend WithEvents lNamaUsaha As System.Windows.Forms.Label
   Friend WithEvents LkasirDate As System.Windows.Forms.Label
   Friend WithEvents lCust As System.Windows.Forms.Label
   Friend WithEvents lll As System.Windows.Forms.Label
   Friend WithEvents Lref As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents BtnSuratJalan As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents srtNama As System.Windows.Forms.TextBox
   Friend WithEvents gSuratJalan As DevExpress.XtraEditors.GroupControl
   Friend WithEvents srtKet As System.Windows.Forms.TextBox
   Friend WithEvents srtAlamat As System.Windows.Forms.TextBox
   Friend WithEvents srtTelp As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents BtnSrtJ As System.Windows.Forms.Button
   Friend WithEvents BtnCancelSrtJ As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
   Friend WithEvents PrintSrtJ As System.Drawing.Printing.PrintDocument
   Friend WithEvents lLoading As System.Windows.Forms.Label
End Class
