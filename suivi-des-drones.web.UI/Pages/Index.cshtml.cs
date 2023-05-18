using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Infrastructure.DataLayers;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;


namespace suivi_des_drones.web.UI.Pages
{

    public class IndexModel : PageModel
    {
        #region Fields
        private readonly ILogger<IndexModel> _logger;
        private readonly IDroneRepository repository;
        private readonly List<Drone> list;
        #endregion

        #region Constructors
        public IndexModel(ILogger<IndexModel> logger,
            IConfiguration configuration,
            IDroneRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }
        #endregion

        #region Puplic methods

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

            _ = new            //this.Drones.Add(new() { Matricule = "54XXD0", CreationDate = DateTime.Now, HealthStatus = HealthStatus.Broken });
            //this.Drones.Add(new() { Matricule = "15FDP14", CreationDate = DateTime.Now.AddDays(-150) });

            SqlServerDroneDataLayer();

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