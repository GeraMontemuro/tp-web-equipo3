<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewLogin.aspx.cs" Inherits="Tp_WEB_Equipo_3.NewLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> </title>
</head>
<body>
    <h2>Nuevo Usuario</h2>
    <form id="form1" runat="server">
         <div class="row">
     <div class="col-2">
         <div class="col">
             <div class="mb-3">
                 <label for="txtEmail1" class="form-label">Usuario</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail1" />
             </div>
             <div class="mb-3">
                 <label for="txtPassword1" class="form-label">Contraseña</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword1" type="password" />
             </div>
             <div class="mb-3">
                 <label for="Nombre1" class="form-label">Nombre</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="Nombre1" type="Nombre" />

             </div>
             <div class="mb-3">
                 <label for="Apellido1" class="form-label">Apellido</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="Apellido1" type="Apellido" />
             </div>
             <div class="mb-3">
                <label for="FechaNacimiento1" class="form-label">Fecha</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="FechaNacimiento1" type="date" />
             </div>
             <div class="mb-3">
                 <label for="Numero1" class="form-label">Numero</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="Numero1" type="" />
             </div>
             <div>
                  <asp:Button Text="Crear Usuario" CssClass="btn btn-primary" ID="btnCrearUsuario" onClick="btnCrearUsuario_Click" runat="server" />
             </div>
             </div>
              </div>
             </div>
            <div>
        </div>
            <div class="col-2">
    </div>

    </form>
</body>
</html>
