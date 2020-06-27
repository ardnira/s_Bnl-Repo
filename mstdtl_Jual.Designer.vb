<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class mstdtl_Jual
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
        Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mstdtl_Jual))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1Vertical = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1VerticalFirstRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1VerticalLastRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1VerticalRow_Even = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.HeaderData1Vertical = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.HeaderData1VerticalFirstRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.HeaderData1VerticalLastRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.HeaderData1VerticalRow_Even = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalData1Vertical = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalData1VerticalFirstRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalData1VerticalLastRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalData1VerticalRow_Even = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.VerticalTotalDataLastItem = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.VerticalHeader = New DevExpress.XtraReports.UI.VerticalHeaderBand()
        Me.VerticalDetail = New DevExpress.XtraReports.UI.VerticalDetailBand()
        Me.VerticalTotal = New DevExpress.XtraReports.UI.VerticalTotalBand()
        Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table5 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_bnl_Connection"
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
        MsSqlConnectionParameters1.DatabaseName = "bnl"
        MsSqlConnectionParameters1.ServerName = "arza41"
        Me.SqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "Ref"
        Table6.Name = "tJual"
        ColumnExpression1.Table = Table6
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Tanggal"
        ColumnExpression2.Table = Table6
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "IdCustomer"
        ColumnExpression3.Table = Table6
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "NamaCustomer"
        ColumnExpression4.Table = Table6
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "TotalBayar"
        ColumnExpression5.Table = Table6
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Tunai"
        ColumnExpression6.Table = Table6
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Piutang"
        ColumnExpression7.Table = Table6
        Column7.Expression = ColumnExpression7
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Name = "tJual"
        SelectQuery1.Tables.Add(Table6)
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
        'GroupCaption1
        '
        Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupCaption1.BorderColor = System.Drawing.Color.White
        Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupCaption1.BorderWidth = 2.0!
        Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupCaption1.Name = "GroupCaption1"
        Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupData1
        '
        Me.GroupData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupData1.BorderColor = System.Drawing.Color.White
        Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupData1.BorderWidth = 2.0!
        Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupData1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GroupData1.Name = "GroupData1"
        Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        '
        'DetailData1Vertical
        '
        Me.DetailData1Vertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DetailData1Vertical.BorderColor = System.Drawing.Color.White
        Me.DetailData1Vertical.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.DetailData1Vertical.BorderWidth = 2.0!
        Me.DetailData1Vertical.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData1Vertical.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DetailData1Vertical.Name = "DetailData1Vertical"
        Me.DetailData1Vertical.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData1Vertical.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData1VerticalFirstRow
        '
        Me.DetailData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DetailData1VerticalFirstRow.BorderColor = System.Drawing.Color.White
        Me.DetailData1VerticalFirstRow.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.DetailData1VerticalFirstRow.BorderWidth = 2.0!
        Me.DetailData1VerticalFirstRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData1VerticalFirstRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DetailData1VerticalFirstRow.Name = "DetailData1VerticalFirstRow"
        Me.DetailData1VerticalFirstRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData1VerticalLastRow
        '
        Me.DetailData1VerticalLastRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DetailData1VerticalLastRow.BorderColor = System.Drawing.Color.White
        Me.DetailData1VerticalLastRow.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DetailData1VerticalLastRow.BorderWidth = 2.0!
        Me.DetailData1VerticalLastRow.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData1VerticalLastRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DetailData1VerticalLastRow.Name = "DetailData1VerticalLastRow"
        Me.DetailData1VerticalLastRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData1VerticalLastRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData1VerticalRow_Even
        '
        Me.DetailData1VerticalRow_Even.BackColor = System.Drawing.Color.Transparent
        Me.DetailData1VerticalRow_Even.BorderColor = System.Drawing.Color.White
        Me.DetailData1VerticalRow_Even.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.DetailData1VerticalRow_Even.BorderWidth = 2.0!
        Me.DetailData1VerticalRow_Even.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DetailData1VerticalRow_Even.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DetailData1VerticalRow_Even.Name = "DetailData1VerticalRow_Even"
        Me.DetailData1VerticalRow_Even.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData1VerticalRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'HeaderData1Vertical
        '
        Me.HeaderData1Vertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.HeaderData1Vertical.BorderColor = System.Drawing.Color.White
        Me.HeaderData1Vertical.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.HeaderData1Vertical.BorderWidth = 2.0!
        Me.HeaderData1Vertical.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.HeaderData1Vertical.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HeaderData1Vertical.Name = "HeaderData1Vertical"
        Me.HeaderData1Vertical.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.HeaderData1Vertical.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'HeaderData1VerticalFirstRow
        '
        Me.HeaderData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.HeaderData1VerticalFirstRow.BorderColor = System.Drawing.Color.White
        Me.HeaderData1VerticalFirstRow.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.HeaderData1VerticalFirstRow.BorderWidth = 2.0!
        Me.HeaderData1VerticalFirstRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.HeaderData1VerticalFirstRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HeaderData1VerticalFirstRow.Name = "HeaderData1VerticalFirstRow"
        Me.HeaderData1VerticalFirstRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.HeaderData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'HeaderData1VerticalLastRow
        '
        Me.HeaderData1VerticalLastRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.HeaderData1VerticalLastRow.BorderColor = System.Drawing.Color.White
        Me.HeaderData1VerticalLastRow.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.HeaderData1VerticalLastRow.BorderWidth = 2.0!
        Me.HeaderData1VerticalLastRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.HeaderData1VerticalLastRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HeaderData1VerticalLastRow.Name = "HeaderData1VerticalLastRow"
        Me.HeaderData1VerticalLastRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.HeaderData1VerticalLastRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'HeaderData1VerticalRow_Even
        '
        Me.HeaderData1VerticalRow_Even.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HeaderData1VerticalRow_Even.BorderColor = System.Drawing.Color.White
        Me.HeaderData1VerticalRow_Even.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.HeaderData1VerticalRow_Even.BorderWidth = 2.0!
        Me.HeaderData1VerticalRow_Even.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.HeaderData1VerticalRow_Even.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HeaderData1VerticalRow_Even.Name = "HeaderData1VerticalRow_Even"
        Me.HeaderData1VerticalRow_Even.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.HeaderData1VerticalRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalData1Vertical
        '
        Me.TotalData1Vertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TotalData1Vertical.BorderColor = System.Drawing.Color.White
        Me.TotalData1Vertical.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.TotalData1Vertical.BorderWidth = 2.0!
        Me.TotalData1Vertical.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TotalData1Vertical.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TotalData1Vertical.Name = "TotalData1Vertical"
        Me.TotalData1Vertical.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.TotalData1Vertical.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalData1VerticalFirstRow
        '
        Me.TotalData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TotalData1VerticalFirstRow.BorderColor = System.Drawing.Color.White
        Me.TotalData1VerticalFirstRow.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.TotalData1VerticalFirstRow.BorderWidth = 2.0!
        Me.TotalData1VerticalFirstRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TotalData1VerticalFirstRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TotalData1VerticalFirstRow.Name = "TotalData1VerticalFirstRow"
        Me.TotalData1VerticalFirstRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.TotalData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalData1VerticalLastRow
        '
        Me.TotalData1VerticalLastRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TotalData1VerticalLastRow.BorderColor = System.Drawing.Color.White
        Me.TotalData1VerticalLastRow.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.TotalData1VerticalLastRow.BorderWidth = 2.0!
        Me.TotalData1VerticalLastRow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TotalData1VerticalLastRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TotalData1VerticalLastRow.Name = "TotalData1VerticalLastRow"
        Me.TotalData1VerticalLastRow.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.TotalData1VerticalLastRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalData1VerticalRow_Even
        '
        Me.TotalData1VerticalRow_Even.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TotalData1VerticalRow_Even.BorderColor = System.Drawing.Color.White
        Me.TotalData1VerticalRow_Even.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TotalData1VerticalRow_Even.BorderWidth = 2.0!
        Me.TotalData1VerticalRow_Even.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TotalData1VerticalRow_Even.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TotalData1VerticalRow_Even.Name = "TotalData1VerticalRow_Even"
        Me.TotalData1VerticalRow_Even.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.TotalData1VerticalRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'VerticalTotalDataLastItem
        '
        Me.VerticalTotalDataLastItem.BackColor = System.Drawing.Color.Transparent
        Me.VerticalTotalDataLastItem.BorderColor = System.Drawing.Color.White
        Me.VerticalTotalDataLastItem.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.VerticalTotalDataLastItem.BorderWidth = 2.0!
        Me.VerticalTotalDataLastItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VerticalTotalDataLastItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.VerticalTotalDataLastItem.Name = "VerticalTotalDataLastItem"
        Me.VerticalTotalDataLastItem.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 15, 0, 0, 254.0!)
        Me.VerticalTotalDataLastItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 254.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 254.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 152.4!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IdCustomer", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 68.58!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.GroupHeader2.Dpi = 254.0!
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Ref", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 68.58!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'VerticalHeader
        '
        Me.VerticalHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
        Me.VerticalHeader.Dpi = 254.0!
        Me.VerticalHeader.HeightF = 380.6!
        Me.VerticalHeader.Name = "VerticalHeader"
        Me.VerticalHeader.RepeatEveryPage = True
        Me.VerticalHeader.WidthF = 258.4899!
        '
        'VerticalDetail
        '
        Me.VerticalDetail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
        Me.VerticalDetail.Dpi = 254.0!
        Me.VerticalDetail.HeightF = 380.6!
        Me.VerticalDetail.KeepTogether = True
        Me.VerticalDetail.Name = "VerticalDetail"
        Me.VerticalDetail.WidthF = 258.4899!
        '
        'VerticalTotal
        '
        Me.VerticalTotal.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5})
        Me.VerticalTotal.Dpi = 254.0!
        Me.VerticalTotal.HeightF = 380.6!
        Me.VerticalTotal.Name = "VerticalTotal"
        Me.VerticalTotal.WidthF = 1042.458!
        '
        'pageInfo1
        '
        Me.pageInfo1.Dpi = 254.0!
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 16.0!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(764.0!, 58.0!)
        Me.pageInfo1.StyleName = "PageInfo"
        '
        'pageInfo2
        '
        Me.pageInfo2.Dpi = 254.0!
        Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(812.0!, 16.0!)
        Me.pageInfo2.Name = "pageInfo2"
        Me.pageInfo2.SizeF = New System.Drawing.SizeF(764.0!, 58.0!)
        Me.pageInfo2.StyleName = "PageInfo"
        Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.pageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'label1
        '
        Me.label1.Dpi = 254.0!
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 16.0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(223.6168!, 61.45361!)
        Me.label1.StyleName = "Title"
        Me.label1.Text = "Penjualan"
        '
        'table1
        '
        Me.table1.Dpi = 254.0!
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.08!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(1592.0!, 63.5!)
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1.0R
        '
        'tableCell1
        '
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StyleName = "GroupCaption1"
        Me.tableCell1.Text = "ID CUSTOMER"
        Me.tableCell1.Weight = 0.14053338017295952R
        '
        'tableCell2
        '
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdCustomer]")})
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StyleName = "GroupData1"
        Me.tableCell2.Weight = 0.85946662941170693R
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.08!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(382.8543!, 63.5!)
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1.0R
        '
        'tableCell3
        '
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StyleName = "GroupCaption1"
        Me.tableCell3.Text = "REF"
        Me.tableCell3.Weight = 0.049125834326049188R
        '
        'tableCell4
        '
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ref]")})
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StyleName = "GroupData1"
        Me.tableCell4.Weight = 0.19136053381053286R
        '
        'table3
        '
        Me.table3.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.table3.Dpi = 254.0!
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3, Me.tableRow4, Me.tableRow5, Me.tableRow6, Me.tableRow7})
        Me.table3.SizeF = New System.Drawing.SizeF(258.4899!, 355.6!)
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 0.20000000429099799R
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 0.20000000429099799R
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7})
        Me.tableRow5.Dpi = 254.0!
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 0.20000000429099799R
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
        Me.tableRow6.Dpi = 254.0!
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 0.20000000429099799R
        '
        'tableRow7
        '
        Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9})
        Me.tableRow7.Dpi = 254.0!
        Me.tableRow7.Name = "tableRow7"
        Me.tableRow7.Weight = 0.20000000429099799R
        '
        'tableCell5
        '
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StyleName = "HeaderData1VerticalFirstRow"
        Me.tableCell5.Text = "Tanggal"
        Me.tableCell5.Weight = 1.3156464344385208R
        Me.tableCell5.WordWrap = False
        '
        'tableCell6
        '
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StyleName = "HeaderData1VerticalRow_Even"
        Me.tableCell6.Text = "Nama Customer"
        Me.tableCell6.Weight = 1.0R
        Me.tableCell6.WordWrap = False
        '
        'tableCell7
        '
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StyleName = "HeaderData1Vertical"
        Me.tableCell7.Text = "Total Bayar"
        Me.tableCell7.Weight = 2.99591501495013R
        Me.tableCell7.WordWrap = False
        '
        'tableCell8
        '
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StyleName = "HeaderData1VerticalRow_Even"
        Me.tableCell8.Text = "Tunai"
        Me.tableCell8.Weight = 0.77544180904718529R
        Me.tableCell8.WordWrap = False
        '
        'tableCell9
        '
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StyleName = "HeaderData1VerticalLastRow"
        Me.tableCell9.Text = "Piutang"
        Me.tableCell9.Weight = 1.219031670635244R
        Me.tableCell9.WordWrap = False
        '
        'table4
        '
        Me.table4.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.table4.Dpi = 254.0!
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow8, Me.tableRow9, Me.tableRow10, Me.tableRow11, Me.tableRow12})
        Me.table4.SizeF = New System.Drawing.SizeF(258.4899!, 355.6!)
        '
        'tableRow8
        '
        Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell10})
        Me.tableRow8.Dpi = 254.0!
        Me.tableRow8.Name = "tableRow8"
        Me.tableRow8.Weight = 0.20000000429099799R
        '
        'tableRow9
        '
        Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell11})
        Me.tableRow9.Dpi = 254.0!
        Me.tableRow9.Name = "tableRow9"
        Me.tableRow9.Weight = 0.20000000429099799R
        '
        'tableRow10
        '
        Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12})
        Me.tableRow10.Dpi = 254.0!
        Me.tableRow10.Name = "tableRow10"
        Me.tableRow10.Weight = 0.20000000429099799R
        '
        'tableRow11
        '
        Me.tableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13})
        Me.tableRow11.Dpi = 254.0!
        Me.tableRow11.Name = "tableRow11"
        Me.tableRow11.Weight = 0.20000000429099799R
        '
        'tableRow12
        '
        Me.tableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell14})
        Me.tableRow12.Dpi = 254.0!
        Me.tableRow12.Name = "tableRow12"
        Me.tableRow12.Weight = 0.20000000429099799R
        '
        'tableCell10
        '
        Me.tableCell10.CanGrow = False
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tanggal]")})
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StyleName = "DetailData1VerticalFirstRow"
        Me.tableCell10.Weight = 0.42673158565310781R
        Me.tableCell10.WordWrap = False
        '
        'tableCell11
        '
        Me.tableCell11.CanGrow = False
        Me.tableCell11.Dpi = 254.0!
        Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NamaCustomer]")})
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StyleName = "DetailData1VerticalRow_Even"
        Me.tableCell11.Weight = 0.42673158565310781R
        Me.tableCell11.WordWrap = False
        '
        'tableCell12
        '
        Me.tableCell12.CanGrow = False
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalBayar]")})
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StyleName = "DetailData1Vertical"
        Me.tableCell12.StylePriority.UseTextAlignment = False
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell12.TextFormatString = "{0:C2}"
        Me.tableCell12.Weight = 0.42673158565310781R
        Me.tableCell12.WordWrap = False
        '
        'tableCell13
        '
        Me.tableCell13.CanGrow = False
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tunai]")})
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StyleName = "DetailData1VerticalRow_Even"
        Me.tableCell13.StylePriority.UseTextAlignment = False
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.TextFormatString = "{0:C2}"
        Me.tableCell13.Weight = 0.42673158565310781R
        Me.tableCell13.WordWrap = False
        '
        'tableCell14
        '
        Me.tableCell14.CanGrow = False
        Me.tableCell14.Dpi = 254.0!
        Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Piutang]")})
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StyleName = "DetailData1VerticalLastRow"
        Me.tableCell14.StylePriority.UseTextAlignment = False
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell14.TextFormatString = "{0:C2}"
        Me.tableCell14.Weight = 0.42673158565310781R
        Me.tableCell14.WordWrap = False
        '
        'table5
        '
        Me.table5.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.table5.Dpi = 254.0!
        Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(13.22917!, 0!)
        Me.table5.Name = "table5"
        Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow13, Me.tableRow14, Me.tableRow15, Me.tableRow16, Me.tableRow17})
        Me.table5.SizeF = New System.Drawing.SizeF(762.0!, 355.6!)
        '
        'tableRow13
        '
        Me.tableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15})
        Me.tableRow13.Dpi = 254.0!
        Me.tableRow13.Name = "tableRow13"
        Me.tableRow13.Weight = 0.91999952902028048R
        '
        'tableRow14
        '
        Me.tableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16})
        Me.tableRow14.Dpi = 254.0!
        Me.tableRow14.Name = "tableRow14"
        Me.tableRow14.Weight = 0.91999952902028048R
        '
        'tableRow15
        '
        Me.tableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17})
        Me.tableRow15.Dpi = 254.0!
        Me.tableRow15.Name = "tableRow15"
        Me.tableRow15.Weight = 0.91999952902028048R
        '
        'tableRow16
        '
        Me.tableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell18})
        Me.tableRow16.Dpi = 254.0!
        Me.tableRow16.Name = "tableRow16"
        Me.tableRow16.Weight = 0.91999952902028048R
        '
        'tableRow17
        '
        Me.tableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell19})
        Me.tableRow17.Dpi = 254.0!
        Me.tableRow17.Name = "tableRow17"
        Me.tableRow17.Weight = 0.91999952902028048R
        '
        'tableCell15
        '
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StyleName = "TotalData1VerticalFirstRow"
        Me.tableCell15.Weight = 0.5R
        '
        'tableCell16
        '
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StyleName = "TotalData1VerticalRow_Even"
        Me.tableCell16.Weight = 0.5R
        '
        'tableCell17
        '
        Me.tableCell17.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.StyleName = "TotalData1Vertical"
        Me.tableCell17.Weight = 0.5R
        '
        'label2
        '
        Me.label2.CanGrow = False
        Me.label2.Dpi = 254.0!
        Me.label2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalBayar])"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalBayar])")})
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(35.56!, 7.62!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(512.4899!, 55.88!)
        Me.label2.StyleName = "VerticalTotalDataLastItem"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.label2.Summary = XrSummary1
        Me.label2.TextFormatString = "{0:C2}"
        Me.label2.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label3})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StyleName = "TotalData1VerticalRow_Even"
        Me.tableCell18.Weight = 0.5R
        '
        'label3
        '
        Me.label3.CanGrow = False
        Me.label3.Dpi = 254.0!
        Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Tunai])"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Tunai])")})
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(35.56!, 7.62!)
        Me.label3.Name = "label3"
        Me.label3.SizeF = New System.Drawing.SizeF(512.4899!, 55.88!)
        Me.label3.StyleName = "VerticalTotalDataLastItem"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.label3.Summary = XrSummary2
        Me.label3.TextFormatString = "{0:C2}"
        Me.label3.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label4})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.StyleName = "TotalData1VerticalLastRow"
        Me.tableCell19.Weight = 0.5R
        '
        'label4
        '
        Me.label4.CanGrow = False
        Me.label4.Dpi = 254.0!
        Me.label4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Piutang])"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Piutang])")})
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(35.56!, 7.62!)
        Me.label4.Name = "label4"
        Me.label4.SizeF = New System.Drawing.SizeF(512.4899!, 55.88!)
        Me.label4.StyleName = "VerticalTotalDataLastItem"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.label4.Summary = XrSummary3
        Me.label4.TextFormatString = "{0:C2}"
        Me.label4.WordWrap = False
        '
        'mstdtl_Jual
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.VerticalHeader, Me.VerticalDetail, Me.VerticalTotal})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "tJual"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(254, 254, 254, 254)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.PageInfo, Me.DetailData1Vertical, Me.DetailData1VerticalFirstRow, Me.DetailData1VerticalLastRow, Me.DetailData1VerticalRow_Even, Me.HeaderData1Vertical, Me.HeaderData1VerticalFirstRow, Me.HeaderData1VerticalLastRow, Me.HeaderData1VerticalRow_Even, Me.TotalData1Vertical, Me.TotalData1VerticalFirstRow, Me.TotalData1VerticalLastRow, Me.TotalData1VerticalRow_Even, Me.VerticalTotalDataLastItem})
        Me.Version = "20.1"
        Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1Vertical As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1VerticalFirstRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1VerticalLastRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1VerticalRow_Even As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HeaderData1Vertical As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HeaderData1VerticalFirstRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HeaderData1VerticalLastRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents HeaderData1VerticalRow_Even As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalData1Vertical As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalData1VerticalFirstRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalData1VerticalLastRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalData1VerticalRow_Even As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents VerticalTotalDataLastItem As DevExpress.XtraReports.UI.XRControlStyle
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
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents VerticalHeader As DevExpress.XtraReports.UI.VerticalHeaderBand
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents VerticalDetail As DevExpress.XtraReports.UI.VerticalDetailBand
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents VerticalTotal As DevExpress.XtraReports.UI.VerticalTotalBand
    Friend WithEvents table5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
End Class
