using BarRating.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarRating.Data
{
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

      
        // Таблица за баровете
        public DbSet<Bar> Bars { get; set; }

        // Таблица за ревюта
        public DbSet<Review> Reviews { get; set; }
    }
}
