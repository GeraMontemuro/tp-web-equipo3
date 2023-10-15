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
        public Articulo Buscar(int ID)
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

    }
}

public static class FuncionGlobal
{
    public static int Valor = 0;

    public static int CantidadTotal()
    {
        return Valor;
    }
    public static void CantidadTotalAsignada(int cont)
    {
        Valor = cont;
    }

}