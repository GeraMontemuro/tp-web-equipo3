﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_WEB_Equipo_3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtEmail.Text;
            string password = txtPassword.Text;


            if ((txtEmail.Text != "") && (txtPassword.Text != ""))
            {


                if ((txtEmail.Text == nombre) && (txtPassword.Text == password))
                {
                    //mensaje de bienvenida y carga de pagina con usuario logeado

                }
            }
        }
    }
}
