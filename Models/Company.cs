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
        [Display(Name = "Companhia")]
        [Index("Company_Name_Index",IsUnique = true)]
        public string Companhia { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100,ErrorMessage = "O campo {0} deve ter no máximo: 100 caracteres !")]
        [Display(Name = "Endereço")]
        [Index("Endereco_Name_Index",IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Address { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(20,ErrorMessage = "O campo {0} deve ter no máximo: 20 caracteres !")]
        [Display(Name = "Telefone")]
        [Index("Telefone_Name_Index",IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int DepartamentsId { get; set; }


        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int CityId { get; set; }


        // navigations properties
        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }        
    }
}