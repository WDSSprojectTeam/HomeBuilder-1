Imports Microsoft.VisualBasic
Imports Microsoft.SolverFoundation.Services

Public Class TeamOptimizer
    ' inputs

    ' model


    Public Sub New()

    End Sub

    Public Sub LoadData(ByVal aDataLoader As DataLoader)

    End Sub

    Public Sub Solve()
        ' creates a Solver and a Model
        Dim mySolverContext As SolverContext = SolverContext.GetContext
        myModel = mySolverContext.CreateModel
        ' Decision variables
        AddDecisions()
        ' Constraints
        AddConstraints()
        ' Objective Function
        AddGoal()
        ' Solve
        mySolverContext.Solve()   ' or specifically    mySolverContext.Solve(New SimplexDirective)
    End Sub

    Private Sub AddDecisions()

    End Sub

    Private Sub AddConstraints()

    End Sub

    Private Sub AddGoal()

    End Sub

    Public Function Results() As OptimizationResults
        Return New OptimizationResults
    End Function
End Class