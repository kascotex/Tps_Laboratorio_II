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
    public partial class FormPrincipal : Form
    {
        private Button opcionActual;


        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarImagenes();
           // Harcodear();
            CargarBase();
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
        }

        private void Harcodear()
        {
            Hardcodeo.CrearHeladeria();
        }
        private void CargarBase()
        {
            Empresa.RecuperarInfo();
        }
        private void CargarImagenes()
        {
            Imagen.CargarBasicas(this);
        }



        private void ManejadorDeOpciones(string opcion)
        {
            switch (opcion)
            {
                case "buttonEmpleados":
                    MostrarFormEmpleados();
                    break;
                case "buttonVentas":
                    MostrarFormVentas();
                    break;
                case "buttonSalir":
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void MostrarFormEmpleados()// << interfaz IControlOpcioneActual
        {
            FormEmpleados form = new FormEmpleados();
            Hide();
            form.ShowDialog();
            Show();
            ManejadorDeOpciones(form.OpcionActual);
        }
        private void MostrarFormVentas()
        {
            FormVentas form = new FormVentas();
            Hide();
            form.ShowDialog();
            Show();
            ManejadorDeOpciones(form.OpcionActual);
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
            if (DialogResult != DialogResult.OK)
            {
                if (!Mensaje.ConfirmarSalir()) e.Cancel = true;
                else Empresa.RespaldarInfo();
            }
        }



    }
}
