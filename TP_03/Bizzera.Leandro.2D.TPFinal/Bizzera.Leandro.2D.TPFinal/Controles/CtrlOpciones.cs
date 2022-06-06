using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class CtrlOpciones : UserControl
    {



        public CtrlOpciones()
        {
            InitializeComponent();
            CargarImagenes();
        }


        private void CargarImagenes()
        {
            string nombre;

            foreach (Control item in Controls)
            {
                try
                {
                    if (item is not null && item is Button boton)
                    {
                        nombre = item.Name.Replace("button", "");
                        boton.BackgroundImage = Imagen.CargarImagenOpcion(nombre);
                    }
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion("Error al cargar Imagen para envase", e);
                }
            }
        }

        public void CargarEventos(EventHandler eventoOpciones)
        {
            buttonSalir.Click += new EventHandler(eventoOpciones);
            buttonInicio.Click += new EventHandler(eventoOpciones);
            buttonVentas.Click += new EventHandler(eventoOpciones);
            buttonEmpleados.Click += new EventHandler(eventoOpciones);
            buttonHerramientas.Click += new EventHandler(eventoOpciones);
            buttonClientes.Click += new EventHandler(eventoOpciones);
        }

    }
}
