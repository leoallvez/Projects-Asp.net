<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp_001.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cliente</title>
    <style>
        form {
            margin: 8% auto auto;
            width: 20%;
            padding: 2%;
            font-family: Verdana;
            background-color: #008B8B;
            color: #FFF;
            border-radius: 2%;
        }
        input {
            border-radius: 3%;
            margin: 1%;
        }
        td {
             padding: 1%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:TextBox ID="TextBoxCpf" runat="server" placeholder="CPF:"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBoxNome" runat="server" placeholder="Nome:"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBoxEndereco" runat="server" placeholder="Endereço:"></asp:TextBox>
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
