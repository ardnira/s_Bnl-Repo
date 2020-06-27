Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI



Partial Public Class fPrint_Bayar
   Dim rp As Print_Bayar
   Dim trns_Ref As String

   Sub Tampil(ref_trans As String)
      trns_Ref = ref_trans
      Me.Show()
      Button1_Click(Nothing, Nothing)
   End Sub

   Sub Detil_Grid()
      Dim xrRowDel As New XRTableRow
      xrRowDel = rp.xTbl.Rows.Item(0)
      rp.xTbl.Rows.Remove(xrRowDel)

      Dim dataTable As DataTable = New DataTable()
      'dataTable.Columns.Add("cNo", GetType(Integer))
      'dataTable.Columns.Add("cTgl", GetType(Date))
      'dataTable.Columns.Add("cKode", GetType(String))
      'dataTable.Columns.Add("cBarang", GetType(String))
      'dataTable.Columns.Add("cGrade", GetType(String))
      'dataTable.Columns.Add("cJml", GetType(Integer))
      'dataTable.Columns.Add("cHarga", GetType(Integer))
      'dataTable.Columns.Add("cBiaya", GetType(Integer))

      Dim qs As String = "select "
      qs &= "0 as no, format(Tanggal,'dd MMM yy')as Tgl ,IdBarang,NamaBarang,Grade,Jumlah,Harga,Total "
      qs &= "from tPembelian where ref ='" & trns_Ref & "' "
      GetRec(dataTable, qs)

      Dim cellWidth As Single() = {
         rp.cNo.WidthF, rp.cTgl.WidthF, rp.cKode.WidthF, rp.cBarang.WidthF,
         rp.cGrade.WidthF, rp.cJml.WidthF, rp.cHarga.WidthF, rp.cBiaya.WidthF}
      Dim t_Align As Single() = {
         rp.cNo.TextAlignment, rp.cTgl.TextAlignment, rp.cKode.TextAlignment, rp.cBarang.TextAlignment,
         rp.cGrade.TextAlignment, rp.cJml.TextAlignment, rp.cHarga.TextAlignment, rp.cBiaya.TextAlignment}
      Dim t_Format As String() = {
         rp.cNo.TextFormatString, rp.cTgl.TextFormatString, rp.cKode.TextFormatString, rp.cBarang.TextFormatString,
         rp.cGrade.TextFormatString, rp.cJml.TextFormatString, rp.cHarga.TextFormatString, rp.cBiaya.TextFormatString}

      rp.xTbl.BeginInit()
      Dim ttl_Byr As Double = 0
      For i As Integer = 0 To dataTable.Rows.Count - 1
         Dim xrRow As New XRTableRow()

         Dim isi As String
         For j As Integer = 0 To 8 - 1
            Dim xRCell As XRTableCell = New XRTableCell()

            isi = dataTable.Rows(i)(j).ToString()
            If j = dataTable.Columns.Count - 1 Then ttl_Byr += Val(isi)
            If t_Format(j) <> "" Then isi = FrMny(isi)
            xRCell.Text = IIf(j = 0, i + 1, isi)

            xRCell.TextAlignment = t_Align(j)
            xRCell.WidthF = cellWidth(j)
            xrRow.Cells.Add(xRCell)
         Next

         rp.xTbl.Rows.Add(xrRow)
      Next
      rp.cTotal.Text = FrMny(ttl_Byr).ToString
      rp.xTbl.EndInit()
   End Sub
   Sub Detil_Grid_2()
      Dim xrRowDel As New XRTableRow
      xrRowDel = rp.xTbl_2.Rows.Item(0)
      rp.xTbl_2.Rows.Remove(xrRowDel)

      Dim dataTable As DataTable = New DataTable()
      'dataTable.Columns.Add("cNo", GetType(Integer))
      'dataTable.Columns.Add("cTgl", GetType(Date))
      'dataTable.Columns.Add("cKode", GetType(String))
      'dataTable.Columns.Add("cBarang", GetType(String))
      'dataTable.Columns.Add("cGrade", GetType(String))
      'dataTable.Columns.Add("cJml", GetType(Integer))
      'dataTable.Columns.Add("cHarga", GetType(Integer))
      'dataTable.Columns.Add("cBiaya", GetType(Integer))

      Dim qs As String = "select "
      qs &= "0 as no, format(Tanggal,'dd MMM yy')as Tgl ,IdBarang,NamaBarang,Grade,Jumlah,Harga,Total "
      qs &= "from tPembelian where ref ='" & trns_Ref & "' "
      GetRec(dataTable, qs)

      Dim cellWidth As Single() = {
         rp.cNo.WidthF, rp.cTgl.WidthF, rp.cKode.WidthF, rp.cBarang.WidthF,
         rp.cGrade.WidthF, rp.cJml.WidthF, rp.cHarga.WidthF, rp.cBiaya.WidthF}
      Dim t_Align As Single() = {
         rp.cNo.TextAlignment, rp.cTgl.TextAlignment, rp.cKode.TextAlignment, rp.cBarang.TextAlignment,
         rp.cGrade.TextAlignment, rp.cJml.TextAlignment, rp.cHarga.TextAlignment, rp.cBiaya.TextAlignment}
      Dim t_Format As String() = {
         rp.cNo.TextFormatString, rp.cTgl.TextFormatString, rp.cKode.TextFormatString, rp.cBarang.TextFormatString,
         rp.cGrade.TextFormatString, rp.cJml.TextFormatString, rp.cHarga.TextFormatString, rp.cBiaya.TextFormatString}

      rp.xTbl_2.BeginInit()
      Dim ttl_Byr As Double = 0
      For i As Integer = 0 To dataTable.Rows.Count - 1
         Dim xrRow As New XRTableRow()

         Dim isi As String
         For j As Integer = 0 To 8 - 1
            Dim xRCell As XRTableCell = New XRTableCell()

            isi = dataTable.Rows(i)(j).ToString()
            If j = dataTable.Columns.Count - 1 Then ttl_Byr += Val(isi)
            If t_Format(j) <> "" Then isi = FrMny(isi)
            xRCell.Text = IIf(j = 0, i + 1, isi)

            xRCell.TextAlignment = t_Align(j)
            xRCell.WidthF = cellWidth(j)
            xrRow.Cells.Add(xRCell)
         Next

         rp.xTbl_2.Rows.Add(xrRow)
      Next
      '  rp.cTotal.Text = FrMny(ttl_Byr).ToString
      rp.xTbl_2.EndInit()
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      'nambahi coba gawe ngetes GITHUP, CUMAN KOMENTER IKI
      rp = New Print_Bayar
      rp.Lref.Text = "Ref: 635345"
      rp.lCust.Text = "nama custku"
      rp.LkasirDate.Text = "Lukman, Selasa 23 Jun 2020"
      Detil_Grid()
      Detil_Grid_2()

      dv.DocumentSource = rp
      rp.CreateDocument()

      '=====ini untuk menampilkan sendiri tanpa form induk================
      'Dim printTool As New ReportPrintTool(rp)
      'printTool.ShowPreview()
      '=====ini untuk menampilkan sendiri tanpa form induk================
   End Sub


