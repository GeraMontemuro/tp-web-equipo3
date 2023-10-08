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
                 <label for="txtEmail" class="form-label">Usuario</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
             </div>
             <div class="mb-3">
                 <label for="txtPassword" class="form-label">Contraseña</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword" type="password" />
             </div>
             <div class="mb-3">
                 <label for="Nombre" class="form-label">Nombre</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="TextBox1" type="Nombre" />

             </div>
             <div class="mb-3">
                 <label for="Apellido" class="form-label">Apellido</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="TextBox2" type="Apellido" />
             </div>
             <div class="mb-3">
                <label for="FechaNacimiento" class="form-label">Fecha</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TextBox3" type="date" />
             </div>
             <div class="mb-3">
                 <label for="Numero" class="form-label">Numero</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TextBox4" type="" />
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
