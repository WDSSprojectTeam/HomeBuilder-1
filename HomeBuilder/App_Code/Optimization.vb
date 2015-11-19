Imports Microsoft.VisualBasic
Imports Microsoft.SolverFoundation.Services
Imports System.Collections.Generic

Public Class Optimization
    ' inputs
    Private myFeatureList As List(Of Feature)
    Private myOptionList As List(Of [Option])
    Private myCostList As List(Of Cost)
    Private budget As Integer
    Private featureUtility As List(Of Integer)
    Private optionUtility As List(Of Integer)
    ' model
    Private myModel As Model
    Private myDecisionList As New List(Of Decision)
    Private myFeatures As List(Of Integer)

    Public Sub New(ByVal aCostList As List(Of Cost))
        myCostList = aCostList
    End Sub

    Public Sub LoadData(ByVal aDataLoader As DataLoader)
        myFeatureList = aDataLoader.FeatureList
        myOptionList = aDataLoader.OptionList
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
        Dim i As Integer
        Dim j As Integer
        For i = 0 To myFeatureList.Count - 1
            For j = 0 To myOptionList.Count - 1
                Dim myDecision As New Decision(Domain.Boolean, "X" & i & j)
                myDecisionList.Add(myDecision)

                ' adds Xij decision variables to the model
                myModel.AddDecision(myDecision)
                myFeatures.Add(i)
            Next
        Next
    End Sub

    Private Sub AddConstraints()
        Dim i As Integer
        Dim j As Integer
        ' Sum(Xij) = 1 
        For i = 0 To myFeatureList.Count - 1
            Dim myChoice As Term = 0
            Dim constraintName As String = myFeatureList.Item(i) & "have options"
            For j = 0 To myOptionList.Count - 1
                Dim optionInfeature As Decision = myDecisionList.Item(j + i)
                myChoice += optionInfeature
            Next
            myModel.AddConstraint(constraintName, myChoice = 1)
        Next

        ' SumSum(CijXij) <= B
        Dim myFeatureCost As Term = 0
        For i = 0 To myFeatureList.Count - 1
            Dim myOptionCost As Term = 0
            For j = 0 To myOptionList.Count - 1
                Dim aCost As Cost = myCostList.Item(j)
                Dim myCost As Integer = aCost.CostFrom(myOptionList.Item(i))
                Dim aX As Decision = myDecisionList.Item(j + i)
                myOptionCost += myCost * aX
            Next
            myFeatureCost += myOptionCost
            myModel.AddConstraint("", myFeatureCost <= budget)
        Next
    End Sub

    Private Sub AddGoal()
        Dim i As Integer
        Dim j As Integer
        Dim myObj1 As Term = 0
        Dim myObj2 As Term = 0
        Dim myObj3 As Term = 0
        ' objectives 1st max sumsum UiUjXij
        For i = 0 To myFeatureList.Count - 1
            For j = 0 To myOptionList.Count - 1
                myObj1 += featureUtility.Item(i) * optionUtility.Item(j) * myDecisionList.Item(i + j)
            Next
        Next
        myModel.AddGoal("MaximizeUtility", GoalKind.Maximize, myObj1)

        ' objectives 2nd min sumsum CijXij
        For i = 0 To myFeatureList.Count - 1
            For j = 0 To myOptionList.Count - 1
                Dim aCost As Cost = myCostList.Item(j)
                Dim myCost As Integer = aCost.CostFrom(myOptionList.Item(i))
                Dim aX As Decision = myDecisionList.Item(j + i)
                myObj2 += myCost * aX
            Next
        Next
        myModel.AddGoal("MinimizeCost", GoalKind.Minimize, myObj2)

        ' objectives 3th max sumsum UiUjXij/Cij
        For i = 0 To myFeatureList.Count - 1
            For j = 0 To myOptionList.Count - 1
                Dim aCost As Cost = myCostList.Item(j)
                Dim myCost As Integer = aCost.CostFrom(myOptionList.Item(i))
                Dim aX As Decision = myDecisionList.Item(j + i)
                myObj3 += featureUtility.Item(i) * optionUtility.Item(j) * aX / myCost
            Next
        Next
        myModel.AddGoal("MaximizeValue", GoalKind.Maximize, myObj3)
    End Sub

    'Public Function Results() As OptimizationResults
    '    Return New OptimizationResults
    'End Function
End Class