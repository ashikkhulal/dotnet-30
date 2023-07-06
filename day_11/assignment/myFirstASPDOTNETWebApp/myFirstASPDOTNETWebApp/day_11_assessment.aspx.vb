Public Class day_11_assessment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs)
        Server.TransferRequest("ThankYouPage.aspx")
    End Sub
End Class