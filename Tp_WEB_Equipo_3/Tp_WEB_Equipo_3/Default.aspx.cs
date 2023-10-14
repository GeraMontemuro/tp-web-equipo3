using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Web.UI.WebControls;

namespace Tp_WEB_Equipo_3
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ListaArticulo = articuloNegocio.listar();
            List<Articulo> listaFiltrada = new List<Articulo>();

            string bandera = Request.QueryString["bandera"];
           

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }


            if (bandera == "1")
            {
                listaFiltrada = (List<Articulo>)Session["ArticuloFiltrado"];
                bandera = "0";
                if (listaFiltrada != null)
                {
                    repRepetidor.DataSource = listaFiltrada;
                    repRepetidor.DataBind();
                }
            }
                      

        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Response.Redirect("Detalle.aspx?auxid=" + valor );

        }
                
    }
}