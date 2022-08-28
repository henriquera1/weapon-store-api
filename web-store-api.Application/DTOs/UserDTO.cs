using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Domain.Entities;

namespace web_store_api.Application.DTOs
{
    public class UserDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int CPF { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int AddressId { get; set; }

        public virtual AddressDTO Address { get; set; }

        public virtual CartDTO Cart { get; set; }

        public bool IsActive { get; set; }
    }
}
