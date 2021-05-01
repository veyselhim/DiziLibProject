using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
