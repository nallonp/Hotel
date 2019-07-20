using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        bool Insert(T t);
        List<T> GetList();
    }
}
