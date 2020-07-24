<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FormularioWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dividendo"></asp:Label>
&nbsp;<asp:TextBox ID="tb_Dividendo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Divisor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb_Divisor" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="bt_Calcular" runat="server" OnClick="bt_Calcular_Click" Text="Calcular" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Resultado:"></asp:Label>
&nbsp;<asp:Label ID="LB_Resultado" runat="server"></asp:Label>
    </form>
</body>
</html>
