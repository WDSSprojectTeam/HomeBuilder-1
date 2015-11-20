Imports Microsoft.VisualBasic

Public Class Feature
    Private myOptionList As New List(Of Options)
    Private FeatureName As String
    Private FeatureID As Integer
    Private RoomID As Integer
    Private PreferenceRating As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal name As String, ByVal ID As Integer, ByVal roomID As Integer, ByVal passedOptions As List(Of Options))
        FeatureName = name
        FeatureID = ID
        PreferenceRating = 0
    End Sub

    ReadOnly Property Name As String
        Get
            Return FeatureName
        End Get
    End Property

    ReadOnly Property ID As String
        Get
            Return FeatureName
        End Get
    End Property

    Property Rating As Integer
        Get
            Return PreferenceRating
        End Get

        Set(passedRating As Integer)
            PreferenceRating = passedRating
        End Set
    End Property

    Property OptionList As List(Of Options)
        Get
            Return myOptionList
        End Get

        Set(passedList As List(Of Options))
            myOptionList = passedList
        End Set
    End Property




    Public Sub Addtofeaturelist(ByVal anoption As Options)
        OptionList.Add(anoption)
    End Sub

    Public Function Getfeaturelist() As ArrayList

        Dim allfeatures As New ArrayList
        Dim anoption As Options
        For Each anoption In OptionList
            If (Not allfeatures.Contains(anoption.FeatureID)) Then
                allfeatures.Add(anoption.FeatureID)
            End If
        Next
        Return allfeatures

    End Function


End Class
