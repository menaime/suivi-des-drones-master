using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;
using MySQL.Data.EntityFrameworkCore;

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
            var query = from item in this.context?.Drones
                        //where item.CreationDate > DateTime.Now
                        select item;

            return query.ToList();
        }
        #endregion                                                                                      
    }
}
