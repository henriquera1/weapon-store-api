using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int WeaponId { get; set; }

        public virtual Weapon Weapon { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

    }
}
