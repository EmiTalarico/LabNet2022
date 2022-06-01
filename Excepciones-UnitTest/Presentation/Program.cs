using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_UnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Color de fondo y letras de la consola.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleKeyInfo opcion;

            //Empieza el menú
            do
            {
                Console.Clear();
                Console.WriteLine("::::::MENU PRINCIPAL::::::");
                Console.WriteLine("");
                Console.WriteLine("1 - División por Cero");
                Console.WriteLine("2 - Dividendo y Divisor");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("ESC - Salir");
                Console.Write("Ingrese una opción: ");

                do
                {
                    opcion = Console.ReadKey(true);
                } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '4')); //!=27 es el boton ESC en ASCII
                switch (opcion.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(":::...MENU DIVISION POR CERO...:::");
                        Console.WriteLine("");

                        try
                        {
                            Console.WriteLine("Ingrese un número: ");
                            int numero = Convert.ToInt32(Console.ReadLine());

                            MetodosExtension.DivisionPorCeroSimple(numero);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Seguro ingresó una letra o no ingresó nada!.");
                            Console.WriteLine("El nombre de la excepción es: " + ex.GetType());
                            Console.WriteLine("");
                            Console.WriteLine("La explicación general es: " + ex.Message);
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine(":::...MENU DIVISOR/DIVIDENDO...:::");
                        Console.WriteLine("");
                        try
                        {
                            Console.WriteLine("Ingrese el dividendo: ");
                            int dividendo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el divisor: ");
                            int divisor = Convert.ToInt32(Console.ReadLine());
                            MetodosExtension.DividendoYDivisor(dividendo,divisor);
                        }
                       
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Seguro ingresó una letra o no ingresó nada!.");
                            Console.WriteLine("El nombre de la excepción es: " + ex.GetType());
                            Console.WriteLine("");
                            Console.WriteLine("La explicación general es: " + ex.Message);
                            Console.WriteLine("");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case '3':
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Solo presione enter...");
                            Console.ReadLine();
                            Logic logic = new Logic();
                            logic.Ejercicio3();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Nombre general de la excepcion: "+ex.Message);
                            Console.WriteLine("Nombre del tipo de excepción: "+ex.GetType().Name);
                            Console.ReadKey();
                        }
                        break;

                    case '4':
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Solo presione enter...");
                            Console.ReadLine();
                            throw new Logic();
                        }
                        catch (Logic ex)
                        {
                            Console.WriteLine(ex.Message(ex));
                            Console.ReadKey();
                        }
                        break;
                }


            } while ((int)opcion.KeyChar != 27);

        }

        

        
    }
}
