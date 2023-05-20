using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NUnit.Framework;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System.Collections.Generic;

namespace suivi_des_drones.web.UI.Pages
{

    public class IndexOldModel : PageModel
    {
        #region Fields
        private readonly ILogger<IndexModel> _logger;
        private readonly IDroneRepository repository;
        #endregion

        #region Constructors
        public IndexOldModel(ILogger<IndexModel> logger,
            IConfiguration configuration,
            IDroneRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }
        #endregion

        #region Public methods

        /// public void OnGet()
        /// {

        /// }
        /// 
        /*public IActionResult OnGet()
        {
            IActionResult result = this.Page();

            if (true)
            {
                result = this.BadRequest();
            }
            return result;*/
        /// }
        /// 
        public IActionResult OnGet()
        {
            _ = RedirectPermanent("/Index");
            SetListOfDrones();
            SetListStatus();

            return Page();
        }
        #endregion

        #region Internal methods
        private void SetListOfDrones()
        {
            //this.Drones.Add(new() { Matricule = "54XXD0", CreationDate = DateTime.Now, HealthStatus = HealthStatus.Broken });
            //this.Drones.Add(new() { Matricule = "15FDP14", CreationDate = DateTime.Now.AddDays(-150) });

            //var dataLayer = new SqlServerDroneDataLayer();

            Drones = repository.GetAll(list);
        }

        private void SetListStatus()
        {
            StatusList.Add(HealthStatus.OK);
            StatusList.Add(HealthStatus.Repair);
            StatusList.Add(HealthStatus.Broken);
        }
        #endregion

        #region Properties
        public List<Drone> Drones { get; set; } = new();

        public List<HealthStatus> StatusList { get; set; } = new();

        #endregion


    }
}