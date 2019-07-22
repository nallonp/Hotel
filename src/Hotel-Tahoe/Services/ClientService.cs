using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Hotel.Services.Interfaces;

namespace Hotel.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientBusiness _clientBusiness;
        public ClientService(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }

        public void AddClient(Client client)
        {
            _clientBusiness.AddClient(client);
        }
    }
}
