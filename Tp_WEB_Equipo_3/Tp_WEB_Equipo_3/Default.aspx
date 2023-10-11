<%@ Page Title="Home" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_WEB_Equipo_3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ESTE ES EL HOME. LISTA DE ARTICULOS</h1>
   
    
    <hr />
    <div class="row row-cols-1 row-cols-md-3 g-4">

 <asp:Repeater ID="repRepetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                <div class="card" style="width:300px">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" style="width:auto; height:300px" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %></p>
                        <asp:HyperLink ID="lnkDetalleArticulo" runat="server" NavigateUrl='<%# "Detalle.aspx?id=" + Eval("IDArticulo") %>'
                         Text="Ver detalles" />
                       <asp:Button Text="Detalle" CssClass="btn btn-primary" runat="server" id="btnDetalle" CommandArgument='<%#Eval("IdArticulo") %>' CommandName="ArtDetalle" OnClick="btnDetalle_Click" />
                    </div>
                </div>
            </div>
        </ItemTemplate>
        </asp:Repeater>
     



    </div>
</asp:Content>
