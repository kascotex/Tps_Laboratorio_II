using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {

        private double numero;



        public Operando() : this(0)
        {
        }
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// Asigna un valor al atributo número, previa validación.
        /// </summary>
        private string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }


        /// <summary>
        /// Valida que el valor recibido sea numérico, y lo retorna en formato double.
        /// Caso contrario, retorna 0.
        /// </summary>
        /// <param name="strNumero"> Variable numerica en formato string</param>
        /// <returns>El valor string recibido en formato double,</returns>
        private double ValidarOperando(string strNumero)
        {
            strNumero = strNumero.Replace('.', ',');

            double.TryParse(strNumero, out double ret);

            return ret;
        }



        /// <summary>
        /// Valida que el array esté compuesto solamente por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True si el array esté compuesto solamente por caracteres '0' o '1',
        /// caso contrario False</returns>
        private bool EsBinario(string binario)
        {
            int i = -1;
            int len = 0;

            if (!(binario is null || (len = binario.Length) < 1))
            {
                for (i = 0; i < len; ++i)
                {
                    if (binario[i] != '0' && binario[i] != '1') break;
                }
            }
            return i == len;
        }


        /// <summary>
        /// Valida que se trate de un binario y luego convierte ese número binario a decimal. 
        /// De no ser posible retorna "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si el array recibido es Binario, el valor decimal en formato string,
        /// caso contrario "Valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string ret = "Valor inválido";
            int entero = 0;

            if (EsBinario(binario))
            {
                for (int i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
                ret = entero.ToString();
            }
            return ret;
        }


        /// <summary>
        /// Convierte un número decimal a binario, en caso de ser posible.
        /// Caso contrario retorna "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string binario = "";
            int num = Math.Abs((int)numero);

            if (num == 0) return "0";

            while (num > 0)
            {
                binario = (num % 2).ToString() + binario;
                num /= 2;
            }

            return binario;
        }
        /// <summary>
        /// Convierte un número decimal a binario, en caso de ser posible.
        /// Caso contrario retorna "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string ret = "Valor inválido";

            if (double.TryParse(numero, out double num))
            {
                ret = DecimalBinario(num);
            }

            return ret;
        }

       
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator /(Operando num1, Operando num2) 
        {
            if (num2.numero == 0) return double.MinValue;
            return num1.numero / num2.numero;
        }




    }
}
