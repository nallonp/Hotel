using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        bool Insert(T t);
        List<T> GetList();
    }
}
