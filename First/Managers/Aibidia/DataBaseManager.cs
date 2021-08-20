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

        public List<Country> GetCountriesByContinentId(int continentId)
        {
            return _context.Countries.Include(c => c.Continent)
                .Where(c => c.ContinentID == continentId)
                .ToList();
        }

        public List<Company> GetCompanies()
        {
            return _context.Companies.Include(c => c.Country).ThenInclude(c => c.Continent).ToList();
        }

        public List<Company> GetCompaniesByCountryId(int countryId)
        {
            return _context.Companies.Include(c => c.Country)
                .ThenInclude(c => c.Continent)
                .Where(c => c.CountryID == countryId) 
                .ToList();
        }

        public List<Ruling> GetRulings()
        {
            return _context.Rulings.Include(c => c.Company).ThenInclude(c => c.Country).ThenInclude(c => c.Continent).ToList();
        }

        public List<Agreement> GetAgreements()
        {
            return _context.Agreements.Include(c => c.Company1).ThenInclude(c1 => c1.Country).ThenInclude(contry1 => contry1.Continent)
                .Include(c => c.Company2).ThenInclude(c2 => c2.Country).ThenInclude(contry2 => contry2.Continent).ToList();
        }

        public List<Legislation> GetLegislations()
        {
            return _context.Legislations.Include(c => c.Country).ThenInclude(c => c.Continent).ToList();
        }

    }

}