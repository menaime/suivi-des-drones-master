using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class UseEntityTypeConfiguration : IEntityTypeConfiguration<CompleteUser>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<CompleteUser> builder)
        {
            builder.HasKey(item => item.Login);
            builder.ToTable("User");

        }
        #endregion

    }
}
