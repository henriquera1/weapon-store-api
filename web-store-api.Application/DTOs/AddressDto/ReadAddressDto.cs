using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Application.DTOs.AddressDto
{
    public class ReadAddressDto
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }
    }
}
