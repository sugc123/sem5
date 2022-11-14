Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ASP.net\Project_Product\App_Data\Database.mdf;Integrated Security=True"
    Dim cmdstr As String
    Dim adp As New SqlDataAdapter
    Dim ds As DataSet
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlInsert.Visible = False
        pnlUpdate.Visible = False
        pnlDelete.Visible = False
        fillgrid()
    End Sub

    Protected Sub btnInsertPanel_Click(sender As Object, e As EventArgs) Handles btnInsertPanel.Click
        pnlInsert.Visible = True
    End Sub

    Protected Sub btnUpdatePanel_Click(sender As Object, e As EventArgs) Handles btnUpdatePanel.Click
        pnlUpdate.Visible = True
    End Sub

    

    Protected Sub btnDeletePanel_Click(sender As Object, e As EventArgs) Handles btnDeletePanel.Click
        pnlDelete.Visible = True
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            con = New SqlConnection(constr)
            con.Open()
            cmdstr = "insert into product values ( " & txtInsertId.Text & ",'" & txtInsertname.Text & "','" & txtInsertPprice.Text & "','" & calenderInsert.SelectedDate & "','" & txtInsertQuantity.Text & "','" & txtInsertQuality.Text & "')"
            cmd = New SqlCommand(cmdstr, con)
            cmd.ExecuteNonQuery()
            fillgrid()
            con.Close()
            MsgBox("Product Inserted Sucessfully!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = New SqlConnection(constr)
            con.Open()
            cmdstr = "Update product set pname='" & txtUpdateId.Text & "', pprice='" & txtUpdateprice.Text & "', date ='" & calenderUpdate.SelectedDate & "',quantity='" & txtUpdateQuantity.Text & "',quality='" & txtUpdateQuality.Text & "' where id=" & txtUpdateId.Text & ""
            cmd = New SqlCommand(cmdstr, con)
            cmd.ExecuteNonQuery()
            fillgrid()
            con.Close()
            MsgBox("Product updated Sucessfully!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con = New SqlConnection(constr)
            con.Open()
            cmdstr = "Delete from product where id = " & txtdeleteId.Text & ""
            cmd = New SqlCommand(cmdstr, con)
            cmd.ExecuteNonQuery()
            fillgrid()
            con.Close()
            MsgBox("Product deleted Sucessfully!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Sub fillgrid()
        Try
            con = New SqlConnection(constr)
            con.Open()
            cmdstr = "select * from product"
            cmd = New SqlCommand(cmdstr, con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet
            adp.Fill(ds, "product")
            GridView1.DataSource = ds.Tables("product")
            GridView1.DataBind()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Product Inserted Sucessfully!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class
