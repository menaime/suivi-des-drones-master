using suivi_des_drones.Core.Models;
using suivi_des_drones.Core.Interfaces.Repositories;

namespace suivi_des_drones.Core.Interfaces.Repositories
{

    public interface IDroneRepository 
    {
          List<Drone> GetAll();
    }
}
