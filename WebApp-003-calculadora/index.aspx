<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp_003_calculadora.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Calculadora Mais ou Menos</th>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtResultado" placeholder="Digite um número" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonMais" runat="server" Text="+" OnClick="ButtonMais_Click" />
                    <asp:Button ID="ButtonMenos" runat="server" Text="-" OnClick="ButtonMenos_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Resultado: "></asp:Label>
                    <asp:Label ID="LabelResulado" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
