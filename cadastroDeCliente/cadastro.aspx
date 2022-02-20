<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="cadastroDeCliente.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de Cliente</title>
    <style>
        .container {
            width: 450px;
            margin: 0 auto;
            padding-bottom: 50px;
        }

        div {
            margin: 10px;
        }

        .sexo {
            display: flex;
            align-items: center;
        }

        .campos {
            padding: 10px;
        }

            .campos input[type="text"] {
                float: right;
                width: 330px;
            }

        input[type="date"] {
            float: right;
            width: 270px;
        }

        .button {
            width: 100px;
            float: right;
        }

            .ok {
                width: 100px;
            }

        .resultado {
            width: 450px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div style="background-color: blue">
                <h1>Cadastro de Cliente</h1>
            </div>
            <div class="campos">
                <asp:Label ID="txtNome" runat="server" Text="Nome">Nome: </asp:Label>
                <input id="txtNome" type="text" />
            </div>
            <div class="sexo">
                <asp:Label ID="txtSexo" runat="server" Text="Sexo">Sexo: </asp:Label>
                <div>
                    <input id="txtSexo" type="radio" name="sexo" value="Masculino" />
                    <span>Masaculino</span>
                </div>
                <div>
                    <input id="txtSexo" type="radio" name="sexo" value="Feminino" />
                    <span>Feminino</span>
                </div>
            </div>
            <div class="campos">
                <asp:Label ID="txtCpf" runat="server" Text="Cpf">CPF: </asp:Label>
                <input id="txtCpf" type="text" />
            </div>
            <div class="campos">
                <asp:Label ID="txtRg" runat="server" Text="Rg">RG: </asp:Label>
                <input id="txtRg" type="text" />
            </div>
            <div class="campos">
                <asp:Label ID="txtDataNascimento" runat="server" Text="DataNascimento">Data de nascimento: </asp:Label>
                <input id="txtDataNascimento" type="date" />
            </div>
            <div class="campos">
                <asp:Label ID="txtEndereco" runat="server" Text="Endereco">Endereço: </asp:Label>
                <input id="txtEndereco" type="text" />
            </div>
            <div class="button">
                <asp:Button class="ok" style="background-color=blue" ID="Button" runat="server" Text="OK" OnClick="Salvar" />
            </div>
        </div>
        <div class="resultado">
            <asp:Panel ID="panelResultado" runat="server">
                <h2>Lista de Clientes</h2>
                <asp:GridView ID="viwResultado" runat="server"></asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
