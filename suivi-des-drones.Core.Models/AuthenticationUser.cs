using System.ComponentModel.DataAnnotations;

namespace suivi_des_drones.Core.Models
{
    public class AuthenticationUser
    {
        [EmailAddress]
        public string? Login { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
