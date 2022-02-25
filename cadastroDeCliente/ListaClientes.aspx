<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="cadastroDeCliente.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Lista de Clientes</h1>

        </div>
    </form>
     <div class="resultado">
            <asp:Panel ID="panelResultado" runat="server" Visible="true">
                <h2>Lista de Clientes</h2>
                <asp:GridView ID="viwResultado" runat="server"></asp:GridView>
            </asp:Panel>
      </div>
</body>
</html>
