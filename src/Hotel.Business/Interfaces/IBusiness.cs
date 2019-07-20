using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IBusiness<T>
    {
        bool Add(T t);
        List<T> GetList();
    }
}
