Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hora.Text = DateTime.Now.ToString("HH:mm:ss tt")
        Label1.Text = VNum(TextBox1.Text)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Hora.Text = DateTime.Now.ToString("HH:mm:ss") & " Esta es la hora del Page Load"
        End If
    End Sub

    Function VNum(ByVal NTexto As String) As Decimal

        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function

    Protected Sub bGoogle_Click(sender As Object, e As EventArgs) Handles bGoogle.Click
        Response.Redirect("https://www.google.com/")
    End Sub

    Protected Sub Lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista.SelectedIndexChanged
        Label1.Text = Lista.SelectedItem.Text
        Response.Redirect(Lista.SelectedValue)
    End Sub

    Protected Sub bPDF_Click(sender As Object, e As EventArgs) Handles bPDF.Click
        Dim nombrePDF As String = "pdfs/Programacion IV - Clase 3.pdf"
        Response.Clear()
        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-disposition", "attachment; filename=" & nombrePDF)
        Response.Redirect(nombrePDF)
        Response.Flush()
        Response.Close()
    End Sub

    Protected Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Session("PasoEsto") = TextBox1.Text.Trim
        Server.Transfer("Clientes.aspx")
    End Sub
End Class