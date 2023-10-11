using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Tp_WEB_Equipo_3
{
    public partial class Detalle : System.Web.UI.Page
    {
        private List<Articulo> Listanueva;
        private Articulo ArticuloDetalle = new Articulo();

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Listanueva = articuloNegocio.listar();

            if (Request.QueryString["auxid"] == null) return;
            string abc = (String)Request.QueryString["auxid"];
            ;

            foreach (var Articulo in Listanueva)
            {
                if(Articulo.IDArticulo == int.Parse(abc))
                {
                    TextBox1.Text = Articulo.Nombre;
                }
            }

        }
    }
}