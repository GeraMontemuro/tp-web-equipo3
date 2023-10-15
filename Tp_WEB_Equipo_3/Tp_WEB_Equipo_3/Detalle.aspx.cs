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
        public List<Articulo> ListaDeCarga = new List<Articulo>(); 

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
                    ArtDetalle.IDArticulo = Articulo.IDArticulo;
                    ArtDetalle.CodigoArticulo = Articulo.CodigoArticulo;
                    ArtDetalle.Nombre = Articulo.Nombre;
                    ArtDetalle.Descripcion = Articulo.Descripcion;
                    ArtDetalle.Marca = Articulo.Marca;
                    ArtDetalle.Categoria = Articulo.Categoria;
                    ArtDetalle.Precio = Articulo.Precio;
                }
            }

            TextTitulo.Text = ArtDetalle.Nombre;
            string precio = string.Format("{0:C}", ArtDetalle.Precio);
            TextPrecio.Text = precio;
            TextDescripcion.Text = ArtDetalle.Descripcion;
            TextMarca.Text = ArtDetalle.Marca.Descripcion;
            TextCategoria.Text = ArtDetalle.Categoria.Descripcion;

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (Session["listafinal"] != null)
            {
                CarritoNegocio Negocio = new CarritoNegocio();
                List<Articulo> Temporal = (List<Articulo>)Session["listafinal"];
                Temporal.Add(Negocio.Buscar(ArtDetalle.IDArticulo));
                FuncionGlobal.Valor += 1;
                FuncionGlobal.CantidadTotalAsignada(FuncionGlobal.Valor);
                FuncionGlobal.CantidadTotal();
                Response.Redirect("Default.aspx");
                
            }
            else
            {
                CarritoNegocio Negocio = new CarritoNegocio();
                Session.Add("listafinal", (Negocio.Cargar(ArtDetalle.IDArticulo, ListaDeCarga)));
                FuncionGlobal.Valor += 1;
                FuncionGlobal.CantidadTotalAsignada(FuncionGlobal.Valor);
                FuncionGlobal.CantidadTotal();
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            string ID = ArtDetalle.IDArticulo.ToString();
            FuncionGlobal.CantidadTotal();
            Response.Redirect("Carrito.aspx?id=" + ID);
        }
    }
}