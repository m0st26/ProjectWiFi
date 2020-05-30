using ParkWifi.ApplicationServices.Ports.Cache;
using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkWifi.InfrastructureServices.Repositories
{
    public class NetworkParkWifiRepository : NetworkRepositoryBase, IReadOnlyParkWifiRepository
    {
        private readonly IDomainObjectsCache<parkwifi> _parkwifiCache;

        public NetworkParkWifiRepository(string host, ushort port, bool useTls, IDomainObjectsCache<parkwifi> parkwifiCache)
            : base(host, port, useTls)
            => _parkwifiCache = parkwifiCache;

        public async Task<parkwifi> GetParkWifi(long id)
            => CacheAndReturn(await ExecuteHttpRequest<parkwifi>($"parkwifis/{id}"));

        public async Task<IEnumerable<parkwifi>> GetAllParkWifis()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<parkwifi>>($"parkwifis"), allObjects: true);

        public async Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<parkwifi>>($"parkwifis"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<parkwifi> CacheAndReturn(IEnumerable<parkwifi> parkwifis, bool allObjects = false)
        {
            if (allObjects)
            {
                _parkwifiCache.ClearCache();
            }
            _parkwifiCache.UpdateObjects(parkwifis, DateTime.Now.AddDays(1), allObjects);
            return parkwifis;
        }

        private parkwifi CacheAndReturn(parkwifi parkwifi)
        {
            _parkwifiCache.UpdateObject(parkwifi, DateTime.Now.AddDays(1));
            return parkwifi;
        }
    }
}
