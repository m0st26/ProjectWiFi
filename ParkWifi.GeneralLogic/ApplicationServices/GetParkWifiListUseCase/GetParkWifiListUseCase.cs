using System.Threading.Tasks;
using System.Collections.Generic;
using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using ParkWifi.ApplicationServices.Ports;

namespace ParkWifi.ApplicationServices.GetParkNameListUseCase
{
    public class GetParkWifiListUseCase : IGetParkWifiListUseCase
    {
        private readonly IReadOnlyParkWifiRepository _readOnlyParkWifiRepository;

        public GetParkWifiListUseCase(IReadOnlyParkWifiRepository readOnlyParkWifiRepository) 
            => _readOnlyParkWifiRepository = readOnlyParkWifiRepository;

        public async Task<bool> Handle(GetParkWifiListUseCaseRequest request, IOutputPort<GetParkWifiListUseCaseResponse> outputPort)
        {
            IEnumerable<parkwifi> parkwifis = null;
            if (request.ParkWifiId != null)
            {
                var parkwifi = await _readOnlyParkWifiRepository.GetParkWifi(request.ParkWifiId.Value);
                parkwifis = (parkwifi != null) ? new List<parkwifi>() { parkwifi } : new List<parkwifi>();
                
            }
            else if (request.ParkName != null)
            {
                parkwifis = await _readOnlyParkWifiRepository.QueryParkWifis(new ParkNameCriteria(request.ParkName));
            }
            else
            {
                parkwifis = await _readOnlyParkWifiRepository.GetAllParkWifis();
            }
            outputPort.Handle(new GetParkWifiListUseCaseResponse(parkwifis));
            return true;
        }
    }
}
