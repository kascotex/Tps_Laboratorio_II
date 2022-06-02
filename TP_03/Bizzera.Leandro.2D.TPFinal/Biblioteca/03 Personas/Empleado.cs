using MisFunciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        static int ultimoId;

        public enum EPuesto { Administrativo, Empleado };

        private int id;
        private int dni;
        private int edad;
        private EPuesto puesto;
        private string clave;
        private bool estaLogeado;


        public Empleado()
        {
        }

        private Empleado(string nombre, string apellido)
            : base(nombre, apellido)
        {
            id = ++ultimoId;
            puesto = EPuesto.Empleado;
            estaLogeado = false;
        }

        public Empleado(int dni, int edad, string nombre, string apellido, EPuesto puesto)
            : this(nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.puesto = puesto;
        }


        public string IdString
        {
            get { return IdToString(id); }
        }
        public string DnIString
        {
            get { return string.Format(" DNI : {0}", dni); }
        }
        public string Clave
        {
            set { clave = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value > ultimoId) ultimoId = value + 1;
                id = value;
            }
        }        
        public int Dni
        {
            get { return dni; }
            set { if (Empresa.EsDniValido(value)) dni = value; }
        }
        public EPuesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public bool EstaLogeado
        {
            get { return estaLogeado; }
            set { estaLogeado = value; }
        }

        public static string IdToString(int id)
        {
            return string.Format(" ID : {0:0000}", id);
        }
        public static string NextIdString()
        {
            return IdToString(NextId());
        }
        public static int NextId()
        {
            return ultimoId + 1;
        }

        public static string EsEmpleadoValido(string nombre, string apellido, int edad, int dni, bool agregar)
        {
            string msj = string.Empty;

            if (!EsNombreValido(nombre)) msj += "El nombre es invalido. (solo letras y al menos dos carecteres)\n";
            if (!EsNombreValido(apellido)) msj += "El apellido es invalido. (solo letras y al menos dos carecteres)\n";
            if (!MfBasic.EnRango(edad, 16, 99)) msj += "La Edad es invalida. (solo numeros desde 16 a 99 años)\n";
            if (!MfBasic.EnRango(dni, 100000, 99999999)) msj += "El Dni es invalido. (solo numeros entre 6 u 8 digitos)\n";
            if (agregar && !Empresa.EsDniValido(dni)) msj += "El Dni es invalido. (Este Dni ya senencuentra registrado)\n";

            return msj;
        }
        public string Editar(string nombre, string apellido, int edad, int dni, EPuesto puesto)
        {
            string msj = EsEmpleadoValido(nombre, apellido, edad, dni, false);

            if (string.IsNullOrEmpty(msj))
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.dni = dni;
                this.puesto = puesto;
            }

            return msj;
        }
        public static bool EsNombreValido(string nombre)
        {
            return MfString.SonLetras(nombre) && nombre.Count() > 1;
        }

    }
}
