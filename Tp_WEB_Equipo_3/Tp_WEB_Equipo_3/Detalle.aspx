<%@ Page Title="Detalle" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Tp_WEB_Equipo_3.Detalle1prueba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>DETALLE DE PRODUCTOS</h1>

     <ItemTemplate>
     <div class="col">
     <div class="card">
         <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
         <div class="card-body">
             <h5 class="card-title"><%#Eval("Nombre") %></h5>
             <p class="card-text"><%#Eval("Descripcion") %></p>
                </div>
    </div>
</ItemTemplate>
   


</asp:Content>
