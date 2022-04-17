using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }



        /// <summary>
        /// Efectua la operacion indicada en el comboBoxOperador, con los valores
        /// tomados de las propiedades Texto de los textBoxNumero1 y textBoxNumero2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string faltanDatos = FaltanDatos();

            if (faltanDatos == string.Empty)
            {
                resultado = Operar(textBoxNumero1.Text, textBoxNumero2.Text, comboBoxOperador.Text);

                if (resultado != double.MinValue)
                {
                    SetConversores(true);
                    labelResultado.Text = resultado.ToString();
                }
                else labelResultado.Text = "ERROR DIV/0!";

                listBoxOperaciones.Items.Add($"{textBoxNumero1.Text} {comboBoxOperador.Text} {textBoxNumero2.Text} = {labelResultado.Text}");
            }
            else MessageBox.Show(faltanDatos, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Opera los dos numeros recibidos segun el operador dado.
        /// </summary>
        /// <param name="numero1">Primer valor a operar</param>
        /// <param name="numero2">Segundo valor a operar</param>
        /// <param name="operador">Tipo de operacion a realizar</param>
        /// <returns>El resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador[0]);
        }



        /// <summary>
        /// Evalua el valor en de la propiedad Text del labelResultado
        /// y, lo convierte en binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConvertirEnBinario_Click(object sender, EventArgs e)
        {
            int num;
            string msj = "Sólo los números enteros se podrán convertir a Binarios.\n\n";

            if (int.TryParse(labelResultado.Text, out num))
            {
                SetConversores(true, false);
                labelResultado.Text = new Operando().DecimalBinario(num);
                listBoxOperaciones.Items.Add($"{num} = {labelResultado.Text}[bin]");
            }
            else MessageBox.Show($"{msj}{labelResultado.Text} No se puede convertir a Binario.", "Convertir a Binario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Evalua el valor en de la propiedad Text del labelResultado
        /// y, si es posible, lo convierte en decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConvertirEnDecimal_Click(object sender, EventArgs e)
        {
            string num = new Operando().BinarioDecimal(labelResultado.Text);

            if (num != "Valor inválido")
            {
                SetConversores(false, true);
                listBoxOperaciones.Items.Add($"{labelResultado.Text}[bin] = {num}");
                labelResultado.Text = num;
            }
            else MessageBox.Show($"{labelResultado.Text} No es un numero Binario.", "Convertir a Entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        /// <summary>
        /// Borrará las propiedades Text de los textBoxNumero, 
        /// comboBoxOperador y labelResultado
        /// </summary>
        private void Limpiar()
        {
            textBoxNumero1.Text = textBoxNumero2.Text = string.Empty;
            labelResultado.Text = "";
            comboBoxOperador.SelectedIndex = -1;
            SetConversores(false);
        }
        /// <summary>
        /// Borra los datos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }




        /// <summary>
        /// Pide verificacion antes de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado is DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }




        // metodos hechos para no repetir codigo
        private void SetConversores(bool permitir)
        {
            SetConversores(permitir, permitir);
        }
        private void SetConversores(bool aDecimal, bool aBinario)
        {
            buttonConvertirEnBinario.Enabled = aBinario;
            buttonConvertirEnDecimal.Enabled = aDecimal;
        }


        // metodo hecho para brindar ayuda al usuario
        private string FaltanDatos()
        {
            string msj = string.Empty;

            if (string.IsNullOrWhiteSpace(textBoxNumero1.Text))
            {
                msj += "El primer operando debe tener un valor numerico\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxNumero2.Text))
            {
                msj += "El segundo operando debe tener un valor numerico\n";
            }
            if (comboBoxOperador.SelectedIndex < 0)
            {
                msj += "Debe elejir una operacion a realizar\n";
            }
            if (msj != string.Empty)
            {
                msj = "Para poder operar:\n\n" + msj;
            }

            return msj;
        }



    }
}
