using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerUserDataLayer : IUserDataLayer
    {
        #region Public method
        public CompleteUser GetOne(string email, string password)
        {
            throw new NotFiniteNumberException();
        }
            
        #endregion
    }
}
