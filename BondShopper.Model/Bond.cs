namespace BondShopper.Model
{
    public class Bond
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Principal { get; set; }
        public decimal Price { get; set; }
        public decimal InterestCouponRate { get; set; }
        public int MaturityInMonths { get; set; }
    }
}
