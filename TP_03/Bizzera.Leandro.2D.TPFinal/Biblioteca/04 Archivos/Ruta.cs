using System;
using System.IO;



namespace Biblioteca

{
    public static class Ruta
    {

        //  *(Actual) C:\Users\Usuario\source\repos\00 Mis Funciones\MisFunciones\bin\Debug\net5.0
        //
        // Estructura de Archivos
        //
        // Projecto 
        // |   
        // |--> MisFunciones
        // |    |   
        // |    |--> bin
        // |    |    |   
        // |    |    |--> Debug 
        // |    |    |    |
        // |    |____|____|--> net5.0  *(Actual)
        // |   
        // |--> Data
        // |    |   
        // |    |--> Imagenes
        // |    |    |   
        // |    |    |--> 
        // |    |       
        // |    |--> Sonidos
        // |    |    |   
        // |    |    |--> 
        // |    |       
        // |    |--> ArchivosDeTexto
        // |    |    |   
        // |    |    |--> Logs
        // |    |    |    |   
        // |    |    |    |--> 
        // |    |    |       
        // |    |    |--> Recibos
        // |    |    |    |   
        // |    |    |    |--> 




        public static string Data
        {
            get
            { return ObtenerCarpeta("..\\..\\..\\..\\Data"); }
        }
        public static string Imagenes
        {
            get
            { return ObtenerCarpeta($"{Data}\\Imagenes"); }
        }
        public static string ImagenesSabores
        {
            get
            { return ObtenerCarpeta($"{Imagenes}\\Sabores"); }
        }
        public static string ImagenesEnvases
        {
            get
            { return ObtenerCarpeta($"{Imagenes}\\Envases"); }
        }
        public static string ImagenesOpciones
        {
            get
            { return ObtenerCarpeta($"{Imagenes}\\Opciones"); }
        }
        public static string Sonidos
        {
            get
            { return ObtenerCarpeta($"{Data}\\Sonidos"); }
        }
        public static string Base
        {
            get
            { return ObtenerCarpeta($"{Data}\\Base"); }
        }
        public static string ArchivosDeTexto
        {
            get
            { return ObtenerCarpeta($"{Data}\\Archivos De Texto"); }
        }
        public static string Logs
        {
            get
            { return ObtenerCarpeta($"{ArchivosDeTexto}\\Logs"); }
        }
        public static string Recibos
        {
            get
            { return ObtenerCarpeta($"{ArchivosDeTexto}\\Recibos"); }
        }



        /// <summary>
        /// Obtiene, y si no existe la crea, la ruta a la carpeta pedida
        /// </summary>
        /// <param name="ruta">Ruta de la carpeta</param>
        /// <returns>La ruta a la carpeta</returns>
        public static string ObtenerCarpeta(string ruta)
        {
            try
            {
                Directory.CreateDirectory(ruta);
                return ruta;
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(e);
                return null;
            }
        }



        /// <summary>
        /// Construye la ruta junto al archivo y la extension, si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="ext">Extencion que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string Archivo(string ruta, string nombre, string ext, bool chek)
        {
            string archivo = null;

            if (!MfBasic.ContieneNull(ruta, nombre, ext))
            {
                archivo = $"{ruta}\\{nombre}.{ext}";

                if (chek && !File.Exists(archivo)) return null;
            }

            return archivo;
        }



        /// <summary>
        /// Construye la ruta junto al archivo con extension txt, si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension txt
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoTxt(string ruta, string nombre, bool chek)
        {
            return Archivo(ruta, nombre, "txt", chek);
        }

