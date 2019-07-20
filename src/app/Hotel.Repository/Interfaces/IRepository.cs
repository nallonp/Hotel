using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
        List<T> GetList();
    }
}
