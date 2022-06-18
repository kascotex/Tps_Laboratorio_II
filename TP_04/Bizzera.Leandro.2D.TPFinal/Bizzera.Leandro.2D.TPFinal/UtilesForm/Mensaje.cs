using Biblioteca;
using MisFunciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public static class Mensaje
    {


        public static void Advertencia(string msj, string titulo)
        {
            try
            {
                MessageBox.Show(msj, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(e);
            }
        }
        /// <summary>
        /// Evalua si un cuadro de dialogo que solo admite 
        /// respuestas [si / no] fue respondido con si
        /// </summary>
        /// <param name="msj">Mensaje que se mostrara</param>
        /// <param name="titulo">Encabezado del mensaje</param>
        /// <returns></returns>
        public static bool Confirmar(string msj, string titulo)
        {
            DialogResult resultado = DialogResult.Abort;
            try
            {
                resultado = MessageBox.Show(msj, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(e);
            }
            return resultado == DialogResult.Yes;
        }

        /// <summary>
        /// Evalua si un cuadro de dialogo, con el mensaje: "¿Confirma que desea salir?",
        /// y que solo admite respuestas [si / no ] fue respondido con si
        /// </summary>
        /// <param name="titulo">Encabezado del mensaje</param>
        /// <returns></returns>
        public static bool ConfirmarSalir(string titulo)
        {
            return Confirmar("¿Confirma que desea salir?", titulo);
        }

        /// <summary>
        /// Evalua si un cuadro de dialogo, con el mensaje: "¿Confirma que desea salir?",
        /// y el titulo: ""Confirmar Salida", que solo admite respuestas [si / no ] fue respondido con si
        /// </summary>
        /// <returns></returns>
        public static bool ConfirmarSalir()
        {
            return ConfirmarSalir("Confirmar Salida");
        }
        public static bool EstaSeguroQue()
        {
            return EstaSeguroQue(null);
        }
        public static bool EstaSeguroQue(string msj)
        {
            string mensaje = "¿Está seguro?";

            if (msj is not null)
            {
                mensaje = $"¿Está seguro que {msj.Trim()}?";
            }
            return Confirmar(mensaje, "Confirmar accion");
        }

        
        public static void Error()
        {
            Error("Se a producido un error.");
        }
        public static void Error(string mensaje)
        {
            Error(mensaje, "Error");
        }
        public static void Error(string mensaje, string titulo)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(mensaje, titulo, buttons, icon);
        }


    }
}
