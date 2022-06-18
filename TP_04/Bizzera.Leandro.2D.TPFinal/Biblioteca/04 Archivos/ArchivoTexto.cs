using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ArchivoTexto : IPersistencia<string>
    {
        /// <summary>
        /// Guarda los datos recibidos en un 
        /// archivo con formato <see langword="txt"></see> en la ruta dada
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <param name="datos">Los datos a guardar en 
        /// formato <see langword="txt"></see></param>
        /// <exception cref="NoSeExportaronDatosException"></exception>Exception>
        public void Guardar(string ruta, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write(datos);
                }
            }
            catch (Exception e)
            {
                throw new NoSeExportaronDatosException("Error al guardar archivo .txt", e);
            }
        }

        /// <summary>
        /// Lee en formato <see langword="txt"></see> los datos en la ruta dada 
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <returns>Los datos en formato <see langword="txt"></see></returns>
        /// <exception cref="NoSeImportaronDatosException"></exception>Exception>
        public string Leer(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    return sr.ReadToEnd() as string;
                }
            }
            catch (Exception e)
            {
                throw new NoSeImportaronDatosException("Error al leer archivo .txt", e);
            }
        }




    }
}
