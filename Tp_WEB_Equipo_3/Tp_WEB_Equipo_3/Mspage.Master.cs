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
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Marca marcasFiltro = new Marca();
                MarcaNegocio marNegFiltro = new MarcaNegocio();
                List<Marca> listaMarcas = new List<Marca>();

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
                FuncionGlobal.CantidadTotal();
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            List<Articulo> listaArt = new List<Articulo>();
            List<Articulo> listaFiltrada = new List<Articulo>();

            string valor = "0";

            listaArt = artNegocio.listar();

            Articulo artFiltrado = new Articulo
            {
                Marca = new Marca(),         
                Categoria = new Categoria() 
            };

            artFiltrado.Marca.Descripcion = ddlMarca.SelectedValue;
            artFiltrado.Categoria.Descripcion = ddlCategoria.SelectedValue;

            foreach( Articulo art in listaArt)
            {
                if(art.Marca.Descripcion == artFiltrado.Marca.Descripcion && art.Categoria.Descripcion == artFiltrado.Categoria.Descripcion)
                {
                    listaFiltrada.Add(art);
                    valor = "1";
                }
            }

            
            Session["ArticuloFiltrado"]= listaFiltrada;
            Response.Redirect("Default.aspx?bandera=" + valor );


        }
    
    }
}