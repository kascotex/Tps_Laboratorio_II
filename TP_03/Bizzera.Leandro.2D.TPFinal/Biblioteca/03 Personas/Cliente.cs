using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        static int ultimonumSocio;

        private int puntos;
        private int numSocio;
        private DateTime alta;
        private List<int> pedidos;



        public Cliente()
        {
        }
        public Cliente(string nombre, string apellido, int dni)
           : base(nombre, apellido, dni)
        {
            numSocio = ++ultimonumSocio;
            alta = DateTime.Now;
            pedidos = new List<int>();
        }
        public Cliente(string nombre, string apellido, int dni, DateTime alta)
            : this(nombre, apellido, dni)
        {
            this.alta = alta;
        }

        public static int UltimonumSocio
        {
            get { return ultimonumSocio; }
        }
        public int NumSocio
        {
            get { return numSocio; }
            set
            {
                if (value > ultimonumSocio) ultimonumSocio = value + 1;
                numSocio = value;
            }
        }
        public string NumSocioString
        {
            get { return IdToString(NumSocio); }
        }
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public DateTime Alta
        {
            get { return alta; }
            set { alta = value; }
        }
        public List<int> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }


        public static string IdToString(int numSocio)
        {
            return string.Format("{0:0000}", numSocio);
        }
        private void CalcularPuntaje(Pedido pedido)
        {

        }


    }
}
