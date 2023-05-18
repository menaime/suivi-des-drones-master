﻿namespace suivi_des_drones.Core.Models
{
    /* public enum HealthStatus
     {
         OK = 0,
         Broken = -1,
         Repair = -2,
     }*/

    /* public class HealthStatus
     {
         public static HealthStatus OK = new HealthStatus() { Id = 0, Label = "OK" };
         public static HealthStatus Broken = new HealthStatus() { Id = 0, Label = "Cassé" };
         public static HealthStatus Repair = new HealthStatus() { Id = 0, Label = "En réparation" };

         public int Id { get; set; } = 0;

         public string Label { get; set; } = default!;
     }*/
    /// public record HelthStatut(int Id, string Label);
    /// 
    public record HealthStatus
    {
        public static HealthStatus OK = new() { Id = 0, Label = "OK" };
        public static HealthStatus Broken = new() { Id = 0, Label = "Cassé" };
        public static HealthStatus Repair = new() { Id = 0, Label = "En réparation" };

        #region Properties
        public decimal Id { get; init; }
        public string Label { get; init; } = default!;  
        
        public List<Drone> Drones{ get; set; }
        #endregion
    }
}
