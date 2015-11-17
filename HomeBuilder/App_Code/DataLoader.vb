Imports Microsoft.VisualBasic

Public Class DataLoader
    Private myFeatureList As New List(Of String)
    Private myOptionList As New List(Of String)

    Public Sub Load()
        myFeatureList = LoadFeatureList()
        myOptionList = LoadOptionList()
    End Sub

    Private Function LoadFeatureList() As List(Of String)

    End Function

    Private Function LoadOptionList() As List(Of String)

    End Function

    Public ReadOnly Property FeatureList As List(Of String)
        Get
            Return myFeatureList
        End Get
    End Property

    Public ReadOnly Property OptionList As List(Of String)
        Get
            Return myOptionList
        End Get
    End Property
End Class
