using System.ComponentModel.DataAnnotations;

namespace pruebaApiBackend.Models.DataModels
{

    //Lo que toda las tablas van a tener 
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? updateDate { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeleteDate { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
