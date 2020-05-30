using ParkWifi.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkWifi.ApplicationServices.GetParkNameListUseCase
{
    public class GetParkWifiListUseCaseRequest : IUseCaseRequest<GetParkWifiListUseCaseResponse>
    {
        public string ParkName { get; private set; }
        public long? ParkWifiId { get; private set; }

        private GetParkWifiListUseCaseRequest()
        { }

        public static GetParkWifiListUseCaseRequest CreateAllParkWifisRequest()
        {
            return new GetParkWifiListUseCaseRequest();
        }

        public static GetParkWifiListUseCaseRequest CreateParkWifiRequest(long parkwifiId)
        {
            return new GetParkWifiListUseCaseRequest() { ParkWifiId = parkwifiId };
        }
        public static GetParkWifiListUseCaseRequest CreateParkWifisRequest(string parkname)
        {
            return new GetParkWifiListUseCaseRequest() { ParkName = parkname };
        }
    }
}
