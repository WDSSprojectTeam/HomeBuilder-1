Imports Microsoft.VisualBasic
Imports Microsoft.SolverFoundation.Services
Imports System.Collections.Generic

Public Class OptimizationResults

    Public Class OptimizationResults

        Private myChoiceList As New List(Of Decision)
        Private myOptionList As New List(Of Options)
        Private myFeatureList As New List(Of Feature)
        Private myFeatures As New List(Of Integer)

        Public Sub New(ByVal choices As List(Of Decision), ByVal options As List(Of Options), ByVal features As List(Of Feature))
            myChoiceList = choices
            myOptionList = options
            myFeatureList = features
        End Sub

        Public Function featureCost(ByVal featureID As Integer) As Integer
            Dim c As Integer = 0
            For i = 0 To myChoiceList.Count - 1
                If myChoiceList.Item(i).ToDouble = 1 And myFeatures(i) = featureID Then
                    c = myOptionList.Item(i).Price
                End If
            Next

            Return c
        End Function

        Public Function StudentsFromDept(ByVal deptID As String) As Integer
            Dim totalStudentsFromThisDept As Integer = 0
            'For i = 0 To myTeamList.Count - 1
            '    totalStudentsFromThisDept += myTeamList.Item(i).StudentsFrom(deptID) * TeamCount(i)
            'Next
            Return totalStudentsFromThisDept
        End Function

    End Class


End Class
