using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name ="Departamento")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}