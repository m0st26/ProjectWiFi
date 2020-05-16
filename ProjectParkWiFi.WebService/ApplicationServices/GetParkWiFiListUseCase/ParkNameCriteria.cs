using ParkWiFi.DomainObjects;
using ParkWiFi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ParkWiFi.ApplicationServices.GetParkWiFiListUseCase
{
    public class ParkNameCriteria : ICriteria<DomainObjects.ParkWiFi>
    {
        public string ParkName { get; } // критерий фильтрации 

        public ParkNameCriteria(string parkname) 
            => ParkName = parkname;

        public Expression<Func<DomainObjects.ParkWiFi, bool>> Filter
            => (pw => pw.ParkName == ParkName); 
    }
}
