using MisFunciones;
using System;

namespace Biblioteca
{
    public static class Log
    {
        public static void GuardarExcepcion(string mensaje, Exception e)
        {
            string error = $"{mensaje}\n";
            string nombre;

            try
            {
                nombre = MfString.FechaParaArchivo(e.Message);
                error += ArmarInformeExcepcion(e);
                new ArchivoTexto().Guardar(Ruta.ArchivoTxt(Ruta.Logs, nombre), error);
            }
            catch (Exception)
            {
            }
        }
        public static void GuardarExcepcion(Exception e)
        {
            GuardarExcepcion(null, e);
        }

        public static string ArmarInformeExcepcion(Exception e)
        {
            int orden = 0;
            string error = null;

            if (e is not null)
            {
                do
                {
                    error += $"Orden: {orden} - Mensaje: {e.Message}\n";
                    error += $"Inner StackTrace:\n{e.StackTrace}\n---\n";
                    e = e.InnerException;
                    orden++;
                } while (e is not null);
            }

            return error;
        }
    }
}
