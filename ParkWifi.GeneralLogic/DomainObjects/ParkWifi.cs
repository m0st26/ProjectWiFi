using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWifi.DomainObjects
{
  public class parkwifi : DomainObject
    {

        public string FunctionFlag { get; set; }

        public string Name { get; set; }

        public string ParkName { get; set; }

        public string wifiName { get; set; }

    }
}
