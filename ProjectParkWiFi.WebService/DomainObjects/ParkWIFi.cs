using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWiFi.DomainObjects
{
    public class ParkWiFi : DomainObject
    {
        public string status { get; set; }

        public string Name { get; set; }

        public string ParkName { get; set; } 
        public string wifiName { get; set; } 
    }
}
