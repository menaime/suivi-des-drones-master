using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost (TestClass test )
        {
            //string mactricule = this.Request.Form [ "matricule"];
        }

        public class TestClass
        {
            public string Matricule {  get;  set;  }
        }
    
    }
}
