using Microsoft.EntityFrameworkCore;

namespace HOTEL.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tour> Tour { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}