using MovieCatalog.Data;
using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
{
    public class CatalogCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MinLength(0)]
        [MaxLength(255)]
        public string Description { get; set; }
        public virtual ICollection<int> MoviesIds { get; set; }
    }
}
