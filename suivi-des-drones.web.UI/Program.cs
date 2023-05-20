using Microsoft.EntityFrameworkCore;
using suivi_des_drone.Core.Application.Repositories;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Infrastructure.DataLayers;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Infrastructure.Web.Middlewares;




WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//.AddRazorPagesOptions(option =>
//{
//    option.Conventions.AddPageRoute("/CreateDrone", "creation-drone");
//});
builder.Services.AddDbContext<DronesDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("DroneContext");
    _ = options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IDroneDataLayer, SqlServerDroneDataLayer>();
//builder.Services.AddScoped<IUserDataLayer, SqlServerUserDataLayer>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<DroneRepository, DroneRepository>();

builder.Services.AddSession(option =>
{
    option.IOTimeout = TimeSpan.FromSeconds(10);
    ///option.Cookie.HttpOnly = true;
    ///option.Cookie.IsEssential = true;

});

WebApplication app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();
app.UseAuthorization();

//app.UseRedirectIfNotConnected();

/// premiere approche

/*app.Use(async (context, next) =>
{
    var id = context.Session.GetInt32("UserId");
    var isLoginPage = context.Request.Path.Value?.ToLower().Contains("Login");

    if (!id.HasValue && (!isLoginPage.HasValue || isLoginPage.Value))
    {
       context.Response.Redirect("/Login");
    }
});*/

app.MapRazorPages();

app.Run();
