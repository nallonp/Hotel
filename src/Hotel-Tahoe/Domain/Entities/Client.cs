using Hotel_Tahoe.Domain.Interfaces;
using System;

namespace Hotel.Domain.Entities
{
    public class Client : GenericEntity, IClient
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String CPF { get; set; }
    }
}
