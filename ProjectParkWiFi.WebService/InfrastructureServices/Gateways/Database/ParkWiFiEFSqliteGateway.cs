using ParkWiFi.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using ParkWiFi.ApplicationServices.Ports.Gateways.Database;

namespace ParkWiFi.InfrastructureServices.Gateways.Database
{
    public class ParkWiFiEFSqliteGateway : IParkWiFiDatabaseGateway
    {
        private readonly ParkWiFiContext _parkwifiContext;

        public ParkWiFiEFSqliteGateway(ParkWiFiContext parkwifiContext)
            => _parkwifiContext = parkwifiContext;

        public async Task<DomainObjects.ParkWiFi> GetParkWiFi(long id)
           => await _parkwifiContext.ParkWiFis.FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.ParkWiFi>> GetAllParkWiFi()
            => await _parkwifiContext.ParkWiFis.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.ParkWiFi>> QueryParkWiFi(Expression<Func<DomainObjects.ParkWiFi, bool>> filter)
            => await _parkwifiContext.ParkWiFis.Where(filter).ToListAsync();

        public async Task AddParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            _parkwifiContext.ParkWiFis.Add(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task UpdateParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            _parkwifiContext.Entry(parkwifi).State = EntityState.Modified;
            await _parkwifiContext.SaveChangesAsync();
        }

        public async Task RemoveParkWiFi(DomainObjects.ParkWiFi parkwifi)
        {
            _parkwifiContext.ParkWiFis.Remove(parkwifi);
            await _parkwifiContext.SaveChangesAsync();
        }


       
    }
}
