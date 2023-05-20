using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drone.Core.Application.Repositories

/// <summary>
/// Repository qui gère les drones, la création, la lecture
/// </summary>
{
    public class DroneRepository : IDroneRepository
    {
        private readonly IDroneRepository dataLayer;

        #region Fields
        //private readonly IDroneRepository dataLayer;
        #endregion

        #region Constructor
        public DroneRepository(IDroneRepository dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        public void AddOne(Drone drone)
        {
            dataLayer.AddOne(drone);
        }
        #endregion



        #region Public methods
        public List<Drone> GetAll(List<Drone> List)
        {
            List<Drone> drones = dataLayer.GetList();
            List<Drone> list = drones;
            return drones;  

        }
        public List<Drone> GetAll(object list)
        {
            return dataLayer.GetAll(list);
        }

        public List<Drone> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Drone> GetList()
        {
            return dataLayer.GetList();
        }

        public void Save(Drone drone)
        {
            drone.HealthStatusId = HealthStatus.OK.Id;
            dataLayer.AddOne(drone);
        }

        #endregion
    }
}
