using System;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida que el operador recibido sea +, -, / ó *. Caso contrario retorna +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            string operadores = "-/*";

            if (operadores.Contains(operador)) return operador;

            return '+';
        }


        /// <summary>
        /// Valida y realiza la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador"> * - / + </param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double ret;

            switch (ValidarOperador(operador))
            {
                case '-':
                    {
                        ret = num1 - num2;
                    }
                    break;

                case '*':
                    {
                        ret = num1 * num2;
                    }
                    break;

                case '/':
                    {
                        ret = num1 / num2;
                    }
                    break;

                default:
                    {
                        ret = num1 + num2;
                    }
                    break;
            }

            return ret;
        }


    }
}
