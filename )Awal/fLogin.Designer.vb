<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLogin
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLogin))
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.tUser = New System.Windows.Forms.TextBox()
      Me.tPassword = New System.Windows.Forms.TextBox()
      Me.ckEdit = New System.Windows.Forms.CheckBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.lpsw_edit = New System.Windows.Forms.Label()
      Me.te_User = New System.Windows.Forms.TextBox()
      Me.te_Password = New System.Windows.Forms.TextBox()
      Me.te_Confirm = New System.Windows.Forms.TextBox()
      Me.Grp_Edit = New System.Windows.Forms.GroupBox()
      Me.ck_HakAkses = New System.Windows.Forms.CheckBox()
      Me.pnl_Akses = New System.Windows.Forms.Panel()
      Me.bt_Del_User = New System.Windows.Forms.Button()
      Me.bt_New_User = New System.Windows.Forms.Button()
      Me.list_Akses = New System.Windows.Forms.ListBox()
      Me.G = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
      Me.bt_Del = New System.Windows.Forms.Button()
      Me.bt_Add = New System.Windows.Forms.Button()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.btLogin = New System.Windows.Forms.Button()
      Me.btCancel = New System.Windows.Forms.Button()
      Me.l_Akses = New System.Windows.Forms.Label()
      Me.pnl_Admin = New System.Windows.Forms.Panel()
      Me.tpsw_Admin = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Grp_Edit.SuspendLayout()
      Me.pnl_Akses.SuspendLayout()
      CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.pnl_Admin.SuspendLayout()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(44, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(32, 15)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "User"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(15, 55)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(61, 15)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Password"
      '
      'tUser
      '
      Me.tUser.Location = New System.Drawing.Point(77, 18)
      Me.tUser.Name = "tUser"
      Me.tUser.Size = New System.Drawing.Size(100, 20)
      Me.tUser.TabIndex = 0
      '
      'tPassword
      '
      Me.tPassword.Location = New System.Drawing.Point(77, 53)
      Me.tPassword.Name = "tPassword"
      Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.tPassword.Size = New System.Drawing.Size(100, 20)
      Me.tPassword.TabIndex = 1
      '
      'ckEdit
      '
      Me.ckEdit.AutoSize = True
      Me.ckEdit.Location = New System.Drawing.Point(77, 89)
      Me.ckEdit.Name = "ckEdit"
      Me.ckEdit.Size = New System.Drawing.Size(44, 17)
      Me.ckEdit.TabIndex = 2
      Me.ckEdit.Text = "Edit"
      Me.ckEdit.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(33, 25)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(32, 15)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "User"
      '
      'lpsw_edit
      '
      Me.lpsw_edit.AutoSize = True
      Me.lpsw_edit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lpsw_edit.Location = New System.Drawing.Point(10, 60)
      Me.lpsw_edit.Name = "lpsw_edit"
      Me.lpsw_edit.Size = New System.Drawing.Size(55, 15)
      Me.lpsw_edit.TabIndex = 5
      Me.lpsw_edit.Text = "New Psw"
      '
      'te_User
      '
      Me.te_User.Font = New System.Drawing.Font("Calibri", 8.0!)
      Me.te_User.Location = New System.Drawing.Point(65, 23)
      Me.te_User.Name = "te_User"
      Me.te_User.Size = New System.Drawing.Size(97, 21)
      Me.te_User.TabIndex = 6
      '
      'te_Password
      '
      Me.te_Password.Font = New System.Drawing.Font("Calibri", 8.0!)
      Me.te_Password.Location = New System.Drawing.Point(65, 58)
      Me.te_Password.Name = "te_Password"
      Me.te_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.te_Password.Size = New System.Drawing.Size(47, 21)
      Me.te_Password.TabIndex = 7
      '
      'te_Confirm
      '
      Me.te_Confirm.Font = New System.Drawing.Font("Calibri", 8.0!)
      Me.te_Confirm.Location = New System.Drawing.Point(115, 58)
      Me.te_Confirm.Name = "te_Confirm"
      Me.te_Confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.te_Confirm.Size = New System.Drawing.Size(47, 21)
      Me.te_Confirm.TabIndex = 7
      '
      'Grp_Edit
      '
      Me.Grp_Edit.BackColor = System.Drawing.Color.Turquoise
      Me.Grp_Edit.Controls.Add(Me.ck_HakAkses)
      Me.Grp_Edit.Controls.Add(Me.pnl_Akses)
      Me.Grp_Edit.Controls.Add(Me.te_Confirm)
      Me.Grp_Edit.Controls.Add(Me.te_Password)
      Me.Grp_Edit.Controls.Add(Me.te_User)
      Me.Grp_Edit.Controls.Add(Me.lpsw_edit)
      Me.Grp_Edit.Controls.Add(Me.Label3)
      Me.Grp_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Grp_Edit.Location = New System.Drawing.Point(225, 1)
      Me.Grp_Edit.Name = "Grp_Edit"
      Me.Grp_Edit.Size = New System.Drawing.Size(275, 222)
      Me.Grp_Edit.TabIndex = 7
      Me.Grp_Edit.TabStop = False
      Me.Grp_Edit.Text = "Edit"
      '
      'ck_HakAkses
      '
      Me.ck_HakAkses.AutoSize = True
      Me.ck_HakAkses.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
      Me.ck_HakAkses.Location = New System.Drawing.Point(188, 61)
      Me.ck_HakAkses.Name = "ck_HakAkses"
      Me.ck_HakAkses.Size = New System.Drawing.Size(78, 18)
      Me.ck_HakAkses.TabIndex = 12
      Me.ck_HakAkses.Text = "Hak Akses"
      Me.ck_HakAkses.UseVisualStyleBackColor = True
      '
      'pnl_Akses
      '
      Me.pnl_Akses.Controls.Add(Me.bt_Del_User)
      Me.pnl_Akses.Controls.Add(Me.bt_New_User)
      Me.pnl_Akses.Controls.Add(Me.list_Akses)
      Me.pnl_Akses.Controls.Add(Me.G)
      Me.pnl_Akses.Controls.Add(Me.bt_Del)
      Me.pnl_Akses.Controls.Add(Me.bt_Add)
      Me.pnl_Akses.Controls.Add(Me.Label6)
      Me.pnl_Akses.Controls.Add(Me.Label4)
      Me.pnl_Akses.Location = New System.Drawing.Point(5, 91)
      Me.pnl_Akses.Name = "pnl_Akses"
      Me.pnl_Akses.Size = New System.Drawing.Size(234, 129)
      Me.pnl_Akses.TabIndex = 11
      Me.pnl_Akses.Visible = False
      '
      'bt_Del_User
      '
      Me.bt_Del_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.bt_Del_User.FlatAppearance.BorderSize = 0
      Me.bt_Del_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Del_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bt_Del_User.Image = CType(resources.GetObject("bt_Del_User.Image"), System.Drawing.Image)
      Me.bt_Del_User.Location = New System.Drawing.Point(72, 6)
      Me.bt_Del_User.Name = "bt_Del_User"
      Me.bt_Del_User.Size = New System.Drawing.Size(15, 15)
      Me.bt_Del_User.TabIndex = 147
      Me.bt_Del_User.TextAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bt_Del_User.UseVisualStyleBackColor = True
      '
      'bt_New_User
      '
      Me.bt_New_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.bt_New_User.FlatAppearance.BorderSize = 0
      Me.bt_New_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_New_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bt_New_User.Image = CType(resources.GetObject("bt_New_User.Image"), System.Drawing.Image)
      Me.bt_New_User.Location = New System.Drawing.Point(54, 6)
      Me.bt_New_User.Name = "bt_New_User"
      Me.bt_New_User.Size = New System.Drawing.Size(15, 15)
      Me.bt_New_User.TabIndex = 148
      Me.bt_New_User.TextAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bt_New_User.UseVisualStyleBackColor = True
      '
      'list_Akses
      '
      Me.list_Akses.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.list_Akses.Font = New System.Drawing.Font("Calibri", 8.0!)
      Me.list_Akses.FormattingEnabled = True
      Me.list_Akses.IntegralHeight = False
      Me.list_Akses.Location = New System.Drawing.Point(98, 23)
      Me.list_Akses.Name = "list_Akses"
      Me.list_Akses.Size = New System.Drawing.Size(72, 96)
      Me.list_Akses.TabIndex = 9
      '
      'G
      '
      Me.G.BackColor = System.Drawing.Color.White
      Me.G.BackColorAlternate = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(234, Byte), Integer))
      Me.G.BackColorBkg = System.Drawing.Color.White
      Me.G.BackColorFixed = System.Drawing.Color.Gainsboro
      Me.G.BackColorSel = System.Drawing.Color.Silver
      Me.G.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
      Me.G.Cols = 2
      Me.G.ColumnInfo = "2,0,0,0,0,100,Columns:0{Width:47;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:59;}" & Global.Microsoft.VisualBasic.ChrW(9)
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
      Me.G.Location = New System.Drawing.Point(8, 23)
      Me.G.Name = "G"
      Me.G.NodeClosedPicture = Nothing
      Me.G.NodeOpenPicture = Nothing
      Me.G.OutlineCol = -1
      Me.G.Rows = 2
      Me.G.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.G.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
      Me.G.SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionByRow
      Me.G.SheetBorder = System.Drawing.Color.White
      Me.G.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.WhenEditing
      Me.G.Size = New System.Drawing.Size(80, 96)
      Me.G.StyleInfo = resources.GetString("G.StyleInfo")
      Me.G.TabIndex = 132
      Me.G.TreeColor = System.Drawing.Color.DarkGray
      '
      'bt_Del
      '
      Me.bt_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.bt_Del.FlatAppearance.BorderSize = 0
      Me.bt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Del.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bt_Del.Image = CType(resources.GetObject("bt_Del.Image"), System.Drawing.Image)
      Me.bt_Del.Location = New System.Drawing.Point(154, 6)
      Me.bt_Del.Name = "bt_Del"
      Me.bt_Del.Size = New System.Drawing.Size(15, 15)
      Me.bt_Del.TabIndex = 10
      Me.bt_Del.TextAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bt_Del.UseVisualStyleBackColor = True
      '
      'bt_Add
      '
      Me.bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.bt_Add.FlatAppearance.BorderSize = 0
      Me.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bt_Add.Image = CType(resources.GetObject("bt_Add.Image"), System.Drawing.Image)
      Me.bt_Add.Location = New System.Drawing.Point(135, 6)
      Me.bt_Add.Name = "bt_Add"
      Me.bt_Add.Size = New System.Drawing.Size(15, 15)
      Me.bt_Add.TabIndex = 10
      Me.bt_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bt_Add.UseVisualStyleBackColor = True
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(6, 5)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(38, 15)
      Me.Label6.TabIndex = 5
      Me.Label6.Text = "Users"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(96, 5)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(38, 15)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Akses"
      '
      'btLogin
      '
      Me.btLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btLogin.Location = New System.Drawing.Point(411, 139)
      Me.btLogin.Name = "btLogin"
      Me.btLogin.Size = New System.Drawing.Size(75, 31)
      Me.btLogin.TabIndex = 9
      Me.btLogin.Text = "Login"
      Me.btLogin.UseVisualStyleBackColor = True
      '
      'btCancel
      '
      Me.btCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btCancel.Location = New System.Drawing.Point(411, 176)
      Me.btCancel.Name = "btCancel"
      Me.btCancel.Size = New System.Drawing.Size(75, 31)
      Me.btCancel.TabIndex = 10
      Me.btCancel.Text = "Cancel"
      Me.btCancel.UseVisualStyleBackColor = True
      '
      'l_Akses
      '
      Me.l_Akses.Location = New System.Drawing.Point(12, 156)
      Me.l_Akses.Name = "l_Akses"
      Me.l_Akses.Size = New System.Drawing.Size(189, 55)
      Me.l_Akses.TabIndex = 8
      Me.l_Akses.Text = "l_Akses"
      Me.l_Akses.Visible = False
      '
      'pnl_Admin
      '
      Me.pnl_Admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.pnl_Admin.Controls.Add(Me.tpsw_Admin)
      Me.pnl_Admin.Controls.Add(Me.Label5)
      Me.pnl_Admin.Location = New System.Drawing.Point(183, 3)
      Me.pnl_Admin.Name = "pnl_Admin"
      Me.pnl_Admin.Size = New System.Drawing.Size(160, 70)
      Me.pnl_Admin.TabIndex = 11
      Me.pnl_Admin.Visible = False
      '
      'tpsw_Admin
      '
      Me.tpsw_Admin.Location = New System.Drawing.Point(15, 27)
      Me.tpsw_Admin.Name = "tpsw_Admin"
      Me.tpsw_Admin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.tpsw_Admin.Size = New System.Drawing.Size(126, 20)
      Me.tpsw_Admin.TabIndex = 1
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(12, 11)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(85, 13)
      Me.Label5.TabIndex = 0
      Me.Label5.Text = "Password Admin"
      '
      'fLogin
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CausesValidation = False
      Me.ClientSize = New System.Drawing.Size(499, 220)
      Me.ControlBox = False
      Me.Controls.Add(Me.btCancel)
      Me.Controls.Add(Me.btLogin)
      Me.Controls.Add(Me.pnl_Admin)
      Me.Controls.Add(Me.l_Akses)
      Me.Controls.Add(Me.Grp_Edit)
      Me.Controls.Add(Me.ckEdit)
      Me.Controls.Add(Me.tPassword)
      Me.Controls.Add(Me.tUser)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.KeyPreview = True
      Me.Name = "fLogin"
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Login Admin"
      Me.Grp_Edit.ResumeLayout(False)
      Me.Grp_Edit.PerformLayout()
      Me.pnl_Akses.ResumeLayout(False)
      Me.pnl_Akses.PerformLayout()
      CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
      Me.pnl_Admin.ResumeLayout(False)
      Me.pnl_Admin.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tUser As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents ckEdit As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lpsw_edit As Label
    Friend WithEvents te_User As TextBox
    Friend WithEvents te_Password As TextBox
    Friend WithEvents te_Confirm As TextBox
   Friend WithEvents Grp_Edit As GroupBox
   Friend WithEvents btLogin As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents list_Akses As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_Del As Button
    Friend WithEvents bt_Add As Button
    Friend WithEvents l_Akses As Label
    Friend WithEvents pnl_Akses As Panel
    Friend WithEvents ck_HakAkses As CheckBox
    Friend WithEvents pnl_Admin As Panel
    Friend WithEvents tpsw_Admin As TextBox
    Friend WithEvents Label5 As Label
   Friend WithEvents G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
   Friend WithEvents bt_Del_User As Button
   Friend WithEvents bt_New_User As Button
   Friend WithEvents Label6 As Label
End Class
