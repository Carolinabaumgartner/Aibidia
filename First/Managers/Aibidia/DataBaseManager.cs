using First.Storage;
using First.Storage.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace First.Managers.Aibidia
{
    public class DataBaseManager
    {
        private readonly AibidiaDatabaseContext _context;

        public DataBaseManager()
        {
            _context = new AibidiaDatabaseContext();
        }

        public List<Continent> GetContinents()
        {
            return _context.Continents.ToList();
        }

        public List<Country> GetCountries()
        {
            return _context.Countries.Include(c => c.Continent).ToList();
        }

        public List<Company> GetCompanies()
            {
            return _context.Companies.Include(c => c.Country).ThenInclude(c => c.Continent).ToList();
        }
    }
}
