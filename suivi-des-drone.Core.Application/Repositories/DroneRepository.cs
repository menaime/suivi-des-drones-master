
using suivi_des_drone.Core.Application.Repositories;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drone.Core.Application.Repositories

/// <summary>
/// Repository qui gère les drones, la création, la lecture
/// </summary>
{
    public class DroneRepository :  IDroneRepository
    {

        #region Fields
        //private readonly IDroneRepository dataLayer;
        #endregion

        #region Constructor
        //public DroneRepository(IDroneRepository dataLayer)
       // {
          //  this.dataLayer = dataLayer;
       // }
        #endregion



        #region Public methods
        public List<Drone> GetAll()
        {
            return new();
         
        }

        #endregion
    }
}
