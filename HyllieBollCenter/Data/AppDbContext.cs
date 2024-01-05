using HyllieBollCenter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HyllieBollCenter.Data
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<DayBooking> DayBookings { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Tennis> Tenniss { get; set; }
        public DbSet<Badminton> Badmintons { get; set; }

    }
}
