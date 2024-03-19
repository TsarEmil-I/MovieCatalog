using System.Globalization;

namespace MovieCatalog.Data
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        public string Description { get; set; }
        public List<int> Ratings { get; set; }
    }
}
