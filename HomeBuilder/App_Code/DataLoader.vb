Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb

Public Class DataLoader

    Inherits System.Web.UI.Page

    Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
    Private myConnection As OleDbConnection
    Private myCommand As OleDbCommand
    Private myReader As OleDbDataReader

    Public Sub LoadOptions()

        Dim afeaturelist As New Feature

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
                afeaturelist.Addtofeaturelist(New Options(OptionID, OptionName, OptionPrice, OptionDescription, OptionFeature))
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
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
