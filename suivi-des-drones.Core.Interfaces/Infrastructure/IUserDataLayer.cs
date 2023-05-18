using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Infrastructure
{
    public interface IUserDataLayer
    {
        /// <summary>
        /// Selectionne un utilisateur en base de donée
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        CompleteUser GetOne(string email, string password);
    }
}
