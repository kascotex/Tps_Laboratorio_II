using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class1
    {

        public void ConectarClienteDB(Cliente cliente)
        {
            string commandText;
            using (SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-8IDHMHG\\MSSQLSERVER06;Database=HELADERI_DB;Trusted_Connection=true;"))
            {
                commandText = "INSERT INTO CLIENTE (NOMBRE, APELLIDO, ALTA) VALUES(@NOMBRE,@APELLIDO,@ALTA)";
                SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
            }

        }



    }
}
