using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Biblioteca
{

    public class EtiquetaNoEncontradaException : Exception 
    {

        public EtiquetaNoEncontradaException() : this("Error al buscar en la lista de Etiquetas del Sabor.")
        {
        }
        public EtiquetaNoEncontradaException(string mensaje) : this(mensaje, null)
        {
        }
        public EtiquetaNoEncontradaException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }





    }

}
