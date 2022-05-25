using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

using RideSharingApplication.Models;

namespace RideSharingApplication.Data 
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Userr> Userrs { get; set; }
        public DbSet<user_info> Users_info { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Registration> Registrations { get; set; }

    }
}