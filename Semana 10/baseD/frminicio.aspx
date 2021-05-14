<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frminicio.aspx.cs" Inherits="baseD.frminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonCargaDatos" runat="server" Height="28px" OnClick="ButtonCargaDatos_Click" Text="Cargar Datos a DB" Width="140px" />
            <br />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="SQL"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="105px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarid" runat="server" OnClick="ButtonBuscarid_Click" Text="Buscar ID" Width="78px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Width="359px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="252px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarnombre" runat="server" OnClick="ButtonBuscarnombre_Click" Text="Buscar Nombre" Width="108px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="MYSQL"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Width="98px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarid2" runat="server" OnClick="ButtonBuscarid2_Click" Text="Buscar ID" Width="78px" />
        </p>
        <asp:TextBox ID="TextBox6" runat="server" Width="356px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" Width="246px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarnombre2" runat="server" OnClick="ButtonBuscarnombre2_Click" Text="Buscar Nombre" Width="108px" />
        </p>
        <asp:TextBox ID="TextBox8" runat="server" Width="150px"></asp:TextBox>
    </form>
</body>
</html>
