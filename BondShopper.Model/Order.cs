using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BondShopper.Model
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public List<Bond> Bond { get; set; }
        [DataMember]
        public Client Client { get; set; }
    }
}
