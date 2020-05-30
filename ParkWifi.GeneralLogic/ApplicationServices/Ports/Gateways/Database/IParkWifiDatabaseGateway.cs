using ParkWifi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkWifi.ApplicationServices.Ports.Gateways.Database
{
    public interface IParkWifiDatabaseGateway
    {
        Task AddParkWifi(parkwifi parkwifi);

        Task RemoveParkWifi(parkwifi parkwifi);

        Task UpdateParkWifi(parkwifi parkwifi);

        Task<parkwifi> GetParkWifi(long id);

        Task<IEnumerable<parkwifi>> GetAllParkWifis();

        Task<IEnumerable<parkwifi>> QueryParkWifis(Expression<Func<parkwifi, bool>> filter);

    }
}
