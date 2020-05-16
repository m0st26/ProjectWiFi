using ParkWiFi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWiFi.ApplicationServices.Ports.Gateways.Database
{
    public interface IParkWiFiDatabaseGateway
    {
        Task AddParkWiFi(DomainObjects.ParkWiFi parkwifi);

        Task RemoveParkWiFi(DomainObjects.ParkWiFi parkwifi);

        Task UpdateParkWiFi(DomainObjects.ParkWiFi parkwifi);

        Task<DomainObjects.ParkWiFi> GetParkWiFi(long id);

        Task<IEnumerable<DomainObjects.ParkWiFi>> GetAllParkWiFi();

        Task<IEnumerable<DomainObjects.ParkWiFi>> QueryParkWiFi(Expression<Func<DomainObjects.ParkWiFi, bool>> filter);

    }
}
