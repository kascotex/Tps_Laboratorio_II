using MisFunciones;
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
        public string DniString
        {
            get { return string.Format(" DNI : {0}", dni); }
        }




        public static bool EsNombreValido(string nombre)
        {
            if (nombre is not null) nombre = nombre.Trim();
            return MfString.SonLetras(nombre) && nombre.Count() > 1;
        }


        public static string EsPersonaValida(string nombre, string apellido, int dni, bool agregar)
        {
            string msj = string.Empty;

            if (!EsNombreValido(nombre)) msj += "El nombre es invalido. (solo letras y al menos dos carecteres)\n";
            if (!EsNombreValido(apellido)) msj += "El apellido es invalido. (solo letras y al menos dos carecteres)\n";
            if (!MfBasic.EnRango(dni, 100000, 99999999)) msj += "El Dni es invalido. (solo numeros entre 6 u 8 digitos)\n";
            if (agregar && !Empresa.EsDniRepetido(dni)) msj += "El Dni es invalido. (Este Dni ya senencuentra registrado)\n";

            return msj;
        }


    }
}
