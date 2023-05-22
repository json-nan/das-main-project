using System.Data.Entity;

namespace MainProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<New> News { get; set; }

        public DbSet<Career> Careers { get; set; }

        public System.Data.Entity.DbSet<MainProject.Models.Contact> Contacts { get; set; }
    }
}