using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// vérifie la présence d'un utilisateur pas son email et son mot de passe (hashé)
        /// </summary>
        /// <param name="user"></param>
        CompleteUser LogIn(AuthenticationUser user);
    }
}
