using MonitoringApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringApp.Repository
{
    public interface IDataRepository
    {
        IEnumerable<Data> GetDatas();
    }
}
