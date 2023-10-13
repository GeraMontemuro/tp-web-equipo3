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
        public Articulo ArtDetalle = new Articulo(); 
        private List<Articulo> Listanueva;
        public List<Imagen> listaimagen = new List<Imagen>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["auxid"] == null) return;

            string Idaux = Request.QueryString["auxid"];

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Listanueva = articuloNegocio.listar();
            ImagenNegocio imagennegocio = new ImagenNegocio();
            listaimagen= imagennegocio.listar(Idaux);

            foreach (var Articulo in Listanueva)
            {
                if (Articulo.IDArticulo == int.Parse(Idaux))
                {
                    ArtDetalle.Descripcion = Articulo.Descripcion;
                    ArtDetalle.Nombre = Articulo.Nombre;
                    ArtDetalle.Precio = Articulo.Precio;
                }
            }

            TextTitulo.Text = ArtDetalle.Nombre;
            TextPrecio.Text = ArtDetalle.Precio.ToString();
            TextDescripcion.Text = ArtDetalle.Descripcion;

        }

      
    }
}