using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Domain.Entities;

namespace web_store_api.Application.DTOs.CartDto
{
    public class ReadCartDto
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Weapon Weapon { get; set; }

        public User User { get; set; }

        public bool IsActive { get; set; }

    }
}
