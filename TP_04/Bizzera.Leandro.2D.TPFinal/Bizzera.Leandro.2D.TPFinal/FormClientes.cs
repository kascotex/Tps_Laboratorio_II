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

        private bool CrearCliente()
        {
            string msj = string.Empty;
            string nombre = string.Empty;
            string apellido = string.Empty;
            string[] nombreCompleto = textBoxNombre.Text.Split(',');
            int.TryParse(textBoxDni.Text, out int dni);

            if (nombreCompleto.Length == 2)
            {
                apellido = nombreCompleto[0];
                nombre = nombreCompleto[1];
                msj += Cliente.EsClienteValido(nombre, apellido, dni);
            }
            else msj += "Ingre el Apellido y luego el Nombre separados por una coma.\n";


            if (string.IsNullOrEmpty(msj))
            {
                Empresa.Clientes.Add(new Cliente(nombre.Trim(), apellido.Trim(), dni));
                MessageBox.Show($"Agregado Cliente: {apellido}, {nombre}");
                return true;
            }

            MessageBox.Show(msj);
            return false;
        }




        private void OpcionBuscar()
        {
            labelTitulo.Text = "Buscar Cliente";
            labelTitulo.BackColor = Color.LightSkyBlue;
            buttonModo.Text = "Agregar";
            buttonModo.BackColor = Color.LightGreen;
            buttonEliminar.Visible = buttonSeleccionar.Visible = true;
            buttonCancelar.Visible = buttonAgregar.Visible = false;
            labelSocio.Enabled = textBoxNumSocio.Enabled = true;
        }
        private void OpcionAgregar()
        {
            labelTitulo.Text = "Agregar Cliente";
            labelTitulo.BackColor = Color.LightGreen;
            buttonModo.Text = "Buscar";
            buttonModo.BackColor = Color.LightSkyBlue;
            buttonEliminar.Visible = buttonSeleccionar.Visible = false;
            buttonCancelar.Visible = buttonAgregar.Visible = true;
            textBoxNumSocio.Text = Cliente.IdToString(Cliente.UltimonumSocio + 1);
            labelSocio.Enabled = textBoxNumSocio.Enabled = false;
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
            if (buttonSeleccionar.Visible && sender is TextBox tb)
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





        private void ButtonModo_Click(object sender, EventArgs e)
        {
            LimpiarGroupBox();
            if (buttonModo.Text == "Agregar") OpcionAgregar();
            else OpcionBuscar();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (cliente is not null && Mensaje.EstaSeguroQue($"desea dar de baja a:\n{cliente.NombreCompleto}"))
            {
                cliente.EstaActivo = false;
                if (!Empresa.ClientesLocal.Contains(cliente))
                {
                    Empresa.Clientes.Remove(cliente);
                    Empresa.ClientesLocal.Add(cliente);
                }
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

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarGroupBox();
            OpcionAgregar();
        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (CrearCliente()) CargarBuscarClientes();
        }




        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



    }
}
