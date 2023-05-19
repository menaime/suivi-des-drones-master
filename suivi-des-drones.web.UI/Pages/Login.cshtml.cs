using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.web.UI.Pages
{
    public class LoginModel : PageModel
    {
        #region Properties
        [BindProperty]
        public new AuthenticationUser User { get; set; }
        #endregion
        #region Fields
        private readonly IUserRepository Repository;
        #endregion
        #region Constructors
        public LoginModel(IUserRepository repository)
        {
            Repository = repository;
        }
        #endregion
        #region Public methods
        public IActionResult OnPost()
        {
            IActionResult result = Page();

            try
            {
                HttpContext.Session.SetInt32("UserId", 12345);

                result = RedirectToPage("/index");

                ///var user = Repository.LogIn(this.User);

                /// if (user != null) 
                /// {

                /// }

            }
            catch (Exception)
            {

            }

            return result;
        }
        #endregion

    }
}
