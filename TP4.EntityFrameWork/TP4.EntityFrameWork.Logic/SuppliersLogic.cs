using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {
        public void Add(Suppliers newSuppliers)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Update(Suppliers newSuppliers)
        {
            throw new NotImplementedException();
        }
    }
}
