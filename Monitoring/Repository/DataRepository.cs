using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonitoringApp.Models;

namespace MonitoringApp.Repository
{
    public class DataRepository : IDataRepository
    {
        private List<Data> _items;
        private IEnumerable<string> _names = new List<string> { "PZU", "SDU", "DUE", "SWQ", "SAX", "SDW", "EWQ", "UAH", "DOZ" };
        private IEnumerable<string> _names1 = new List<string> {  "SDU", "PZU", "DUE", "SWQ", "SAX", "SDW", "EWQ", "UAH", "DOZ" };
        private static int idx = 0;

        public DataRepository()
        {
            _items = _names.Select(n => new Data() { Name = n }).ToList();
        }


        public IEnumerable<Data> GetDatas()
        {
            if(idx % 2 == 0)
            {
                _items = _names.Select(n => new Data() { Name = n }).ToList();
            }
            else
            {
                _items = _names1.Select(n => new Data() { Name = n }).ToList();
            }



            idx += 1;


            var rand = new Random();
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].Price = rand.NextDouble() * (100 - 1) + 1;
            }

            return _items;
        }
    }
}
