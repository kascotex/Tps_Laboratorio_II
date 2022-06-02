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
    public partial class FormVentas : Form
    {
        private string opcionActual;
        Envase envaseActual;



        public FormVentas()
        {
            InitializeComponent();
        }



        public string OpcionActual
        {
            get { return opcionActual; }
        }



        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
            ctrlEnvases.CargarEventos(CtrlEnvases_Click);
        }

        private void CargarImagenes()
        {
            Imagen.CargarBasicas(this);
            CargarImagenesSabores();
        }

        private void CargarImagenesSabores()
        {
            foreach (Control item in groupBoxSabores.Controls)
            {
                if (item is not null)
                {
                    try
                    {
                        item.BackgroundImage = Imagen.CargarImagenSabor(item.Text);
                    }
                    catch (Exception e)
                    {
                        Log.GuardarExcepcion("Error al cargar BackgroundImage", e);
                    }

                }
            }
        }

        internal void CtrlSabor_Click(object sender, EventArgs e)
        {
            if(sender is Button boton && boton.GetContainerControl() is CtrlSabor ctrlSabor)
            {
                flowLayoutPanelSabores.Controls.Remove(ctrlSabor);
            }
        }

        private void ManejadorDeOpciones(string opcion)
        {
            if (opcion is not null && opcion != "buttonVentas")
            {
                if (opcion == "buttonSalir") opcion = "buttonInicio";

                opcionActual = opcion;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ManejadorDeOpcionesEnvases(string opcion)
        {
            try
            {
                flowLayoutPanelSabores.Controls.Clear();
                opcion = opcion.Replace("pictureBox", "");
                envaseActual = Empresa.EnvasePorNombre(opcion);
                pictureBoxEnvase.Image = Imagen.CargarImagenEnvase(opcion);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion($"Error al CargarImagenPng", e);
            }
        }




        public void CtrlEnvases_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is PictureBox picture)
            {
                ManejadorDeOpcionesEnvases(picture.Name);
            }

        }

        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is Button boton)
            {
                ManejadorDeOpciones(boton.Name);
            }

        }

        private void ButtonSabor_Click(object sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                CargarPanelSabor(boton.Text);
            }
        }

        private void CargarPanelSabor(string sabor)
        {
            CtrlSabor ctrlSabor;
            if (envaseActual is not null)
            {
                  if (flowLayoutPanelSabores.Controls.Count < envaseActual.CantSabores)
                {
                    ctrlSabor = new CtrlSabor(sabor);
                    ctrlSabor.CargarEventos(this);
                    flowLayoutPanelSabores.Controls.Add(ctrlSabor);
                }
                  else MessageBox.Show($"Maximo {envaseActual.CantSabores} sabores para el envase de {envaseActual.Nombre}");
            }
            else MessageBox.Show("Debe seleccionar un envase\nantes de elejir los sabores");
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


    }
}
