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
    public partial class FormVentas : Form, IControlOpcionActual
    {
        private string opcionActual;
        Envase envaseActual;
        Image inicial;
        List<Sabor> sabores;
        List<Helado> helados;

        public FormVentas()
        {
            InitializeComponent();
        }


        public string OpcionActual
        {
            get { return opcionActual; }
        }


        private void FormVentas_Load(object sender, EventArgs e)
        {
            sabores = new List<Sabor>();
            helados = new List<Helado>();
            CargarImagenes();
            MostrarStatusLabel();
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
            ctrlEnvases.CargarEventos(CtrlEnvases_Click);
        }

        private void CargarImagenes()
        {
            inicial = pictureBoxEnvase.Image;
            Imagen.CargarBasicas(this);
            CargarImagenesSabores();
        }

        /// <summary>
        /// Actualiza el StatusLabel con el nombre del Cliente seleccionado
        /// </summary>
        private void MostrarStatusLabel()
        {
            if (Empresa.ClienteActual is null)
            {
                statusLabel.Text = "Ningun Cliente Seleccionado";
                statusStrip.BackColor = Color.Silver;
            }
            else
            {
                statusLabel.Text = $"Cliente Seleccionado: [{Empresa.ClienteActual.NombreCompleto}]";
                statusStrip.BackColor = Color.Orange;
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

        private void ManejadorDeOpcionesEnvases(string opcion)
        {
            if (Empresa.ClienteActual is not null)
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
            else MessageBox.Show("Debe seleccionar un cliente\nantes de realizar un pedido");
        }



        internal void CtrlSabor_Click(object sender, EventArgs e)
        {
            if (sender is Button boton && boton.GetContainerControl() is CtrlSabor ctrlSabor)
            {
                flowLayoutPanelSabores.Controls.Remove(ctrlSabor);
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



        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ButtonConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (envaseActual is not null && flowLayoutPanelSabores.Controls.Count > 0)
            {
                CrearPedido();
                ManejadorDeOpciones("buttonInicio");
            }
            else MessageBox.Show("Debe seleccionar un envase y elejir sabores\n para poder realizar un pedido");
        }

        private void CrearPedido()
        {
            if (Empresa.ClienteActual is not null && CrearHelado())
            {
                Empresa.Pedidos.Add(new Pedido(Empresa.ClienteActual.NumSocio, helados));
                MessageBox.Show("Pedido confirmado.");
            }
            else MessageBox.Show("No se pudo confirmar el pedido.");
        }

        private bool CrearHelado()
        {
            foreach (CtrlSabor item in flowLayoutPanelSabores.Controls)
            {
                if (item is not null) sabores.Add(Empresa.SaborPorNombre(item.Sabor));
            }

            if (envaseActual is not null)
            {
                helados.Add(new Helado(envaseActual, sabores));
                return true;
            }
            return false;
        }


        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            pictureBoxEnvase.Image = inicial;
            flowLayoutPanelSabores.Controls.Clear();
        }
    }
}
