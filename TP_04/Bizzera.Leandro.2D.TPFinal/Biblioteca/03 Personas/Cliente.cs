using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        static int ultimonumSocio;

        private int numSocio;
        private DateTime alta;
        private byte estaActivo;


        public Cliente()
        {
        }
        public Cliente(string nombre, string apellido, int dni)
           : base(nombre, apellido, dni)
        {
            numSocio = ++ultimonumSocio;
            alta = DateTime.Now;
            estaActivo = 1;
        }
        public Cliente(string nombre, string apellido, int dni, DateTime alta)
            : this(nombre, apellido, dni)
        {
            this.alta = alta;
        }

        public Cliente(string nombre, string apellido, int dni, DateTime alta, int numSocio, byte estaActivo)
        : this(nombre, apellido, dni, alta)
        {
            this.numSocio = numSocio;
            this.estaActivo = estaActivo;
        }

        public static int UltimonumSocio
        {
            get { return ultimonumSocio; }
        }
        public int NumSocio
        {
            get { return numSocio; }
            set
            {
                if (value > ultimonumSocio) ultimonumSocio = value;
                numSocio = value;
            }
        }
        public string NumSocioString
        {
            get { return IdToString(NumSocio); }
        }

        public DateTime Alta
        {
            get { return alta; }
            set { alta = value; }
        }

        public bool EstaActivo
        {
            get
            {
                return estaActivo == 1 ? true : false;
            }
            set
            {
                if (value) estaActivo = 1;
                estaActivo = 0;
            }
        }





        public static string IdToString(int numSocio)
        {
            return string.Format("{0:0000}", numSocio);
        }



        public static string EsClienteValido(string nombre, string apellido, int dni)
        {
            return EsPersonaValida(nombre, apellido, dni, true);
        }


        public static bool Modificar(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                Empresa.Comando.Parameters.Clear();
                Empresa.Conexion.Open();

                Empresa.Comando.CommandText = $"UPDATE CLIENTES SET NOMBRE = @nombre, APELLIDO = @apellido, ALTA = @alta, DNI = @dni, estaActivo = @estaActivo WHERE numSocio = {cliente.numSocio}";

                Empresa.Comando.Parameters.AddWithValue("@nombre", cliente.nombre);
                Empresa.Comando.Parameters.AddWithValue("@apellido", cliente.apellido);
                Empresa.Comando.Parameters.AddWithValue("@alta", cliente.alta);
                Empresa.Comando.Parameters.AddWithValue("@dni", cliente.dni);
                Empresa.Comando.Parameters.AddWithValue("@estaActivo", cliente.estaActivo);

                Empresa.Comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al Modificar Cliente", e));
            }
            finally
            {
                Empresa.Conexion.Close();
            }
            return retorno;
        }

        public static bool Guardar(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                Empresa.Comando.Parameters.Clear();
                Empresa.Conexion.Open();

                Empresa.Comando.CommandText = "INSERT INTO CLIENTES (nombre,apellido,alta,dni,estaActivo) VALUES (@nombre,@apellido,@alta,@dni,@estaActivo)";
                Empresa.Comando.Parameters.AddWithValue("@nombre", cliente.nombre);
                Empresa.Comando.Parameters.AddWithValue("@apellido", cliente.apellido);
                Empresa.Comando.Parameters.AddWithValue("@alta", cliente.alta);
                Empresa.Comando.Parameters.AddWithValue("@dni", cliente.dni);
                Empresa.Comando.Parameters.AddWithValue("@estaActivo", cliente.estaActivo);

                Empresa.Comando.ExecuteNonQuery();
            }
            finally
            {
                Empresa.Conexion.Close();
            }
            return retorno;
        }

        public static Cliente LeerPorId(int numSocio)
        {
            Cliente cliente = null;

            try
            {
                Empresa.Conexion.Open();
                Empresa.Comando.CommandText = $"SELECT * FROM CLIENTES WHERE numSocio = {numSocio}";

                using (SqlDataReader dr = Empresa.Comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cliente = new Cliente(
                                Convert.ToString(dr["nombre"]),
                                Convert.ToString(dr["apellido"]),
                                Convert.ToInt32(dr["dni"]),
                                Convert.ToDateTime(dr["alta"]),
                                Convert.ToInt32(dr["numSocio"]),
                                Convert.ToByte(dr["estaActivo"]));
                    }
                }
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al Leer Cliente", e));
            }
            finally
            {
                Empresa.Conexion.Close();
            }

            return cliente;
        }

        public static List<Cliente> Leer()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                Empresa.Comando.Parameters.Clear();
                Empresa.Conexion.Open();
                Empresa.Comando.CommandText = "select * from Clientes";
                SqlDataReader dr = Empresa.Comando.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Cliente(
                        Convert.ToString(dr["nombre"]),
                        Convert.ToString(dr["apellido"]),
                        Convert.ToInt32(dr["dni"]),
                        Convert.ToDateTime(dr["alta"]),
                        Convert.ToInt32(dr["numSocio"]),
                        Convert.ToByte(dr["estaActivo"])));
                }
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al cargar lista de clientes", e));
            }
            finally
            {
                Empresa.Conexion.Close();
            }

            return lista;
        }

        public override string ToString()
        {
            string estado = (EstaActivo) ? " Activo" : "De baja";

            return $"{estado} - Socio N°: {numSocio} {NombreCompleto}";
        }
    }
}
