using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Interface
{
    public interface IEntity
    {
        Guid Guid { get; set; }
    }
}
