using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : IDroneDataLayer
    {
        #region Fields
        private readonly DronesDbContext? context = null;

        public SqlServerDroneDataLayer()
        {
        }
        #endregion
        #region Constructors
        public SqlServerDroneDataLayer(DronesDbContext context)
        {
            this.context = context;
        }


        #endregion
        #region Public methods

       
                        
        public List<Drone> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Drone> List
        {
            get
            {
                var query = from item in this.context?.Drones.Include(item =>item.HealthStatus)
                                //where item.CreationDate > DateTime.Now
                            select item;

                return query.ToList();
            }

        }
        public void AddOne(Drone drone)
        {

            this.context?.Drones.Add(drone);
            
            this.context?.SaveChanges();

            ///var entry = this.context?.Entry(drone.HealthStatus);
            ///entry.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
        #endregion
    }
}
