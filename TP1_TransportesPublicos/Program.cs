using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_TransportesPublicos
{
    internal class Program
    {
             
        static void Main(string[] args)
        {
            //Color de fondo y letras de la consola.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Listas donde se van a guardar los objetos correspondientes.
            List<Omnibus> lOmnibus = new List<Omnibus>();
            List<Taxi> lTaxi = new List<Taxi>();

            ConsoleKeyInfo opcion;


            //Empieza el menú
            do
            {
                Console.Clear();
                Console.WriteLine("::::::MENU PRINCIPAL::::::");
                Console.WriteLine("");
                Console.WriteLine("1 - Nuevo transporte");
                Console.WriteLine("2 - Listar transportes");
                Console.WriteLine("ESC - Salir");
                Console.Write("Ingrese una opción: ");

                do
                {
                    opcion = Console.ReadKey(true);
                } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '2')); //!=27 es el boton ESC en ASCII
                switch (opcion.KeyChar)
                {
                    case '1':
                        NuevoTransporte(lOmnibus,lTaxi);
                        break;

                    case '2':
                        ListarTransportes(lOmnibus,lTaxi);
                        break;
                }


            } while ((int)opcion.KeyChar != 27);

        }

        public static void ListarTransportes(List<Omnibus> lOmnibus, List<Taxi> lTaxi)
        {
            Console.Clear();
            Console.WriteLine(":::::MENU LISTAR TRANSPORTES:::::");
            Console.WriteLine("");
            Console.WriteLine(":::...Omnibus...:::");
            Console.WriteLine("");
            foreach (var item in lOmnibus)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(":::...Taxi...:::");
            Console.WriteLine("");
            foreach (var item in lTaxi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        public static void NuevoTransporte(List<Omnibus> lOmnibus, List<Taxi> lTaxi)
        {
            ConsoleKeyInfo opcion;

            Console.Clear();
            Console.WriteLine(":::::MENU AGREGAR TRANSPORTE:::::");
            Console.WriteLine("\nTipo de transporte: ");
            Console.WriteLine("\n1 - Omnibus");
            Console.WriteLine("2 - Taxi");
            Console.WriteLine("ESC - Salir");
            Console.Write("Ingrese una opción: ");
            do
            {
                opcion = Console.ReadKey(true);
            } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '2'));

            switch (opcion.KeyChar)
            {
                case '1':
                    NuevoOmnibus(lOmnibus);
                    break;

                case '2':
                    NuevoTaxi(lTaxi);
                    break;
            }
        }
        public static void NuevoTaxi(List<Taxi> lTaxi)
        {
            Console.Clear();
            try
            {
                Console.WriteLine(":::::MENU NUEVO TAXI:::::");
                Console.WriteLine("\nIngrese los datos para el nuevo Taxi:");
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Motor: ");
                string motor = Console.ReadLine();
                Console.Write("Capacidad de pasajeros, debe ser entre 1 y 5: ");
                int pasajeros = Convert.ToInt32(Console.ReadLine());
                if (pasajeros < 1 || pasajeros>5)
                {
                    Console.WriteLine("Ingresó un numero fuera del rango permitido");
                    Console.WriteLine("Toque una tecla para continuar...");
                    Console.ReadKey(true);
                    return;
                }


                Taxi taxi = new Taxi(marca, motor, pasajeros);
                lTaxi.Add(taxi);

                Console.WriteLine("");
                Console.WriteLine("Taxi agregado con éxito..");
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar..");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Uy, apareció el siguiente error: " + ex.Message);

                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar..");
                Console.ReadKey();
            }
            Console.WriteLine("\n");
        }
        public static void NuevoOmnibus(List<Omnibus> lOmnibus)
        {
            Console.Clear();
            try
            {
                Console.WriteLine(":::::MENU NUEVO OMNIBUS:::::");
                Console.WriteLine("\nIngrese los datos para el nuevo Omnibus:");
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Motor: ");
                string motor = Console.ReadLine();
                Console.Write("Capacidad de pasajeros, debe ser entre 1 y 100: ");
                int pasajeros = Convert.ToInt32(Console.ReadLine());
                if (pasajeros < 1 || pasajeros > 100)
                {
                    Console.WriteLine("Ingresó un numero fuera del rango permitido");
                    Console.WriteLine("Toque una tecla para continuar...");
                    Console.ReadKey(true);
                    return;
                }


                Omnibus omnibus = new Omnibus(marca, motor, pasajeros);
                lOmnibus.Add(omnibus);
                Console.WriteLine("");
                Console.WriteLine("Omnibus agregado con éxito..");
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar..");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Uy, apareció el siguiente error: " + ex.Message);

                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar..");
                Console.ReadKey();
            }
            Console.WriteLine("\n");
            
        }
    }
}
