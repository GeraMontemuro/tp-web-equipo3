<%@ Page Title="" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_WEB_Equipo_3.Compra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>RESUMEN DE COMPRA</h1>
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    
    <asp:GridView ID="dgvCarrito"  runat="server" CssClass="table" DataKeyNames="IDArticulo" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
            <asp:CommandField ShowSelectButton="true" SelectText="Eliminar Producto" HeaderText="Acción" /> 

        </Columns>

    </asp:GridView> 



</asp:Content>
