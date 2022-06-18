using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MisFunciones
{

    public static class MfString
    {


        /// <summary>
        /// Evalua las cadenas estan vacias son null o contienen todos espacios en blancos
        /// </summary>
        /// <param name="c"></param>
        /// <returns><see langword="true"></see> si la cadena contiene todos espacios en blancos</returns>
        public static bool EstaVaciaEnBlancoNull(string[] cadenas)
        {
            foreach (string item in cadenas)
            {
                if (!EstaVaciaEnBlancoNull(item)) return false;
            }
            return true;
        }

        /// <summary>
        /// Evalua la cadena esta vacia es null o contiene todos espacios en blancos
        /// </summary>
        /// <param name="c"></param>
        /// <returns><see langword="true"></see> si la cadena contiene todos espacios en blancos</returns>
        public static bool EstaVaciaEnBlancoNull(string cadena)
        {
            if (cadena is null || EstaVacia(cadena) || EsEspaciosEnBlanco(cadena)) return true;
            return false;
        }

        /// <summary>
        /// Evalua si la cadena contiene todos espacios en blancos
        /// </summary>
        /// <param name="c"></param>
        /// <returns><see langword="true"></see> si la cadena contiene todos espacios en blancos</returns>
        public static bool EsEspaciosEnBlanco(string cadena)
        {
            if (cadena is null) return false;

            foreach (char item in cadena)
            {
                if (item != ' ') return false;
            }
            return true;
        }

        /// <summary>
        /// Evalua si la cadena solo tiene un espacio en blanco
        /// </summary>
        /// <param name="c"></param>
        /// <returns><see langword="true"></see> si solo tiene un espacio en blanco</returns>
        public static bool EsEspacio(string cadena)
        {
            if (cadena is null || cadena != " ") return false;
            return true;
        }

        /// <summary>
        /// Evalua si es una cadena vacia
        /// </summary>
        /// <param name="c"></param>
        /// <returns><see langword="true"></see> si esta vacia</returns>
        public static bool EstaVacia(string cadena)
        {
            if (cadena is null || cadena != "") return false;
            return true;
        }




        /// <summary>
        /// Evalua si son caracteres de letras
        /// </summary>
        /// <param name="texto"></param>
        /// <returns><see langword="true"></see> si todos los caracteres son letras</returns>
        public static bool SonLetras(string cadena)
        {
            if (cadena is null) return false;
            
            foreach (char item in cadena)
            {
                if (!char.IsLetter(item)) return false;
            }
            return true;
        }
        public static bool SonLetrasConEspacios(string cadena)
        {
            if (cadena is null) return false;

            foreach (char item in cadena)
            {
                if (!char.IsLetter(item) || item != ' ') return false;
            }
            return true;
        }

        /// <summary>
        /// Evalua si son caracteres en mayusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns><see langword="true"></see> si todos los caracteres son mayusculas</returns>
        public static bool EstaEnMayusculas(string texto)
        {
            if (texto is not null)
            {
                foreach (char item in texto)
                {
                    if (char.IsLower(item)) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Evalua si son caracteres en minusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns><see langword="true"></see> si todos los caracteres son minusculas</returns>
        public static bool EstaEnMinusculas(string texto)
        {
            foreach (char item in texto)
            {
                if (char.IsUpper(item)) return false;
            }
            return true;
        }

        /// <summary>
        /// Quita de la cadena recibida todos cararcteres que coincidan con el caracter dado
        /// </summary>
        /// <param name="texto">Cadena de caracteres</param>
        /// <param name="c">Caracter a eleminar de la cadena</param>
        /// <returns>Una nueva cadena sin el caracter buscado</returns>
        public static string QuitarCaracteres(string texto, char c)
        {
            if (texto is not null)
            {
                while (texto.Contains(c))
                {
                    texto = texto.Remove(texto.IndexOf(c), 1);
                }
            }
            return texto;
        }

        /// <summary>
        /// Quita de la cadena recibida todos cararcteres de espacio ' '
        /// </summary>
        /// <param name="texto">Cadena de caracteres</param>
        /// <returns>Una nueva cadena sin espacios</returns>
        public static string QuitarEspacios(string texto)
        {
            return QuitarCaracteres(texto, ' ');
        }





        /// <summary>
        /// Crea un nombre junto una fecha con el formato aaaammdd-hhmmss
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string FechaParaArchivo(string nombre, DateTime fecha)
        {
            return $"{nombre} {FechaParaArchivo(fecha)}";
        }

        /// <summary>
        /// Crea un nombre junto la fecha actual con el formato aaaammdd-hhmmss
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string FechaParaArchivo(string nombre)
        {
            return FechaParaArchivo(nombre, DateTime.Now);
        }

        /// <summary>
        /// Crea una fecha con el formato aaaammdd-hhmmss, con la fecha actual
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string FechaParaArchivo()
        {
            return FechaParaArchivo(DateTime.Now);
        }

        /// <summary>
        /// Crea una fecha con el formato aaaammdd-hhmmss
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string FechaParaArchivo(DateTime fecha)
        {
            try
            {
                return fecha.ToString("yyyy_MM_dd HH_mm_ss");
            }
            catch (Exception)
            {
                return $"{fecha.Year}_{fecha.Month}_{fecha.Day} {fecha.Hour}_{fecha.Minute}_{fecha.Second}";
            }
        }


    }
}
