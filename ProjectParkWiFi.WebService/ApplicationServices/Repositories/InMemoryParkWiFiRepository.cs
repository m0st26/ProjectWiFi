using ParkWiFi.DomainObjects;
using ParkWiFi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWiFi.ApplicationServices.Repositories
{
    public class InMemoryParkWiFiRepository : IReadOnlyParkWiFiRepository,
                                           IParkWiFiRepository 
    {
        private readonly List<DomainObjects.ParkWiFi> _parkwifis = new List<DomainObjects.ParkWiFi>();

        public InMemoryParkWiFiRepository(IEnumerable<DomainObjects.ParkWiFi> parkwifis = null)
        {
            if (parkwifis != null)
            {
                _parkwifis.AddRange(parkwifis);
            }
        }

        public Task AddParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            _parkwifis.Add(parkwifi);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<DomainObjects.ParkWiFi>> GetAllParkWiFi()
        {
            return Task.FromResult(_parkwifis.AsEnumerable());
        }

        public Task<DomainObjects.ParkWiFi> GetParkWiFi(long id)
        {
            return Task.FromResult(_parkwifis.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<DomainObjects.ParkWiFi>> QueryParkWiFi(ICriteria<DomainObjects.ParkWiFi> criteria)
        {
            return Task.FromResult(_parkwifis.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            _parkwifis.Remove(parkwifi);
            return Task.CompletedTask;
        }

        public Task UpdateParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            var foundParkWiFi = GetParkWiFi(parkwifi.Id).Result;
            if (foundParkWiFi == null)
            {
                AddParkWiFi(parkwifi);
            }
            else
            {
                if (foundParkWiFi != parkwifi)
                {
                    _parkwifis.Remove(foundParkWiFi);
                    _parkwifis.Add(parkwifi);
                }
            }
            return Task.CompletedTask;
        }
    }
}
