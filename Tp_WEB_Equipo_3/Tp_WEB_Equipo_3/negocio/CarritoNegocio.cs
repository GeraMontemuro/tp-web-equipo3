using dominio;
using negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace negocio
{
    public class CarritoNegocio
    {
        private List<Articulo> art;
        private Articulo art1;

        public List<Articulo> Cargar(int ID, List<Articulo> lista)
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                art = negocio.listar();

                foreach (var Articulo in art)
                {
                    if (ID == (int)Articulo.IDArticulo)
                    {
                        lista.Add(Articulo);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
        public Articulo Agregar(int ID)
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                art = negocio.listar();

                foreach (var Articulo in art)
                {
                    if (ID == (int)Articulo.IDArticulo)
                    {
                        art1 = Articulo;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return art1;



        }

        public void Eliminar(int ID, List<Articulo> lista)
        {
            ///VIENE DEL BOTON EL ID Y LA LISTA BUSCA EL ID EN LA LISTA LO ELIMINA Y RETORNA LA LISTA NUEVA

        }

    }
}
