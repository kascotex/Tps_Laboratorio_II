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





        private void ImportarSabores()
        {
            string msj = "Error al importar lista de sabores";

            if (ObtenerRutaParaAbrirArchivo(Ruta.Base, "Archivo json|*.json"))
            {
                try
                {
                    Empresa.Sabores = new SerializadorJson<List<Sabor>>().Leer(rutaDelArchivo);
                    msj = $"Se importo la lista de sabores\n con {Empresa.Sabores.Count} sabores.";
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(new Exception(msj, e));
                }
                finally
                {
                    MessageBox.Show(msj);
                }
            }
        }
        private void ExportarSabores()
        {
            string msj = "Error al exportar lista de sabores";

            if (ObtenerRutaParaGuardarArchivo(Ruta.Base, "Archivo json|*.json"))
            {
                try
                {
                    new SerializadorJson<List<Sabor>>().Guardar(rutaDelArchivo, Empresa.Sabores);
                    msj = $"Se exporto la lista de sabores\n con {Empresa.Sabores.Count} sabores.";
                }
                catch (Exception e)
                {
                    Log.GuardarExcepcion(new Exception(msj, e));
                }
                finally
                {
                    MessageBox.Show(msj);
                }
            }
        }



        private bool ObtenerRutaParaAbrirArchivo(string directorioInicial, string filtro)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            ObtenerRuta(archivo, directorioInicial, filtro);
            if (rutaDelArchivo is null) return false;
            return true;
        }
        private bool ObtenerRutaParaGuardarArchivo(string directorioInicial, string filtro)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            ObtenerRuta(archivo, directorioInicial, filtro);
            if (rutaDelArchivo is null) return false;
            return true;
        }
        private void ObtenerRuta(FileDialog archivo, string directorioInicial, string filtro)
        {
            archivo.Filter = filtro;
            archivo.InitialDirectory = directorioInicial;

            if (archivo.ShowDialog() == DialogResult.OK) rutaDelArchivo = archivo.FileName;
            else rutaDelArchivo = null;
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
            ExportarSabores();
        }

        private void ButtonImportarClientes_Click(object sender, EventArgs e)
        {
            ImportarSabores();
        }


    }
}
