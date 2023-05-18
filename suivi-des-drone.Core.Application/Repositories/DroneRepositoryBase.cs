using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drone.Core.Application.Repositories
{
    public class DroneRepositoryBase
    {

        private readonly IDroneRepository dataLayer;



        public List<Drone> GetAll()
        {
            return new List<Drone>();
        }
    }
}