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
        [MaxLength(50,ErrorMessage = "O campo {0} deve ter no máximo: 50 caracteres !")]
        [Display(Name = "Departamento")]
        [Index("Departament_Name_Index",IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}