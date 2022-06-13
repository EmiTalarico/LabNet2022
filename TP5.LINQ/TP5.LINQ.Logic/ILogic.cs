using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.LINQ.Entities;

namespace TP5.LINQ.Logic
{
    public interface ILogic<T> where T : BaseEntity
    {
        List<T> GetAll();

        void Add(T newObject);
        void Delete(int id);
        void Update(T newObject);
    }
}
