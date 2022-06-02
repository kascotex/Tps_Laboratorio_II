using MisFunciones;
using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Sabor
    {
        public enum ETipo { Cremas, Chocolates, Granizados, Frutales, De_Agua, De_Crema, Especiales }
        static int ultimoId;

        private int id;
        private string nombre;
        private float costo;
        private float stock;
        private float minimo;
        private List<ETipo> etiquetas;


        public Sabor()
        {

        }
        private Sabor(string nombre, float costo, float? cantidad)
        {
            id = ++ultimoId;
            etiquetas = new List<ETipo>();
            minimo = 20000;
            Costo = costo;
            Stock = cantidad ?? 0;
            this.nombre = nombre;
        }
        public Sabor(string nombre, float costo, List<ETipo> etiquetas, float? cantidad)
            : this(nombre, costo, cantidad)
        {
            this.etiquetas = etiquetas;
        }
        public Sabor(string nombre, float costo, List<ETipo> etiquetas)
            : this(nombre, costo, etiquetas, null)
        {
        }
        public Sabor(string nombre, float costo, ETipo etiqueta, float? cantidad)
          : this(nombre, costo, EtiquetaEnListaEtiquetas(etiqueta), cantidad)
        {
        }
        public Sabor(string nombre, float costo, ETipo etiqueta)
           : this(nombre, costo, etiqueta, null)
        {
        }



        public int Id
        {
            get { return id; }
            //<< corregir set { }
        }
        public float Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Costo
        {
            get { return costo; }
            set
            {
                if (value < 0) value = 0;
                costo = value;
            }
        }
        public float Stock
        {
            get { return stock; }
            set
            {
                if (stock + value < 0) value = 0;
                else if (stock + value >= float.MaxValue) stock = float.MaxValue;
                stock = value;
            }
        }
        public static int UltimoId
        {
            get { return ultimoId; }
        }
        public List<ETipo> Etiquetas
        {
            get { return etiquetas; }
            set { etiquetas = value; }
        }
        public List<string> EtiquetasString //<< hacer metodo? quitar propiedad Etiquetas? se usa Etiquetas?
        {
            get
            {
                List<string> lista = new List<string>();

                foreach (ETipo item in etiquetas)
                {
                    lista.Add(item.ToString());
                }
                return lista;
            }           
        }




        /// <summary>
        /// Convierte una etiqueta en una lista de etiquetas de un solo item
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns>Una lista de etiquetas de un solo item</returns>
        private static List<ETipo> EtiquetaEnListaEtiquetas(ETipo etiqueta)
        {
            List<ETipo> lista = new List<ETipo>();
            lista.Add(etiqueta);
            return lista;
        }

        /// <summary>
        /// Busca la etiqueta que coincida con el argumento dado
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns>Una etiqueta que coincide con el string recibido ó
        /// una etiqueta ETipo.SinEtiqueta</returns>
        /// <exception cref="EtiquetaNoEncontradaException"></exception>Exception>
        private ETipo EtiquetaDesdeString(string etiqueta)
        {
            if (etiqueta is not null)
            {
                foreach (ETipo item in Enum.GetValues(typeof(ETipo)))
                {
                    if (item.ToString() == etiqueta) return item;
                }
            }
            throw new EtiquetaNoEncontradaException();
        }

        /// <summary>
        /// Evalua si exite una etiqueta que coincida con el argumento dado
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> si es valida</returns>
        public bool EsValidEtiqueta(string etiqueta)
        {
            if (etiqueta is not null)
            {
                foreach (ETipo item in Enum.GetValues(typeof(ETipo)))
                {
                    if (item.ToString() == etiqueta) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Evalua si exite, dentro de la lista de etiquetas,
        /// una etiqueta que coincida con el argumento dado
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> si existe dentro de la lista de etiquetas</returns>
        public bool ContieneEtiqueta(string etiqueta)
        {
            if (etiqueta is not null)
            {
                foreach (ETipo item in etiquetas)
                {
                    if (item.ToString() == etiqueta) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Agrega la etiqueta que coincida con el argumento dado
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> si agrego la etiqueta</returns>
        private bool AgregarEtiqueta(string etiqueta)
        {
            if (etiqueta is not null && EsValidEtiqueta(etiqueta) && !ContieneEtiqueta(etiqueta))
            {
                try
                {
                    etiquetas.Add(EtiquetaDesdeString(etiqueta));
                    return true;
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(e);
                }
            }
            return false;
        }

        /// <summary>
        /// Quita la etiqueta que coincida con el argumento dado
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> si quito la etiqueta</returns>
        private bool QuitarEtiqueta(string etiqueta)
        {
            if (etiqueta is not null && EsValidEtiqueta(etiqueta) && ContieneEtiqueta(etiqueta))
            {
                try
                {
                    etiquetas.Remove(EtiquetaDesdeString(etiqueta));
                    return true;
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(e);
                }
            }
            return false;
        }

        /// <summary>
        /// Agrega las etiquetas que coincidan con la lista argumentos dados
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> la cantidad de etiquetas que se agregaron</returns>
        public int AgregarEtiqueta(List<string> etiquetas)
        {
            int i = 0;
            if (etiquetas is not null)
            {
                foreach (string item in etiquetas)
                {
                    if (item is not null && AgregarEtiqueta(item)) i++;
                }
            }
            return i;
        }

        /// <summary>
        /// Quita las etiquetas que coincidan con la lista argumentos dados
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <returns><see langword="true"></see> la cantidad de etiquetas que se quitaron</returns>
        public int QuitarEtiqueta(List<string> etiquetas)
        {
            int i = 0;
            if (etiquetas is not null)
            {
                foreach (string item in etiquetas)
                {
                    if (item is not null && QuitarEtiqueta(item)) i++;
                }
            }
            return i;
        }



    }
}