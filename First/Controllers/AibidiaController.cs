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

        public IActionResult Countries()
        {
            return View(manager.GetCountries());
        }

        public IActionResult Companies()
        {
            return View(manager.GetCompanies());
        }

        public IActionResult Rulings()
        {
            return View(manager.GetRulings());
        }
    }
}
