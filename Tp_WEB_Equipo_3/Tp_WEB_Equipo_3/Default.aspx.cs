using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace Tp_WEB_Equipo_3
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        // dgvArticulos.DataSource = articuloNegocio.listarconSP();
        //dgvArticulos.DataBind(); 
        ListaArticulo = articuloNegocio.listarconSP();
        }
    }
}