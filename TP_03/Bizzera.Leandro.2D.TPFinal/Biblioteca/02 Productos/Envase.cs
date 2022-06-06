using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Envase
    {
        static int ultimoId;

        private int id;
        private string nombre;
        private int cantSabores;


        public Envase()
        {
        }
        public Envase(string nombre, int cantSabores)
        {
            id = ++ultimoId;
            this.nombre = nombre;
            this.cantSabores = cantSabores;
        }



        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value > ultimoId) ultimoId = value;
                id = value;
            }
        }
        public int CantSabores
        {
            get { return cantSabores; }
            set { cantSabores = value; }
        }






    }
}
