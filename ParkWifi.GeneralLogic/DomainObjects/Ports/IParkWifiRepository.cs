using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ParkWifi.DomainObjects.Ports
{
    public interface IReadOnlyParkWifiRepository
    {
        Task<parkwifi> GetParkWifi(long id);

        Task<IEnumerable<parkwifi>> GetAllParkWifis();

        Task<IEnumerable<parkwifi>> QueryParkWifis(ICriteria<parkwifi> criteria);

    }

    public interface IParkWifiRepository
    {
        Task AddParkWifi(parkwifi parkwifi);

        Task RemoveParkWifi(parkwifi parkwifi);

        Task UpdateParkWifi(parkwifi parkwifi);
    }
}
