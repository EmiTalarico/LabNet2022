using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Entities;
using TP4.EntityFrameWork.Logic;

namespace TP4.EntityFrameWork.UI
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
                Console.WriteLine(":::...Realizados en la demo/clase en vivo...:::");
                Console.WriteLine("1 - Mostrar regiones");
                Console.WriteLine("2 - Mostrar productos");
                Console.WriteLine(":::...Solicitados por el trabajo práctico...:::");
                Console.WriteLine("3 - Mostrar Suppliers");
                Console.WriteLine("4 - Mostrar Shippers");
                Console.WriteLine("5 - Nuevo Shippers");
                Console.WriteLine("6 - Modificar Shippers");
                Console.WriteLine("7 - Eliminar Shippers");
                Console.WriteLine("ESC - Salir");
                Console.Write("Ingrese una opción: ");

                do
                {
                    opcion = Console.ReadKey(true);
                } while (((int)opcion.KeyChar != 27) && (opcion.KeyChar < '1' || opcion.KeyChar > '7'));
                switch (opcion.KeyChar)
                {
                    case '1':
                        MostrarRegiones();
                        break;

                    case '2':
                        MostrarProductos();
                        break;

                    case '3':
                        MostrarSuppliers();
                        break;

                    case '4':
                        MostrarShippers();
                        break;

                    case '5':
                        AgregarShippers();
                        break;

                    case '6':
                        ModificarShippers();
                        break;

                    case '7':
                        EliminarShippers();
                        break;
                }
            } while ((int)opcion.KeyChar != 27);

            #endregion
        }

        #region Metodos del ABM
        private static void EliminarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::DELETE SHIPPERS::::::::");
                Console.WriteLine();
                Console.WriteLine();
                ShippersLogic shippersLogic = new ShippersLogic();
                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID) {item.ShipperID} - Phone: {item.Phone} - Name: {item.CompanyName}");
                }
                Console.WriteLine();
                Console.WriteLine("Ingrese el ID del shipper a eliminar: ");
                int id = Convert.ToInt32(Console.ReadLine());
                shippersLogic.Delete(id);
                Console.WriteLine("Shipper elimnado con éxito...");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true); ;
            }
        }

        private static void ModificarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::MODIFY SHIPPERS::::::::");
                Console.WriteLine();
                ShippersLogic shippersLogic = new ShippersLogic();
                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID) {item.ShipperID} - Phone: {item.Phone} - Name: {item.CompanyName}");
                }
                Console.WriteLine();
                Console.WriteLine("Ingrese el Id del shipper a modificar:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo telefono: ");
                string phone = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo nombre: ");
                string name = Console.ReadLine();

                shippersLogic.Update(new Shippers
                {
                    ShipperID = id,
                    Phone = phone,
                    CompanyName = name
                });
                Console.WriteLine("Shipper modificado con éxito...");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true); ;
            }
        }

        private static void AgregarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::NEW SHIPPERS::::::::");
                Console.WriteLine("");
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine("Ingrese el nombre de la compañia: ");
                string companyName = Console.ReadLine();
                Console.WriteLine("Ingrese el teléfono: ");
                string phone = Console.ReadLine();

                shippersLogic.Add(new Shippers
                {
                    CompanyName = companyName,
                    Phone = phone
                });
                Console.WriteLine("Shipper agregado con éxito...");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
        }

        private static void MostrarShippers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::LIST SHIPPERS::::::::");
                Console.WriteLine();
                Console.WriteLine();
                ShippersLogic shippersLogic = new ShippersLogic();
                foreach (var item in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID) {item.ShipperID} - Phone: {item.Phone} - Name: {item.CompanyName}");
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar..."); ;
            }
        }

        private static void MostrarSuppliers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(":::::::LIST SUPPLIERS::::::::");
                Console.WriteLine();
                SuppliersLogic suppliersLogic = new SuppliersLogic();
                foreach (var item in suppliersLogic.GetAll())
                {
                    Console.WriteLine($"ID) {item.SupplierID} - Phone: {item.Phone} - Name: {item.CompanyName}");
                }
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }

        }

        private static void MostrarRegiones()
        {
            try
            {
                Console.WriteLine();
                RegionLogic regionLogic = new RegionLogic();

                foreach (var item in regionLogic.GetAll())
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                }
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true);
            }
        }

        private static void MostrarProductos()
        {
            try
            {
                Console.WriteLine();
                ProductsLogic productoLogic = new ProductsLogic();
                foreach (var item in productoLogic.GetAll())
                {
                    Console.WriteLine($"{item.ProductID} - {item.ProductName}");
                }
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La explicación general es: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey(true); ;
            }


        }

        #endregion
    }
}
