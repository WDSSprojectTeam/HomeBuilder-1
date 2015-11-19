Imports Microsoft.VisualBasic

Public Class Options
    Private ID As Integer
    Private Name As String
    Private Price As Double
    Private Description As String
    Private FeatureID As Integer
    Private PreferenceRating As Integer
    Private Need As Boolean

    Public Sub New(ByVal optid As Integer, ByVal optname As String, ByVal optprice As Double, ByVal optdescription As String, ByVal optfeature As String)

        ID = optid
        Name = optname
        Price = optprice
        Description = optdescription
        FeatureID = optfeature
        PreferenceRating = 0
        Need = False

    End Sub

    Public ReadOnly Property getoptionID As Integer
        Get
            Return ID
        End Get
    End Property

    Public ReadOnly Property getoptionname As String
        Get
            Return Name
        End Get
    End Property

    Public ReadOnly Property getoptionprice As Double
        Get
            Return Price
        End Get
    End Property

    Public Function CalculateTotalPrice(ByVal squarefeet As Double) As Double
        Dim totalprice As Double

        'will add something here once we decide how we categorize homes

        Return totalprice
    End Function

    Public ReadOnly Property getoptiondescription As String
        Get
            Return Description
        End Get
    End Property

    Public ReadOnly Property getoptionfeature As String
        Get
            Return FeatureID
        End Get
    End Property

    Public Property Rating As Integer
        Get
            Return PreferenceRating
        End Get

        Set(passedRating As Integer)
            PreferenceRating = passedRating
        End Set
    End Property



End Class
