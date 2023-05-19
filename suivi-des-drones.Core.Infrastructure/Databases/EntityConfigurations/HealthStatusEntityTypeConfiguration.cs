using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class HealthStatusEntityTypeConfiguration : IEntityTypeConfiguration<HealthStatus>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            _ = builder.HasKey(item => item.Id);
            _ = builder.ToTable("HealthStatus");
        }
        #endregion
    }
}
