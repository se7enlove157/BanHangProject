using System.Data.Entity;

namespace WebBanHang.Models
{
    public class SalesContext: DbContext
    {
        public SalesContext() : base("QLBH")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalesContext, WebBanHang.Migrations.Configuration>("QLBH"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}