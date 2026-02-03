using System.ComponentModel.DataAnnotations;

namespace Earth.Models
{
    public class User
    {
        public int ID { get; set; }

        //public string Username { get; set; }
        //public string Password { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }

    }
}
