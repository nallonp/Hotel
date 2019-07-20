using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IClientBusiness
    {
        bool Add(Client booking);
        List<Client> GetList();
    }
}
