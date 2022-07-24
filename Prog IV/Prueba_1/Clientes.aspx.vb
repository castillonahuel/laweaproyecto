Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lClientes.Text = Session("PasoEsto")
    End Sub

    Protected Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Server.Transfer("Default.aspx")
    End Sub
End Class