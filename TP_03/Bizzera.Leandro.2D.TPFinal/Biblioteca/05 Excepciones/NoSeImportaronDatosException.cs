using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class NoSeImportaronDatosException : Exception
    {

        public NoSeImportaronDatosException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
        public NoSeImportaronDatosException(string mensaje) : this(mensaje, null)
        {
        }
        public NoSeImportaronDatosException() : this("Error al importar datos")
        {
        }





    }
}
