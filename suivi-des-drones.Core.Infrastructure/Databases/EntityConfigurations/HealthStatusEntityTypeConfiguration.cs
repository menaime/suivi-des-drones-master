using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;
using MySQL.Data.EntityFrameworkCore;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class HealthStatusEntityTypeConfiguration : IEntityTypeConfiguration<HealthStatus>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            builder.HasKey(item => item.Id);
            builder.ToTable("HealthStatus");
        }
        #endregion
    }
}
