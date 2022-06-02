using MisFunciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Empresa
    {

        /*
        /// Se aplica lo aprendido en la Clase 10 - Excepciones.
        /// Se aplica lo aprendido en la Clase 11 - Pruebas Unitarias.
        /// Se aplica lo aprendido en la Clase 12 - Tipos Genéricos.
        /// Se aplica lo aprendido en la Clase 13 - Interfaces.
        /// Se aplica lo aprendido en la clase 14 - Serializacion
        */

        

        private static string nombre;
        private static Empleado usuarioActual;
        private static Cliente clienteActual;
        private static List<Sabor> sabores;
        private static List<Envase> envases;
        private static List<Pedido> pedidos;
        private static List<Cliente> clientes;
        private static List<Empleado> empleados;


        static Empresa()
        {
            sabores = new List<Sabor>();
            envases = new List<Envase>();
            pedidos = new List<Pedido>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
        }


        public static string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public static Empleado UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }
        public static Cliente ClienteActual
        {
            get { return clienteActual; }
            set { clienteActual = value; }
        }
        public static List<Sabor> Sabores
        {
            get { return sabores; }
            set { sabores = value; }
        }
        public static List<Envase> Envases
        {
            get { return envases; }
            set { envases = value; }
        }
        public static List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }
        public static List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public static List<Empleado> Empleados
        {
            get { return empleados; }
            set { empleados = value; }
        }



        public static Envase EnvasePorNombre(string nombre)
        {
            foreach (Envase item in envases)
            {
                if (item is not null && item.Nombre == nombre) return item;
            }
            return null;
        }


        internal static bool EsDniRepetido(int dni)
        {
            List<Persona> lista = new List<Persona>();

            lista.AddRange(empleados);
            lista.AddRange(clientes);

            foreach (Persona item in lista)
            {
                if (item is not null && item.Dni == dni) return false;
            }

            return true;
        }



        public static void RespaldarInfo()
        {
            GuardarListaEmpleados();
            GuardarListaClientes();
            GuardarListaSabores();
            GuardarListaEnvases();
        }
        public static void RecuperarInfo()
        {
            CargarListaEmpleados();
            CargarListaClientes();
            CargarListaEnvases();
            CargarListaSabores();
        }



        private static void GuardarBase<T>(IPersistencia<T> lista, string ruta, T datos)
        {
            try
            {
                lista.Guardar(ruta, datos);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static T CargarBase<T>(IPersistencia<T> lista, string ruta)
        {
            try
            {
                return lista.Leer(ruta);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private static void CargarListaSabores()
        {
            string ruta = Ruta.ArchivoJson(Ruta.Base, "Lista de Sabores");
            try
            {
                sabores = CargarBase(new SerializadorJson<List<Sabor>>(), ruta);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de sabores", e));
            }
        }
        private static void CargarListaEnvases()
        {
            string ruta = Ruta.ArchivoJson(Ruta.Base, "Lista de Envases");
            try
            {
                envases = CargarBase(new SerializadorJson<List<Envase>>(), ruta);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de envases", e));
            }
        }
        private static void CargarListaEmpleados()
        {
            string ruta = Ruta.ArchivoXml(Ruta.Base, "Lista de Empleados");
            List<Persona> lista;
            try
            {
                lista = CargarBase(new SerializadorXml<List<Persona>>(),ruta);

                foreach (Persona item in lista)
                {
                    if (item is not null && item is Empleado empleado) empleados.Add(empleado);
                }
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de empleados", e));
            }
        }
        private static void CargarListaClientes()
        {

            string ruta = Ruta.ArchivoXml(Ruta.Base, "Lista de clientes");
            List<Persona> lista;
            try
            {
                lista = CargarBase(new SerializadorXml<List<Persona>>(), ruta);

                foreach (Persona item in lista)
                {
                    if (item is not null && item is Cliente cliente) clientes.Add(cliente);
                }
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de clientes", e));
            }
        }


        private static void GuardarListaEmpleados()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                lista.AddRange(Empleados);
                GuardarListaPersonas(lista, "Empleados");
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al guardar lista de empleados", e));
            }
        }
        private static void GuardarListaClientes()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                lista.AddRange(Clientes);
                GuardarListaPersonas(lista, "Clientes");
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al guardar lista de clientes", e));
            }

        }
        private static void GuardarListaPersonas(List<Persona> lista, string tipo)
        {
            string ruta = Ruta.ArchivoXml(Ruta.Base, $"Lista de {tipo}");

            try
            {
                GuardarBase(new SerializadorXml<List<Persona>>(), ruta, lista);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void GuardarListaSabores()
        {
            string ruta = Ruta.ArchivoJson(Ruta.Base, "Lista de Sabores");
            try
            {
                GuardarBase(new SerializadorJson<List<Sabor>>(), ruta, sabores);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al guardar lista de sabores", e));
            }
        }
        private static void GuardarListaEnvases()
        {
            string ruta = Ruta.ArchivoJson(Ruta.Base, "Lista de Envases");
            try
            {
                GuardarBase(new SerializadorJson<List<Envase>>(), ruta, envases);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al guardar lista de envases", e));
            }
        }



    }
}
