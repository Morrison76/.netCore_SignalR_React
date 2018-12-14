using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonitoringApp.Models;
using MonitoringApp.Repository;

namespace MonitoringApp.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository _repository;

        public DataService(IDataRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Data> GetDates()
        {
            return _repository.GetDatas();
        }
    }
}
