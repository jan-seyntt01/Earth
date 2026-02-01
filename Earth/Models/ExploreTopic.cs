using System.ComponentModel.DataAnnotations;

namespace Earth.Models
{
    public class ExploreTopic
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Short description is required")]
        [StringLength(200)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Image path is required")]
        [StringLength(200)]
        public string ImagePath { get; set; } = string.Empty;

        [Required(ErrorMessage = "Full content is required")]
        public string FullContent { get; set; } = string.Empty;

        [Required(ErrorMessage = "Key facts are required")]
        public string KeyFacts { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}