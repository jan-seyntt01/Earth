using System.ComponentModel.DataAnnotations;

namespace Earth.Models
{
    public class AboutContent
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Introduction is required")]
        public string Introduction { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mission is required")]
        public string Mission { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vision is required")]
        public string Vision { get; set; } = string.Empty;

        [StringLength(200, MinimumLength = 50)]
        public string ImagePath { get; set; } = string.Empty;

        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
