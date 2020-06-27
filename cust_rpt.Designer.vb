<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class cust_rpt
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.lbl1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.label_akhir = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lb_dtl2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lb_dtl1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xtbl = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        CType(Me.xtbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl1})
        Me.TopMargin.HeightF = 57.29167!
        Me.TopMargin.Name = "TopMargin"
        '
        'lbl1
        '
        Me.lbl1.LocationFloat = New DevExpress.Utils.PointFloat(26.04167!, 10.00001!)
        Me.lbl1.Multiline = True
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl1.Text = "lbl1"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 55.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 11, 10, 100.0!)
        '
        'label_akhir
        '
        Me.label_akhir.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.label_akhir.Multiline = True
        Me.label_akhir.Name = "label_akhir"
        Me.label_akhir.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label_akhir.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.label_akhir.Text = "label_akhir"
        '
        'Detail
        '
        Me.Detail.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Detail.BorderWidth = 0!
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lb_dtl2, Me.lb_dtl1, Me.xtbl})
        Me.Detail.DrillDownExpanded = False
        Me.Detail.HeightF = 71.04169!
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.LockedInUserDesigner = True
        Me.Detail.MultiColumn.ColumnCount = 3
        Me.Detail.MultiColumn.ColumnSpacing = 4.0!
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("no", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("nama", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("jumlah", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StylePriority.UseBorderDashStyle = False
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.StylePriority.UseBorderWidth = False
        '
        'lb_dtl2
        '
        Me.lb_dtl2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 48.04169!)
        Me.lb_dtl2.Multiline = True
        Me.lb_dtl2.Name = "lb_dtl2"
        Me.lb_dtl2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lb_dtl2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lb_dtl2.Text = "XrLabel1"
        '
        'lb_dtl1
        '
        Me.lb_dtl1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.lb_dtl1.Multiline = True
        Me.lb_dtl1.Name = "lb_dtl1"
        Me.lb_dtl1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lb_dtl1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lb_dtl1.Text = "lb_dtl1"
        '
        'xtbl
        '
        Me.xtbl.LocationFloat = New DevExpress.Utils.PointFloat(127.0833!, 7.291667!)
        Me.xtbl.Name = "xtbl"
        Me.xtbl.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xtbl.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.xtbl.SizeF = New System.Drawing.SizeF(558.3334!, 36.45833!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 0.41666665213448661R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Id"
        Me.XrTableCell1.Weight = 0.67981826301062664R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Nama"
        Me.XrTableCell2.Weight = 0.7607478183589329R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "APa"
        Me.XrTableCell3.Weight = 0.719524786283467R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Saja"
        Me.XrTableCell4.Weight = 0.78424716669108R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Boleh"
        Me.XrTableCell5.Weight = 0.85131422014919012R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label_akhir})
        Me.ReportFooter.Name = "ReportFooter"
        '
        'cust_rpt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportFooter})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(59, 100, 57, 55)
        Me.Version = "20.1"
        CType(Me.xtbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents lbl1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xtbl As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lb_dtl2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lb_dtl1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label_akhir As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
