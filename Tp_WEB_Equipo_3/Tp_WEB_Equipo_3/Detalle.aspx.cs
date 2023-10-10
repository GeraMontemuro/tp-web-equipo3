using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_WEB_Equipo_3
{
    public partial class Detalle: System.Web.UI.Page
    {
        Articulo articulo = new Articulo(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Request.QueryString["auxid"] == null) return;
                string abc = (String)Request.QueryString["auxid"];
                Console.WriteLine(abc);     
            }
        }

    }
}