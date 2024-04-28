using BarRating.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BarRating.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        // Таблица за потребителите
        public DbSet<User> Users { get; set; }

        // Таблица за баровете
        public DbSet <Bar> Bars { get; set; }
       
        // Таблица за ревюта
        public DbSet <Review> Reviews { get; set; }
}
}

