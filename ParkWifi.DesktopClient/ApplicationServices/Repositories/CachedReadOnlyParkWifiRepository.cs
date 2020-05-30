using ParkWifi.ApplicationServices.Ports.Cache;
using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using ParkWifi.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWifi.ApplicationServices.Repositories
{
    public class CachedReadOnlyParkWifiRepository : ReadOnlyParkWifiRepositoryDecorator
    {
        private readonly IDomainObjectsCache<parkwifi> _parkwifisCache;

        public CachedReadOnlyParkWifiRepository(IReadOnlyParkWifiRepository parkwifiRepository, 
                                             IDomainObjectsCache<parkwifi> parkwifisCache)
            : base(parkwifiRepository)
            => _parkwifisCache = parkwifisCache;

        public async override Task<parkwifi> GetParkWifi(long id)
            => _parkwifisCache.GetObject(id) ?? await base.GetParkWifi(id);

        public async override Task<IEnumerable<parkwifi>> GetAllParkWifis()
            => _parkwifisCache.GetObjects() ?? await base.GetAllParkWifis();

        public async override Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria)
            => _parkwifisCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryParkWifis(criteria);

    }
}
