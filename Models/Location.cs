using System.ComponentModel.DataAnnotations;

namespace RideSharingApplication.Models
{
    public class Location
    {
        [Key]
        public int location_id { get; set; }

        public string name { get; set; }

        public string country { get; set; }

        public string city { get; set; }


    }
}
