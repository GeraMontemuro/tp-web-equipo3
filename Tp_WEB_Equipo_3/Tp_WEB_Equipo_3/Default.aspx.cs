﻿using System;
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

            ListaArticulo = articuloNegocio.listarconSP();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }
            //ArticuloNegocio articulonegocio = new ArticuloNegocio();
            //dgvarticulos.DataSource = articulonegocio.listar();
            //dgvarticulos.DataBind();

            //if (Request.QueryString["auxid"]!= null)
            //{
            //    int id = int.Parse(Request.QueryString["auxid"].ToString());
            //    List<Articulo> temporal = (List<Articulo>)Session["listarArticulos"];
            //    Articulo selecionado = temporal.Find(x=>x.IDArticulo == id);

            //}

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
        }

        protected void dgvarticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  var algo= dgvarticulos.SelectedRow.Cells[0].Text;
           // var auxid = dgvarticulos.SelectedDataKey.Value.ToString();
          //  Response.Redirect("Detalle.aspx?auxid=" + auxid);
        }
    }
}