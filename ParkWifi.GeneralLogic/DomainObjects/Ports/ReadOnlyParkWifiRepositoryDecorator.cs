using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWifi.DomainObjects.Repositories
{
    public abstract class ReadOnlyParkWifiRepositoryDecorator : IReadOnlyParkWifiRepository
    {
        private readonly IReadOnlyParkWifiRepository _parkwifiRepository;

        public ReadOnlyParkWifiRepositoryDecorator(IReadOnlyParkWifiRepository parkwifiRepository)
        {
            _parkwifiRepository = parkwifiRepository;
        }

        public virtual async Task<IEnumerable<parkwifi>> GetAllParkWifis()
        {
            return await _parkwifiRepository?.GetAllParkWifis();
        }

        public virtual async Task<parkwifi> GetParkWifi(long id)
        {
            return await _parkwifiRepository?.GetParkWifi(id);
        }

        public virtual async Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria)
        {
            return await _parkwifiRepository?.QueryParkWifis(criteria);
        }
    }
}
