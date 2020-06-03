using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkWifi.WebService.InfrastructureServices.Gateways
{
    public class Cells
    {
        public string FunctionFlag { get; set; }
        public string Name { get; set; }
        public string ParkName { get; set; }
        public string wifiName { get; set; }
        public string TechnicalCharacteristics { get; set; }
    }

    public class ResultFromServer
    {
        public int Number { get; set; }
        public Cells Cells { get; set; }
    }
}
