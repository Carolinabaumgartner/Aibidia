using First.Storage;
using First.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Managers.Aibidia
{
    public class DataBaseManager
    {
        private AibidiaDatabaseContext _context;

        public DataBaseManager()
        {
            _context = new AibidiaDatabaseContext();
        }

        public List<Continent> GetContinents()
        {
            return _context.Continents.ToList();
        }
    }
}
