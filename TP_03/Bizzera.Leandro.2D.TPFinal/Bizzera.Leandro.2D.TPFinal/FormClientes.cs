using Biblioteca;
using Heladeria;
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
    public partial class FormClientes : Form, IControlOpcionActual
    {
        private string opcionActual;

        public FormClientes()
        {
            InitializeComponent();
        }


        public string OpcionActual
        {
            get { return opcionActual; }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarImagenes();
           
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
        }

        private void CargarImagenes()
        {
            Imagen.CargarBasicas(this);
        }

        private void ManejadorDeOpciones(string opcion)
        {
            if (opcion is not null && opcion != "buttonClientes")
            {
                if (opcion == "buttonSalir") opcion = "buttonInicio";

                opcionActual = opcion;
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is Button boton)
            {
                ManejadorDeOpciones(boton.Name);
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


    }
}
