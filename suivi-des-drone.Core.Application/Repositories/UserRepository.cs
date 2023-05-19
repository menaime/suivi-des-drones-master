using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drone.Core.Application.Repositories
{
    #region Public method

    #endregion
    public class UserRepository : IUserRepository
    {
        #region Fields
        private readonly IUserDataLayer layer;
        #endregion

        #region Constructors
        public UserRepository(IUserDataLayer layer)
        {
            this.layer = layer;
        }
        #endregion

        public CompleteUser LogIn(AuthenticationUser user)
        {
            CompleteUser userData = layer.GetOne(user.Login, user.Password);

            return userData ?? throw new ArgumentNullException(nameof(user));
        }
    }
}
