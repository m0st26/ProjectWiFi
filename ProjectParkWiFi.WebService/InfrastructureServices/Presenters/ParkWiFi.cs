using ParkWiFi.ApplicationServices.GetParkWiFiListUseCase;
using System.Net;
using Newtonsoft.Json;
using ParkWiFi.ApplicationServices.Ports;

namespace ParkWiFi.InfrastructureServices.Presenters
{
    public class ParkWiFiListPresenter : IOutputPort<GetParkWiFiListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ParkWiFiListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetParkWiFiListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.ParkWiFi) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
