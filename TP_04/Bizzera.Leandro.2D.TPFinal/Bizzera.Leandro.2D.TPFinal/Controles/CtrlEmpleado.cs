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
    public partial class CtrlEmpleado : UserControl
    {
        private Empleado empleado;

        public CtrlEmpleado()
        {
            InitializeComponent();
        }
        public CtrlEmpleado(Empleado empleado)
            : this()
        {
            this.empleado = empleado;
        }


        public Empleado Empleado
        {
            get { return empleado; }
        }



        private void CtrlEmpleado_Load(object sender, EventArgs e)
        {
            CaegarEmpleado();
        }

        private void CaegarEmpleado()
        {
            try
            {
                pictureBoxEmpleado.Image = Imagen.CargarImagen(empleado.Puesto.ToString());
                labelNombre.Text = empleado.NombreCompleto;
                labelId.Text = empleado.IdString;
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al CargarImagenPng empleado", e));
            }
        }

        public void CargarEventos(FormEmpleados form)
        {
            foreach (Control item in Controls)
            {
                if (item is not null) item.Click += new EventHandler(form.CtrlEmpleado_Click);
            }

        }





    }
}
