using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    [XmlInclude(typeof(Envase))]
    [XmlInclude(typeof(Sabor))]
    public class Helado
    {

        private Envase envase;
        private List<Sabor> sabores;


        public Helado()
        {
        }
        public Helado(Envase envase, List<Sabor> sabores)
            :this()
        {
            sabores = new List<Sabor>();
            this.envase = envase;
            this.sabores = sabores;
        }

        public Envase Envase { get => envase; set => envase = value; }
        public List<Sabor> Sabores { get => sabores; set => sabores = value; }



    }
}
