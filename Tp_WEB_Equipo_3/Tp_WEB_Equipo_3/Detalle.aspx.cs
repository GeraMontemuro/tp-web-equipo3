using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_WEB_Equipo_3
{
    public partial class Detalle1prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int idArticulo = Convert.ToInt32(Request.QueryString["id"]);
                    // Aquí debes escribir código para cargar la información completa del artículo
                    // basándote en el idArticulo. Puedes utilizar una consulta a una base de datos
                    // u otra fuente de datos para obtener los detalles del artículo.

                    // Luego, puedes mostrar la información en controles de la página, como Label o TextBox.
                    // Por ejemplo:
                    lblTitulo.Text = "Título del artículo";
                    lblDescripcion.Text = "Descripción del artículo";
                    // ... y así sucesivamente.
                }
                else
                {
                    // Manejar el caso en el que no se proporciona un ID válido en la URL.
                }
            }

        }
    }
}