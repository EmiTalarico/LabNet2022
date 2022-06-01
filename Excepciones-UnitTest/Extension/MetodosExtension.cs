using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_UnitTest
{
    public static class MetodosExtension
    {
        public static void DivisionPorCeroSimple(this int numero)
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::...MENU DIVISION POR CERO...:::");
                Console.WriteLine("");

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

        public static void DividendoYDivisor(this int dividendo, int divisor)
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::...MENU DIVISOR/DIVIDENDO...:::");
                Console.WriteLine("");
                

                int resultado = (dividendo / divisor);
                Console.WriteLine("El resultado es: " + resultado);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ingresó en el dividendo el numero 0!");
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine("");
                Console.WriteLine("El nombre del error es: "+ex.Message);
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
