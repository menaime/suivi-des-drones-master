using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Interfaces.Repositories
{

    public interface IDroneRepository
    {
        void AddOne(Drone drone);
        List<Drone> GetAll();
        List<Drone> GetAll(List<Drone> list);
        List<Drone> GetAll(object list);
   
        List<Drone> GetList();

        /// <summary>
        /// 
        /// Ajout ou mise à jour d'un drone
        /// </summary>
        /// <param name="drone"></param>
        void Save(Drone drone);
    }
}
