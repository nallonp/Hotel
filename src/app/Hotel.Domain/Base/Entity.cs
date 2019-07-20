using Hotel.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Base
{
    public abstract class Entity : IEntity
    {
        public Guid Guid { get; set; }
        public long Id { get; set; }
    }
}
