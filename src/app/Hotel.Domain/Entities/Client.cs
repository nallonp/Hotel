using Hotel.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
    public class Client : Entity
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String CPF { get; set; }
    }
}
