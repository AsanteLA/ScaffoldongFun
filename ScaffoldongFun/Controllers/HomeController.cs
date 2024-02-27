using Microsoft.AspNetCore.Mvc;
using ScaffoldongFun.Models;
using SQLitePCL;
using System.Diagnostics;

namespace ScaffoldongFun.Controllers
{
    public class HomeController : Controller
    {
        private IBaseballRepository _repo
            ;
        public HomeController(IBaseballRepository temp)
        {
            _repo = temp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var blah = _repo.Managers.
            //    FirstOrDefault(x => x.PlayerId == "wrighha01");

            return View(new Manager());
        }

        [HttpPost]
        public IActionResult Index(Manager m)
        {
            if (ModelState.IsValid)
            {
                _repo.AddManager(m);

            }

            return View(new Manager());
        }
    }
}
