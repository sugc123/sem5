
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUserName.Text.Equals("admin") And txtPass.Text.Equals("1234")) Then
            MsgBox("Login SucessFully")
            Response.Redirect("Home.aspx")
        Else
            MsgBox("Invalid Username Or Password")
        End If

    End Sub
End Class
