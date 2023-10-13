<%@ Page Title="" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Tp_WEB_Equipo_3.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle del Producto  </h1>
    <hr />

    <div class="container text-center">
        <div class="row align-items-start">

            <div class="col">
                <div id="carouselExampleIndicators" class="carousel slide">
                    <div class="carousel-indicators">
                        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    </div>
                    <div class="carousel-inner">

                        <%
                            for (int i = 0; i < listaimagen.Count; i++)
                            {
                        %>
                        <div class="carousel-item <%=i ==0? "active":"" %> ">

                            <img src="<%: listaimagen[i].ImagenUrl %>" class="d-block w-100"
                                style="width:auto; height:320px" alt="..." onerror="this.src='Logos/free-fire-png-logo-11569068080w6jocjzwuk.png'"/>
                        </div>
                        <%
                            }%>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>

            <div class="col">

                <div class="card" style="width: auto; max-height: 320px;">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:TextBox ReadOnly="true" ID="TextTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                        </h5>
                        <h6 class="card-subtitle mb-2 text-muted">
                            <asp:TextBox ReadOnly="true" ID="TextPrecio" CssClass="form-control" runat="server"></asp:TextBox>
                        </h6>
                        <p class="card-text">
                            <asp:TextBox ID="TextDescripcion" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                        </p>
                        <div class="button-group">
                            <asp:Button ID="btnAgregarCarrito" CssClass="btn btn-primary" Text="Añadir al carrito" runat="server" OnClick="btnAgregarCarrito_Click" />
                            <asp:Button ID="btnComprar" CssClass="btn btn-success" Text="Comprar" runat="server" OnClick="btnComprar_Click" />
                        </div>
                    </div>
                </div>
        </div>
    </div>
    </div>

</asp:Content>
