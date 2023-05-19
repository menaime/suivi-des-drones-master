using Microsoft.AspNetCore.Builder;
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
        public async Task invokeAsync(HttpContext context)
        {
               var id = context.Session.GetInt32("UserId");
               var isLoginPage = context.Request.Path.Value?.ToLower().Contains("Login");

              if (!id.HasValue && (!isLoginPage.HasValue || isLoginPage.Value))
              {
                 context.Response.Redirect("/Login");
              }
             
            await this.next.Invoke(context);
        }
        #endregion
        public static class AuthenticatonMiddleWares
        {
            #region Publi methods
            public static IApplicationBuilder UseRedirectIfNotConnected(this IApplicationBuilder app)
            {
              return app.UseMiddleware<RedirectNotConnectedMiddleware>();
              
            }
            #endregion
        }
    }
}
