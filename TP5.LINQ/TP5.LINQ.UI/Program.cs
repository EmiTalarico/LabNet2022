using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.LINQ.Entities;
using TP5.LINQ.Logic;

namespace TP5.LINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Color y letra de la consola
            //Color de fondo y letras de la consola.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            #region Menu principal

            ConsoleKeyInfo opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("::::::MENU PRINCIPAL::::::");
                Console.WriteLine("");
                Console.WriteLine("1 - Devolver objeto Customer");
                Console.WriteLine("2 - Productos sin stock");
                Console.WriteLine("3 - Productos con stock y valor unitario mayor a 3");
                Console.WriteLine("4 - Customers de Washington // Productos por Id mayor a 789");
                Console.WriteLine("5 - Nombre de los customers");
                Console.WriteLine("6 - Join entre customers y orders // Primeros 3 customers WA");
                Console.WriteLine("7 - Productos ordenados por nombre // Productos ordenados por stock");
                Console.WriteLine("8 - Productos ordenados por categoria");
                Console.WriteLine("9 - Primer elemento de una lista de productos // Customers con ordenes asociadas ");
                Console.WriteLine("ESC - Salir");
                Console.Write("Ingrese una opción: ");

                do
                {
                    opcion = Console.ReadKey(true);
                } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '9'));
                switch (opcion.KeyChar)
                {
                    case '1':
                        //Devolver Objeto Customer
                        ObjetCustomer();
                        break;

                    case '2':
                        //Query para devolver todos los productos sin stock;
                        ProductOutStock();
                        break;

                    case '3':
                        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
                        AllProductWhere();

                        break;

                    case '4':
                        //4. Query para devolver todos los customers de la Región WA
                        WashingtonCustomers();
                        //5.Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
                        //producto sea igual a 789
                        Console.Clear();
                        Console.WriteLine("******************************");
                        Console.WriteLine("INICIO DEL EJERCICIO 5");
                        Console.WriteLine("******************************");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey(true);
                        ProductByIdWhere();
                        break;

                    case '5':
                        //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
                        CustomerName();
                        break;

                    case '6':
                        //7.Query para devolver Join entre Customers y Orders donde los customers sean de la
                        //Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.
                        CustomersAndOrderWhere();
                        Console.Clear();
                        Console.WriteLine("******************************");
                        Console.WriteLine("INICIO DEL EJERCICIO 8");
                        Console.WriteLine("******************************");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey(true);
                        //8. Query para devolver los primeros 3 Customers de la  Región WA
                        CustomerWaThree();
                        break;

                    case '7':
                        //9.Query para devolver lista de productos ordenados por nombre
                        ProductsOrderByName();
                        Console.Clear();
                        Console.WriteLine("******************************");
                        Console.WriteLine("INICIO DEL EJERCICIO 10");
                        Console.WriteLine("******************************");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey(true);
                        //10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
                        ProductsOrderByStock();

                        break;

                    case '8':
                        //11. Query para devolver las distintas categorías asociadas a los productos
                        ProductsByCategory();
                        break;

                    case '9':
                        //12. Query para devolver el primer elemento de una lista de productos
                        FistProduct();
                        Console.Clear();
                        Console.WriteLine("******************************");
                        Console.WriteLine("INICIO DEL EJERCICIO 13");
                        Console.WriteLine("******************************");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey(true);
                        //13.Query para devolver los customer con la cantidad de ordenes asociadas
                        CustomersWithOrders();
                        break;
                }
            } while ((int)opcion.KeyChar != 27);

            #endregion
        }

        #region Métodos estáticos del menú
        private static void CustomersWithOrders()
        {
            Console.Clear();
            Console.WriteLine(":::::::CUSTOMERS WITH ORDERS::::::::");
            Console.WriteLine();
            Console.WriteLine();
            CustomersLogic customerLogic = new CustomersLogic();
            Console.WriteLine(customerLogic.CustomersWithOrders());
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey(true);
        }

        private static void FistProduct()
        {
            Console.Clear();
            Console.WriteLine(":::::::FIRST PRODUCTS::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productLogic = new ProductsLogic();
            Console.WriteLine(productLogic.FirstProduct());
            Console.WriteLine("Presione una tecla para ir al siguiente ejercicio...");
            Console.ReadKey(true);
        }

        private static void ProductsByCategory()
        {
            Console.Clear();
            Console.WriteLine(":::::::PRODUCTS BY CATEGORY::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productLogic = new ProductsLogic();
            Console.WriteLine(productLogic.ProductsByCategory());
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey(true);
        }

        private static void ProductsOrderByStock()
        {
            Console.Clear();
            Console.WriteLine(":::::::PRODUCTS ORDER BY STOCK::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productLogic = new ProductsLogic();
            Console.WriteLine(productLogic.ProductOrderByStock());
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey(true);
        }

        private static void ProductsOrderByName()
        {
            Console.Clear();
            Console.WriteLine(":::::::PRODUCTS ORDER BY NAME::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productLogic = new ProductsLogic();
            Console.WriteLine(productLogic.ProductOrderByName());
            Console.WriteLine("Presione una tecla para ir al ejercicio siguiente...");
            Console.ReadKey(true);
        }

        private static void CustomerWaThree()
        {
            Console.Clear();
            Console.WriteLine(":::::::FIRST 3 CUSTOMERS REGION 'WA'::::::::");
            Console.WriteLine();
            Console.WriteLine();
            CustomersLogic customerLogic = new CustomersLogic();
            Console.WriteLine(customerLogic.FirstThreeWaCustomers());
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey(true);
        }

        private static void CustomersAndOrderWhere()
        {
            Console.Clear();
            Console.WriteLine(":::::::CUSTOMERS REGION 'WA' WHERE ORDER > 1/1/1997::::::::");
            Console.WriteLine();
            Console.WriteLine();
            CustomersLogic customerLogic = new CustomersLogic();
            Console.WriteLine(customerLogic.CustomersAndOrder());
            Console.WriteLine("Presione una tecla para ir al ejercicio siguiente...");
            Console.ReadKey(true);
        }

        private static void CustomerName()
        {
            Console.Clear();
            Console.WriteLine(":::::::CUSTOMERS NAME::::::::");
            Console.WriteLine();
            Console.WriteLine();
            CustomersLogic customerLogic = new CustomersLogic();
            Console.WriteLine(customerLogic.customerName());
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey(true);
        }

        private static void ProductByIdWhere()
        {
            Console.Clear();
            Console.WriteLine(":::::::FIRST PRODUCT BY ID WHERE > 789::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productsLogic = new ProductsLogic();
            Console.WriteLine("Tipee el ID 789 como pide el ejercicio...");
            Console.WriteLine("Los id de los productos van desde el 1 hasta el 77 por si quieren probar alguna opción..");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(productsLogic.ProductByIdWhere(id));
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey();
        }

        private static void WashingtonCustomers()
        {
            Console.Clear();
            Console.WriteLine(":::::::WASHINGTON CUSTOMERS::::::::");
            Console.WriteLine();
            Console.WriteLine();
            CustomersLogic customerLogic = new CustomersLogic();
            Console.WriteLine(customerLogic.WaCustomers());
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para ir al ejercicio siguiente...");
            Console.ReadKey();
        }

        private static void AllProductWhere()
        {
            Console.Clear();
            Console.WriteLine(":::::::PRODUCTS WITH STOCK AND UNIT PRICE > 3::::::::");
            Console.WriteLine();
            Console.WriteLine();
            ProductsLogic productsLogic = new ProductsLogic();
            Console.WriteLine(productsLogic.StockAndUnitePrice());
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para volver al menú principal...");
            Console.ReadKey();
        }

        private static void ProductOutStock()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::PRODUCTS OUT OF STOCK ::::::::");
                Console.WriteLine();
                Console.WriteLine();
                ProductsLogic productsLogic = new ProductsLogic();
                Console.WriteLine(productsLogic.OutStock());
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menú principal...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar..."); ;
            }
        }

        private static void ObjetCustomer()
        {
            try
            {

                Console.Clear();
                Console.WriteLine(":::::::LIST CUSTOMERS::::::::");
                Console.WriteLine();
                Console.WriteLine();
                CustomersLogic customersLogic = new CustomersLogic();
                Console.WriteLine("Ingrese ID Customer: ");
                Console.WriteLine("Recuerde que estos id son de 5 letras, ejemplo: welli ,savea ,ricar ,ranch, romey");
                Customers customer = customersLogic.CustomerById(Console.ReadLine().ToUpper());
                if (customer == null)
                    Console.WriteLine($"No extiste el customer con ese ID;");
                else
                    Console.WriteLine($"ID: {customer.CustomerID}\nNombre: {customer.ContactName}\nDireccion: {customer.Address}");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar..."); ;
            }
        }
        #endregion
    }
}
