using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ParkWifi.ApplicationServices.GetParkNameListUseCase
{
    public class ParkNameCriteria : ICriteria<parkwifi>
    {
        public string ParkName { get; }

        public ParkNameCriteria (string parkname)
            => ParkName = parkname;

        public Expression<Func<parkwifi, bool>> Filter
            => (b => b.ParkName == ParkName);
    }
}
