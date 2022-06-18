using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        private static Random rnd = new Random();


        /// <summary>
        /// Crea una Heladeria y le carga los datos harcodeados
        /// </summary>
        /// <returns></returns>       
        public static void CrearHeladeria()
        {
            Empresa.Nombre = " Heladeria\"T.P. N° 03\" Srl.";
            Empresa.Empleados = CrearPersonal(5, 9);
            Empresa.Sabores = CrearSabores();
            Empresa.Envases = CrearEnvases();
            Empresa.Clientes = CrearCliente(50);
        }


        private static List<Envase> CrearEnvases()
        {
            List<Envase> lista = new List<Envase>();

            lista.Add(new Envase("Kilo", 4));
            lista.Add(new Envase("Medio", 4));
            lista.Add(new Envase("Cuarto", 3));
            lista.Add(new Envase("Tacita", 3));
            lista.Add(new Envase("Cucurucho", 2));
            lista.Add(new Envase("Vasito", 2));

            return lista;
        }

        private static List<Sabor> CrearSabores()
        {
            List<Sabor.ETipo> listaChoco = new List<Sabor.ETipo>();
            List<Sabor.ETipo> listaCrema = new List<Sabor.ETipo>();
            List<Sabor> lista = new List<Sabor>();

            listaChoco.Add(Sabor.ETipo.Chocolates);
            listaChoco.Add(Sabor.ETipo.De_Crema);
            listaCrema.Add(Sabor.ETipo.Cremas);
            listaCrema.Add(Sabor.ETipo.De_Crema);

            lista.Add(new Sabor("Chocolate", CostoRnd(), listaChoco, 30000));
            lista.Add(new Sabor("Chocolate Con Almendras", CostoRnd(), listaChoco, 30000));
            lista.Add(new Sabor("Chocolate Amargo", CostoRnd(), listaChoco, 30000));
            lista.Add(new Sabor("Crema", CostoRnd(), listaCrema, 30000));
            lista.Add(new Sabor("Granizado", CostoRnd(), listaCrema, 30000));
            lista.Add(new Sabor("Dulce de Leche", CostoRnd(), Sabor.ETipo.De_Crema, 30000));
            lista.Add(new Sabor("Frutilla", CostoRnd(), Sabor.ETipo.De_Agua, 30000));
            lista.Add(new Sabor("Limon", CostoRnd(), Sabor.ETipo.De_Agua, 30000));

            return lista;
        }



        /// <summary>
        /// Crea una lista de empleados 
        /// </summary>
        /// <param name="administrativos">Cantidad de empleados con el puesto administrativo</param>
        /// <param name="empleados">Cantidad de empleados con el puesto empleados</param>
        /// <returns>Una lista de empleados con la suma
        /// de las cantidades en los puestos indicados</returns>
        private static List<Empleado> CrearPersonal(int administrativos, int empleados)
        {
            List<Empleado> lista = new List<Empleado>();

            lista.AddRange(CrearPersonalAdministrativo(administrativos));
            lista.AddRange(CrearPersonalEmpleado(empleados));

            return lista;
        }

        /// <summary>
        /// Crea una lista de empleados en el puesto administrativo
        /// </summary>
        /// <param name="administrativos">Cantidad de empleados en el puesto administrativo</param>
        /// <returns>Una lista de empleados en el puesto administrativo</returns>
        private static List<Empleado> CrearPersonalAdministrativo(int administrativos)
        {
            List<Empleado> lista = new List<Empleado>();

            for (int i = 0; i < administrativos; i++)
            {
                lista.Add(CrearUsuario(Empleado.EPuesto.Administrativo));
            }
            return lista;
        }

        /// <summary>
        /// Crea una lista de empleados en el puesto empleado
        /// </summary>
        /// <param name="empleados">Cantidad de empleados en el puesto empleado</param>
        /// <returns>Una lista de empleados en el puesto empleado</returns>
        private static List<Empleado> CrearPersonalEmpleado(int empleados)
        {
            List<Empleado> lista = new List<Empleado>();

            for (int i = 0; i < empleados; i++)
            {
                lista.Add(CrearUsuario(Empleado.EPuesto.Empleado));
            }
            return lista;
        }

        /// <summary>
        /// Crea un empleados en el puesto pasado como parametro
        /// </summary>
        /// <param name="puesto">puesto que tendra el empleados</param>
        /// <returns>Un empleados con el puesto indicado</returns>
        private static Empleado CrearUsuario(Empleado.EPuesto puesto)
        {
            return new Empleado(DniRnd(), EdadRnd(), NombreRnd(), ApellidoRnd(), puesto);
        }


        /// <summary>
        /// Crea una lista de clientes
        /// </summary>
        /// <param name="cantidad">Cantidad e clientes a crear</param>
        /// <returns>Lista de clientes de la cantdad indicada</returns>
        public static List<Cliente> CrearCliente(int cantidad)
        {
            List<Cliente> lista = new List<Cliente>();

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(CrearCliente());
            }
            return lista;
        }

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <returns>Un cliente</returns>
        public static Cliente CrearCliente()
        {
            int dni;

            do
            {
                dni = DniRnd();

            } while (!Empresa.EsDniRepetido(dni));

            return new Cliente(NombreRnd(), ApellidoRnd(), dni, FechaAltaRnd());
        }



        /// <summary>
        /// Simula las chances de que el valor devuelto sea true o false
        /// de manera random en base a las chanses indicadas
        /// </summary>
        /// <param name="aciertos">Cantidad de chances que sea true</param>
        /// <param name="entre">Chances maximas</param>
        /// <returns>true o false de manera random</returns>
        private static bool ChanceRnd(int aciertos, int entre)
        {
            if (aciertos >= 0 && entre >= 0)
            {
                return rnd.Next(0, entre) < aciertos;
            }
            return false;
        }




        private static DateTime FechaAltaRnd()
        {
            return FechaRnd(true, 2400, 24);
        }
        private static DateTime FechaRnd(bool previo, int max, int min)
        {
            int horas = rnd.Next(min, max);
            int minutos = rnd.Next(1, 60);

            if (previo) horas *= -1;

            return DateTime.Now.Add(new TimeSpan(horas, minutos, 0));
        }

        /// <summary>
        /// Simula un numero de dni random
        /// </summary>
        /// <returns>Devuelve un numero entre (10456400, 47681739) random</returns>
        private static int DniRnd()
        {
            return rnd.Next(10456400, 47681739);
        }

        /// <summary>
        /// Simula una edad random
        /// </summary>
        /// <returns>Devuelve un numero entre (10456400, 47681739) random</returns>
        private static int EdadRnd()
        {
            return rnd.Next(20, 70);
        }

        /// <summary>
        /// Simula un costo random
        /// </summary>
        /// <returns>Devuelve un numero entre (200, 300) random</returns>
        private static int CostoRnd()
        {
            return rnd.Next(200, 300);
        }

        /// <summary>
        /// Simula un nombre random
        /// </summary>
        /// <returns>Devuelve un nombre random</returns>
        private static string NombreRnd()
        {
            string[] nombre = {"Moisés", "Lililana","Lina" ,"Valeria","José","Ángel","Florencia","Miguel", "Mateo", "ViViana",
                               "Blanca", "Alba", "Marta","Sabastian","Camila","Manuel","Emiliano","Ámbar","Brunilda","Silvia",
                               "Matilde", "Ariel", "Leo","Victoria","Teobaldo","Delfina","Rodrigo","Blas","Marcelo", "Rosa"
                              };
            return nombre[rnd.Next(0, 30)];
        }

        /// <summary>
        /// Simula un apellido random
        /// </summary>
        /// <returns>Devuelve un apellido random</returns>
        private static string ApellidoRnd()
        {
            string[] apellido = {"Cordero","Tejada","Echevarría","Ponce","Leocadio","Llorens","Ortiz","Luque","Bello","Miralles",
                                 "Lago","Batista","Márquez","Córdoba","Mosquera","Serra","Cortez","Dominguez","Benitez","Garcia",
                                 "Heredia", "Prada","Galán","Miguez","Viña","Soto","Mendizábal","Sandoval","Ripoll","Frutos"
                                };
            return apellido[rnd.Next(0, 30)];
        }





    }
}
