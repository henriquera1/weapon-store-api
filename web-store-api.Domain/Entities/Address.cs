using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Domain.Entities
{
    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; } 

    }
}
