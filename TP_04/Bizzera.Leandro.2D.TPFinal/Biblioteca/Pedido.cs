using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    public class Pedido
    {

        static int ultimoPedido;

        private int numPedido;
        private int numSocioCliente;
        private DateTime fecha;
        private List<Helado> helados;



        public Pedido()
        {
            numPedido = ++ultimoPedido;
            helados = new List<Helado>();
            fecha = DateTime.Now;
        }
        public Pedido(int numSocioCliente, List<Helado> helados)
            : this()
        {
            this.numSocioCliente = numSocioCliente;
            this.helados = helados;
        }

        public Pedido(int idCliente, List<Helado> helados, DateTime fecha)
            : this(idCliente, helados)
        {
            this.fecha = fecha;
        }



       
        public static int UltimoPedido
        {
            get { return ultimoPedido; }
        }
        public int NumPedido
        {
            get { return numPedido; }
            set
            {
                if (value > numPedido) numPedido = value;
                numPedido = value;
            }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public float Total
        {
            get { return CalcularTotal(); }
        }

        private float CalcularTotal()
        {
            float total = 0;
            foreach (Helado item in helados)
            {
                if (item is not null) total += item.Envase.Precio;
            }
            return total;
        }

        public List<Helado> Helados { get => helados; set => helados = value; }
        public int IdCliente { get => numSocioCliente; set => numSocioCliente = value; }       

       
       
        public override string ToString()
        {
            return $"Ticket N° {numPedido} {fecha} -  {Empresa.ClientePorNumSocio(IdCliente).NombreCompleto} ${Total}";
        }

    }
}
