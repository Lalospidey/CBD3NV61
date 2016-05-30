<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Number9.Administrador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Bienvenido
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Agregar Evento" 
            onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Consultar Usuarios" 
            onclick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Borrar Evento" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Modificar Evento" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Aceptar" />
    </p>
    <p>
        <asp:GridView ID="panel_principal" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Zona</p>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;Precio<br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    Calle<br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    Colonia<br />
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    Delegacion
    <br />
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    Nombre Recinto<br />
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    Capacidad<br />
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    Nombre Evento<br />
    <asp:TextBox ID="TextBox10" runat="server" TextMode="Date"></asp:TextBox>
    Fecha<br />
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;Vendidos</form>
</body>
</html>
