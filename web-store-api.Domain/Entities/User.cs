using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }  

        public string Username { get; set; }

        public int CPF { get; set; }

        public int Age { get; set; }

        public int Number { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Cart Cart { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

    }
}
