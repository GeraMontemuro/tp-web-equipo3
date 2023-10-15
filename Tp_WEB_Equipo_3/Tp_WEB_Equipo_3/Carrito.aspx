<%@ Page Title="" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_WEB_Equipo_3.Compra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style >        body {
            color:aquamarine;
        } </style>
    <h1>RESUMEN DE COMPRA</h1>
   
    
    <asp:GridView ID="dgvCarrito"  runat="server" CssClass="table" DataKeyNames="IDArticulo" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
            <asp:BoundField headerText="Precio" DataField="Precio" DataFormatString="{0:C}" />
            <asp:CommandField ShowSelectButton="true" SelectText="Eliminar Producto" HeaderText="Acción" /> 

        </Columns>
    </asp:GridView> 

          <asp:Label ID="lblPrecio" runat="server" Text="Precio Total: " FontColor="white"></asp:Label>
     <asp:TextBox ID="TextPrecioTotal" ReadOnly="true" CssClass="form-control" runat="server" style="width: 150px; height:45px" alt="..." ></asp:TextBox>


</asp:Content>
