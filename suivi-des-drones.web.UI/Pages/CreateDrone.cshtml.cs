using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace suivi_des_drones.web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        #region Fields
        private readonly IDroneRepository repository;
        #endregion

        #region Constructor
        public CreateDroneModel(IDroneRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public methods
        
        #endregion
        public void OnGet()
        {    
        }

        //public void OnPost(Drone drone)                 //(TestClass test)
        public void OnPost() 
        {
            if (this.ModelState.IsValid)
            {
                this.repository.Save(this.MonDrone);
                this.MonDrone = new Drone();
                this.ModelState.Clear();
                //string mactricule = this.Request.Form [ "matricule"];
            }

        }

        [BindProperty]
        public Drone MonDrone { get; set; }

    }
}
