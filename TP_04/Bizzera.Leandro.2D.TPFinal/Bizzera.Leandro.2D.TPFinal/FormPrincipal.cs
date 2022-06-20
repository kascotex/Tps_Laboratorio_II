using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class FormPrincipal : Form
    {
        //  private Button opcionActual;
        private bool cargaFinalizada;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Empresa.EventoPedidoAleatorio += new PedidoAleatorioHandler(Empresa.PedidoAleatorio);
            CargarImagenes();
            // Harcodear();
            MostrarStatusLabel();
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
            Task.Run(CargarBase);
            
        }

        private void Aleatorio()
        {
            while (true)
            {
                Thread.Sleep(10000);
                Empresa.PedidoAleatorio();
                Empresa.RespaldarClientes();
            }


        }

        private void Harcodear()
        {
            Hardcodeo.CrearHeladeria();
        }
        private void CargarBase()
        {
            Task.Run(MostrarCartel);
            Empresa.RecuperarInfo();
            cargaFinalizada = true;
            Task.Run(Aleatorio);
            if (InvokeRequired) BeginInvoke(new Action(MostrarInfo));
            else MostrarInfo();
        }
        private void MostrarCartel()
        {
            while (!cargaFinalizada)
            {
                Thread.Sleep(200);
                if (InvokeRequired) BeginInvoke(new Action(CartelCargando));
                else CartelCargando();
            }
        }
        private void CartelCargando()
        {
            switch (labelInfo.Text)
            {
                case "Cargando los datos .....":
                    labelInfo.Text = "Cargando los datos  ....";
                    break;
                case "Cargando los datos  ....":
                    labelInfo.Text = "Cargando los datos . ...";
                    break;
                case "Cargando los datos . ...":
                    labelInfo.Text = "Cargando los datos .. ..";
                    break;
                case "Cargando los datos .. ..":
                    labelInfo.Text = "Cargando los datos ... .";
                    break;
                case "Cargando los datos ... .":
                    labelInfo.Text = "Cargando los datos .... ";
                    break;
                case "Cargando los datos .... ":
                    labelInfo.Text = "Cargando los datos .....";
                    break;

            }
        }

        private void MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de Empleados: {Empresa.Empleados.Count}");
            sb.AppendLine($"Cantidad de Clientes: {Empresa.Clientes.Count}");
            sb.AppendLine($"Cantidad de Envases: {Empresa.Envases.Count}");
            sb.AppendLine($"Cantidad de Sabores: {Empresa.Sabores.Count}");

            labelInfo.Text = sb.ToString();
            MessageBox.Show("Carga Finalizada");
            labelInfo.Visible = false;
        }

        private void CargarImagenes()
        {
            Imagen.CargarBasicas(this);
        }

        /// <summary>
        /// Actualiza el StatusLabel con el nombre del Cliente seleccionado
        /// </summary>
        private void MostrarStatusLabel()
        {
            if (Empresa.ClienteActual is null)
            {
                statusLabel.Text = "Ningún Cliente Seleccionado";
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
            switch (opcion)
            {
                case "buttonEmpleados":
                    MostrarForm(new FormEmpleados());
                    break;
                case "buttonVentas":
                    MostrarForm(new FormVentas());
                    break;
                case "buttonClientes":
                    MostrarForm(new FormClientes());
                    break;
                case "buttonHerramientas":
                    MostrarForm(new FormHerramientas());
                    break;
                case "buttonSalir":
                    Close();
                    break;
                default:
                    break;
            }
        }


        private void MostrarForm(Form form)
        {
            if (form is IControlOpcionActual f)
            {
                Hide();
                form.ShowDialog();
                Show();
                MostrarStatusLabel();
                ManejadorDeOpciones(f.OpcionActual);
            }
        }


        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (cargaFinalizada)
            {
                if (sender is Control ctrl && ctrl is Button boton)
                {
                    ManejadorDeOpciones(boton.Name);
                }
            }
            else MessageBox.Show("Aguarde a que finalize la carga de datos.");
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
