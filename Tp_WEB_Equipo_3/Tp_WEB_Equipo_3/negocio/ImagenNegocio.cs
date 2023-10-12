using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar(string ArticuloId)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("Select Ima.Id as IDImagen,Ima.IdArticulo as IDArti,Ima.ImagenUrl as UrlI  from IMAGENES Ima");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen ImagenArticulos = new Imagen();


                    ImagenArticulos.IDArticulo = (int)datos.Lector["IDArti"];
                    if (!(datos.Lector["UrlI"] is DBNull))
                    {
                        if (ArticuloId == ImagenArticulos.IDArticulo.ToString())
                            ImagenArticulos.ImagenUrl = (string)datos.Lector["UrlI"];
                            lista.Add(ImagenArticulos);
                    }

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