        /// <summary>
        /// Construye la ruta junto al archivo con extension txt
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension txt
        /// o <see langword="null"></see></returns>
        public static string ArchivoTxt(string ruta, string nombre)
        {
            return ArchivoTxt(ruta, nombre, false);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension txt, si la ruta no existe
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension txt
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoTxt(string nombre, bool chek)
        {
            return ArchivoTxt(Data, nombre, chek);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension txt
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension txt
        /// o <see langword="null"></see></returns>
        public static string ArchivoTxt(string nombre)
        {
            return ArchivoTxt(nombre, false);
        }



        /// <summary>
        /// Construye la ruta junto al archivo con extension xml, si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension xml
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoXml(string ruta, string nombre, bool chek)
        {
            return Archivo(ruta, nombre, "xml", chek);
        }

        /// <summary>
        /// Construye la ruta junto al archivo con extension xml
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension xml
        /// o <see langword="null"></see></returns>
        public static string ArchivoXml(string ruta, string nombre)
        {
            return ArchivoXml(ruta, nombre, false);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension xml, si la ruta no existe
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension xml
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoXml(string nombre, bool chek)
        {
            return ArchivoXml(Data, nombre, chek);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension xml
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension xml
        /// o <see langword="null"></see></returns>
        public static string ArchivoXml(string nombre)
        {
            return ArchivoXml(nombre, false);
        }



        /// <summary>
        /// Construye la ruta junto al archivo con extension json, si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension json
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoJson(string ruta, string nombre, bool chek)
        {
            return Archivo(ruta, nombre, "json", chek);
        }

        /// <summary>
        /// Construye la ruta junto al archivo con extension json
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension json
        /// o <see langword="null"></see></returns>
        public static string ArchivoJson(string ruta, string nombre)
        {
            return ArchivoJson(ruta, nombre, false);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension json, si la ruta no existe
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension json
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ArchivoJson(string nombre, bool chek)
        {
            return ArchivoJson(Data, nombre, chek);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Data junto al archivo con extension json
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension json
        /// o <see langword="null"></see></returns>
        public static string ArchivoJson(string nombre)
        {
            return ArchivoJson(nombre, false);
        }



        /// <summary>
        /// Construye la ruta junto al archivo con extension png, si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension png
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ImagenPng(string ruta, string nombre, bool chek)
        {
            // return Archivo(ruta, nombre, "png", chek);
            return Archivo(ruta, nombre, "png", chek);
        }

        /// <summary>
        /// Construye la ruta junto al archivo con extension png
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension png
        /// o <see langword="null"></see></returns>
        public static string ImagenPng(string ruta, string nombre)
        {
            return ImagenPng(ruta, nombre, false);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Imagenes junto al archivo con extension png, si la ruta no existe
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension png
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string ImagenPng(string nombre, bool chek)
        {
            return ImagenPng(Imagenes, nombre, chek);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Imagenes junto al archivo con extension png
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension png
        /// o <see langword="null"></see></returns>
        public static string ImagenPng(string nombre)
        {
            return ImagenPng(nombre, false);
        }



        /// <summary>
        /// Construye la ruta junto al archivo con extension wav unicamente si la ruta no existe
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension wav
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string SonidoWav(string ruta, string nombre, bool chek)
        {
            // return Archivo(ruta, nombre, "png", chek);
            return Archivo(ruta, nombre, "wav", chek);
        }

        /// <summary>
        /// Construye la ruta junto al archivo con extension wav
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension wav
        /// o <see langword="null"></see></returns>
        public static string SonidoWav(string ruta, string nombre)
        {
            return SonidoWav(ruta, nombre, false);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Sonidos junto al archivo con extension wav unicamente si la ruta no existe
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <param name="chek">Verificar si ya existe</param>
        /// <returns>La ruta completa con extension wav
        /// o <see langword="null"></see> si se verifica que ya existia</returns>
        public static string SonidoWav(string nombre, bool chek)
        {
            return SonidoWav(Sonidos, nombre, chek);
        }

        /// <summary>
        /// Construye la ruta a la carpeta Sonidos junto al archivo con extension wav
        /// </summary>
        /// <param name="nombre">Nombre que tendra el archivo</param>
        /// <returns>La ruta completa con extension wav
        /// o <see langword="null"></see></returns>
        public static string SonidoWav(string nombre)
        {
            return SonidoWav(nombre, false);
        }


    }

}
