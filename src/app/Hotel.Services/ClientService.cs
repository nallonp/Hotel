using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ClientService
    {
        private readonly IClientBusiness _clientBusiness;
        public ClientService(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }
    }
}
