<%@ Page Title="Home" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_WEB_Equipo_3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> "LISTA DE ARTICULOS"   </h1>
   
    <div class="container text-left">
        <div class="row align-items-start" >
            <div class="col-1" id="left">
              <%--  <div id="sidebar">
                    <a href="#">Inicio</a>
                    <a href="#">Productos</a>
                    <a href="#marcas">Marcas</a>
                    <a href="#categorias">Categorías</a>
                </div>--%>
            </div>
            <div class="col-10">
                <div class="row row-cols-1 row-cols-md-3 g-4">
                    <asp:Repeater ID="repRepetidor" runat="server">

                        <ItemTemplate>

                            <div class="col" width:1200>
                                <div class="card" style="width: 300px">
                                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" style="width: auto; height: 300px" alt="..." onerror="this.src='Logos/error.jpg'" />
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                        <p class="card-text"><%#Eval("Descripcion") %></p>
                                        <asp:Button Text="Detalle" CssClass="btn btn-primary" runat="server" ID="btnDetalle" CommandArgument='<%#Eval("IdArticulo") %>' CommandName="ArtDetalle" OnClick="btnDetalle_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>

        </div>
    </div>
    <hr />
</asp:Content>
