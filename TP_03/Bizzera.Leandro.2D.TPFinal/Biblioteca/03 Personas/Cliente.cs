using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {

        private int puntos;
        private int numSocio;
        private DateTime alta;
        private List<int> pedidos;



        public Cliente(string nombre, string apellido, int numSocio) : base(nombre, apellido)
        {
            pedidos = new List<int>();
            alta = DateTime.Now;
            this.numSocio = numSocio;
        }



        public int NumSocio
        {
            get { return numSocio; }
            set { numSocio = value; }
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


        private void CalcularPuntaje(Pedido pedido)
        {

        }


    }
}
