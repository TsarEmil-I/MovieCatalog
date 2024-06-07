using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MovieCatalog.Data
{
    public class Movie : BaseEntity
    {
        [Required]
        [MinLength(1)]
        [MaxLength(65)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Catalog>? Catalogs { get; set; }
    }
}
