using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; protected set; }
    }
}
