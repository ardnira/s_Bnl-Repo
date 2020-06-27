<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
   Inherits DevExpress.XtraReports.UI.XtraReport

   'XtraReport overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Designer
   'It can be modified using the Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
      Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
      Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
      Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
      Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
      Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
      Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
      Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.GrandTotalCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.GrandTotalData1 = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.GrandTotalBackground1 = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
      Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
      Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
      Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
      Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
      Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
      Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
      Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
      Me.table1 = New DevExpress.XtraReports.UI.XRTable()
      Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
      Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
      Me.table2 = New DevExpress.XtraReports.UI.XRTable()
      Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
      Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
      Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
      Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
      Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
      Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
      Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
      Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
      CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'SqlDataSource1
      '
      Me.SqlDataSource1.ConnectionName = "arza41_Con"
      Me.SqlDataSource1.Name = "SqlDataSource1"
      ColumnExpression1.ColumnName = "Id"
      Table3.Name = "tBarang"
      ColumnExpression1.Table = Table3
      Column1.Expression = ColumnExpression1
      ColumnExpression2.ColumnName = "NamaBarang"
      ColumnExpression2.Table = Table3
      Column2.Expression = ColumnExpression2
      ColumnExpression3.ColumnName = "Grade"
      ColumnExpression3.Table = Table3
      Column3.Expression = ColumnExpression3
      ColumnExpression4.ColumnName = "Kategori"
      ColumnExpression4.Table = Table3
      Column4.Expression = ColumnExpression4
      ColumnExpression5.ColumnName = "Satuan"
      ColumnExpression5.Table = Table3
      Column5.Expression = ColumnExpression5
      ColumnExpression6.ColumnName = "HargaBeli"
      ColumnExpression6.Table = Table3
      Column6.Expression = ColumnExpression6
      ColumnExpression7.ColumnName = "HargaJual"
      ColumnExpression7.Table = Table3
      Column7.Expression = ColumnExpression7
      ColumnExpression8.ColumnName = "StockAwal"
      ColumnExpression8.Table = Table3
      Column8.Expression = ColumnExpression8
      ColumnExpression9.ColumnName = "StockMinimal"
      ColumnExpression9.Table = Table3
      Column9.Expression = ColumnExpression9
      SelectQuery1.Columns.Add(Column1)
      SelectQuery1.Columns.Add(Column2)
      SelectQuery1.Columns.Add(Column3)
      SelectQuery1.Columns.Add(Column4)
      SelectQuery1.Columns.Add(Column5)
      SelectQuery1.Columns.Add(Column6)
      SelectQuery1.Columns.Add(Column7)
      SelectQuery1.Columns.Add(Column8)
      SelectQuery1.Columns.Add(Column9)
      SelectQuery1.Name = "tBarang"
      SelectQuery1.Tables.Add(Table3)
      Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
      Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
      '
      'Title
      '
      Me.Title.BackColor = System.Drawing.Color.Transparent
      Me.Title.BorderColor = System.Drawing.Color.Black
      Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.Title.BorderWidth = 1.0!
      Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
      Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
      Me.Title.Name = "Title"
      '
      'DetailCaption1
      '
      Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(107, Byte), Integer))
      Me.DetailCaption1.BorderColor = System.Drawing.Color.White
      Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
      Me.DetailCaption1.BorderWidth = 2.0!
      Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
      Me.DetailCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
      Me.DetailCaption1.Name = "DetailCaption1"
      Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
      Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
      '
      'DetailData1
      '
      Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
      Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
      Me.DetailData1.BorderWidth = 2.0!
      Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25!)
      Me.DetailData1.ForeColor = System.Drawing.Color.Black
      Me.DetailData1.Name = "DetailData1"
      Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
      Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
      '
      'DetailData3_Odd
      '
      Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
      Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
      Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.DetailData3_Odd.BorderWidth = 1.0!
      Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25!)
      Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
      Me.DetailData3_Odd.Name = "DetailData3_Odd"
      Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
      Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
      '
      'GrandTotalCaption1
      '
      Me.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.GrandTotalCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
      Me.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer))
      Me.GrandTotalCaption1.Name = "GrandTotalCaption1"
      Me.GrandTotalCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100.0!)
      Me.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
      '
      'GrandTotalData1
      '
      Me.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.GrandTotalData1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
      Me.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
      Me.GrandTotalData1.Name = "GrandTotalData1"
      Me.GrandTotalData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100.0!)
      Me.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
      '
      'GrandTotalBackground1
      '
      Me.GrandTotalBackground1.BackColor = System.Drawing.Color.White
      Me.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
      Me.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
      Me.GrandTotalBackground1.BorderWidth = 2.0!
      Me.GrandTotalBackground1.Name = "GrandTotalBackground1"
      '
      'PageInfo
      '
      Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
      Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
      Me.PageInfo.Name = "PageInfo"
      Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
      '
      'TopMargin
      '
      Me.TopMargin.Name = "TopMargin"
      '
      'BottomMargin
      '
      Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
      Me.BottomMargin.Name = "BottomMargin"
      '
      'pageInfo1
      '
      Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
      Me.pageInfo1.Name = "pageInfo1"
      Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
      Me.pageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
      Me.pageInfo1.StyleName = "PageInfo"
      '
      'pageInfo2
      '
      Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
      Me.pageInfo2.Name = "pageInfo2"
      Me.pageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
      Me.pageInfo2.StyleName = "PageInfo"
      Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
      Me.pageInfo2.TextFormatString = "Page {0} of {1}"
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
      Me.ReportHeader.HeightF = 60.0!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'label1
      '
      Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
      Me.label1.Name = "label1"
      Me.label1.SizeF = New System.Drawing.SizeF(638.0!, 24.19433!)
      Me.label1.StyleName = "Title"
      Me.label1.Text = "data Barang"
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
      Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
      Me.GroupHeader1.HeightF = 28.0!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'table1
      '
      Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
      Me.table1.Name = "table1"
      Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
      Me.table1.SizeF = New System.Drawing.SizeF(650.0!, 28.0!)
      '
      'tableRow1
      '
      Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9})
      Me.tableRow1.Name = "tableRow1"
      Me.tableRow1.Weight = 1.0R
      '
      'tableCell1
      '
      Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.tableCell1.Name = "tableCell1"
      Me.tableCell1.StyleName = "DetailCaption1"
      Me.tableCell1.StylePriority.UseBorders = False
      Me.tableCell1.Text = "Id"
      Me.tableCell1.Weight = 0.041691774221567009R
      '
      'tableCell2
      '
      Me.tableCell2.Name = "tableCell2"
      Me.tableCell2.StyleName = "DetailCaption1"
      Me.tableCell2.Text = "Nama Barang"
      Me.tableCell2.Weight = 0.15111255352313702R
      '
      'tableCell3
      '
      Me.tableCell3.Name = "tableCell3"
      Me.tableCell3.StyleName = "DetailCaption1"
      Me.tableCell3.Text = "Grade"
      Me.tableCell3.Weight = 0.081094014094426084R
      '
      'tableCell4
      '
      Me.tableCell4.Name = "tableCell4"
      Me.tableCell4.StyleName = "DetailCaption1"
      Me.tableCell4.Text = "Kategori"
      Me.tableCell4.Weight = 0.10404900184044472R
      '
      'tableCell5
      '
      Me.tableCell5.Name = "tableCell5"
      Me.tableCell5.StyleName = "DetailCaption1"
      Me.tableCell5.Text = "Satuan"
      Me.tableCell5.Weight = 0.089831912700946509R
      '
      'tableCell6
      '
      Me.tableCell6.Name = "tableCell6"
      Me.tableCell6.StyleName = "DetailCaption1"
      Me.tableCell6.StylePriority.UseTextAlignment = False
      Me.tableCell6.Text = "Harga Beli"
      Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell6.Weight = 0.12157287597656249R
      '
      'tableCell7
      '
      Me.tableCell7.Name = "tableCell7"
      Me.tableCell7.StyleName = "DetailCaption1"
      Me.tableCell7.StylePriority.UseTextAlignment = False
      Me.tableCell7.Text = "Harga Jual"
      Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell7.Weight = 0.12486039381760818R
      '
      'tableCell8
      '
      Me.tableCell8.Name = "tableCell8"
      Me.tableCell8.StyleName = "DetailCaption1"
      Me.tableCell8.StylePriority.UseTextAlignment = False
      Me.tableCell8.Text = "Stock Awal"
      Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell8.Weight = 0.12922454833984376R
      '
      'tableCell9
      '
      Me.tableCell9.Name = "tableCell9"
      Me.tableCell9.StyleName = "DetailCaption1"
      Me.tableCell9.StylePriority.UseTextAlignment = False
      Me.tableCell9.Text = "Stock Minimal"
      Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell9.Weight = 0.15656292255108173R
      '
      'Detail
      '
      Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
      Me.Detail.HeightF = 25.0!
      Me.Detail.Name = "Detail"
      '
      'table2
      '
      Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
      Me.table2.Name = "table2"
      Me.table2.OddStyleName = "DetailData3_Odd"
      Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
      Me.table2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
      '
      'tableRow2
      '
      Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18})
      Me.tableRow2.Name = "tableRow2"
      Me.tableRow2.Weight = 11.5R
      '
      'tableCell10
      '
      Me.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None
      Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Id]")})
      Me.tableCell10.Name = "tableCell10"
      Me.tableCell10.StyleName = "DetailData1"
      Me.tableCell10.StylePriority.UseBorders = False
      Me.tableCell10.Weight = 0.041691774221567009R
      '
      'tableCell11
      '
      Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NamaBarang]")})
      Me.tableCell11.Name = "tableCell11"
      Me.tableCell11.StyleName = "DetailData1"
      Me.tableCell11.Weight = 0.15111255352313702R
      '
      'tableCell12
      '
      Me.tableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Grade]")})
      Me.tableCell12.Name = "tableCell12"
      Me.tableCell12.StyleName = "DetailData1"
      Me.tableCell12.Weight = 0.081094014094426084R
      '
      'tableCell13
      '
      Me.tableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kategori]")})
      Me.tableCell13.Name = "tableCell13"
      Me.tableCell13.StyleName = "DetailData1"
      Me.tableCell13.Weight = 0.10404900184044472R
      '
      'tableCell14
      '
      Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Satuan]")})
      Me.tableCell14.Name = "tableCell14"
      Me.tableCell14.StyleName = "DetailData1"
      Me.tableCell14.Weight = 0.089831912700946509R
      '
      'tableCell15
      '
      Me.tableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HargaBeli]")})
      Me.tableCell15.Name = "tableCell15"
      Me.tableCell15.StyleName = "DetailData1"
      Me.tableCell15.StylePriority.UseTextAlignment = False
      Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell15.TextFormatString = "{0:C2}"
      Me.tableCell15.Weight = 0.12157287597656249R
      '
      'tableCell16
      '
      Me.tableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HargaJual]")})
      Me.tableCell16.Name = "tableCell16"
      Me.tableCell16.StyleName = "DetailData1"
      Me.tableCell16.StylePriority.UseTextAlignment = False
      Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell16.TextFormatString = "{0:C2}"
      Me.tableCell16.Weight = 0.12486039381760818R
      '
      'tableCell17
      '
      Me.tableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StockAwal]")})
      Me.tableCell17.Name = "tableCell17"
      Me.tableCell17.StyleName = "DetailData1"
      Me.tableCell17.StylePriority.UseTextAlignment = False
      Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell17.TextFormatString = "{0:C2}"
      Me.tableCell17.Weight = 0.12922454833984376R
      '
      'tableCell18
      '
      Me.tableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StockMinimal]")})
      Me.tableCell18.Name = "tableCell18"
      Me.tableCell18.StyleName = "DetailData1"
      Me.tableCell18.StylePriority.UseTextAlignment = False
      Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.tableCell18.TextFormatString = "{0:C2}"
      Me.tableCell18.Weight = 0.15656287560096155R
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
      Me.ReportFooter.HeightF = 49.38444!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'panel1
      '
      Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2, Me.label3, Me.label4, Me.label5})
      Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
      Me.panel1.Name = "panel1"
      Me.panel1.SizeF = New System.Drawing.SizeF(650.0!, 49.38444!)
      Me.panel1.StyleName = "GrandTotalBackground1"
      '
      'label2
      '
      Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(304.0565!, 11.5!)
      Me.label2.Name = "label2"
      Me.label2.SizeF = New System.Drawing.SizeF(33.46234!, 14.88444!)
      Me.label2.StyleName = "GrandTotalCaption1"
      Me.label2.Text = "SUM"
      '
      'label3
      '
      Me.label3.CanGrow = False
      Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([HargaBeli])")})
      Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(337.5189!, 11.5!)
      Me.label3.Name = "label3"
      Me.label3.SizeF = New System.Drawing.SizeF(45.56003!, 14.88444!)
      Me.label3.StyleName = "GrandTotalData1"
      Me.label3.StylePriority.UseTextAlignment = False
      XrSummary1.IgnoreNullValues = True
      XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
      Me.label3.Summary = XrSummary1
      Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.label3.TextFormatString = "{0:C2}"
      Me.label3.WordWrap = False
      '
      'label4
      '
      Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(383.0789!, 11.5!)
      Me.label4.Name = "label4"
      Me.label4.SizeF = New System.Drawing.SizeF(33.46234!, 14.88444!)
      Me.label4.StyleName = "GrandTotalCaption1"
      Me.label4.Text = "SUM"
      '
      'label5
      '
      Me.label5.CanGrow = False
      Me.label5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([HargaJual])")})
      Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(416.5412!, 11.5!)
      Me.label5.Name = "label5"
      Me.label5.SizeF = New System.Drawing.SizeF(47.69693!, 14.88444!)
      Me.label5.StyleName = "GrandTotalData1"
      Me.label5.StylePriority.UseTextAlignment = False
      XrSummary2.IgnoreNullValues = True
      XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
      Me.label5.Summary = XrSummary2
      Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
      Me.label5.TextFormatString = "{0:C2}"
      Me.label5.WordWrap = False
      '
      'XtraReport1
      '
      Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.ReportFooter})
      Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
      Me.Font = New System.Drawing.Font("Arial", 9.75!)
      Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.GrandTotalCaption1, Me.GrandTotalData1, Me.GrandTotalBackground1, Me.PageInfo})
      Me.Version = "20.1"
      CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

   Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalBackground1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents panel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
End Class
