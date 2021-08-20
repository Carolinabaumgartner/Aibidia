using First.Managers.Aibidia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Controllers
{
    public class AibidiaController : Controller
    {
        private DataBaseManager manager;
        public AibidiaController()
        {
            manager = new DataBaseManager();
        }
        public IActionResult Index()
        {
            return View(manager.GetContinents());
        }

        public IActionResult Continents()
        {
            return View(manager.GetContinents());
        }

        public IActionResult Countries(int? id)
        {
            if (id is null)
                return View(manager.GetCountries());
            else
                return View(manager.GetCountriesByContinentId(id.Value));
        }

        public IActionResult Companies(int? id)
        {
           if (id is null)
            return View(manager.GetCompanies());
           else
                return View(manager.GetCompaniesByCountryId(id.Value)); 

        }


        public IActionResult Rulings()
        {
            return View(manager.GetRulings());
        }

        public IActionResult Agreements()
        {
            return View(manager.GetAgreements());
        }

        public IActionResult Legislations()
        {
            return View(manager.GetLegislations());
        }
    }
}
