Imports C1.Win.C1FlexGrid.Classic
Imports Newtonsoft.Json.Linq
Public Class fUpdate
    Dim g As C1FlexGridClassic
    Dim nama_form As String
    Dim Add_Edit_Del As String

    Private Sub fUpdate_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown, Ljudul.MouseDown, pnl_proses.MouseDown

        GeserForm(Me)
    End Sub
    Function Tampil(frm As Form, gx As C1FlexGridClassic, AddEditDel As String) As DialogResult
        Add_Edit_Del = AddEditDel
        g = gx
        nama_form = frm.Name
        Return Me.ShowDialog
    End Function

    Private Sub fUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bt_Ok.Text = Add_Edit_Del
        SelectPropertyGridItem(pg, g.get_ColKey(g.Col))
        SendKeys.Send("{tab}")
        pg.Focus()
    End Sub
    Public Function FindPropertyGridItem(ByVal property_grid As _
    PropertyGrid, ByVal item_label As String) As GridItem
        ' Find the GridItem root.
        Dim root As GridItem
        root = property_grid.SelectedGridItem
        Do Until root.Parent Is Nothing
            root = root.Parent
        Loop

        ' Search the tree.
        Dim nodes As New Collection
        nodes.Add(root)
        Do Until nodes.Count = 0
            Dim test_node As GridItem = DirectCast(nodes(1),
            GridItem)
            nodes.Remove(1)
            If test_node.Label = item_label Then Return _
            test_node

            For Each obj As Object In test_node.GridItems
                nodes.Add(obj)
            Next obj
        Loop

        Return Nothing
    End Function
    Public Sub SelectPropertyGridItem(ByVal property_grid As _
    PropertyGrid, ByVal item_label As String)
        property_grid.SelectedGridItem =
        FindPropertyGridItem(property_grid, item_label)
    End Sub

    Private Function GetImageFromByteArray(picData As Byte()) As Image
        If (picData) Is Nothing Then Return Nothing

        Dim bmData As Integer = If((picData(0) = 21 AndAlso picData(1) = 28), 78, 0)
        Dim img As Image = Nothing
        Try
            Dim ms As New System.IO.MemoryStream(picData, bmData, picData.Length - bmData)
            img = Image.FromStream(ms)
        Catch
        End Try
        Return img
    End Function
    Private Sub fUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetPosisiForm(Me, nama_form)
        With pg
            .SelectedObject = pg.Item : .Item.Clear()

            For i As Integer = 0 To g.Cols - 1
                If g.get_ColKey(i).ToString.ToUpper = "FOTO" Then
                    pct_foto.BackgroundImage = GetImageFromByteArray(TryCast(g(g.Row, g.get_ColIndex("Foto")), [Byte]()))
                    pct_foto.BackgroundImageLayout = ImageLayout.Zoom
                    pct_foto.Refresh()
                Else
                    .Item.Add(g.get_ColKey(i).ToString, g(g.Row, i),
                          IIf(i = 0, True, False),
                          nama_form, 'kategori
                          g.get_ColKey(i).ToString.Replace("_", " ")) 'description

                    If Add_Edit_Del = "Add" Then
                        .Item.Item(i).Value = IIf(IsNumeric(g(g.Row, i)), Nothing, "")
                    End If
                End If
            Next

            .Refresh()



            Exit Sub

            .Item.Add("My String", "My Value", False,
                      "Simple type",   'kategori
                      "This is a string", True)
            .Item.Add("My Integer", 100, False,
                      "Simple type",  'kategori
                      "This is an integer", True)
            .Item.Add("My Double", 10.4, False,
                      "Simple type",  'kategori
                      "This is a double", True)
            .Item.Add("My Font", New Font("Arial", 9), False,
                      "Classes",   'kategori
                      "This is a font class", True)
            .Item.Add("My Color", New Color(), False,
                      "Classes",   'kategori
                      "This is a color class", True)
            .Item.Add("My Point", New Point(10, 10), False,
                      "Classes",   'kategori
                      "This is point class", True)

            .Refresh()
        End With
    End Sub

    Private Sub bt_Ok_Click(sender As Object, e As EventArgs) Handles bt_Ok.Click
        Dim jAry As New JArray : Dim isi As String

        For i As Int16 = 0 To pg.Item.Count - 1
            ' Console.WriteLine(.Item(i).Name & "   =   " & .Item(i).Value.ToString)
            'Me.Tag += .Item(i).Name & "=" & .Item(i).Value.ToString

            isi = IIf(IsNothing(pg.Item(i).Value), Nothing, pg.Item(i).Value.ToString)

            If Not IsNumeric(isi) Then
                If IsNothing(isi) Then
                    isi = "Null"
                Else
                    isi = "'" & isi.ToString.Replace("'", "`") & "'"
                End If
            End If

            jAry.Add(pg.Item(i).Name & "=" & isi)
        Next

        Me.Tag = jAry.ToString
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub bt_Cancel_Click(sender As Object, e As EventArgs) Handles bt_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub fUpdate_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        SetPosisiForm(Me, nama_form)
    End Sub

End Class