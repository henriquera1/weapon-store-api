using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Application.DTOs.CartDto
{
    public class UpdateCartDto
    {
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
