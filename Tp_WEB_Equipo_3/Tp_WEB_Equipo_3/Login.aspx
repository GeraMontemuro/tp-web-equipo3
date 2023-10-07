﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Mspage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tp_WEB_Equipo_3.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2">
            <div class="col">
                <div class="mb-3">
                    <label for="txtEmail" class="form-label">Email address</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
                </div>
                <div class="mb-3">
                    <label for="txtPassword" class="form-label">Password</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword" type="password" />
                </div>
                
               
                <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnAceptar" onClick="btnAceptar_Click" runat="server" />
            </div>
        </div>
    </div>

    <div class="col-2">
    </div>
    </div>

</asp:Content>
