Imports Microsoft.VisualBasic

Public Class Options
    Private myID As Integer
    Private myName As String
    Private myPrice As Double
    Private myDescription As String
    Private myFeatureID As Integer
    Private myPreferenceRating As Integer
    Private isNeed As Boolean

    Public Sub New(ByVal optid As Integer, ByVal optname As String, ByVal optprice As Double, ByVal optdescription As String, ByVal optfeature As String)

        myID = optid
        myName = optname
        myPrice = optprice
        myDescription = optdescription
        myFeatureID = optfeature
        myPreferenceRating = 0
        isNeed = False

    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return myID
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return myName
        End Get
    End Property

    Public ReadOnly Property Price As Double
        Get
            Return myPrice
        End Get
    End Property

    Public Function CalculateTotalPrice(ByVal squareFeet As Double) As Double
        Dim totalPrice As Double

        'will add something here once we decide how we categorize homes

        Return totalPrice
    End Function

    Public ReadOnly Property Description As String
        Get
            Return myDescription
        End Get
    End Property

    Public ReadOnly Property FeatureID As String
        Get
            Return myFeatureID
        End Get
    End Property

    Public Property Rating As Integer
        Get
            Return myPreferenceRating
        End Get

        Set(passedRating As Integer)
            myPreferenceRating = passedRating
        End Set
    End Property



End Class
