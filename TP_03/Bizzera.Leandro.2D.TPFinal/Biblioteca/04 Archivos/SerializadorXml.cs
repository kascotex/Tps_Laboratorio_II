using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace Biblioteca
{

    public class SerializadorXml<T> : IPersistencia<T>
    {
        /// <summary>
        /// Guarda los datos recibidos en un 
        /// archivo con formato <see langword="xml"></see> en la ruta dada
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <param name="datos">Los datos a guardar en 
        /// formato <see langword="xml"></see></param>
        /// <exception cref="NoSeExportaronDatosException"></exception>Exception>
        public void Guardar(string ruta, T datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(datos.GetType());
                    xml.Serialize(sw, datos);
                }
            }
            catch (Exception e)
            {
                throw new NoSeExportaronDatosException("Error al guardar archivo .xml", e);
            }
        }

        /// <summary>
        /// Lee en formato <see langword="xml"></see> los datos en la ruta dada 
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <returns>Los datos en formato <see langword="xml"></see></returns>
        /// <exception cref="NoSeImportaronDatosException"></exception>Exception>
        public T Leer(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    return (T)xml.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                throw new NoSeImportaronDatosException("Error al leer archivo .xml", e);
            }
        }







    }
}
