using MonitoringApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringApp.Services
{
    public interface IDataService
    {
        IEnumerable<Data> GetDates();
    }
}
