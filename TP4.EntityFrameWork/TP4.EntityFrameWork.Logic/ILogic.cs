using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic
{
    public interface ILogic<T> where T : BaseEntity
    {
        List<T> GetAll();

        void Add(T elemento);
        void Delete(int id);
        void Update(T elemento);

        //
    }
}
