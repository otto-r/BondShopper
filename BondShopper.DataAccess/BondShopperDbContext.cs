using BondShopper.Model;
using System.Data.Entity;

namespace BondShopper.DataAccess
{
    public class BondShopperDbContext : DbContext
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BondShopper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public BondShopperDbContext() : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Client> Clients { get; set; }
        //public DbSet<Order> Orders { get; set; }
    }
}
