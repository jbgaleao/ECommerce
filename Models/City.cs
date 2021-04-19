using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Cidade Id")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name ="Cidade")]
        public string Name { get; set; }

        [Display(Name ="Departamento")]
        public int DepartamentsId { get; set; }

        public virtual Departaments Departaments { get; set; }
    }
}