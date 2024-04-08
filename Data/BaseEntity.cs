using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Data
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
    }
}
