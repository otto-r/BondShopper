using System.Collections.Generic;

namespace BondShopper.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bond> Holdings { get; set; }
    }
}
