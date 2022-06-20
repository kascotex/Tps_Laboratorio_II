using MisFunciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Empresa
    {


        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;


        private static string nombre;
        private static Empleado usuarioActual;
        private static Cliente clienteActual;
        private static List<Sabor> sabores;
        private static List<Envase> envases;
        private static List<Pedido> pedidos;
        private static List<Cliente> clientesBase;
        private static List<Cliente> clientesLocal;
        private static List<Empleado> empleados;

        public static event EventoAleatorioHandler NotificadorDeGuardado;

        static Empresa()
        {
            sabores = new List<Sabor>();
            envases = new List<Envase>();
            pedidos = new List<Pedido>();
            clientesBase = new List<Cliente>();
            clientesLocal = new List<Cliente>();
            empleados = new List<Empleado>();

            cadenaConexion = @"Data Source=DESKTOP-8IDHMHG\MSSQLSERVER06;Initial Catalog=HELADERIA_DB;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);

            try
            {
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al conectar HELADERIA_DB", e));
            }

        }



        public static string CadenaConexion { get => cadenaConexion; }
        public static SqlCommand Comando { get => comando; }
        public static SqlConnection Conexion { get => conexion; }
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
            get
            {
                List<Cliente> lista = new List<Cliente>();
                lista.AddRange(clientesBase);
                lista.AddRange(clientesLocal);

                return lista;
            }
            set { value = clientesLocal; }
        }
        public static List<Cliente> ClientesLocal
        { get => clientesLocal; }
        public static List<Empleado> Empleados
        {
            get { return empleados; }
            set { empleados = value; }
        }
        public static string[] NombresDeClientes
        {
            get
            {
                int i = 0;
                string[] lista = new string[Clientes.Count];
                foreach (Cliente item in Clientes)
                {
                    if (item is not null && item.EstaActivo) lista[i++] = item.NombreCompleto;
                }
                return lista;
            }
        }
        public static string[] ApellidosDeClientes
        {
            get
            {
                int i = 0;
                string[] lista = new string[Clientes.Count];
                foreach (Cliente item in Clientes)
                {
                    if (item is not null && item.EstaActivo) lista[i++] = item.Apellido;
                }
                return lista;
            }
        }
        public static string[] NumerosDnisClientes
        {
            get
            {
                int i = 0;
                string[] lista = new string[Clientes.Count];
                foreach (Cliente item in Clientes)
                {
                    if (item is not null && item.EstaActivo) lista[i++] = item.Dni.ToString();
                }
                return lista;
            }
        }
        public static string[] NumerosSocioClientes
        {
            get
            {
                int i = 0;
                string[] lista = new string[Clientes.Count];
                foreach (Cliente item in Clientes)
                {
                    if (item is not null && item.EstaActivo) lista[i++] = item.NumSocio.ToString();
                }
                return lista;
            }
        }


        public static Envase EnvasePorNombre(string nombre)
        {
            return envases.FiltrarElemento(e => e.Nombre == nombre);
        }
        public static Sabor SaborPorNombre(string nombre)
        {
            return sabores.FiltrarElemento(s => s.Nombre == nombre);
        }


        /// <summary>
        /// Busca un cliente por su nombre
        /// </summary>
        /// <param name="nombreCompleto">El nombre de cliente a buscar</param>
        /// <returns>El cliente que coincide con el nombre pasado como
        /// argumento o <see langword="null"></see> si no hay coincidencia</returns>
        public static Cliente ClientePorNombreCompleto(string nombreCompleto)
        {
            return Clientes.FiltrarElemento(c => c.NombreCompleto == nombreCompleto);
        }

        /// <summary>
        /// Busca un cliente por su numero de Dni
        /// </summary>
        /// <param name="dni">El numero de Dni a buscar</param>
        /// <returns>El cliente que coincide con el dni pasado como argumento o
        /// <see langword="null"></see> si no hay coincidencia</returns>
        public static Cliente ClientePorDni(int dni)
        {
            return Clientes.FiltrarElemento(c => c.Dni == dni);
        }
        public static Cliente ClientePorDni(string dni)
        {
            if (int.TryParse(dni, out int num)) return ClientePorDni(num);
            return null;
        }

        /// <summary>
        /// Busca un cliente por su numero de Dni
        /// </summary>
        /// <param name="dni">El numero de Dni a buscar</param>
        /// <returns>El cliente que coincide con el dni pasado como argumento o
        /// <see langword="null"></see> si no hay coincidencia</returns>
        public static Cliente ClientePorNumSocio(int numSocio)
        {
            return Clientes.FiltrarElemento(c => c.NumSocio == numSocio);
        }
        public static Cliente ClientePorNumSocio(string numSocio)
        {
            if (int.TryParse(numSocio, out int n)) return ClientePorNumSocio(n);
            return null;
        }



        public static void Aleatorio()
        {
            while (true)
            {
                Thread.Sleep(10000);
                PedidoAleatorio();
               
                RespaldarClientes();
            }

        }

        public static void PedidoAleatorio()
        {
            Random rnd = new Random();
            List<Helado> helados = new List<Helado>();
            List<Sabor> listaSabores = new List<Sabor>();
            Cliente cliente;            

            if (Clientes.Count < 2 || rnd.Next(0, 2) == 1)
            {
                cliente = Hardcodeo.CrearCliente();
                clientesLocal.Add(cliente);
            }
            else cliente = Clientes[rnd.Next(0, Clientes.Count)];

            Envase envase = envases[rnd.Next(0, envases.Count)];

            for (int i = 0; i < envase.CantSabores; i++)
            {
                listaSabores.Add(sabores[rnd.Next(0, sabores.Count)]);
            }

            helados.Add(new Helado(envase, listaSabores));

            pedidos.Add(new Pedido(cliente.NumSocio, helados));
        }


        public static void RespaldarClientes()
        {
           if (clientesLocal.Count > 10)
            {
                GuardarListaClientes();
                NotificadorDeGuardado();
            }
        }

        internal static bool EsDniRepetido(int dni)
        {
            List<Persona> lista = new List<Persona>();

            lista.AddRange(empleados);
            lista.AddRange(clientesBase);

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
            GuardarListaPedidos();
        }
        public static void RecuperarInfo()
        {
            CargarListaEmpleados();
            CargarListaClientes();
            //  CargarListaClientesDesdeArchivo();//<< quitar
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
                lista = CargarBase(new SerializadorXml<List<Persona>>(), ruta);

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
            clientesBase = Cliente.Leer();
        }

        private static void CargarListaClientesDesdeArchivo()
        {
            string ruta = Ruta.ArchivoXml(Ruta.Base, "Lista de clientes");
            List<Persona> lista;
            try
            {
                lista = CargarBase(new SerializadorXml<List<Persona>>(), ruta);

                foreach (Persona item in lista)
                {
                    if (item is not null && item is Cliente cliente) clientesLocal.Add(cliente);
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
        public static void GuardarListaClientes()
        {
            int ultimoId = 0;
            // List<Cliente> lista
            try
            {
                conexion.Open();
                comando.CommandText = "select top(1) numSocio from Clientes order by numSocio desc";
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    ultimoId = Convert.ToInt32(dr["numSocio"]);
                }

                if (ultimoId < 1) throw new Exception($"Error al guardar base: ultimo Id = {ultimoId}");
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de clientes", e));
            }
            finally
            {
                conexion.Close();
            }

            foreach (Cliente item in clientesLocal)
            {
                if (item is not null)
                {
                    if (item.NumSocio > ultimoId) Cliente.Guardar(item);
                    else Cliente.Modificar(item);
                }
            }
            clientesLocal.Clear();
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
        private static void GuardarListaPedidos()
        {
            string ruta = Ruta.ArchivoJson(Ruta.Base, "Lista de Pedidos");
            try
            {
                GuardarBase(new SerializadorJson<List<Pedido>>(), ruta, pedidos);
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al guardar lista de Pedidos", e));
            }
        }






    }
}
