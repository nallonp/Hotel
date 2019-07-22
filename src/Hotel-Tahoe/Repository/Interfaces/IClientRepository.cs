using Hotel.Domain.Entities;

namespace Hotel_Tahoe.Repository.Interfaces
{
   public interface IClientRepository
    {
        bool ItExists(Client client);
    }
}
