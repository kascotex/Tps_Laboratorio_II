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
            //   pedidos = new List<int>();
        }//<< eliminar
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
        //public int Puntos
        //{
        //    get { return puntos; }
        //    set { puntos = value; }
        //}
        //<< eliminar
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
        // public List<int> Pedidos 
        // {
        //     get { return pedidos; }
        //     set { pedidos = value; }
        // }
        //<< eliminar




        public static string IdToString(int numSocio)
        {
            return string.Format("{0:0000}", numSocio);
        }
        private void CalcularPuntaje(Pedido pedido)
        {

        }


        public static string EsClienteValido(string nombre, string apellido, int dni)
        {
            return EsPersonaValida(nombre, apellido, dni, true);
        }

        public static void DarBaja(int numSocio)
        {
            try
            {
                Empresa.Conexion.Open();
                // Empresa.Comando.CommandText = $"DELETE FROM CLIENTES WHERE numSocio = {numSocio}";
                Empresa.Comando.CommandText = $" UPDATE CLIENTES SET estaActivo = 0 WHERE numSocio = {numSocio}";
                Empresa.Comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al Eliminar Cliente", e));
            }
            finally
            {
                Empresa.Conexion.Close();
            }
        }
        public static void Modificar(Cliente cliente)
        {
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
            }
            catch (Exception e)
            {
                Log.GuardarExcepcion(new Exception("Error al Modificar Cliente", e));
            }
            finally
            {
                Empresa.Conexion.Close();
            }
        }

        public static void Guardar(Cliente cliente)
        {
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
                // Empresa.Comando.Parameters.AddWithValue("@numSocio", cliente.numSocio);

                Empresa.Comando.ExecuteNonQuery();
            }
            finally
            {
                Empresa.Conexion.Close();
            }
        }

        //  public static Cliente LeerPorId(int numSocio)
        //  {
        //      Cliente cliente = null;
        //
        //      try
        //      {
        //          Empresa.Conexion.Open();
        //          Empresa.Comando.CommandText = $"SELECT * FROM CLIENTES WHERE CODIGO_JUEGO = {numSocio}";
        //
        //          using (SqlDataReader dataReader = Empresa.Comando.ExecuteReader())
        //          {
        //              while (dataReader.Read())
        //              {
        //                  cliente = new Cliente(dataReader["NOMBRE"].ToString(),
        //                      Convert.ToDouble(dataReader["PRECIO"]),
        //                      dataReader["GENERO"].ToString(),
        //                      Convert.ToInt32(dataReader["CODIGO_JUEGO"]),
        //                      Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
        //              }
        //          }
        //      }
        //      catch (Exception e)
        //      {
        //         Log.GuardarExcepcion(new Exception("Error al Leer Cliente", e));
        //      }
        //      finally
        //      {
        //          Empresa.Conexion.Close();
        //      }
        //
        //      return cliente;
        //  }




    }
}
