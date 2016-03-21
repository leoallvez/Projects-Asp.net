<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp_002_produto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Produto</title>
    <style>
        form {
            margin: 8% auto auto;
            border: 1px solid gray;
            color: gray;
            font-family: Verdana;
            border-radius: 1%;
            padding: 2%;
            width: 20%;
            min-width: 250px;
        }
        input[type=submit] {
            color: gray;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <thead>
                <th>Cadastro de Produtos: </th>
            </thead>
            <tr>
                <td>
                    <asp:TextBox ID="TxtCodigo"  placeholder="Código" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtNome" placeholder="Nome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtPreco" placeholder="Preço" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonGravar" runat="server" Text="Gravar" OnClick="ButtonGravar_Click" />
                    <asp:Button ID="ButtonLimpar" runat="server" Text="Limpar" OnClick="ButtonLimpar_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
