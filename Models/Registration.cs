using System.ComponentModel.DataAnnotations.Schema;

namespace RideSharingApplication.Models
{
    [Microsoft.EntityFrameworkCore.Keyless]
    public class Registration
    {
        [ForeignKey("Userrs")]
        public int user_id { get; set; }

        [ForeignKey("Trips")]
        public int trip_id { get; set; }

        public DateTime date { get; set; }

    }
}
