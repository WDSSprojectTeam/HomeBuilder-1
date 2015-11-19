Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.datavisualization.Charting

Public Class DataLoader
    Inherits System.Web.UI.Page

    Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
    Private myConnection As OleDbConnection
    Private myCommand As OleDbCommand
    Private myReader As OleDbDataReader

    Public Sub LoadFeatures()
        'Dim aOptionList As New List(Of Options)

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblFeatures.FeatureID, tblFeatures.Feature, tblFeatures.RoomID From tblFeatures", myConnection)

        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim featureID As Integer = myReader.Item("UpgradeID")
                Dim featureName As String = myReader.Item("Feature")
                Dim roomID As Integer = myReader.Item("RoomID")

                Dim myFeature As New Feature(featureName, featureID, roomID, New List(Of Options))
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            myReader.Close()
            myConnection.Close()

        End Try


    End Sub

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
                    If opt.getoptionfeature = feat.ID Then
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
