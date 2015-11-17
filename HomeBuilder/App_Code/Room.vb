Imports Microsoft.VisualBasic

Public Class Room

    Private RoomList As New List(Of Feature)
    Private RoomName As String
    Private RoomID As Integer
    Private PreferenceRating As Integer

    Public Sub Addtoroomlist(ByVal afeature As Feature)
        RoomList.Add(afeature)
    End Sub
End Class
