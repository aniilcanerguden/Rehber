using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rehber.API.Abstract
{
   public interface IRepository<T> where T : class
    {

        void Add(T entities);
        void Update(T entities);
        void Delete(T entities);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter = null);
        T GetWrong(Expression<Func<T, bool>> filter = null);
        List<T> Getlist(Expression<Func<T, bool>> filter = null);
      
    }
}
