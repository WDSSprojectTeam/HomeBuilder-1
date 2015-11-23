
Partial Class ChooseHome
    Inherits System.Web.UI.Page

    Private myDataLoader As New DataLoader

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Not IsPostBack) Then
            'FillWithAllHomes()
        End If
    End Sub

    Private Sub FillWithAllHomes()
        gvwHome.DataSource = myDataLoader.GetAllHomesTable
        gvwHome.DataBind()
    End Sub

    Protected Sub gvwHome_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwHome.RowCommand
        If (e.CommandName = "TheDetails") Then
            Dim rowIndex As Integer = e.CommandArgument
            ShowHomeDetails(gvwHome.Rows.Item(rowIndex).Cells.Item(2).Text)
        End If

    End Sub

    Private Sub ShowHomeDetails(ByVal ID As Integer)
        dvwDetails.DataSource = myDataLoader.GetHomeDetails(ID)
        dvwDetails.DataBind()
    End Sub



    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'NEED TO SELECT HOME 
        Response.Redirect("FeatureEvaluation1.aspx")
    End Sub

    Private Sub gvwHome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvwHome.SelectedIndexChanged

        Dim modelid As Integer
        modelid = gvwHome.SelectedRow.Cells.Item(2).Text
        btnNext.Enabled = True

        'subtract house price from the budget

    End Sub

End Class
