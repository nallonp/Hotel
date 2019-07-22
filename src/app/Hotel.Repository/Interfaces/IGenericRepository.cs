using Hotel.Domain.Interfaces;
using Repository.Base;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IGenericRepository<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        T SelectById(ulong id);
        List<T> GetList();
    }
}
