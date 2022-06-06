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
    public partial class CtrlSabor : UserControl
    {
       private string sabor;


        private CtrlSabor()
        {
            InitializeComponent();
        }

        public CtrlSabor(string sabor)
            :this()
        {
            this.sabor = sabor;
        }
        public string Sabor { get => sabor; }

        private void CtrlSabor_Load(object sender, EventArgs e)
        {
            labelSabor.Text = sabor;
            try
            {
                BackgroundImage = Imagen.CargarImagenSabor(sabor);
            }
            catch (Exception ex)
            {
                Log.GuardarExcepcion("Error al cargar BackgroundImage", ex);
            }
        }

        internal void CargarEventos(FormVentas form)
        {
            buttonEliminar.Click += new EventHandler(form.CtrlSabor_Click);
                 
        }
    }
}
