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
        private Cliente cliente;
        private List<Helado> helados;
        private DateTime fecha;







        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }
}
