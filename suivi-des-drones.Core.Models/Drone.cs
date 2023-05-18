namespace suivi_des_drones.Core.Models
{
    /// <summary>
    /// Drone de l'application
    /// </summary>
    public class Drone
    {
        #region Properties
        //[Key]
        public string Matricule { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        /// <summary>
        /// public HealthStatus HealthStatus { get; set; } = HealthStatus.OK;
        /// </summary>

        public HealthStatus HealthStatus { get; set; } = new HealthStatus();
        #endregion

    }
}
