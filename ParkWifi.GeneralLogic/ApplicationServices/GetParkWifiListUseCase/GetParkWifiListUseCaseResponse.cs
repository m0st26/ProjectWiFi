using ParkWifi.DomainObjects;
using ParkWifi.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWifi.ApplicationServices.GetParkNameListUseCase
{
    public class GetParkWifiListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<parkwifi> ParkWifis { get; }

        public GetParkWifiListUseCaseResponse(IEnumerable<parkwifi> parkwifis) => ParkWifis = parkwifis;
    }
}
