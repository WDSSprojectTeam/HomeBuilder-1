Imports Microsoft.VisualBasic

Public Class Feature
    Private FeatureList As New List(Of Options)
    Private FeatureName As String
    Private FeatureID As Integer
    Private PreferenceRating As Integer

    'Public Sub New(ByVal name As String, ByVal ID As Integer)
    '    FeatureName = name
    '    FeatureID = ID
    '    PreferenceRating = 0
    'End Sub

    Public Sub Addtofeaturelist(ByVal anoption As Options)
        FeatureList.Add(anoption)
    End Sub

    Public Function Getfeaturelist() As ArrayList

        Dim allfeatures As New ArrayList
        Dim anoption As Options
        For Each anoption In FeatureList
            If (Not allfeatures.Contains(anoption.getoptionfeature)) Then
                allfeatures.Add(anoption.getoptionfeature)
            End If
        Next
        Return allfeatures

    End Function


End Class
