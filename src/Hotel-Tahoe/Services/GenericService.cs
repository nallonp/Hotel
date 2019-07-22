using Hotel_Tahoe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Tahoe.Services
{
    public abstract class GenericService<T> : IGenericService<T>
    {
        public T _Business { get; }
        public GenericService(T business)
        {
            _Business = business;
        }
    }
}
