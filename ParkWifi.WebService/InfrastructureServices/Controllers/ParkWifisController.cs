using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkWifi.DomainObjects;
using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using ParkWifi.InfrastructureServices.Presenters;

namespace ParkWifi.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkWifisController : ControllerBase
    {
        private readonly ILogger<ParkWifisController> _logger;
        private readonly IGetParkWifiListUseCase _getParkWifiListUseCase;

        public ParkWifisController(ILogger<ParkWifisController> logger,
                                IGetParkWifiListUseCase getParkWifiListUseCase)
        {
            _logger = logger;
            _getParkWifiListUseCase = getParkWifiListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllParkWifis()
        {
            var presenter = new ParkWifiListPresenter();
            await _getParkWifiListUseCase.Handle(GetParkWifiListUseCaseRequest.CreateAllParkWifisRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{parkwifiId}")]
        public async Task<ActionResult> GetParkWifi(long parkwifiId)
        {
            var presenter = new ParkWifiListPresenter();
            await _getParkWifiListUseCase.Handle(GetParkWifiListUseCaseRequest.CreateParkWifiRequest(parkwifiId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("parkname/{parkname}")]
        public async Task<ActionResult> GetParkNameParkWifis(string parkname)
        {
            var presenter = new ParkWifiListPresenter();
            await _getParkWifiListUseCase.Handle(GetParkWifiListUseCaseRequest.CreateParkWifisRequest(parkname), presenter);
            return presenter.ContentResult;
        }
    }
}
