using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:novademo3.database.windows.net,1433;Initial Catalog=novademodb;Persist Security Info=False;User ID=mdvincent;Password=L@ptop123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<LoveTeam> LoveTeams { get; set; }
    }
}