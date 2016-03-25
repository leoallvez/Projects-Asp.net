<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp_004_colecao.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Estados</th>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtSigla" runat="server" placeholder="Sigla"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtNome" runat="server" placeholder="Nome" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonAtualizar" runat="server" Text="Enviar" OnClick="ButtonAtualizar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <!--O AutoGenerateColumns tem que estar demarcado na GridVier -->
                    <!--DataFields abaixo referenciam propriedades Nome e Sigla da classe Estado -->
                    <asp:GridView ID="gvEstados" runat="server" class='gridVier' AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Sigla" HeaderText="Sigla" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                 </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
