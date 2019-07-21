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
        public Client(string nome, string email, string telefone, string cpf)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
        }

    }
}
