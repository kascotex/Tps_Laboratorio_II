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
    public partial class FormClientes : Form, IControlOpcionActual
    {
        private string opcionActual;
        private Cliente cliente;


        public FormClientes()
        {
            InitializeComponent();
        }


        public string OpcionActual
        {
            get { return opcionActual; }
        }


        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            MostrarStatusLabel();
            CargarBuscarClientes();
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
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
            if (opcion is not null && opcion != "buttonClientes")
            {
                if (opcion == "buttonSalir") opcion = "buttonInicio";

                opcionActual = opcion;
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void CargarBuscarClientes()
        {
            textBoxNombre.AutoCompleteCustomSource.AddRange(Empresa.NombresDeClientes);
            textBoxDni.AutoCompleteCustomSource.AddRange(Empresa.NumerosDnisClientes);
            textBoxNumSocio.AutoCompleteCustomSource.AddRange(Empresa.NumerosSocioClientes);
        }

        /// <summary>
        /// Muestra los datos del usuario,
        /// habilita y selecciona el textBoxContrasenia
        /// </summary>
        private void MostrarCliente()
        {
            if (cliente is not null)
            {
                textBoxDni.Text = cliente.Dni.ToString();
                textBoxNombre.Text = cliente.NombreCompleto;
                textBoxNumSocio.Text = cliente.NumSocio.ToString();
            }
            else
            {
                LimpiarGroupBox();
                textBoxNombre.Text = "Cliente no encontrado.";
            }
        }

        private void LimpiarGroupBox()
        {
            foreach (Control item in groupBoxCliente.Controls)
            {
                if (item is not null && item is TextBox tb)
                {
                    tb.Text = "";
                }
            }
        }








        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is Button boton)
            {
                ManejadorDeOpciones(boton.Name);
            }
        }

        /// <summary>
        /// Cuando se abandona el textBoxNombreDeUsuario
        /// busca el usuario con el nombre de usuario ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                switch (tb.Name)
                {
                    case "textBoxNumSocio":
                        cliente = Empresa.ClientePorNumSocio(tb.Text);
                        break;
                    case "textBoxDni":
                        cliente = Empresa.ClientePorDni(tb.Text);
                        break;
                    case "textBoxNombre":
                        cliente = Empresa.ClientePorNombreCompleto(tb.Text);
                        break;
                }
                MostrarCliente();
            }
        }





        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (cliente is not null && Mensaje.EstaSeguroQue($"desea eliminar a:\n{cliente.NombreCompleto}"))
            {
                Empresa.Clientes.Remove(cliente);
                cliente = null;
                CargarBuscarClientes();
                LimpiarGroupBox();
            }
        }

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            if (cliente is not null)
            {
                Empresa.ClienteActual = cliente;
                ManejadorDeOpciones("buttonInicio");
            }
            else MessageBox.Show("Ningún Cliente seleccionado.");
        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            LimpiarGroupBox();
            if (buttonAgregar.Text == "Agregar") OpcionAgregar();
            else OpcionBuscar();
        }
        
        private void OpcionBuscar()
        {
            labelTitulo.Text = "Buscar Cliente";
            labelTitulo.BackColor = Color.LightSkyBlue;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.BackColor = Color.LightGreen;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.BackColor = Color.LightSkyBlue;
            buttonEliminar.Text = "Eliminar";
            labelSocio.Enabled = textBoxNumSocio.Enabled = true;
        }
        private void OpcionAgregar()
        {
            labelTitulo.Text = "Agregar Cliente";
            labelTitulo.BackColor = Color.LightGreen;
            buttonAgregar.Text = "Buscar";
            buttonAgregar.BackColor = Color.LightSkyBlue;
            buttonSeleccionar.Text = "Agregar";
            buttonSeleccionar.BackColor = Color.LightGreen;
            buttonEliminar.Text = "Cancelar";
            textBoxNumSocio.Text = Cliente.IdToString(Cliente.UltimonumSocio+1);
            labelSocio.Enabled = textBoxNumSocio.Enabled = false;
        }


        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
