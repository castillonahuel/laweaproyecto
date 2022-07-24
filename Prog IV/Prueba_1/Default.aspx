<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Prueba_1._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba de Reloj</title>
    <script LANGUAGE = "Javascript">
        var timerID = null;
        var timerCorre = false;
        function stopclock() {
            if (timerCorre)
            clearTimeout(timerID);
            timerCorre = false;
        }

        function MostrarHora() {
            var ahora = new Date();
            var horas = ahora.getHours();
            var minutos = ahora.getMinutes();
            var segundos = ahora.getSeconds();
            var valorHora = "" + ((horas > 12) ? horas -12 :horas)
            if (valorHora == "0") valorHora = 12;
            valorHora += ((minutos < 10) ? ":0": ":") + minutos
            valorHora += ((segundos < 10) ? ":0" : ":") + segundos
            valorHora += (horas >= 12) ? " P.M." : " A.M."
            document.getElementById('Hora').innerText = valorHora;

            timerID = setTimeout("MostrarHora()", 1000);
            timerCorre = true;
        }

        function startclock() {
            stopclock();
            MostrarHora();
        }

    </script>

</head>
<body onLoad = "startclock()">
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Hora" runat="server" Text="Hora"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bClientes" runat="server" Text="Ver Clientes" />
            <br />
            <asp:Button ID="bGoogle" runat="server" Text="GOOGLE" Width="82px" />
            <br />
            <asp:ListBox ID="Lista" runat="server" AutoPostBack="True">
                <asp:ListItem Value="https://www.clarin.com/">Clarin</asp:ListItem>
                <asp:ListItem Value="https://www.lanacion.com.ar/">La Nacion</asp:ListItem>
                <asp:ListItem Selected="True" Value="https://www.infobae.com/">Infobae</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="bPDF" runat="server" style="height: 26px" Text="Clase 3" />
        </div>
    </form>
</body>
</html>
