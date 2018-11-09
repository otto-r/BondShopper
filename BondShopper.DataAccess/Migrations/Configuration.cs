namespace BondShopper.DataAccess.Migrations
{
    using BondShopper.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BondShopper.DataAccess.BondShopperDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BondShopper.DataAccess.BondShopperDbContext context)
        {
            context.Bonds.AddOrUpdate(b => b.Name,
                new Bond
                {
                    Name = "3_MONTH",
                    InterestCouponRate = 0,
                    Price = 99.95M,
                    Principal = 100M,
                    MaturityInMonths = 3
                },
                new Bond
                {
                    Name = "6_MONTH",
                    InterestCouponRate = 0,
                    Price = 99.9M,
                    Principal = 100M,
                    MaturityInMonths = 6
                },
                new Bond
                {
                    Name = "12_MONTH",
                    InterestCouponRate = 0,
                    Price = 99.8M,
                    Principal = 100M,
                    MaturityInMonths = 12
                },
                new Bond
                {
                    Name = "2_YEAR",
                    InterestCouponRate = 2.88M,
                    Price = 99.86M,
                    Principal = 100M,
                    MaturityInMonths = 24
                },
                new Bond
                {
                    Name = "5_YEAR",
                    InterestCouponRate = 2.88M,
                    Price = 99.13M,
                    Principal = 100M,
                    MaturityInMonths = 60
                },
                new Bond
                {
                    Name = "10_YEAR",
                    InterestCouponRate = 3.13M,
                    Price = 99.33M,
                    Principal = 100M,
                    MaturityInMonths = 120
                },
                new Bond
                {
                    Name = "30_YEAR",
                    InterestCouponRate = 3.38M,
                    Price = 99.56M,
                    Principal = 100M,
                    MaturityInMonths = 360
                }
                );
            context.Clients.AddOrUpdate(c => c.Name,
                new Client { Name = "Otto" });
        }
    }
}
