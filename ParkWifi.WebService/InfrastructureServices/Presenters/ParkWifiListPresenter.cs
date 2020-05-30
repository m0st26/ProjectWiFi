using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using System.Net;
using Newtonsoft.Json;
using ParkWifi.ApplicationServices.Ports;

namespace ParkWifi.InfrastructureServices.Presenters
{
    public class ParkWifiListPresenter : IOutputPort<GetParkWifiListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ParkWifiListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetParkWifiListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.ParkWifis) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
