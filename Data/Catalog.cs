using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Data
{
    public class Catalog : BaseEntity
    {
        [MinLength(2)]
        [MaxLength(64)]
        public string Name { get; set; }

        [MinLength(0)]
        [MaxLength(255)]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
