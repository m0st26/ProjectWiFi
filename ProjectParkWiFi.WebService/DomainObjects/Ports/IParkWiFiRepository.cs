using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ParkWiFi.DomainObjects.Ports
{
    public interface IReadOnlyParkWiFiRepository
    {
        Task<ParkWiFi> GetParkWiFi(long id);

        Task<IEnumerable<ParkWiFi>> GetAllParkWiFi();

        Task<IEnumerable<ParkWiFi>> QueryParkWiFi(ICriteria<ParkWiFi> criteria);

    }

    public interface IParkWiFiRepository
    {
        Task AddParkWiFi(ParkWiFi parkwifi);

        Task RemoveParkWiFi(ParkWiFi parkwifi);

        Task UpdateParkWiFi(ParkWiFi parkwifi);
    }
}
