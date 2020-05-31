using ParkWifi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using System.Linq.Expressions;
using ParkWifi.ApplicationServices.Ports;
using ParkWifi.DomainObjects.Ports;
using ParkWifi.ApplicationServices.Repositories;

namespace ParkWifi.WebService.Core.Tests
{
    public class GetParkWifiListUseCaseTest
    {
        private InMemoryParkWifiRepository CreateParkWifiRepository()
        {
            var repo = new InMemoryParkWifiRepository(new List<DomainObjects.parkwifi> {
                new DomainObjects.parkwifi { Id = 1, ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", Name = "Точка доступа №337"},
                new DomainObjects.parkwifi { Id = 2, ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", Name = "Точка доступа №338"},
                new DomainObjects.parkwifi { Id = 3, ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", Name = "Точка доступа №339"},
                new DomainObjects.parkwifi { Id = 4, ParkName = "Государственное автономное учреждение культуры города Москвы «Государственный историко-архитектурный и природно-ландшафтный музей-заповедник Кузьминки-Люблино, Парк Кузбминки", Name = "Точка доступа №340"},
            });
            return repo;
        }
        [Fact]
        public void TestGetAllParkWifi()
        {
            var useCase = new GetParkWifiListUseCase(CreateParkWifiRepository());
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetParkWifiListUseCaseRequest.CreateAllParkWifisRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.ParkWifis.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.ParkWifis.Select(mp => mp.Id));
        }

        [Fact]
        public void TestGetAllParkWifisFromEmptyRepository()
        {
            var useCase = new GetParkWifiListUseCase(new InMemoryParkWifiRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkWifiListUseCaseRequest.CreateAllParkWifisRequest(), outputPort).Result);
            Assert.Empty(outputPort.ParkWifis);
        }

        [Fact]
        public void TestGetParkWifi()
        {
            var useCase = new GetParkWifiListUseCase(CreateParkWifiRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkWifiListUseCaseRequest.CreateParkWifiRequest(2), outputPort).Result);
            Assert.Single(outputPort.ParkWifis, pn => 2 == pn.Id);
        }

        [Fact]
        public void TestTryGetNotExistingParkWifi()
        {
            var useCase = new GetParkWifiListUseCase(CreateParkWifiRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkWifiListUseCaseRequest.CreateParkWifiRequest(999), outputPort).Result);
            Assert.Empty(outputPort.ParkWifis);
        }
      
    }

    class OutputPort : IOutputPort<GetParkWifiListUseCaseResponse>
    {
        public IEnumerable<DomainObjects.parkwifi> ParkWifis { get; private set; }

        public void Handle(GetParkWifiListUseCaseResponse response)
        {
            ParkWifis = response.ParkWifis;
        }
    }
}
