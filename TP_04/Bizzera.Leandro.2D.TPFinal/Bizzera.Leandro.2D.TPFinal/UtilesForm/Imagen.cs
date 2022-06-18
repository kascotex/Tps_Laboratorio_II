using Biblioteca;
using MisFunciones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public static class Imagen
    {
        /// <summary>
        /// Remplaza un icono por uno 
        /// </summary>
        /// <param name="icono">Icono que va a ser remplazado</param>
        /// <param name="nombre">nombre del archivo</param>
        /// <returns></returns>
        /// <exception cref="DirectoryNotFoundException"></exception>Exception>
        public static Icon CargarIcono(string nombre)
        {
            try
            {
                return new Icon(Ruta.Archivo(Ruta.Imagenes, nombre, "ico", true));
            }
            catch (Exception e)
            {
                throw new DirectoryNotFoundException($"Error al intentar Cargar icono '{nombre}'", e);
            }
        }


        private static Image CargarImagenPng(string ruta)
        {
            try
            {
                return Image.FromFile(ruta);
            }
            catch (Exception e)
            {
                throw new DirectoryNotFoundException($"Error al cargar la imagen '{ruta}'", e);
            }
        }


        /// <summary>
        /// Carga una imagen .png desde la carpeta Imagenes 
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        /// <returns></returns>
        /// <exception cref="DirectoryNotFoundException"></exception>Exception>
        public static Image CargarImagen(string nombre)
        {
            return CargarImagenPng(Ruta.ImagenPng(nombre, true));
        }

        public static Image CargarImagenSabor(string nombre)
        {
            return CargarImagenPng(Ruta.ImagenPng(Ruta.ImagenesSabores, nombre));
        }
        public static Image CargarImagenEnvase(string nombre)
        {
            return CargarImagenPng(Ruta.ImagenPng(Ruta.ImagenesEnvases, nombre));
        }
        public static Image CargarImagenOpcion(string nombre)
        {
            return CargarImagenPng(Ruta.ImagenPng(Ruta.ImagenesOpciones, nombre));
        }



        /// <summary>
        /// Carga la propiedad BackgroundImage y el icono del Form
        /// </summary>
        /// <param name="form"></param>
        public static void CargarBasicas(Form form)
        {
            CargarIcono(form);
            CargarBackgroundImage(form);
        }

        /// <summary>
        /// Carga la propiedad BackgroundImage del Form con una imagen .png 
        /// </summary>
        /// <param name="form"></param>
        public static void CargarBackgroundImage(Form form)
        {
            try
            {
                form.BackgroundImage = CargarImagen("Fondo");
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion("Error al cargar BackgroundImage", e);
            }
        }

        public static void CargarIcono(Form form)
        {
            try
            {
                form.Icon = CargarIcono("Heladeria");
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion("Error al cargar Icono", e);
            }
        }

        /// <summary>
        /// Carga la propiedad BackgroundImage del control con una imagen .png 
        /// desde la carpeta Imagenes cuyo es el nombre de la propiedad Name del control
        /// </summary>
        /// <param name="control"></param>
        public static void CargarBackgroundImage(Control control)
        {
            try
            {
                control.BackgroundImage = CargarImagen(control.Name);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion("Error al cargar BackgroundImage Para un Control", e);
            }
        }


    }
}
