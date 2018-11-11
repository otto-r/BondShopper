using System.Runtime.Serialization;

namespace BondShopper.Model
{
    [DataContract]
    public class Bond
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Principal { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public decimal InterestCouponRate { get; set; }
        [DataMember]
        public int MaturityInMonths { get; set; }
    }
}
