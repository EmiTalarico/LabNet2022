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
                        Console.Clear();
                        Console.WriteLine(":::::MENU AGREGAR TRANSPORTE:::::");
                        Console.WriteLine("");
                        Console.WriteLine("\n\nTipo de transporte: ");
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
                                Console.Clear();
                                try
                                {
                                    Console.WriteLine(":::::MENU NUEVO OMNIBUS:::::");
                                    Console.WriteLine("");
                                    Console.WriteLine("\n\nIngrese los datos para el nuevo Omnibus:");
                                    Console.Write("Marca: ");
                                    string marca = Console.ReadLine();
                                    Console.Write("Motor: ");
                                    string motor = Console.ReadLine();
                                    Console.Write("Capacidad de pasajeros: ");
                                    int pasajeros = Convert.ToInt32(Console.ReadLine());


                                    Omnibus omnibus = new Omnibus(marca, motor, pasajeros);
                                    lOmnibus.Add(omnibus);
                                    Console.WriteLine("Omnibus agregado con éxito..");
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
                                break;

                            case '2':
                                Console.Clear();
                                try
                                {
                                    Console.WriteLine(":::::MENU NUEVO TAXI:::::");
                                    Console.WriteLine("");
                                    Console.WriteLine("\n\nIngrese los datos para el nuevo Taxi:");
                                    Console.Write("Marca: ");
                                    string marca = Console.ReadLine();
                                    Console.Write("Motor: ");
                                    string motor = Console.ReadLine();
                                    Console.Write("Capacidad de pasajeros: ");
                                    int pasajeros = Convert.ToInt32(Console.ReadLine());


                                    Taxi taxi = new Taxi(marca, motor, pasajeros);
                                    lTaxi.Add(taxi);

                                    Console.WriteLine("Taxi agregado con éxito..");
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
                                break;
                        }
                        break;

                    case '2':

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

                        break;
                }


            } while ((int)opcion.KeyChar != 27);

        }
    }
}
