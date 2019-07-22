using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Tahoe.Domain.Interfaces
{
    public interface IRoom
    {
        double Price { get; set; }
        bool Empty { get; set; }
        bool Locked { get; set; }
        ERoomType Type { get; set; }
    }
}