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
    public partial class FormHerramientas : Form, IControlOpcionActual
    {
        private string opcionActual;

        string rutaDelArchivo;
        string nombreDelArchivo;



        public FormHerramientas()
        {
            InitializeComponent();
        }


        public string OpcionActual
        {
            get { return opcionActual; }
        }

        private void FormHerramientas_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            MostrarStatusLabel();
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
            if (opcion is not null && opcion != "buttonHerramientas")
            {
                if (opcion == "buttonSalir") opcion = "buttonInicio";

                opcionActual = opcion;
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private string RutaDelArchivo
        {
            get { return rutaDelArchivo; }
            set
            {
                rutaDelArchivo = value;
                if (!(value is null)) nombreDelArchivo = rutaDelArchivo.Substring(rutaDelArchivo.LastIndexOf('\\') + 1);
            }
        }



        private void ImportarClientes()
        {
            if (ObtenerRutaParaCargarArchivo(Ruta.ArchivosDeTexto, "Archivo xml|*.xml"))
            {
                try
                {
                    Empresa.Clientes = new SerializadorXml<List<Cliente>>().Leer(RutaDelArchivo);
                    MessageBox.Show($"Se Cargo la lista de clientes\n con {Empresa.Clientes.Count} clientes.");
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(new Exception("Error al guardar lista de clientes", e));
                }
            }
        }
        private void ExportarClientes()
        {
            if (ObtenerRutaParaGuardarArchivo(Ruta.ArchivosDeTexto, "Archivo xml|*.xml"))
            {
                try
                {
                    new SerializadorXml<List<Cliente>>().Guardar(RutaDelArchivo, Empresa.Clientes);
                    MessageBox.Show($"Se guardo la lista de clientes\n con {Empresa.Clientes.Count} clientes.");
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(new Exception("Error al guardar lista de clientes", e));
                }
            }
        }



        private bool ObtenerRutaParaCargarArchivo(string directorioInicial, string filtro)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            ObtenerRuta(archivo, directorioInicial, filtro);
            if (RutaDelArchivo is null) return false;
            return true;
        }
        private bool ObtenerRutaParaGuardarArchivo(string directorioInicial, string filtro)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            ObtenerRuta(archivo, directorioInicial, filtro);
            if (RutaDelArchivo is null) return false;
            return true;
        }
        private void ObtenerRuta(FileDialog archivo, string directorioInicial, string filtro)
        {
            archivo.Filter = filtro;
            archivo.InitialDirectory = directorioInicial;

            if (archivo.ShowDialog() == DialogResult.OK) RutaDelArchivo = archivo.FileName;
            else RutaDelArchivo = null;
        }


        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is Button boton)
            {
                ManejadorDeOpciones(boton.Name);
            }

        }

        private void FormHerramientas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (!Mensaje.ConfirmarSalir()) e.Cancel = true;
                else
                {
                    DialogResult = DialogResult.OK;
                    opcionActual = "buttonInicio";
                }
            }
        }

        private void ButtonExportarClientes_Click(object sender, EventArgs e)
        {
            ExportarClientes();
        }

        private void ButtonImportarClientes_Click(object sender, EventArgs e)
        {
            ImportarClientes();
        }


    }
}
