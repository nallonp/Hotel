using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Repository;
using System;
using System.Collections.Generic;

namespace Hotel.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private ClientRepository _repository;
        public ClientBusiness(ClientRepository repository)
        {
            _repository = repository;
        }
        public void AddClient(Client client)
        {
            if (_repository.ItExists(client))
                _repository.Insert(client);
            else
                throw new ArgumentException("Cliente já está cadastrado.");
        }

        public Client GetById(uint id)
        {
            return _repository.SelectById(id);
        }

        public List<Client> GetList()
        {
            return _repository.GetList();
        }
    }
}
