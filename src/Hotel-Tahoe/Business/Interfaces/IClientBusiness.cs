using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Business.Interfaces
{
    public interface IClientBusiness
    {
        void AddClient(Client client);
        Client GetById(uint id);
        IList<Client> GetClients();
    }
}
