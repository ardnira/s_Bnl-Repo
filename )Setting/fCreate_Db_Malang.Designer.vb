<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCreate_Db_Malang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCreate_Db_Malang))
        Me.Cmd_LoadXls = New System.Windows.Forms.Button()
        Me.G_xls = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Bt_CreateDt = New System.Windows.Forms.Button()
        Me.Lexcell = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pgr = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.BtSaveDb = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.G_xls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd_LoadXls
        '
        Me.Cmd_LoadXls.Location = New System.Drawing.Point(23, 12)
        Me.Cmd_LoadXls.Name = "Cmd_LoadXls"
        Me.Cmd_LoadXls.Size = New System.Drawing.Size(95, 33)
        Me.Cmd_LoadXls.TabIndex = 0
        Me.Cmd_LoadXls.Text = "Load Xls"
        Me.Cmd_LoadXls.UseVisualStyleBackColor = True
        '
        'G_xls
        '
        Me.G_xls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.G_xls.BackColor = System.Drawing.Color.White
        Me.G_xls.BackColorAlternate = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.G_xls.BackColorBkg = System.Drawing.Color.White
        Me.G_xls.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.G_xls.BackColorSel = System.Drawing.Color.Silver
        Me.G_xls.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.G_xls.Cols = 4
        Me.G_xls.ColumnInfo = "4,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:62;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.G_xls.EditOptions = C1.Win.C1FlexGrid.EditFlags.None
        Me.G_xls.ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMoveRows
        Me.G_xls.FixedCols = 0
        Me.G_xls.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.G_xls.ForeColor = System.Drawing.Color.Maroon
        Me.G_xls.ForeColorFixed = System.Drawing.Color.Black
        Me.G_xls.ForeColorSel = System.Drawing.Color.Blue
        Me.G_xls.GridColor = System.Drawing.Color.WhiteSmoke
        Me.G_xls.GridColorFixed = System.Drawing.Color.Black
        Me.G_xls.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridSkipHorz
        Me.G_xls.Location = New System.Drawing.Point(209, 71)
        Me.G_xls.Name = "G_xls"
        Me.G_xls.NodeClosedPicture = Nothing
        Me.G_xls.NodeOpenPicture = Nothing
        Me.G_xls.OutlineCol = -1
        Me.G_xls.Rows = 8
        Me.G_xls.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.G_xls.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
        Me.G_xls.SheetBorder = System.Drawing.Color.White
        Me.G_xls.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
        Me.G_xls.Size = New System.Drawing.Size(610, 350)
        Me.G_xls.StyleInfo = resources.GetString("G_xls.StyleInfo")
        Me.G_xls.TabIndex = 133
        Me.G_xls.TreeColor = System.Drawing.Color.DarkGray
        '
        'Bt_CreateDt
        '
        Me.Bt_CreateDt.Location = New System.Drawing.Point(209, 7)
        Me.Bt_CreateDt.Name = "Bt_CreateDt"
        Me.Bt_CreateDt.Size = New System.Drawing.Size(95, 33)
        Me.Bt_CreateDt.TabIndex = 0
        Me.Bt_CreateDt.Text = "Create Db"
        Me.Bt_CreateDt.UseVisualStyleBackColor = True
        '
        'Lexcell
        '
        Me.Lexcell.AutoSize = True
        Me.Lexcell.Location = New System.Drawing.Point(22, 57)
        Me.Lexcell.Name = "Lexcell"
        Me.Lexcell.Size = New System.Drawing.Size(40, 13)
        Me.Lexcell.TabIndex = 134
        Me.Lexcell.Text = "Lexcell"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(796, 349)
        Me.TabControl1.TabIndex = 135
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(788, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(788, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pgr
        '
        Me.pgr.Animated = True
        Me.pgr.AnimationSpeed = 0.6!
        Me.pgr.BackColor = System.Drawing.Color.Transparent
        Me.pgr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pgr.BaseColor = System.Drawing.Color.White
        Me.pgr.IdleColor = System.Drawing.Color.Gainsboro
        Me.pgr.IdleOffset = 20
        Me.pgr.Image = Nothing
        Me.pgr.ImageSize = New System.Drawing.Size(52, 52)
        Me.pgr.Location = New System.Drawing.Point(122, -1)
        Me.pgr.Margin = New System.Windows.Forms.Padding(1)
        Me.pgr.Name = "pgr"
        Me.pgr.ProgressMaxColor = System.Drawing.Color.Red
        Me.pgr.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pgr.ProgressOffset = 4
        Me.pgr.ProgressThickness = 6
        Me.pgr.Size = New System.Drawing.Size(55, 55)
        Me.pgr.TabIndex = 140
        Me.pgr.UseProgressPercentText = True
        Me.pgr.UseWaitCursor = True
        Me.pgr.Value = 44
        Me.pgr.Visible = False
        '
        'BtSaveDb
        '
        Me.BtSaveDb.Location = New System.Drawing.Point(404, 11)
        Me.BtSaveDb.Name = "BtSaveDb"
        Me.BtSaveDb.Size = New System.Drawing.Size(75, 42)
        Me.BtSaveDb.TabIndex = 141
        Me.BtSaveDb.Text = "Save To Db"
        Me.BtSaveDb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 42)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fCreate_Db_Malang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 439)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtSaveDb)
        Me.Controls.Add(Me.pgr)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Lexcell)
        Me.Controls.Add(Me.G_xls)
        Me.Controls.Add(Me.Bt_CreateDt)
        Me.Controls.Add(Me.Cmd_LoadXls)
        Me.Name = "fCreate_Db_Malang"
        Me.Text = "fCreate_Db_Malang"
        Me.TopMost = True
        CType(Me.G_xls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_LoadXls As Button
    Friend WithEvents G_xls As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Bt_CreateDt As Button
    Friend WithEvents Lexcell As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pgr As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents BtSaveDb As Button
    Friend WithEvents Button1 As Button
End Class
