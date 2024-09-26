using fisher_folio.Models;
using Microsoft.EntityFrameworkCore;

namespace fisher_folio.Data
{
    public class AppDBContext : DbContext // : DBContext
    {
        // constructor der tager db context som parameter
        // DBSet for catch og user properties
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options) { }
        

        
        public DbSet<Catch> Catches { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
