using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string MusicDirector { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int Cost { get; set; }
        public int Collection { get; set; }
        public string Review { get; set; } = string.Empty;
    }
}
