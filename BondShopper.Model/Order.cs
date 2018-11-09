using System.Collections.Generic;

namespace BondShopper.Model
{
    public class Order
    {
        public int Id { get; set; }
        public List<Bond> Bond { get; set; }
        public Client Client { get; set; }
    }
}
