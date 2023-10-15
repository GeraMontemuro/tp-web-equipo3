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
            decimal auxprecio = 0;
            string PrecioTotal;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
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
                finally
                {
                    List<Articulo> Temporal2 = new List<Articulo>();
                    Temporal2 = (List<Articulo>)Session["listafinal"];

                    if (Temporal2 != null)
                    {
                        foreach (Articulo item in Temporal2)
                        {
                            auxprecio += item.Precio;
                        }

                    }

                    PrecioTotal = string.Format("{0:C}", auxprecio);
                    TextPrecioTotal.Text = PrecioTotal;
                }

            }
            else
            {

                List<Articulo> Temporal2 = new List<Articulo>();
                Temporal2 = (List<Articulo>)Session["listafinal"];
              
                if (Temporal2 != null)
                {
                    foreach (Articulo item in Temporal2)
                    {
                        auxprecio += item.Precio;
                    }

                }
               
                 PrecioTotal = string.Format("{0:C}", auxprecio);
                    TextPrecioTotal.Text = PrecioTotal;
            }
        }


        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxprecio = 0;
            var id = dgvCarrito.SelectedDataKey.Value.ToString();
            Articulo aux = new Articulo();

            List<Articulo> carrito = (List<Articulo>)Session["listafinal"];
            aux = carrito.Find(x => x.IDArticulo == int.Parse(id));
            if (aux != null)
            {
                carrito.Remove(aux);
                Session["listafinal"] = carrito;
                
        

            if (carrito != null)
            {
                foreach (Articulo item in carrito)
                {
                    auxprecio += item.Precio;
                }
                    PrecioTotal = string.Format("{0:C}", auxprecio);
                    TextPrecioTotal.Text = PrecioTotal;

            }
            dgvCarrito.DataSource = carrito;
            dgvCarrito.DataBind();
            }


        }
    }
}