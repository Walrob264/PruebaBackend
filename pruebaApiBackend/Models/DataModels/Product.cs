using System.ComponentModel.DataAnnotations;

namespace pruebaApiBackend.Models.DataModels
{
    // La tabla que utlizamos en el proyecto
    public class Product : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required]
        public string image { get; set; }
    }
}
