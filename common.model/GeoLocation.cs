using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace common.model {
    public class GeoLocation {
        
        [DataMember]
       public double Longitude { get; set; } 

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        int Altitude { get; set; }

        public GeoLocation(double longitude, double latitude) {
            Longitude = longitude;
            Latitude = latitude;
        }

        public override string ToString() {
            return "lat: " + Latitude + " long: " + Longitude;

        }
    }
}
