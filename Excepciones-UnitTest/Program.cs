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
                Console.WriteLine("ESC - Salir");
                Console.Write("Ingrese una opción: ");

                do
                {
                    opcion = Console.ReadKey(true);
                } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '2')); //!=27 es el boton ESC en ASCII
                switch (opcion.KeyChar)
                {
                    case '1':
                        DivisionPorCeroSimple();
                        break;

                    case '2':
                        DividendoYDivisor();
                        break;
                }


            } while ((int)opcion.KeyChar != 27);

        }
        /*1) Realizar una método que al ingresar un valor genere una simple
         * excepción al intentar hacer una división por cero. 
         * Esta misma excepción deberá ser capturada, 
         * mostrando el mensaje de la excepción y siempre deberá avisar 
         * cuando terminó de realizarse la operación haya sido exitosa o no.
*/
        public static void DivisionPorCeroSimple()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::...MENU DIVISION POR CERO...:::");
                Console.WriteLine("");
                Console.WriteLine("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int resultado = (numero / 0);
                Console.WriteLine(resultado); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Seguro ingresó una letra o no ingresó nada!.");
                Console.WriteLine("El nombre de la excepción es: " + ex.GetType());
                Console.WriteLine("");
                Console.WriteLine("La explicación general es: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Uy, apareció el siguiente error general: " + ex.Message);

            }
            finally
            {
                Console.WriteLine("Fin de la ejecución.");
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
        }

        public static void DividendoYDivisor()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::...MENU DIVISOR/DIVIDENDO...:::");
                Console.WriteLine("");
                Console.WriteLine("Ingrese el dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int resultado = (dividendo / divisor);
                Console.WriteLine("El resultado es: " + resultado);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ingresó en el dividendo el numero 0!");
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine("");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Seguro ingresó una letra o no ingresó nada!.");
                Console.WriteLine("El nombre de la excepción es: "+ex.GetType());
                Console.WriteLine("");
                Console.WriteLine("La explicación general es: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uy, apareció el siguiente error general: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de la ejecución.");
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
        }
    }
}
