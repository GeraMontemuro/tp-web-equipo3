using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        
        public int IDArticulo { get; set; }
        [DisplayName ("Código Artículo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria{ get; set; }
        public decimal Precio { get; set; }


        public Articulo()
        {
            UrlImagen = "https://production.listennotes.com/podcasts/el-podcast-m%C3%A1s-random-del-mundo-L6I3Ep9lRTB-xB_PCg0EDch.1400x1400.jpg";
        }
    }

}
