using MisFunciones;
using System;



namespace Biblioteca
{

    public static class MfBasic
    {          

        /// <summary>
        /// Evalua si un numero es multiplo de un determinado valor
        /// </summary>
        /// <param name="num"></param>
        /// <param name="val"></param>
        /// <returns><see langword="true"></see> si es multiplo</returns>
        public static bool EsMultiplo(int num, int val)
        {
            return num % val == 0;
        }

        /// <summary>
        /// Evalua si el valor dado se encuetra dentro del rango dado
        /// </summary>
        /// <param name="val">Valor a evaluar</param>
        /// <param name="min">Valor Minimo</param>
        /// <param name="max">Valor Maximo</param>
        /// <returns><see langword="true"></see> si esta dentro del rango</returns>
        public static bool EnRango(int val, int min, int max)
        {
            return !(val < min || val > max);
        }

        /// <summary>
        /// Evalua si el valor dado se encuetra dentro de la lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="val"></param>
        /// <returns><see langword="true"></see> si esta dentro de la lista</returns>
        public static bool EstaContenido(int[] lista, int val)
        {
            if (!ContieneNull(lista, val))
            {
                foreach (var item in lista)
                {
                    if (item == val) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Evalua si el valor dado se encuetra dentro de la lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="val"></param>
        /// <returns><see langword="true"></see> si esta dentro de la lista</returns>
        public static bool EstaContenido(char[] lista, char val)
        {
            if (!ContieneNull(lista, val))
            {
                foreach (var item in lista)
                {
                    if (item == val) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Evalua el valor <see langword="null"></see> de los elementos dados
        /// </summary>
        /// <returns><see langword="true"></see> si alguno de los elementos
        /// es <see langword="null"></see></returns>
        public static bool ContieneNull(object elementoA, object elementoB)
        {
            object[] elementos = { elementoA, elementoB };
            return ContieneNull(elementos);
        }
        /// <summary>
        /// Evalua el valor <see langword="null"></see> de los elementos dados
        /// </summary>
        /// <returns><see langword="true"></see> si alguno de los elementos
        /// es <see langword="null"></see></returns>
        public static bool ContieneNull(object elementoA, object elementoB, object elementoC)
        {
            object[] elementos = { elementoA, elementoB, elementoC };
            return ContieneNull(elementos);
        }
        /// <summary>
        /// Evalua el valor <see langword="null"></see> de los elementos dados
        /// </summary>
        /// <returns><see langword="true"></see> si alguno de los elementos
        /// es <see langword="null"></see></returns>
        public static bool ContieneNull(object[] elementos)
        {
            foreach (object item in elementos)
            {
                if (item is null)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
