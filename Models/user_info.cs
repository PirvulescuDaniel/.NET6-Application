
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideSharingApplication.Models
{
    [Keyless]
    public class user_info
    {
        [ForeignKey("Userrs")]
        public int user_id { get; set; }

        public string name { get; set; }

        public string mail { get; set; }

        public char gender { get; set; }

        public int age { get; set; }

        public string description { get; set; }


    }
}
