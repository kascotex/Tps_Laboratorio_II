using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SerializadorJson<T> : IPersistencia<T>
    {
        /// <summary>
        /// Guarda los datos recibidos en un 
        /// archivo con formato <see langword="json"></see> en la ruta dada
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <param name="datos">Los datos a guardar en 
        /// formato <see langword="XML"></see></param>
        /// <exception cref="NoSeExportaronDatosException"></exception>Exception>
        public void Guardar(string ruta, T datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
                    jsonOptions.WriteIndented = true;

                    string contenidoJson = JsonSerializer.Serialize(datos, jsonOptions);
                    streamWriter.Write(contenidoJson);
                }
            }
            catch (Exception e)
            {
                throw new NoSeExportaronDatosException("Error al guardar archivo .json", e);
            }
        }

        /// <summary>
        /// Lee en formato <see langword="json"></see> los datos en la ruta dada 
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        /// </summary>
        /// <param name="ruta">Ruta completa del archivo incuida la extencion</param>
        /// <returns>Los datos en formato <see langword="json"></see></returns>
        /// <exception cref="NoSeImportaronDatosException"></exception>Exception>
        public T Leer(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return JsonSerializer.Deserialize<T>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw new NoSeImportaronDatosException("Error al leer archivo .json", e);
            }
        }

    }
}
