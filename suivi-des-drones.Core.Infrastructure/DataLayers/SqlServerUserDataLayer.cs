using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerUserDataLayer : BaseSqlServerDataLayer,  IUserDataLayer
    {
        #region Constructor
        public SqlServerUserDataLayer(DronesDbContext context) : base(context) { }
      
        #endregion
        #region Public method
        public CompleteUser GetOne(string email, string password)
        {
            return this.Context.Users?.Where(IThreadPoolWorkItem => item.Login == email && item.Password == password)
                                      .First();
        }
            
        #endregion
    }
}
