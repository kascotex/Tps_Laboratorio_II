using Biblioteca;
using MisFunciones;
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
    public partial class CtrlEnvases : UserControl
    {
        public CtrlEnvases()
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
                    if (item is not null && item is PictureBox p)
                    {
                        nombre = item.Name.Replace("pictureBox", "");
                        p.Image = Imagen.CargarImagenEnvase(nombre);
                    }
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion("Error al cargar Imagen para envase", e);
                }
            }
        }


        public void CargarEventos(EventHandler eventoEnvase)
        {
            pictureBoxCucurucho.Click += new EventHandler(eventoEnvase);
            pictureBoxVasito.Click += new EventHandler(eventoEnvase);
            pictureBoxTacita.Click += new EventHandler(eventoEnvase);
            pictureBoxCuarto.Click += new EventHandler(eventoEnvase);
            pictureBoxMedio.Click += new EventHandler(eventoEnvase);
            pictureBoxKilo.Click += new EventHandler(eventoEnvase);
        }



    }
}
