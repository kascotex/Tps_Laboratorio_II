using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NoSeExportaronDatosException : Exception
    {

        public NoSeExportaronDatosException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
        public NoSeExportaronDatosException(string mensaje) : this(mensaje, null)
        {
        }
        public NoSeExportaronDatosException() : this("Error al exportar datos")
        {
        }
       





    }
}
