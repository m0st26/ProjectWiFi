using ParkWifi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using ParkWifi.ApplicationServices.Ports.Gateways.Database;

namespace ParkWifi.InfrastructureServices.Gateways.Database
{
    public class ParkWifiEFSqliteGateway : IParkWifiDatabaseGateway
    {
        private readonly ParkWifiContext _parkwifiContext;

        public ParkWifiEFSqliteGateway(ParkWifiContext ParkWifiContext)
            => _parkwifiContext = ParkWifiContext;

        public async Task<DomainObjects.parkwifi> GetParkWifi(long id)
           => await _parkwifiContext.ParkWifi.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.parkwifi>> GetAllParkWifis()
            => await _parkwifiContext.ParkWifi.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.parkwifi>> QueryParkWifis(Expression<Func<DomainObjects.parkwifi, bool>> filter)
            => await _parkwifiContext.ParkWifi.Where(filter).ToListAsync();

        public async Task AddParkWifi(DomainObjects.parkwifi parkwifi)
        {
            _parkwifiContext.ParkWifi.Add(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task UpdateParkWifi(DomainObjects.parkwifi parkwifi)
        {
            _parkwifiContext.Entry(parkwifi).State = EntityState.Modified;
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task RemoveParkWifi(DomainObjects.parkwifi parkwifi)
        {
            _parkwifiContext.ParkWifi.Remove(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }

    }
}
