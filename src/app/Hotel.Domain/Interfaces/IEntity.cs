using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Guid { get; set; }
        ulong Id { get; set; }
    }
}
