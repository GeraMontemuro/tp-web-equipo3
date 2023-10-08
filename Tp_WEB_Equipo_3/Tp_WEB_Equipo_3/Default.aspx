<%@ Page Title="Home" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_WEB_Equipo_3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ESTE ES EL HOME. LISTA DE ARTICULOS</h1>
   
    <!-- <asp:GridView ID="dgvArticulos"  runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />

        </Columns>

    </asp:GridView> -->

    <div class="row row-cols-1 row-cols-md-3 g-4">

        <%
            foreach (dominio.Articulo articulo in ListaArticulo)
            {
        %>

            <div class="col">
                <div class="card">
                    <img src="<%: articulo.UrlImagen %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%: articulo.Nombre %></h5>
                        <p class="card-text"><%: articulo.Descripcion %></p>
                        <a href="Detalle.aspx?id=<%: articulo.IDArticulo %>">Ver Detalle</a>
                    </div>
                </div>
            </div>
        <%  }%>
    </div>
</asp:Content>
