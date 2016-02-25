using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace common.model {
    public class SuperheroAbility {
        [DataMember]
        public string Name { get; set; }

        public SuperheroAbility(string name) {
            Name = name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
