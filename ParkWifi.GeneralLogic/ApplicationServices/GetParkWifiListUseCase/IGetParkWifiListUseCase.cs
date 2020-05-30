using System;
using System.Collections.Generic;
using System.Text;
using ParkWifi.ApplicationServices.Interfaces;

namespace ParkWifi.ApplicationServices.GetParkNameListUseCase
{
    public interface IGetParkWifiListUseCase 
        : IUseCase<GetParkWifiListUseCaseRequest, GetParkWifiListUseCaseResponse>
    {
    }
}
