using ParkWiFi.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWiFi.ApplicationServices.GetParkWiFiListUseCase
{
    public class GetParkWiFiListUseCaseRequest : IUseCaseRequest<GetParkWiFiListUseCaseResponse>
    {
        public string ParkName { get; private set; }
        public long? ParkWiFiId { get; private set; }

        private GetParkWiFiListUseCaseRequest()
        { }

        public static GetParkWiFiListUseCaseRequest CreateAllParkWiFiRequest()
        {
            return new GetParkWiFiListUseCaseRequest();
        }

        public static GetParkWiFiListUseCaseRequest CreateParkWiFiRequest(long parkwifiId)
        {
            return new GetParkWiFiListUseCaseRequest() { ParkWiFiId = parkwifiId };
        }
        public static GetParkWiFiListUseCaseRequest CreateParkNameParkWiFiRequest(string parkwifis)
        {
            return new GetParkWiFiListUseCaseRequest() { ParkName = parkwifis };
        }
    }
}
