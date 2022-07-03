using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Domain.Entities
{
    public class Weapon : BaseEntity
    {
      
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Image { get; set; }
 
        public string Type { get; set; }

    
        public string Caliber { get; set; }

      
        public int Capacity { get; set; }

      
        public int Year { get; set; }

       
        public bool IsIlegal { get; set; }
    }
}
