using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50,ErrorMessage = "O campo {0} deve ter no máximo: 50 caracteres !")]
        [Display(Name = "Companhias")]
        [Index("Company_Name_Index",IsUnique = true)]
        public string Companhia { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20,ErrorMessage = "O campo {0} deve ter no máximo: 20 caracteres !")]
        [Display(Name = "Telefone")]
        [Index("Telefone_Name_Index",IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100,ErrorMessage = "O campo {0} deve ter no máximo: 100 caracteres !")]
        [Display(Name = "Telefone")]
        [Index("Endereco_Name_Index",IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }


        public virtual ICollection<City> Cities { get; set; }        
        public virtual ICollection<Departaments> Departaments { get; set; }
    }
}