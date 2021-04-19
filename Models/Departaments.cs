using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name ="Departamento")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}