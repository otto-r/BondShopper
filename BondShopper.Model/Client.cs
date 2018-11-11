using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BondShopper.Model
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        //[Required]
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Bond> Holdings { get; set; }
    }
}
