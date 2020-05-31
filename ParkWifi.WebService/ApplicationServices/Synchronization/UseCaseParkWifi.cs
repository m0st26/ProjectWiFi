using System;
using System.Collections.Generic;
using System.Net;
using ParkWifi.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using ParkWifi.InfrastructureServices.Gateways.Database;
namespace ParkWifi.ApplicationServices.Synchronization
{
    public class ParkWifi_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public ParkWifi_inf Cells { get; set; }   
    }

    public class ParkWifi_inf
    {
        public long global_id { get; set; }
        public string FunctionFlag { get; set; }
        public string Name { get; set; }
        public string ParkName { get; set; }
        public string wifiName { get; set; }
    }
}

