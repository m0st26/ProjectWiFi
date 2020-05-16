using ParkWiFi.ApplicationServices.Ports.Gateways.Database;
using ParkWiFi.DomainObjects;
using ParkWiFi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkWiFi.ApplicationServices.Repositories
{
    public class DbParkWiFiRepository : IReadOnlyParkWiFiRepository,
                                     IParkWiFiRepository
    {
        private readonly IParkWiFiDatabaseGateway _databaseGateway;

        public DbParkWiFiRepository(IParkWiFiDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<DomainObjects.ParkWiFi> GetParkWiFi(long id)
            => await _databaseGateway.GetParkWiFi(id);

        public async Task<IEnumerable<DomainObjects.ParkWiFi>> GetAllParkWiFi()
            => await _databaseGateway.GetAllParkWiFi();

        public async Task<IEnumerable<DomainObjects.ParkWiFi>> QueryParkWiFi(ICriteria<DomainObjects.ParkWiFi> criteria)
            => await _databaseGateway.QueryParkWiFi(criteria.Filter);

        public async Task AddParkWiFi(DomainObjects.ParkWiFi parkwifi)
            => await _databaseGateway.AddParkWiFi(parkwifi);

        public async Task RemoveParkWiFi(DomainObjects.ParkWiFi parkwifi)
            => await _databaseGateway.RemoveParkWiFi(parkwifi);

        public async Task UpdateParkWiFi(DomainObjects.ParkWiFi parkwifi)
            => await _databaseGateway.UpdateParkWiFi(parkwifi);
    }
}
