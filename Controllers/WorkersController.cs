using eserS5L1.Models;
using Microsoft.AspNetCore.Mvc;

namespace eserS5L1.Controllers
{
    public class WorkersController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.Workers);
        }

        public IActionResult RegisterWorker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterWorker(string name, string lastName, string address, string fiscalCode, bool isMarried, int howManyChildren, string position)
        {
            StaticDB.Add(name, lastName, address, fiscalCode, isMarried, howManyChildren, position);

            return RedirectToAction("Index", "Workers");
        }
    }
}
