using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_WEB_Equipo_3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public List<Articulo> ListaFiltro { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            /* traer la lista de articulos 
             * aplicar al dropdownlist todo lo que vaya a filtrar
             * agregar un boton que reciba el articulo
             * pasar ese filtro no se de que manera el listado de default
             * mostrar desde default
             */
            Marca marcasFiltro = new Marca();
            MarcaNegocio marNegFiltro = new MarcaNegocio();
            List<Marca>listaMarcas= new List<Marca>();

            Categoria categoriaFiltro = new Categoria();
            CategoriaNegocio marCatFiltro = new CategoriaNegocio();
            List<Categoria> listaCategorias = new List<Categoria>();

            listaMarcas = marNegFiltro.listar();
            listaCategorias = marCatFiltro.listar();    

            ddlMarca.DataSource = listaMarcas;
            ddlMarca.DataValueField = "Descripcion";
            ddlMarca.DataBind();

            ddlCategoria.DataSource = listaCategorias;
            ddlCategoria.DataValueField = "Descripcion";
            ddlCategoria.DataBind();

        }
    }
}