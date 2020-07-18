Option Strict On

Public Class CarClass

#Region "Properties"
    Shared Count As Integer = 0
    Private IdentificationNumber As Integer
    Private Make As String = String.Empty
    Private Model As String = String.Empty
    'Private Year As Integer = 0
    Private Year As String = String.Empty
    'Private Price As Decimal = 0
    Private Price As String = String.Empty
    Private NewStatus As Boolean = False
#End Region

#Region "Constructors"

    Public Sub New()
        IdentificationNumber = Count
        Count += 1
    End Sub

    Public Sub New(Make As String, Model As String, Year As String, Price As String, NewStatus As Boolean)
        'Public Sub New(Make As String, Model As String, Year As Integer, Price As Decimal, NewStatus As Boolean, IdentificationNumber As Integer)

        IdentificationNumber = Count
        Count += 1
        Me.CarMake = Make
        Me.CarModel = Model
        Me.CarYear = Year
        Me.CarPrice = Price
        Me.CarStatus = NewStatus
    End Sub

#End Region

#Region "Property Methods"

    Public ReadOnly Property CarCount() As Integer
        Get
            Return Count
        End Get
    End Property

    Public ReadOnly Property CarIdentification() As Integer
        Get
            Return IdentificationNumber
        End Get
    End Property

    Public Property CarMake() As String
        Get
            Return Make
        End Get
        Set(value As String)
            Make = value
        End Set
    End Property

    Public Property CarModel() As String
        Get
            Return Model
        End Get
        Set(value As String)
            Model = value
        End Set
    End Property

    Public Property CarYear() As String
        Get
            Return Year
        End Get
        Set(value As String)
            Year = value
        End Set
    End Property

    Public Property CarPrice() As String
        Get
            Return Price
        End Get
        Set(value As String)
            Price = value
        End Set
    End Property

    Public Property CarStatus() As Boolean
        Get
            Return NewStatus
        End Get
        Set(value As Boolean)
            NewStatus = value
        End Set
    End Property

#End Region

#Region "Methods"
    Public Function GetCarData() As String
        Return "The car make is " & Make & ", the car model is " & Model & ", the car year is " & Year & ", the car price is " & Price & ", and the car status is " & NewStatus
    End Function
#End Region

End Class
