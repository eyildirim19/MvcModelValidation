using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcModelValidation.Controllers
{
    using Models;
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici model)
        {
            bool durum = ModelState.IsValid; // IsValid propert'si modelin validate durumunu kontrol eder...

            if (ModelState.IsValid) // doğrulama yapılmış
            {
                // gerekli form işlemi yapılır
            }
            else
            {
                ModelState.AddModelError("error", "Lütfen belirtilen alanları doldurunuz...");
            }
            return View();
        }
    }
}
