using Hotel.Domain.Entities;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ClientRepository : GenericRepository<Client>
    {
        public bool ItExists(Client client)
        {
            return !((GetList().Where(x => x.CPF == client.CPF).SingleOrDefault()) == null);
        }
    }
}
