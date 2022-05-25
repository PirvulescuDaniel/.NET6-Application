
using System.ComponentModel.DataAnnotations;

namespace RideSharingApplication.Models
{
    public class Car
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int engineCapacity { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int pricePerDay { get; set; }

    }
}
