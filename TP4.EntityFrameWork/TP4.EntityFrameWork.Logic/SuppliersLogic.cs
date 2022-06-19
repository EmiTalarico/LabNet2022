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
            _context.Suppliers.Add(newSuppliers);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplierAEliminar = _context.Suppliers.Find(id);

            _context.Suppliers.Remove(supplierAEliminar);

            _context.SaveChanges();
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Update(Suppliers supplier)
        {
            var supplierUpdate = _context.Suppliers.Find(supplier.SupplierID);

            supplierUpdate.CompanyName = supplier.CompanyName;
            supplierUpdate.Address = supplier.Address;
            supplierUpdate.Phone = supplier.Phone;


            _context.SaveChanges();
        }
    }
}
