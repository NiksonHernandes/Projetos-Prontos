using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Controllers
{
    public class TelasBlocosController : Controller
    {
        public IActionResult Florianopolis()
        {
            return View();
        }

        public IActionResult SobreNos()
        {
            return View();
        }
        public IActionResult Hotel()
        {
            return View();
        }
    }
}
