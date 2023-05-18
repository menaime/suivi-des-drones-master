using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;
using MySQL.Data.EntityFrameworkCore;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class DroneEntityTypeConfiguration : IEntityTypeConfiguration<Drone>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Drone> builder)
        {
            builder.HasKey(item => item.Matricule);
            builder.ToTable("Drone");
        }
        #endregion
    }
}
