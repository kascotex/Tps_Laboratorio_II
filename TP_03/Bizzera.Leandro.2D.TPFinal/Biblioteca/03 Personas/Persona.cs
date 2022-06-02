using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Cliente))]
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;


        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }



        public Persona()
        {
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string NombreCompleto
        {
            get { return $"{Apellido}, {Nombre}"; }
        }
        public int Dni
        {
            get { return dni; }
            set { if (Empresa.EsDniRepetido(value)) dni = value; }
        }
        public string DnIString
        {
            get { return string.Format(" DNI : {0}", dni); }
        }






        public static string IdToString(int id)
        {
            return string.Format(" ID : {0:0000}", id);
        }

    }
}
