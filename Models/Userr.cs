
using System.ComponentModel.DataAnnotations;

namespace RideSharingApplication.Models
{
    public class Userr
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string mail { get; set; }

        [Required]
        public string password { get; set; }

    }
}
