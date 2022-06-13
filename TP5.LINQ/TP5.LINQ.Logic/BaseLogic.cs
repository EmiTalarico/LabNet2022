using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.LINQ.Data;
using TP5.LINQ.Entities;

namespace TP5.LINQ.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }

        public void Add(Customers newObject)
        {
            throw new NotImplementedException();
        }
    }
}
