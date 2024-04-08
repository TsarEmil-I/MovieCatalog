using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieCatalog.Data
{
    public class Catalog : BaseEntity
    {
        [Required]
        [MinLength(2)]
        [MaxLength(64)]
        public string Name { get; set; }

        [MinLength(0)]
        [MaxLength(255)]
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Movie>? Movies { get; set; }
    }
}
