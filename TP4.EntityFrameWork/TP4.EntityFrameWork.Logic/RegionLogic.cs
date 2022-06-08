using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Data;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public class RegionLogic : BaseLogic, ILogic<Region>
    {
        public List<Region> GetAll()
        {
            return _context.Region.ToList();
        }

        public void Add(Region newRegion)
        {
            _context.Region.Add(newRegion);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ////First devuelve el primer elemento de una secuencia que satisfaga la conexion
            //var regionAEliminar = _context.Region.First(r => r.RegionID == id);

            ////Primer elemento o el valor por default si no se encuentra el elemetno
            //regionAEliminar = _context.Region.FirstOrDefault(r => r.RegionID == id);

            ////Devuevle el unico elemento de la secuencia que satisfaga la condicion, si encuentra mas de 1 elemento lanza excepcion
            //regionAEliminar = _context.Region.Single(r => r.RegionID == id);

            ////Devuelve el unico elemento q satisfaga la condicion o default. Si encuetra  mas de 1 lanza excepcion.
            //regionAEliminar = _context.Region.SingleOrDefault (r => r.RegionID == id);

            //Busca directamente por la primera key, en este caso de regiones es REGION ID
            var regionAEliminar = _context.Region.Find(id);

            _context.Region.Remove(regionAEliminar);

            _context.SaveChanges();
        }

        public void Update(Region region)
        {
            var regionUpdate = _context.Region.Find(region.RegionID);

            regionUpdate.RegionDescription = region.RegionDescription;

            _context.SaveChanges();
        }

       
    }
}
