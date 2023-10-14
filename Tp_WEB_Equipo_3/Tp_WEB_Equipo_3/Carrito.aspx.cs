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
    public partial class Compra : System.Web.UI.Page
    {
        public Articulo art = new Articulo();
        public List<Articulo> ListadeCompra = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {

                int Idaux = int.Parse(Request.QueryString["id"]);
                art.IDArticulo = Idaux;



                if (Session["listafinal"] == null)
                {
                    CarritoNegocio Negocio = new CarritoNegocio();
                    Session.Add("listafinal", (Negocio.Cargar(Idaux, ListadeCompra)));
                }
                else
                {

                    CarritoNegocio Negocio = new CarritoNegocio();
                    List<Articulo> Temporal1 = (List<Articulo>)Session["listafinal"];
                    Temporal1.Add(Negocio.Buscar(Idaux));

                }


                List<Articulo> Temporal = (List<Articulo>)Session["listafinal"];


                dgvCarrito.DataSource = Temporal;
                dgvCarrito.DataBind();


            }
            catch (Exception)
            {
                List<Articulo> Temporal = (List<Articulo>)Session["listafinal"];

                dgvCarrito.DataSource = Temporal;
                dgvCarrito.DataBind();

            }

        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

            var algo = dgvCarrito.SelectedRow.Cells[0].Text;
            var id = dgvCarrito.SelectedDataKey.Value.ToString();
            Articulo aux = new Articulo();


            List<Articulo> carrito = (List<Articulo>)Session["listafinal"];
            aux = carrito.Find(x => x.IDArticulo == int.Parse(id));
            if (aux != null)
            {
                carrito.Remove(aux);
                Session.Add("listafinal", carrito);
                //dgvCarrito.DataSource = carrito;
                //dgvCarrito.DataBind();
            }


        }
    }
}