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
    public partial class FormEmpleados : Form
    {
        private string opcionActual;
        CtrlEmpleado ctrlActual;


        public FormEmpleados()
        {
            InitializeComponent();
        }


        public string OpcionActual
        {
            get { return opcionActual; }
        }


        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            ctrlOpciones.CargarEventos(CtrlOpciones_Click);
            RefrescarPanelEmpleados();
            comboBoxPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuesto));
            ctrlActual = (CtrlEmpleado)flowLayoutPanelEmpleados.Controls[0];
            MostrarEmpleado(ctrlActual.Empleado);
        }

        private void ManejadorDeOpciones(string opcion)
        {
            if (opcion is not null && opcion != "buttonEmpleados")
            {
                if (opcion == "buttonSalir") opcion = "buttonInicio";

                opcionActual = opcion;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Actualiza el panel de usuarios logeados
        /// </summary>
        private void RefrescarPanelEmpleados()
        {
            flowLayoutPanelEmpleados.Controls.Clear();

            if (Empresa.Empleados is not null && Empresa.Empleados.Count > 0)
            {
                foreach (Empleado item in Empresa.Empleados)
                {
                    if (item is not null)
                    {
                        CtrlEmpleado ctrlEmpleado = new CtrlEmpleado(item);
                        ctrlEmpleado.CargarEventos(this);
                        flowLayoutPanelEmpleados.Controls.Add(ctrlEmpleado);
                    }
                }
            }
        }


        private void MostrarEmpleado(Empleado empleado)
        {
            if (labelId.Text != Empleado.NextIdString()) labelId.Text = empleado.IdString;
            textBoxNombre.Text = empleado.Nombre;
            textBoxApellido.Text = empleado.Apellido;
            textBoxDni.Text = empleado.DnIString;
            numericUpDownEdad.Value = empleado.Edad;
            comboBoxPuesto.SelectedItem = empleado.Puesto;
        }


        private bool CrearEmpleado()
        {
            string msj;

            Empleado.EPuesto puesto = (Empleado.EPuesto)comboBoxPuesto.SelectedValue;
            int.TryParse(textBoxDni.Text.Remove(0, 6), out int dni);
            int edad = (int)numericUpDownEdad.Value;
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;

            msj = Empleado.EsEmpleadoValido(nombre, apellido, edad, dni,true);

            if (string.IsNullOrEmpty(msj))
            {
                Empresa.Empleados.Add(new Empleado(dni, edad, nombre, apellido, puesto));
                return true;
            }

            MessageBox.Show(msj);
            return false;
        }


        private bool EditarEmpleado(Empleado empleado)
        {
            string msj;
              
            Empleado.EPuesto puesto = (Empleado.EPuesto)comboBoxPuesto.SelectedValue;
            int.TryParse(textBoxDni.Text.Remove(0, 6), out int dni);
            int edad = (int)numericUpDownEdad.Value;
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;

            msj = empleado.Editar(nombre, apellido, edad, dni, puesto);

            if (string.IsNullOrEmpty(msj)) return true;

            MessageBox.Show(msj);
            return false;
        }

        private void LimpiarGroupBox(int id)
        {
            labelId.Text = Empleado.IdToString(id);
            numericUpDownEdad.Value = 20;
            comboBoxPuesto.Text = Empleado.EPuesto.Empleado.ToString();

            foreach (Control item in groupBoxEditar.Controls)
            {
                if (item is not null && item is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }
        private void LimpiarGroupBox()
        {
            LimpiarGroupBox(Empleado.NextId());
        }

        private bool HabilitarEdicion(bool habilitar)
        {
            buttonEditar.Visible = !habilitar;
            groupBoxEditar.Enabled = habilitar;

            if (habilitar) HabilitarEdicion();
            else
            {
                buttonAgregar.Text = "Agregar";
                buttonEliminar.Text = "Eliminar";
            }
            return !habilitar;
        }
        private void HabilitarEdicion()
        {
            buttonAgregar.Text = "Confirmar";
            buttonEliminar.Text = "Cancelar";
        }




        public void CtrlOpciones_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl is Button boton)
            {
                ManejadorDeOpciones(boton.Name);
            }

        }

        public void CtrlEmpleado_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.GetContainerControl() is CtrlEmpleado ctrlEmpleado)
            {
                ctrlActual = ctrlEmpleado;
                MostrarEmpleado(ctrlEmpleado.Empleado);
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (!buttonEditar.Visible)
            {
                HabilitarEdicion(buttonEditar.Visible);
                LimpiarGroupBox(0);
            }
            else if (ctrlActual is not null && Mensaje.EstaSeguroQue($"desea eliminar a:\n{ctrlActual.Empleado.NombreCompleto}?"))
            {
                Empresa.Empleados.Remove(ctrlActual.Empleado);
                RefrescarPanelEmpleados();
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

            if (!buttonEditar.Visible)
            {
                if ((labelId.Text == Empleado.NextIdString() && CrearEmpleado()) ||
                 (labelId.Text != Empleado.NextIdString() && EditarEmpleado(ctrlActual.Empleado)))
                {
                    HabilitarEdicion(buttonEditar.Visible);
                    RefrescarPanelEmpleados();
                }
            }
            else
            {
                LimpiarGroupBox();
                HabilitarEdicion(buttonEditar.Visible);
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(buttonEditar.Visible);
        }



        private void Form_FormClosing(object sender, FormClosingEventArgs e)
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







    }
}
