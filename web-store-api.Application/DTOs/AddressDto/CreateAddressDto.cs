using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Application.DTOs.AddressDto
{
    public class CreateAddressDto
    {
        
        [Required(ErrorMessage = "A Rua é obrigatória.")]
        public string Street { get; set; }
        
        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "O Estado é obrigatório.")]
        public string State { get; set; }
        
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "O País é obrigatório.")]
        public string Country { get; set; }

    }
}
