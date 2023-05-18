using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Models;
using MySQL.Data.EntityFrameworkCore;

namespace suivi_des_drones.Core.Infrastructure.Databases
{
    public class DronesDbContext : DbContext
    {
        public DronesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DronesDbContext()
        {
        }
        #region Public Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.DroneEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.HealthStatusEntityTypeConfiguration());
            //modelBuilder.Entity<Drone>().HasKey(item => item.Matricule);
        }
        #endregion


        #region Constructors


        #endregion


        #region Proprerties

        #endregion
        public DbSet<Drone> Drones { get; set; }
        
        public DbSet<Drone> HealthStatutses { get; set; }
    }
}
