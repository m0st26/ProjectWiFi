using ParkWiFi.DomainObjects;
using ParkWiFi.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWiFi.ApplicationServices.GetParkWiFiListUseCase
{
    public class GetParkWiFiListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<DomainObjects.ParkWiFi> ParkWiFi { get; }

        public GetParkWiFiListUseCaseResponse(IEnumerable<DomainObjects.ParkWiFi> parkwifi) => ParkWiFi = parkwifi;
    }
}
