Public Class clsTbarang


#Region "Declarations"

    Private _id As String
    Private _namaBarang As String
    Private _grade As String
    Private _kategori As String
    Private _satuan As String
    Private _hargaBeli As Decimal
    Private _hargaJual As Decimal
    Private _stockAwal As Decimal
    Private _stockMinimal As Decimal

#End Region

#Region "Properties"

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property NamaBarang As String
        Get
            Return _namaBarang
        End Get
        Set(value As String)
            _namaBarang = value
        End Set
    End Property

    Public Property Grade As String
        Get
            Return _grade
        End Get
        Set(value As String)
            _grade = value
        End Set
    End Property

    Public Property Kategori As String
        Get
            Return _kategori
        End Get
        Set(value As String)
            _kategori = value
        End Set
    End Property

    Public Property Satuan As String
        Get
            Return _satuan
        End Get
        Set(value As String)
            _satuan = value
        End Set
    End Property

    Public Property HargaBeli As Decimal
        Get
            Return _hargaBeli
        End Get
        Set(value As Decimal)
            _hargaBeli = value
        End Set
    End Property

    Public Property HargaJual As Decimal
        Get
            Return _hargaJual
        End Get
        Set(value As Decimal)
            _hargaJual = value
        End Set
    End Property

    Public Property StockAwal As Decimal
        Get
            Return _stockAwal
        End Get
        Set(value As Decimal)
            _stockAwal = value
        End Set
    End Property

    Public Property StockMinimal As Decimal
        Get
            Return _stockMinimal
        End Get
        Set(value As Decimal)
            _stockMinimal = value
        End Set
    End Property


#End Region

#Region "Constructors"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal namaBarang As String, ByVal grade As String, ByVal kategori As String, ByVal satuan As String, ByVal hargaBeli As Decimal, ByVal hargaJual As Decimal, ByVal stockAwal As Decimal, ByVal stockMinimal As Decimal)
        Me.New()
    End Sub

#End Region

End Class
 