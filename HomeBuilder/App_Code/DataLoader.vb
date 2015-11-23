Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.DataVisualization.Charting

Public Class DataLoader
    Inherits System.Web.UI.Page

    Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
    Private myConnection As OleDbConnection
    Private myCommand As OleDbCommand

    Private myFeatureSet As New List(Of Feature)

    Public Function GetAllHomesTable() As Object
        Throw New NotImplementedException()
    End Function

    Private myReader As OleDbDataReader

    Public Sub LoadData()
        LoadFeatures()
        LoadOptions()
    End Sub

    Public Sub LoadFeatures()

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblFeatures.FeatureID, tblFeatures.Feature, tblFeatures.RoomID From tblFeatures", myConnection)
        Dim myFeatureList As New List(Of Feature)
        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim featureID As Integer = myReader.Item("FeatureID")
                Dim featureName As String = myReader.Item("Feature")
                Dim roomID As Integer = myReader.Item("RoomID")

                Dim myFeature As New Feature(featureName, featureID, roomID, New List(Of Options))
                myFeatureList.Add(myFeature)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            myReader.Close()
            myConnection.Close()
            Session("FeatureSet") = myFeatureList

        End Try


    End Sub

    Public Function GetHomeDetails(iD As Integer) As Object
        Throw New NotImplementedException()
    End Function

    Public Sub LoadOptions()

        Dim aOptionList As New List(Of Options)

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblOptions.FeatureID, tblOptions.UpgradeID, tblOptions.UpgradeName, tblOptions.UpgradePrice, tblOptions.Description
FROM tblOptions GROUP BY tblOptions.FeatureID, tblOptions.UpgradeID, tblOptions.UpgradeName, tblOptions.UpgradePrice, tblOptions.Description", myConnection)

        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim OptionID As Integer = myReader.Item("UpgradeID")
                Dim OptionName As String = myReader.Item("UpgradeName")
                Dim OptionPrice As Double = myReader.Item("UpgradePrice")
                Dim OptionDescription As String = myReader.Item("Description")
                Dim OptionFeature As Integer = myReader.Item("FeatureID")
                aOptionList.Add(New Options(OptionID, OptionName, OptionPrice, OptionDescription, OptionFeature))
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Dim myFeatureList As New List(Of Feature)
            myFeatureList = Session("FeatureSet")
            For Each feat In myFeatureList
                For Each opt In aOptionList
                    If opt.FeatureID = feat.ID Then
                        feat.OptionList = aOptionList
                    End If
                Next
            Next
            myReader.Close()
            myConnection.Close()

        End Try

    End Sub

    Friend Function OptionList() As List(Of Options)
        Throw New NotImplementedException()
    End Function

    Friend Function FeatureList() As List(Of Feature)
        Throw New NotImplementedException()
    End Function
End Class
