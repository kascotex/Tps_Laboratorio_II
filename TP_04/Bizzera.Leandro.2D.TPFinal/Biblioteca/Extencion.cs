using MisFunciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Extencion
    {

        /// <summary>
        /// Devuelve una lista filtrada, aplicando el criterio Delegado
        /// </summary>
        /// <typeparam name="T">Tipo de la lista</typeparam>
        /// <param name="lista"></param>
        /// <param name="filtro">Delegado que devuelve bool</param>
        /// <returns></returns>
        public static List<T> Filtrar<T>(this List<T> lista, DelegadoFiltrar<T> filtro)
        {
            List<T> listaFiltrada = new List<T>();

            if (!MfBasic.ContieneNull(lista, filtro))
            {
                foreach (T item in lista)
                {
                    if (item is not null && filtro(item)) listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        public static T FiltrarElemento<T>(this List<T> lista, DelegadoFiltrar<T> filtro)
        where T : class
        {
            if (!MfBasic.ContieneNull(lista, filtro))
            {
                foreach (T item in lista)
                {
                    if (item is not null && filtro(item)) return item;
                }
            }
            return null;
        }




    }
}
