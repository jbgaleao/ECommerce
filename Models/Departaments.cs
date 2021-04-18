using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }
    }
}