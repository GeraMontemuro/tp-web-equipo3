<%@ Page Title="Home" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_WEB_Equipo_3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ESTE ES EL HOME. LISTA DE ARTICULOS</h1>
   
    

    <div class="row row-cols-1 row-cols-md-3 g-4">

        <asp:Repeater ID="repRepetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %></p>
                        <a href="Detalle.aspx?id=<%#Eval("IdArticulo") %>">Ver Detalle</a>
                        <asp:Button Text="Comprar" CssClass="btn btn-primary" runat="server" id="btnComprar" CommandArgument='<%#Eval("IdArticulo") %>' CommandName="ArtComprado" OnClick="btnComprar_Click" />
                    </div>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
</asp:Content>
