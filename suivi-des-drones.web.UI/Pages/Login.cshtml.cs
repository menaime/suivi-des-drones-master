using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.web.UI.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public AuthenticationUser User { get; set; }
        public IActionResult OnPost()
        {
            IActionResult result=this.Page();

            return result;
        }
    }
}
