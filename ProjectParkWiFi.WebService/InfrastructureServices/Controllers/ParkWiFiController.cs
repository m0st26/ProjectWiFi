using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkWiFi.DomainObjects;
using ParkWiFi.ApplicationServices.GetParkWiFiListUseCase;
using ParkWiFi.InfrastructureServices.Presenters;

namespace ParkWiFi.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkWiFiController : ControllerBase
    {
        private readonly ILogger<ParkWiFiController> _logger;
        private readonly IGetParkWiFiListUseCase _getParkWiFiListUseCase;

        public ParkWiFiController(ILogger<ParkWiFiController> logger,
                                IGetParkWiFiListUseCase getParkWiFiListUseCase)
        {
            _logger = logger;
            _getParkWiFiListUseCase = getParkWiFiListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllParkWiFi()
        {
            var presenter = new ParkWiFiListPresenter();
            await _getParkWiFiListUseCase.Handle(GetParkWiFiListUseCaseRequest.CreateAllParkWiFiRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{parkwifiId}")]
        public async Task<ActionResult> GetParkWiFi(long parkwifiId)
        {
            var presenter = new ParkWiFiListPresenter();
            await _getParkWiFiListUseCase.Handle(GetParkWiFiListUseCaseRequest.CreateParkWiFiRequest(parkwifiId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("ParkNames/{parkname}")]
        public async Task<ActionResult> GetParkNameFilter(string prescription)
        {
            var presenter = new ParkWiFiListPresenter();
            await _getParkWiFiListUseCase.Handle(GetParkWiFiListUseCaseRequest.CreateParkNameParkWiFiRequest(prescription), presenter);
            return presenter.ContentResult;
        }
    }
}
