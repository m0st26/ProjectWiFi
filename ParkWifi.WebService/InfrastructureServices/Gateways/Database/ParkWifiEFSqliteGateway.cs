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

        public async Task<parkwifi> GetParkWifi(long id)
           => await _parkwifiContext.ParkWifis.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<parkwifi>> GetAllParkWifis()
            => await _parkwifiContext.ParkWifis.ToListAsync();
          
        public async Task<IEnumerable<parkwifi>> QueryParkWifis(Expression<Func<parkwifi, bool>> filter)
            => await _parkwifiContext.ParkWifis.Where(filter).ToListAsync();

        public async Task AddParkWifi(parkwifi parkwifi)
        {
            _parkwifiContext.ParkWifis.Add(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task UpdateParkWifi(parkwifi parkwifi)
        {
            _parkwifiContext.Entry(parkwifi).State = EntityState.Modified;
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task RemoveParkWifi(parkwifi parkwifi)
        {
            _parkwifiContext.ParkWifis.Remove(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }

    }
}
