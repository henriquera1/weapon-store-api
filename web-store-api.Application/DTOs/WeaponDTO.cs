using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_store_api.Application.DTOs
{
    public class WeaponDTO
    {

        [Required(ErrorMessage = "O nome é obrigatório.", AllowEmptyStrings = false)]
        [MinLength(2, ErrorMessage = "Insira um nome com dois ou mais caracteres.")]
        [Display(Name = "Nome da arma")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.", AllowEmptyStrings = false)]
        [Display(Name = "Marca da arma")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "A Imagem é obrigatória.",AllowEmptyStrings = false)]
        [Display(Name="Imagem da arma")]
        public string Image { get; set; }

        [Required(ErrorMessage = "O Tipo é obrigatório.", AllowEmptyStrings = false)]
        [Display(Name = "Tipo da arma")]
        public string Type { get; set; }

        [Required(ErrorMessage = "O Calibre é obrigatório.", AllowEmptyStrings = false)]
        [Display(Name = "Calibre da arma")]
        public string Caliber { get; set; }

        [Required(ErrorMessage = "A Capacidade é obrigatória.", AllowEmptyStrings = false)]
        [Display(Name = "Capacidade da arma")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "O Ano é obrigatório.", AllowEmptyStrings = false)]
        [Display(Name = "Ano da arma")]
        [Range(1288, 2022)]
        public int Year { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório", AllowEmptyStrings = false)]
        public decimal Price { get; set; }


    }
}
