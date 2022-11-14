
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub lbtnLogin_Click(sender As Object, e As EventArgs) Handles lbtnLogin.Click
        Response.Redirect("LoginPage.aspx")
    End Sub

    Protected Sub lbtnRegistration_Click(sender As Object, e As EventArgs) Handles lbtnRegistration.Click
        Response.Redirect("RegistrationPage.aspx")
    End Sub

    Protected Sub lbtnHome_Click(sender As Object, e As EventArgs) Handles lbtnHome.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class

