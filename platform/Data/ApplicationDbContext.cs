using Microsoft.EntityFrameworkCore;
using platform.Models;
namespace platform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext>opt):base(opt)
        {

        }
        public DbSet <Platform>Platforms {get;set;}

    }

}