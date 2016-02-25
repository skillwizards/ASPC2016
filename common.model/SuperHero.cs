using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace common.model
{
    public class SuperHero
    {
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Alias { get; set; }

        public SuperHero(string firstname, string lastname, string alias) {
            Firstname = firstname;
            Lastname = lastname;
            Alias = alias;
        }

        public GeoLocation LastKnownLocation { get; set; }
        public string AbilityDescription { get; set; }
        public List<SuperHero> GropAffiliations = new List<SuperHero>();

        public override string ToString() {
            string toString = "";
            toString = Firstname + " " + Lastname + " (" + Alias + ")";

            return toString;
        }
    }
}
