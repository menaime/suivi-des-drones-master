using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Interfaces.Infrastructure
{
    /// <summary>
    /// Isole l"accès à la base de donées.
    /// </summary>
    public interface IDroneDataLayer
    {

        /// <summary>
        /// Retourne la liste compléte
        /// </summary>
        List<Drone> List { get; }

        /// <summary>
        /// Permet ajout d(un nouveau drone en bases de donée
        /// </summary>
        /// <param name="drone"></param>
        void AddOne(Drone drone);
        List<Drone> GetList();
    }
}
