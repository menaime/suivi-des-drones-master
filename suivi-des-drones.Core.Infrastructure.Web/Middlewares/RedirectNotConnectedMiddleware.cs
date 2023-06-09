﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


namespace suivi_des_drones.Core.Infrastructure.Web.Middlewares
{
    public class RedirectNotConnectedMiddleware
    {
        #region Fields
        private readonly RequestDelegate next;
        #endregion
        #region Constructors
        public RedirectNotConnectedMiddleware(RequestDelegate next)
        {
            this.next = next;

        }
        #endregion
        #region Public mathods
        public async Task InvokeAsync(HttpContext context)
        {
            string id = context.Session.GetString("UserId");
            bool? isLoginPage = context.Request.Path.Value?.ToLower().Contains("Login");

            if (string.IsNullOrEmpty(id) && (!isLoginPage.HasValue || isLoginPage.Value))
            {
                context.Response.Redirect("/Login");
            }

            await next.Invoke(context);
        }
        #endregion
        /*public static class AuthenticatonMiddleWares
        {
            #region Publi methods
            public static IApplicationBuilder UseRedirectIfNotConnected (this IApplicationBuilder app)
             {
            return app;

            }
            #endregion
        }*/
    }
}
