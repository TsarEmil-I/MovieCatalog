using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
