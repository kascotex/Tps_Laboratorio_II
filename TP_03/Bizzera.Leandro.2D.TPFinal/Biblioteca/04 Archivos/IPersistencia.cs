using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Biblioteca
{

    public interface IPersistencia<T>
    //<< revisar:  where T : class
    {

        /// <summary>
        /// Guarda los datos recibidos, en un archivo en la ruta dada
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <param name="datos">Los datos a guardar en 
        /// formato <see langword="xml"></see></param>
        /// <exception cref="NoSeExportaronDatosException"></exception>Exception>
        void Guardar(string ruta, T datos);


        /// <summary>
        /// Lee los datos en la ruta dada 
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <returns>Los datos en formato <see langword="xml"></see></returns>
        /// <exception cref="NoSeImportaronDatosException"></exception>Exception>
        T Leer(string ruta);

    }


}
