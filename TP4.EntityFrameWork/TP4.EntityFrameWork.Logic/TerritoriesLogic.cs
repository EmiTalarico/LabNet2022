using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Data;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public class TerritoriesLogic : BaseLogic, ILogic<Territories>
    {
        public void Add(Territories newRegion)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
            //using (NorthwindContext otroContexto = new NorthwindContext())
            //{
            //    return otroContexto.Territories.Include("Region").ToList();
            //}
        }

        public void Update(Territories newRegion)
        {
            throw new NotImplementedException();
        }
    }
}
