using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWifi.ApplicationServices.Repositories
{
    public class InMemoryParkWifiRepository : IReadOnlyParkWifiRepository,
                                           IParkWifiRepository 
    {
        private readonly List<parkwifi> _parkwifis = new List<parkwifi>();

        public InMemoryParkWifiRepository(IEnumerable<parkwifi> parkwifis = null)
        {
            if (parkwifis != null)
            {
                _parkwifis.AddRange(parkwifis);
            }
        }

        public Task AddParkWifi(parkwifi parkwifi)
        {
            _parkwifis.Add(parkwifi);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<parkwifi>> GetAllParkWifis()
        {
            return Task.FromResult(_parkwifis.AsEnumerable());
        }

        public Task<parkwifi> GetParkWifi(long id)
        {
            return Task.FromResult(_parkwifis.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria)
        {
            return Task.FromResult(_parkwifis.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveParkWifi(parkwifi parkwifi)
        {
            _parkwifis.Remove(parkwifi);
            return Task.CompletedTask;
        }

        public Task UpdateParkWifi(parkwifi parkwifi)
        {
            var foundParkWifi = GetParkWifi(parkwifi.Id).Result;
            if (foundParkWifi == null)
            {
                AddParkWifi(parkwifi);
            }
            else
            {
                if (foundParkWifi != parkwifi)
                {
                    _parkwifis.Remove(foundParkWifi);
                    _parkwifis.Add(parkwifi);
                }
            }
            return Task.CompletedTask;
        }
    }
}
