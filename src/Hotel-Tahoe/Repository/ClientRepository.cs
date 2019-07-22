using Hotel.Domain.Entities;
using System.Linq;

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
