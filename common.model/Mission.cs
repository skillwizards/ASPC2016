using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace common.model {
    public class Mission {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public GeoLocation Location { get; set; }
        [DataMember]
        public SuperHero HiredHer { get; set; }
        [DataMember]
        public List<SuperHero>  AssistingHeroes { get; set; }

        public Mission(string name, string description, string customer, GeoLocation location) {
            Name = name;
            Description = description;


        }

        public override string ToString() {
            return Name;
        }
    }
}

