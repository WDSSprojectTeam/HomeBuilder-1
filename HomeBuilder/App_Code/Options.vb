Imports Microsoft.VisualBasic

Public Class Options
    Private ID As Integer
    Private Name As String
    Private Price As Double
    Private Description As String
    Private Feature As Integer

    Public Sub New(ByVal optid As Integer, ByVal optname As String, ByVal optprice As Double, ByVal optdescription As String, ByVal optfeature As String)

        ID = optid
        Name = optname
        Price = optprice
        Description = optdescription
        Feature = optfeature

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



        Return totalprice
    End Function

    Public ReadOnly Property getoptiondescription As String
        Get
            Return Description
        End Get
    End Property

    Public ReadOnly Property getoptionfeature As String
        Get
            Return Feature
        End Get
    End Property

End Class
