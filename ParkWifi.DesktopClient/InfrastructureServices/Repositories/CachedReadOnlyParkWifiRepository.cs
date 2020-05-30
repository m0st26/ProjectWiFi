using parkwifi.ApplicationServices.Ports.Cache;
using parkwifi.DomainObjects;
using parkwifi.DomainObjects.Ports;
using parkwifi.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace parkwifi.InfrastructureServices.Repositories
{
    public class CachedReadOnlyParkWifiRepository : ReadOnlyParkWifiRepositoryDecorator
    {
        private readonly IDomainObjectsCache<DomainObjects.ParkWifi> _parkwifisCache;

        public CachedReadOnlyParkWifiRepository(IReadOnlyParkWifiRepository parkwifiRepository, 
                                             IDomainObjectsCache<DomainObjects.ParkWifi> parkwifisCache)
            : base(parkwifiRepository)
            => _parkwifisCache = parkwifisCache;

        public async override Task<DomainObjects.ParkWifi> GetParkWifi(long id)
            => _parkwifisCache.GetObject(id) ?? await base.GetParkWifi(id);

        public async override Task<IEnumerable<DomainObjects.ParkWifi>> GetAllParkWifis()
            => _parkwifisCache.GetObjects() ?? await base.GetAllParkWifis();

        public async override Task<IEnumerable<DomainObjects.ParkWifi>> QueryParkWifis(ICriteria<DomainObjects.ParkWifi> criteria)
            => _parkwifisCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryParkWifis(criteria);

    }
}
