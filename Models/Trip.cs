using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideSharingApplication.Models
{
    public class Trip
    {

        [Key]
        public int trip_id { get; set; }

        public string trip_name { get; set; }

        public int people_no { get; set; }

        public int joins_no { get; set; }

        [ForeignKey("Cars")]
        public int car_id { get; set; }

        [ForeignKey("Locations")]
        public int location_id  { get; set; }

    }
}
