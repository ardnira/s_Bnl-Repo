<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fUpdate
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUpdate))
      Me.bt_Colapse = New System.Windows.Forms.Button()
      Me.pjok_3 = New System.Windows.Forms.Label()
      Me.pnl_proses = New System.Windows.Forms.Panel()
      Me.bt_Cancel = New System.Windows.Forms.Button()
      Me.bt_Ok = New System.Windows.Forms.Button()
      Me.Ljudul = New System.Windows.Forms.Label()
      Me.pg = New PropertyGridEx.PropertyGridEx()
      Me.pct_foto = New Guna.UI.WinForms.GunaPictureBox()
      Me.pnl_proses.SuspendLayout()
      CType(Me.pct_foto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'bt_Colapse
      '
      Me.bt_Colapse.BackColor = System.Drawing.Color.White
      Me.bt_Colapse.FlatAppearance.BorderSize = 0
      Me.bt_Colapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
      Me.bt_Colapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.bt_Colapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Colapse.ForeColor = System.Drawing.Color.White
      Me.bt_Colapse.Image = CType(resources.GetObject("bt_Colapse.Image"), System.Drawing.Image)
      Me.bt_Colapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.bt_Colapse.Location = New System.Drawing.Point(-84, 35)
      Me.bt_Colapse.Name = "bt_Colapse"
      Me.bt_Colapse.Size = New System.Drawing.Size(28, 18)
      Me.bt_Colapse.TabIndex = 149
      Me.bt_Colapse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.bt_Colapse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.bt_Colapse.UseVisualStyleBackColor = False
      '
      'pjok_3
      '
      Me.pjok_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pjok_3.BackColor = System.Drawing.Color.Gray
      Me.pjok_3.Enabled = False
      Me.pjok_3.Location = New System.Drawing.Point(473, 309)
      Me.pjok_3.Name = "pjok_3"
      Me.pjok_3.Size = New System.Drawing.Size(3, 3)
      Me.pjok_3.TabIndex = 147
      '
      'pnl_proses
      '
      Me.pnl_proses.Controls.Add(Me.bt_Cancel)
      Me.pnl_proses.Controls.Add(Me.bt_Ok)
      Me.pnl_proses.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.pnl_proses.Location = New System.Drawing.Point(5, 282)
      Me.pnl_proses.Name = "pnl_proses"
      Me.pnl_proses.Size = New System.Drawing.Size(384, 44)
      Me.pnl_proses.TabIndex = 151
      '
      'bt_Cancel
      '
      Me.bt_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.bt_Cancel.BackColor = System.Drawing.Color.LightSlateGray
      Me.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.bt_Cancel.FlatAppearance.BorderSize = 0
      Me.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
      Me.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Cancel.ForeColor = System.Drawing.Color.White
      Me.bt_Cancel.Location = New System.Drawing.Point(277, 7)
      Me.bt_Cancel.Name = "bt_Cancel"
      Me.bt_Cancel.Size = New System.Drawing.Size(81, 32)
      Me.bt_Cancel.TabIndex = 135
      Me.bt_Cancel.Text = "Cancel"
      Me.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.bt_Cancel.UseVisualStyleBackColor = False
      '
      'bt_Ok
      '
      Me.bt_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.bt_Ok.BackColor = System.Drawing.Color.LightSlateGray
      Me.bt_Ok.FlatAppearance.BorderSize = 0
      Me.bt_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
      Me.bt_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.bt_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.bt_Ok.ForeColor = System.Drawing.Color.White
      Me.bt_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.bt_Ok.Location = New System.Drawing.Point(189, 7)
      Me.bt_Ok.Name = "bt_Ok"
      Me.bt_Ok.Size = New System.Drawing.Size(82, 32)
      Me.bt_Ok.TabIndex = 134
      Me.bt_Ok.Text = "Save"
      Me.bt_Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.bt_Ok.UseVisualStyleBackColor = False
      '
      'Ljudul
      '
      Me.Ljudul.BackColor = System.Drawing.Color.CadetBlue
      Me.Ljudul.Font = New System.Drawing.Font("Agency FB", 14.0!)
      Me.Ljudul.ForeColor = System.Drawing.Color.White
      Me.Ljudul.Location = New System.Drawing.Point(6, 6)
      Me.Ljudul.Name = "Ljudul"
      Me.Ljudul.Size = New System.Drawing.Size(144, 27)
      Me.Ljudul.TabIndex = 152
      Me.Ljudul.Text = "Form Daftar Bangunan"
      '
      'pg
      '
      Me.pg.BackColor = System.Drawing.Color.CadetBlue
      Me.pg.CanShowVisualStyleGlyphs = False
      Me.pg.CategorySplitterColor = System.Drawing.Color.OrangeRed
      Me.pg.CommandsBackColor = System.Drawing.Color.Teal
      Me.pg.CommandsVisibleIfAvailable = False
      '
      '
      '
      Me.pg.DocCommentDescription.AccessibleName = ""
      Me.pg.DocCommentDescription.AutoEllipsis = True
      Me.pg.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default
      Me.pg.DocCommentDescription.Location = New System.Drawing.Point(3, 18)
      Me.pg.DocCommentDescription.Name = ""
      Me.pg.DocCommentDescription.Size = New System.Drawing.Size(378, 37)
      Me.pg.DocCommentDescription.TabIndex = 1
      Me.pg.DocCommentImage = Nothing
      '
      '
      '
      Me.pg.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default
      Me.pg.DocCommentTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.pg.DocCommentTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
      Me.pg.DocCommentTitle.Location = New System.Drawing.Point(3, 3)
      Me.pg.DocCommentTitle.Name = ""
      Me.pg.DocCommentTitle.Size = New System.Drawing.Size(378, 15)
      Me.pg.DocCommentTitle.TabIndex = 0
      Me.pg.DocCommentTitle.Text = "New Property"
      Me.pg.DocCommentTitle.UseMnemonic = False
      Me.pg.Dock = System.Windows.Forms.DockStyle.Fill
      Me.pg.ImeMode = System.Windows.Forms.ImeMode.[On]
      Me.pg.Item.Add(CType(resources.GetObject("pg.Item"), PropertyGridEx.CustomProperty))
      Me.pg.Item.Add(CType(resources.GetObject("pg.Item1"), PropertyGridEx.CustomProperty))
      Me.pg.Item.Add(CType(resources.GetObject("pg.Item2"), PropertyGridEx.CustomProperty))
      Me.pg.Item.Add(CType(resources.GetObject("pg.Item3"), PropertyGridEx.CustomProperty))
      Me.pg.Item.Add(CType(resources.GetObject("pg.Item4"), PropertyGridEx.CustomProperty))
      Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet"), PropertyGridEx.CustomPropertyCollection))
      Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet1"), PropertyGridEx.CustomPropertyCollection))
      Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet2"), PropertyGridEx.CustomPropertyCollection))
      Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet3"), PropertyGridEx.CustomPropertyCollection))
      Me.pg.ItemSet.Add(CType(resources.GetObject("pg.ItemSet4"), PropertyGridEx.CustomPropertyCollection))
      Me.pg.Location = New System.Drawing.Point(5, 37)
      Me.pg.Name = "pg"
      Me.pg.PropertySort = System.Windows.Forms.PropertySort.NoSort
      Me.pg.SelectedObject = CType(resources.GetObject("pg.SelectedObject"), Object)
      Me.pg.Size = New System.Drawing.Size(384, 245)
      Me.pg.TabIndex = 153
      '
      '
      '
      Me.pg.ToolStrip.AccessibleName = "ToolBar"
      Me.pg.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
      Me.pg.ToolStrip.AllowMerge = False
      Me.pg.ToolStrip.AutoSize = False
      Me.pg.ToolStrip.BackColor = System.Drawing.Color.CadetBlue
      Me.pg.ToolStrip.CanOverflow = False
      Me.pg.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
      Me.pg.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
      Me.pg.ToolStrip.Location = New System.Drawing.Point(0, 1)
      Me.pg.ToolStrip.Name = ""
      Me.pg.ToolStrip.Padding = New System.Windows.Forms.Padding(2, 0, 1, 0)
      Me.pg.ToolStrip.Size = New System.Drawing.Size(384, 25)
      Me.pg.ToolStrip.TabIndex = 1
      Me.pg.ToolStrip.TabStop = True
      Me.pg.ToolStrip.Text = "PropertyGridToolBar"
      '
      'pct_foto
      '
      Me.pct_foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pct_foto.BackColor = System.Drawing.Color.Coral
      Me.pct_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.pct_foto.BaseColor = System.Drawing.Color.White
      Me.pct_foto.Location = New System.Drawing.Point(274, 228)
      Me.pct_foto.Name = "pct_foto"
      Me.pct_foto.Size = New System.Drawing.Size(111, 50)
      Me.pct_foto.TabIndex = 154
      Me.pct_foto.TabStop = False
      Me.pct_foto.Visible = False
      '
      'fUpdate
      '
      Me.AcceptButton = Me.bt_Ok
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Silver
      Me.CancelButton = Me.bt_Cancel
      Me.ClientSize = New System.Drawing.Size(394, 331)
      Me.ControlBox = False
      Me.Controls.Add(Me.pct_foto)
      Me.Controls.Add(Me.pg)
      Me.Controls.Add(Me.Ljudul)
      Me.Controls.Add(Me.pnl_proses)
      Me.Controls.Add(Me.bt_Colapse)
      Me.Controls.Add(Me.pjok_3)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "fUpdate"
      Me.Padding = New System.Windows.Forms.Padding(5, 37, 5, 5)
      Me.ShowIcon = False
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.TopMost = True
      Me.pnl_proses.ResumeLayout(False)
      CType(Me.pct_foto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents bt_Colapse As Button
   Friend WithEvents pjok_3 As Label
   Friend WithEvents pnl_proses As Panel
   Friend WithEvents bt_Cancel As Button
   Friend WithEvents bt_Ok As Button
   Friend WithEvents Ljudul As Label
   Friend WithEvents pg As PropertyGridEx.PropertyGridEx
   Friend WithEvents pct_foto As Guna.UI.WinForms.GunaPictureBox
End Class
