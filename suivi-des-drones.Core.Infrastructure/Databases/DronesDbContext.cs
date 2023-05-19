using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Models;

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
            _ = modelBuilder.ApplyConfiguration(new EntityConfigurations.DroneEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new EntityConfigurations.HealthStatusEntityTypeConfiguration());
            _ = modelBuilder.ApplyConfiguration(new EntityConfigurations.UseEntityTypeConfiguration());
            //modelBuilder.Entity<Drone>().HasKey(item => item.Matricule);
        }
        #endregion


        #region Constructors


        #endregion


        #region Proprerties

        #endregion
        public DbSet<Drone> Drones { get; set; }

        public DbSet<Drone> HealthStatutses { get; set; }

        public DbSet<CompleteUser> CompletedUsers { get; set; }
        public CompleteUser Users { get; internal set; }
    }
}
