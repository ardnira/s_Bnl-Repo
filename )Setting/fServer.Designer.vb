<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fServer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.tServer_Database = New System.Windows.Forms.TextBox()
        Me.tServer_Password = New System.Windows.Forms.TextBox()
        Me.tServer_User = New System.Windows.Forms.TextBox()
        Me.tServer_Alamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btServer = New System.Windows.Forms.Button()
        Me.GunaColorTransition1 = New Guna.UI.WinForms.GunaColorTransition(Me.components)
        Me.gn = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lthm = New System.Windows.Forms.Label()
        Me.Lst = New System.Windows.Forms.ListBox()
        Me.lc4 = New System.Windows.Forms.Label()
        Me.lc3 = New System.Windows.Forms.Label()
        Me.lc2 = New System.Windows.Forms.Label()
        Me.lc1 = New System.Windows.Forms.Label()
        Me.grp.SuspendLayout()
        CType(Me.gn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp.Controls.Add(Me.tServer_Database)
        Me.grp.Controls.Add(Me.tServer_Password)
        Me.grp.Controls.Add(Me.tServer_User)
        Me.grp.Controls.Add(Me.tServer_Alamat)
        Me.grp.Controls.Add(Me.Label1)
        Me.grp.Controls.Add(Me.Label8)
        Me.grp.Controls.Add(Me.Label7)
        Me.grp.Controls.Add(Me.Label3)
        Me.grp.ForeColor = System.Drawing.Color.White
        Me.grp.Location = New System.Drawing.Point(146, 20)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(332, 103)
        Me.grp.TabIndex = 131
        Me.grp.TabStop = False
        Me.grp.Text = "Server Utama"
        '
        'tServer_Database
        '
        Me.tServer_Database.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tServer_Database.Location = New System.Drawing.Point(52, 61)
        Me.tServer_Database.Name = "tServer_Database"
        Me.tServer_Database.Size = New System.Drawing.Size(123, 20)
        Me.tServer_Database.TabIndex = 2
        '
        'tServer_Password
        '
        Me.tServer_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tServer_Password.Location = New System.Drawing.Point(238, 61)
        Me.tServer_Password.Name = "tServer_Password"
        Me.tServer_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tServer_Password.Size = New System.Drawing.Size(79, 20)
        Me.tServer_Password.TabIndex = 4
        '
        'tServer_User
        '
        Me.tServer_User.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tServer_User.Location = New System.Drawing.Point(238, 22)
        Me.tServer_User.Name = "tServer_User"
        Me.tServer_User.Size = New System.Drawing.Size(79, 20)
        Me.tServer_User.TabIndex = 3
        '
        'tServer_Alamat
        '
        Me.tServer_Alamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tServer_Alamat.Location = New System.Drawing.Point(52, 22)
        Me.tServer_Alamat.Name = "tServer_Alamat"
        Me.tServer_Alamat.Size = New System.Drawing.Size(123, 20)
        Me.tServer_Alamat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(205, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Psw"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(205, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "user"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Database"
        '
        'btCancel
        '
        Me.btCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(411, 142)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(67, 37)
        Me.btCancel.TabIndex = 130
        Me.btCancel.Text = "Close"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btServer
        '
        Me.btServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btServer.Location = New System.Drawing.Point(338, 142)
        Me.btServer.Name = "btServer"
        Me.btServer.Size = New System.Drawing.Size(67, 37)
        Me.btServer.TabIndex = 129
        Me.btServer.Text = "Set Server"
        Me.btServer.UseVisualStyleBackColor = True
        '
        'GunaColorTransition1
        '
        Me.GunaColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        Me.GunaColorTransition1.EndColor = System.Drawing.Color.Blue
        Me.GunaColorTransition1.StartColor = System.Drawing.Color.Red
        '
        'gn
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gn.BackgroundColor = System.Drawing.Color.White
        Me.gn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gn.ColumnHeadersHeight = 21
        Me.gn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gn.DefaultCellStyle = DataGridViewCellStyle3
        Me.gn.Enabled = False
        Me.gn.EnableHeadersVisualStyles = False
        Me.gn.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.gn.Location = New System.Drawing.Point(-2, 174)
        Me.gn.Name = "gn"
        Me.gn.RowHeadersVisible = False
        Me.gn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.gn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gn.Size = New System.Drawing.Size(42, 59)
        Me.gn.TabIndex = 133
        Me.gn.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepOrange
        Me.gn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gn.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gn.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.gn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.gn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gn.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gn.ThemeStyle.HeaderStyle.Height = 21
        Me.gn.ThemeStyle.ReadOnly = False
        Me.gn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gn.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gn.ThemeStyle.RowsStyle.Height = 22
        Me.gn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.gn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gn.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "     "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        '
        'Lthm
        '
        Me.Lthm.Location = New System.Drawing.Point(147, 142)
        Me.Lthm.Name = "Lthm"
        Me.Lthm.Size = New System.Drawing.Size(27, 21)
        Me.Lthm.TabIndex = 139
        Me.Lthm.Text = "Label1"
        Me.Lthm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lthm.Visible = False
        '
        'Lst
        '
        Me.Lst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lst.FormattingEnabled = True
        Me.Lst.IntegralHeight = False
        Me.Lst.Location = New System.Drawing.Point(23, 20)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(108, 159)
        Me.Lst.TabIndex = 138
        '
        'lc4
        '
        Me.lc4.Location = New System.Drawing.Point(259, 142)
        Me.lc4.Name = "lc4"
        Me.lc4.Size = New System.Drawing.Size(27, 21)
        Me.lc4.TabIndex = 134
        Me.lc4.Text = "lc4"
        Me.lc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lc4.Visible = False
        '
        'lc3
        '
        Me.lc3.Location = New System.Drawing.Point(231, 142)
        Me.lc3.Name = "lc3"
        Me.lc3.Size = New System.Drawing.Size(27, 21)
        Me.lc3.TabIndex = 135
        Me.lc3.Text = "lc3"
        Me.lc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lc3.Visible = False
        '
        'lc2
        '
        Me.lc2.Location = New System.Drawing.Point(203, 142)
        Me.lc2.Name = "lc2"
        Me.lc2.Size = New System.Drawing.Size(27, 21)
        Me.lc2.TabIndex = 136
        Me.lc2.Text = "lc2"
        Me.lc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lc2.Visible = False
        '
        'lc1
        '
        Me.lc1.Location = New System.Drawing.Point(175, 142)
        Me.lc1.Name = "lc1"
        Me.lc1.Size = New System.Drawing.Size(27, 21)
        Me.lc1.TabIndex = 137
        Me.lc1.Text = "lc1"
        Me.lc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lc1.Visible = False
        '
        'fServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(507, 206)
        Me.Controls.Add(Me.Lthm)
        Me.Controls.Add(Me.lc4)
        Me.Controls.Add(Me.lc3)
        Me.Controls.Add(Me.lc2)
        Me.Controls.Add(Me.lc1)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btServer)
        Me.Controls.Add(Me.gn)
        Me.Controls.Add(Me.Lst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fServer"
        Me.Text = "Setting"
        Me.TopMost = True
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.gn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp As GroupBox
    Friend WithEvents tServer_Database As TextBox
    Friend WithEvents tServer_Password As TextBox
    Friend WithEvents tServer_User As TextBox
    Friend WithEvents tServer_Alamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btCancel As Button
    Friend WithEvents btServer As Button
    Friend WithEvents GunaColorTransition1 As Guna.UI.WinForms.GunaColorTransition
    Friend WithEvents gn As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Lthm As Label
    Friend WithEvents Lst As ListBox
    Friend WithEvents lc4 As Label
    Friend WithEvents lc3 As Label
    Friend WithEvents lc2 As Label
    Friend WithEvents lc1 As Label
End Class
