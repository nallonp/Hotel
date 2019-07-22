using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Tahoe.Domain.Interfaces
{
    public interface IClient
    {
        String Nome { get; set; }
        String Email { get; set; }
        String Telefone { get; set; }
        String CPF { get; set; }
    }
}
