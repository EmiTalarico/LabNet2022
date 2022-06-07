using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Data;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public class ProductsLogic
    {
        private readonly NorthwindContext _context;

        public ProductsLogic()
        {
            _context = new NorthwindContext();
        }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
