using System.ComponentModel.DataAnnotations;

namespace suivi_des_drones.Core.Models
{
    /// <summary>
    /// Drone de l'application
    /// </summary>
    public class Drone
    {
        #region Properties
        //[Key]
        //[Required]
        public string Matricule { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        /// <summary>
        /// public HealthStatus HealthStatus { get; set; } = HealthStatus.OK;
        /// </summary>

        public HealthStatus? HealthStatus { get; set; } = null;

        public decimal HealthStatusId { get; set; } = HealthStatus.OK.Id;
        #endregion

    }
}
