using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneContacts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        UserManager userManager = new UserManager(new EfUserDal());

        [HttpPost]
        public IActionResult Index()
        {
            //userManager.TAdd(u);
            //return RedirectToAction("Index", "Privacy");
            return View();
        } 

        public IActionResult Privacy()
        {
            var values = userManager.TGetList();
            return View(values);
        }
        
     
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var values = userManager.TGetList();
            return View(values);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
