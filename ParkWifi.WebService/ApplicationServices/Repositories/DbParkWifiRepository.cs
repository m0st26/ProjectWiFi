using ParkWifi.ApplicationServices.Ports.Gateways.Database;
using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkWifi.ApplicationServices.Repositories
{
    public class DbParkWifiRepository : IReadOnlyParkWifiRepository,
                                     IParkWifiRepository
    {
        private readonly IParkWifiDatabaseGateway _databaseGateway;

        public DbParkWifiRepository(IParkWifiDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<parkwifi> GetParkWifi(long id)
            => await _databaseGateway.GetParkWifi(id);

        public async Task<IEnumerable<parkwifi>> GetAllParkWifis()
            => await _databaseGateway.GetAllParkWifis();

        public async Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria)
            => await _databaseGateway.QueryParkWifis(criteria.Filter);

        public async Task AddParkWifi(parkwifi parkwifi)
            => await _databaseGateway.AddParkWifi(parkwifi);

        public async Task RemoveParkWifi(parkwifi parkwifi)
            => await _databaseGateway.RemoveParkWifi(parkwifi);

        public async Task UpdateParkWifi(parkwifi parkwifi)
            => await _databaseGateway.UpdateParkWifi(parkwifi);
    }
}
