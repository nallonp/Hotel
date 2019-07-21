using Hotel.Domain.Interfaces;
using Repository.Base;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IGenericRepository<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
        List<T> GetList();
    }
}
