using System.Threading.Tasks;
using System.Collections.Generic;
using ParkWiFi.DomainObjects;
using ParkWiFi.DomainObjects.Ports;
using ParkWiFi.ApplicationServices.Ports;

namespace ParkWiFi.ApplicationServices.GetParkWiFiListUseCase
{
    public class GetParkWiFiListUseCase : IGetParkWiFiListUseCase
    {
        private readonly IReadOnlyParkWiFiRepository _readOnlyParkWiFiRepository;

        public GetParkWiFiListUseCase(IReadOnlyParkWiFiRepository readOnlyParkWiFiRepository) 
            => _readOnlyParkWiFiRepository = readOnlyParkWiFiRepository;

        public async Task<bool> Handle(GetParkWiFiListUseCaseRequest request, IOutputPort<GetParkWiFiListUseCaseResponse> outputPort)
        {
            IEnumerable<DomainObjects.ParkWiFi> parkwifis = null;
            if (request.ParkWiFiId != null)
            {
                var parkwifi = await _readOnlyParkWiFiRepository.GetParkWiFi(request.ParkWiFiId.Value);
                parkwifis = (parkwifi != null) ? new List<DomainObjects.ParkWiFi>() { parkwifi } : new List<DomainObjects.ParkWiFi>();
                
            }
            else if (request.ParkName != null)
            {
                parkwifis = await _readOnlyParkWiFiRepository.QueryParkWiFi(new ParkNameCriteria(request.ParkName));
            }
            else
            {
                parkwifis = await _readOnlyParkWiFiRepository.GetAllParkWiFi();
            }
            outputPort.Handle(new GetParkWiFiListUseCaseResponse(parkwifis));
            return true;
        }
    }
}
