using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Logic;

namespace TP4.EntityFrameWork.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductsLogic productslogic = new ProductsLogic();


            foreach (var item in productslogic.GetAll())
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            }

            Console.ReadKey();

        }
    }
}
