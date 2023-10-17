using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService <T>
    {
        void Tadd(T t);
        void TDelete(T t);  
        void TUpdate(T t);
        List<T> TGetList();
        T GetByID(int id);
        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
