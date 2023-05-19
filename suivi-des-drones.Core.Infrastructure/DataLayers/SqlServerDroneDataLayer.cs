using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : BaseSqlServerDataLayer, IDroneDataLayer
    {
        #region Fields
        private readonly DronesDbContext? context = null;

        #endregion
        #region Constructors
        public SqlServerDroneDataLayer(DronesDbContext Context) : base(Context) { }



        #endregion
        #region Public methods





        public List<Drone> List
        {
            get
            {
                IQueryable<Drone> query = from item in Context?.Drones.Include(item => item.HealthStatus)
                                              //where item.CreationDate > DateTime.Now
                                          select item;

                return query.ToList();
            }

        }
        public void AddOne(Drone drone)
        {

            _ = (context?.Drones.Add(drone));

            _ = (Context?.SaveChanges());

            ///var entry = this.context?.Entry(drone.HealthStatus);
            ///entry.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }

        public List<Drone> GetList()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
