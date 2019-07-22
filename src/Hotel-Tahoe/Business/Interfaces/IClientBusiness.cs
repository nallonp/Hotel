using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IClientBusiness
    {
        void AddClient(Client client);
        Client GetById(uint id);
        IList<Client> GetClients();
    }
}
