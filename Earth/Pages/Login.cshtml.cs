using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Earth.Models; 

namespace Earth.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User Users { get; set; } = new User();
        public IActionResult OnPost()
        {
            if(Users.Username == "Admin" && Users.Password == "Admin123")
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
