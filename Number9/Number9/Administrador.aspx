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
        <asp:Button ID="Button2" runat="server" Text="Consultar Evento" />
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="id_evento" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id_evento" HeaderText="id_evento" ReadOnly="True" 
                    SortExpression="id_evento" />
                <asp:BoundField DataField="nombre_evento" HeaderText="nombre_evento" 
                    SortExpression="nombre_evento" />
                <asp:BoundField DataField="id_recinto" HeaderText="id_recinto" 
                    SortExpression="id_recinto" />
                <asp:BoundField DataField="id_precios" HeaderText="id_precios" 
                    SortExpression="id_precios" />
                <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                <asp:BoundField DataField="vendidos" HeaderText="vendidos" 
                    SortExpression="vendidos" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Numero9ConnectionString %>" 
            SelectCommand="SELECT * FROM [evento]"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
