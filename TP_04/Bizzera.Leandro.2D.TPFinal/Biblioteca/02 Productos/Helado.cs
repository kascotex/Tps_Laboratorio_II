using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
  
    public class Helado
    {

        private Envase envase;
        private List<Sabor> sabores;


        public Helado()
        {
            sabores = new List<Sabor>();
        }
        public Helado(Envase envase, List<Sabor> sabores)
            :this()
        {
            this.envase = envase;
            this.sabores = sabores;
        }

        public Envase Envase { get => envase; set => envase = value; }
        public List<Sabor> Sabores { get => sabores; set => sabores = value; }




    }
}
