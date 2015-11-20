Public Class Home
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        GetData()


    End Sub

    Private Sub GetData()
        If (Not IsPostBack) Then
            Dim myDataLoader As New DataLoader
            myDataLoader.LoadData()
            Session("myData") = myDataLoader

        End If


    End Sub

    Protected Sub btnBuildHome_Click(sender As Object, e As EventArgs) Handles btnBuildHome.Click
        Response.Redirect("~\FeatureEvaluation1.aspx")
    End Sub
End Class