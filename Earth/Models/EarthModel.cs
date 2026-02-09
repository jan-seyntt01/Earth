using System.ComponentModel.DataAnnotations;

namespace Earth.Models
{
    public class EarthModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Question is required")]
        [StringLength(300)]
        public string Question { get; set; } = string.Empty;

        [Required(ErrorMessage = "Option A is required")]
        public string OptionA { get; set; } = string.Empty;

        [Required(ErrorMessage = "Option B is required")]
        public string OptionB { get; set; } = string.Empty;

        [Required(ErrorMessage = "Option C is required")]
        public string OptionC { get; set; } = string.Empty;

        [Required(ErrorMessage = "Option D is required")]
        public string OptionD { get; set; } = string.Empty;

        [Required(ErrorMessage = "Correct Answer is required")]
        public string CorrectAnswer { get; set; } = string.Empty;

        [Required(ErrorMessage = "Explanation is required")]
        [StringLength(500)]
        public string Explanation { get; set; } = string.Empty;
    }
}