End Class


'Sub Detil_Grid()
'   Dim dataTable As DataTable = New DataTable()
'   dataTable.Columns.Add("Field1", GetType(Integer))
'   dataTable.Columns.Add("Field2", GetType(Single))
'   dataTable.Columns.Add("Field3", GetType(String))
'   dataTable.Columns.Add("Field4", GetType(String))
'   dataTable.Columns.Add("Field5", GetType(String))

'   For i As Integer = 1 To Val(tjml.Text)
'      dataTable.Rows.Add(i, i * 1.1, "Field3 " & i, "Field4 " & i, "Field5 " & i)
'   Next
'   Dim cellWidth As Single() = {rp.XrTableCell1.WidthF, rp.XrTableCell2.WidthF,
'         rp.XrTableCell3.WidthF, rp.xrTableCell4.WidthF, rp.xrTableCell5.WidthF}

'   rp.xtbl.BeginInit()
'   tinggi_tbl = 0
'   For i As Integer = 0 To dataTable.Rows.Count - 1
'      Dim xrRow As New XRTableRow()

'      For j As Integer = 0 To 5 - 1
'         Dim xRCell As XRTableCell = New XRTableCell()
'         xRCell.Text = dataTable.Rows(i)(j).ToString()
'         xRCell.WidthF = cellWidth(j)
'         xrRow.Cells.Add(xRCell)
'      Next
'      rp.xtbl.Rows.Add(xrRow)
'      tinggi_tbl = rp.xtbl.Rows.LastRow.TopF
'   Next
'   rp.xtbl.EndInit()
'End Sub