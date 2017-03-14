using NewsPortal.Models;
using System.Data.Entity;

namespace NewsPortal.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OneNews> News { get; set; }


        public EFDbContext() : base("NewsPortalDatabase")
        {
            
        }
    }
}