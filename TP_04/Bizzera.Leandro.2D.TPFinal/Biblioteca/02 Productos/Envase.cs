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
        private float precio;


        public Envase()
        {
            id = ++ultimoId;
        }
        public Envase(string nombre, int cantSabores, float precio)
            :this()
        {
            this.nombre = nombre;
            this.cantSabores = cantSabores;
            this.precio = precio;
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

        public float Precio { get => precio; set => precio = value; }
    }
}
