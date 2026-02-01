using System.ComponentModel.DataAnnotations;

namespace Earth.Models
{
    public class AboutContent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Introduction { get; set; } = string.Empty;

        [Required]
        public string Mission { get; set; } = string.Empty;

        [Required]
        public string Vision { get; set; } = string.Empty;

        [StringLength(200)]
        public string ImagePath { get; set; } = string.Empty;

        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
