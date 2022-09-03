using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Application.DTOs.CartDto
{
    public class CreateCartDto
    {
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "A Quantidade é obrigatória.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O Id da arma é obrigatória.")]
        public int WeaponId { get; set; }

        [Required(ErrorMessage = "O Id do usuário é obrigatório.")]
        public int UserId { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
