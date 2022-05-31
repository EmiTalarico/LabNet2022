using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_ExtMeth_UTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

                        break;

                    case '2':

                        break;
                }


            } while ((int)opcion.KeyChar != 27);

        }

        

    }
    
}
