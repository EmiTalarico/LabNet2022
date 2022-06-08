using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public void Add(Shippers newShippers)
        {
            _context.Shippers.Add(newShippers);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shippersAEliminar = _context.Shippers.Find(id);

            _context.Shippers.Remove(shippersAEliminar);

            _context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public void Update(Shippers shipper)
        {
            var shipperUpdate = _context.Shippers.Find(shipper.ShipperID);

            shipperUpdate.Phone = shipper.Phone;
            shipperUpdate.CompanyName = shipper.CompanyName;

            _context.SaveChanges();
        }
    }
}
