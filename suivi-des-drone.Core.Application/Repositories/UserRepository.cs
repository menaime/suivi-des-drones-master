﻿using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var userData = this.layer.GetOne(user.Login, user.Password);

            if (userData == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return userData;
        }
    }
}
