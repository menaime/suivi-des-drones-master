﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class DroneEntityTypeConfiguration : IEntityTypeConfiguration<Drone>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Drone> builder)
        {
            builder.HasKey(item => item.Matricule);
            builder.ToTable("Drone");
            builder.Property(item => item.Matricule) .IsRequired(true);
            builder.Property(item => item.Matricule).HasMaxLength(255);
            ///builder.HasOne(item => item.HealthStatus)
            ///     .WithMany(item => item.Drones)
            ///    .HasForeignKey(item => item.HealthStatusId);

        }
        #endregion
    }
}
